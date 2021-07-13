using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;
using Singe3.Internal.Interop;
using Windows.Win32.Graphics.Dxgi;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal sealed unsafe class D3D11Texture : Texture, IDisposable
    {
        private readonly D3D11Renderer renderer;
        private ID3D11Texture2D* pD3D11Texture;
        private ID3D11RenderTargetView* pRenderTargetView;
        private ID3D11SamplerState* pSamplerState;
        private ID3D11ShaderResourceView* pShaderResourceView;

        public override int Width => this.width;
        public override int Height => this.height;
        public override int BytesPerPixel => this.bpp;

        private int width;
        private int height;
        private int bpp;

        public D3D11Texture(D3D11Renderer renderer, int width, int height, DataFormat format) : this(renderer, CreateTexture(renderer, width, height, format))
        {
            
        }

        private static ID3D11Texture2D* CreateTexture(D3D11Renderer renderer, int width, int height, DataFormat format)
        {
            ID3D11Texture2D* pResult;
            var desc = new D3D11_TEXTURE2D_DESC
            {
                Format = format.ToD3D11(),
                Width = (uint)width,
                Height = (uint)height,
                MipLevels = 1,
                Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT,
                BindFlags = (uint)(D3D11_BIND_FLAG.D3D11_BIND_RENDER_TARGET | D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE),
                SampleDesc = new DXGI_SAMPLE_DESC() { Count = 1, Quality = 0 },
                ArraySize = 1
            };

            renderer.GetDevice()->CreateTexture2D(&desc, null, &pResult);

            return pResult;
        }

        public D3D11Texture(D3D11Renderer renderer, ID3D11Texture2D* texture) : base(renderer)
        {
            this.renderer = renderer;
            SetInternalTexture(texture);
        }

        public void SetInternalTexture(ID3D11Texture2D* tex)
        {
            if (pD3D11Texture != null)
            {
                if(pD3D11Texture != null)
                    pD3D11Texture->Release();
                pD3D11Texture = null;
            }

            Reset();

            if (pShaderResourceView != null)
                pShaderResourceView->Release();

            pD3D11Texture = tex;
            
            if (tex == null)
                return;

            var desc = new D3D11_TEXTURE2D_DESC();
            pD3D11Texture->GetDesc(&desc);

            this.width = (int)desc.Width;
            this.height = (int)desc.Height;
            this.bpp = desc.Format.BytesPerPixel();
        }

        public override void Dispose()
        {
            Reset();
            pD3D11Texture->Release();
            base.Dispose();
        }

        public ID3D11RenderTargetView* GetRenderTargetView()
        {
            if (pRenderTargetView == null)
            {
                D3D11_TEXTURE2D_DESC textureDesc;
                pD3D11Texture->GetDesc(&textureDesc);

                var desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    ViewDimension = D3D11_RTV_DIMENSION.D3D11_RTV_DIMENSION_TEXTURE2D,
                    Format = textureDesc.Format
                };
                desc.Anonymous.Texture2D = new D3D11_TEX2D_RTV()
                {
                    MipSlice = 0,
                };

                fixed (ID3D11RenderTargetView** ppRtv = &pRenderTargetView)
                    renderer.GetDevice()->CreateRenderTargetView((ID3D11Resource*)pD3D11Texture, &desc, ppRtv);
            }

            return pRenderTargetView;
        }

        public ID3D11SamplerState* GetSampler()
        {
            if (pSamplerState == null)
            {
                var desc = new D3D11_SAMPLER_DESC
                {
                    Filter = D3D11_FILTER.D3D11_FILTER_ANISOTROPIC
                };
                desc.AddressU = desc.AddressV = desc.AddressW = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_WRAP;

                fixed (ID3D11SamplerState** ppShaderResourceView = &pSamplerState)
                    renderer.GetDevice()->CreateSamplerState(&desc, ppShaderResourceView);
            }

            return pSamplerState;
        }

        public ID3D11ShaderResourceView* GetShaderResourceView()
        {
            if (pShaderResourceView == null)
            {
                D3D11_TEXTURE2D_DESC textureDesc;
                pD3D11Texture->GetDesc(&textureDesc);

                var desc = new D3D11_SHADER_RESOURCE_VIEW_DESC
                {
                    ViewDimension = D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2D,
                    Format = textureDesc.Format
                };
                desc.Anonymous.Texture2D = new D3D11_TEX2D_SRV()
                {
                    MipLevels = 1,
                    MostDetailedMip = 0,
                };

                fixed (ID3D11ShaderResourceView** ppShaderResourceView = &pShaderResourceView)
                    renderer.GetDevice()->CreateShaderResourceView((ID3D11Resource*)pD3D11Texture, &desc, ppShaderResourceView);
            }

            return pShaderResourceView;
        }

        public void Reset()
        {
            if(pRenderTargetView != null)
                pRenderTargetView->Release();
            pRenderTargetView = null;

            if(pShaderResourceView != null)
                pShaderResourceView->Release();
            pShaderResourceView = null;

            if(pSamplerState != null)
                pSamplerState->Release();
            pSamplerState = null;
        }

        public override void SetData<T>(T[] data)
        {
            fixed(T* pData = data)
                renderer.GetContext()->UpdateSubresource((ID3D11Resource*)pD3D11Texture, 0, (D3D11_BOX*)null, pData, (uint)(bpp * width), 0);
        }
    }
}
