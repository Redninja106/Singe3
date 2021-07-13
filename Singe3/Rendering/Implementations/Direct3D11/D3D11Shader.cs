using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32.System.Com;
using Windows.Win32;
using Windows.Win32.System.SystemServices;
using Singe3.Internal.Interop;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal abstract unsafe class D3D11Shader<T> : IShader, IDisposable where T : unmanaged
    {
        private protected D3D11Renderer Renderer { get; private set; }

        private readonly D3D11ShaderReflector reflector;
        private readonly T* shader;
        private readonly byte[] bytecode;

        private protected abstract T* CreateShader(byte[] compiledBytecode);

        public D3D11Shader(D3D11Renderer renderer, string source, string hlslProfile)
        {
            this.Renderer = renderer;
            HRESULT hr;

            ID3DBlob* compileResult;
            ID3DBlob* compileError;

            byte[] src = Encoding.ASCII.GetBytes(source);
            byte[] entry = Encoding.ASCII.GetBytes("main");
            byte[] target = Encoding.ASCII.GetBytes(hlslProfile);
            fixed (byte* pSrc = src, pEntry = entry, pTarget = target)
                hr = D3DCompiler_47.D3DCompile(pSrc, (nuint)src.Length, default, (D3D_SHADER_MACRO*)null, null, new PCSTR(pEntry), new PCSTR(pTarget), 0, 0, &compileResult, &compileError);
            
            if (hr.Failed)
            {
                throw new Exception(Encoding.ASCII.GetString(new ReadOnlySpan<byte>(compileError->GetBufferPointer(), (int)compileError->GetBufferSize())));
            }

            bytecode = new Span<byte>(compileResult->GetBufferPointer(), (int)compileResult->GetBufferSize()).ToArray();

            ID3D11ShaderReflection* reflection;
            hr = D3DCompiler_47.D3DReflect(compileResult->GetBufferPointer(), compileResult->GetBufferSize(), InteropUtils.GetGuidPtr<ID3D11ShaderReflection>(), (void**)&reflection);

            if (hr.Failed)
                throw new Exception(hr.Value.ToString("x"));

            this.reflector = new D3D11ShaderReflector(this.Renderer, reflection);

            if (compileResult != null)
                compileResult->Release();
            if (compileError != null)
                compileError->Release();

            this.shader = this.CreateShader(this.bytecode);
        }

        public ShaderReflection GetReflector()
        {
            return this.reflector;
        }

        public T* GetShader()
        {
            return this.shader;
        }

        public byte[] GetBytecode()
        {
            return bytecode;
        }

        public void Dispose()
        {
            ((IUnknown*)shader)->Release();
            reflector.Dispose();
        }
    }
}
