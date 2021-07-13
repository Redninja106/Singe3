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
        /// <summary>Defines the inputs for a raytracing acceleration structure build operation. This structure is used by ID3D12GraphicsCommandList4::BuildRaytracingAccelerationStructure and ID3D12Device5::GetRaytracingAccelerationStructurePrebuildInfo.</summary>
        /// <remarks>
        /// <para>When used with  <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device5-getraytracingaccelerationstructureprebuildinfo">GetRaytracingAccelerationStructurePrebuildInfo</a>, which actually perform a build, any parameter that is referenced via <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/d3d12_gpu_virtual_address">D3D12_GPU_VIRTUAL_ADDRESS</a> (an address in GPU memory), like <i>InstanceDescs</i>, will not be accessed by the operation.  So this memory does not need to be initialized yet or be in a particular resource state.  Whether GPU addresses are null or not can be inspected by the operation, even though the pointers are not dereferenced.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_inputs#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
        {
            /// <summary>The type of acceleration structure to build.</summary>
            internal win32.Graphics.Direct3D12.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
            /// <summary>The build flags.</summary>
            internal win32.Graphics.Direct3D12.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
            /// <summary>
            /// <para>If <i>Type</i> is <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TOP_LEVEL</b>, this value is the number of instances, laid out based on <i>DescsLayout</i>.</para>
            /// <para>If <i>Type</i> is <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BOTTOM_LEVEL</b>, this value is the number of elements referred to by <i>pGeometryDescs</i> or <i>ppGeometryDescs</i>. Which of these fields  is used depends on <i>DescsLayout</i>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_inputs#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NumDescs;
            /// <summary>How geometry descriptions are specified; either an array of descriptions or an array of pointers to descriptions.</summary>
            internal win32.Graphics.Direct3D12.D3D12_ELEMENTS_LAYOUT DescsLayout;
            internal win32.Graphics.Direct3D12.D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal ulong InstanceDescs;
                [FieldOffset(0)]
                internal unsafe win32.Graphics.Direct3D12.D3D12_RAYTRACING_GEOMETRY_DESC*pGeometryDescs;
                [FieldOffset(0)]
                internal unsafe win32.Graphics.Direct3D12.D3D12_RAYTRACING_GEOMETRY_DESC**ppGeometryDescs;
            }
        }
    }
}