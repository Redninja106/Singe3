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
        /// <summary>FFT creation flags.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ne-d3dcsx-d3dx11_fft_create_flag">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3DX11_FFT_CREATE_FLAG
        {
            /// <summary>
            /// <para>Do not AddRef or Release temp and precompute buffers, caller is responsible for holding references to these buffers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcsx/ne-d3dcsx-d3dx11_fft_create_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3DX11_FFT_CREATE_FLAG_NO_PRECOMPUTE_BUFFERS = 1,
        }
    }
}