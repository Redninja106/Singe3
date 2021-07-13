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
        /// <summary>For stereo 3D video, specifies whether the data in frame 0 or frame 1 is flipped, either horizontally or vertically.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_video_processor_stereo_flip_mode">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE
        {
            /// <summary>Neither frame is flipped.</summary>
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE = 0,
            /// <summary>The data in frame 0 is flipped.</summary>
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0 = 1,
            /// <summary>The data in frame 1 is flipped.</summary>
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1 = 2,
        }
    }
}