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
        /// <summary>Identifiers for properties of the Sepia effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_2/ne-d2d1effects_2-d2d1_sepia_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_SEPIA_PROP : uint
        {
            /// <summary>The D2D1_SEPIA_PROP_INTENSITY property is a float value indicating the intesity of the sepia effect. The allowed range is 0.0 to 1.0.  The default value is 0.5.</summary>
            D2D1_SEPIA_PROP_INTENSITY = 0U,
            /// <summary>
            /// <para>The D2D1_SEPIA_PROP_ALPHA_MODE property is a <a href = "https://docs.microsoft.com/windows/desktop/api/dcommon/ne-dcommon-d2d1_alpha_mode">D2D1_ALPHA_MODE</a> enumeration value indicating the alpha mode of the input file. See the About Alpha Modes section of the <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/supported-pixel-formats-and-alpha-modes">Supported Pixel Formats and Alpha Modes</a> topic for additional information.. The default value is D2D1_ALPHA_MODE_PREMULTIPLIED.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_2/ne-d2d1effects_2-d2d1_sepia_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_SEPIA_PROP_ALPHA_MODE = 1U,
            /// <summary></summary>
            D2D1_SEPIA_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}