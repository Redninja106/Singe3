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
        /// <summary>Contains combo box status information.</summary>
        /// <remarks>
        /// <para>The following example code retrieves information about the combo box specified by the window handle.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct COMBOBOXINFO
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">DWORD</a></b></para>
            /// <para>The size, in bytes, of the structure. The calling application must set this to sizeof(COMBOBOXINFO).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cbSize;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that specifies the coordinates of the edit box.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT rcItem;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that specifies the coordinates of the button that contains the drop-down arrow.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT rcButton;
            /// <summary>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">DWORD</a></b></summary>
            internal win32.UI.Controls.COMBOBOXINFO_BUTTON_STATE stateButton;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a></b></para>
            /// <para>A handle to the combo box.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndCombo;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a></b></para>
            /// <para>A handle to the edit box.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndItem;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a></b></para>
            /// <para>A handle to the drop-down list.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-comboboxinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndList;
        }
    }
}