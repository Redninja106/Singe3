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
        /// <summary>Describes the root signature 1.1 layout of a descriptor table as a collection of descriptor ranges that are all relative to a single base descriptor handle.</summary>
        /// <remarks>
        /// <para>Samplers are not allowed in the same descriptor table as constant-buffer views (CBVs), unordered-access views (UAVs), and shader-resource views (SRVs).</para>
        /// <para><b>D3D12_ROOT_DESCRIPTOR_TABLE1</b>is the data type of the <b>DescriptorTable</b>member of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_parameter1">D3D12_ROOT_PARAMETER1</a>. Use a <b>D3D12_ROOT_DESCRIPTOR_TABLE1</b> when you set <b>D3D12_ROOT_PARAMETER1</b>'s <b>SlotType</b> member to <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_root_parameter_type">D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE</a>.</para>
        /// <para>Refer to the helper structure <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/cd3dx12-root-descriptor-table1">CD3DX12_ROOT_DESCRIPTOR_TABLE1</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_root_descriptor_table1#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_ROOT_DESCRIPTOR_TABLE1
        {
            /// <summary>The number of descriptor ranges in the table layout.</summary>
            internal uint NumDescriptorRanges;
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_descriptor_range1">D3D12_DESCRIPTOR_RANGE1</a> structures that describe the descriptor ranges.</summary>
            internal unsafe win32.Graphics.Direct3D12.D3D12_DESCRIPTOR_RANGE1*pDescriptorRanges;
        }
    }
}