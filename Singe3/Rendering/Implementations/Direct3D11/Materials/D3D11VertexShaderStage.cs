﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;

namespace Singe3.Rendering.Implementations.Direct3D11.Materials
{
    internal unsafe class D3D11VertexShaderStage : D3D11MaterialShaderStage<IVertexShader>
    {
        internal D3D11VertexShaderStage(D3D11Renderer renderer) : base(renderer)
        {
        }

        internal override void Apply()
        {
            var context = this.renderer.GetContext();

            var shader = (D3D11VertexShader)this.GetShader();
            context->VSSetShader(shader.GetShader(), null, 0);

            if(this.samplers != null)
                fixed (ID3D11SamplerState** ppSamplers = this.samplers)
                    context->VSSetSamplers(0, (uint)this.samplers.Length, ppSamplers);

            if (this.resourceViews != null)
                fixed (ID3D11ShaderResourceView** ppResourceViews = this.resourceViews)
                    context->VSSetShaderResources(0, (uint)this.resourceViews.Length, ppResourceViews);

            if (this.constantBuffers != null)
                fixed (ID3D11Buffer** ppConstantBuffers = this.constantBuffers)
                    context->VSSetConstantBuffers(0, (uint)this.constantBuffers.Length, ppConstantBuffers);

            context->IASetInputLayout(shader.GetInputLayout());
        }

        internal override void Remove()
        {
            var context = this.renderer.GetContext();

            context->VSSetShader(null, null, 0);

            uint len = (uint)renderer.Info.MaxTextureCount;
            var pSamplers = new ID3D11SamplerState*[renderer.Info.MaxTextureCount];
            fixed (ID3D11SamplerState** ppSamplers = pSamplers)
                context->VSSetSamplers(0, len, ppSamplers);

            len = (uint)renderer.Info.MaxTextureCount;
            var pConstantBuffers = new ID3D11Buffer*[renderer.Info.MaxTextureCount];
            fixed (ID3D11Buffer** ppConstantBuffers = pConstantBuffers)
                context->VSSetConstantBuffers(0, len, ppConstantBuffers);

            context->IASetInputLayout(null);
        }

        public override void SetTexture(int index, Texture value)
        {
            base.SetTexture(index, value);

            var context = this.renderer.GetContext();

            if (this.Material.IsApplied)
            {
                fixed (ID3D11SamplerState** ppSampler = &samplers[index])
                    context->VSSetSamplers((uint)index, 1, ppSampler);
                fixed (ID3D11ShaderResourceView** ppResource = &resourceViews[index])
                    context->VSSetShaderResources((uint)index, 1, ppResource);
            }
        }

        public override void SetConstantBuffer<TType>(int index, TType value)
        {
            base.SetConstantBuffer(index, value);

            var context = this.renderer.GetContext();

            if (this.Material.IsApplied)
            {
                fixed (ID3D11Buffer** ppBuffer = &this.constantBuffers[index])
                    context->VSSetConstantBuffers((uint)index, 1, ppBuffer);
            }
        }

        public override void Set(IVertexShader shader)
        {
            base.Set(shader);

            var context = this.renderer.GetContext();
            if (this.Material.IsApplied)
            {
                var s = (D3D11VertexShader)this.GetShader();
                context->VSSetShader(s.GetShader(), null, 0);
            }
        }
    }
}