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

    namespace System.WindowsProgramming
    {
        /// <summary>Contains operating system version information. The information includes major and minor version numbers, a build number, a platform identifier, and information about product suites and the latest Service Pack installed on the system.</summary>
        /// <remarks>
        /// <para>Relying on version information is not the best way to test for a feature. Instead, refer to the documentation for the feature of interest. For more information on common techniques for feature detection, see <a href = "https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</a>.</para>
        /// <para>If you must require a particular operating system, be sure to use it as a minimum supported version, rather than design the test for the one operating system. This way, your detection code will continue to work on future versions of Windows.</para>
        /// <para>The following table summarizes the values returned by supported versions of Windows. Use the information in the  column labeled "Other" to distinguish between operating systems with identical version numbers.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct OSVERSIONINFOEXW
        {
            /// <summary>
            /// <para>The size of this data structure, in bytes. Set this member to <c>sizeof(OSVERSIONINFOEX)</c>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwOSVersionInfoSize;
            /// <summary>The major version number of the operating system. For more information, see Remarks.</summary>
            internal uint dwMajorVersion;
            /// <summary>The minor version number of the operating system. For more information, see Remarks.</summary>
            internal uint dwMinorVersion;
            /// <summary>The build number of the operating system.</summary>
            internal uint dwBuildNumber;
            /// <summary>The operating system platform. This member can be <b>VER_PLATFORM_WIN32_NT</b> (2).</summary>
            internal uint dwPlatformId;
            /// <summary>
            /// <para>A null-terminated string, such as "Service Pack 3", that indicates the latest Service Pack installed on the system. If no Service Pack has been installed, the string is empty.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal __char_128 szCSDVersion;
            /// <summary>
            /// <para>The major version number of the latest Service Pack installed on the system. For example, for Service Pack 3, the major version number is 3. If no Service Pack has been installed, the value is zero.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wServicePackMajor;
            /// <summary>
            /// <para>The minor version number of the latest Service Pack installed on the system. For example, for Service Pack 3, the minor version number is 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wServicePackMinor;
            /// <summary>
            /// <para>A bit mask that identifies the product suites available on the system. This member can be a combination of the following values.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-osversioninfoexw#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ushort wSuiteMask;
            /// <summary></summary>
            internal byte wProductType;
            /// <summary>Reserved for future use.</summary>
            internal byte wReserved;
            internal struct __char_128
            {
                internal char _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84, _85, _86, _87, _88, _89, _90, _91, _92, _93, _94, _95, _96, _97, _98, _99, _100, _101, _102, _103, _104, _105, _106, _107, _108, _109, _110, _111, _112, _113, _114, _115, _116, _117, _118, _119, _120, _121, _122, _123, _124, _125, _126, _127;
                /// <summary>Always <c>128</c>.</summary>
                internal int Length => 128;
            }
        }
    }
}