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

    namespace System.JobObjects
    {
        /// <summary>Contains information used to control the I/O rate for a job. This structure is used by the SetIoRateControlInformationJobObject and QueryIoRateControlInformationJobObject functions.</summary>
        /// <remarks>
        /// <para><div class = "alert"><b>Important</b>  Starting with Windows 10, version 1607, this structure is no longer supported.</div> <div> </div> You can only set one I/O rate control for a job in a hierarchy of nested jobs. The settings that you specify apply to that job and the child jobs in the hierarchy for that job.  The settings do not apply to the chain of jobs from the parent job up to the top of the hierarchy. You still can change the settings for the original job in the hierarchy on which you set I/O rate control. However, attempts to set values for the control of the I/O rate for any other jobs in the hierarchy, including the parent jobs, fail.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION
        {
            /// <summary>
            /// <para>The maximum limit for the I/O rate in I/O operations per second (IOPS). Set to 0 if to specify no limit.</para>
            /// <para>When you set both <b>MaxIops</b> and <b>MaxBandwith</b>, the operating system enforces the first limit that the I/O rate reaches.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal long MaxIops;
            /// <summary>
            /// <para>The maximum limit for the I/O rate in bytes per second. Set to 0 to specify no limit.</para>
            /// <para>When you set both <b>MaxBandwith</b> and <b>MaxIops</b>, the operating system enforces the first limit that the I/O rate reaches.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal long MaxBandwidth;
            /// <summary>
            /// <para>Sets a minimum I/O rate which the operating system reserves for the job. To make no reservation for the job, set this value to 0.</para>
            /// <para>The operating system allows the job to perform I/O operations at this rate, if possible. If the sum of the minimum rates for all jobs exceeds the capacity of the operating system, the rate at which the operating system allows each job to perform I/O operations is proportional to the reservation for the job.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal long ReservationIops;
            /// <summary>
            /// <para>The NT device name for the volume to which you want to apply the policy for the I/O rate. For information about NT device names, see <a href = "https://docs.microsoft.com/windows-hardware/drivers/kernel/nt-device-names">NT Device Names</a>.</para>
            /// <para>If this member is <b>NULL</b>, the policy for the I/O rate applies to all of the volumes for the operating system. For example, if this member is <b>NULL</b> and the <b>MaxIops</b> member is 100, the maximum limit for the I/O rate for each volume is set to 100 IOPS, instead of setting an aggregate limit for the I/O rate across all volumes of 100 IOPS.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCWSTR VolumeName;
            /// <summary>
            /// <para>The base size of the normalized I/O unit, in bytes.  For example, if the <b>BaseIoSize</b> member is 8,000, every 8,000 bytes counts as one I/O unit. 4,000 bytes is also one I/O unit in this example, while 8,001 bytes is two I/O units.</para>
            /// <para>You  can set the value of this base I/O size by using the <b>StorageBaseIOSize</b> value of the <b>HKEY_LOCAL_MACHINE</b>&#92;<b>SYSTEM</b>&#92;<b>CurrentControlSet</b>&#92;<b>Control</b>&#92;<b>QoS</b></p> registry key.</para>
            /// <para>The value of the <b>BaseIoSize</b> member is subject to the following constraints:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//jobapi2/ns-jobapi2-jobobject_io_rate_control_information#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint BaseIoSize;
            /// <summary></summary>
            internal win32.System.SystemServices.JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;
        }
    }
}