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
        /// <summary>Describes the descriptor heap.</summary>
        /// <remarks>
        /// <para>This structure is used by the following:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_descriptor_heap_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DESCRIPTOR_HEAP_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_descriptor_heap_type">D3D12_DESCRIPTOR_HEAP_TYPE</a>-typed value that specifies the types of descriptors in the heap.</summary>
            internal win32.Graphics.Direct3D12.D3D12_DESCRIPTOR_HEAP_TYPE Type;
            /// <summary>The number of descriptors in the heap.</summary>
            internal uint NumDescriptors;
            /// <summary>A combination of <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_descriptor_heap_flags">D3D12_DESCRIPTOR_HEAP_FLAGS</a>-typed values that are combined by using a bitwise OR operation. The resulting value specifies options for the heap.</summary>
            internal win32.Graphics.Direct3D12.D3D12_DESCRIPTOR_HEAP_FLAGS Flags;
            /// <summary>
            /// <para>For single-adapter operation, set this to zero. If there are multiple adapter nodes, set a bit to identify the node (one of the device's physical adapters) to which the descriptor heap applies. Each bit in the mask corresponds to a single node. Only one bit must be set. See <a href = "https://docs.microsoft.com/windows/win32/direct3d12/multi-engine">Multi-adapter systems</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_descriptor_heap_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NodeMask;
        }
    }
}