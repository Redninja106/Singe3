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
        /// <summary>Describes the subresource from a 2D texture to use in a render-target view.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/ns-d3d11_3-d3d11_tex2d_rtv1">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_TEX2D_RTV1
        {
            /// <summary>The index of the mipmap level to use mip slice.</summary>
            internal uint MipSlice;
            /// <summary>The index (plane slice number) of the plane to use in the texture.</summary>
            internal uint PlaneSlice;
        }
    }
}