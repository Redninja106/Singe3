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

    namespace System.ProcessStatus
    {
        /// <summary>Contains performance information.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//psapi/ns-psapi-performance_information">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct PERFORMANCE_INFORMATION
        {
            /// <summary>The size of this structure, in bytes.</summary>
            internal uint cb;
            /// <summary>The number of pages currently committed by the system. Note that committing pages (using <a href = "https://docs.microsoft.com/windows/desktop/api/memoryapi/nf-memoryapi-virtualalloc">VirtualAlloc</a> with MEM_COMMIT) changes this value immediately; however, the physical memory is not charged until the pages are accessed.</summary>
            internal nuint CommitTotal;
            /// <summary>The current maximum number of pages that can be committed by the system without extending the paging file(s). This number can change if memory is added or deleted, or if pagefiles have grown, shrunk, or been added. If the paging file can be extended, this is a soft limit.</summary>
            internal nuint CommitLimit;
            /// <summary>The maximum number of pages that were simultaneously in the committed state since the last system reboot.</summary>
            internal nuint CommitPeak;
            /// <summary>The amount of actual physical memory, in pages.</summary>
            internal nuint PhysicalTotal;
            /// <summary>The amount of physical memory currently available, in pages.  This is the amount of physical memory that can be immediately reused without having to write its contents to disk first. It is the sum of the size of the standby, free, and zero lists.</summary>
            internal nuint PhysicalAvailable;
            /// <summary>The amount of system cache memory, in pages. This is the size of the standby list plus the system working set.</summary>
            internal nuint SystemCache;
            /// <summary>The sum of the memory currently in the paged and nonpaged kernel pools, in pages.</summary>
            internal nuint KernelTotal;
            /// <summary>The memory currently in the paged kernel pool, in pages.</summary>
            internal nuint KernelPaged;
            /// <summary>The memory currently in the nonpaged kernel pool, in pages.</summary>
            internal nuint KernelNonpaged;
            /// <summary>The size of a page, in bytes.</summary>
            internal nuint PageSize;
            /// <summary>The current number of open handles.</summary>
            internal uint HandleCount;
            /// <summary>The current number of processes.</summary>
            internal uint ProcessCount;
            /// <summary>The current number of threads.</summary>
            internal uint ThreadCount;
        }
    }
}