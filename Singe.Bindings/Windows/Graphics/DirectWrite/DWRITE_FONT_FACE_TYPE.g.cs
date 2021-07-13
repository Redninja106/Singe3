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
        /// <summary>Indicates the file format of a complete font face.</summary>
        /// <remarks>
        /// <para>Font formats that consist of multiple files, such as Type 1 .PFM and .PFB, have a single enum entry.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/ne-dwrite-dwrite_font_face_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum DWRITE_FONT_FACE_TYPE
        {
            /// <summary>OpenType font face with CFF outlines.</summary>
            DWRITE_FONT_FACE_TYPE_CFF = 0,
            /// <summary>OpenType font face with TrueType outlines.</summary>
            DWRITE_FONT_FACE_TYPE_TRUETYPE = 1,
            /// <summary></summary>
            DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION = 2,
            /// <summary>A Type 1 font face.</summary>
            DWRITE_FONT_FACE_TYPE_TYPE1 = 3,
            /// <summary>A vector .FON format font face.</summary>
            DWRITE_FONT_FACE_TYPE_VECTOR = 4,
            /// <summary>A bitmap .FON format font face.</summary>
            DWRITE_FONT_FACE_TYPE_BITMAP = 5,
            /// <summary>Font face type is not recognized by the DirectWrite font system.</summary>
            DWRITE_FONT_FACE_TYPE_UNKNOWN = 6,
            /// <summary>The font data includes only the CFF table from an OpenType CFF font. This font face type can be used only for embedded fonts (i.e., custom font file loaders) and the resulting font face object supports only the minimum functionality necessary to render glyphs.</summary>
            DWRITE_FONT_FACE_TYPE_RAW_CFF = 7,
            /// <summary>OpenType font face that is a part of a TrueType collection.</summary>
            DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION = 2,
        }
    }
}