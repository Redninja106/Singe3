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
        /// <summary>Describes query data for stream output.</summary>
        /// <remarks>
        /// <para>Use this structure with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_query_heap_type">D3D12_QUERY_HEAP_TYPE</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-createqueryheap">CreateQueryHeap</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_query_data_so_statistics#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_QUERY_DATA_SO_STATISTICS
        {
            /// <summary>Specifies the number of primitives written.</summary>
            internal ulong NumPrimitivesWritten;
            /// <summary>Specifies the total amount of storage needed by the primitives.</summary>
            internal ulong PrimitivesStorageNeeded;
        }
    }
}