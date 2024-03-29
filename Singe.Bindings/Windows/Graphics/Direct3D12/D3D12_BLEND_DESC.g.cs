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
        /// <summary>Describes the blend state.</summary>
        /// <remarks>
        /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_graphics_pipeline_state_desc">D3D12_GRAPHICS_PIPELINE_STATE_DESC</a> object contains a blend-state structure that controls blending by the output-merger stage.</para>
        /// <para>Here are the default values for blend state.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_blend_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_BLEND_DESC
        {
            /// <summary>Specifies whether to use alpha-to-coverage as a multisampling technique when setting a pixel to a render target. For more info about using alpha-to-coverage, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-blend-state">Alpha-To-Coverage</a>.</summary>
            internal win32.System.SystemServices.BOOL AlphaToCoverageEnable;
            /// <summary>
            /// <para>Specifies whether to enable independent blending in simultaneous render targets. Set to <b>TRUE</b> to enable independent blending. If set to <b>FALSE</b>, only the <b>RenderTarget</b>[0] members are used; <b>RenderTarget</b>[1..7] are ignored.</para>
            /// <para>See the **Remarks** section for restrictions.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_blend_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL IndependentBlendEnable;
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_render_target_blend_desc">D3D12_RENDER_TARGET_BLEND_DESC</a> structures that describe the blend states for render targets; these correspond to the eight render targets that can be bound to the <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-output-merger-stage">output-merger stage</a> at one time.</summary>
            internal __win32_Graphics_Direct3D12_D3D12_RENDER_TARGET_BLEND_DESC_8 RenderTarget;
            internal struct __win32_Graphics_Direct3D12_D3D12_RENDER_TARGET_BLEND_DESC_8
            {
                internal win32.Graphics.Direct3D12.D3D12_RENDER_TARGET_BLEND_DESC _0, _1, _2, _3, _4, _5, _6, _7;
                /// <summary>Always <c>8</c>.</summary>
                internal int Length => 8;
            }
        }
    }
}