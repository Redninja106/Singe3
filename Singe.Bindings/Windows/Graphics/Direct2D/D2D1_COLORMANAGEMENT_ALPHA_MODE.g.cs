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
        /// <summary>Indicates how the Color management effect should interpret alpha data that is contained in the input image.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_alpha_mode">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_COLORMANAGEMENT_ALPHA_MODE : uint
        {
            /// <summary>The effect assumes the alpha mode is premultiplied.</summary>
            D2D1_COLORMANAGEMENT_ALPHA_MODE_PREMULTIPLIED = 1U,
            /// <summary>The effect assumes the alpha mode is straight.</summary>
            D2D1_COLORMANAGEMENT_ALPHA_MODE_STRAIGHT = 2U,
            /// <summary></summary>
            D2D1_COLORMANAGEMENT_ALPHA_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}