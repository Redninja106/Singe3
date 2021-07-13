﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable CS1591, CS1573, CS0465, CS0649, CS8019, CS1570, CS1584, CS1658
namespace Windows.Win32
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using win32 = global::Windows.Win32;

    namespace Graphics.Direct2D
    {
        /// <summary>Describes how a render target is remoted and whether it should be GDI-compatible. This enumeration allows a bitwise combination of its member values.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ne-d2d1-d2d1_render_target_usage">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D2D1_RENDER_TARGET_USAGE : uint
        {
            /// <summary>The render target attempts to use Direct3D command-stream remoting and uses bitmap remoting if stream remoting fails. The render target is not GDI-compatible.</summary>
            D2D1_RENDER_TARGET_USAGE_NONE = 0x00000000,
            /// <summary>The render target renders content locally and sends it to the terminal services client as a bitmap.</summary>
            D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 0x00000001,
            /// <summary>The render target can be used efficiently with GDI.</summary>
            D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 0x00000002,
            /// <summary></summary>
            D2D1_RENDER_TARGET_USAGE_FORCE_DWORD = 0xFFFFFFFF,
        }
    }
}