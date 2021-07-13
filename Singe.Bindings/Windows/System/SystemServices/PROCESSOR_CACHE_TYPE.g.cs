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

    namespace System.SystemServices
    {
        /// <summary>Represents the type of processor cache identified in the corresponding CACHE_DESCRIPTOR structure.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ne-winnt-processor_cache_type">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum PROCESSOR_CACHE_TYPE
        {
            /// <summary>The cache is unified.</summary>
            CacheUnified = 0,
            /// <summary>The cache is for processor instructions.</summary>
            CacheInstruction = 1,
            /// <summary>The cache is for data.</summary>
            CacheData = 2,
            /// <summary>The cache is for traces.</summary>
            CacheTrace = 3,
        }
    }
}