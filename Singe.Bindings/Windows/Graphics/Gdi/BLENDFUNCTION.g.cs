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

    namespace Graphics.Gdi
    {
        /// <summary>The BLENDFUNCTION structure controls blending by specifying the blending functions for source and destination bitmaps.</summary>
        /// <remarks>
        /// <para>When the <b>AlphaFormat</b> member is AC_SRC_ALPHA, the source bitmap must be 32 bpp. If it is not, the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/nf-wingdi-alphablend">AlphaBlend</a> function will fail.</para>
        /// <para>When the <b>BlendOp</b> member is AC_SRC_OVER, the source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.</para>
        /// <para>If the source bitmap has no per-pixel alpha value (that is, AC_SRC_ALPHA is not set), the <b>SourceConstantAlpha</b> value determines the blend of the source and destination bitmaps, as shown in the following table. Note that SCA is used for <b>SourceConstantAlpha</b> here. Also, SCA is divided by 255 because it has a value that ranges from 0 to 255.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-blendfunction#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct BLENDFUNCTION
        {
            /// <summary>The source blend operation. Currently, the only source and destination blend operation that has been defined is AC_SRC_OVER. For details, see the following Remarks section.</summary>
            internal byte BlendOp;
            /// <summary>Must be zero.</summary>
            internal byte BlendFlags;
            /// <summary>Specifies an alpha transparency value to be used on the entire source bitmap. The <b>SourceConstantAlpha</b> value is combined with any per-pixel alpha values in the source bitmap. If you set <b>SourceConstantAlpha</b> to 0, it is assumed that your image is transparent. Set the <b>SourceConstantAlpha</b> value to 255 (opaque) when you only want to use per-pixel alpha values.</summary>
            internal byte SourceConstantAlpha;
            /// <summary>
            /// <para>This member controls the way the source and destination bitmaps are interpreted. <b>AlphaFormat</b> has the following value.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-blendfunction#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte AlphaFormat;
        }
    }
}