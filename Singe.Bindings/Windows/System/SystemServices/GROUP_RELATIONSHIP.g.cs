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
        /// <summary>Represents information about processor groups. This structure is used with the GetLogicalProcessorInformationEx function.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-group_relationship">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct GROUP_RELATIONSHIP
        {
            /// <summary>The maximum number of processor groups on the system.</summary>
            internal ushort MaximumGroupCount;
            /// <summary>The number of active groups on the system. This member indicates the number of <a href = "https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-processor_group_info">PROCESSOR_GROUP_INFO</a> structures in the <b>GroupInfo</b> array.</summary>
            internal ushort ActiveGroupCount;
            /// <summary>This member is reserved.</summary>
            internal __byte_20 Reserved;
            /// <summary>An array of <a href = "https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-processor_group_info">PROCESSOR_GROUP_INFO</a> structures. Each structure represents the number and affinity of processors in an active group on the system.</summary>
            internal __win32_System_SystemServices_PROCESSOR_GROUP_INFO_1 GroupInfo;
            internal struct __byte_20
            {
                internal byte _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19;
                /// <summary>Always <c>20</c>.</summary>
                internal int Length => 20;
            }

            internal struct __win32_System_SystemServices_PROCESSOR_GROUP_INFO_1
            {
                internal win32.System.SystemServices.PROCESSOR_GROUP_INFO _0;
                /// <summary>Always <c>1</c>.</summary>
                internal int Length => 1;
            }
        }
    }
}