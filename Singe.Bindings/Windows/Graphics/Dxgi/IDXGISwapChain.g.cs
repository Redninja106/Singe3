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
        [Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
        internal unsafe struct IDXGISwapChain
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
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGISwapChain*pThis = &this)
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
                fixed (IDXGISwapChain*pThis = &this)
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
                fixed (IDXGISwapChain*pThis = &this)
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
                fixed (IDXGISwapChain*pThis = &this)
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
                fixed (IDXGISwapChain*pThis = &this)
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
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppDevice);
            }

            /// <summary>Presents a rendered image to the user.</summary>
            /// <param name = "SyncInterval">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>An integer that specifies how to synchronize presentation of a frame with the vertical blank.</para>
            /// <para>For the bit-block transfer (bitblt) model (<a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_DISCARD</a>or <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_SEQUENTIAL</a>), values are:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-present#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "Flags">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>An integer value that contains swap-chain presentation options. These options are defined by the <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-present">DXGI_PRESENT</a> constants.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-present#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Possible return values include: S_OK, DXGI_ERROR_DEVICE_RESET or DXGI_ERROR_DEVICE_REMOVED (see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>), DXGI_STATUS_OCCLUDED (see <a href = "/windows/desktop/direct3ddxgi/dxgi-status">DXGI_STATUS</a>), or D3DDDIERR_DEVICEREMOVED.</para>
            /// <para><div class = "alert"><b>Note</b>  The <b>Present</b> method can return either DXGI_ERROR_DEVICE_REMOVED or D3DDDIERR_DEVICEREMOVED if a video card has been physically removed from the computer, or a driver upgrade for the video card has occurred.</div> <div> </div></para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-present">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT Present(uint SyncInterval, uint Flags)
            {
                fixed (IDXGISwapChain*pThis = &this)
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

            /// <summary>Accesses one of the swap-chain's back buffers.</summary>
            /// <param name = "Buffer">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A zero-based buffer index.</para>
            /// <para>If the swap chain's swap effect is <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_DISCARD</a>, this method can only access the first buffer; for this situation, set the index to zero.</para>
            /// <para>If the swap chain's swap effect is either <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_SEQUENTIAL</a> or <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_effect">DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL</a>, only the swap chain's zero-index buffer can be read from and written to. The swap chain's buffers with indexes greater than zero can only be read from; so if you call the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgiresource-getusage">IDXGIResource::GetUsage</a> method for such buffers, they have the <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-usage">DXGI_USAGE_READ_ONLY</a> flag set.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getbuffer#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "riid">
            /// <para>Type: <b>REFIID</b></para>
            /// <para>The type of interface used to manipulate the buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getbuffer#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppSurface">
            /// <para>Type: <b>void**</b></para>
            /// <para>A pointer to a back-buffer interface.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getbuffer#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getbuffer">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetBuffer(uint Buffer, global::System.Guid*riid, void **ppSurface)
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->GetBuffer_10(pThis, Buffer, riid, ppSurface);
            }

            /// <summary>Sets the display state to windowed or full screen.</summary>
            /// <param name = "Fullscreen">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>A Boolean value that specifies whether to set the display state to windowed or full screen. <b>TRUE</b> for full screen, and <b>FALSE</b> for windowed.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-setfullscreenstate#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pTarget">
            /// <para>Type: [in, optional] <b><a href = "https://docs.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a>*</b></para>
            /// <para>If you pass <b>TRUE</b> to the <i>Fullscreen</i> parameter to set the display state to full screen, you can optionally set this parameter to a pointer to an <a href = "https://docs.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a> interface for the output target that contains the swap chain. If you set this parameter to <b>NULL</b>, DXGI will choose the output based on the swap-chain's device and the output window's placement. If you pass <b>FALSE</b> to <i>Fullscreen</i>, then you must set this parameter to <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-setfullscreenstate#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of these values.</para>
            /// <para>- **S_OK** if the action succeeded and the swap chain was placed in the requested state. - **DXGI_ERROR_NOT_CURRENTLY_AVAILABLE** if the action failed. When this error is returned, your application can continue to run in windowed mode and try to switch to full-screen mode later. There are many reasons why a windowed-mode swap chain cannot switch to full-screen mode. Here are some examples. - The application is running over Terminal Server. - The output window is occluded. - The output window does not have keyboard focus. - Another application is already in full-screen mode. - **DXGI_STATUS_MODE_CHANGE_IN_PROGRESS** is returned if a fullscreen/windowed mode transition is occurring when this API is called. - Other error codes if you run out of memory or encounter another unexpected fault; these codes may be treated as hard, non-continuable errors.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-setfullscreenstate">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetFullscreenState(win32.System.SystemServices.BOOL Fullscreen, [Optional] win32.Graphics.Dxgi.IDXGIOutput*pTarget)
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->SetFullscreenState_11(pThis, Fullscreen, pTarget);
            }

            /// <summary>Get the state associated with full-screen mode.</summary>
            /// <param name = "pFullscreen">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a>*</b></para>
            /// <para>A pointer to a boolean whose value is either:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getfullscreenstate#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppTarget">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a>**</b></para>
            /// <para>A pointer to the output target (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a>) when the mode is full screen; otherwise <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getfullscreenstate#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getfullscreenstate">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetFullscreenState([Optional] win32.System.SystemServices.BOOL*pFullscreen, [Optional] win32.Graphics.Dxgi.IDXGIOutput**ppTarget)
            {
                fixed (IDXGISwapChain*pThis = &this)
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

            /// <summary>Get a description of the swap chain.</summary>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_swap_chain_desc">DXGI_SWAP_CHAIN_DESC</a>*</b></para>
            /// <para>A pointer to the swap-chain description (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_swap_chain_desc">DXGI_SWAP_CHAIN_DESC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*pDesc)
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->GetDesc_13(pThis, pDesc);
            }

            /// <summary>Changes the swap chain's back buffer size, format, and number of buffers. This should be called when the application window is resized.</summary>
            /// <param name = "BufferCount">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of buffers in the swap chain (including all back and front buffers). This number can be different from the number of buffers with which you created the swap chain. This number can't be greater than <b>DXGI_MAX_SWAP_CHAIN_BUFFERS</b>. Set this number to zero to preserve the existing number of buffers in the swap chain. You can't specify less than two buffers for the flip presentation model.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "Width">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The new width of the back buffer. If you specify zero, DXGI will use the width of the client area of the target window. You can't specify the width as zero if you called the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcomposition">IDXGIFactory2::CreateSwapChainForComposition</a> method to create the swap chain for a composition surface.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "Height">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The new height of the back buffer. If you specify zero, DXGI will use the height of the client area of the target window. You can't specify the height as zero if you called the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcomposition">IDXGIFactory2::CreateSwapChainForComposition</a> method to create the swap chain for a composition surface.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "NewFormat">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a>-typed value for the new format of the back buffer. Set this value to <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT_UNKNOWN</a> to preserve the existing format of the back buffer. The flip presentation model supports a more restricted set of formats than the bit-block transfer (bitblt) model.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "SwapChainFlags">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A combination of <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ne-dxgi-dxgi_swap_chain_flag">DXGI_SWAP_CHAIN_FLAG</a>-typed values that are combined by using a bitwise OR operation. The resulting value specifies options for swap-chain behavior.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK if successful; an error code otherwise. For a list of error codes, see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizebuffers">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, win32.Graphics.Dxgi.DXGI_FORMAT NewFormat, uint SwapChainFlags)
            {
                fixed (IDXGISwapChain*pThis = &this)
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

            /// <summary>Resizes the output target.</summary>
            /// <param name = "pNewTargetParameters">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173064(v=vs.85)">DXGI_MODE_DESC</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/bb173064(v=vs.85)">DXGI_MODE_DESC</a> structure that describes the mode, which specifies the new width, height, format, and refresh rate of the target. If the format is <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT_UNKNOWN</a>, <b>ResizeTarget</b> uses the existing format. We only recommend that you use <b>DXGI_FORMAT_UNKNOWN</b> when the swap chain is in full-screen mode as this method is not thread safe.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizetarget#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns a code that indicates success or failure. <b>DXGI_STATUS_MODE_CHANGE_IN_PROGRESS</b> is returned if a full-screen/windowed mode transition is occurring when this API is called. See <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a> for additional DXGI error codes.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-resizetarget">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ResizeTarget(win32.Graphics.Dxgi.DXGI_MODE_DESC*pNewTargetParameters)
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->ResizeTarget_15(pThis, pNewTargetParameters);
            }

            /// <summary>Get the output (the display monitor) that contains the majority of the client area of the target window.</summary>
            /// <param name = "ppOutput">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a>**</b></para>
            /// <para>A pointer to the output interface (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgioutput">IDXGIOutput</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getcontainingoutput#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getcontainingoutput">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetContainingOutput(win32.Graphics.Dxgi.IDXGIOutput**ppOutput)
            {
                fixed (IDXGISwapChain*pThis = &this)
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

            /// <summary>Gets performance statistics about the last render frame.</summary>
            /// <param name = "pStats">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_frame_statistics">DXGI_FRAME_STATISTICS</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_frame_statistics">DXGI_FRAME_STATISTICS</a> structure for the frame statistics.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getframestatistics#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a> values.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getframestatistics">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetFrameStatistics(win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*pStats)
            {
                fixed (IDXGISwapChain*pThis = &this)
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

            /// <summary>Gets the number of times that IDXGISwapChain::Present or IDXGISwapChain1::Present1 has been called.</summary>
            /// <param name = "pLastPresentCount">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a>*</b></para>
            /// <para>A pointer to a variable that receives the number of calls.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getlastpresentcount#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a> values.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiswapchain-getlastpresentcount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetLastPresentCount(uint *pLastPresentCount)
            {
                fixed (IDXGISwapChain*pThis = &this)
                    return lpVtbl->GetLastPresentCount_18(pThis, pLastPresentCount);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, win32.System.Com.HRESULT>Present_9;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint, global::System.Guid*, void **, win32.System.Com.HRESULT>GetBuffer_10;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.System.SystemServices.BOOL, win32.Graphics.Dxgi.IDXGIOutput*, win32.System.Com.HRESULT>SetFullscreenState_11;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.System.SystemServices.BOOL*, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>GetFullscreenState_12;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*, win32.System.Com.HRESULT>GetDesc_13;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, uint, win32.Graphics.Dxgi.DXGI_FORMAT, uint, win32.System.Com.HRESULT>ResizeBuffers_14;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.Graphics.Dxgi.DXGI_MODE_DESC*, win32.System.Com.HRESULT>ResizeTarget_15;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>GetContainingOutput_16;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, win32.Graphics.Dxgi.DXGI_FRAME_STATISTICS*, win32.System.Com.HRESULT>GetFrameStatistics_17;
                internal delegate *unmanaged[Stdcall]<IDXGISwapChain*, uint *, win32.System.Com.HRESULT>GetLastPresentCount_18;
            }

            private Vtbl*lpVtbl;
        }
    }
}