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
        /// <summary>Describes full-screen mode for a swap chain.</summary>
        /// <remarks>
        /// <para>This structure is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforhwnd">CreateSwapChainForHwnd</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getfullscreendesc">GetFullscreenDesc</a> methods.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/ns-dxgi1_2-dxgi_swap_chain_fullscreen_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DXGI_SWAP_CHAIN_FULLSCREEN_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgicommon/ns-dxgicommon-dxgi_rational">DXGI_RATIONAL</a> structure that describes the refresh rate in hertz.</summary>
            internal win32.Graphics.Dxgi.DXGI_RATIONAL RefreshRate;
            /// <summary>A member of the <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173067(v=vs.85)">DXGI_MODE_SCANLINE_ORDER</a> enumerated type that describes the scan-line drawing mode.</summary>
            internal win32.Graphics.Dxgi.DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
            /// <summary>A member of the <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173066(v=vs.85)">DXGI_MODE_SCALING</a> enumerated type that describes the scaling mode.</summary>
            internal win32.Graphics.Dxgi.DXGI_MODE_SCALING Scaling;
            /// <summary>A Boolean value that specifies whether the swap chain is in windowed mode. <b>TRUE</b> if the swap chain is in windowed mode; otherwise, <b>FALSE</b>.</summary>
            internal win32.System.SystemServices.BOOL Windowed;
        }
    }
}