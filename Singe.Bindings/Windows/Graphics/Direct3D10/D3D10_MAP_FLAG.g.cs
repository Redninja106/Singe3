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
        /// <summary>Specifies how the CPU should respond when Map is called on a resource being used by the GPU.</summary>
        /// <remarks>
        /// <para>This enumeration is used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10buffer-map">ID3D10Buffer::Map</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10texture1d-map">ID3D10Texture1D::Map</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10texture2d-map">ID3D10Texture2D::Map</a>, and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10texture3d-map">ID3D10Texture3D::Map</a>.</para>
        /// <para>D3D10_MAP_FLAG_DO_NOT_WAIT cannot be used with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_map">D3D10_MAP_WRITE_DISCARD</a> or <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_map">D3D10_MAP_WRITE_NOOVERWRITE</a>.</para>
        /// <para>For more information about potential conflicts between the GPU and CPU during resource mapping, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-mapping">Copying and Accessing Resource Data (Direct3D 10)</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_map_flag#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_MAP_FLAG
        {
            /// <summary>Specifies that Map should return <b>DXGI_ERROR_WAS_STILL_DRAWING</b> when the GPU blocks the CPU from accessing a resource.</summary>
            D3D10_MAP_FLAG_DO_NOT_WAIT = 1048576,
        }
    }
}