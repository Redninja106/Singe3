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
        [Flags]
        internal enum COMM_EVENT_MASK : uint
        {
            EV_BREAK = 0x00000040,
            EV_CTS = 0x00000008,
            EV_DSR = 0x00000010,
            EV_ERR = 0x00000080,
            EV_EVENT1 = 0x00000800,
            EV_EVENT2 = 0x00001000,
            EV_PERR = 0x00000200,
            EV_RING = 0x00000100,
            EV_RLSD = 0x00000020,
            EV_RX80FULL = 0x00000400,
            EV_RXCHAR = 0x00000001,
            EV_RXFLAG = 0x00000002,
            EV_TXEMPTY = 0x00000004,
        }
    }
}