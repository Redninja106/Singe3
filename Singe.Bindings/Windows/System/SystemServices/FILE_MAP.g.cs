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

    namespace System.SystemServices
    {
        [Flags]
        internal enum FILE_MAP : uint
        {
            FILE_MAP_WRITE = 0x00000002,
            FILE_MAP_READ = 0x00000004,
            FILE_MAP_ALL_ACCESS = 0x000F001F,
            FILE_MAP_EXECUTE = 0x00000020,
            FILE_MAP_COPY = 0x00000001,
            FILE_MAP_RESERVE = 0x80000000,
            FILE_MAP_TARGETS_INVALID = 0x40000000,
            FILE_MAP_LARGE_PAGES = 0x20000000,
        }
    }
}