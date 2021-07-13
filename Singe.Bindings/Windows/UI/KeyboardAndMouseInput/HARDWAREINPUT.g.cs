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
        /// <summary>Contains information about a simulated message generated by an input device other than a keyboard or mouse.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-hardwareinput">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct HARDWAREINPUT
        {
            /// <summary>
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The message generated by the input hardware.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-hardwareinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint uMsg;
            /// <summary>
            /// <para>Type: <b>WORD</b></para>
            /// <para>The low-order word of the <i>lParam </i> parameter for <b>uMsg</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-hardwareinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wParamL;
            /// <summary>
            /// <para>Type: <b>WORD</b></para>
            /// <para>The high-order word of the <i>lParam </i> parameter for <b>uMsg</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-hardwareinput#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wParamH;
        }
    }
}