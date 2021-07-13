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
        /// <summary>Specifies the subresources from a 3D texture to use in a shader-resource view.</summary>
        /// <remarks>
        /// <para>This structure is one member of a shader-resource-view description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_shader_resource_view_desc">D3D11_SHADER_RESOURCE_VIEW_DESC</a>).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_tex3d_srv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_TEX3D_SRV
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Index of the most detailed mipmap level to use; this number is between 0 and <b>MipLevels</b> (from the original Texture3D for which <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11device-createshaderresourceview">ID3D11Device::CreateShaderResourceView</a> creates a view) -1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_tex3d_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MostDetailedMip;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The maximum number of mipmap levels for the view of the texture. See the remarks in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_tex1d_srv">D3D11_TEX1D_SRV</a>.</para>
            /// <para>Set to -1 to indicate all the mipmap levels from <b>MostDetailedMip</b> on down to least detailed.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_tex3d_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MipLevels;
        }
    }
}