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
        /// <summary>Used to specify the geometric blend mode for all Direct2D primitives.</summary>
        /// <remarks>
        /// <para><h3><a id = "Blend_modes"></a><a id = "blend_modes"></a><a id = "BLEND_MODES"></a>Blend modes</h3> For aliased rendering (except for MIN mode), the output value O is computed by linearly interpolating the value <i>blend(S, D)</i> with the destination pixel value, based on the amount that the primitive covers the destination pixel.</para>
        /// <para>The table here shows the primitive blend modes for both aliased and antialiased blending. The equations listed in the table  use these elements: </para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ne-d2d1_1-d2d1_primitive_blend#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_PRIMITIVE_BLEND : uint
        {
            /// <summary>The standard source-over-destination blend mode.</summary>
            D2D1_PRIMITIVE_BLEND_SOURCE_OVER = 0U,
            /// <summary>The source is copied to the destination; the destination pixels are ignored.</summary>
            D2D1_PRIMITIVE_BLEND_COPY = 1U,
            /// <summary>The resulting pixel values use the minimum of the source and destination pixel values. Available in Windows 8 and later.</summary>
            D2D1_PRIMITIVE_BLEND_MIN = 2U,
            /// <summary>The resulting pixel values are the sum of the source and destination pixel values. Available in Windows 8 and later.</summary>
            D2D1_PRIMITIVE_BLEND_ADD = 3U,
            /// <summary>
            /// <para>The resulting pixel values use the maximum of the source and destination pixel values. Available in Windows 10 and later (set using <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_3/nf-d2d1_3-id2d1commandsink4-setprimitiveblend2">ID21CommandSink4::SetPrimitiveBlend2</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ne-d2d1_1-d2d1_primitive_blend#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_PRIMITIVE_BLEND_MAX = 4U,
            /// <summary></summary>
            D2D1_PRIMITIVE_BLEND_FORCE_DWORD = 4294967295U,
        }
    }
}