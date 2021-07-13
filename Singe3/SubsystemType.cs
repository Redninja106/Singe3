using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    /// <summary>
    /// Represents the possible types of subsystems.
    /// </summary>
    public enum SubsystemType
    {
        Platform,
        Renderer,
        ResourceLoader,
        GUI,
        Debug,
        SceneManager,
        Custom
    }
}
