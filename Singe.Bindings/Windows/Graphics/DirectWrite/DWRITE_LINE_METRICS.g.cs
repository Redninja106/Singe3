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

    namespace Graphics.DirectWrite
    {
        /// <summary>Contains information about a formatted line of text.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DWRITE_LINE_METRICS
        {
            /// <summary>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of text positions in the text line. This includes any trailing whitespace and newline characters.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint length;
            /// <summary>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of whitespace positions at the end of the text line. Newline sequences are considered whitespace.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint trailingWhitespaceLength;
            /// <summary>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of characters in the newline sequence at the end of the text line. If the count is zero, then the text line was either wrapped or it is the end of the text.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint newlineLength;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The height of the text line.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float height;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The distance from the top of the text line to its baseline.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float baseline;
            /// <summary>
            /// <para>Type: <b>BOOL</b></para>
            /// <para>The line is trimmed.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_line_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL isTrimmed;
        }
    }
}