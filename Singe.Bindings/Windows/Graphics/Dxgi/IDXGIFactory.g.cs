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
        [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
        internal unsafe struct IDXGIFactory
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
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIFactory*pThis = &this)
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
                fixed (IDXGIFactory*pThis = &this)
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
                fixed (IDXGIFactory*pThis = &this)
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
                fixed (IDXGIFactory*pThis = &this)
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
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->GetParent_7(pThis, riid, ppParent);
            }

            /// <summary>Enumerates the adapters (video cards).</summary>
            /// <param name = "Adapter">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The index of the adapter to enumerate.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-enumadapters#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppAdapter">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiadapter">IDXGIAdapter</a>**</b></para>
            /// <para>The address of a pointer to an <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiadapter">IDXGIAdapter</a> interface at the position specified by the <i>Adapter</i> parameter.  This parameter must not be <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-enumadapters#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK if successful; otherwise, returns <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_NOT_FOUND</a> if the index is greater than or equal to the number of adapters in the local system, or <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a> if <i>ppAdapter</i> parameter is <b>NULL</b>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-enumadapters">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT EnumAdapters(uint Adapter, win32.Graphics.Dxgi.IDXGIAdapter**ppAdapter)
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->EnumAdapters_8(pThis, Adapter, ppAdapter);
            }

            /// <summary>Allows DXGI to monitor an application's message queue for the alt-enter key sequence (which causes the application to switch from windowed to full screen or vice versa).</summary>
            /// <param name = "WindowHandle">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a></b></para>
            /// <para>The handle of the window that is to be monitored. This parameter can be <b>NULL</b>; but only if *Flags* is also 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-makewindowassociation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "Flags">Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para><a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a> if <i>WindowHandle</i> is invalid, or E_OUTOFMEMORY.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-makewindowassociation">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT MakeWindowAssociation(win32.UI.WindowsAndMessaging.HWND WindowHandle, uint Flags)
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->MakeWindowAssociation_9(pThis, WindowHandle, Flags);
            }

            /// <inheritdoc cref = "GetWindowAssociation(win32.UI.WindowsAndMessaging.HWND*)"/>
            internal unsafe win32.System.Com.HRESULT GetWindowAssociation(out win32.UI.WindowsAndMessaging.HWND pWindowHandle)
            {
                fixed (win32.UI.WindowsAndMessaging.HWND*pWindowHandleLocal = &pWindowHandle)
                {
                    win32.System.Com.HRESULT __result = this.GetWindowAssociation(pWindowHandleLocal);
                    return __result;
                }
            }

            /// <summary>Get the window through which the user controls the transition to and from full screen.</summary>
            /// <param name = "pWindowHandle">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HWND</a>*</b></para>
            /// <para>A pointer to a window handle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-getwindowassociation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns a code that indicates success or failure. <b>S_OK</b> indicates success, <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a> indicates <i>pWindowHandle</i> was passed in as <b>NULL</b>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-getwindowassociation">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetWindowAssociation(win32.UI.WindowsAndMessaging.HWND*pWindowHandle)
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->GetWindowAssociation_10(pThis, pWindowHandle);
            }

            /// <inheritdoc cref = "CreateSwapChain(win32.System.Com.IUnknown*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*, win32.Graphics.Dxgi.IDXGISwapChain**)"/>
            internal unsafe win32.System.Com.HRESULT CreateSwapChain(win32.System.Com.IUnknown*pDevice, in win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC pDesc, win32.Graphics.Dxgi.IDXGISwapChain**ppSwapChain)
            {
                fixed (win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.CreateSwapChain(pDevice, pDescLocal, ppSwapChain);
                    return __result;
                }
            }

            /// <summary>Creates a swap chain.</summary>
            /// <param name = "pDevice">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/unknwn/nn-unknwn-iunknown">IUnknown</a>*</b></para>
            /// <para>For Direct3D 11, and earlier versions of Direct3D, this is a pointer to the Direct3D device for the swap chain. For Direct3D 12 this is a pointer to a direct command queue (refer to <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nn-d3d12-id3d12commandqueue">ID3D12CommandQueue</a>) . This parameter cannot be <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createswapchain#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_swap_chain_desc">DXGI_SWAP_CHAIN_DESC</a>*</b></para>
            /// <para>A pointer to a  <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/ns-dxgi-dxgi_swap_chain_desc">DXGI_SWAP_CHAIN_DESC</a> structure for the swap-chain description. This parameter cannot be <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createswapchain#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppSwapChain">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain">IDXGISwapChain</a>**</b></para>
            /// <para>A pointer to a variable that receives a pointer to the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain">IDXGISwapChain</a> interface for the swap chain that <b>CreateSwapChain</b> creates.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createswapchain#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para><a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_INVALID_CALL</a>  if <i>pDesc</i> or <i>ppSwapChain</i> is <b>NULL</b>, DXGI_STATUS_OCCLUDED if you request full-screen mode and it is unavailable, or E_OUTOFMEMORY. Other error codes defined by the type of device passed in may also be returned.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createswapchain">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT CreateSwapChain(win32.System.Com.IUnknown*pDevice, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*pDesc, win32.Graphics.Dxgi.IDXGISwapChain**ppSwapChain)
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->CreateSwapChain_11(pThis, pDevice, pDesc, ppSwapChain);
            }

            /// <inheritdoc cref = "CreateSoftwareAdapter(win32.System.SystemServices.HINSTANCE, win32.Graphics.Dxgi.IDXGIAdapter**)"/>
            internal unsafe win32.System.Com.HRESULT CreateSoftwareAdapter(SafeHandle Module, win32.Graphics.Dxgi.IDXGIAdapter**ppAdapter)
            {
                bool ModuleAddRef = false;
                try
                {
                    win32.System.SystemServices.HINSTANCE ModuleLocal;
                    if (Module is object)
                    {
                        Module.DangerousAddRef(ref ModuleAddRef);
                        ModuleLocal = (win32.System.SystemServices.HINSTANCE)Module.DangerousGetHandle();
                    }
                    else
                        ModuleLocal = default(win32.System.SystemServices.HINSTANCE);
                    win32.System.Com.HRESULT __result = this.CreateSoftwareAdapter(ModuleLocal, ppAdapter);
                    return __result;
                }
                finally
                {
                    if (ModuleAddRef)
                        Module.DangerousRelease();
                }
            }

            /// <summary>Create an adapter interface that represents a software adapter.</summary>
            /// <param name = "Module">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HMODULE</a></b></para>
            /// <para>Handle to the software adapter's dll. HMODULE can be obtained with <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandlea">GetModuleHandle</a> or <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createsoftwareadapter#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppAdapter">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiadapter">IDXGIAdapter</a>**</b></para>
            /// <para>Address of a pointer to an adapter (see <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiadapter">IDXGIAdapter</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createsoftwareadapter#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>A <a href = "/windows/desktop/direct3ddxgi/dxgi-error">return code</a> indicating success or failure.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgifactory-createsoftwareadapter">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT CreateSoftwareAdapter(win32.System.SystemServices.HINSTANCE Module, win32.Graphics.Dxgi.IDXGIAdapter**ppAdapter)
            {
                fixed (IDXGIFactory*pThis = &this)
                    return lpVtbl->CreateSoftwareAdapter_12(pThis, Module, ppAdapter);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, uint, win32.Graphics.Dxgi.IDXGIAdapter**, win32.System.Com.HRESULT>EnumAdapters_8;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, win32.UI.WindowsAndMessaging.HWND, uint, win32.System.Com.HRESULT>MakeWindowAssociation_9;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, win32.UI.WindowsAndMessaging.HWND*, win32.System.Com.HRESULT>GetWindowAssociation_10;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, win32.System.Com.IUnknown*, win32.Graphics.Dxgi.DXGI_SWAP_CHAIN_DESC*, win32.Graphics.Dxgi.IDXGISwapChain**, win32.System.Com.HRESULT>CreateSwapChain_11;
                internal delegate *unmanaged[Stdcall]<IDXGIFactory*, win32.System.SystemServices.HINSTANCE, win32.Graphics.Dxgi.IDXGIAdapter**, win32.System.Com.HRESULT>CreateSoftwareAdapter_12;
            }

            private Vtbl*lpVtbl;
        }
    }
}