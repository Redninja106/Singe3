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
        /// <summary>Describes the set of features targeted by a Direct3D device.</summary>
        /// <remarks>
        /// <para>For an overview of the capabilities of each feature level, see [Direct3D feature levels](/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro).</para>
        /// <para>For information about limitations creating non-hardware-type devices on certain feature levels, see [Limitations creating WARP and reference devices](/windows/desktop/direct3d11/overviews-direct3d-11-devices-limitations).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/ne-d3dcommon-d3d_feature_level#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D_FEATURE_LEVEL
        {
            /// <summary>Allows Microsoft Compute Driver Model (MCDM) devices to be used, or more feature-rich devices (such as traditional GPUs) that support a superset of the functionality. MCDM is the overall driver model for compute-only; it's a scaled-down peer of the larger scoped Windows Device Driver Model (WDDM).</summary>
            D3D_FEATURE_LEVEL_1_0_CORE = 4096,
            /// <summary>Targets features supported by [feature level](/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro) 9.1, including shader model 2.</summary>
            D3D_FEATURE_LEVEL_9_1 = 37120,
            /// <summary>Targets features supported by [feature level](/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro) 9.2, including shader model 2.</summary>
            D3D_FEATURE_LEVEL_9_2 = 37376,
            /// <summary>Targets features supported by [feature level](/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro) 9.3, including shader model 2.0b.</summary>
            D3D_FEATURE_LEVEL_9_3 = 37632,
            /// <summary>Targets features supported by Direct3D 10.0, including shader model 4.</summary>
            D3D_FEATURE_LEVEL_10_0 = 40960,
            /// <summary>Targets features supported by Direct3D 10.1, including shader model 4.</summary>
            D3D_FEATURE_LEVEL_10_1 = 41216,
            /// <summary>Targets features supported by Direct3D 11.0, including shader model 5.</summary>
            D3D_FEATURE_LEVEL_11_0 = 45056,
            /// <summary>Targets features supported by Direct3D 11.1, including shader model 5 and logical blend operations. This feature level requires a display driver that is at least implemented to WDDM for Windows 8 (WDDM 1.2).</summary>
            D3D_FEATURE_LEVEL_11_1 = 45312,
            /// <summary>Targets features supported by Direct3D 12.0, including shader model 5.</summary>
            D3D_FEATURE_LEVEL_12_0 = 49152,
            /// <summary>Targets features supported by Direct3D 12.1, including shader model 5.</summary>
            D3D_FEATURE_LEVEL_12_1 = 49408,
        }
    }
}