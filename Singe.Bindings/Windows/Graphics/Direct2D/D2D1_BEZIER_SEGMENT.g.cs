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
        /// <summary>Represents a cubic bezier segment drawn between two points.</summary>
        /// <remarks>
        /// <para>A cubic Bezier curve is defined by four points: a start point, an end point (<i>point3</i>), and two control points (<i>point1</i> and <i>point2</i>). A Bezier segment does not contain a property for the starting point of the curve; it defines only the end point. The beginning point of the curve is the current point of the path to which the Bezier curve is added.</para>
        /// <para>The two control points of a cubic Bezier curve behave like magnets, attracting portions of what would otherwise be a straight line toward themselves and producing a curve. The first control point, <i>point1</i>, affects the beginning portion of the curve; the second control point, <i>point2</i>, affects the ending portion of the curve.</para>
        /// <para><div class = "alert"><b>Note</b>  The curve doesn't necessarily pass through either of the control points; each control point moves its portion of the line toward itself, but not through itself.</div> <div> </div></para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bezier_segment#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_BEZIER_SEGMENT
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/Direct2D/d2d1-point-2f">D2D1_POINT_2F</a></b></para>
            /// <para>The first control point for the Bezier segment.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bezier_segment#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D_POINT_2F point1;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/Direct2D/d2d1-point-2f">D2D1_POINT_2F</a></b></para>
            /// <para>The second control point for the Bezier segment.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bezier_segment#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D_POINT_2F point2;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/Direct2D/d2d1-point-2f">D2D1_POINT_2F</a></b></para>
            /// <para>The end point for the Bezier segment.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/ns-d2d1-d2d1_bezier_segment#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D_POINT_2F point3;
        }
    }
}