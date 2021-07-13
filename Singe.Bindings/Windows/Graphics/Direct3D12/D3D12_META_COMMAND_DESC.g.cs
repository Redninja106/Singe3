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
        /// <summary>Describes a meta command.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_meta_command_desc">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_META_COMMAND_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/guiddef/ns-guiddef-guid">GUID</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/win32/api/guiddef/ns-guiddef-guid">GUID</a> uniquely identifying the meta command.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_meta_command_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal global::System.Guid Id;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCWSTR</a></b></para>
            /// <para>The meta command name.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_meta_command_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCWSTR Name;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_graphics_states">D3D12_GRAPHICS_STATES</a></b></para>
            /// <para>Declares the command list states that are modified by the call to initialize the meta command. If all state bits are set, then that's equivalent to calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearstate">ID3D12GraphicsCommandList::ClearState</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_meta_command_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D12.D3D12_GRAPHICS_STATES InitializationDirtyState;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_graphics_states">D3D12_GRAPHICS_STATES</a></b></para>
            /// <para>Declares the command list states that are modified by the call to execute the meta command. If all state bits are set, then that's equivalent to calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearstate">ID3D12GraphicsCommandList::ClearState</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_meta_command_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D12.D3D12_GRAPHICS_STATES ExecutionDirtyState;
        }
    }
}