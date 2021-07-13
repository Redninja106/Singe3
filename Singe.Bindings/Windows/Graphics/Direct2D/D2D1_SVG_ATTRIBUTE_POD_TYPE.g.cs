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
        /// <summary>Defines the type of SVG POD attribute to set or get.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/ne-d2d1svg-d2d1_svg_attribute_pod_type">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_SVG_ATTRIBUTE_POD_TYPE : uint
        {
            /// <summary>The attribute is a FLOAT.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT = 0U,
            /// <summary>The attribute is a D2D1_COLOR_F.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR = 1U,
            /// <summary>The attribute is a D2D1_FILL_MODE.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE = 2U,
            /// <summary>The attribute is a D2D1_SVG_DISPLAY.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY = 3U,
            /// <summary>The attribute is a D2D1_SVG_OVERFLOW.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW = 4U,
            /// <summary>The attribute is a D2D1_SVG_LINE_CAP.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP = 5U,
            /// <summary>The attribute is a D2D1_SVG_LINE_JOIN.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN = 6U,
            /// <summary>The attribute is a D2D1_SVG_VISIBILITY.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY = 7U,
            /// <summary>The attribute is a D2D1_MATRIX_3X2_F.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX = 8U,
            /// <summary>The attribute is a D2D1_SVG_UNIT_TYPE.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE = 9U,
            /// <summary>The attribute is a D2D1_EXTEND_MODE.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE = 10U,
            /// <summary>The attribute is a D2D1_SVG_PRESERVE_ASPECT_RATIO.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO = 11U,
            /// <summary>The attribute is a D2D1_SVG_VIEWBOX.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX = 12U,
            /// <summary>The attribute is a D2D1_SVG_LENGTH.</summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH = 13U,
            /// <summary></summary>
            D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD = 4294967295U,
        }
    }
}