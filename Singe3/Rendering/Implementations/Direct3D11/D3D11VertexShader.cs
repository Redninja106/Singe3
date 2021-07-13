using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32.Graphics.Dxgi;
using Windows.Win32.System.SystemServices;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal sealed unsafe class D3D11VertexShader : D3D11Shader<ID3D11VertexShader>, IVertexShader
    {
        private readonly ID3D11InputLayout* pInputLayout;

        public D3D11VertexShader(D3D11Renderer renderer, string source) : base(renderer, source, "vs_4_0")
        {
            SetExplicitVertexLayout(null);
        }

        public void SetExplicitVertexLayout(VertexLayoutElement[] layout)
        {
            if (pInputLayout != null)
                pInputLayout->Release();

            D3D11_INPUT_ELEMENT_DESC[] elems;

            IntPtr[] unmanagedStrings = null;
            if (layout == null)
            {
                var reflector = (D3D11ShaderReflector)this.GetReflector();
                elems = reflector.GetInputLayoutDesc();
            }
            else
            {
                elems = ConvertVertexLayout(layout, out unmanagedStrings);
            }

            var bytecode = this.GetBytecode();
            fixed (D3D11_INPUT_ELEMENT_DESC* pDescs = elems)
                fixed (ID3D11InputLayout** ppInputLayout = &pInputLayout)
                    fixed (byte* pBytecode = bytecode)
                        Renderer.GetDevice()->CreateInputLayout(pDescs, (uint)elems.Length, pBytecode, (uint)bytecode.Length, ppInputLayout);
            
            if (unmanagedStrings != null)
                FreeUnmanagedStrings(unmanagedStrings);
        }

        internal ID3D11InputLayout* GetInputLayout()
        {
            return this.pInputLayout;
        }

        private protected override ID3D11VertexShader* CreateShader(byte[] compiledBytecode)
        {
            ID3D11VertexShader* pShader;
            
            var bytecode = this.GetBytecode();
            fixed (byte* pBytecode = bytecode)
                this.Renderer.GetDevice()->CreateVertexShader((void*)pBytecode, (nuint)bytecode.Length, null, &pShader);
            
            return pShader;
        }

        bool IVertexShader.CheckValidVertex<T>()
        {
            return true;
        }
        private static D3D11_INPUT_ELEMENT_DESC[] ConvertVertexLayout(VertexLayoutElement[] layout, out IntPtr[] unmanagedStrings)
        {
            var result = new D3D11_INPUT_ELEMENT_DESC[layout.Length];
            unmanagedStrings = new IntPtr[layout.Length];
            for (int i = 0; i < result.Length; i++)
            {
                string formatString = "DXGI_FORMAT_";

                if (layout[i].ComponentCount >= 1) formatString += "R" + layout[i].BytesPerElement;
                if (layout[i].ComponentCount >= 2) formatString += "G" + layout[i].BytesPerElement;
                if (layout[i].ComponentCount >= 3) formatString += "B" + layout[i].BytesPerElement;
                if (layout[i].ComponentCount >= 4) formatString += "A" + layout[i].BytesPerElement;
                formatString += '_' + layout[i].Type.ToString().ToUpper();

                if (!Enum.TryParse(formatString, true, out DXGI_FORMAT format))
                {
                    format = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;
                }

                var semantic = layout[i].Semantic;
                var pSemantic = (byte*)(unmanagedStrings[i] = Marshal.StringToHGlobalAnsi(semantic));
                result[i] = new D3D11_INPUT_ELEMENT_DESC { SemanticName = new PCSTR(pSemantic), SemanticIndex = (uint)layout[i].SemanticIndex, Format = format, AlignedByteOffset = Constants.D3D11_APPEND_ALIGNED_ELEMENT };
            }

            return result;
        }

        private static void FreeUnmanagedStrings(IntPtr[] unmanagedStrings)
        {
            foreach (var str in unmanagedStrings)
            {
                Marshal.FreeHGlobal(str);
            }
        }
    }
}
