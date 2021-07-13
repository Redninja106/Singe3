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
        /// <summary>Contains information passed to a WH_CBT hook procedure, CBTProc, before a window is created.</summary>
        /// <remarks>
        /// <para>> [!NOTE] > The winuser.h header defines CBT_CREATEWND as an alias which automatically selects the ANSI or Unicode version of this function based on the definition of the UNICODE preprocessor constant. Mixing usage of the encoding-neutral alias with code that not encoding-neutral can lead to mismatches that result in compilation or runtime errors. For more information, see [Conventions for Function Prototypes](/windows/win32/intl/conventions-for-function-prototypes).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cbt_createwnda#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct CBT_CREATEWNDA
        {
            /// <summary>
            /// <para>Type: <b>LPCREATESTRUCT</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-createstructa">CREATESTRUCT</a> structure that contains initialization parameters for the window about to be created.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cbt_createwnda#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.UI.WindowsAndMessaging.CREATESTRUCTA*lpcs;
            /// <summary>
            /// <para>Type: <b>HWND</b></para>
            /// <para>A handle to the window whose position in the Z order precedes that of the window being created. This member can also be <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-cbt_createwnda#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndInsertAfter;
        }
    }
}