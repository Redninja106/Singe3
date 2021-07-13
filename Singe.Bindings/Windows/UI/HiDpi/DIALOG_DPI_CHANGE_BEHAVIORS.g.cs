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

    namespace UI.HiDpi
    {
        /// <summary>In Per Monitor v2 contexts, dialogs will automatically respond to DPI changes by resizing themselves and re-computing the positions of their child windows (here referred to as re-layouting).</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-dialog_dpi_change_behaviors">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum DIALOG_DPI_CHANGE_BEHAVIORS : uint
        {
            /// <summary>The default behavior of the dialog manager. In response to a DPI change, the dialog manager will re-layout each control, update the font on each control, resize the dialog, and update the dialog's own font.</summary>
            DDC_DEFAULT = 0x00000000,
            /// <summary>Prevents the dialog manager from responding to <a href = "https://docs.microsoft.com/windows/desktop/hidpi/wm-getdpiscaledsize">WM_GETDPISCALEDSIZE</a> and <a href = "https://docs.microsoft.com/windows/desktop/hidpi/wm-dpichanged">WM_DPICHANGED</a>, disabling all default DPI scaling behavior.</summary>
            DDC_DISABLE_ALL = 0x00000001,
            /// <summary>Prevents the dialog manager from resizing the dialog in response to a DPI change.</summary>
            DDC_DISABLE_RESIZE = 0x00000002,
            /// <summary>Prevents the dialog manager from re-layouting all of the dialogue's immediate children HWNDs in response to a DPI change.</summary>
            DDC_DISABLE_CONTROL_RELAYOUT = 0x00000004,
        }
    }
}