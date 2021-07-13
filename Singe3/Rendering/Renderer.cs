using Singe3.Rendering.Implementations.Direct3D11;
using Singe3.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Singe3.Rendering
{
    [SingleSubsystem]
    [CallAfter(CoreSubsystem.Platform)]
    public abstract class Renderer : Subsystem
    {
        public Renderer(GraphicsApi api)
        {
            this.Api = api;
            this.Info = GetInfo();
        }

        public GraphicsInformation Info { get; }
        public GraphicsApi Api { get; }

        private protected abstract GraphicsInformation GetInfo();
        public abstract IRenderingOutput GetRenderingOutput();

        public abstract void Clear(Color color);
        
        public abstract Texture GetWindowRenderTarget();
        
        public abstract void SetMaterial(Material material);
        public abstract void DrawMesh(Mesh mesh);
        
        // RS
        public abstract void SetClippingRectangles(Rectangle[] rects);
        public abstract void SetViewport(float x, float y, float w, float h);

        // OM
        public abstract void SetRenderTarget(Texture texture);
        public abstract void SetDepthStencilRenderTarget();

        public abstract void ClearState();

        public abstract Mesh CreateMesh<T>(T[] vertices, uint[] indices) where T : unmanaged;
        public abstract Material CreateMaterial();
        public abstract IVertexShader CreateVertexShader(string source);
        public abstract IPixelShader CreatePixelShader(string source);
        public abstract Texture CreateTexture<T>(int width, int height, DataFormat format, T[] data) where T : unmanaged;
        protected abstract void SetRenderingOutput(IRenderingOutput output);

        public override void OnInitialize(ApplicationContext context)
        {
            if (context.Platform == null)
            {
                context.Debug?.Warn(this, "No Platform subsystem is present.");
                return;
            }

            var output = context.Platform.CreateOutput(this);

            this.SetRenderingOutput(output);


            base.OnInitialize(context);
        }

        private void Context_AfterDraw(object sender, EventArgs e)
        {
            GetRenderingOutput().Present(0);
        }

        private void Context_BeforeDraw(object sender, EventArgs e)
        {
            ClearState();
            SetRenderTarget(GetWindowRenderTarget());
        }

        public static Renderer Create(GraphicsApi api)
        {
            switch (api)
            {
                case GraphicsApi.Direct3D11:
                    return new D3D11Renderer();
                case GraphicsApi.Direct3D12:
                case GraphicsApi.Vulkan:
                case GraphicsApi.OpenGL:
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
