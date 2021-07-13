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
        /// <summary>Specifies the way a function is invoked.</summary>
        /// <remarks>
        /// <para>In C, value assignment is written as *pobj1 = *pobj2, while reference assignment is written as pobj1 = pobj2. Other languages have other syntactic conventions. A property or data member can support only a value assignment, a reference assignment, or both. The INVOKEKIND enumeration constants are the same constants that are passed to <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/oaidl/nf-oaidl-idispatch-invoke">IDispatch::Invoke</a> to specify the way in which a function is invoked.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//oaidl/ne-oaidl-invokekind#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum INVOKEKIND
        {
            /// <summary>The member is called using a normal function invocation syntax.</summary>
            INVOKE_FUNC = 1,
            /// <summary>The function is invoked using a normal property-access syntax.</summary>
            INVOKE_PROPERTYGET = 2,
            /// <summary>The function is invoked using a property value assignment syntax. Syntactically, a typical programming language might represent changing a property in the same way as assignment. For example: object.property : = value.</summary>
            INVOKE_PROPERTYPUT = 4,
            /// <summary>The function is invoked using a property reference assignment syntax.</summary>
            INVOKE_PROPERTYPUTREF = 8,
        }
    }
}