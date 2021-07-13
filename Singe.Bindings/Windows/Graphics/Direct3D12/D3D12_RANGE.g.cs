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
        /// <summary>Describes a memory range.</summary>
        /// <remarks>
        /// <para><b>End</b> is one-past-the-end. When <b>Begin</b> equals <b>End</b>, the range is empty. The size of the range is (<b>End</b> - <b>Begin</b>).</para>
        /// <para>This structure is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12resource-map">Map</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12resource-unmap">Unmap</a> methods.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_range#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_RANGE
        {
            /// <summary>The offset, in bytes, denoting the beginning of a memory range.</summary>
            internal nuint Begin;
            /// <summary>
            /// <para>The offset, in bytes, denoting the end of a memory range. <b>End</b> is one-past-the-end.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_range#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal nuint End;
        }
    }
}