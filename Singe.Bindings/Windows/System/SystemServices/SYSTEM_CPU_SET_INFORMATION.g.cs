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
        /// <summary>This structure is returned by GetSystemCpuSetInformation. It is used to enumerate the CPU Sets on the system and determine their current state.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-system_cpu_set_information">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct SYSTEM_CPU_SET_INFORMATION
        {
            /// <summary>This is the size, in bytes, of this information structure.</summary>
            internal uint Size;
            /// <summary>This is the type of information in the structure. Applications should skip any structures with unrecognized types.</summary>
            internal win32.System.SystemServices.CPU_SET_INFORMATION_TYPE Type;
            internal win32.System.SystemServices.SYSTEM_CPU_SET_INFORMATION._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.System.SystemServices.SYSTEM_CPU_SET_INFORMATION._Anonymous_e__Union._CpuSet_e__Struct CpuSet;
                internal partial struct _CpuSet_e__Struct
                {
                    internal uint Id;
                    internal ushort Group;
                    internal byte LogicalProcessorIndex;
                    internal byte CoreIndex;
                    internal byte LastLevelCacheIndex;
                    internal byte NumaNodeIndex;
                    internal byte EfficiencyClass;
                    internal win32.System.SystemServices.SYSTEM_CPU_SET_INFORMATION._Anonymous_e__Union._CpuSet_e__Struct._Anonymous1_e__Union Anonymous1;
                    internal win32.System.SystemServices.SYSTEM_CPU_SET_INFORMATION._Anonymous_e__Union._CpuSet_e__Struct._Anonymous2_e__Union Anonymous2;
                    internal ulong AllocationTag;
                    [StructLayout(LayoutKind.Explicit)]
                    internal partial struct _Anonymous1_e__Union
                    {
                        [FieldOffset(0)]
                        internal byte AllFlags;
                        [FieldOffset(0)]
                        internal win32.System.SystemServices.SYSTEM_CPU_SET_INFORMATION._Anonymous_e__Union._CpuSet_e__Struct._Anonymous1_e__Union._Anonymous_e__Struct Anonymous;
                        internal partial struct _Anonymous_e__Struct
                        {
                            internal byte _bitfield;
                        }
                    }

                    [StructLayout(LayoutKind.Explicit)]
                    internal partial struct _Anonymous2_e__Union
                    {
                        [FieldOffset(0)]
                        internal uint Reserved;
                        [FieldOffset(0)]
                        internal byte SchedulingClass;
                    }
                }
            }
        }
    }
}