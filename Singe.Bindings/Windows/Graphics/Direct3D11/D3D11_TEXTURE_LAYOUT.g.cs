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

    namespace Graphics.Direct3D11
    {
        /// <summary>Specifies texture layout options.</summary>
        /// <remarks>
        /// <para>This enumeration controls the swizzle pattern of default textures and enable map support on default textures.  Callers must query <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options2">D3D11_FEATURE_DATA_D3D11_OPTIONS2</a> to ensure that each option is supported.</para>
        /// <para>The standard swizzle formats applies within each page-sized chunk, and pages are laid out in linear order with respect to one another.  A 16-bit interleave pattern defines the conversion from pre-swizzled intra-page location to the post-swizzled location.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/ne-d3d11_3-d3d11_texture_layout#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_TEXTURE_LAYOUT
        {
            /// <summary>The texture layout is undefined, and is selected by the driver.</summary>
            D3D11_TEXTURE_LAYOUT_UNDEFINED = 0,
            /// <summary>Data for the texture is stored in row major (sometimes called pitch-linear) order.</summary>
            D3D11_TEXTURE_LAYOUT_ROW_MAJOR = 1,
            /// <summary>A default texture uses the standardized swizzle pattern.</summary>
            D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE = 2,
        }
    }
}