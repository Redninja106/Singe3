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
        /// <summary>Indicates the level of support that the adapter provides for timestamp queries, format-casting, immediate write, view instancing, and barycentrics.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_d3d12_options3">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
        {
            /// <summary>Indicates whether timestamp queries are supported on copy queues.</summary>
            internal win32.System.SystemServices.BOOL CopyQueueTimestampQueriesSupported;
            /// <summary>Indicates whether casting from one fully typed format to another, compatible, format is supported.</summary>
            internal win32.System.SystemServices.BOOL CastingFullyTypedFormatSupported;
            /// <summary>Indicates the kinds of command lists that support the ability to write an immediate value directly from the command stream into a specified buffer.</summary>
            internal win32.Graphics.Direct3D12.D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;
            /// <summary>Indicates the level of support the adapter has for view instancing.</summary>
            internal win32.Graphics.Direct3D12.D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;
            /// <summary>Indicates whether barycentrics are supported.</summary>
            internal win32.System.SystemServices.BOOL BarycentricsSupported;
        }
    }
}