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
        /// <summary>Specifies the flip and rotation at which an image appears.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_orientation">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_ORIENTATION : uint
        {
            /// <summary>The orientation is unchanged.</summary>
            D2D1_ORIENTATION_DEFAULT = 1U,
            /// <summary>The image is flipped horizontally.</summary>
            D2D1_ORIENTATION_FLIP_HORIZONTAL = 2U,
            /// <summary>The image is rotated clockwise 180 degrees.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE180 = 3U,
            /// <summary>The image is rotated clockwise 180 degrees, then flipped horizontally.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL = 4U,
            /// <summary>The image is rotated clockwise 90 degrees, then flipped horizontally.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL = 5U,
            /// <summary>The image is rotated clockwise 270 degrees.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE270 = 6U,
            /// <summary>The image is rotated clockwise 270 degrees, then flipped horizontally.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL = 7U,
            /// <summary>The image is rotated clockwise 90 degrees.</summary>
            D2D1_ORIENTATION_ROTATE_CLOCKWISE90 = 8U,
            /// <summary></summary>
            D2D1_ORIENTATION_FORCE_DWORD = 4294967295U,
        }
    }
}