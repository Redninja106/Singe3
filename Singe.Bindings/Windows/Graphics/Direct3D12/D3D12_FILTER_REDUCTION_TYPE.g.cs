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
        /// <summary>Specifies the type of filter reduction.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_sampler_desc">D3D12_SAMPLER_DESC</a> structure. Also, refer to the remarks for <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_filter_reduction_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_FILTER_REDUCTION_TYPE
        {
            /// <summary>The filter type is standard.</summary>
            D3D12_FILTER_REDUCTION_TYPE_STANDARD = 0,
            /// <summary>The filter type is comparison.</summary>
            D3D12_FILTER_REDUCTION_TYPE_COMPARISON = 1,
            /// <summary>The filter type is minimum.</summary>
            D3D12_FILTER_REDUCTION_TYPE_MINIMUM = 2,
            /// <summary>The filter type is maximum.</summary>
            D3D12_FILTER_REDUCTION_TYPE_MAXIMUM = 3,
        }
    }
}