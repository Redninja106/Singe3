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
        /// <summary>Specifies the type of root signature slot.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_parameter">D3D12_ROOT_PARAMETER</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_root_parameter_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_ROOT_PARAMETER_TYPE
        {
            /// <summary>The slot is for a descriptor table.</summary>
            D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE = 0,
            /// <summary>The slot is for root constants.</summary>
            D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS = 1,
            /// <summary>The slot is for a constant-buffer view (CBV).</summary>
            D3D12_ROOT_PARAMETER_TYPE_CBV = 2,
            /// <summary>The slot is for a shader-resource view (SRV).</summary>
            D3D12_ROOT_PARAMETER_TYPE_SRV = 3,
            /// <summary>The slot is for a unordered-access view (UAV).</summary>
            D3D12_ROOT_PARAMETER_TYPE_UAV = 4,
        }
    }
}