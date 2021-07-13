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
        /// <summary>Contains the metrics associated with text after layout.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DWRITE_TEXT_METRICS
        {
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>A value that indicates the left-most point of formatted text relative to the layout box, while excluding any glyph overhang.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float left;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>A value that indicates the top-most point of formatted text relative to the layout box, while excluding any glyph overhang.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float top;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>A value that indicates the width of the formatted text, while ignoring trailing whitespace at the end of each line.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float width;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The width of the formatted text, taking into account the trailing whitespace at the end of each line.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float widthIncludingTrailingWhitespace;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The height of the formatted text. The height of an empty string is set to the same value as that of the default font.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float height;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The initial width given to the layout. It can be either larger or smaller than the text content width, depending on whether the text was wrapped.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float layoutWidth;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>Initial height given to the layout. Depending on the length of the text, it may be larger or smaller than the text content height.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float layoutHeight;
            /// <summary>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The maximum reordering count of any line of text, used to calculate the most number of hit-testing boxes needed. If the layout has no bidirectional text, or no text at all, the minimum level is 1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint maxBidiReorderingDepth;
            /// <summary>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Total number of lines.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ns-dwrite-dwrite_text_metrics#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint lineCount;
        }
    }
}