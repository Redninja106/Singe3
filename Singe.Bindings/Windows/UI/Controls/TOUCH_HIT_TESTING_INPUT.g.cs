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

    namespace UI.Controls
    {
        /// <summary>Contains information about the touch contact area reported by the touch digitizer.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-touch_hit_testing_input">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct TOUCH_HIT_TESTING_INPUT
        {
            /// <summary>The ID of the pointer. You cannot pass this value to the input message process and  retrieve additional pointer info through <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getpointerinfo">GetPointerInfo</a>.</summary>
            internal uint pointerId;
            /// <summary>The screen coordinates of the touch point that the touch digitizer reports.</summary>
            internal win32.UI.DisplayDevices.POINT point;
            /// <summary>
            /// <para>The bounding rectangle of the touch contact area. Valid touch targets are identified and scored based on this bounding box.</para>
            /// <para><div class = "alert"><b>Note</b>  This bounding box may differ from the contact area that the digitizer reports when: </para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-touch_hit_testing_input#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.UI.DisplayDevices.RECT boundingBox;
            /// <summary>The touch contact area within a specific targeted window that's not occluded by other objects that are higher in the z-order. Any area that's occluded by another object is an invalid target.</summary>
            internal win32.UI.DisplayDevices.RECT nonOccludedBoundingBox;
            /// <summary>The orientation of the touch contact area.</summary>
            internal uint orientation;
        }
    }
}