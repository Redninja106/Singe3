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
        /// <summary>Describes a descriptor range, with flags to determine their volatility.</summary>
        /// <remarks>
        /// <para>This structure is a member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_descriptor_table1">D3D12_ROOT_DESCRIPTOR_TABLE1</a> structure.</para>
        /// <para>Refer to the helper structure <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/cd3dx12-descriptor-range1">CD3DX12_DESCRIPTOR_RANGE1</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_descriptor_range1#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DESCRIPTOR_RANGE1
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_descriptor_range_type">D3D12_DESCRIPTOR_RANGE_TYPE</a>-typed value that specifies the type of descriptor range.</summary>
            internal win32.Graphics.Direct3D12.D3D12_DESCRIPTOR_RANGE_TYPE RangeType;
            /// <summary>The number of descriptors in the range. Use -1 or UINT_MAX to specify unbounded size. Only the last entry in a table can have unbounded size.</summary>
            internal uint NumDescriptors;
            /// <summary>The base shader register in the range. For example, for shader-resource views (SRVs), 3 maps to ": register(t3);" in HLSL.</summary>
            internal uint BaseShaderRegister;
            /// <summary>
            /// <para>The register space. Can typically be 0, but allows multiple descriptor  arrays of unknown size to not appear to overlap. For example, for SRVs, by extending the example in the <b>BaseShaderRegister</b> member description, 5 maps to ": register(t3,space5);" in HLSL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_descriptor_range1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint RegisterSpace;
            /// <summary>Specifies the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_descriptor_range_flags">D3D12_DESCRIPTOR_RANGE_FLAGS</a> that determine descriptor and data volatility.</summary>
            internal win32.Graphics.Direct3D12.D3D12_DESCRIPTOR_RANGE_FLAGS Flags;
            /// <summary>The offset in descriptors from the start of the root signature. This value can be <b>D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND</b>, which indicates this range should immediately follow the preceding range.</summary>
            internal uint OffsetInDescriptorsFromTableStart;
        }
    }
}