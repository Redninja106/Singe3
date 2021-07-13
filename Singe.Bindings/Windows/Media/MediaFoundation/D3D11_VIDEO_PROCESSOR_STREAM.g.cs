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
        /// <summary>Contains stream-level data for the ID3D11VideoContext::VideoProcessorBlt method.</summary>
        /// <remarks>
        /// <para>If the stereo 3D format is <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE</b>, the <b>ppPastSurfaces</b>, <b>pInputSurface</b>, and <b>ppFutureSurfaces</b> members contain the left view.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_video_processor_stream#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_VIDEO_PROCESSOR_STREAM
        {
            /// <summary>
            /// <para>Specifies whether this input stream is enabled. If the value is <b>TRUE</b>, the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorblt">VideoProcessorBlt</a> method blits this stream to the output surface. Otherwise, this stream is not blitted.</para>
            /// <para>The maximum number of streams that can be enabled at one time is given in the <b>MaxInputStreams</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_video_processor_caps">D3D11_VIDEO_PROCESSOR_CAPS</a> structure.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_video_processor_stream#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL Enable;
            /// <summary>The zero-based index number of the output frame.</summary>
            internal uint OutputIndex;
            /// <summary>The zero-based index number of the input frame or field.</summary>
            internal uint InputFrameOrField;
            /// <summary>The number of past reference frames.</summary>
            internal uint PastFrames;
            /// <summary>The number of future reference frames.</summary>
            internal uint FutureFrames;
            /// <summary>A pointer to an array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nn-d3d11-id3d11videoprocessorinputview">ID3D11VideoProcessorInputView</a> pointers, allocated by the caller. This array contains the past reference frames for the video processing operation. The number of elements in the array is equal to <b>PastFrames</b>.</summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView**ppPastSurfaces;
            /// <summary>A pointer to the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nn-d3d11-id3d11videoprocessorinputview">ID3D11VideoProcessorInputView</a> interface of the surface that contains the current input frame.</summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView*pInputSurface;
            /// <summary>A pointer to an array of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nn-d3d11-id3d11videoprocessorinputview">ID3D11VideoProcessorInputView</a> pointers, allocated by the caller. This array contains the future reference frames for the video processing operation. The number of elements in the array is equal to <b>FutureFrames</b>.</summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView**ppFutureSurfaces;
            /// <summary>
            /// <para>If the stereo 3D format is <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE</b>, this member points to an array that contains the past reference frames for the right view. The number of elements in the array is equal to <b>PastFrames</b>.</para>
            /// <para>For any other stereo 3D format, set this member to <b>NULL</b>. For more information, see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamstereoformat">ID3D11VideoContext::VideoProcessorSetStreamStereoFormat</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_video_processor_stream#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView**ppPastSurfacesRight;
            /// <summary>
            /// <para>If the stereo 3D format is <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE</b>, this member contains a pointer to the current input frame for the right view.</para>
            /// <para>For any other stereo 3D format, set this member to <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_video_processor_stream#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView*pInputSurfaceRight;
            /// <summary>
            /// <para>If the stereo 3D format is <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE</b>, this member points to an array that contains the future reference frames for the right view. The number of elements in the array is equal to <b>FutureFrames</b>.</para>
            /// <para>For any other stereo 3D format, set this member to <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_video_processor_stream#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Media.MediaFoundation.ID3D11VideoProcessorInputView**ppFutureSurfacesRight;
        }
    }
}