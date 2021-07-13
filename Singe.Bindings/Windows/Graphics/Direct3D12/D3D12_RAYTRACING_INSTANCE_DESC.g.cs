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
        /// <summary>Describes an instance of a raytracing acceleration structure used in GPU memory during the acceleration structure build process.</summary>
        /// <remarks>
        /// <para>This C++ struct definition is useful if you're generating instance data on the CPU first, then uploading to the GPU. But your application is also free to generate instance descriptions directly into GPU memory (from compute shaders, for instance) following the same layout.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_raytracing_instance_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_RAYTRACING_INSTANCE_DESC
        {
            /// <summary>
            /// <para>Type: **[FLOAT](/windows/win32/winprog/windows-data-types) \[3\]\[4\]**</para>
            /// <para>A 3x4 transform matrix in row-major layout representing the instance-to-world transformation. Implementations transform rays, as opposed to transforming all of the geometry or AABBs.</para>
            /// <para>> [!NOTE] > The layout of `Transform` is a transpose of how affine matrices are typically stored in memory. Instead of four 3-vectors, `Transform` is laid out as three 4-vectors.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_raytracing_instance_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __float_12 Transform;
            internal uint _bitfield1;
            internal uint _bitfield2;
            /// <summary>
            /// <para>Type: **[D3D12_GPU_VIRTUAL_ADDRESS](/windows/win32/direct3d12/d3d12_gpu_virtual_address)**</para>
            /// <para>Address of the bottom-level acceleration structure that is being instanced. The address must be aligned to 256 bytes, defined as [D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT](/windows/win32/direct3d12/constants). Any existing acceleration structure passed in here would already have been required to be placed with such alignment.</para>
            /// <para>The memory pointed to must be in state [D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE](./ne-d3d12-d3d12_resource_states.md).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_raytracing_instance_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong AccelerationStructure;
            internal struct __float_12
            {
                internal float _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11;
                /// <summary>Always <c>12</c>.</summary>
                internal int Length => 12;
            }
        }
    }
}