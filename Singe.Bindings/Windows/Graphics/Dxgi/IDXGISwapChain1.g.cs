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
        [Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
        internal unsafe struct IDXGISwapChain1
        {
            /// <inheritdoc cref = "QueryInterface(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT QueryInterface(in global::System.Guid riid, out void *ppvObject)
            {
                fixed (void **ppvObjectLocal = &ppvObject)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        win32.System.Com.HRESULT __result = this.QueryInterface(riidLocal, ppvObjectLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT QueryInterface(global::System.Guid*riid, void **ppvObject)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "SetPrivateData(global::System.Guid*, uint, void *)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateData(in global::System.Guid Name, uint DataSize, void *pData)
            {
                fixed (global::System.Guid*NameLocal = &Name)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateData(NameLocal, DataSize, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateData(global::System.Guid*Name, uint DataSize, void *pData)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->SetPrivateData_4(pThis, Name, DataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateDataInterface(global::System.Guid*, win32.System.Com.IUnknown*)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(in global::System.Guid Name, win32.System.Com.IUnknown*pUnknown)
            {
                fixed (global::System.Guid*NameLocal = &Name)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateDataInterface(NameLocal, pUnknown);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(global::System.Guid*Name, [Optional] win32.System.Com.IUnknown*pUnknown)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_5(pThis, Name, pUnknown);
            }

            /// <inheritdoc cref = "GetPrivateData(global::System.Guid*, uint *, void *)"/>
            internal unsafe win32.System.Com.HRESULT GetPrivateData(in global::System.Guid Name, ref uint pDataSize, void *pData)
            {
                fixed (uint *pDataSizeLocal = &pDataSize)
                {
                    fixed (global::System.Guid*NameLocal = &Name)
                    {
                        win32.System.Com.HRESULT __result = this.GetPrivateData(NameLocal, pDataSizeLocal, pData);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetPrivateData(global::System.Guid*Name, uint *pDataSize, void *pData)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetPrivateData_6(pThis, Name, pDataSize, pData);
            }

            /// <inheritdoc cref = "GetParent(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetParent(in global::System.Guid riid, out void *ppParent)
            {
                fixed (void **ppParentLocal = &ppParent)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        win32.System.Com.HRESULT __result = this.GetParent(riidLocal, ppParentLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetParent(global::System.Guid*riid, void **ppParent)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetParent_7(pThis, riid, ppParent);
            }

            /// <inheritdoc cref = "GetDevice(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetDevice(in global::System.Guid riid, out void *ppDevice)
            {
                fixed (void **ppDeviceLocal = &ppDevice)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        win32.System.Com.HRESULT __result = this.GetDevice(riidLocal, ppDeviceLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDevice(global::System.Guid*riid, void **ppDevice)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppDevice);
            }

            internal win32.System.Com.HRESULT Present(uint SyncInterval, uint Flags)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->Present_9(pThis, SyncInterval, Flags);
            }

            /// <inheritdoc cref = "GetBuffer(uint, global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetBuffer(uint Buffer, in global::System.Guid riid, out void *ppSurface)
            {
                fixed (void **ppSurfaceLocal = &ppSurface)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        win32.System.Com.HRESULT __result = this.GetBuffer(Buffer, riidLocal, ppSurfaceLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetBuffer(uint Buffer, global::System.Guid*riid, void **ppSurface)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetBuffer_10(pThis, Buffer, riid, ppSurface);
            }

            internal unsafe win32.System.Com.HRESULT SetFullscreenState(win32.System.SystemServices.BOOL Fullscreen, [Optional] win32.Graphics.Dxgi.IDXGIOutput*pTarget)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->SetFullscreenState_11(pThis, Fullscreen, pTarget);
            }

            internal unsafe win32.System.Com.HRESULT GetFullscreenState([Optional] win32.System.SystemServices.BOOL*pFullscreen, [Optional] win32.Graphics.Dxgi.IDXGIOutput**ppTarget)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetFullscreenState_12(pThis, pFullscreen, ppTarget);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc(out win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc(pDescLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*pDesc)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetDesc_13(pThis, pDesc);
            }

            internal win32.System.Com.HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, win32.Graphics.Dxgi.DXGI_FORMAT NewFormat, uint SwapChainFlags)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->ResizeBuffers_14(pThis, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }

            /// <inheritdoc cref = "ResizeTarget(win32.Graphics.Dxgi.DXGI_MODE_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT ResizeTarget(in win32.Graphics.Dxgi.DXGI_MODE_DESC pNewTargetParameters)
            {
                fixed (win32.Graphics.Dxgi.DXGI_MODE_DESC*pNewTargetParametersLocal = &pNewTargetParameters)
                {
                    win32.System.Com.HRESULT __result = this.ResizeTarget(pNewTargetParametersLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT ResizeTarget(win32.Graphics.Dxgi.DXGI_MODE_DESC*pNewTargetParameters)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->ResizeTarget_15(pThis, pNewTargetParameters);
            }

            internal unsafe win32.System.Com.HRESULT GetContainingOutput(win32.Graphics.Dxgi.IDXGIOutput**ppOutput)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetContainingOutput_16(pThis, ppOutput);
            }

            /// <inheritdoc cref = "GetFrameStatistics(win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*)"/>
            internal unsafe win32.System.Com.HRESULT GetFrameStatistics(out win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS pStats)
            {
                fixed (win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*pStatsLocal = &pStats)
                {
                    win32.System.Com.HRESULT __result = this.GetFrameStatistics(pStatsLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetFrameStatistics(win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*pStats)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetFrameStatistics_17(pThis, pStats);
            }

            /// <inheritdoc cref = "GetLastPresentCount(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetLastPresentCount(out uint pLastPresentCount)
            {
                fixed (uint *pLastPresentCountLocal = &pLastPresentCount)
                {
                    win32.System.Com.HRESULT __result = this.GetLastPresentCount(pLastPresentCountLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetLastPresentCount(uint *pLastPresentCount)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetLastPresentCount_18(pThis, pLastPresentCount);
            }

            /// <inheritdoc cref = "GetDesc1(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC1*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc1(out win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC1 pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC1*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc1(pDescLocal);
                    return __result;
                }
            }

            /// <summary>Gets a description of the swap chain.</summary>
            /// <param name = "pDesc">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ns-dxgi1_2-dxgi_swap_chain_desc1">DXGI_SWAP_CHAIN_DESC1</a>  structure that describes the swap chain.</param>
            /// <returns>Returns S_OK if successful; an error code otherwise.  For a list of error codes, see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getdesc1">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDesc1(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC1*pDesc)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetDesc1_19(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetFullscreenDesc(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_FULLSCREEN_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetFullscreenDesc(out win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_FULLSCREEN_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetFullscreenDesc(pDescLocal);
                    return __result;
                }
            }

            /// <summary>Gets a description of a full-screen swap chain.</summary>
            /// <param name = "pDesc">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ns-dxgi1_2-dxgi_swap_chain_fullscreen_desc">DXGI_SWAP_CHAIN_FULLSCREEN_DESC</a>  structure that describes the full-screen swap chain.</param>
            /// <returns>
            /// <para><b>GetFullscreenDesc</b> returns: </para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getfullscreendesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetFullscreenDesc(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_FULLSCREEN_DESC*pDesc)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetFullscreenDesc_20(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetHwnd(win32.UI.WindowsAndMessaging.HWND*)"/>
            internal unsafe win32.System.Com.HRESULT GetHwnd(out win32.UI.WindowsAndMessaging.HWND pHwnd)
            {
                fixed (win32.UI.WindowsAndMessaging.HWND*pHwndLocal = &pHwnd)
                {
                    win32.System.Com.HRESULT __result = this.GetHwnd(pHwndLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the underlying HWND for this swap-chain object.</summary>
            /// <param name = "pHwnd">A pointer to a variable that receives the <a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a> for the swap-chain object.</param>
            /// <returns>
            /// <para>Returns S_OK if successful; an error code otherwise.  For a list of error codes, see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// <para>If <i>pHwnd</i> receives <b>NULL</b> (that is, the swap chain is not <a href = "/windows/desktop/WinProg/windows-data-types">HWND</a>-based), <b>GetHwnd</b> returns <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-gethwnd">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetHwnd(win32.UI.WindowsAndMessaging.HWND*pHwnd)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetHwnd_21(pThis, pHwnd);
            }

            /// <inheritdoc cref = "GetCoreWindow(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetCoreWindow(in global::System.Guid refiid, out void *ppUnk)
            {
                fixed (void **ppUnkLocal = &ppUnk)
                {
                    fixed (global::System.Guid*refiidLocal = &refiid)
                    {
                        win32.System.Com.HRESULT __result = this.GetCoreWindow(refiidLocal, ppUnkLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Retrieves the underlying CoreWindow object for this swap-chain object.</summary>
            /// <param name = "refiid">
            /// <para>A pointer to the globally unique identifier (GUID) of the <a href = "https://docs.microsoft.com/uwp/api/Windows.UI.Core.CoreWindow">CoreWindow</a> object that is referenced by the <i>ppUnk</i> parameter.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getcorewindow#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppUnk">A pointer to a variable that receives a pointer to the <a href = "https://docs.microsoft.com/uwp/api/Windows.UI.Core.CoreWindow">CoreWindow</a> object.</param>
            /// <returns>
            /// <para><b>GetCoreWindow</b> returns: </para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getcorewindow">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetCoreWindow(global::System.Guid*refiid, void **ppUnk)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetCoreWindow_22(pThis, refiid, ppUnk);
            }

            /// <inheritdoc cref = "Present1(uint, uint, win32.Graphics.Dxgi.DXGI_PRESENT_PARAMETERS*)"/>
            internal unsafe win32.System.Com.HRESULT Present1(uint SyncInterval, uint PresentFlags, in win32.Graphics.Dxgi.DXGI_PRESENT_PARAMETERS pPresentParameters)
            {
                fixed (win32.Graphics.Dxgi.DXGI_PRESENT_PARAMETERS*pPresentParametersLocal = &pPresentParameters)
                {
                    win32.System.Com.HRESULT __result = this.Present1(SyncInterval, PresentFlags, pPresentParametersLocal);
                    return __result;
                }
            }

            /// <summary>Presents a frame on the display screen.</summary>
            /// <param name = "SyncInterval">
            /// <para>An integer that specifies how to synchronize presentation of a frame with the vertical blank.</para>
            /// <para>For the bit-block transfer (bitblt) model (<a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_DISCARD</a>or <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_SEQUENTIAL</a>), values are:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-present1#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "PresentFlags">An integer value that contains swap-chain presentation options. These options are defined by the <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-present">DXGI_PRESENT</a> constants.</param>
            /// <param name = "pPresentParameters">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ns-dxgi1_2-dxgi_present_parameters">DXGI_PRESENT_PARAMETERS</a> structure that describes updated rectangles and scroll information of the frame to present.</param>
            /// <returns>Possible return values include: S_OK, <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_DEVICE_REMOVED</a> , <a href = "/windows/desktop/direct3ddxgi/dxgi-status">DXGI_STATUS_OCCLUDED</a>, <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a>, or E_OUTOFMEMORY.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-present1">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Present1(uint SyncInterval, uint PresentFlags, win32.Graphics.Dxgi.DXGI_PRESENT_PARAMETERS*pPresentParameters)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->Present1_23(pThis, SyncInterval, PresentFlags, pPresentParameters);
            }

            /// <summary>Determines whether a swap chain supports “temporary mono.”</summary>
            /// <returns>
            /// <para>Indicates whether to use the swap chain in temporary mono mode. <b>TRUE</b> indicates that you can use temporary-mono mode; otherwise, <b>FALSE</b>.</para>
            /// <para><b>Platform Update for Windows 7:  </b>On Windows 7 or Windows Server 2008 R2 with the <a href = "https://support.microsoft.com/help/2670838">Platform Update for Windows 7</a> installed, <b>IsTemporaryMonoSupported</b> always returns FALSE because stereoscopic 3D display behavior isn’t available with the Platform Update for Windows 7. For more info about the Platform Update for Windows 7, see <a href = "/windows/desktop/direct3darticles/platform-update-for-windows-7">Platform Update for Windows 7</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-istemporarymonosupported">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.SystemServices.BOOL IsTemporaryMonoSupported()
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->IsTemporaryMonoSupported_24(pThis);
            }

            /// <summary>Gets the output (the display monitor) to which you can restrict the contents of a present operation.</summary>
            /// <param name = "ppRestrictToOutput">A pointer to a buffer that receives a pointer to the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a> interface for the restrict-to output. An application passes this pointer to <b>IDXGIOutput</b> in a call to the  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforhwnd">IDXGIFactory2::CreateSwapChainForHwnd</a>, <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcorewindow">IDXGIFactory2::CreateSwapChainForCoreWindow</a>, or  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcomposition">IDXGIFactory2::CreateSwapChainForComposition</a> method to create the swap chain.</param>
            /// <returns>Returns S_OK if the restrict-to output was successfully retrieved; otherwise, returns E_INVALIDARG if the pointer is invalid.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getrestricttooutput">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetRestrictToOutput(win32.Graphics.Dxgi.IDXGIOutput**ppRestrictToOutput)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetRestrictToOutput_25(pThis, ppRestrictToOutput);
            }

            /// <inheritdoc cref = "SetBackgroundColor(win32.Graphics.Dxgi.DXGI_RGBA*)"/>
            internal unsafe win32.System.Com.HRESULT SetBackgroundColor(in win32.Graphics.Dxgi.DXGI_RGBA pColor)
            {
                fixed (win32.Graphics.Dxgi.DXGI_RGBA*pColorLocal = &pColor)
                {
                    win32.System.Com.HRESULT __result = this.SetBackgroundColor(pColorLocal);
                    return __result;
                }
            }

            /// <summary>Changes the background color of the swap chain.</summary>
            /// <param name = "pColor">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-rgba">DXGI_RGBA</a> structure that specifies the background color to set.</param>
            /// <returns>
            /// <para><b>SetBackgroundColor</b> returns: </para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-setbackgroundcolor">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetBackgroundColor(win32.Graphics.Dxgi.DXGI_RGBA*pColor)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->SetBackgroundColor_26(pThis, pColor);
            }

            /// <inheritdoc cref = "GetBackgroundColor(win32.Graphics.Dxgi.DXGI_RGBA*)"/>
            internal unsafe win32.System.Com.HRESULT GetBackgroundColor(out win32.Graphics.Dxgi.DXGI_RGBA pColor)
            {
                fixed (win32.Graphics.Dxgi.DXGI_RGBA*pColorLocal = &pColor)
                {
                    win32.System.Com.HRESULT __result = this.GetBackgroundColor(pColorLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the background color of the swap chain.</summary>
            /// <param name = "pColor">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-rgba">DXGI_RGBA</a> structure that receives the background color of the swap chain.</param>
            /// <returns>
            /// <para><b>GetBackgroundColor</b> returns: </para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getbackgroundcolor">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetBackgroundColor(win32.Graphics.Dxgi.DXGI_RGBA*pColor)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetBackgroundColor_27(pThis, pColor);
            }

            /// <summary>Sets the rotation of the back buffers for the swap chain.</summary>
            /// <param name = "Rotation">A <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173065(v=vs.85)">DXGI_MODE_ROTATION</a>-typed value that specifies how to set the rotation of the back buffers for the swap chain.</param>
            /// <returns>
            /// <para><b>SetRotation</b> returns: </para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-setrotation">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetRotation(win32.Graphics.Dxgi.DXGI_MODE_ROTATION Rotation)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->SetRotation_28(pThis, Rotation);
            }

            /// <inheritdoc cref = "GetRotation(win32.Graphics.Dxgi.DXGI_MODE_ROTATION*)"/>
            internal unsafe win32.System.Com.HRESULT GetRotation(out win32.Graphics.Dxgi.DXGI_MODE_ROTATION pRotation)
            {
                fixed (win32.Graphics.Dxgi.DXGI_MODE_ROTATION*pRotationLocal = &pRotation)
                {
                    win32.System.Com.HRESULT __result = this.GetRotation(pRotationLocal);
                    return __result;
                }
            }

            /// <summary>Gets the rotation of the back buffers for the swap chain.</summary>
            /// <param name = "pRotation">A pointer to a variable that receives a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173065(v=vs.85)">DXGI_MODE_ROTATION</a>-typed value that specifies the rotation of the back buffers for the swap chain.</param>
            /// <returns>
            /// <para>Returns S_OK if successful; an error code otherwise.  For a list of error codes, see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// <para><b>Platform Update for Windows 7:  </b>On Windows 7 or Windows Server 2008 R2 with the <a href = "https://support.microsoft.com/help/2670838">Platform Update for Windows 7</a> installed, <b>GetRotation</b> fails with DXGI_ERROR_INVALID_CALL. For more info about the Platform Update for Windows 7, see <a href = "/windows/desktop/direct3darticles/platform-update-for-windows-7">Platform Update for Windows 7</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getrotation">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetRotation(win32.Graphics.Dxgi.DXGI_MODE_ROTATION*pRotation)
            {
                fixed (IDXGISwapChain1*pThis = &this)
                    return lpVtbl->GetRotation_29(pThis, pRotation);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, win32.System.Com.HRESULT>Present_9;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint, global::System.Guid*, void **, win32.System.Com.HRESULT>GetBuffer_10;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.System.SystemServices.BOOL, win32.Graphics.Dxgi.IDXGIOutput*, win32.System.Com.HRESULT>SetFullscreenState_11;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.System.SystemServices.BOOL*, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>GetFullscreenState_12;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*, win32.System.Com.HRESULT>GetDesc_13;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, uint, win32.Graphics.Dxgi.DXGI_FORMAT, uint, win32.System.Com.HRESULT>ResizeBuffers_14;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_MODE_DESC*, win32.System.Com.HRESULT>ResizeTarget_15;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>GetContainingOutput_16;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*, win32.System.Com.HRESULT>GetFrameStatistics_17;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint *, win32.System.Com.HRESULT>GetLastPresentCount_18;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC1*, win32.System.Com.HRESULT>GetDesc1_19;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, win32.System.Com.HRESULT>GetFullscreenDesc_20;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.UI.WindowsAndMessaging.HWND*, win32.System.Com.HRESULT>GetHwnd_21;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetCoreWindow_22;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, win32.Graphics.Dxgi.DXGI_PRESENT_PARAMETERS*, win32.System.Com.HRESULT>Present1_23;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.System.SystemServices.BOOL>IsTemporaryMonoSupported_24;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>GetRestrictToOutput_25;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_RGBA*, win32.System.Com.HRESULT>SetBackgroundColor_26;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_RGBA*, win32.System.Com.HRESULT>GetBackgroundColor_27;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_MODE_ROTATION, win32.System.Com.HRESULT>SetRotation_28;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain1*, win32.Graphics.Dxgi.DXGI_MODE_ROTATION*, win32.System.Com.HRESULT>GetRotation_29;
            }

            private Vtbl*lpVtbl;
        }
    }
}