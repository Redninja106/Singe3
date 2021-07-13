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
        /// <summary>Identifies unordered-access view options for a buffer resource.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_buffer_uav_flag">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_BUFFER_UAV_FLAG
        {
            /// <summary>
            /// <para>Resource contains raw, unstructured data.  Requires the UAV format to be DXGI_FORMAT_R32_TYPELESS. For more info about raw viewing of buffers, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-resources-intro">Raw Views of Buffers</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_buffer_uav_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_BUFFER_UAV_FLAG_RAW = 1,
            /// <summary>
            /// <para>Allow data to be appended to the end of the buffer.  <b>D3D11_BUFFER_UAV_FLAG_APPEND</b> flag must also be used for any view that will be used as a <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/sm5-object-appendstructuredbuffer">AppendStructuredBuffer</a> or a <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/sm5-object-consumestructuredbuffer">ConsumeStructuredBuffer</a>. Requires the UAV format to be DXGI_FORMAT_UNKNOWN.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_buffer_uav_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_BUFFER_UAV_FLAG_APPEND = 2,
            /// <summary>
            /// <para>Adds a counter to the unordered-access-view buffer.  <b>D3D11_BUFFER_UAV_FLAG_COUNTER</b> can only be used on a UAV that is a <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/sm5-object-rwstructuredbuffer">RWStructuredBuffer</a> and it enables the functionality needed for the <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/sm5-object-rwstructuredbuffer-incrementcounter">IncrementCounter</a>and <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/sm5-object-rwstructuredbuffer-decrementcounter">DecrementCounter</a> methods in HLSL.  Requires the UAV format to be DXGI_FORMAT_UNKNOWN.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_buffer_uav_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_BUFFER_UAV_FLAG_COUNTER = 4,
        }
    }
}