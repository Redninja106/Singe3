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
        /// <summary>Represents a point, radius pair that makes up part of a D2D1_INK_BEZIER_SEGMENT.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ns-d2d1_3-d2d1_ink_point">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_INK_POINT
        {
            /// <summary>The x-coordinate of the point.</summary>
            internal float x;
            /// <summary>The y-coordinate of the point.</summary>
            internal float y;
            /// <summary>The radius of this point. Corresponds to the width of the ink stroke at this point in the stroke.</summary>
            internal float radius;
        }
    }
}