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
        /// <summary>Contains the scalable metrics associated with the nonclient area of a nonminimized window.</summary>
        /// <remarks>
        /// <para>If the <b>iPaddedBorderWidth</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-nonclientmetricsa">NONCLIENTMETRICS</a> structure is present, this structure is 4 bytes larger than for an application that is compiled with <b>_WIN32_WINNT</b> less than or equal to 0x0502. For more information about conditional compilation, see <a href = "https://docs.microsoft.com/windows/desktop/WinProg/using-the-windows-headers">Using the Windows Headers</a>.</para>
        /// <para><b>Windows Server 2003 and Windows XP/2000:  </b>If an application  that is compiled for Windows Server 2008 or Windows Vista must also run on Windows Server 2003 or Windows XP/2000, use the <a href = "https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-getversionexa">GetVersionEx</a> function to check the operating system version at run time and, if the application is running on Windows Server 2003 or Windows XP/2000, subtract the size of the <b>iPaddedBorderWidth</b> member from the <b>cbSize</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-nonclientmetricsa">NONCLIENTMETRICS</a> structure before calling the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-systemparametersinfoa">SystemParametersInfo</a> function.</para>
        /// <para>> [!NOTE] > The winuser.h header defines NONCLIENTMETRICS as an alias which automatically selects the ANSI or Unicode version of this function based on the definition of the UNICODE preprocessor constant. Mixing usage of the encoding-neutral alias with code that not encoding-neutral can lead to mismatches that result in compilation or runtime errors. For more information, see [Conventions for Function Prototypes](/windows/win32/intl/conventions-for-function-prototypes).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-nonclientmetricsa#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct NONCLIENTMETRICSA
        {
            /// <summary>The size of the structure, in bytes. The caller must set this to <c>sizeof(NONCLIENTMETRICS)</c>. For   information about application compatibility, see Remarks.</summary>
            internal uint cbSize;
            /// <summary>The thickness of the sizing border, in pixels. The default is 1 pixel.</summary>
            internal int iBorderWidth;
            /// <summary>The width of a standard vertical scroll bar, in pixels.</summary>
            internal int iScrollWidth;
            /// <summary>The height of a standard horizontal scroll bar, in pixels.</summary>
            internal int iScrollHeight;
            /// <summary>The width of caption buttons, in pixels.</summary>
            internal int iCaptionWidth;
            /// <summary>The height of caption buttons, in pixels.</summary>
            internal int iCaptionHeight;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-logfonta">LOGFONT</a> structure that contains information about the caption font.</summary>
            internal win32.Graphics.Gdi.LOGFONTA lfCaptionFont;
            /// <summary>The width of small caption buttons, in pixels.</summary>
            internal int iSmCaptionWidth;
            /// <summary>The height of small captions, in pixels.</summary>
            internal int iSmCaptionHeight;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-logfonta">LOGFONT</a> structure that contains information about the small caption font.</summary>
            internal win32.Graphics.Gdi.LOGFONTA lfSmCaptionFont;
            /// <summary>The width of menu-bar buttons, in pixels.</summary>
            internal int iMenuWidth;
            /// <summary>The height of a menu bar, in pixels.</summary>
            internal int iMenuHeight;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-logfonta">LOGFONT</a> structure that contains information about the font used in menu bars.</summary>
            internal win32.Graphics.Gdi.LOGFONTA lfMenuFont;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-logfonta">LOGFONT</a> structure that contains information about the font used in status bars and tooltips.</summary>
            internal win32.Graphics.Gdi.LOGFONTA lfStatusFont;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-logfonta">LOGFONT</a> structure that contains information about the font used in message boxes.</summary>
            internal win32.Graphics.Gdi.LOGFONTA lfMessageFont;
            /// <summary>
            /// <para>The thickness of the padded border, in pixels. The default value is 4 pixels. The <b>iPaddedBorderWidth</b> and <b>iBorderWidth</b> members are combined for both resizable and nonresizable windows in  the Windows Aero desktop experience. To compile an application that uses this member, define <b>_WIN32_WINNT</b> as 0x0600 or later. For more information, see Remarks.</para>
            /// <para><b>Windows Server 2003 and Windows XP/2000:  </b>This member is not supported.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-nonclientmetricsa#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int iPaddedBorderWidth;
        }
    }
}