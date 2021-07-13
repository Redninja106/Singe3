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
        /// <summary>Identifies other, less common options for resources.</summary>
        /// <remarks>
        /// <para>This enumeration is used in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-cd3d10_buffer_desc">D3D10_BUFFER_DESC</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-cd3d10_texture1d_desc">D3D10_TEXTURE1D_DESC</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-cd3d10_texture2d_desc">D3D10_TEXTURE2D_DESC</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-cd3d10_texture3d_desc">D3D10_TEXTURE3D_DESC</a>, <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3dx10-image-info">D3DX10_IMAGE_INFO</a>, and <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3dx10-image-load-info">D3DX10_IMAGE_LOAD_INFO</a>.</para>
        /// <para>These flags can be combined by bitwise OR.</para>
        /// <para>D3D10_RESOURCE_MISC_SHARED and D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX are mutually exclusive flags: either one may be set in the resource creation calls but not both simultaneously.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_RESOURCE_MISC_FLAG
        {
            /// <summary>
            /// <para>Enables an application to call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10device-generatemips">ID3D10Device::GenerateMips</a> on a <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-types">texture resource</a>. The resource must be created with the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_bind_flag">bind flags</a> that specify that the resource is a render target and a shader resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_RESOURCE_MISC_GENERATE_MIPS = 1,
            /// <summary>
            /// <para>Enables the sharing of resource data between two or more Direct3D devices. The only resources that can be shared are 2D non-mipmapped textures.</para>
            /// <para>WARP and REF devices do not support shared resources. Attempting to create a resource with this flag on either a WARP or REF device will cause the create method to return an E_OUTOFMEMORY error code.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_RESOURCE_MISC_SHARED = 2,
            /// <summary>
            /// <para>Enables an application to create a cube texture from a <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-types">Texture2DArray</a> that contains 6 textures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_RESOURCE_MISC_TEXTURECUBE = 4,
            /// <summary>
            /// <para>Enables the resource created to be synchronized using the IDXGIKeyedMutex::AcquireSync and ReleaseSync APIs. The following resource creation D3D10 APIs, that all take a D3D10_RESOURCE_MISC_FLAG parameter, have been extended to support the new flag.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 16,
            /// <summary>
            /// <para>Enables a surface to be used for GDI interoperability.  Setting this flag enables rendering on the surface via IDXGISurface1::GetDC.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_resource_misc_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 32,
        }
    }
}