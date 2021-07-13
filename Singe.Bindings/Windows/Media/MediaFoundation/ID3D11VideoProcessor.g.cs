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
        [Guid("1D7B0652-185F-41C6-85CE-0C5BE3D4AE6C")]
        internal unsafe struct ID3D11VideoProcessor
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
                fixed (ID3D11VideoProcessor*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11VideoProcessor*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11VideoProcessor*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D11.ID3D11Device**ppDevice)
            {
                fixed (ID3D11VideoProcessor*pThis = &this)
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
                fixed (ID3D11VideoProcessor*pThis = &this)
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
                fixed (ID3D11VideoProcessor*pThis = &this)
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
                fixed (ID3D11VideoProcessor*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            /// <inheritdoc cref = "GetContentDesc(win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_CONTENT_DESC*)"/>
            internal unsafe void GetContentDesc(out win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc)
            {
                fixed (win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_CONTENT_DESC*pDescLocal = &pDesc)
                {
                    this.GetContentDesc(pDescLocal);
                }
            }

            /// <summary>Gets the content description that was used to create the video processor.</summary>
            /// <param name = "pDesc">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_video_processor_content_desc">D3D11_VIDEO_PROCESSOR_CONTENT_DESC</a> structure that receives the content description.</param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/nf-d3d11-id3d11videoprocessor-getcontentdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetContentDesc(win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_CONTENT_DESC*pDesc)
            {
                fixed (ID3D11VideoProcessor*pThis = &this)
                    lpVtbl->GetContentDesc_8(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetRateConversionCaps(win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*)"/>
            internal unsafe void GetRateConversionCaps(out win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps)
            {
                fixed (win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*pCapsLocal = &pCaps)
                {
                    this.GetRateConversionCaps(pCapsLocal);
                }
            }

            /// <summary>Gets the rate conversion capabilities of the video processor.</summary>
            /// <param name = "pCaps">A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_video_processor_rate_conversion_caps">D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS</a> structure that receives the rate conversion capabilities.</param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/nf-d3d11-id3d11videoprocessor-getrateconversioncaps">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetRateConversionCaps(win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*pCaps)
            {
                fixed (ID3D11VideoProcessor*pThis = &this)
                    lpVtbl->GetRateConversionCaps_9(pThis, pCaps);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, win32.Graphics.Direct3D11.ID3D11Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, void>GetContentDesc_8;
                internal delegate *unmanaged[Stdcall]<ID3D11VideoProcessor*, win32.Media.MediaFoundation.D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, void>GetRateConversionCaps_9;
            }

            private Vtbl*lpVtbl;
        }
    }
}