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
        /// <summary>Used to specify the blend mode for all of the Direct2D blending operations.</summary>
        /// <remarks>
        /// <para>The figure here shows an example of each of the modes with images that have an opacity of 1.0 or 0.5.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ne-d2d1_1-d2d1_composite_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_COMPOSITE_MODE : uint
        {
            /// <summary>The standard source-over-destination blend mode.</summary>
            D2D1_COMPOSITE_MODE_SOURCE_OVER = 0U,
            /// <summary>The destination is rendered over the source.</summary>
            D2D1_COMPOSITE_MODE_DESTINATION_OVER = 1U,
            /// <summary>Performs a logical clip of the source pixels against the destination pixels.</summary>
            D2D1_COMPOSITE_MODE_SOURCE_IN = 2U,
            /// <summary>The inverse of the <b>D2D1_COMPOSITE_MODE_SOURCE_IN</b> operation.</summary>
            D2D1_COMPOSITE_MODE_DESTINATION_IN = 3U,
            /// <summary>This is the logical inverse to <b>D2D1_COMPOSITE_MODE_SOURCE_IN</b>.</summary>
            D2D1_COMPOSITE_MODE_SOURCE_OUT = 4U,
            /// <summary>The is the logical inverse to <b>D2D1_COMPOSITE_MODE_DESTINATION_IN</b>.</summary>
            D2D1_COMPOSITE_MODE_DESTINATION_OUT = 5U,
            /// <summary>Writes the source pixels over the destination where there are destination pixels.</summary>
            D2D1_COMPOSITE_MODE_SOURCE_ATOP = 6U,
            /// <summary>The logical inverse of <b>D2D1_COMPOSITE_MODE_SOURCE_ATOP</b>.</summary>
            D2D1_COMPOSITE_MODE_DESTINATION_ATOP = 7U,
            /// <summary>The source is inverted with the destination.</summary>
            D2D1_COMPOSITE_MODE_XOR = 8U,
            /// <summary>The channel components are summed.</summary>
            D2D1_COMPOSITE_MODE_PLUS = 9U,
            /// <summary>The source is copied to the destination; the destination pixels are ignored.</summary>
            D2D1_COMPOSITE_MODE_SOURCE_COPY = 10U,
            /// <summary>Equivalent to <b>D2D1_COMPOSITE_MODE_SOURCE_COPY</b>, but pixels outside of the source bounds are unchanged.</summary>
            D2D1_COMPOSITE_MODE_BOUNDED_SOURCE_COPY = 11U,
            /// <summary>Destination colors are inverted according to a source mask.</summary>
            D2D1_COMPOSITE_MODE_MASK_INVERT = 12U,
            /// <summary></summary>
            D2D1_COMPOSITE_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}