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

    namespace UI.TouchInput
    {
        [Flags]
        internal enum TOUCHEVENTF_FLAGS : uint
        {
            TOUCHEVENTF_MOVE = 0x00000001,
            TOUCHEVENTF_DOWN = 0x00000002,
            TOUCHEVENTF_UP = 0x00000004,
            TOUCHEVENTF_INRANGE = 0x00000008,
            TOUCHEVENTF_PRIMARY = 0x00000010,
            TOUCHEVENTF_NOCOALESCE = 0x00000020,
            TOUCHEVENTF_PEN = 0x00000040,
            TOUCHEVENTF_PALM = 0x00000080,
        }
    }
}