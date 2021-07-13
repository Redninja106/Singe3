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
        /// <summary>The meetOrSlice portion of the SVG preserveAspectRatio attribute.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/ne-d2d1svg-d2d1_svg_aspect_scaling">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_SVG_ASPECT_SCALING : uint
        {
            /// <summary>Scale the viewBox up as much as possible such that the entire viewBox is visible within the viewport.</summary>
            D2D1_SVG_ASPECT_SCALING_MEET = 0U,
            /// <summary>
            /// <para>Scale the viewBox down as much as possible such that the entire viewport is covered by the viewBox.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/ne-d2d1svg-d2d1_svg_aspect_scaling#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_SVG_ASPECT_SCALING_SLICE = 1U,
            /// <summary></summary>
            D2D1_SVG_ASPECT_SCALING_FORCE_DWORD = 4294967295U,
        }
    }
}