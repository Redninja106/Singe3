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

    namespace Graphics.Direct3D12
    {
        /// <summary>Specifies texture layout options.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_desc">D3D12_RESOURCE_DESC</a> structure.</para>
        /// <para>This enumeration controls the swizzle pattern of default textures and enable map support on default textures. Callers must query <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options">D3D12_FEATURE_DATA_D3D12_OPTIONS</a> to ensure that each option is supported.</para>
        /// <para>The standard swizzle formats applies within each page-sized chunk, and pages are laid out in linear order with respect to one another. A 16-bit interleave pattern defines the conversion from pre-swizzled intra-page location to the post-swizzled location.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_texture_layout#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_TEXTURE_LAYOUT
        {
            /// <summary>
            /// <para>Indicates that the layout is unknown, and is likely adapter-dependent. During creation, the driver chooses the most efficient layout based on other resource properties, especially resource size and flags. Prefer this choice unless certain functionality is required from another texture layout.</para>
            /// <para>Zero-copy texture upload optimizations exist for UMA architectures; see <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-writetosubresource">ID3D12Resource::WriteToSubresource</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_texture_layout#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_TEXTURE_LAYOUT_UNKNOWN = 0,
            /// <summary>
            /// <para>Indicates that data for the texture is stored in row-major order (sometimes called "pitch-linear order").</para>
            /// <para>This texture layout locates consecutive texels of a row contiguously in memory, before the texels of the next row. Similarly, consecutive texels of a particular depth or array slice are contiguous in memory before the texels of the next depth or array slice. Padding may exist between rows and between depth or array slices to align collections of data. A stride is the distance in memory between rows, depth, or array slices; and it includes any padding.</para>
            /// <para>This texture layout enables sharing of the texture data between multiple adapters, when other layouts aren't available.</para>
            /// <para>Many restrictions apply, because this layout is generally not efficient for extensive usage:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_texture_layout#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_TEXTURE_LAYOUT_ROW_MAJOR = 1,
            /// <summary>
            /// <para>Indicates that the layout within 64KB tiles and tail mip packing is up to the driver. No standard swizzle pattern.</para>
            /// <para>This texture layout is arranged into contiguous 64KB regions, also known as tiles, containing near equilateral amount of consecutive number of texels along each dimension. Tiles are arranged in row-major order. While there is no padding between tiles, there are typically unused texels within the last tile in each dimension. The layout of texels within the tile is undefined. Each subresource immediately follows where the previous subresource end, and the subresource order follows the same sequence as subresource ordinals. However, tail mip packing is adapter-specific. For more details, see tiled resource tier and <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getresourcetiling">ID3D12Device::GetResourceTiling</a>.</para>
            /// <para>This texture layout enables partially resident or sparse texture scenarios when used together with virtual memory page mapping functionality. This texture layout must be used together with <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createreservedresource">ID3D12Device::CreateReservedResource</a>to enable the usage of <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-updatetilemappings">ID3D12CommandQueue::UpdateTileMappings</a>.</para>
            /// <para>Some restrictions apply to textures with this layout:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_texture_layout#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE = 2,
            /// <summary>
            /// <para>Indicates that a default texture uses the standardized swizzle pattern.</para>
            /// <para>This texture layout is arranged the same way that D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE is, except that the layout of texels within the tile is defined. Tail mip packing is adapter-specific.</para>
            /// <para>This texture layout enables optimizations when marshaling data between multiple adapters or between the CPU and GPU. The amount of copying can be reduced when multiple components understand the texture memory layout. This layout is generally more efficient for extensive usage than row-major layout, due to the rotationally invariant locality of neighboring texels. This layout can typically only be used with adapters that support standard swizzle, but exceptions exist for cross-adapter shared heaps.</para>
            /// <para>The restrictions for this layout are that the following aren't supported:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_texture_layout#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE = 3,
        }
    }
}