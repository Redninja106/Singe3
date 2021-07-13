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

    namespace Security
    {
        /// <summary>Contains the security information associated with an object.</summary>
        /// <remarks>
        /// <para>A security descriptor includes information that specifies the following components of an object's security:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-security_descriptor#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct SECURITY_DESCRIPTOR
        {
            internal byte Revision;
            internal byte Sbz1;
            internal ushort Control;
            internal win32.Security.PSID Owner;
            internal win32.Security.PSID Group;
            internal unsafe win32.Security.ACL*Sacl;
            internal unsafe win32.Security.ACL*Dacl;
        }
    }
}