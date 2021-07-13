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
        /// <summary>Indicates the level of support that the adapter provides for variable-rate shading (VRS), and indicates whether or not background processing is supported.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
        {
            /// <summary>
            /// <para>Type: <b>[BOOL](/windows/desktop/winprog/windows-data-types)</b></para>
            /// <para>Indicates whether 2x4, 4x2, and 4x4 coarse pixel sizes are supported for single-sampled rendering; and whether coarse pixel size 2x4 is supported for 2x MSAA. `true` if those sizes are supported, otherwise `false`.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL AdditionalShadingRatesSupported;
            /// <summary>
            /// <para>Type: <b>[BOOL](/windows/desktop/winprog/windows-data-types)</b></para>
            /// <para>Indicates whether the per-provoking-vertex (also known as per-primitive) rate can be used with more than one viewport. If so, then, in that case, that rate can be used when `SV_ViewportIndex` is written to. `true` if that rate can be used with more than one viewport, otherwise `false`.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL PerPrimitiveShadingRateSupportedWithViewportIndexing;
            /// <summary>
            /// <para>Type: <b>[D3D12_VARIABLE_SHADING_RATE_TIER](/windows/desktop/api/d3d12/ne-d3d12-d3d12_variable_shading_rate_tier)</b></para>
            /// <para>Indicates the shading rate tier.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D12.D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;
            /// <summary>
            /// <para>Type: <b>[UINT](/windows/desktop/winprog/windows-data-types)</b></para>
            /// <para>Indicates the tile size of the screen-space image as a **UINT**.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ShadingRateImageTileSize;
            /// <summary>
            /// <para>Type: <b>[BOOL](/windows/desktop/winprog/windows-data-types)</b></para>
            /// <para>Indicates whether or not background processing is supported. `true` if background processing is supported, otherwise `false`. For more info, see the [Direct3D 12 background processing spec](https://microsoft.github.io/DirectX-Specs/d3d/BackgroundProcessing.html).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL BackgroundProcessingSupported;
        }
    }
}