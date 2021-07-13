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
        /// <summary>Describes parameters for drawing indexed instances.</summary>
        /// <remarks>
        /// <para>The members of this structure serve the same purpose as the parameters of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawindexedinstanced">DrawIndexedInstanced</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_draw_indexed_arguments#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DRAW_INDEXED_ARGUMENTS
        {
            /// <summary>The number of indices read from the index buffer for each instance.</summary>
            internal uint IndexCountPerInstance;
            /// <summary>The number of instances to draw.</summary>
            internal uint InstanceCount;
            /// <summary>The location of the first index read by the GPU from the index buffer.</summary>
            internal uint StartIndexLocation;
            /// <summary>A value added to each index before reading a vertex from the vertex buffer.</summary>
            internal int BaseVertexLocation;
            /// <summary>A value added to each index before reading per-instance data from a vertex buffer.</summary>
            internal uint StartInstanceLocation;
        }
    }
}