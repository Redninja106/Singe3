using System;
using System.Collections.Generic;
using System.Text;

namespace Singe3.Rendering
{
    public interface IShader
    {
        ShaderReflection GetReflector();
    }
}
