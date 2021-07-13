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
        /// <summary>Identifiers for properties of the 2D affine transform effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_2DAFFINETRANSFORM_PROP : uint
        {
            /// <summary>
            /// <para>The interpolation mode used to scale the image. There are 6 scale modes that range in quality and speed.</para>
            /// <para>Type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_interpolation_mode">D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE</a>. Default value is D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE = 0U,
            /// <summary>
            /// <para>The mode used to calculate the border of the image, soft or hard.</para>
            /// <para>Type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_border_mode">D2D1_BORDER_MODE</a>. Default value is D2D1_BORDER_MODE_SOFT.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE = 1U,
            /// <summary>
            /// <para>The 3x2 matrix to transform the image using the Direct2D matrix transform.</para>
            /// <para>Type is <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a>. Default value is Matrix3x2F::Identity().</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX = 2U,
            /// <summary>
            /// <para>In the high quality cubic interpolation mode, the sharpness level of the scaling filter as a float between 0 and 1. The values are unitless. You can use sharpness to adjust the quality of an image when you scale the image. The sharpness factor affects the shape of the kernel. The higher the sharpness factor, the smaller the kernel.</para>
            /// <para><div class = "alert"><b>Note</b>  This property affects only the high quality cubic interpolation mode.</div> <div> </div> Type is FLOAT. Default value is 1.0f.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_2daffinetransform_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS = 3U,
            /// <summary></summary>
            D2D1_2DAFFINETRANSFORM_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}