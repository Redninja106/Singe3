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

    namespace System.Diagnostics.ProcessSnapshotting
    {
        /// <summary>Specifies what information PssQuerySnapshot function returns.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//processsnapshot/ne-processsnapshot-pss_query_information_class">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum PSS_QUERY_INFORMATION_CLASS
        {
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_process_information">PSS_PROCESS_INFORMATION</a> structure, with information about the original process.</summary>
            PSS_QUERY_PROCESS_INFORMATION = 0,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_va_clone_information">PSS_VA_CLONE_INFORMATION</a> structure, with a handle to the VA clone.</summary>
            PSS_QUERY_VA_CLONE_INFORMATION = 1,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_auxiliary_pages_information">PSS_AUXILIARY_PAGES_INFORMATION</a> structure, which contains the count of auxiliary pages captured.</summary>
            PSS_QUERY_AUXILIARY_PAGES_INFORMATION = 2,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_va_space_information">PSS_VA_SPACE_INFORMATION</a> structure, which contains the count of regions captured.</summary>
            PSS_QUERY_VA_SPACE_INFORMATION = 3,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_handle_information">PSS_HANDLE_INFORMATION</a> structure, which contains the count of handles captured.</summary>
            PSS_QUERY_HANDLE_INFORMATION = 4,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_thread_information">PSS_THREAD_INFORMATION</a> structure, which contains the count of threads captured.</summary>
            PSS_QUERY_THREAD_INFORMATION = 5,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_handle_trace_information">PSS_HANDLE_TRACE_INFORMATION</a> structure, which contains a handle to the handle trace section, and its size.</summary>
            PSS_QUERY_HANDLE_TRACE_INFORMATION = 6,
            /// <summary>Returns a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/ns-processsnapshot-pss_performance_counters">PSS_PERFORMANCE_COUNTERS</a> structure, which contains various performance counters.</summary>
            PSS_QUERY_PERFORMANCE_COUNTERS = 7,
        }
    }
}