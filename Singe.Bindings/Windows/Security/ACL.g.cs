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
        /// <summary>Header of an access control list (ACL).</summary>
        /// <remarks>
        /// <para>An ACL includes a sequential list of zero or more ACEs. The individual ACEs in an ACL are numbered from 0 to <i>n</i>, where <i>n</i>+1 is the number of ACEs in the ACL. When editing an ACL, an application refers to an ACE within the ACL by the ACE's index.</para>
        /// <para>There are two types of ACL: discretionary and system.</para>
        /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/SecGloss/d-gly">discretionary access control list</a> (DACL) is controlled by the owner of an object or anyone granted WRITE_DAC access to the object. It specifies the access particular users and groups can have to an object. For example, the owner of a file can use a DACL to control which users and groups can and cannot have access to the file.</para>
        /// <para>An object can also have system-level security information associated with it, in the form of a <a href = "https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">system access control list</a> (SACL) controlled by a system administrator. A SACL  allows the system administrator to audit any attempts to gain access to an object.</para>
        /// <para>For a list of currently defined ACE structures, see <a href = "https://docs.microsoft.com/windows/desktop/SecAuthZ/ace">ACE</a>.</para>
        /// <para>A fourth ACE structure, <a href = "https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-system_alarm_ace">SYSTEM_ALARM_ACE</a>, is not currently supported.</para>
        /// <para>The <b>ACL</b> structure is to be treated as though it were opaque and applications are not to attempt to work with its members directly. To ensure that ACLs are semantically correct, applications can use the functions listed in the See Also section to create and manipulate ACLs.</para>
        /// <para>Each <b>ACL</b> and <a href = "https://docs.microsoft.com/windows/desktop/SecAuthZ/ace">ACE</a> structure begins on a <b>DWORD</b> boundary.</para>
        /// <para>The maximum size for an ACL, including its ACEs, is 64 KB.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-acl#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct ACL
        {
            /// <summary>Specifies the revision level of the ACL. This value should be ACL_REVISION, unless the ACL contains an object-specific ACE, in which case this value must be ACL_REVISION_DS. All ACEs in an ACL must be at the same revision level.</summary>
            internal byte AclRevision;
            /// <summary>Specifies a zero byte of <a href = "https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">padding</a> that aligns the <b>AclRevision</b> member on a 16-bit boundary.</summary>
            internal byte Sbz1;
            /// <summary>Specifies the size, in bytes, of the ACL. This value includes both the <b>ACL</b> structure and all the ACEs.</summary>
            internal ushort AclSize;
            /// <summary>Specifies the number of ACEs stored in the ACL.</summary>
            internal ushort AceCount;
            /// <summary>Specifies two zero-bytes of <a href = "https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">padding</a> that align the <b>ACL</b> structure on a 32-bit boundary.</summary>
            internal ushort Sbz2;
        }
    }
}