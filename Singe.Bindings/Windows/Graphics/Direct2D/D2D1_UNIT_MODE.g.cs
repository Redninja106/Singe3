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
        /// <summary>Specifies how units in Direct2D will be interpreted.</summary>
        /// <remarks>
        /// <para>Setting the unit mode to <b>D2D1_UNIT_MODE_PIXELS</b> is similar to setting the <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nn-d2d1_1-id2d1devicecontext">ID2D1DeviceContext</a> dots per inch (dpi) to 96. However, Direct2D still checks the dpi to determine the threshold for enabling vertical antialiasing for text, and when the unit mode is restored, the dpi will be remembered.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ne-d2d1_1-d2d1_unit_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_UNIT_MODE : uint
        {
            /// <summary>Units will be interpreted as device-independent pixels (1/96").</summary>
            D2D1_UNIT_MODE_DIPS = 0U,
            /// <summary>Units will be interpreted as pixels.</summary>
            D2D1_UNIT_MODE_PIXELS = 1U,
            /// <summary></summary>
            D2D1_UNIT_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}