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
        /// <summary>Indicates the device state.</summary>
        /// <remarks>
        /// <para>A state-block mask indicates the device states that a pass or a technique changes.  The <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenablecapture">D3D10StateBlockMaskEnableCapture</a> function provides a convenient way of setting a range of bitmasks for the array members of <b>D3D10_STATE_BLOCK_MASK</b>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_STATE_BLOCK_MASK
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the vertex shader state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte VS;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of vertex-shader samplers.  The array is a multi-byte bitmask where each bit represents one sampler slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 VSSamplers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of vertex-shader resources. The array is a multi-byte bitmask where each bit represents one resource slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_16 VSShaderResources;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of vertex-shader constant buffers. The array is a multi-byte bitmask where each bit represents one constant buffer slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 VSConstantBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the geometry shader state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte GS;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of geometry-shader samplers. The array is a multi-byte bitmask where each bit represents one sampler slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 GSSamplers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of geometry-shader resources. The array is a multi-byte bitmask where each bit represents one resource slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_16 GSShaderResources;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of geometry-shader constant buffers. The array is a multi-byte bitmask where each bit represents one buffer slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 GSConstantBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the pixel shader state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte PS;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of pixel-shader samplers. The array is a multi-byte bitmask where each bit represents one sampler slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 PSSamplers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of pixel-shader resources. The array is a multi-byte bitmask where each bit represents one resource slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_16 PSShaderResources;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of pixel-shader constant buffers. The array is a multi-byte bitmask where each bit represents one constant buffer slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 PSConstantBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Array of vertex buffers. The array is a multi-byte bitmask where each bit represents one resource slot.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_2 IAVertexBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the index buffer state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte IAIndexBuffer;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the input layout state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte IAInputLayout;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the primitive topology state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte IAPrimitiveTopology;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the render targets states.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte OMRenderTargets;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the depth-stencil state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte OMDepthStencilState;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the blend state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte OMBlendState;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the viewports states.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte RSViewports;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the scissor rectangles states.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte RSScissorRects;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the rasterizer state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte RSRasterizerState;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the stream-out buffers states.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte SOBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Boolean value indicating whether to save the predication state.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_state_block_mask#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte Predication;
            internal struct __byte_2
            {
                internal byte _0, _1;
                /// <summary>Always <c>2</c>.</summary>
                internal int Length => 2;
            }

            internal struct __byte_16
            {
                internal byte _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15;
                /// <summary>Always <c>16</c>.</summary>
                internal int Length => 16;
            }
        }
    }
}