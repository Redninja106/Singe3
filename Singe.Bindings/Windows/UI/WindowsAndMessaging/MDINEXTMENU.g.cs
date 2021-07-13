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
        /// <summary>Contains information about the menu to be activated.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdinextmenu">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct MDINEXTMENU
        {
            /// <summary>
            /// <para>Type: <b>HMENU</b></para>
            /// <para>A handle to the current menu.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdinextmenu#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.MenusAndResources.HMENU hmenuIn;
            /// <summary>
            /// <para>Type: <b>HMENU</b></para>
            /// <para>A handle to the menu to be activated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdinextmenu#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.MenusAndResources.HMENU hmenuNext;
            /// <summary>
            /// <para>Type: <b>HWND</b></para>
            /// <para>A handle to the window to receive the menu notification messages.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdinextmenu#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndNext;
        }
    }
}