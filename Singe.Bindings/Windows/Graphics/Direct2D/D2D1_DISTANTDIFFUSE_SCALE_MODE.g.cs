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
        /// <summary>The interpolation mode the effect uses to scale the image to the corresponding kernel unit length. There are six scale modes that range in quality and speed.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_distantdiffuse_scale_mode">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D2D1_DISTANTDIFFUSE_SCALE_MODE : uint
        {
            /// <summary>Samples the nearest single point and uses that. This mode uses less processing time, but outputs the lowest quality image.</summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR = 0U,
            /// <summary>Uses a four point sample and linear interpolation. This mode outputs a higher quality image than nearest neighbor.</summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_LINEAR = 1U,
            /// <summary>Uses a 16 sample cubic kernel for interpolation. This mode uses the most processing time, but outputs a higher quality image.</summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_CUBIC = 2U,
            /// <summary>Uses 4 linear samples within a single pixel for good edge anti-aliasing. This mode is good for scaling down by small amounts on images with few pixels.</summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR = 3U,
            /// <summary>Uses anisotropic filtering to sample a pattern according to the transformed shape of the bitmap.</summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_ANISOTROPIC = 4U,
            /// <summary>
            /// <para>Uses a variable size high quality cubic kernel to perform a pre-downscale the image if downscaling is involved in the transform matrix. Then uses the cubic interpolation mode for the final output.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effects/ne-d2d1effects-d2d1_distantdiffuse_scale_mode#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC = 5U,
            /// <summary></summary>
            D2D1_DISTANTDIFFUSE_SCALE_MODE_FORCE_DWORD = 4294967295U,
        }
    }
}