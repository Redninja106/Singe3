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
        /// <summary>Describes the elements in a buffer to use in a unordered-access view.</summary>
        /// <remarks>
        /// <para>Use this structure with a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_unordered_access_view_desc">D3D12_UNORDERED_ACCESS_VIEW_DESC</a> structure to view the resource as a buffer.</para>
        /// <para>If <i>StructureByteStride</i> value is not 0, a view of a structured buffer is created and the D3D12_UNORDERED_ACCESS_VIEW_DESC::Format field must be DXGI_FORMAT_UNKNOWN. If <i>StructureByteStride</i> is 0, a typed view of a buffer is created and a format must be supplied. The specified format for the typed view must be supported by the hardware. More information on this topic can be found in the <a href = "https://docs.microsoft.com/en-gb/windows/win32/direct3d12/typed-unordered-access-view-loads">Typed unordered access view (UAV) loads</a> page.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_buffer_uav#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_BUFFER_UAV
        {
            /// <summary>The zero-based index of the first element to be accessed.</summary>
            internal ulong FirstElement;
            /// <summary>The number of elements in the resource. For structured buffers, this is the number of structures in the buffer.</summary>
            internal uint NumElements;
            /// <summary>The size of each element in the buffer structure (in bytes) when the buffer represents a structured buffer.</summary>
            internal uint StructureByteStride;
            /// <summary>The counter offset, in bytes.</summary>
            internal ulong CounterOffsetInBytes;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_buffer_uav_flags">D3D12_BUFFER_UAV_FLAGS</a>-typed value that specifies the view options for the resource.</summary>
            internal win32.Graphics.Direct3D12.D3D12_BUFFER_UAV_FLAGS Flags;
        }
    }
}