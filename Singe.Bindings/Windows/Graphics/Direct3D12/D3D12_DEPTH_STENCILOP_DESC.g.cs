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
        /// <summary>Describes stencil operations that can be performed based on the results of stencil test.</summary>
        /// <remarks>
        /// <para>All stencil operations are specified as a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_stencil_op">D3D12_STENCIL_OP</a>-typed value. Each stencil operation can be set differently based on the outcome of the stencil test, which is referred to as <b>StencilFunc</b>, in the stencil test portion of depth-stencil testing.</para>
        /// <para>Members of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_depth_stencil_desc">D3D12_DEPTH_STENCIL_DESC</a> have this structure for their data type.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_depth_stencilop_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DEPTH_STENCILOP_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_stencil_op">D3D12_STENCIL_OP</a>-typed value that identifies the stencil operation to perform when stencil testing fails.</summary>
            internal win32.Graphics.Direct3D12.D3D12_STENCIL_OP StencilFailOp;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_stencil_op">D3D12_STENCIL_OP</a>-typed value that identifies the stencil operation to perform when stencil testing passes and depth testing fails.</summary>
            internal win32.Graphics.Direct3D12.D3D12_STENCIL_OP StencilDepthFailOp;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_stencil_op">D3D12_STENCIL_OP</a>-typed value that identifies the stencil operation to perform when stencil testing and depth testing both pass.</summary>
            internal win32.Graphics.Direct3D12.D3D12_STENCIL_OP StencilPassOp;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_comparison_func">D3D12_COMPARISON_FUNC</a>-typed value that identifies the function that compares stencil data against existing stencil data.</summary>
            internal win32.Graphics.Direct3D12.D3D12_COMPARISON_FUNC StencilFunc;
        }
    }
}