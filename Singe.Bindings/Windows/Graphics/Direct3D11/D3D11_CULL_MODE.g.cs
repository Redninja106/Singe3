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
        /// <summary>Indicates triangles facing a particular direction are not drawn.</summary>
        /// <remarks>
        /// <para>This enumeration is part of a rasterizer-state object description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_rasterizer_desc">D3D11_RASTERIZER_DESC</a>).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_cull_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_CULL_MODE
        {
            /// <summary>Always draw all triangles.</summary>
            D3D11_CULL_NONE = 1,
            /// <summary>Do not draw triangles that are front-facing.</summary>
            D3D11_CULL_FRONT = 2,
            /// <summary>Do not draw triangles that are back-facing.</summary>
            D3D11_CULL_BACK = 3,
        }
    }
}