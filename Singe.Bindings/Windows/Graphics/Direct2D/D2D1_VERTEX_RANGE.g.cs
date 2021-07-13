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

    namespace Graphics.Direct2D
    {
        /// <summary>Defines a range of vertices that are used when rendering less than the full contents of a vertex buffer.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/ns-d2d1effectauthor-d2d1_vertex_range">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_VERTEX_RANGE
        {
            /// <summary>The first vertex in the range to process.</summary>
            internal uint startVertex;
            /// <summary>The number of vertices to use.</summary>
            internal uint vertexCount;
        }
    }
}