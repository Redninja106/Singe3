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

    namespace Storage.Packaging.Appx
    {
        /// <summary>The AppPolicyCreateFileAccess enumeration indicates whether a process has full or restricted access to the IO devices (file, file stream, directory, physical disk, volume, console buffer, tape drive, communications resource, mailslot, and pipe).</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//appmodel/ne-appmodel-apppolicycreatefileaccess">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum AppPolicyCreateFileAccess
        {
            /// <summary>Indicates that the process has full access to the IO devices. This value is expected for a desktop application, or for a Desktop Bridge application.</summary>
            AppPolicyCreateFileAccess_Full = 0,
            /// <summary>Indicates that the process has limited access to the IO devices. This value is expected for a UWP app.</summary>
            AppPolicyCreateFileAccess_Limited = 1,
        }
    }
}