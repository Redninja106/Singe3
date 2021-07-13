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
        /// <summary>Describes a streaming output buffer.</summary>
        /// <remarks>
        /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_graphics_pipeline_state_desc">D3D12_GRAPHICS_PIPELINE_STATE_DESC</a> object contains a <b>D3D12_STREAM_OUTPUT_DESC</b> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_stream_output_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_STREAM_OUTPUT_DESC
        {
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_so_declaration_entry">D3D12_SO_DECLARATION_ENTRY</a> structures. Can't be <b>NULL</b> if <b>NumEntries</b> &gt; 0.</summary>
            internal unsafe win32.Graphics.Direct3D12.D3D12_SO_DECLARATION_ENTRY*pSODeclaration;
            /// <summary>The number of entries in the stream output declaration array that the <b>pSODeclaration</b> member points to.</summary>
            internal uint NumEntries;
            /// <summary>An array of buffer strides; each stride is the size of an element for that buffer.</summary>
            internal unsafe uint *pBufferStrides;
            /// <summary>The number of strides (or buffers) that the <b>pBufferStrides</b> member points to.</summary>
            internal uint NumStrides;
            /// <summary>The index number of the stream to be sent to the rasterizer stage.</summary>
            internal uint RasterizedStream;
        }
    }
}