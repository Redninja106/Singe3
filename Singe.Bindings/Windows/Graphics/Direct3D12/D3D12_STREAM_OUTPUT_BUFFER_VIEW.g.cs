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
        /// <summary>Describes a stream output buffer.</summary>
        /// <remarks>
        /// <para>Use this structure with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12graphicscommandlist-sosettargets">SOSetTargets</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_stream_output_buffer_view#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_STREAM_OUTPUT_BUFFER_VIEW
        {
            /// <summary>
            /// <para>A D3D12_GPU_VIRTUAL_ADDRESS (a UINT64) that points to the stream output buffer. If <b>SizeInBytes</b> is 0, this member isn't used and can be any value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_stream_output_buffer_view#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong BufferLocation;
            /// <summary>The size of the stream output buffer in bytes.</summary>
            internal ulong SizeInBytes;
            /// <summary>
            /// <para>The location of the value of how much data has been filled into the buffer, as a D3D12_GPU_VIRTUAL_ADDRESS (a UINT64). This member can't be NULL; a filled size location must be supplied (which the hardware will increment as data is output). If <b>SizeInBytes</b> is 0, this member isn't used and can be any value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_stream_output_buffer_view#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong BufferFilledSizeLocation;
        }
    }
}