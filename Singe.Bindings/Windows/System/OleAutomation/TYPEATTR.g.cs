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

    namespace System.OleAutomation
    {
        /// <summary>Contains attributes of a type.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//oaidl/ns-oaidl-typeattr">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct TYPEATTR
        {
            /// <summary>The GUID of the type information.</summary>
            internal global::System.Guid guid;
            /// <summary>The locale of member names and documentation strings.</summary>
            internal uint lcid;
            /// <summary>Reserved.</summary>
            internal uint dwReserved;
            /// <summary>The constructor ID, or MEMBERID_NIL if none.</summary>
            internal int memidConstructor;
            /// <summary>The destructor ID, or MEMBERID_NIL if none.</summary>
            internal int memidDestructor;
            /// <summary>Reserved.</summary>
            internal win32.System.SystemServices.PWSTR lpstrSchema;
            /// <summary>The size of an instance of this type.</summary>
            internal uint cbSizeInstance;
            /// <summary>The kind of type.</summary>
            internal win32.System.OleAutomation.TYPEKIND typekind;
            /// <summary>The number of functions.</summary>
            internal ushort cFuncs;
            /// <summary>The number of variables or data members.</summary>
            internal ushort cVars;
            /// <summary>The number of implemented interfaces.</summary>
            internal ushort cImplTypes;
            /// <summary>The size of this type's VTBL.</summary>
            internal ushort cbSizeVft;
            /// <summary>The byte alignment for an instance of this type. A value of 0 indicates alignment on the 64K boundary; 1 indicates no special alignment. For other values, <i>n</i> indicates aligned on byte <i>n</i>.</summary>
            internal ushort cbAlignment;
            /// <summary>The type flags. See <a href = "https://docs.microsoft.com/windows/desktop/api/oaidl/ne-oaidl-typeflags">TYPEFLAGS</a>.</summary>
            internal ushort wTypeFlags;
            /// <summary>The major version number.</summary>
            internal ushort wMajorVerNum;
            /// <summary>The minor version number.</summary>
            internal ushort wMinorVerNum;
            /// <summary>If <b>typekind</b> is TKIND_ALIAS, specifies the type for which this type is an alias.</summary>
            internal win32.System.OleAutomation.TYPEDESC tdescAlias;
            /// <summary>The IDL attributes of the described type.</summary>
            internal win32.System.OleAutomation.IDLDESC idldescType;
        }
    }
}