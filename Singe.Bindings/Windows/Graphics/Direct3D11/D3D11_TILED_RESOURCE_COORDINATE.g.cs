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
        /// <summary>Describes the coordinates of a tiled resource.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_TILED_RESOURCE_COORDINATE
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The x position of a tiled resource. Used for buffer and 1D, 2D, and 3D textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint X;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The y position of a tiled resource. Used for 2D and 3D textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Y;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The z position of a tiled resource. Used for 3D textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Z;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A subresource index value into mipmaps and arrays. Used for 1D, 2D, and 3D textures.</para>
            /// <para>For mipmaps that use nonstandard tiling, or are packed, or both use nonstandard tiling and are packed, any subresource value that indicates any of the packed mipmaps all refer to the same tile.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Subresource;
        }
    }
}