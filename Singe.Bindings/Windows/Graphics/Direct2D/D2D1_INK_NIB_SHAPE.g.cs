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
        /// <summary>Specifies the appearance of the ink nib (pen tip) as part of an D2D1_INK_STYLE_PROPERTIES structure.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_ink_nib_shape">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_INK_NIB_SHAPE : uint
        {
            /// <summary>The pen tip is circular.</summary>
            D2D1_INK_NIB_SHAPE_ROUND = 0U,
            /// <summary>The pen tip is square.</summary>
            D2D1_INK_NIB_SHAPE_SQUARE = 1U,
            /// <summary></summary>
            D2D1_INK_NIB_SHAPE_FORCE_DWORD = 4294967295U,
        }
    }
}