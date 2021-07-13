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
        /// <summary>Indicates the screen orientation preference for a desktop app process.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-orientation_preference">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum ORIENTATION_PREFERENCE
        {
            /// <summary>The process has no device orientation preferences. The system may choose any available setting.</summary>
            ORIENTATION_PREFERENCE_NONE = 0,
            /// <summary>The process represents a desktop app that can be used in landscape mode.</summary>
            ORIENTATION_PREFERENCE_LANDSCAPE = 1,
            /// <summary>The process represents a desktop app that can be used in portrait mode.</summary>
            ORIENTATION_PREFERENCE_PORTRAIT = 2,
            /// <summary>The process represents a desktop app that can be used in flipped landscape mode.</summary>
            ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 4,
            /// <summary>The process represents a desktop app that can be used in flipped portrait mode.</summary>
            ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 8,
        }
    }
}