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
        /// <summary>Contains the arguments passed to a method or property.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//oaidl/ns-oaidl-dispparams">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DISPPARAMS
        {
            /// <summary>An array of arguments.</summary>
            internal unsafe win32.System.OleAutomation.VARIANT*rgvarg;
            /// <summary>The dispatch IDs of the named arguments.</summary>
            internal unsafe int *rgdispidNamedArgs;
            /// <summary>The number of arguments.</summary>
            internal uint cArgs;
            /// <summary>The number of named arguments.</summary>
            internal uint cNamedArgs;
        }
    }
}