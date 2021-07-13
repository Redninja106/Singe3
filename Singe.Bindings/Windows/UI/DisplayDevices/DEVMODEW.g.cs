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

    namespace UI.DisplayDevices
    {
        /// <summary>The DEVMODEW structure is used for specifying characteristics of display and print devices in the Unicode (wide) character set.</summary>
        /// <remarks>
        /// <para>The <a href = "https://docs.microsoft.com/windows-hardware/drivers/display/the-devmodew-structure">DEVMODEW structure</a> is the Unicode version of the <a href = "https://docs.microsoft.com/previous-versions//ms535771(v=vs.85)">DEVMODE </a> structure (described in the Microsoft Windows SDK documentation). While applications can use either the ANSI or Unicode version of the structure, drivers are required to use the Unicode version.</para>
        /// <para>For printer drivers, the DEVMODEW structure is used for specifying printer characteristics required by a print document. It is also used for specifying a printer's default characteristics.</para>
        /// <para>Immediately following a DEVMODEW structure's defined members (often referred to as its public members), there can be a set of driver-defined members (often referred to as private DEVMODEW members). The driver supplies the size, in bytes, of this private area in <b>dmDriverExtra</b>. Driver-defined private members are for exclusive use by the driver. The starting address for the private members can be referenced using the <b>dmSize</b> member as follows:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DEVMODEW
        {
            /// <summary>
            /// <para>For a display, specifies the name of the display driver's DLL; for example, "perm3dd" for the 3Dlabs Permedia3 display driver.</para>
            /// <para>For a printer, specifies the "friendly name"; for example, "PCL/HP LaserJet" in the case of PCL/HP LaserJet. If the name is greater than CCHDEVICENAME characters in length, the spooler truncates it to fit in the array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __char_32 dmDeviceName;
            /// <summary>Specifies the version number of this DEVMODEW structure. The current version number is identified by the DM_SPECVERSION constant in <i>wingdi.h</i>.</summary>
            internal ushort dmSpecVersion;
            /// <summary>
            /// <para>For a printer, specifies the printer driver version number assigned by the printer driver developer.</para>
            /// <para>Display drivers can set this member to DM_SPECVERSION.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort dmDriverVersion;
            /// <summary>Specifies the size in bytes of the public DEVMODEW structure, not including any private, driver-specified members identified by the <b>dmDriverExtra</b> member.</summary>
            internal ushort dmSize;
            /// <summary>Specifies the number of bytes of private driver data that follow the public structure members. If a device driver does not provide private DEVMODEW members, this member should be set to zero.</summary>
            internal ushort dmDriverExtra;
            /// <summary>Specifies bit flags identifying which of the following DEVMODEW members are in use. For example, the DM_ORIENTATION flag is set when the <b>dmOrientation</b> member contains valid data. The DM_XXX flags are defined in <i>wingdi.h</i>.</summary>
            internal uint dmFields;
            internal win32.UI.DisplayDevices.DEVMODEW._Anonymous1_e__Union Anonymous1;
            /// <summary>
            /// <para>For printers, specifies whether a color printer should print color or monochrome. This member can be one of DMCOLOR_COLOR or DMCOLOR_MONOCHROME.</para>
            /// <para>This member is not used for displays.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal short dmColor;
            /// <summary></summary>
            internal short dmDuplex;
            /// <summary>
            /// <para>For printers, specifies the <i>y</i> resolution of the printer, in DPI. If this member is used, the <b>dmPrintQuality</b> member specifies the <i>x</i> resolution.</para>
            /// <para>This member is not used for displays.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal short dmYResolution;
            /// <summary>
            /// <para>For printers, specifies how TrueType fonts should be printed. This member must be one of the DMTT-prefixed constants defined in <i>wingdi.h</i>.</para>
            /// <para>This member is not used for displays.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal short dmTTOption;
            /// <summary></summary>
            internal short dmCollate;
            /// <summary>
            /// <para>For printers, specifies the name of the form to use; such as "Letter" or "Legal". This must be a name that can be obtain by calling the Win32 <b>EnumForms</b> function (described in the Microsoft Window SDK documentation).</para>
            /// <para>This member is not used for displays.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __char_32 dmFormName;
            /// <summary>
            /// <para>For displays, specifies the number of logical pixels per inch of a display device and should be equal to the <b>ulLogPixels</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/winddi/ns-winddi-gdiinfo">GDIINFO</a> structure.</para>
            /// <para>This member is not used for printers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort dmLogPixels;
            /// <summary>
            /// <para>For displays, specifies the color resolution, in bits per pixel, of a display device.</para>
            /// <para>This member is not used for printers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dmBitsPerPel;
            /// <summary>
            /// <para>For displays, specifies the width, in pixels, of the visible device surface.</para>
            /// <para>This member is not used for printers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dmPelsWidth;
            /// <summary>
            /// <para>For displays, specifies the height, in pixels, of the visible device surface.</para>
            /// <para>This member is not used for printers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dmPelsHeight;
            internal win32.UI.DisplayDevices.DEVMODEW._Anonymous2_e__Union Anonymous2;
            /// <summary>
            /// <para>For displays, specifies the frequency, in hertz, of a display device in its current mode.</para>
            /// <para>This member is not used for printers.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-devmodew#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dmDisplayFrequency;
            /// <summary>Specifies one of the DMICMMETHOD-prefixed constants defined in <i>wingdi.h</i>.</summary>
            internal uint dmICMMethod;
            /// <summary>Specifies one of the DMICM-prefixed constants defined in <i>wingdi.h</i>.</summary>
            internal uint dmICMIntent;
            /// <summary>Specifies one of the DMMEDIA-prefixed constants defined in <i>wingdi.h</i>.</summary>
            internal uint dmMediaType;
            /// <summary>Specifies one of the DMDITHER-prefixed constants defined in <i>wingdi.h</i>.</summary>
            internal uint dmDitherType;
            /// <summary>Is reserved for system use and should be ignored by the driver.</summary>
            internal uint dmReserved1;
            /// <summary>Is reserved for system use and should be ignored by the driver.</summary>
            internal uint dmReserved2;
            /// <summary>Is reserved for system use and should be ignored by the driver.</summary>
            internal uint dmPanningWidth;
            /// <summary>Is reserved for system use and should be ignored by the driver.</summary>
            internal uint dmPanningHeight;
            internal struct __char_32
            {
                internal char _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31;
                /// <summary>Always <c>32</c>.</summary>
                internal int Length => 32;
            }

            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous1_e__Union
            {
                [FieldOffset(0)]
                internal win32.UI.DisplayDevices.DEVMODEW._Anonymous1_e__Union._Anonymous1_e__Struct Anonymous1;
                [FieldOffset(0)]
                internal win32.UI.DisplayDevices.DEVMODEW._Anonymous1_e__Union._Anonymous2_e__Struct Anonymous2;
                internal partial struct _Anonymous1_e__Struct
                {
                    internal short dmOrientation;
                    internal short dmPaperSize;
                    internal short dmPaperLength;
                    internal short dmPaperWidth;
                    internal short dmScale;
                    internal short dmCopies;
                    internal short dmDefaultSource;
                    internal short dmPrintQuality;
                }

                internal partial struct _Anonymous2_e__Struct
                {
                    internal win32.UI.DisplayDevices.POINTL dmPosition;
                    internal uint dmDisplayOrientation;
                    internal uint dmDisplayFixedOutput;
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous2_e__Union
            {
                [FieldOffset(0)]
                internal uint dmDisplayFlags;
                [FieldOffset(0)]
                internal uint dmNup;
            }
        }
    }
}