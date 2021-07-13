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
        /// <summary>Specifies a date and time, using individual members for the month, day, year, weekday, hour, minute, second, and millisecond. The time is either in coordinated universal time (UTC) or local time, depending on the function that is being called.</summary>
        /// <remarks>
        /// <para>> [!NOTE] > The <b>SYSTEMTIME</b> does not check to see if the date represented is a real and valid date. When working with this API, you should ensure its validity, especially in leap year scenarios. See [leap day readiness](https://techcommunity.microsoft.com/t5/azure-developer-community-blog/it-s-2020-is-your-code-ready-for-leap-day/ba-p/1157279) for more information.</para>
        /// <para>It is not recommended that you add and subtract values from the <b>SYSTEMTIME</b> structure to obtain relative times. Instead, you should</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-systemtime#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct SYSTEMTIME
        {
            /// <summary>The year. The valid values for this member are 1601 through 30827.</summary>
            internal ushort wYear;
            /// <summary></summary>
            internal ushort wMonth;
            /// <summary></summary>
            internal ushort wDayOfWeek;
            /// <summary>The day of the month. The valid values for this member are 1 through 31.</summary>
            internal ushort wDay;
            /// <summary>The hour. The valid values for this member are 0 through 23.</summary>
            internal ushort wHour;
            /// <summary>The minute. The valid values for this member are 0 through 59.</summary>
            internal ushort wMinute;
            /// <summary>The second. The valid values for this member are 0 through 59.</summary>
            internal ushort wSecond;
            /// <summary>The millisecond. The valid values for this member are 0 through 999.</summary>
            internal ushort wMilliseconds;
        }
    }
}