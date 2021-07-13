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
        /// <summary>Contains the scalable metrics associated with minimized windows.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-minimizedmetrics">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct MINIMIZEDMETRICS
        {
            /// <summary>The size of the structure, in bytes. The caller must set this to <c>sizeof(MINIMIZEDMETRICS)</c>.</summary>
            internal uint cbSize;
            /// <summary>The width of minimized windows, in pixels.</summary>
            internal int iWidth;
            /// <summary>The horizontal space between arranged minimized windows, in pixels.</summary>
            internal int iHorzGap;
            /// <summary>The vertical space between arranged minimized windows, in pixels.</summary>
            internal int iVertGap;
            /// <summary></summary>
            internal win32.UI.WindowsAndMessaging.MINIMIZEDMETRICS_ARRANGE iArrange;
        }
    }
}