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

    namespace System.Console
    {
        internal partial struct INPUT_RECORD
        {
            internal ushort EventType;
            internal win32.System.Console.INPUT_RECORD._Event_e__Union Event;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Event_e__Union
            {
                [FieldOffset(0)]
                internal win32.System.Console.KEY_EVENT_RECORD KeyEvent;
                [FieldOffset(0)]
                internal win32.System.Console.MOUSE_EVENT_RECORD MouseEvent;
                [FieldOffset(0)]
                internal win32.System.Console.WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;
                [FieldOffset(0)]
                internal win32.System.Console.MENU_EVENT_RECORD MenuEvent;
                [FieldOffset(0)]
                internal win32.System.Console.FOCUS_EVENT_RECORD FocusEvent;
            }
        }
    }
}