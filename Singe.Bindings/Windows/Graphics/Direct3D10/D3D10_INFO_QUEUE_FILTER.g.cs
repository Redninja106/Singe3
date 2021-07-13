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
        /// <summary>Debug message filter; contains a lists of message types to allow or deny.</summary>
        /// <remarks>
        /// <para>For use with an <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/nn-d3d10sdklayers-id3d10infoqueue">ID3D10InfoQueue Interface</a>.</para>
        /// <para>Providing an allow list with non-zero values causes only the specified combination of categories, severities and message IDs to be allowed. Messages that do not match the specified combination will be rejected.</para>
        /// <para>Providing a deny list with non-zero values causes the specified combination of categories, severities and message IDs to be rejected. Messages that do not match the specified combination will be allowed.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_INFO_QUEUE_FILTER
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter_desc">D3D10_INFO_QUEUE_FILTER_DESC</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter_desc">D3D10_INFO_QUEUE_FILTER_DESC</a> structure describing the types of messages the info queue should allow.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_INFO_QUEUE_FILTER_DESC AllowList;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter_desc">D3D10_INFO_QUEUE_FILTER_DESC</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter_desc">D3D10_INFO_QUEUE_FILTER_DESC</a> structure describing the types of messages the info queue should reject.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_INFO_QUEUE_FILTER_DESC DenyList;
        }
    }
}