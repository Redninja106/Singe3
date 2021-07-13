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

    namespace Graphics.Direct2D
    {
        /// <summary>Describes the antialiasing mode used for drawing text.</summary>
        /// <remarks>
        /// <para>This enumeration is used with the <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settextantialiasmode">SetTextAntialiasMode</a> of an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1rendertarget">ID2D1RenderTarget</a> to specify how text and glyphs are antialiased.</para>
        /// <para>By default, Direct2D renders text in ClearType mode. Factors that</para>
        /// <para>can downgrade the default quality to grayscale or aliased:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ne-d2d1-d2d1_text_antialias_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_TEXT_ANTIALIAS_MODE : uint
        {
            /// <summary>Use the system default. See Remarks.</summary>
            D2D1_TEXT_ANTIALIAS_MODE_DEFAULT = 0U,
            /// <summary>Use ClearType antialiasing.</summary>
            D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE = 1U,
            /// <summary>Use grayscale antialiasing.</summary>
            D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE = 2U,
            /// <summary>Do not use antialiasing.</summary>
            D2D1_TEXT_ANTIALIAS_MODE_ALIASED = 3U,
            /// <summary></summary>
            D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}