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
        /// <summary>Flags to control pipeline state.</summary>
        /// <remarks>
        /// <para>This enum is used by the <b>Flags</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_graphics_pipeline_state_desc">D3D12_GRAPHICS_PIPELINE_STATE_DESC</a>and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_compute_pipeline_state_desc">D3D12_COMPUTE_PIPELINE_STATE_DESC</a>structures.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_pipeline_state_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D3D12_PIPELINE_STATE_FLAGS : uint
        {
            /// <summary>Indicates no flags.</summary>
            D3D12_PIPELINE_STATE_FLAG_NONE = 0x00000000,
            /// <summary>
            /// <para>Indicates that the pipeline state should be compiled with additional information to assist debugging. This can only be set on WARP devices.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_pipeline_state_flags#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG = 0x00000001,
        }
    }
}