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
        /// <summary>Provides information about the input streams passed into the ID3DVideoContext1::VideoProcessorGetBehaviorHints method.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_1/ns-d3d11_1-d3d11_video_processor_stream_behavior_hint">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT
        {
            /// <summary>A value indicating whether this input stream should be used to compute behavior hints. Set to true if the stream should be used to compute behavior hints; otherwise, set to false.</summary>
            internal win32.System.SystemServices.BOOL Enable;
            /// <summary>The width of the input stream.</summary>
            internal uint Width;
            /// <summary>The height of the input stream.</summary>
            internal uint Height;
            /// <summary>The format of the input stream.</summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
        }
    }
}