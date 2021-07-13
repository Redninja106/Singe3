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

    namespace UI.KeyboardAndMouseInput
    {
        /// <summary>Contains the raw input from a device.</summary>
        /// <remarks>
        /// <para>The handle to this structure is passed in the <i>lParam</i> parameter of <a href = "https://docs.microsoft.com/windows/desktop/inputdev/wm-input">WM_INPUT</a>.</para>
        /// <para>To get detailed information -- such as the header and the content of the raw input -- call <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getrawinputdata">GetRawInputData</a>.</para>
        /// <para>To read the <b>RAWINPUT</b> in the message loop as a buffered read, call <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getrawinputbuffer">GetRawInputBuffer</a>.</para>
        /// <para>To get device specific information, call <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getrawinputdeviceinfoa">GetRawInputDeviceInfo</a> with the <i>hDevice</i> from <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-rawinputheader">RAWINPUTHEADER</a>.</para>
        /// <para>Raw input is available only when the application calls <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerrawinputdevices">RegisterRawInputDevices</a> with valid device specifications.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawinput#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct RAWINPUT
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-rawinputheader">RAWINPUTHEADER</a></b></para>
            /// <para>The raw input data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.KeyboardAndMouseInput.RAWINPUTHEADER header;
            /// <summary></summary>
            internal win32.UI.KeyboardAndMouseInput.RAWINPUT._data_e__Union data;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _data_e__Union
            {
                [FieldOffset(0)]
                internal win32.UI.KeyboardAndMouseInput.RAWMOUSE mouse;
                [FieldOffset(0)]
                internal win32.UI.KeyboardAndMouseInput.RAWKEYBOARD keyboard;
                [FieldOffset(0)]
                internal win32.UI.KeyboardAndMouseInput.RAWHID hid;
            }
        }
    }
}