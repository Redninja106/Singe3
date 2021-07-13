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

    namespace UI.Controls
    {
        /// <summary>Identifies the pointer device cursor types.</summary>
        /// <remarks>
        /// <para>Cursor objects represent pointing and selecting devices used with digitizer devices, most commonly tactile contacts on touch digitizers and tablet pens on pen digitizers. Physical pens may have multiple tips (such as normal and eraser ends), with each pen tip representing a different cursor object. Each cursor object has an associated cursor identifier.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-pointer_device_cursor_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum POINTER_DEVICE_CURSOR_TYPE
        {
            /// <summary>Unidentified cursor.</summary>
            POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0,
            /// <summary>Pen tip.</summary>
            POINTER_DEVICE_CURSOR_TYPE_TIP = 1,
            /// <summary>Pen eraser.</summary>
            POINTER_DEVICE_CURSOR_TYPE_ERASER = 2,
            /// <summary>Forces this enumeration to compile to 32 bits in size. Without this value, some compilers would allow this enumeration to compile to a size other than 32 bits. You should not use this value.</summary>
            POINTER_DEVICE_CURSOR_TYPE_MAX = -1,
        }
    }
}