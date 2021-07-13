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
        /// <summary>Describes the subresources from an array of 2D textures to use in a render-target view.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/ns-d3d11_3-d3d11_tex2d_array_rtv1">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_TEX2D_ARRAY_RTV1
        {
            /// <summary>The index of the mipmap level to use mip slice.</summary>
            internal uint MipSlice;
            /// <summary>The index of the first texture to use in an array of textures.</summary>
            internal uint FirstArraySlice;
            /// <summary>Number of textures in the array to use in the render-target view, starting from <b>FirstArraySlice</b>.</summary>
            internal uint ArraySize;
            /// <summary>The index (plane slice number) of the plane to use in an array of textures.</summary>
            internal uint PlaneSlice;
        }
    }
}