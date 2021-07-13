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
        /// <summary>Identifiers for the properties of the Arithmetic composite effect.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_arithmeticcomposite_prop">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_ARITHMETICCOMPOSITE_PROP : uint
        {
            /// <summary>
            /// <para>The coefficients for the equation used to composite the two input images. The coefficients are unitless and unbounded.</para>
            /// <para>Type is D2D1_VECTOR_4F. Default value is {1.0f, 0.0f, 0.0f, 0.0f}.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_arithmeticcomposite_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_ARITHMETICCOMPOSITE_PROP_COEFFICIENTS = 0U,
            /// <summary>
            /// <para>The effect clamps color values to between 0 and 1 before the effect passes the values to the next effect in the graph. If you set this to TRUE the effect will clamp the values. If you set this to FALSE, the effect will not clamp the color values, but other effects and the output surface may clamp the values if they are not of high enough precision.</para>
            /// <para>Type is BOOL. Default value is FALSE.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_arithmeticcomposite_prop#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_ARITHMETICCOMPOSITE_PROP_CLAMP_OUTPUT = 1U,
            /// <summary></summary>
            D2D1_ARITHMETICCOMPOSITE_PROP_FORCE_DWORD = 4294967295U,
        }
    }
}