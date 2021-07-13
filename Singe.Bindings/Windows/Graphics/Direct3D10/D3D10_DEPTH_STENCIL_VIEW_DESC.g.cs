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

    namespace Graphics.Direct3D10
    {
        /// <summary>Specifies the subresource(s) from a texture that are accessible using a depth-stencil view.</summary>
        /// <remarks>
        /// <para>These are valid formats for a depth-stencil view:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_depth_stencil_view_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_DEPTH_STENCIL_VIEW_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a></b></para>
            /// <para>Resource data  format (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a>). See remarks for allowable formats.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_depth_stencil_view_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_dsv_dimension">D3D10_DSV_DIMENSION</a></b></para>
            /// <para>Type of resource (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_dsv_dimension">D3D10_DSV_DIMENSION</a>). Specifies how a depth-stencil resource will be accessed; the value is stored in the union in this structure.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_depth_stencil_view_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_DSV_DIMENSION ViewDimension;
            internal win32.Graphics.Direct3D10.D3D10_DEPTH_STENCIL_VIEW_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX1D_DSV Texture1D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX1D_ARRAY_DSV Texture1DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX2D_DSV Texture2D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX2D_ARRAY_DSV Texture2DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX2DMS_DSV Texture2DMS;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D10.D3D10_TEX2DMS_ARRAY_DSV Texture2DMSArray;
            }
        }
    }
}