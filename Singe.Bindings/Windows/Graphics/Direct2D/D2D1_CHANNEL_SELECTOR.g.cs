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
        /// <summary>Specifies the color channel the Displacement map effectextracts the intensity from and uses it to spatially displace the image in the X or Y direction.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_channel_selector">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_CHANNEL_SELECTOR : uint
        {
            /// <summary>The effect extracts the intensity output from the red channel.</summary>
            D2D1_CHANNEL_SELECTOR_R = 0U,
            /// <summary>The effect extracts the intensity output from the green channel.</summary>
            D2D1_CHANNEL_SELECTOR_G = 1U,
            /// <summary>The effect extracts the intensity output from the blue channel.</summary>
            D2D1_CHANNEL_SELECTOR_B = 2U,
            /// <summary>The effect extracts the intensity output from the alpha channel.</summary>
            D2D1_CHANNEL_SELECTOR_A = 3U,
            /// <summary></summary>
            D2D1_CHANNEL_SELECTOR_FORCE_DWORD = 4294967295U,
        }
    }
}