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
        /// <summary>Describes a raytracing acceleration structure. Pass this structure into ID3D12GraphicsCommandList4::BuildRaytracingAccelerationStructure to describe the acceleration structure to be built.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_desc">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC
        {
            /// <summary>
            /// <para>Location to store resulting acceleration structure.  <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device5-getraytracingaccelerationstructureprebuildinfo">ID3D12Device5::GetRaytracingAccelerationStructurePrebuildInfo</a> reports the amount of memory required for the result here given a set of acceleration structure build parameters.</para>
            /// <para>The address must be aligned to 256 bytes, defined as <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/constants">D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT</a>.</para>
            /// <para>> [!IMPORTANT] > The memory must be in state [**D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE**](/windows/desktop/api/d3d12/ne-d3d12-d3d12_resource_states).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong DestAccelerationStructureData;
            /// <summary>Description of the input data for the acceleration structure build.  This is data is stored in a separate structure because it is also used with <b>GetRaytracingAccelerationStructurePrebuildInfo</b>.</summary>
            internal win32.Graphics.Direct3D12.D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS Inputs;
            /// <summary>
            /// <para>Address of an existing acceleration structure if an acceleration structure update (an incremental build) is being requested, by setting  <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_raytracing_acceleration_structure_build_flags">D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE</a> in the Flags parameter.  Otherwise this address must be NULL.</para>
            /// <para>If this address is the same as <i>DestAccelerationStructureData</i>, the update is to be performed in-place.  Any other form of overlap of the source and destination memory is invalid and produces undefined behavior.</para>
            /// <para>The address must be aligned to 256 bytes, defined as <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/constants">D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT</a>, which should automatically be the case because any existing acceleration structure passed in here would have already been required to be placed with such alignment.</para>
            /// <para>> [!IMPORTANT] > The memory must be in state [**D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE**](/windows/desktop/api/d3d12/ne-d3d12-d3d12_resource_states).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong SourceAccelerationStructureData;
            /// <summary></summary>
            internal ulong ScratchAccelerationStructureData;
        }
    }
}