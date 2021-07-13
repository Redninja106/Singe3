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
        /// <summary>Describes an FFT.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ns-d3dcsx-d3dx11_fft_desc">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3DX11_FFT_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of dimension in the FFT.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ns-d3dcsx-d3dx11_fft_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NumDimensions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a>[D3DX11_FFT_MAX_DIMENSIONS]</b></para>
            /// <para>Length of each dimension in the FFT.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ns-d3dcsx-d3dx11_fft_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __uint_32 ElementLengths;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Combination of <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcsx/ne-d3dcsx-d3dx11_fft_dim_mask">D3DX11_FFT_DIM_MASK</a> flags indicating the  dimensions to transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ns-d3dcsx-d3dx11_fft_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint DimensionMask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcsx/ne-d3dcsx-d3dx11_fft_data_type">D3DX11_FFT_DATA_TYPE</a></b></para>
            /// <para><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcsx/ne-d3dcsx-d3dx11_fft_data_type">D3DX11_FFT_DATA_TYPE</a> flag indicating the type of data being transformed.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ns-d3dcsx-d3dx11_fft_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3DX11_FFT_DATA_TYPE Type;
            internal struct __uint_32
            {
                internal uint _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31;
                /// <summary>Always <c>32</c>.</summary>
                internal int Length => 32;
            }
        }
    }
}