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

    namespace Storage.FileSystem
    {
        /// <summary>Defines values that are used with the FindFirstFileEx function to specify the type of filtering to perform.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-findex_search_ops">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum FINDEX_SEARCH_OPS
        {
            /// <summary>
            /// <para>The search for a file that matches a specified file name.</para>
            /// <para>The <i>lpSearchFilter</i> parameter of <a href = "https://docs.microsoft.com/windows/desktop/api/fileapi/nf-fileapi-findfirstfileexa">FindFirstFileEx</a> must be <b>NULL</b> when this search operation is used.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-findex_search_ops#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            FindExSearchNameMatch = 0,
            /// <summary>
            /// <para>This is an advisory flag. If the file system supports directory filtering, the function searches for a file that matches the specified  name and is also a directory. If the file system does not support directory filtering, this flag is silently ignored.</para>
            /// <para>The <i>lpSearchFilter</i> parameter of the <a href = "https://docs.microsoft.com/windows/desktop/api/fileapi/nf-fileapi-findfirstfileexa">FindFirstFileEx</a> function must be <b>NULL</b> when this search value is used.</para>
            /// <para>If directory filtering is desired, this flag can be used on all file systems, but because it is  an advisory flag and  only affects file systems that support it, the application must examine the file attribute data stored in the <i>lpFindFileData</i> parameter of the <a href = "https://docs.microsoft.com/windows/desktop/api/fileapi/nf-fileapi-findfirstfileexa">FindFirstFileEx</a> function to determine whether the function has  returned a handle to a directory.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-findex_search_ops#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            FindExSearchLimitToDirectories = 1,
            /// <summary>
            /// <para>This filtering type is not available.</para>
            /// <para>For more information, see <a href = "https://docs.microsoft.com/windows-hardware/drivers/install/overview-of-device-interface-classes">Device Interface Classes</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-findex_search_ops#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            FindExSearchLimitToDevices = 2,
            /// <summary></summary>
            FindExSearchMaxSearchOp = 3,
        }
    }
}