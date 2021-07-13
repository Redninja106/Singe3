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
        /// <summary>Describes the pixel format and dpi of a bitmap.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bitmap_properties">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_BITMAP_PROPERTIES
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d1_pixel_format">D2D1_PIXEL_FORMAT</a></b></para>
            /// <para>The bitmap's pixel format and alpha mode.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bitmap_properties#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_PIXEL_FORMAT pixelFormat;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The horizontal dpi of the bitmap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bitmap_properties#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float dpiX;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The vertical dpi of the bitmap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bitmap_properties#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float dpiY;
        }
    }
}