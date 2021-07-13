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
        /// <summary>Describes the size of a tiled region.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_TILE_REGION_SIZE
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of tiles in the tiled region.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NumTiles;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Specifies whether the runtime uses the <b>Width</b>, <b>Height</b>, and <b>Depth</b> members to define the region.</para>
            /// <para>If <b>TRUE</b>, the runtime uses the <b>Width</b>, <b>Height</b>, and <b>Depth</b> members to define the region.</para>
            /// <para>If <b>FALSE</b>, the runtime ignores the <b>Width</b>, <b>Height</b>, and <b>Depth</b> members and uses the <b>NumTiles</b> member to traverse tiles in the resource linearly across x, then y, then z (as applicable) and then spills over mipmaps/arrays in subresource order.  For example, use this technique to map an entire resource at once.</para>
            /// <para>Regardless of whether you specify <b>TRUE</b> or <b>FALSE</b> for <b>bUseBox</b>, you use a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate">D3D11_TILED_RESOURCE_COORDINATE</a> structure to specify the starting location for the region within the resource as a separate parameter outside of this structure by using x, y, and z coordinates.</para>
            /// <para>When the region includes mipmaps that are packed with nonstandard tiling, <b>bUseBox</b> must be <b>FALSE</b> because tile dimensions are not standard and the app only knows a count of how many tiles are consumed by the packed area, which is per array slice.  The corresponding (separate) starting location parameter uses x to offset into the flat range of tiles in this case, and y and z coordinates must each be 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL bUseBox;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The width of the tiled region, in tiles. Used for buffer and 1D, 2D, and 3D textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Width;
            /// <summary>
            /// <para>Type: <b>UINT16</b></para>
            /// <para>The height of the tiled region, in tiles. Used for 2D and 3D textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort Height;
            /// <summary>
            /// <para>Type: <b>UINT16</b></para>
            /// <para>The depth of the tiled region, in tiles. Used for 3D textures or arrays. For arrays, used for advancing in depth jumps to next slice of same mipmap size, which isn't contiguous in the subresource counting space if there are multiple mipmaps.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_2/ns-d3d11_2-d3d11_tile_region_size#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort Depth;
        }
    }
}