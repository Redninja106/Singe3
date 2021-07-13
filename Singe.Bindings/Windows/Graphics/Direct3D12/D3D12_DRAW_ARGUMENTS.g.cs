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
        /// <summary>Describes parameters for drawing instances.</summary>
        /// <remarks>
        /// <para>The members of this structure serve the same purpose as the parameters of  <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawinstanced">DrawInstanced</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_draw_arguments#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DRAW_ARGUMENTS
        {
            /// <summary>Specifies the number of vertices to draw, per instance.</summary>
            internal uint VertexCountPerInstance;
            /// <summary>Specifies the number of instances.</summary>
            internal uint InstanceCount;
            /// <summary>Specifies an index to the first vertex to start drawing from.</summary>
            internal uint StartVertexLocation;
            /// <summary>Specifies an index to the first instance to start drawing from.</summary>
            internal uint StartInstanceLocation;
        }
    }
}