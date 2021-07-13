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
        /// <summary>Provides access to subresource data.</summary>
        /// <remarks>
        /// <para>This structure is used in a call to <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-map">ID3D11DeviceContext::Map</a>.</para>
        /// <para>The values in these members tell you how much data you can view:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_mapped_subresource#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_MAPPED_SUBRESOURCE
        {
            /// <summary>
            /// <para>Type: <b>void*</b></para>
            /// <para>Pointer to the data. When <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-map">ID3D11DeviceContext::Map</a> provides the pointer, the runtime ensures that the pointer has a specific alignment, depending on the following feature levels:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_mapped_subresource#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe void *pData;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The row pitch, or width, or physical size (in bytes) of the data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_mapped_subresource#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint RowPitch;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The depth pitch, or width, or physical size (in bytes)of the data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_mapped_subresource#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint DepthPitch;
        }
    }
}