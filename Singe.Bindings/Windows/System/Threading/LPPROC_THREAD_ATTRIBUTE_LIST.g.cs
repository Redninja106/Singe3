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

    namespace System.Threading
    {
        [DebuggerDisplay("{Value}")]
        internal unsafe readonly partial struct LPPROC_THREAD_ATTRIBUTE_LIST : IEquatable<LPPROC_THREAD_ATTRIBUTE_LIST>
        {
            internal readonly void *Value;
            internal LPPROC_THREAD_ATTRIBUTE_LIST(void *value) => this.Value = value;
            public static implicit operator void *(LPPROC_THREAD_ATTRIBUTE_LIST value) => value.Value;
            public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(void *value) => new LPPROC_THREAD_ATTRIBUTE_LIST(value);
            public bool Equals(LPPROC_THREAD_ATTRIBUTE_LIST other) => this.Value == other.Value;
            public override bool Equals(object obj) => obj is LPPROC_THREAD_ATTRIBUTE_LIST other && this.Equals(other);
            public override int GetHashCode() => unchecked((int)this.Value);
        }
    }
}