using System;
using System.Collections.Generic;
using System.Text;

namespace Singe3.Rendering
{
    public sealed class GraphicsInformation
    {
        public int MaxConstantBufferCount { get; internal set; }
        public int MaxTextureCount { get; internal set; }
    }
}
