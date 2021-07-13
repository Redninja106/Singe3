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

    namespace Graphics.Direct3D11
    {
        /// <summary>Describes the level of support for shader caching in the current graphics driver.</summary>
        /// <remarks>
        /// <para>This enum is used by the [D3D11_FEATURE_DATA_SHADER_CACHE](./ns-d3d11-d3d11_feature_data_shader_cache.md) structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_shader_cache_support_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_SHADER_CACHE_SUPPORT_FLAGS
        {
            /// <summary>Indicates that the driver does not support shader caching.</summary>
            D3D11_SHADER_CACHE_SUPPORT_NONE = 0,
            /// <summary>Indicates that the driver supports an OS-managed shader cache that stores compiled shaders in memory during the current run of the application.</summary>
            D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 1,
            /// <summary>Indicates that the driver supports an OS-managed shader cache that stores compiled shaders on disk to accelerate future runs of the application.</summary>
            D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 2,
        }
    }
}