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
        /// <summary>Describes the layout of a root signature version 1.1.</summary>
        /// <remarks>
        /// <para>Use this structure with the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_versioned_root_signature_desc">D3D12_VERSIONED_ROOT_SIGNATURE_DESC</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_root_signature_desc1#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_ROOT_SIGNATURE_DESC1
        {
            /// <summary>The number of slots in the root signature. This number is also the number of elements in the <i>pParameters</i> array.</summary>
            internal uint NumParameters;
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_parameter1">D3D12_ROOT_PARAMETER1</a> structures for the slots in the root signature.</summary>
            internal unsafe win32.Graphics.Direct3D12.D3D12_ROOT_PARAMETER1*pParameters;
            /// <summary>Specifies the number of static samplers.</summary>
            internal uint NumStaticSamplers;
            /// <summary>Pointer to one or more <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_static_sampler_desc">D3D12_STATIC_SAMPLER_DESC</a> structures.</summary>
            internal unsafe win32.Graphics.Direct3D12.D3D12_STATIC_SAMPLER_DESC*pStaticSamplers;
            /// <summary>Specifies the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_root_signature_flags">D3D12_ROOT_SIGNATURE_FLAGS</a> that determine the data volatility.</summary>
            internal win32.Graphics.Direct3D12.D3D12_ROOT_SIGNATURE_FLAGS Flags;
        }
    }
}