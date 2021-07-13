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
        /// <summary>Specifies the CPU-page properties for the heap.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_heap_properties">D3D12_HEAP_PROPERTIES</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_cpu_page_property#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_CPU_PAGE_PROPERTY
        {
            /// <summary>The CPU-page property is unknown.</summary>
            D3D12_CPU_PAGE_PROPERTY_UNKNOWN = 0,
            /// <summary>The CPU cannot access the heap, therefore no page properties are available.</summary>
            D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE = 1,
            /// <summary>The CPU-page property is write-combined.</summary>
            D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE = 2,
            /// <summary>The CPU-page property is write-back.</summary>
            D3D12_CPU_PAGE_PROPERTY_WRITE_BACK = 3,
        }
    }
}