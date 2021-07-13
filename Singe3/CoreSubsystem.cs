using System;
using Singe3.Rendering;
using Singe3.Platforms;
using Singe3.Resources;
using Singe3.Debugging;

namespace Singe3
{
    /// <summary>
    /// Represents the core subsystems. Each subsystem does not require any other subsystem to be present on an <see cref="ApplicationContext"/>, but some functionality might. 
    /// <para>These flags can be combined using a logical OR to represent multiple core subsystems. <see cref="Enum.HasFlag(Enum)"/> can be used to determine if a flag is present. </para>
    /// </summary>
    [Flags]
    public enum CoreSubsystem
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,
        /// <summary>
        /// The <see cref="Platforms.Platform"/> subsystem.
        /// </summary>
        Platform = 1 << 0,
        /// <summary>
        /// The <see cref="Rendering.Renderer"/> subsystem.
        /// </summary>
        Renderer = 1 << 1,
        /// <summary>
        /// The <see cref="Resources.ResourceLoader"/> subsystem.
        /// </summary>
        ResourceLoader = 1 << 2,
        /// <summary>
        /// The <see cref="Debugging.GUI"/> subsystem.
        /// </summary>
        GUI = 1 << 3,
        /// <summary>
        /// The <see cref="Debugging.Debug"/> subsystem.
        /// </summary>
        Debug = 1 << 4,
        /// <summary>
        /// Represents all of the subsystems.
        /// </summary>
        All = Platform | Renderer | ResourceLoader | GUI | Debug,
    }
}
