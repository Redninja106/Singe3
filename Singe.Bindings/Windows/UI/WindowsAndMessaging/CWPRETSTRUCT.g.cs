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
        /// <summary>Defines the message parameters passed to a WH_CALLWNDPROCRET hook procedure, CallWndRetProc.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct CWPRETSTRUCT
        {
            /// <summary>
            /// <para>Type: <b>LRESULT</b></para>
            /// <para>The return value of the window procedure that processed the message specified by the <b>message</b> value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.LRESULT lResult;
            /// <summary>
            /// <para>Type: <b>LPARAM</b></para>
            /// <para>Additional information about the message. The exact meaning depends on the <b>message</b> value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.LPARAM lParam;
            /// <summary>
            /// <para>Type: <b>WPARAM</b></para>
            /// <para>Additional information about the message. The exact meaning depends on the <b>message</b> value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.WPARAM wParam;
            /// <summary>
            /// <para>Type: <b>UINT</b></para>
            /// <para>The message.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint message;
            /// <summary>
            /// <para>Type: <b>HWND</b></para>
            /// <para>A handle to the window that processed the message specified by the <b>message</b> value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cwpretstruct#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwnd;
        }
    }
}