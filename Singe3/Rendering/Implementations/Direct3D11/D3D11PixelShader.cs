using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal unsafe class D3D11PixelShader : D3D11Shader<ID3D11PixelShader>, IPixelShader
    {
        public D3D11PixelShader(D3D11Renderer renderer, string source) : base(renderer, source, "ps_4_0")
        {
        }

        private protected override ID3D11PixelShader* CreateShader(byte[] compiledBytecode)
        {
            ID3D11PixelShader* pShader;

            var bytecode = this.GetBytecode();
            fixed (byte* pBytecode = bytecode)
                this.Renderer.GetDevice()->CreatePixelShader((void*)pBytecode, (nuint)bytecode.Length, null, &pShader);

            return pShader;
        }
    }
}
