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
        /// <summary>Describes the subresources from a 3D texture to use in a render-target view.</summary>
        /// <remarks>
        /// <para>Use this structure with a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_render_target_view_desc">D3D12_RENDER_TARGET_VIEW_DESC</a> structure to view the resource as a 3D texture.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_tex3d_rtv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_TEX3D_RTV
        {
            /// <summary>The index of the mipmap level to use mip slice.</summary>
            internal uint MipSlice;
            /// <summary>First depth level to use.</summary>
            internal uint FirstWSlice;
            /// <summary>Number of depth levels to use in the render-target view, starting from <b>FirstWSlice</b>. A value of -1 indicates all of the slices along the w axis, starting from <b>FirstWSlice</b>.</summary>
            internal uint WSize;
        }
    }
}