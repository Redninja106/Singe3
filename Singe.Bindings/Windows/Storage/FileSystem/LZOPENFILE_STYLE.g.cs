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
        [Flags]
        internal enum LZOPENFILE_STYLE : uint
        {
            OF_CANCEL = 0x00000800,
            OF_CREATE = 0x00001000,
            OF_DELETE = 0x00000200,
            OF_EXIST = 0x00004000,
            OF_PARSE = 0x00000100,
            OF_PROMPT = 0x00002000,
            OF_READ = 0x00000000,
            OF_READWRITE = 0x00000002,
            OF_REOPEN = 0x00008000,
            OF_SHARE_DENY_NONE = 0x00000040,
            OF_SHARE_DENY_READ = 0x00000030,
            OF_SHARE_DENY_WRITE = 0x00000020,
            OF_SHARE_EXCLUSIVE = 0x00000010,
            OF_WRITE = 0x00000001,
            OF_SHARE_COMPAT = 0x00000000,
            OF_VERIFY = 0x00000400,
        }
    }
}