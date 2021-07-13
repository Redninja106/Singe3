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

    namespace UI.KeyboardAndMouseInput
    {
        /// <summary>Describes the format of the raw input from a Human Interface Device (HID).</summary>
        /// <remarks>
        /// <para>Each <a href = "https://docs.microsoft.com/windows/desktop/inputdev/wm-input">WM_INPUT</a> can indicate several inputs, but all of the inputs come from the same HID. The size of the <b>bRawData</b> array is <b>dwSizeHid</b> *	<b>dwCount</b>.</para>
        /// <para>For more information, see <a href = "https://docs.microsoft.com/windows-hardware/drivers/hid/interpreting-hid-reports">Interpreting HID Reports</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawhid#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct RAWHID
        {
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The size, in bytes, of each HID input in <b>bRawData</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawhid#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwSizeHid;
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The number of HID inputs in <b>bRawData</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawhid#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwCount;
            /// <summary>
            /// <para>Type: <b>BYTE[1]</b></para>
            /// <para>The raw input data, as an array of bytes.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawhid#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __byte_1 bRawData;
            internal struct __byte_1
            {
                internal byte _0;
                /// <summary>Always <c>1</c>.</summary>
                internal int Length => 1;
            }
        }
    }
}