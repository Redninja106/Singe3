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
        /// <summary>Contains information about a menu.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct MENUINFO
        {
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The size of the structure, in bytes. The caller must set this member to <c>sizeof(MENUINFO)</c>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cbSize;
            /// <summary>Type: <b>DWORD</b></summary>
            internal win32.UI.WindowsAndMessaging.MENUINFO_MASK fMask;
            /// <summary>Type: <b>DWORD</b></summary>
            internal win32.UI.WindowsAndMessaging.MENUINFO_STYLE dwStyle;
            /// <summary>
            /// <para>Type: <b>UINT</b></para>
            /// <para>The maximum height of the menu in pixels. When the menu items exceed the space available, scroll bars are automatically used. The default (0) is the screen height.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint cyMax;
            /// <summary>
            /// <para>Type: <b>HBRUSH</b></para>
            /// <para>A handle to the brush to be used for the menu's background.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Gdi.HBRUSH hbrBack;
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The context help identifier. This is the same value used in the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getmenucontexthelpid">GetMenuContextHelpId</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setmenucontexthelpid">SetMenuContextHelpId</a> functions.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwContextHelpID;
            /// <summary>
            /// <para>Type: <b>ULONG_PTR</b></para>
            /// <para>An application-defined value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-menuinfo#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal nuint dwMenuData;
        }
    }
}