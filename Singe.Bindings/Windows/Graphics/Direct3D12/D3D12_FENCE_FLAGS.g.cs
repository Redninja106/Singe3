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
        /// <summary>Specifies fence options.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-createfence">ID3D12Device::CreateFence</a> method.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_fence_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D3D12_FENCE_FLAGS : uint
        {
            /// <summary>No options are specified.</summary>
            D3D12_FENCE_FLAG_NONE = 0x00000000,
            /// <summary>The fence is shared.</summary>
            D3D12_FENCE_FLAG_SHARED = 0x00000001,
            /// <summary>The fence is shared with another GPU adapter.</summary>
            D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER = 0x00000002,
            /// <summary>The fence is of the non-monitored type. Non-monitored fences should only be used when the adapter doesn't support monitored fences, or when a fence is shared with an adapter that doesn't support monitored fences.</summary>
            D3D12_FENCE_FLAG_NON_MONITORED = 0x00000004,
        }
    }
}