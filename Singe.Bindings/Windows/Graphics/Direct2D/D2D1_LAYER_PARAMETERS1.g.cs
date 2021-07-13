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
        /// <summary>Contains the content bounds, mask information, opacity settings, and other options for a layer resource.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D2D1_LAYER_PARAMETERS1
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-f">D2D1_RECT_F</a></b></para>
            /// <para>The content bounds of the layer. Content outside these bounds is not guaranteed to render.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D_RECT_F contentBounds;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/nn-d2d1-id2d1geometry">ID2D1Geometry</a>*</b></para>
            /// <para>The geometric mask specifies the area of the layer that is composited into the render target.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Graphics.Direct2D.ID2D1Geometry*geometricMask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_antialias_mode">D2D1_ANTIALIAS_MODE</a></b></para>
            /// <para>A value that specifies the antialiasing mode for the geometricMask.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_ANTIALIAS_MODE maskAntialiasMode;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a></b></para>
            /// <para>A value that specifies the transform that is applied to the geometric mask when composing the layer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D_MATRIX_3X2_F maskTransform;
            /// <summary>
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>An opacity value that is applied uniformly to all resources in the layer when compositing to the target.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float opacity;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/nn-d2d1-id2d1brush">ID2D1Brush</a>*</b></para>
            /// <para>A brush that is used to modify the opacity of the layer. The brush is mapped to the layer, and the alpha channel of each mapped brush pixel is multiplied against the corresponding layer pixel.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Graphics.Direct2D.ID2D1Brush*opacityBrush;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_layer_options1">D2D1_LAYER_OPTIONS1</a></b></para>
            /// <para>Additional options for the layer creation.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/ns-d2d1_1-d2d1_layer_parameters1#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct2D.D2D1_LAYER_OPTIONS1 layerOptions;
        }
    }
}