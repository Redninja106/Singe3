using System;
using System.Collections.Generic;
using System.Text;

namespace Singe3.Rendering
{
    public interface IRenderingOutputFactory
    {
        GraphicsApi[] GetSupportedApis();

        IRenderingOutput CreateOutput(Renderer renderer);
    }
}
