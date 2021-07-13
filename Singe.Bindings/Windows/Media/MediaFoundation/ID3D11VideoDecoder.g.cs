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
        [Guid("3C9C5B51-995D-48D1-9B8D-FA5CAEDED65C")]
        internal unsafe struct ID3D11VideoDecoder
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
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D11.ID3D11Device**ppDevice)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    lpVtbl->GetDevice_4(pThis, ppDevice);
            }

            /// <inheritdoc cref = "GetPrivateData(global::System.Guid*, uint *, void *)"/>
            internal unsafe win32.System.Com.HRESULT GetPrivateData(in global::System.Guid guid, ref uint pDataSize, void *pData)
            {
                fixed (uint *pDataSizeLocal = &pDataSize)
                {
                    fixed (global::System.Guid*guidLocal = &guid)
                    {
                        win32.System.Com.HRESULT __result = this.GetPrivateData(guidLocal, pDataSizeLocal, pData);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetPrivateData(global::System.Guid*guid, uint *pDataSize, [Optional] void *pData)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->GetPrivateData_5(pThis, guid, pDataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateData(global::System.Guid*, uint, void *)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateData(in global::System.Guid guid, uint DataSize, void *pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateData(guidLocal, DataSize, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateData(global::System.Guid*guid, uint DataSize, [Optional] void *pData)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->SetPrivateData_6(pThis, guid, DataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateDataInterface(global::System.Guid*, win32.System.Com.IUnknown*)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(in global::System.Guid guid, win32.System.Com.IUnknown*pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateDataInterface(guidLocal, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(global::System.Guid*guid, [Optional] win32.System.Com.IUnknown*pData)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            /// <inheritdoc cref = "GetCreationParameters(win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_DESC*, win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_CONFIG*)"/>
            internal unsafe win32.System.Com.HRESULT GetCreationParameters(out win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_DESC pVideoDesc, out win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_CONFIG pConfig)
            {
                fixed (win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_CONFIG*pConfigLocal = &pConfig)
                {
                    fixed (win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_DESC*pVideoDescLocal = &pVideoDesc)
                    {
                        win32.System.Com.HRESULT __result = this.GetCreationParameters(pVideoDescLocal, pConfigLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Gets the parameters that were used to create the decoder.</summary>
            /// <param name = "pVideoDesc">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_video_decoder_desc">D3D11_VIDEO_DECODER_DESC</a> structure that receives a description of the video stream.</param>
            /// <param name = "pConfig">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_video_decoder_config">D3D11_VIDEO_DECODER_CONFIG</a> structure that receives the decoder configuration.</param>
            /// <returns>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/nf-d3d11-id3d11videodecoder-getcreationparameters">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetCreationParameters(win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_DESC*pVideoDesc, win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_CONFIG*pConfig)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->GetCreationParameters_8(pThis, pVideoDesc, pConfig);
            }

            /// <inheritdoc cref = "GetDriverHandle(win32.System.SystemServices.HANDLE*)"/>
            internal unsafe win32.System.Com.HRESULT GetDriverHandle(out Microsoft.Win32.SafeHandles.SafeFileHandle pDriverHandle)
            {
                win32.System.SystemServices.HANDLE pDriverHandleLocal;
                win32.System.Com.HRESULT __result = this.GetDriverHandle(&pDriverHandleLocal);
                pDriverHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle(pDriverHandleLocal, ownsHandle: true);
                return __result;
            }

            /// <summary>Gets a handle to the driver.</summary>
            /// <param name = "pDriverHandle">Receives a handle to the driver.</param>
            /// <returns>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/nf-d3d11-id3d11videodecoder-getdriverhandle">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDriverHandle(win32.System.SystemServices.HANDLE*pDriverHandle)
            {
                fixed (ID3D11VideoDecoder*pThis = &this)
                    return lpVtbl->GetDriverHandle_9(pThis, pDriverHandle);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, win32.Graphics.Direct3D11.ID3D11Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_DESC*, win32.Media.MediaFoundation.D3D11_VIDEO_DECODER_CONFIG*, win32.System.Com.HRESULT>GetCreationParameters_8;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoDecoder*, win32.System.SystemServices.HANDLE*, win32.System.Com.HRESULT>GetDriverHandle_9;
            }

            private Vtbl*lpVtbl;
        }
    }
}