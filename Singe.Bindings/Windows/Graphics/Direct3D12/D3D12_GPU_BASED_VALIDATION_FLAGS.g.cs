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
        /// <summary>Describes the level of GPU-based validation to perform at runtime.</summary>
        /// <remarks>
        /// <para>This enumeration is used with the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug2-setgpubasedvalidationflags">ID3D12Debug2::SetGPUBasedValidationFlags</a> method to configure the amount of runtime validation that will occur.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_GPU_BASED_VALIDATION_FLAGS
        {
            /// <summary>Default behavior; resource states, descriptors, and descriptor tables are all validated.</summary>
            D3D12_GPU_BASED_VALIDATION_FLAGS_NONE = 0,
            /// <summary>When set, GPU-based validation does not perform resource state validation which greatly reduces the performance cost of GPU-based validtion. Descriptors and descriptor heaps are still validated.</summary>
            D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING = 1,
        }
    }
}