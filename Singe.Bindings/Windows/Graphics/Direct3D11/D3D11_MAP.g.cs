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
        /// <summary>Identifies a resource to be accessed for reading and writing by the CPU. Applications may combine one or more of these flags.</summary>
        /// <remarks>
        /// <para>This enumeration is used in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-map">ID3D11DeviceContext::Map</a>.</para>
        /// <para>These remarks are divided into the following topics:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_MAP
        {
            /// <summary>
            /// <para>Resource is mapped for reading. The resource must have been created with read access (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_cpu_access_flag">D3D11_CPU_ACCESS_READ</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_MAP_READ = 1,
            /// <summary>
            /// <para>Resource is mapped for writing. The resource must have been created with write access (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_cpu_access_flag">D3D11_CPU_ACCESS_WRITE</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_MAP_WRITE = 2,
            /// <summary>
            /// <para>Resource is mapped for reading and writing. The resource must have been created with read and write access (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_cpu_access_flag">D3D11_CPU_ACCESS_READ and D3D11_CPU_ACCESS_WRITE</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_MAP_READ_WRITE = 3,
            /// <summary>
            /// <para>Resource is mapped for writing; the previous contents of the resource will be undefined. The resource must have been created with write access and dynamic usage (See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_cpu_access_flag">D3D11_CPU_ACCESS_WRITE</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_usage">D3D11_USAGE_DYNAMIC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_MAP_WRITE_DISCARD = 4,
            /// <summary>
            /// <para>Resource is mapped for writing; the existing contents of the resource cannot be overwritten (see Remarks). This flag is only valid on vertex and index buffers. The resource must have been created with write access (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_cpu_access_flag">D3D11_CPU_ACCESS_WRITE</a>). Cannot be used on a resource created with the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_bind_flag">D3D11_BIND_CONSTANT_BUFFER</a> flag.</para>
            /// <para><div class = "alert"><b>Note</b>  The Direct3D 11.1 runtime, which is available starting with Windows 8, enables  mapping dynamic constant buffers and shader resource views (SRVs) of dynamic buffers with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_map">D3D11_MAP_WRITE_NO_OVERWRITE</a>.  The Direct3D 11 and earlier runtimes limited mapping to vertex or index buffers. To determine if a Direct3D device supports these features, call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11device-checkfeaturesupport">ID3D11Device::CheckFeatureSupport</a> with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_feature">D3D11_FEATURE_D3D11_OPTIONS</a>. <b>CheckFeatureSupport</b> fills members of a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options">D3D11_FEATURE_DATA_D3D11_OPTIONS</a> structure with the device's features. The relevant members here are <b>MapNoOverwriteOnDynamicConstantBuffer</b> and <b>MapNoOverwriteOnDynamicBufferSRV</b>.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_map#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_MAP_WRITE_NO_OVERWRITE = 5,
        }
    }
}