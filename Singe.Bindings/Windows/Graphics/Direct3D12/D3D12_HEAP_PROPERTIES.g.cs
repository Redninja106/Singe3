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
        /// <summary>Describes heap properties.</summary>
        /// <remarks>
        /// <para>This structure is used by the following:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_heap_properties#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_HEAP_PROPERTIES
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_heap_type">D3D12_HEAP_TYPE</a>-typed value that specifies the type of heap.</summary>
            internal win32.Graphics.Direct3D12.D3D12_HEAP_TYPE Type;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_cpu_page_property">D3D12_CPU_PAGE_PROPERTY</a>-typed value that specifies the CPU-page properties for the heap.</summary>
            internal win32.Graphics.Direct3D12.D3D12_CPU_PAGE_PROPERTY CPUPageProperty;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_memory_pool">D3D12_MEMORY_POOL</a>-typed value that specifies the memory pool for the heap.</summary>
            internal win32.Graphics.Direct3D12.D3D12_MEMORY_POOL MemoryPoolPreference;
            /// <summary>
            /// <para>For multi-adapter operation, this indicates the node where the resource should be created.</para>
            /// <para>Exactly one bit of this UINT must be set. See <a href = "https://docs.microsoft.com/windows/win32/direct3d12/multi-engine">Multi-adapter systems</a>.</para>
            /// <para>Passing zero is equivalent to passing one, in order to simplify the usage of single-GPU adapters.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_heap_properties#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint CreationNodeMask;
            /// <summary>
            /// <para>For multi-adapter operation, this indicates the set of nodes where the resource is visible.</para>
            /// <para><i>VisibleNodeMask</i> must have the same bit set that is set in <i>CreationNodeMask</i>. <i>VisibleNodeMask</i> can *also* have additional bits set for cross-node resources, but doing so can potentially reduce performance for resource accesses, so you should do so only when needed.</para>
            /// <para>Passing zero is equivalent to passing one, in order to simplify the usage of single-GPU adapters.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_heap_properties#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint VisibleNodeMask;
        }
    }
}