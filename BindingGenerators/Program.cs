using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BindingGenerators
{
    class Program
    {
        static Dictionary<string, string> extraAssemblies = new Dictionary<string, string>();

        static string framework;

        public static unsafe void Main()
        {
            void* device = null;
            D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, default, D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG, null, 0, D3D11_SDK_VERSION, (ID3D11Device*)&device);

            //DirectX.Run();
            //var paths = new[]
            //{ 
            //    "./Windows.Win32.winmd",
            //};

            //extraAssemblies.Add("Windows.Foundation.UniversalApiContract", "C:\\Program Files (x86)\\Windows Kits\\10\\References\\10.0.19041.0\\Windows.Foundation.UniversalApiContract\\10.0.0.0\\Windows.Foundation.UniversalApiContract.winmd");
            //extraAssemblies.Add("Windows.Foundation.FoundationContract", "C:\\Program Files (x86)\\Windows Kits\\10\\References\\10.0.19041.0\\Windows.Foundation.FoundationContract\\4.0.0.0\\Windows.Foundation.FoundationContract.winmd");

            //var stream = File.OpenRead("./Windows.Win32.winmd");

            //var file = new PEFile("Windows.Win32.winmd", stream);
            //framework = file.Reader.DetectTargetFrameworkId();

            //var settings = new DecompilerSettings(LanguageVersion.Latest);

            //var resolver = new MyAssemblyResolver();
            
            //CSharpDecompiler e = new CSharpDecompiler(file, resolver, settings);
            //ICodeGenerator codeGenerator;
            //var src = e.()

            //File.WriteAllText("./Windows.Win32.cs", src);
            
            //Console.ReadLine();
        }

        class MyAssemblyResolver : IAssemblyResolver
        {
            UniversalAssemblyResolver baseResolver = new UniversalAssemblyResolver(Path.GetFullPath("./Windows.Win32.winmd"), true, framework);

            public PEFile Resolve(IAssemblyReference reference)
            {
                if (extraAssemblies.Keys.Contains(reference.Name))
                    return new PEFile(extraAssemblies[reference.Name]);

                return baseResolver.Resolve(reference);
            }

            public async Task<PEFile> ResolveAsync(IAssemblyReference reference)
            {
                return Resolve(reference);
            }

            public PEFile ResolveModule(PEFile mainModule, string moduleName)
            {
                return baseResolver.ResolveModule(mainModule, moduleName);
            }

            public async Task<PEFile> ResolveModuleAsync(PEFile mainModule, string moduleName)
            {
                return ResolveModule(mainModule, moduleName);
            }
        }
    }
}
