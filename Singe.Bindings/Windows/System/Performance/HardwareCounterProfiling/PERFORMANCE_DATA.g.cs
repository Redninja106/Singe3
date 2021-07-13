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

    namespace System.Performance.HardwareCounterProfiling
    {
        /// <summary>Contains the thread profiling and hardware counter data that you requested.</summary>
        /// <remarks>
        /// <para>You must initialize the <b>Size</b> and <b>Version</b> members before calling the <a href = "https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-readthreadprofilingdata">ReadThreadProfilingData</a> function to read the profiling data.</para>
        /// <para>The profile data contained in this structure depends on the data that you requested when you called the <a href = "https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-readthreadprofilingdata">ReadThreadProfilingData</a> function. The following members are set when you specify the READ_THREAD_PROFILING_FLAG_DISPATCHING flag:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-performance_data#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct PERFORMANCE_DATA
        {
            /// <summary>The size of this structure.</summary>
            internal ushort Size;
            /// <summary>The version of this structure. Must be set to PERFORMANCE_DATA_VERSION.</summary>
            internal byte Version;
            /// <summary>The number of array elements in the <b>HwCounters</b> array that contain hardware counter data. A value of 3 means that the array contains data for three hardware counters, not that elements 0 through 2 contain counter data.</summary>
            internal byte HwCountersCount;
            /// <summary>The number of context switches that occurred from the time profiling was enabled.</summary>
            internal uint ContextSwitchCount;
            /// <summary>A bitmask that identifies the reasons for the context switches that occurred since the last time the data was read. For possible values, see the <b>KWAIT_REASON</b> enumeration (the enumeration is included in the Wdm.h file in the WDK).</summary>
            internal ulong WaitReasonBitMap;
            /// <summary>The cycle time of the thread (excludes the time spent interrupted) from the time profiling was enabled.</summary>
            internal ulong CycleTime;
            /// <summary>The number of times that the read operation read the data to ensure a consistent snapshot of the data.</summary>
            internal uint RetryCount;
            /// <summary>Reserved. Set to zero.</summary>
            internal uint Reserved;
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-hardware_counter_data">HARDWARE_COUNTER_DATA</a> structures that contain the counter values. The elements of the array that contain counter data relate directly to the bits set in the <i>HardwareCounters</i> bitmask that you specified when you called the <a href = "https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-enablethreadprofiling">EnableThreadProfiling</a> function. For example, if you set bit 3 in the <i>HardwareCounters</i> bitmask, HwCounters[3] will contain the counter data for that counter.</summary>
            internal __win32_System_Performance_HardwareCounterProfiling_HARDWARE_COUNTER_DATA_16 HwCounters;
            internal struct __win32_System_Performance_HardwareCounterProfiling_HARDWARE_COUNTER_DATA_16
            {
                internal win32.System.Performance.HardwareCounterProfiling.HARDWARE_COUNTER_DATA _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15;
                /// <summary>Always <c>16</c>.</summary>
                internal int Length => 16;
            }
        }
    }
}