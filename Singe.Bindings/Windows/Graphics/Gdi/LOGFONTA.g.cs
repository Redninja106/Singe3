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

    namespace Graphics.Gdi
    {
        /// <summary>The LOGFONT structure defines the attributes of a font.</summary>
        /// <remarks>
        /// <para>The following situations do not support ClearType antialiasing:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-logfonta#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct LOGFONTA
        {
            /// <summary>
            /// <para>The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the character cell height value minus the internal-leading value. The font mapper interprets the value specified in <b>lfHeight</b> in the following manner.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-logfonta#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int lfHeight;
            /// <summary>The average width, in logical units, of characters in the font. If <b>lfWidth</b> is zero, the aspect ratio of the device is matched against the digitization aspect ratio of the available fonts to find the closest match, determined by the absolute value of the difference.</summary>
            internal int lfWidth;
            /// <summary>
            /// <para>The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base line of a row of text.</para>
            /// <para>When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of the string's characters.</para>
            /// <para>When the graphics mode is set to GM_COMPATIBLE, <b>lfEscapement</b> specifies both the escapement and orientation. You should set <b>lfEscapement</b> and <b>lfOrientation</b> to the same value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-logfonta#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int lfEscapement;
            /// <summary>The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</summary>
            internal int lfOrientation;
            /// <summary>
            /// <para>The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.</para>
            /// <para>The following values are defined for convenience.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-logfonta#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int lfWeight;
            /// <summary>An italic font if set to <b>TRUE</b>.</summary>
            internal byte lfItalic;
            /// <summary>An underlined font if set to <b>TRUE</b>.</summary>
            internal byte lfUnderline;
            /// <summary>A strikeout font if set to <b>TRUE</b>.</summary>
            internal byte lfStrikeOut;
            /// <summary>
            /// <para>The character set. The following values are predefined.</para>
            /// <para><dl> <dd>ANSI_CHARSET</dd> <dd>BALTIC_CHARSET</dd> <dd>CHINESEBIG5_CHARSET</dd> <dd>DEFAULT_CHARSET</dd> <dd>EASTEUROPE_CHARSET</dd> <dd>GB2312_CHARSET</dd> <dd>GREEK_CHARSET</dd> <dd>HANGUL_CHARSET</dd> <dd>MAC_CHARSET</dd> <dd>OEM_CHARSET</dd> <dd>RUSSIAN_CHARSET</dd> <dd>SHIFTJIS_CHARSET</dd> <dd>SYMBOL_CHARSET</dd> <dd>TURKISH_CHARSET</dd> <dd>VIETNAMESE_CHARSET</dd> </dl> <b>Korean language edition of Windows:</b></para>
            /// <para><dl> <dd>JOHAB_CHARSET</dd> </dl> <b>Middle East language edition of Windows:</b></para>
            /// <para><dl> <dd>ARABIC_CHARSET</dd> <dd>HEBREW_CHARSET</dd> </dl> <b>Thai language edition of Windows:</b></para>
            /// <para><dl> <dd>THAI_CHARSET</dd> </dl></para>
            /// <para>The OEM_CHARSET value specifies a character set that is operating-system dependent.</para>
            /// <para>DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is set as ANSI_CHARSET.</para>
            /// <para>Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not attempt to translate or interpret strings that are rendered with that font.</para>
            /// <para>This parameter is important in the font mapping process. To ensure consistent results, specify a specific character set. If you specify a typeface name in the <b>lfFaceName</b> member, make sure that the <b>lfCharSet</b> value matches the character set of the typeface specified in <b>lfFaceName</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-logfonta#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte lfCharSet;
            /// <summary></summary>
            internal byte lfOutPrecision;
            /// <summary></summary>
            internal byte lfClipPrecision;
            /// <summary></summary>
            internal byte lfQuality;
            /// <summary></summary>
            internal byte lfPitchAndFamily;
            /// <summary>A null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 <b>TCHAR</b> values, including the terminating <b>NULL</b>. The <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/nf-wingdi-enumfontfamiliesexa">EnumFontFamiliesEx</a> function can be used to enumerate the typeface names of all currently available fonts. If <b>lfFaceName</b> is an empty string, GDI uses the first font that matches the other specified attributes.</summary>
            internal __win32_System_SystemServices_CHAR_32 lfFaceName;
            internal struct __win32_System_SystemServices_CHAR_32
            {
                internal win32.System.SystemServices.CHAR _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31;
                /// <summary>Always <c>32</c>.</summary>
                internal int Length => 32;
            }
        }
    }
}