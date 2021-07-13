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
        /// <summary>Describes the level of shader caching supported in the current graphics driver.</summary>
        /// <remarks>
        /// <para>Use this structure with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-checkfeaturesupport">CheckFeatureSupport</a> to determine the level of support offered for the optional shader-caching features.</para>
        /// <para>See the enumeration constant D3D12_FEATURE_SHADER_CACHE in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_feature">D3D12_FEATURE</a> enumeration.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_shader_cache#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_FEATURE_DATA_SHADER_CACHE
        {
            /// <summary>
            /// <para>Type: [**D3D12_SHADER_CACHE_SUPPORT_FLAGS**](./ne-d3d12-d3d12_shader_cache_support_flags.md)</para>
            /// <para><a href = "https://docs.microsoft.com/visualstudio/code-quality/annotating-structs-and-classes?view=vs-2015">SAL</a>: <c>_Out_</c></para>
            /// <para>Indicates the level of caching supported.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_feature_data_shader_cache#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D12.D3D12_SHADER_CACHE_SUPPORT_FLAGS SupportFlags;
        }
    }
}