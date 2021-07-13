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
        /// <summary>Describes the subresources from an array of 2D textures to use in a shader-resource view.</summary>
        /// <remarks>
        /// <para>This structure is one member of a shader-resource-view description, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_shader_resource_view_desc">D3D12_SHADER_RESOURCE_VIEW_DESC</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_tex2d_array_srv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_TEX2D_ARRAY_SRV
        {
            /// <summary>Index of the most detailed mipmap level to use; this number is between 0 and <b>MipLevels</b> -1 (where <b>MipLevels</b> is from the original Texture2D for which <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-createshaderresourceview">ID3D12Device::CreateShaderResourceView</a> creates a view).</summary>
            internal uint MostDetailedMip;
            /// <summary>
            /// <para>The maximum number of mipmap levels for the view of the texture. See the remarks in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_tex1d_srv">D3D12_TEX1D_SRV</a>.</para>
            /// <para>Set to -1 to indicate all the mipmap levels from <b>MostDetailedMip</b> on down to least detailed.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_tex2d_array_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MipLevels;
            /// <summary>The index of the first texture to use in an array of textures.</summary>
            internal uint FirstArraySlice;
            /// <summary>Number of textures in the array.</summary>
            internal uint ArraySize;
            /// <summary>The index (plane slice number) of the plane to use in an array of textures.</summary>
            internal uint PlaneSlice;
            /// <summary>A value to clamp sample LOD values to. For example, if you specify 2.0f for the clamp value, you ensure that no individual sample accesses a mip level less than 2.0f.</summary>
            internal float ResourceMinLODClamp;
        }
    }
}