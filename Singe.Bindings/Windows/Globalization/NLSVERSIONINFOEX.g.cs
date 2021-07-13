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

    namespace Globalization
    {
        /// <summary>Contains version information about an NLS capability.</summary>
        /// <remarks>
        /// <para>The <b>dwNLSVersion</b> and <b>dwDefinedVersion</b> members are completely independent. Although each member is defined for a single DWORD, actually each is composed of a major version and a minor version. See <a href = "https://docs.microsoft.com/windows/desktop/Intl/handling-sorting-in-your-applications">Handling Sorting in Your Applications</a> for more information.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnls/ns-winnls-nlsversioninfoex#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct NLSVERSIONINFOEX
        {
            /// <summary>Size, in bytes, of the structure.</summary>
            internal uint dwNLSVersionInfoSize;
            /// <summary>Version. This value is used to track changes and additions to the set of code points that have the indicated capability for a particular locale. The value is locale-specific, and increments when the capability changes. For example, using the COMPARE_STRING capability defined by the <a href = "https://docs.microsoft.com/windows/desktop/api/winnls/ne-winnls-sysnls_function">SYSNLS_FUNCTION</a> enumeration, the version changes if sorting weights are assigned to code points that previously had no weights defined for the locale.</summary>
            internal uint dwNLSVersion;
            /// <summary>
            /// <para>Defined version. This value is used to track changes in the repertoire of Unicode code points. The value increments when the Unicode repertoire is extended, for example, if more characters are defined.</para>
            /// <para><b>Starting with Windows 8:</b> Deprecated. Use <b>dwNLSVersion</b> instead.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnls/ns-winnls-nlsversioninfoex#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwDefinedVersion;
            /// <summary>
            /// <para>Identifier of the sort order used for the input locale for the represented version. For example, for a custom locale en-Mine that uses 0409 for a sort order identifier, this member contains "0409". If this member specifies a "real" sort, <b>guidCustomVersion</b> is set to an empty GUID.</para>
            /// <para><b>Starting with Windows 8:</b> Deprecated. Use <b>guidCustomVersion</b> instead.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winnls/ns-winnls-nlsversioninfoex#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwEffectiveId;
            /// <summary>Unique GUID for the behavior of a custom sort used by the locale for the represented version.</summary>
            internal global::System.Guid guidCustomVersion;
        }
    }
}