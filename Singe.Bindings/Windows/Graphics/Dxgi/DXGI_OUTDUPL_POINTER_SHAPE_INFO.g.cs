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
        /// <summary>The DXGI_OUTDUPL_POINTER_SHAPE_INFO structure describes information about the cursor shape.</summary>
        /// <remarks>
        /// <para>An application draws the cursor shape with the top-left-hand corner drawn at the position that the <b>Position</b> member of the  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_pointer_position">DXGI_OUTDUPL_POINTER_POSITION</a> structure specifies; the application does not use the hot spot to draw the cursor shape.</para>
        /// <para>An application calls the  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-getframepointershape">IDXGIOutputDuplication::GetFramePointerShape</a> method to retrieve cursor shape information in a  <b>DXGI_OUTDUPL_POINTER_SHAPE_INFO</b> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/ns-dxgi1_2-dxgi_outdupl_pointer_shape_info#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ne-dxgi1_2-dxgi_outdupl_pointer_shape_type">DXGI_OUTDUPL_POINTER_SHAPE_TYPE</a>-typed value that specifies the type of cursor shape.</summary>
            internal uint Type;
            /// <summary>The width in pixels of the mouse cursor.</summary>
            internal uint Width;
            /// <summary>The height in scan lines of the mouse cursor.</summary>
            internal uint Height;
            /// <summary>The width in bytes of the mouse cursor.</summary>
            internal uint Pitch;
            /// <summary>The position of the cursor's hot spot relative to its upper-left pixel. An application does not use the hot spot when it determines where to draw the cursor shape.</summary>
            internal win32.UI.DisplayDevices.POINT HotSpot;
        }
    }
}