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
        internal enum DRAWSTATE_FLAGS : uint
        {
            DST_COMPLEX = 0x00000000,
            DST_TEXT = 0x00000001,
            DST_PREFIXTEXT = 0x00000002,
            DST_ICON = 0x00000003,
            DST_BITMAP = 0x00000004,
            DSS_NORMAL = 0x00000000,
            DSS_UNION = 0x00000010,
            DSS_DISABLED = 0x00000020,
            DSS_MONO = 0x00000080,
            DSS_HIDEPREFIX = 0x00000200,
            DSS_PREFIXONLY = 0x00000400,
            DSS_RIGHT = 0x00008000,
        }
    }
}