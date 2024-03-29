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
        /// <summary>Specifies the pixel snapping policy when rendering color bitmap glyphs.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_color_bitmap_glyph_snap_option">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION : uint
        {
            /// <summary>
            /// <para>Color bitmap glyph positions are snapped to the nearest pixel if the bitmap resolution matches that of the device context.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_color_bitmap_glyph_snap_option#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT = 0U,
            /// <summary>Color bitmap glyph positions are not snapped.</summary>
            D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE = 1U,
            /// <summary></summary>
            D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD = 4294967295U,
        }
    }
}