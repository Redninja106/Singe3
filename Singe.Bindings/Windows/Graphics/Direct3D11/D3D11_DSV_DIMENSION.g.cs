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
        /// <summary>Specifies how to access a resource used in a depth-stencil view.</summary>
        /// <remarks>
        /// <para>This enumeration is used in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencil_view_desc">D3D11_DEPTH_STENCIL_VIEW_DESC</a> to create a depth-stencil view.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_dsv_dimension#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_DSV_DIMENSION
        {
            /// <summary><i>D3D11_DSV_DIMENSION_UNKNOWN</i> is not a valid value for <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencil_view_desc">D3D11_DEPTH_STENCIL_VIEW_DESC</a> and is not used.</summary>
            D3D11_DSV_DIMENSION_UNKNOWN = 0,
            /// <summary>The resource will be accessed as a 1D texture.</summary>
            D3D11_DSV_DIMENSION_TEXTURE1D = 1,
            /// <summary>The resource will be accessed as an array of 1D textures.</summary>
            D3D11_DSV_DIMENSION_TEXTURE1DARRAY = 2,
            /// <summary>The resource will be accessed as a 2D texture.</summary>
            D3D11_DSV_DIMENSION_TEXTURE2D = 3,
            /// <summary>The resource will be accessed as an array of 2D textures.</summary>
            D3D11_DSV_DIMENSION_TEXTURE2DARRAY = 4,
            /// <summary>The resource will be accessed as a 2D texture with multisampling.</summary>
            D3D11_DSV_DIMENSION_TEXTURE2DMS = 5,
            /// <summary>The resource will be accessed as an array of 2D textures with multisampling.</summary>
            D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY = 6,
        }
    }
}