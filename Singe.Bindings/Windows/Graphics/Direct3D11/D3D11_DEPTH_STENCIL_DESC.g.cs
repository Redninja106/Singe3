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
        /// <summary>Describes depth-stencil state.</summary>
        /// <remarks>
        /// <para>Pass a pointer to <b>D3D11_DEPTH_STENCIL_DESC</b> to the  <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11device-createdepthstencilstate">ID3D11Device::CreateDepthStencilState</a> method to create the depth-stencil state object.</para>
        /// <para>Depth-stencil state controls how depth-stencil testing is performed by the output-merger stage.</para>
        /// <para>The following table shows the default values of depth-stencil states.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_DEPTH_STENCIL_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Enable depth testing.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL DepthEnable;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_depth_write_mask">D3D11_DEPTH_WRITE_MASK</a></b></para>
            /// <para>Identify a portion of the depth-stencil buffer that can be modified by depth data (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_depth_write_mask">D3D11_DEPTH_WRITE_MASK</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D11_DEPTH_WRITE_MASK DepthWriteMask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_comparison_func">D3D11_COMPARISON_FUNC</a></b></para>
            /// <para>A function that compares depth data against existing depth data. The function options are listed in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_comparison_func">D3D11_COMPARISON_FUNC</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D11_COMPARISON_FUNC DepthFunc;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Enable stencil testing.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL StencilEnable;
            /// <summary>
            /// <para>Type: <b>UINT8</b></para>
            /// <para>Identify a portion of the depth-stencil buffer for reading stencil data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte StencilReadMask;
            /// <summary>
            /// <para>Type: <b>UINT8</b></para>
            /// <para>Identify a portion of the depth-stencil buffer for writing stencil data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte StencilWriteMask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencilop_desc">D3D11_DEPTH_STENCILOP_DESC</a></b></para>
            /// <para>Identify how to use the results of the depth test and the stencil test for pixels whose surface normal is facing towards the camera (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencilop_desc">D3D11_DEPTH_STENCILOP_DESC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D11_DEPTH_STENCILOP_DESC FrontFace;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencilop_desc">D3D11_DEPTH_STENCILOP_DESC</a></b></para>
            /// <para>Identify how to use the results of the depth test and the stencil test for pixels whose surface normal is facing away from the camera (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_depth_stencilop_desc">D3D11_DEPTH_STENCILOP_DESC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_depth_stencil_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D11_DEPTH_STENCILOP_DESC BackFace;
        }
    }
}