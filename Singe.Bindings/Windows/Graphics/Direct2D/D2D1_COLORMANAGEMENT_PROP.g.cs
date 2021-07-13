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
        /// <summary>Identifiers for the properties of the Color management effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_COLORMANAGEMENT_PROP : uint
        {
            /// <summary>
            /// <para>The source color space information.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nn-d2d1_1-id2d1colorcontext">ID2D1ColorContext</a>. The default value is NULL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT = 0U,
            /// <summary>
            /// <para>Which ICC rendering intent to use.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_colormanagement_rendering_intent">D2D1_COLORMANAGEMENT_RENDERING_INTENT</a>. The default value is D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT = 1U,
            /// <summary>
            /// <para>The destination color space information.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nn-d2d1_1-id2d1colorcontext">ID2D1ColorContext</a>. The default value is NULL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT = 2U,
            /// <summary>
            /// <para>Which ICC rendering intent to use.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_colormanagement_rendering_intent">D2D1_COLORMANAGEMENT_RENDERING_INTENT</a>. The default value is D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT = 3U,
            /// <summary>
            /// <para>How to interpret alpha data that is contained in the input image.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_colormanagement_alpha_mode">D2D1_COLORMANAGEMENT_ALPHA_MODE</a>. The default value is D2D1_COLORMANAGEMENT_ALPHA_MODE_PREMULTIPLIED.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE = 4U,
            /// <summary>
            /// <para>The quality level of the transform.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effects/ne-d2d1effects-d2d1_colormanagement_quality">D2D1_COLORMANAGEMENT_QUALITY</a>. The default value is D2D1_COLORMANAGEMENT_QUALITY_NORMAL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_colormanagement_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_COLORMANAGEMENT_PROP_QUALITY = 5U,
            /// <summary></summary>
            D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}