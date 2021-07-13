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
        /// <summary>Contains information about a simulated mouse event.</summary>
        /// <remarks>
        /// <para>If the mouse has moved, indicated by **MOUSEEVENTF_MOVE**, **dx** and **dy** specify information about that movement. The information is specified as absolute or relative integer values.</para>
        /// <para>If **MOUSEEVENTF_ABSOLUTE** value is specified, **dx** and **dy** contain normalized absolute coordinates between 0 and 65,535. The event procedure maps these coordinates onto the display surface. Coordinate (0,0) maps onto the upper-left corner of the display surface; coordinate (65535,65535) maps onto the lower-right corner. In a multimonitor system, the coordinates map to the primary monitor.</para>
        /// <para>If **MOUSEEVENTF_VIRTUALDESK** is specified, the coordinates map to the entire virtual desktop.</para>
        /// <para>If the **MOUSEEVENTF_ABSOLUTE** value is not specified, **dx**and **dy** specify movement relative to the previous mouse event (the last reported position). Positive values mean the mouse moved right (or down); negative values mean the mouse moved left (or up).</para>
        /// <para>Relative mouse motion is subject to the effects of the mouse speed and the two-mouse threshold values. A user sets these three values with the **Pointer Speed** slider of the Control Panel's **Mouse Properties** sheet. You can obtain and set these values using the [SystemParametersInfo](/windows/desktop/api/winuser/nf-winuser-systemparametersinfoa) function.</para>
        /// <para>The system applies two tests to the specified relative mouse movement. If the specified distance along either the x or y axis is greater than the first mouse threshold value, and the mouse speed is not zero, the system doubles the distance. If the specified distance along either the x or y axis is greater than the second mouse threshold value, and the mouse speed is equal to two, the system doubles the distance that resulted from applying the first threshold test. It is thus possible for the system to multiply specified relative mouse movement along the x or y axis by up to four times.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct MOUSEINPUT
        {
            /// <summary>
            /// <para>Type: **LONG**</para>
            /// <para>The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the **dwFlags** member. Absolute data is specified as the x coordinate of the mouse; relative data is specified as the number of pixels moved.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int dx;
            /// <summary>
            /// <para>Type: **LONG**</para>
            /// <para>The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the **dwFlags** member. Absolute data is specified as the y coordinate of the mouse; relative data is specified as the number of pixels moved.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int dy;
            /// <summary>
            /// <para>Type: **DWORD**</para>
            /// <para>If **dwFlags** contains **MOUSEEVENTF_WHEEL**, then **mouseData** specifies the amount of wheel movement. A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as **WHEEL_DELTA**, which is 120.</para>
            /// <para>**Windows Vista**: If *dwFlags* contains **MOUSEEVENTF_HWHEEL**, then *dwData* specifies the amount of wheel movement. A positive value indicates that the wheel was rotated to the right; a negative value indicates that the wheel was rotated to the left. One wheel click is defined as **WHEEL_DELTA**, which is 120.</para>
            /// <para>If **dwFlags** does not contain **MOUSEEVENTF_WHEEL**, **MOUSEEVENTF_XDOWN**, or **MOUSEEVENTF_XUP**, then **mouseData** should be zero.</para>
            /// <para>If **dwFlags** contains **MOUSEEVENTF_XDOWN** or **MOUSEEVENTF_XUP**, then **mouseData** specifies which X buttons were pressed or released. This value may be any combination of the following flags.</para>
            /// <para>| Value | Meaning | |-|-| | **XBUTTON1**<br>0x0001 | Set if the first X button is pressed or released. | | **XBUTTON2**<br>0x0002 | Set if the second X button is pressed or released. |</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint mouseData;
            /// <summary>Type: **DWORD**</summary>
            internal win32.UI.KeyboardAndMouseInput.MOUSE_EVENT_FLAGS dwFlags;
            /// <summary>
            /// <para>Type: **DWORD**</para>
            /// <para>The time stamp for the event, in milliseconds. If this parameter is 0, the system will provide its own time stamp.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint time;
            /// <summary>
            /// <para>Type: **ULONG_PTR**</para>
            /// <para>An additional value associated with the mouse event. An application calls [GetMessageExtraInfo](/windows/desktop/api/winuser/nf-winuser-getmessageextrainfo) to obtain this extra information.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mouseinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal nuint dwExtraInfo;
        }
    }
}