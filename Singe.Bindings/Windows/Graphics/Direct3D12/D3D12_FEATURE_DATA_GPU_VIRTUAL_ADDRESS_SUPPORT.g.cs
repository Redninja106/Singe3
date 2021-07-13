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
        /// <summary>Details the adapter's GPU virtual address space limitations, including maximum address bits per resource and per process.</summary>
        /// <remarks>
        /// <para>See the enumeration constant D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_feature">D3D12_FEATURE</a> enumeration.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_gpu_virtual_address_support#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
        {
            /// <summary>
            /// <para>The maximum GPU virtual address bits per resource.</para>
            /// <para>Some adapters have significantly less bits available per resource than per process, while other adapters have significantly greater bits available per resource than per process. The latter scenario tends to happen in less common scenarios, like when running a 32-bit process on certain UMA adapters. When per resource capabilities are greater than per process, the greater per resource capabilities can only be leveraged by reserved resources or NULL mapped pages.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_gpu_virtual_address_support#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MaxGPUVirtualAddressBitsPerResource;
            /// <summary>
            /// <para>The maximum GPU virtual address bits per process.</para>
            /// <para>When this value is nearly equal to the available residency budget, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-evict">Evict</a> will not be a feasible option to manage residency. See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-makeresident">MakeResident</a> for more details.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_gpu_virtual_address_support#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MaxGPUVirtualAddressBitsPerProcess;
        }
    }
}