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
        [Guid("645967A4-1392-4310-A798-8053CE3E93FD")]
        internal unsafe struct IDXGIAdapter3
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
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIAdapter3*pThis = &this)
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
                fixed (IDXGIAdapter3*pThis = &this)
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
                fixed (IDXGIAdapter3*pThis = &this)
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
                fixed (IDXGIAdapter3*pThis = &this)
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
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->GetParent_7(pThis, riid, ppParent);
            }

            internal unsafe win32.System.Com.HRESULT EnumOutputs(uint Output, win32.Graphics.Dxgi.IDXGIOutput**ppOutput)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->EnumOutputs_8(pThis, Output, ppOutput);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc(out win32.Graphics.Dxgi.DXGI_ADAPTER_DESC pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_ADAPTER_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc(pDescLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC*pDesc)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->GetDesc_9(pThis, pDesc);
            }

            /// <inheritdoc cref = "CheckInterfaceSupport(global::System.Guid*, long *)"/>
            internal unsafe win32.System.Com.HRESULT CheckInterfaceSupport(in global::System.Guid InterfaceName, out long pUMDVersion)
            {
                fixed (long *pUMDVersionLocal = &pUMDVersion)
                {
                    fixed (global::System.Guid*InterfaceNameLocal = &InterfaceName)
                    {
                        win32.System.Com.HRESULT __result = this.CheckInterfaceSupport(InterfaceNameLocal, pUMDVersionLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT CheckInterfaceSupport(global::System.Guid*InterfaceName, long *pUMDVersion)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->CheckInterfaceSupport_10(pThis, InterfaceName, pUMDVersion);
            }

            /// <inheritdoc cref = "GetDesc1(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc1(out win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1 pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc1(pDescLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDesc1(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1*pDesc)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->GetDesc1_11(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetDesc2(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc2(out win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2 pDesc)
            {
                fixed (win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc2(pDescLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDesc2(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*pDesc)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->GetDesc2_12(pThis, pDesc);
            }

            /// <inheritdoc cref = "RegisterHardwareContentProtectionTeardownStatusEvent(win32.System.SystemServices.HANDLE, uint *)"/>
            internal unsafe win32.System.Com.HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(SafeHandle hEvent, out uint pdwCookie)
            {
                bool hEventAddRef = false;
                try
                {
                    fixed (uint *pdwCookieLocal = &pdwCookie)
                    {
                        win32.System.SystemServices.HANDLE hEventLocal;
                        if (hEvent is object)
                        {
                            hEvent.DangerousAddRef(ref hEventAddRef);
                            hEventLocal = (win32.System.SystemServices.HANDLE)hEvent.DangerousGetHandle();
                        }
                        else
                            hEventLocal = default(win32.System.SystemServices.HANDLE);
                        win32.System.Com.HRESULT __result = this.RegisterHardwareContentProtectionTeardownStatusEvent(hEventLocal, pdwCookieLocal);
                        return __result;
                    }
                }
                finally
                {
                    if (hEventAddRef)
                        hEvent.DangerousRelease();
                }
            }

            /// <summary>Registers to receive notification of hardware content protection teardown events.</summary>
            /// <param name = "hEvent">
            /// <para>Type: <b>HANDLE</b></para>
            /// <para>A handle to the event object that the operating system sets when hardware content protection teardown occurs. The <a href = "https://docs.microsoft.com/windows/desktop/api/synchapi/nf-synchapi-createeventa">CreateEvent</a> or <a href = "https://docs.microsoft.com/windows/desktop/api/synchapi/nf-synchapi-openeventa">OpenEvent</a> function returns this handle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pdwCookie">
            /// <para>Type: <b>DWORD*</b></para>
            /// <para>A pointer to a key value that an application can pass to the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregisterhardwarecontentprotectionteardownstatus">IDXGIAdapter3::UnregisterHardwareContentProtectionTeardownStatus</a> method to unregister the notification event that <i>hEvent</i> specifies.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(win32.System.SystemServices.HANDLE hEvent, uint *pdwCookie)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->RegisterHardwareContentProtectionTeardownStatusEvent_13(pThis, hEvent, pdwCookie);
            }

            /// <summary>Unregisters an event to stop it from receiving notification of hardware content protection teardown events.</summary>
            /// <param name = "dwCookie">
            /// <para>Type: <b>DWORD</b></para>
            /// <para>A key value for the window or event to unregister. The  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent">IDXGIAdapter3::RegisterHardwareContentProtectionTeardownStatusEvent</a> method returns this value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregisterhardwarecontentprotectionteardownstatus#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregisterhardwarecontentprotectionteardownstatus">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void UnregisterHardwareContentProtectionTeardownStatus(uint dwCookie)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    lpVtbl->UnregisterHardwareContentProtectionTeardownStatus_14(pThis, dwCookie);
            }

            /// <inheritdoc cref = "QueryVideoMemoryInfo(uint, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP, win32.Graphics.Dxgi.DXGI_QUERY_VIDEO_MEMORY_INFO*)"/>
            internal unsafe win32.System.Com.HRESULT QueryVideoMemoryInfo(uint NodeIndex, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, out win32.Graphics.Dxgi.DXGI_QUERY_VIDEO_MEMORY_INFO pVideoMemoryInfo)
            {
                fixed (win32.Graphics.Dxgi.DXGI_QUERY_VIDEO_MEMORY_INFO*pVideoMemoryInfoLocal = &pVideoMemoryInfo)
                {
                    win32.System.Com.HRESULT __result = this.QueryVideoMemoryInfo(NodeIndex, MemorySegmentGroup, pVideoMemoryInfoLocal);
                    return __result;
                }
            }

            /// <summary>This method informs the process of the current budget and process usage.</summary>
            /// <param name = "NodeIndex">
            /// <para>Type: <b>UINT</b></para>
            /// <para>Specifies the device's physical adapter for which the video memory information is queried. For single-GPU operation, set this to zero. If there are multiple GPU nodes, set this to the index of the node (the device's physical adapter) for which the video memory information is queried. See <a href = "https://docs.microsoft.com/windows/win32/direct3d12/multi-engine">Multi-adapter systems</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-queryvideomemoryinfo#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "MemorySegmentGroup">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dxgi1_4/ne-dxgi1_4-dxgi_memory_segment_group">DXGI_MEMORY_SEGMENT_GROUP</a></b></para>
            /// <para>Specifies a DXGI_MEMORY_SEGMENT_GROUP that identifies the group as local or non-local.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-queryvideomemoryinfo#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pVideoMemoryInfo">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dxgi1_4/ns-dxgi1_4-dxgi_query_video_memory_info">DXGI_QUERY_VIDEO_MEMORY_INFO</a>*</b></para>
            /// <para>Fills in a DXGI_QUERY_VIDEO_MEMORY_INFO structure with the current values.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-queryvideomemoryinfo#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK if successful; an error code otherwise. For a list of error codes, see <a href = "/windows/win32/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-queryvideomemoryinfo">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT QueryVideoMemoryInfo(uint NodeIndex, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, win32.Graphics.Dxgi.DXGI_QUERY_VIDEO_MEMORY_INFO*pVideoMemoryInfo)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->QueryVideoMemoryInfo_15(pThis, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
            }

            /// <summary>This method sends the minimum required physical memory for an application, to the OS.</summary>
            /// <param name = "NodeIndex">
            /// <para>Type: <b>UINT</b></para>
            /// <para>Specifies the device's physical adapter for which the video memory information is being set. For single-GPU operation, set this to zero. If there are multiple GPU nodes, set this to the index of the node (the device's physical adapter) for which the video memory information is being set. See <a href = "https://docs.microsoft.com/windows/win32/direct3d12/multi-engine">Multi-adapter systems</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-setvideomemoryreservation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "MemorySegmentGroup">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dxgi1_4/ne-dxgi1_4-dxgi_memory_segment_group">DXGI_MEMORY_SEGMENT_GROUP</a></b></para>
            /// <para>Specifies a DXGI_MEMORY_SEGMENT_GROUP that identifies the group as local or non-local.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-setvideomemoryreservation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "Reservation">
            /// <para>Type: <b>UINT64</b></para>
            /// <para>Specifies a UINT64 that sets the minimum required physical memory, in bytes.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-setvideomemoryreservation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK if successful; an error code otherwise. For a list of error codes, see <a href = "/windows/win32/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-setvideomemoryreservation">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetVideoMemoryReservation(uint NodeIndex, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, ulong Reservation)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->SetVideoMemoryReservation_16(pThis, NodeIndex, MemorySegmentGroup, Reservation);
            }

            /// <inheritdoc cref = "RegisterVideoMemoryBudgetChangeNotificationEvent(win32.System.SystemServices.HANDLE, uint *)"/>
            internal unsafe win32.System.Com.HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(SafeHandle hEvent, out uint pdwCookie)
            {
                bool hEventAddRef = false;
                try
                {
                    fixed (uint *pdwCookieLocal = &pdwCookie)
                    {
                        win32.System.SystemServices.HANDLE hEventLocal;
                        if (hEvent is object)
                        {
                            hEvent.DangerousAddRef(ref hEventAddRef);
                            hEventLocal = (win32.System.SystemServices.HANDLE)hEvent.DangerousGetHandle();
                        }
                        else
                            hEventLocal = default(win32.System.SystemServices.HANDLE);
                        win32.System.Com.HRESULT __result = this.RegisterVideoMemoryBudgetChangeNotificationEvent(hEventLocal, pdwCookieLocal);
                        return __result;
                    }
                }
                finally
                {
                    if (hEventAddRef)
                        hEvent.DangerousRelease();
                }
            }

            /// <summary>This method establishes a correlation between a CPU synchronization object and the budget change event.</summary>
            /// <param name = "hEvent">
            /// <para>Type: <b>HANDLE</b></para>
            /// <para>Specifies a HANDLE for the event.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registervideomemorybudgetchangenotificationevent#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pdwCookie">
            /// <para>Type: <b>DWORD*</b></para>
            /// <para>A key value for the window or event to unregister. The  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent">IDXGIAdapter3::RegisterHardwareContentProtectionTeardownStatusEvent</a> method returns this value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registervideomemorybudgetchangenotificationevent#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-registervideomemorybudgetchangenotificationevent">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(win32.System.SystemServices.HANDLE hEvent, uint *pdwCookie)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    return lpVtbl->RegisterVideoMemoryBudgetChangeNotificationEvent_17(pThis, hEvent, pdwCookie);
            }

            /// <summary>This method stops notifying a CPU synchronization object whenever a budget change occurs. An application may switch back to polling the information regularly.</summary>
            /// <param name = "dwCookie">
            /// <para>Type: <b>DWORD</b></para>
            /// <para>A key value for the window or event to unregister. The  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent">IDXGIAdapter3::RegisterHardwareContentProtectionTeardownStatusEvent</a> method returns this value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregistervideomemorybudgetchangenotification#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>An application may switch back to polling for the information regularly.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregistervideomemorybudgetchangenotification#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void UnregisterVideoMemoryBudgetChangeNotification(uint dwCookie)
            {
                fixed (IDXGIAdapter3*pThis = &this)
                    lpVtbl->UnregisterVideoMemoryBudgetChangeNotification_18(pThis, dwCookie);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>EnumOutputs_8;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC*, win32.System.Com.HRESULT>GetDesc_9;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, global::System.Guid*, long *, win32.System.Com.HRESULT>CheckInterfaceSupport_10;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1*, win32.System.Com.HRESULT>GetDesc1_11;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*, win32.System.Com.HRESULT>GetDesc2_12;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, win32.System.SystemServices.HANDLE, uint *, win32.System.Com.HRESULT>RegisterHardwareContentProtectionTeardownStatusEvent_13;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint, void>UnregisterHardwareContentProtectionTeardownStatus_14;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP, win32.Graphics.Dxgi.DXGI_QUERY_VIDEO_MEMORY_INFO*, win32.System.Com.HRESULT>QueryVideoMemoryInfo_15;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint, win32.Graphics.Dxgi.DXGI_MEMORY_SEGMENT_GROUP, ulong, win32.System.Com.HRESULT>SetVideoMemoryReservation_16;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, win32.System.SystemServices.HANDLE, uint *, win32.System.Com.HRESULT>RegisterVideoMemoryBudgetChangeNotificationEvent_17;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter3*, uint, void>UnregisterVideoMemoryBudgetChangeNotification_18;
            }

            private Vtbl*lpVtbl;
        }
    }
}