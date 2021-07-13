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

    namespace Graphics.Dxgi
    {
        /// <summary>Indicates options for presenting frames to the swap chain.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_3/ns-dxgi1_3-dxgi_frame_statistics_media">DXGI_FRAME_STATISTICS_MEDIA</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_3/ne-dxgi1_3-dxgi_frame_presentation_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum DXGI_FRAME_PRESENTATION_MODE
        {
            /// <summary>
            /// <para>Specifies that the presentation mode is a composition surface, meaning that the conversion from YUV to RGB is happening once per output refresh (for example, 60 Hz). When this value is returned, the media app should discontinue use of the decode swap chain and perform YUV to RGB conversion itself, reducing the frequency of YUV to RGB conversion to once per video frame.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_3/ne-dxgi1_3-dxgi_frame_presentation_mode#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            DXGI_FRAME_PRESENTATION_MODE_COMPOSED = 0,
            /// <summary>
            /// <para>Specifies that the presentation mode is an overlay surface, meaning that the YUV to RGB conversion is happening efficiently in hardware (once per video frame). When this value is returned, the media app can continue to use the decode swap chain. See <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_3/nn-dxgi1_3-idxgidecodeswapchain">IDXGIDecodeSwapChain</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_3/ne-dxgi1_3-dxgi_frame_presentation_mode#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            DXGI_FRAME_PRESENTATION_MODE_OVERLAY = 1,
            /// <summary>No presentation is specified.</summary>
            DXGI_FRAME_PRESENTATION_MODE_NONE = 2,
            /// <summary>
            /// <para>An  issue occurred that caused content protection to be invalidated in a swap-chain with hardware content protection, and is usually because the system ran out of hardware protected memory. The app will need to do one of the following:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_3/ne-dxgi1_3-dxgi_frame_presentation_mode#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE = 3,
        }
    }
}