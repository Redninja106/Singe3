using System;
using System.Collections.Generic;
using System.Text;
using Singe3.Debugging;

namespace Singe3.Rendering
{
    public abstract class Texture : GraphicsResource
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract int BytesPerPixel { get; }

        private IntPtr imGuiId;

        public abstract void SetData<T>(T[] data) where T : unmanaged;

        public Texture(Renderer renderer) : base(renderer)
        {
        }

        public IntPtr GetGuiTextureID()
        {
            if(imGuiId == IntPtr.Zero)
            {
                var gui = Renderer.ApplicationContext.GUI;

                if (gui == null)
                    return IntPtr.Zero;

                imGuiId = gui.NewTextureId(this);
            }

            return this.imGuiId;
        }

        public virtual void Dispose()
        {
            var gui = Renderer.ApplicationContext.GUI;

            if (gui != null)
                gui.DestroyTextureId(this.imGuiId);
        }
    }
}
