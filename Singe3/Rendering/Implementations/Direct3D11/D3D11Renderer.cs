using Singe3.Rendering.Implementations.Direct3D11.Materials;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32;
using System.Numerics;
using Windows.Win32.UI.DisplayDevices;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal sealed unsafe class D3D11Renderer : Renderer
    {
        private readonly ID3D11Device* device;
        private readonly ID3D11DeviceContext* immediateContext;
        private readonly ID3D11BlendState* blendState;
        private readonly ID3D11DepthStencilState* dsState;
        private readonly ID3D11RasterizerState* rsState;
        D3D11Texture currentRenderTarget;
        Material currentMaterial;
        IRenderingOutput output;

        public D3D11Renderer() : base(GraphicsApi.Direct3D11)
        {
            fixed (ID3D11Device** dev = &device)
                fixed (ID3D11DeviceContext** cxt = &immediateContext)
                    D3D11.D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, default, D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT | D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG, null, 0, Constants.D3D11_SDK_VERSION, dev, null, cxt);
            
            var blendDesc = new D3D11_BLEND_DESC();
            blendDesc.RenderTarget._0.BlendOpAlpha = D3D11_BLEND_OP.D3D11_BLEND_OP_ADD;
            blendDesc.RenderTarget._0.RenderTargetWriteMask = (byte)D3D11_DEPTH_WRITE_MASK.D3D11_DEPTH_WRITE_MASK_ALL;

            fixed (ID3D11BlendState** blnd = &blendState)
                device->CreateBlendState(&blendDesc, blnd);

            var rsDesc = new D3D11_RASTERIZER_DESC
            {
                CullMode = D3D11_CULL_MODE.D3D11_CULL_NONE,
                FillMode = D3D11_FILL_MODE.D3D11_FILL_SOLID,
                DepthClipEnable = false
            };
            fixed (ID3D11RasterizerState** rs = &rsState)
                device->CreateRasterizerState(&rsDesc, rs).ThrowOnFailure();
            
            var dsDesc = new D3D11_DEPTH_STENCIL_DESC();

            fixed (ID3D11DepthStencilState** ds = &dsState)
                device->CreateDepthStencilState(&dsDesc, ds).ThrowOnFailure();
        }

        public override void Clear(Color color)
        {
            Vector4 col = Utility.ColorToVectorRGBA(color);
            immediateContext->ClearRenderTargetView(currentRenderTarget.GetRenderTargetView(), (float*)&col);
        }

        public override Material CreateMaterial()
        {
            return new Material(this, new D3D11VertexShaderStage(this), new D3D11PixelShaderStage(this));
        }

        public override Mesh CreateMesh<T>(T[] vertices, uint[] indices)
        {
            var result = new D3D11Mesh(this);
            result.CreateVertexBuffer(vertices);
            result.CreateIndexBuffer(indices);
            result.SetPrimitiveType(PrimitiveType.TriangleList);
            return result;
        }

        public override IPixelShader CreatePixelShader(string source)
        {
            return new D3D11PixelShader(this, source);
        }

        public override Texture CreateTexture<T>(int width, int height, DataFormat format, T[] data)
        {
            var tex = new D3D11Texture(this, width, height, format);
            tex.SetData(data);
            return tex;
        }

        public override IVertexShader CreateVertexShader(string source)
        {
            return new D3D11VertexShader(this, source);
        }

        protected override void Dispose(bool disposing)
        {
            this.device->Release();
            this.immediateContext->Release();
        }

        public override unsafe void DrawMesh(Mesh mesh)
        {
            if (currentMaterial == null)
                throw new Exception("There is no material set!");

            immediateContext->RSSetState(this.rsState);
            immediateContext->OMSetDepthStencilState(this.dsState, 0);
            immediateContext->OMSetBlendState(this.blendState, (float*)null, int.MaxValue);

            var d3d11Mesh = (D3D11Mesh)mesh;
            d3d11Mesh.Draw();
        }

        public void SetState()
        {
            immediateContext->RSSetState(this.rsState);
            immediateContext->OMSetDepthStencilState(this.dsState, 0);
            immediateContext->OMSetBlendState(this.blendState, (float*)null, int.MaxValue);
        }

        public ID3D11Device* GetDevice()
        {
            return this.device;
        }

        public ID3D11DeviceContext* GetContext()
        {
            return this.immediateContext;
        }

        public override void SetMaterial(Material material)
        {
            this.currentMaterial?.Remove();
            this.currentMaterial = material;
            this.currentMaterial.Apply();
        }

        public override void SetRenderTarget(Texture texture)
        {
            this.currentRenderTarget = (D3D11Texture)texture;
            ID3D11RenderTargetView* pRtv = currentRenderTarget.GetRenderTargetView();
            this.immediateContext->OMSetRenderTargets(1, &pRtv, null);
        }

        protected override void SetRenderingOutput(IRenderingOutput output)
        {
            this.output = output;
        }

        public override IRenderingOutput GetRenderingOutput()
        {
            return this.output;
        }

        private protected override GraphicsInformation GetInfo()
        {
            var info = new GraphicsInformation
            {

                // hardcode these values for now. later, use a different interop lib and actually to feature level checking and stuff
                MaxConstantBufferCount = 8,
                MaxTextureCount = 8
            };

            return info;
        }

        public override void SetClippingRectangles(Rectangle[] rects)
        {
            fixed (Rectangle* pRects = rects)
                immediateContext->RSSetScissorRects((uint)rects.Length, (RECT*)pRects);
        }

        public override void ClearState()
        {
        }

        public override Texture GetWindowRenderTarget()
        {
            return this.output.GetRenderTarget();
        }

        public override void SetDepthStencilRenderTarget()
        {
            throw new NotImplementedException();
        }

        public override void SetViewport(float x, float y, float w, float h)
        {
            var vp = new D3D11_VIEWPORT { TopLeftX = x, TopLeftY = y, Width = w, Height = h, MaxDepth = 1, MinDepth = 0 };
            immediateContext->RSSetViewports(1, &vp);
        }
    }
}
