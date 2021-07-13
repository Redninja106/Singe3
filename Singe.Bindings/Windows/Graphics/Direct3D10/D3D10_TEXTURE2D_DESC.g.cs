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
        /// <summary>Describes a 2D texture.</summary>
        /// <remarks>
        /// <para>This structure is used in a call to <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10device-createtexture2d">ID3D10Device::CreateTexture2D</a>. A helpful derived structure CD3D10_TEXTURE2D_DESC is declared in D3D10.h, to help create a texture description.</para>
        /// <para>The device places some size restrictions (must be multiples of a minimum size) for a subsampled, <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-block-compression">block compressed</a>, or bit-format resource.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_TEXTURE2D_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Texture width (in texels). The range is from 1 to D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION (8192). For a texture cube-map, the range is from 1 to D3D10_REQ_TEXTURECUBE_DIMENSION (8192). For more information about restrictions, see Remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Width;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Texture height (in texels). The range is from 1 to D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION (8192). For a texture cube-map, the range is from 1 to D3D10_REQ_TEXTURECUBE_DIMENSION (8192). For more information about restrictions, see Remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Height;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of subtextures (also called mipmap levels). Use 1 for a multisampled texture; or 0 to generate a full set of subtextures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MipLevels;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of textures in the texture array. The range is from 1 to D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION (512). For a texture cube-map, this value is a multiple of 6 (that is, 6 * the value in the <b>NumCubes</b> member of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10_1/ns-d3d10_1-d3d10_texcube_array_srv1">D3D10_TEXCUBE_ARRAY_SRV1</a>), and the range is from 6 to D3D10_REQ_TEXTURECUBE_DIMENSION.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ArraySize;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a></b></para>
            /// <para>Texture format (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgicommon/ns-dxgicommon-dxgi_sample_desc">DXGI_SAMPLE_DESC</a></b></para>
            /// <para>Structure that specifies multisampling parameters for the texture. See <a href = "https://docs.microsoft.com/windows/desktop/api/dxgicommon/ns-dxgicommon-dxgi_sample_desc">DXGI_SAMPLE_DESC</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Dxgi.DXGI_SAMPLE_DESC SampleDesc;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_usage">D3D10_USAGE</a></b></para>
            /// <para>Value that identifies how the texture is to be read from and written to. The most common value is D3D10_USAGE-DEFAULT; see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_usage">D3D10_USAGE</a> for all possible values.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_USAGE Usage;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Flags (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_bind_flag">D3D10_BIND_FLAG</a>) for binding to <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-pipeline-stages">pipeline</a> stages. The flags can be combined by a logical OR.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint BindFlags;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Flags (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_cpu_access_flag">D3D10_CPU_ACCESS_FLAG</a>) to specify the types of CPU access allowed. Use 0 if CPU access is not required. These flags can be combined with a logical OR.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint CPUAccessFlags;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Flags (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_resource_misc_flag">D3D10_RESOURCE_MISC_FLAG</a>) that identify other, less common resource options. Use 0 if none of these flags apply. These flags can be combined with a logical OR. For a texture cube-map, set the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_resource_misc_flag">D3D10_RESOURCE_MISC_TEXTURECUBE</a> flag. Cube-map arrays (that is, <b>ArraySize</b> &gt; 6) require feature level <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_feature_level">D3D_FEATURE_LEVEL_10_1</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_texture2d_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MiscFlags;
        }
    }
}