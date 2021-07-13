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

    namespace Graphics.Direct2D
    {
        /// <summary>Defines constants that identify the top level properties of the White Level Adjustment effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects_2/ne-d2d1effects_2-d2d1_whiteleveladjustment_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_WHITELEVELADJUSTMENT_PROP : uint
        {
            /// <summary>Identifies the `InputWhiteLevel` property of the effect. The property is of type FLOAT, and is specified in nits.</summary>
            D2D1_WHITELEVELADJUSTMENT_PROP_INPUT_WHITE_LEVEL = 0U,
            /// <summary>Identifies the `OutputWhiteLevel` property of the effect. The property is of type FLOAT, and is specified in nits.</summary>
            D2D1_WHITELEVELADJUSTMENT_PROP_OUTPUT_WHITE_LEVEL = 1U,
            /// <summary></summary>
            D2D1_WHITELEVELADJUSTMENT_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}