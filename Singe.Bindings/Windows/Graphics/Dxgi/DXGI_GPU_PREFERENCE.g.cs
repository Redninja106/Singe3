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

    namespace Graphics.Dxgi
    {
        /// <summary>The preference of GPU for the app to run on.</summary>
        /// <remarks>
        /// <para>This enumeration is used in the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_6/nf-dxgi1_6-idxgifactory6-enumadapterbygpupreference">IDXGIFactory6::EnumAdapterByGpuPreference</a> method.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum DXGI_GPU_PREFERENCE
        {
            /// <summary>No preference of GPU.</summary>
            DXGI_GPU_PREFERENCE_UNSPECIFIED = 0,
            /// <summary>Preference for the minimum-powered GPU (such as an integrated graphics processor, or iGPU).</summary>
            DXGI_GPU_PREFERENCE_MINIMUM_POWER = 1,
            /// <summary>Preference for the highest performing GPU, such as a discrete graphics processor (dGPU) or external graphics processor (xGPU).</summary>
            DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE = 2,
        }
    }
}