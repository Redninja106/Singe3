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

    namespace Media.MediaFoundation
    {
        /// <summary>Specifies a type of compressed buffer for decoding.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_video_decoder_buffer_type">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_VIDEO_DECODER_BUFFER_TYPE
        {
            /// <summary>Picture decoding parameter buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS = 0,
            /// <summary>Macroblock control command buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL = 1,
            /// <summary>Residual difference block data buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE = 2,
            /// <summary>Deblocking filter control command buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL = 3,
            /// <summary>Inverse quantization matrix buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX = 4,
            /// <summary>Slice-control buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL = 5,
            /// <summary>Bitstream data buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_BITSTREAM = 6,
            /// <summary>Motion vector buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR = 7,
            /// <summary>Film grain synthesis data buffer.</summary>
            D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN = 8,
        }
    }
}