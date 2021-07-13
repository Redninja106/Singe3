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

    namespace Graphics.Direct3D12
    {
        /// <summary>Describes a sub-pixel sample position for use with programmable sample positions.</summary>
        /// <remarks>
        /// <para>Sample positions have the origin (0, 0) at the pixel center. Each of the X and Y coordinates are signed values in the range -8 (top/left) to 7 (bottom/right). Values outside this range are invalid.</para>
        /// <para>Each increment of these integer values represents 1/16th of a pixel. For example, X and Y values of -8 and 4, respectively, correspond to floating-point values of -0.5 and 0.25, a point located on the left-most edge of the pixel, half-way between its center-line and the bottom edge. Because of this, the bottom-most and right-most edge of a pixel are not reachable by sampling (these positions are reachable as the top-most and left-most edges of the neighboring pixels).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_sample_position#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_SAMPLE_POSITION
        {
            /// <summary>A signed sub-pixel coordinate value in the X axis.</summary>
            internal sbyte X;
            /// <summary>A signed sub-pixel coordinate value in the Y axis.</summary>
            internal sbyte Y;
        }
    }
}