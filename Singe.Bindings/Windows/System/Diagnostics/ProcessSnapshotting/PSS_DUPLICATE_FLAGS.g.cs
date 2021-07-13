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
        /// <summary>Duplication flags for use by PssDuplicateSnapshot.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//processsnapshot/ne-processsnapshot-pss_duplicate_flags">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum PSS_DUPLICATE_FLAGS : uint
        {
            /// <summary>No flag.</summary>
            PSS_DUPLICATE_NONE = 0x00000000,
            /// <summary>
            /// <para>Free the source handle. This will only succeed if you set the  <b>PSS_CREATE_USE_VM_ALLOCATIONS</b> flag when you called <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/processsnapshot/nf-processsnapshot-psscapturesnapshot">PssCaptureSnapshot</a> to create the snapshot and handle. The handle will be freed  even if duplication fails. The close operation does not protect against concurrent access to the same descriptor.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//processsnapshot/ne-processsnapshot-pss_duplicate_flags#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            PSS_DUPLICATE_CLOSE_SOURCE = 0x00000001,
        }
    }
}