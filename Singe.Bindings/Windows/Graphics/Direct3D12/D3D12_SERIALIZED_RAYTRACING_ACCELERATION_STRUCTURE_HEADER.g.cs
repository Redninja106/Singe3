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
        /// <summary>Defines the header for a serialized raytracing acceleration structure.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_serialized_raytracing_acceleration_structure_header">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER
        {
            /// <summary>The driver-matching identifier.</summary>
            internal win32.Graphics.Direct3D12.D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;
            /// <summary>The size of serialized data.</summary>
            internal ulong SerializedSizeInBytesIncludingHeader;
            /// <summary>Size of the memory that will be consumed when the acceleration structure is deserialized.  This value is less than or equal to the size of the original acceleration structure before it was serialized.</summary>
            internal ulong DeserializedSizeInBytes;
            /// <summary>Size of the array of <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/d3d12_gpu_virtual_address">D3D12_GPU_VIRTUAL_ADDRESS</a> values that follow the header.  For more information, see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_postbuild_info_serialization_desc">D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC</a>.</summary>
            internal ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
        }
    }
}