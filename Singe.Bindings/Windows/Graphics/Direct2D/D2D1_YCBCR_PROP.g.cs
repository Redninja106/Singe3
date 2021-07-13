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
        /// <summary>Identifiers for properties of the YCbCr effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_YCBCR_PROP : uint
        {
            /// <summary>
            /// <para>Specifies the chroma subsampling of the input chroma image.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_chroma_subsampling">D2D1_YCBCR_CHROMA_SUBSAMPLING</a>. The default value is D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING = 0U,
            /// <summary>
            /// <para>A 3x2 Matrix specifying the axis-aligned affine transform of the image. Axis aligned transforms include Scale, Flips, and 90 degree rotations.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a>. The default value is Matrix3x2F::Identity().</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_YCBCR_PROP_TRANSFORM_MATRIX = 1U,
            /// <summary>
            /// <para>The interpolation mode.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_interpolation_mode">D2D1_YCBCR_INTERPOLATION_MODE</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_1/ne-d2d1effects_1-d2d1_ycbcr_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_YCBCR_PROP_INTERPOLATION_MODE = 2U,
            /// <summary></summary>
            D2D1_YCBCR_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}