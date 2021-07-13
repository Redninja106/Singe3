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
        /// <summary>Identifies unordered-access view options for a buffer resource.</summary>
        /// <remarks>
        /// <para>This enum is used in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_buffer_uav">D3D12_BUFFER_UAV</a>  structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_buffer_uav_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D3D12_BUFFER_UAV_FLAGS : uint
        {
            /// <summary>Indicates a default view.</summary>
            D3D12_BUFFER_UAV_FLAG_NONE = 0x00000000,
            /// <summary>
            /// <para>Resource contains raw, unstructured data.  Requires the UAV format to be <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT_R32_TYPELESS</a>. For more info about raw viewing of buffers, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-resources-intro">Raw Views of Buffers</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_buffer_uav_flags#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_BUFFER_UAV_FLAG_RAW = 0x00000001,
        }
    }
}