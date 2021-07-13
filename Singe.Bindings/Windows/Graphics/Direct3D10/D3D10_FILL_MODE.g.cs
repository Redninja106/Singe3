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

    namespace Graphics.Direct3D10
    {
        /// <summary>Determines the fill mode to use when rendering triangles.</summary>
        /// <remarks>
        /// <para>This enumeration is part of a rasterizer-state object description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_rasterizer_desc">D3D10_RASTERIZER_DESC</a>).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_fill_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_FILL_MODE
        {
            /// <summary>Draw lines connecting the vertices. <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-primitive-topologies">Adjacent vertices</a> are not drawn.</summary>
            D3D10_FILL_WIREFRAME = 2,
            /// <summary>Fill the triangles formed by the vertices. Adjacent vertices are not drawn.</summary>
            D3D10_FILL_SOLID = 3,
        }
    }
}