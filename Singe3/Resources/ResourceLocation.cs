using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources
{
    /// <summary>
    /// Represents different storage systems that files can be located in.
    /// </summary>
    public enum ResourceLocation
    {
        /// <summary>
        /// The resource location is not known and needs to be inferred.
        /// </summary>
        Unknown,
        /// <summary>
        /// The resource is an embedded resource in the assembly.
        /// </summary>
        EmbeddedResource,
        /// <summary>
        /// The resource is a file located within a directory or subdirectory of this application.
        /// </summary>
        FileSystem,
    }
}
