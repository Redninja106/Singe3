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
        /// <summary>Specifies which unordered resource options are supported for a provided format.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_feature_data_format_support">D3D12_FEATURE_DATA_FORMAT_SUPPORT</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_format_support2#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D3D12_FORMAT_SUPPORT2 : uint
        {
            /// <summary>No unordered resource options are supported.</summary>
            D3D12_FORMAT_SUPPORT2_NONE = 0x00000000,
            /// <summary>Format supports atomic add.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_ADD = 0x00000001,
            /// <summary>Format supports atomic bitwise operations.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS = 0x00000002,
            /// <summary>Format supports atomic compare with store or exchange.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE = 0x00000004,
            /// <summary>Format supports atomic exchange.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE = 0x00000008,
            /// <summary>Format supports atomic min and max.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX = 0x00000010,
            /// <summary>Format supports atomic unsigned min and max.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX = 0x00000020,
            /// <summary>Format supports a typed load.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD = 0x00000040,
            /// <summary>Format supports a typed store.</summary>
            D3D12_FORMAT_SUPPORT2_UAV_TYPED_STORE = 0x00000080,
            /// <summary>Format supports logic operations in blend state.</summary>
            D3D12_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP = 0x00000100,
            /// <summary>Format supports tiled resources. Refer to <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/volume-tiled-resources">Volume Tiled Resources</a>.</summary>
            D3D12_FORMAT_SUPPORT2_TILED = 0x00000200,
            /// <summary>Format supports multi-plane overlays.</summary>
            D3D12_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY = 0x00004000,
            D3D12_FORMAT_SUPPORT2_SAMPLER_FEEDBACK = 0x00008000,
        }
    }
}