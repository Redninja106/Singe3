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
        [Flags]
        internal enum CDS_TYPE : uint
        {
            CDS_FULLSCREEN = 0x00000004,
            CDS_GLOBAL = 0x00000008,
            CDS_NORESET = 0x10000000,
            CDS_RESET = 0x40000000,
            CDS_SET_PRIMARY = 0x00000010,
            CDS_TEST = 0x00000002,
            CDS_UPDATEREGISTRY = 0x00000001,
            CDS_VIDEOPARAMETERS = 0x00000020,
            CDS_ENABLE_UNSAFE_MODES = 0x00000100,
            CDS_DISABLE_UNSAFE_MODES = 0x00000200,
            CDS_RESET_EX = 0x20000000,
        }
    }
}