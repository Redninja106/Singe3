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
        /// <summary>Describes the stroke that outlines a shape.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_STROKE_STYLE_PROPERTIES1
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_cap_style">D2D1_CAP_STYLE</a></b></para>
            /// <para>The cap to use at the start of each open figure.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_CAP_STYLE startCap;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_cap_style">D2D1_CAP_STYLE</a></b></para>
            /// <para>The cap to use at the end of each open figure.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_CAP_STYLE endCap;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_cap_style">D2D1_CAP_STYLE</a></b></para>
            /// <para>The cap to use at the start and end of each dash.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_CAP_STYLE dashCap;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_line_join">D2D1_LINE_JOIN</a></b></para>
            /// <para>The line join to use.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_LINE_JOIN lineJoin;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The limit beyond which miters are either clamped or converted to bevels.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float miterLimit;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_dash_style">D2D1_DASH_STYLE</a></b></para>
            /// <para>The type of dash to use.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_DASH_STYLE dashStyle;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The location of the first dash, relative to the start of the figure.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float dashOffset;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_stroke_transform_type">D2D1_STROKE_TRANSFORM_TYPE</a></b></para>
            /// <para>The rule that determines what render target properties affect the nib of the stroke.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_STROKE_TRANSFORM_TYPE transformType;
        }
    }
}