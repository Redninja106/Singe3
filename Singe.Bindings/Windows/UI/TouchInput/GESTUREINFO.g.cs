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

    namespace UI.TouchInput
    {
        /// <summary>Stores information about a gesture.</summary>
        /// <remarks>
        /// <para>The <b>HIDWORD</b> of the <b>ullArguments</b> member is always 0, with the following exceptions: </para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-gestureinfo#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct GESTUREINFO
        {
            /// <summary>The size of the structure, in bytes. The caller must set this to <c>sizeof(GESTUREINFO)</c>.</summary>
            internal uint cbSize;
            /// <summary>The state of the gesture.  For additional information, see Remarks.</summary>
            internal uint dwFlags;
            /// <summary>The identifier of the gesture command.</summary>
            internal uint dwID;
            /// <summary>A handle to the window that is targeted by this gesture.</summary>
            internal win32.UI.WindowsAndMessaging.HWND hwndTarget;
            /// <summary>A <b>POINTS</b> structure containing the coordinates associated with the gesture. These coordinates are always relative to the origin of the screen.</summary>
            internal win32.UI.DisplayDevices.POINTS ptsLocation;
            /// <summary>An internally used identifier for the structure.</summary>
            internal uint dwInstanceID;
            /// <summary>An internally used identifier for the sequence.</summary>
            internal uint dwSequenceID;
            /// <summary>A 64-bit unsigned integer that contains the arguments for gestures that fit into 8 bytes.</summary>
            internal ulong ullArguments;
            /// <summary>The size, in bytes, of extra arguments that accompany this gesture.</summary>
            internal uint cbExtraArgs;
        }
    }
}