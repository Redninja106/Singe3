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
        /// <summary>Identifiers for properties of the Opacity metadata effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_opacitymetadata_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_OPACITYMETADATA_PROP : uint
        {
            /// <summary>
            /// <para>The portion of the source image that is opaque. The default is the entire input image.</para>
            /// <para>The type is <a href = "https://docs.microsoft.com/windows/desktop/api/dcommon/ns-dcommon-d2d_vector_4f">D2D1_VECTOR_4F</a>. The default is {-FLT_MAX, -FLT_MAX, FLT_MAX, FLT_MAX}.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_opacitymetadata_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_OPACITYMETADATA_PROP_INPUT_OPAQUE_RECT = 0U,
            /// <summary></summary>
            D2D1_OPACITYMETADATA_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}