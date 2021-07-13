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

    namespace Graphics.Direct3D11
    {
        /// <summary>Arguments for draw instanced indirect.</summary>
        /// <remarks>
        /// <para>The members of this structure serve the same purpose as the parameters of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-drawinstanced">ID3D11DeviceContext::DrawInstanced</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_draw_instanced_indirect_args#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS
        {
            /// <summary>The number of vertices to draw.</summary>
            internal uint VertexCountPerInstance;
            /// <summary>The number of instances to draw.</summary>
            internal uint InstanceCount;
            /// <summary>The index of the first vertex.</summary>
            internal uint StartVertexLocation;
            /// <summary>A value added to each index before reading per-instance data from a vertex buffer.</summary>
            internal uint StartInstanceLocation;
        }
    }
}