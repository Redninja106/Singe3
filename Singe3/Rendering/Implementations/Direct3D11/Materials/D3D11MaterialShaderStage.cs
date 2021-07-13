using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.Graphics.Direct3D11;

namespace Singe3.Rendering.Implementations.Direct3D11.Materials
{
    internal abstract unsafe class D3D11MaterialShaderStage<T> : MaterialShaderStage<T> where T : IShader
    {
        protected D3D11Renderer renderer;

        protected ID3D11Buffer*[] constantBuffers;
        ValueType[] constantBuffersData;

        protected ID3D11SamplerState*[] samplers;
        protected ID3D11ShaderResourceView*[] resourceViews;
        D3D11Texture[] textures;

        T shader;

        internal D3D11MaterialShaderStage(D3D11Renderer renderer)
        {
            this.renderer = renderer;
        }

        public override unsafe void SetConstantBuffer<TType>(int index, TType value)
        {
            if (constantBuffers == null)
            {
                constantBuffers =  new ID3D11Buffer*[renderer.Info.MaxConstantBufferCount];
                constantBuffersData = new ValueType[renderer.Info.MaxConstantBufferCount];
            }

            if (constantBuffers[index] != null)
            {
                D3D11_BUFFER_DESC bufferDesc;
                constantBuffers[index]->GetDesc(&bufferDesc);

                if (bufferDesc.ByteWidth == sizeof(TType)) 
                {
                    UpdateConstantBuffer(constantBuffers[index], value);
                    constantBuffersData[index] = value;
                    return;
                }

                constantBuffers[index]->Release();
            }

            constantBuffers[index] = CreateConstantBuffer(value);

            constantBuffersData[index] = value;
        }

        public override TData GetConstantBuffer<TData>(int index)
        {
            if (constantBuffers == null)
            {
                constantBuffers = new ID3D11Buffer*[renderer.Info.MaxConstantBufferCount];
                constantBuffersData = new ValueType[renderer.Info.MaxConstantBufferCount];
            }

            return (TData)constantBuffersData[index];
        }

        public override void SetTexture(int index, Texture value)
        {
            if (samplers == null)
            {
                samplers = new ID3D11SamplerState*[renderer.Info.MaxTextureCount];
                textures = new D3D11Texture[renderer.Info.MaxTextureCount];
                resourceViews = new ID3D11ShaderResourceView*[renderer.Info.MaxTextureCount];
            }

            textures[index] = (D3D11Texture)value;
            samplers[index] = textures[index].GetSampler();
            resourceViews[index] = textures[index].GetShaderResourceView();
        }

        public override Texture GetTexture(int index)
        {
            if (samplers == null)
            {
                samplers = new ID3D11SamplerState*[renderer.Info.MaxTextureCount];
                textures = new D3D11Texture[renderer.Info.MaxTextureCount];
                resourceViews = new ID3D11ShaderResourceView*[renderer.Info.MaxTextureCount];
            }

            return textures[index];
        }

        public override void Set(T shader)
        {
            this.shader = shader;
        }

        public override T GetShader()
        {
            return this.shader;
        }

        private unsafe ID3D11Buffer* CreateConstantBuffer<TType>(TType initialValue) where TType : unmanaged
        {
            ID3D11Buffer* pResult;

            var desc = new D3D11_BUFFER_DESC();

            desc.ByteWidth = (uint)sizeof(TType);
            desc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_CONSTANT_BUFFER;
            desc.Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT;

            renderer.GetDevice()->CreateBuffer(&desc, null, &pResult);

            return pResult;
        }

        private void UpdateConstantBuffer<TType>(ID3D11Buffer* buffer, TType value) where TType : unmanaged
        {
            renderer.GetContext()->UpdateSubresource((ID3D11Resource*)buffer, 0, (D3D11_BOX*)null, &value, 0, 0);
        }

        public override void Dispose()
        {
            foreach (var buffer in constantBuffers)
            {
                if (buffer != null)
                    buffer->Release();
            }
        }
    }
}
