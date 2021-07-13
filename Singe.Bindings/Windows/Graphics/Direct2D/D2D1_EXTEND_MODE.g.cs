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
        /// <summary>Specifies how a brush paints areas outside of its normal content area.</summary>
        /// <remarks>
        /// <para>For an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmapbrush">ID2D1BitmapBrush</a>, the brush's content is the brush's bitmap. For an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1lineargradientbrush">ID2D1LinearGradientBrush</a>, the brush's content area is the gradient axis. For an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1radialgradientbrush">ID2D1RadialGradientBrush</a>, the brush's content is the area within the gradient ellipse.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ne-d2d1-d2d1_extend_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_EXTEND_MODE : uint
        {
            /// <summary>Repeat the edge pixels of the brush's content for all regions outside the normal content area.</summary>
            D2D1_EXTEND_MODE_CLAMP = 0U,
            /// <summary>Repeat the brush's content.</summary>
            D2D1_EXTEND_MODE_WRAP = 1U,
            /// <summary>The same as D2D1_EXTEND_MODE_WRAP, except that alternate tiles of the brush's content are flipped. (The brush's normal content is drawn untransformed.)</summary>
            D2D1_EXTEND_MODE_MIRROR = 2U,
            /// <summary></summary>
            D2D1_EXTEND_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}