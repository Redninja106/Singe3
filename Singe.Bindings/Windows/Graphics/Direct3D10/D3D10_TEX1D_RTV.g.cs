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
        /// <summary>Specifies the subresource from a 1D texture to use in a render-target view.</summary>
        /// <remarks>
        /// <para>This structure is one member of a render-target-view description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_render_target_view_desc">D3D10_RENDER_TARGET_VIEW_DESC</a>).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_tex1d_rtv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_TEX1D_RTV
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The index of the mipmap level to use (see <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-types">mip slice</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_tex1d_rtv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MipSlice;
        }
    }
}