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
        /// <summary>Contains window information.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct WINDOWINFO
        {
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The size of the structure, in bytes. The caller must set this member to <c>sizeof(WINDOWINFO)</c>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cbSize;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b></para>
            /// <para>The coordinates of the window.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT rcWindow;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b></para>
            /// <para>The coordinates of the client area.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT rcClient;
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The window styles. For a table of window styles, see <a href = "https://docs.microsoft.com/windows/desktop/winmsg/window-styles">Window Styles</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwStyle;
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The extended window styles. For a table of extended window styles, see <a href = "https://docs.microsoft.com/windows/desktop/winmsg/extended-window-styles">Extended Window Styles</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwExStyle;
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The window status. If this member is <b>WS_ACTIVECAPTION</b> (0x0001), the window is active. Otherwise, this member is zero.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwWindowStatus;
            /// <summary>
            /// <para>Type: <b>UINT</b></para>
            /// <para>The width of the window border, in pixels.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cxWindowBorders;
            /// <summary>
            /// <para>Type: <b>UINT</b></para>
            /// <para>The height of the window border, in pixels.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cyWindowBorders;
            /// <summary>
            /// <para>Type: <b>ATOM</b></para>
            /// <para>The window class atom (see <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassa">RegisterClass</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort atomWindowType;
            /// <summary>
            /// <para>Type: <b>WORD</b></para>
            /// <para>The Windows version of the application that created the window.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wCreatorVersion;
        }
    }
}