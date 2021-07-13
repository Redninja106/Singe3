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
        /// <summary>Describes the elements in a raw buffer resource to use in a shader-resource view.</summary>
        /// <remarks>
        /// <para>This structure is used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_shader_resource_view_desc">D3D11_SHADER_RESOURCE_VIEW_DESC</a> to create a raw view of a buffer.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_bufferex_srv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_BUFFEREX_SRV
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The index of the first element to be accessed by the view.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_bufferex_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint FirstElement;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of elements in the resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_bufferex_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NumElements;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_bufferex_srv_flag">D3D11_BUFFEREX_SRV_FLAG</a>-typed value that identifies view options for the buffer. Currently, the only option is to identify a raw view of the buffer. For more info about raw viewing of buffers, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-resources-intro">Raw Views of Buffers</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_bufferex_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Flags;
        }
    }
}