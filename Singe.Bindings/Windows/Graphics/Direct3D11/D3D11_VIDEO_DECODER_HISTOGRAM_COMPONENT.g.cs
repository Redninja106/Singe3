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

    namespace Graphics.Direct3D11
    {
        /// <summary>Specifies indices for arrays of per component histogram infromation.</summary>
        /// <remarks>
        /// <para>The [D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS](ne-d3d11_4-d3d11_video_decoder_histogram_component_flags.md) is the flags enumeration used by [D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM](ns-d3d11_4-d3d11_feature_data_video_decoder_histogram.md) to allow you to specify one or more components for which histogram data is queried.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_4/ne-d3d11_4-d3d11_video_decoder_histogram_component#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT
        {
            /// <summary>If the format is a YUV format, indicates a histogram for the Y component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y = 0,
            /// <summary>If the format is a YUV format, indicates a histogram for the U component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U = 1,
            /// <summary>If the format is a YUV format, indicates a histogram for the V component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V = 2,
            /// <summary>If the format is an RGB/BGR format, indicates a histogram for the R component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R = 0,
            /// <summary>If the format is an RGB/BGR format, indicates a histogram for the G component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G = 1,
            /// <summary>If the format is an RGB/BGR format, indicates a histogram for the B component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B = 2,
            /// <summary>If the format has an alpha channel, indicates a histogram for the A component.</summary>
            D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A = 3,
        }
    }
}