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
        [DebuggerDisplay("{Value}")]
        internal readonly partial struct HPOWERNOTIFY : IEquatable<HPOWERNOTIFY>
        {
            internal readonly IntPtr Value;
            internal HPOWERNOTIFY(IntPtr value) => this.Value = value;
            internal bool IsNull => Value == default;
            public static implicit operator IntPtr(HPOWERNOTIFY value) => value.Value;
            public static explicit operator HPOWERNOTIFY(IntPtr value) => new HPOWERNOTIFY(value);
            public bool Equals(HPOWERNOTIFY other) => this.Value == other.Value;
            public override bool Equals(object obj) => obj is HPOWERNOTIFY other && this.Equals(other);
            public override int GetHashCode() => this.Value.GetHashCode();
        }
    }
}