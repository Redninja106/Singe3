using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Rendering
{
    public abstract class GraphicsResource : IDisposable
    {
        public Renderer Renderer { get; private set; }

        private bool disposedValue;

        public GraphicsResource(Renderer renderer)
        {
            this.Renderer = renderer;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        ~GraphicsResource()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
