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

    namespace UI.WindowsAndMessaging
    {
        [DebuggerDisplay("{Value}")]
        internal readonly partial struct WPARAM : IEquatable<WPARAM>
        {
            internal readonly nuint Value;
            internal WPARAM(nuint value) => this.Value = value;
            public static implicit operator nuint(WPARAM value) => value.Value;
            public static implicit operator WPARAM(nuint value) => new WPARAM(value);
            public bool Equals(WPARAM other) => this.Value == other.Value;
            public override bool Equals(object obj) => obj is WPARAM other && this.Equals(other);
            public override int GetHashCode() => this.Value.GetHashCode();
        }
    }
}