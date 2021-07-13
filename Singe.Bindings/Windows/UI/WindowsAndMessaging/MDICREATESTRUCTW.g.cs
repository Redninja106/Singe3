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
        /// <summary>Contains information about the class, title, owner, location, and size of a multiple-document interface (MDI) child window.</summary>
        /// <remarks>
        /// <para>When the MDI client window creates an MDI child window by calling <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-createwindowa">CreateWindow</a>, the system sends a <a href = "https://docs.microsoft.com/windows/desktop/winmsg/wm-create">WM_CREATE</a> message to the created window. The <i>lParam</i> member of the <b>WM_CREATE</b> message contains a pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-createstructa">CREATESTRUCT</a> structure. The <b>lpCreateParams</b> member of this structure contains a pointer to the <b>MDICREATESTRUCT</b> structure passed with the <a href = "https://docs.microsoft.com/windows/desktop/winmsg/wm-mdicreate">WM_MDICREATE</a> message that created the MDI child window.</para>
        /// <para>> [!NOTE] > The winuser.h header defines MDICREATESTRUCT as an alias which automatically selects the ANSI or Unicode version of this function based on the definition of the UNICODE preprocessor constant. Mixing usage of the encoding-neutral alias with code that not encoding-neutral can lead to mismatches that result in compilation or runtime errors. For more information, see [Conventions for Function Prototypes](/windows/win32/intl/conventions-for-function-prototypes).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct MDICREATESTRUCTW
        {
            /// <summary>
            /// <para>Type: <b>LPCTSTR</b></para>
            /// <para>The name of the window class of the MDI child window. The class name must have been registered by a previous call to the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassa">RegisterClass</a> function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCWSTR szClass;
            /// <summary>
            /// <para>Type: <b>LPCTSTR</b></para>
            /// <para>The title of the MDI child window. The system displays the title in the child window's title bar.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCWSTR szTitle;
            /// <summary>
            /// <para>Type: <b>HANDLE</b></para>
            /// <para>A handle to the instance of the application creating the MDI client window.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.HANDLE hOwner;
            /// <summary>
            /// <para>Type: <b>int</b></para>
            /// <para>The initial horizontal position, in client coordinates, of the MDI child window. If this member is <b>CW_USEDEFAULT</b>, the MDI child window is assigned the default horizontal position.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int x;
            /// <summary>
            /// <para>Type: <b>int</b></para>
            /// <para>The initial vertical position, in client coordinates, of the MDI child window. If this member is <b>CW_USEDEFAULT</b>, the MDI child window is assigned the default vertical position.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int y;
            /// <summary>
            /// <para>Type: <b>int</b></para>
            /// <para>The initial width, in device units, of the MDI child window. If this member is <b>CW_USEDEFAULT</b>, the MDI child window is assigned the default width.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int cx;
            /// <summary>
            /// <para>Type: <b>int</b></para>
            /// <para>The initial height, in device units, of the MDI child window. If this member is set to <b>CW_USEDEFAULT</b>, the MDI child window is assigned the default height.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int cy;
            /// <summary>Type: <b>DWORD</b></summary>
            internal win32.UI.WindowsAndMessaging.WINDOW_STYLE style;
            /// <summary>
            /// <para>Type: <b>LPARAM</b></para>
            /// <para>An application-defined value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-mdicreatestructw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.WindowsAndMessaging.LPARAM lParam;
        }
    }
}