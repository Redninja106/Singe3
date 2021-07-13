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
        /// <summary>Describes the rasterizer state.</summary>
        /// <remarks>
        /// <para>Rasterizer state defines the behavior of the <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-rasterizer-stage">rasterizer stage</a>. To create a rasterizer-state object, call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10device-createrasterizerstate">ID3D10Device::CreateRasterizerState</a>. To set rasterizer state, call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10device-rssetstate">ID3D10Device::RSSetState</a>.</para>
        /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature levels</a> 9.1, 9.2, 9.3, and 10.0, if you set <b>MultisampleEnable</b> to <b>FALSE</b>, the runtime renders all points, lines, and triangles without anti-aliasing even for render targets with a sample count greater than 1. For feature level 10.1, the setting of <b>MultisampleEnable</b> has no effect on points and triangles with regard to MSAA and impacts only the selection of the line-rendering algorithm as shown in this table:</div> <div> </div></para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_RASTERIZER_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_fill_mode">D3D10_FILL_MODE</a></b></para>
            /// <para>A member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_fill_mode">D3D10_FILL_MODE</a> enumerated type that determines the fill mode to use when rendering.  The default value is <b>D3D10_FILL_SOLID</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_FILL_MODE FillMode;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_cull_mode">D3D10_CULL_MODE</a></b></para>
            /// <para>A member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ne-d3d10-d3d10_cull_mode">D3D10_CULL_MODE</a> enumerated type that indicates whether triangles facing the specified direction are drawn.  The default value is <b>D3D10_CULL_BACK</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_CULL_MODE CullMode;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Determines if a triangle is front-facing or back-facing. If this parameter is <b>TRUE</b>, then a triangle is considered front-facing if its vertices are counter-clockwise on the render target, and considered back-facing if they are clockwise. If this parameter is <b>FALSE</b>, then the opposite is true.  The default value is <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL FrontCounterClockwise;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">INT</a></b></para>
            /// <para>Specifies the depth value added to a given pixel. The default value is 0. For info about depth bias, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-output-merger-stage-depth-bias">Depth Bias</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int DepthBias;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Specifies the maximum depth bias of a pixel. The default value is 0.0f. For info about depth bias, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-output-merger-stage-depth-bias">Depth Bias</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float DepthBiasClamp;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Specifies a scalar on a given pixel's slope. The default value is 0.0f. For info about depth bias, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-output-merger-stage-depth-bias">Depth Bias</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float SlopeScaledDepthBias;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Enables or disables clipping based on distance.  The default value is <b>TRUE</b>.</para>
            /// <para>The hardware always performs x and y clipping of rasterized coordinates. When <b>DepthClipEnable</b> is set to the default value, the hardware also clips the z value (that is, the hardware performs the last step of the following algorithm).</para>
            /// <para><pre class = "syntax"xml: space = "preserve"><code> 0 &lt; w -w &lt;= x &lt;= w (or arbitrarily wider range if implementation uses a guard band to reduce clipping burden) -w &lt;= y &lt;= w (or arbitrarily wider range if implementation uses a guard band to reduce clipping burden) 0 &lt;= z &lt;= w </code></pre> When you set <b>DepthClipEnable</b> to FALSE, the hardware skips the z clipping (that is, the last step in the preceding algorithm). However, the hardware still performs the "0 &lt; w" clipping. When z clipping is disabled, improper depth ordering at the pixel level might result. However, when z clipping is disabled, stencil shadow implementations are simplified. In other words, you can avoid complex special-case handling for geometry that goes beyond the back clipping plane.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL DepthClipEnable;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Enable or disables scissor-rectangle culling. All pixels outside an active scissor rectangle are culled. The default value is <b>FALSE</b>. For more information, see <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d10-graphics-programming-guide-rasterizer-stage-getting-started">Set the Scissor Rectangle</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL ScissorEnable;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Specifies whether to use the quadrilateral or alpha line anti-aliasing algorithm on multisample antialiasing (MSAA) render targets. The default value is <b>FALSE</b>. Set to <b>TRUE</b> to use the quadrilateral line anti-aliasing algorithm and to <b>FALSE</b> to use the alpha line anti-aliasing algorithm. For more info about this member, see Remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL MultisampleEnable;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Specifies whether to enable line antialiasing; only applies when alpha blending is enabled, you are drawing lines, and the <b>MultisampleEnable</b> member is <b>FALSE</b>.  The default value is <b>FALSE</b>. For more info about this member, see Remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_rasterizer_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL AntialiasedLineEnable;
        }
    }
}