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

    namespace System.Kernel
    {
        /// <summary>Represents a logical processor in a processor group.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-processor_number">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct PROCESSOR_NUMBER
        {
            /// <summary>The processor group to which the logical processor is assigned.</summary>
            internal ushort Group;
            /// <summary>The number of the logical processor relative to the group.</summary>
            internal byte Number;
            /// <summary>This parameter is reserved.</summary>
            internal byte Reserved;
        }
    }
}