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
        /// <summary>Effect device-state types.</summary>
        /// <remarks>
        /// <para>This enumeration is used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdisablecapture">D3D10StateBlockMaskDisableCapture</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenablecapture">D3D10StateBlockMaskEnableCapture</a>, and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskgetsetting">D3D10StateBlockMaskGetSetting</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ne-d3d10effect-d3d10_device_state_types#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_DEVICE_STATE_TYPES
        {
            /// <summary>Stream-output buffer.</summary>
            D3D10_DST_SO_BUFFERS = 1,
            /// <summary>Render target.</summary>
            D3D10_DST_OM_RENDER_TARGETS = 2,
            /// <summary>Depth-stencil state.</summary>
            D3D10_DST_OM_DEPTH_STENCIL_STATE = 3,
            /// <summary>Blend state.</summary>
            D3D10_DST_OM_BLEND_STATE = 4,
            /// <summary>Vertex shader.</summary>
            D3D10_DST_VS = 5,
            /// <summary>Vertex shader sampler.</summary>
            D3D10_DST_VS_SAMPLERS = 6,
            /// <summary>Vertex shader resource.</summary>
            D3D10_DST_VS_SHADER_RESOURCES = 7,
            /// <summary>Vertex shader constant buffer.</summary>
            D3D10_DST_VS_CONSTANT_BUFFERS = 8,
            /// <summary>Geometry shader.</summary>
            D3D10_DST_GS = 9,
            /// <summary>Geometry shader sampler.</summary>
            D3D10_DST_GS_SAMPLERS = 10,
            /// <summary>Geometry shader resource.</summary>
            D3D10_DST_GS_SHADER_RESOURCES = 11,
            /// <summary>Geometry shader constant buffer.</summary>
            D3D10_DST_GS_CONSTANT_BUFFERS = 12,
            /// <summary>Pixel shader.</summary>
            D3D10_DST_PS = 13,
            /// <summary>Pixel shader sampler.</summary>
            D3D10_DST_PS_SAMPLERS = 14,
            /// <summary>Pixel shader resource.</summary>
            D3D10_DST_PS_SHADER_RESOURCES = 15,
            /// <summary>Pixel shader constant buffer.</summary>
            D3D10_DST_PS_CONSTANT_BUFFERS = 16,
            /// <summary>Input-assembler vertex buffer.</summary>
            D3D10_DST_IA_VERTEX_BUFFERS = 17,
            /// <summary>Input-assembler index buffer.</summary>
            D3D10_DST_IA_INDEX_BUFFER = 18,
            /// <summary>Input-assembler input layout.</summary>
            D3D10_DST_IA_INPUT_LAYOUT = 19,
            /// <summary>Input-assembler primitive topology.</summary>
            D3D10_DST_IA_PRIMITIVE_TOPOLOGY = 20,
            /// <summary>Viewport.</summary>
            D3D10_DST_RS_VIEWPORTS = 21,
            /// <summary>Scissor rectangle.</summary>
            D3D10_DST_RS_SCISSOR_RECTS = 22,
            /// <summary>Rasterizer state.</summary>
            D3D10_DST_RS_RASTERIZER_STATE = 23,
            /// <summary>Predication state.</summary>
            D3D10_DST_PREDICATION = 24,
        }
    }
}