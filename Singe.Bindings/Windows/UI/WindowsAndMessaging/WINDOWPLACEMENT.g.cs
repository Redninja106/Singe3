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
        /// <summary>Contains information about the placement of a window on the screen.</summary>
        /// <remarks>
        /// <para>If the window is a top-level window that does not have the <b>WS_EX_TOOLWINDOW</b> window style, then the coordinates represented by the following members are in workspace coordinates: <b>ptMinPosition</b>, <b>ptMaxPosition</b>, and <b>rcNormalPosition</b>. Otherwise, these members are in screen coordinates.</para>
        /// <para>Workspace coordinates differ from screen coordinates in that they take the locations and sizes of application toolbars (including the taskbar) into account. Workspace coordinate (0,0) is the upper-left corner of the workspace area, the area of the screen not being used by application toolbars.</para>
        /// <para>The coordinates used in a <b>WINDOWPLACEMENT</b> structure should be used only by the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getwindowplacement">GetWindowPlacement</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowplacement">SetWindowPlacement</a> functions. Passing workspace coordinates to functions which expect screen coordinates (such as <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowpos">SetWindowPos</a>) will result in the window appearing in the wrong location. For example, if the taskbar is at the top of the screen, saving window coordinates using <b>GetWindowPlacement</b> and restoring them using <b>SetWindowPos</b> causes the window to appear to "creep" up the screen.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct WINDOWPLACEMENT
        {
            /// <summary>
            /// <para>Type: <b>UINT</b> The length of the structure, in bytes. Before calling the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getwindowplacement">GetWindowPlacement</a> or <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowplacement">SetWindowPlacement</a> functions, set this member to <c>sizeof(WINDOWPLACEMENT)</c>.</para>
            /// <para><a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getwindowplacement">GetWindowPlacement</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowplacement">SetWindowPlacement</a> fail if this member is not set correctly.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint length;
            /// <summary>Type: <b>UINT</b></summary>
            internal win32.UI.WindowsAndMessaging.WINDOWPLACEMENT_FLAGS flags;
            /// <summary>
            /// <para>Type: <b>UINT</b></para>
            /// <para>The current show state of the window. It can be any of the values that can be specified in the <i>nCmdShow</i> parameter for the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-showwindow">ShowWindow</a> function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.SHOW_WINDOW_CMD showCmd;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/dd162805(v=vs.85)">POINT</a></b></para>
            /// <para>The coordinates of the window's upper-left corner when the window is minimized.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.POINT ptMinPosition;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/dd162805(v=vs.85)">POINT</a></b></para>
            /// <para>The coordinates of the window's upper-left corner when the window is maximized.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.POINT ptMaxPosition;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b></para>
            /// <para>The window's coordinates when the window is in the restored position.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-windowplacement#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT rcNormalPosition;
        }
    }
}