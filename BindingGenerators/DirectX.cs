using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingGenerators
{
    class DirectX
    {
        public static void Run()
        {
            var files = new[]
            {
                "Common.txt",
                "D3D11.txt",
                "DXGI.cs",
                "D3D.txt",
            };

            foreach (var fileName in files)
            {
                RunOneFile(fileName);
            }
        }

        private static void RunOneFile(string name)
        {
            var reader = new StreamReader(File.OpenRead("./DirectXDefs/" + name));
            name = name.Remove(name.IndexOf('.'));
            var result = ProcessFile(name, reader);
            File.WriteAllText("./../../../../Singe3/Bindings/DirectX/" + name + ".gen.cs", result);
        }

        private static Dictionary<string, (List<CodeSnippetTypeMember> methods, List<CodeSnippetTypeMember> fnPointers)> definedInterfaces = new();

        private static string ProcessFile(string name, StreamReader reader)
        {
            
            bool IsWordPart(char c)
            {
                return char.IsLetterOrDigit(c) || c == '*' || c == '_' || c == ';' || c == '-' || c == '?' || c == '>';
            }

            string ReadWord()
            {
                string result = "";

                char current = (char)reader.Read();
                if (IsWordPart(current))
                    result += current;
                while (!IsWordPart(current))
                {
                    current = (char)reader.Read();
                    if (current.Equals('\uffff') || current == 0x0000)
                        return result; 
                    if (IsWordPart(current))
                        result += current;
                }
                while(IsWordPart(current))
                    if(IsWordPart(current = (char)reader.Read()))
                        result += current;

                if (result == ">>")
                    while (current != '\r' || current != '\n' || current != '\uffff' || current != '\u0000' || current != '<') ;
                        current = (char)reader.Read();

                if (result.StartsWith(">"))
                    return ReadWord();

                return result;
            }

            bool IsMemberCategory(string word)
            {
                word = word.ToLower();
                return word == "constants" || word == "interfaces" || word == "enums" || word == "structs" || word == "methods";
            }

            CSharpCodeProvider provider = new CSharpCodeProvider();

            CodeCompileUnit unit = new CodeCompileUnit();
            
            var nmsp = new CodeNamespace("Singe3.Bindings.DirectX");
            unit.Namespaces.Add(nmsp);

            nmsp.Imports.Add(new CodeNamespaceImport("System"));
            nmsp.Imports.Add(new CodeNamespaceImport("System.Runtime.CompilerServices"));
            nmsp.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));
            nmsp.Imports.Add(new CodeNamespaceImport("static Singe3.Bindings.DirectX.D3D"));
            nmsp.Imports.Add(new CodeNamespaceImport("static Singe3.Bindings.Platforms.Windows"));
            nmsp.Imports.Add(new CodeNamespaceImport("static Singe3.Bindings.DirectX.DXGI"));

            var rootClass = new CodeTypeDeclaration(name);

            rootClass.TypeAttributes = TypeAttributes.Public;
            rootClass.IsClass = true;
            rootClass.Attributes = MemberAttributes.Public | MemberAttributes.Static;

            nmsp.Types.Add(rootClass);

            var word = ReadWord();

            while (!reader.EndOfStream)
            {

                switch (word.ToLower())
                {
                    case "constants":
                        while (!IsMemberCategory(word = ReadWord()))
                        {
                            if (word == "")
                                break;

                            var constMember = new CodeMemberField();

                            constMember.Name = word;
                            constMember.Attributes = MemberAttributes.Public | MemberAttributes.Const;
                            constMember.InitExpression = new CodeSnippetExpression(ReadWord());
                            constMember.Type = new CodeTypeReference(typeof(uint));
                            rootClass.Members.Add(constMember);
                        }
                        break;
                    case "interfaces":
                        while (!IsMemberCategory(word = ReadWord()))
                        {
                            if (word == "")
                                break;

                            var interfaceMember = new CodeTypeDeclaration();
                            var interfaceVtblMember = new CodeTypeDeclaration();
                            var cppClassAttribute = new CodeAttributeDeclaration(new CodeTypeReference(typeof(NativeCppClassAttribute)));

                            interfaceMember.CustomAttributes.Add(cppClassAttribute);
                            interfaceMember.CustomAttributes.Add(new CodeAttributeDeclaration(new CodeTypeReference(typeof(GuidAttribute)), new CodeAttributeArgument(new CodeSnippetExpression( "\""+ word + "\""))));
                            interfaceVtblMember.CustomAttributes.Add(cppClassAttribute);

                            interfaceMember.IsStruct = true;
                            interfaceVtblMember.IsStruct = true;

                            interfaceMember.TypeAttributes = TypeAttributes.Public;
                            interfaceVtblMember.TypeAttributes = TypeAttributes.NestedPrivate;

                            interfaceMember.Members.Add(interfaceVtblMember);

                            word = ReadWord();
                            if (word == ";")
                                break;

                            var typeName = word;
                            interfaceMember.Name = typeName;
                            interfaceVtblMember.Name = word + "Vtbl";

                            interfaceMember.Members.Add(new CodeMemberField(word + "Vtbl*", "lpVtbl"));
                            
                            word = ReadWord();
                            if (word == ";")
                                break;

                            List<CodeSnippetTypeMember> fnPtrs = new();
                            List<CodeSnippetTypeMember> methods = new();

                            var baseType = word;
                            if (baseType.ToLower() != "nothing")
                            {
                                var inheritedMembers = definedInterfaces[baseType];

                                foreach (var item in inheritedMembers.methods)
                                {
                                    interfaceMember.Members.Add(new CodeSnippetTypeMember(item.Text.Replace("[type]", typeName)));
                                    methods.Add(item);
                                }

                                foreach (var item in inheritedMembers.fnPointers)
                                {
                                    interfaceVtblMember.Members.Add(new CodeSnippetTypeMember(item.Text.Replace("[type]", typeName)));
                                    fnPtrs.Add(item);
                                }
                            }

                            //word = ReadWord();
                            if (word == ";")
                                break;

                            bool continueLoop = false;
                            while((word != ";" && word != "" ) || continueLoop)
                            {
                                string methodString = "            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]\r\n            public ";
                                
                                word = ReadWord();
                                if (word == ";" || word != "")
                                {
                                    break;
                                }

                                var returnType = word;

                                word = ReadWord();
                                if (word == ";" || word != "")
                                {
                                    break;
                                }

                                var methodName = word;

                                methodString += $"{returnType} {methodName}(";

                                List<string> names = new List<string>();
                                List<string> types = new List<string>();

                                bool firstParam = true;
                                while(word != "")
                                {
                                    
                                    word = ReadWord();
                                    if (word == ";")
                                    {
                                        continueLoop = true;
                                        break;
                                    }

                                    if (!firstParam)
                                        methodString += ", ";

                                    methodString += word + " ";
                                    types.Add(word);

                                    word = ReadWord();
                                    if (word == ";")
                                    {
                                        continueLoop = true;
                                        break;
                                    }

                                    names.Add(word);
                                    methodString += word;

                                    firstParam = false;
                                }
                                
                                methodString += $") \r\n            {{\r\n                fixed ({typeName}* pThis = &this)\r\n                    {(returnType == "void" ? "" : "return")} this.lpVtbl->{methodName}(pThis";

                                foreach (var n in names)
                                {
                                    methodString += $", {n}";
                                }

                                methodString += ");\r\n            }\r\n";

                                interfaceMember.Members.Add(new CodeSnippetTypeMember(methodString));

                                string fnPtrStr = $"                public delegate* unmanaged[Stdcall]<{typeName}*";

                                foreach (var type in types)
                                {
                                    fnPtrStr += $", {type}";
                                }

                                fnPtrStr += $", {returnType}> {methodName};";

                                interfaceVtblMember.Members.Add(new CodeSnippetTypeMember(fnPtrStr));

                                fnPtrs.Add(new CodeSnippetTypeMember(fnPtrStr.Replace(typeName, "[type]")));

                                methods.Add(new CodeSnippetTypeMember(methodString.Replace(typeName, "[type]")));
                            }

                            definedInterfaces.Add(typeName, (methods, fnPtrs));

                            rootClass.Members.Add(interfaceMember);

                        }
                        break;
                    case "enums":
                        while (!IsMemberCategory(word = ReadWord()))
                        {
                            if (word == "")
                                break;

                            var enumName = word;
                            var enumType = new CodeTypeDeclaration(enumName);
                            enumType.BaseTypes.Add(new CodeTypeReference(typeof(uint)));
                            enumType.IsEnum = true;

                            while (word.ToLower() != ";")
                            {
                                var w1 = ReadWord();
                                if (w1 == ";")
                                    break;
                                var w2 = ReadWord();
                                if (w2 == ";")
                                    break; 
                                var entry = new CodeMemberField(enumName, w1);
                                if (w2 != "?")
                                    entry.InitExpression = new CodeSnippetExpression(w2);
                                else
                                    entry.InitExpression = null;
                                enumType.Members.Add(entry);
                            }

                            rootClass.Members.Add(enumType);
                        }
                        break;
                    case "structs":
                        while (!IsMemberCategory(word = ReadWord()))
                        {
                            if (word == "")
                                break;

                            var structName = word;
                            var structType = new CodeTypeDeclaration(structName);
                            structType.IsStruct = true;
                            structType.Attributes = MemberAttributes.Public;

                            while (word.ToLower() != ";")
                            {
                                var w1 = ReadWord();
                                if (w1 == ";")
                                    break;

                                var w2 = ReadWord();
                                if (w2 == ";")
                                    break;

                                string w3 = null;
                                if (w1.ToLower().StartsWith("fixed_"))
                                {
                                    w1 = w1.Replace("fixed_", "fixed ");
                                    w3 = ReadWord();
                                    if (w3 == ";")
                                        break;
                                }

                                var entry = new CodeSnippetTypeMember($"            public {w1} {w2}{(w3 == null ? "" : $"[{w3}]")};");
                                structType.Members.Add(entry);
                            }

                            rootClass.Members.Add(structType);
                        }
                        break;
                    case "methods":
                        while (!IsMemberCategory(word = ReadWord()))
                        {
                            if (word == "")
                                break;

                            var method = new CodeMemberMethod();

                            method.Attributes = MemberAttributes.Static | MemberAttributes.Final;

                            method.ReturnType = new CodeTypeReference(word);
                            method.Name = ReadWord();

                            while (word != ";" && word != "")
                            {
                                var param = new CodeParameterDeclarationExpression();

                                word = ReadWord();
                                if (word == ";")
                                    break;

                                param.Type = new CodeTypeReference(word);

                                word = ReadWord();
                                if (word == ";")
                                    break;

                                param.Name = word; 

                                method.Parameters.Add(param);
                            }

                            var methodString = $"        [DllImport(\"{name.ToLower()}.dll\")]\r\n        public static extern {provider.GetTypeOutput(method.ReturnType).Replace("@", "")} {method.Name}(";

                            bool firstParam = true; 
                            foreach (CodeParameterDeclarationExpression param in method.Parameters)
                            {
                                if(!firstParam)
                                {
                                    methodString += ", ";
                                }

                                methodString += $"{provider.GetTypeOutput(param.Type).Replace("@", "")} {param.Name}";
                                firstParam = false;
                            }

                            methodString += ");";

                            rootClass.Members.Add(new CodeSnippetTypeMember(methodString));
                        }
                        break;
                    default:
                        break;
                }
            }

            var writer = new StringWriter();

            var options = new CodeGeneratorOptions()
            {
                BlankLinesBetweenMembers = false,
                BracingStyle = "C",
                VerbatimOrder = true,
                IndentString = "    ",
                ElseOnClosing = false,
            };

            provider.GenerateCodeFromCompileUnit(unit, writer, options);

            var result = writer.GetStringBuilder().ToString();
            return result.Insert(result.IndexOf("class"), "unsafe ");
        }
    }
}
