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
        /// <summary>Specifies the alpha fill mode for video processing.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_video_processor_alpha_fill_mode">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE
        {
            /// <summary>Alpha values inside the target rectangle are set to opaque.</summary>
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE = 0,
            /// <summary>Alpha values inside the target rectangle are set to the alpha value specified in the background color. To set the background color, call the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputbackgroundcolor">ID3D11VideoContext::VideoProcessorSetOutputBackgroundColor</a> method.</summary>
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND = 1,
            /// <summary>Existing alpha values remain unchanged in the output surface.</summary>
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION = 2,
            /// <summary>
            /// <para>Alpha values are taken from an  input stream, scaled, and copied to the corresponding destination rectangle for that stream. The input stream is specified in the <i>StreamIndex</i> parameter of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputalphafillmode">ID3D11VideoContext::VideoProcessorSetOutputAlphaFillMode</a> method.</para>
            /// <para>If the input stream does not have alpha data, the video processor sets the alpha values in the target rectangle to opaque. If the input stream is disabled or the source rectangle is empty, the alpha values in the target rectangle are not modified.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_video_processor_alpha_fill_mode#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
        }
    }
}