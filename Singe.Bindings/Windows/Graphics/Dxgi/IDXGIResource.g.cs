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
        [Guid("035F3AB4-482E-4E50-B41F-8A7F8BD8960B")]
        internal unsafe struct IDXGIResource
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
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIResource*pThis = &this)
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
                fixed (IDXGIResource*pThis = &this)
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
                fixed (IDXGIResource*pThis = &this)
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
                fixed (IDXGIResource*pThis = &this)
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
                fixed (IDXGIResource*pThis = &this)
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
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppDevice);
            }

            /// <inheritdoc cref = "GetSharedHandle(win32.System.SystemServices.HANDLE*)"/>
            internal unsafe win32.System.Com.HRESULT GetSharedHandle(out Microsoft.Win32.SafeHandles.SafeFileHandle pSharedHandle)
            {
                win32.System.SystemServices.HANDLE pSharedHandleLocal;
                win32.System.Com.HRESULT __result = this.GetSharedHandle(&pSharedHandleLocal);
                pSharedHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle(pSharedHandleLocal, ownsHandle: true);
                return __result;
            }

            /// <summary>Gets the handle to a shared resource.</summary>
            /// <param name = "pSharedHandle">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HANDLE</a>*</b></para>
            /// <para>A pointer to a handle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getsharedhandle#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a> values.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getsharedhandle">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetSharedHandle(win32.System.SystemServices.HANDLE*pSharedHandle)
            {
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->GetSharedHandle_9(pThis, pSharedHandle);
            }

            /// <inheritdoc cref = "GetUsage(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetUsage(out uint pUsage)
            {
                fixed (uint *pUsageLocal = &pUsage)
                {
                    win32.System.Com.HRESULT __result = this.GetUsage(pUsageLocal);
                    return __result;
                }
            }

            /// <summary>Get the expected resource usage.</summary>
            /// <param name = "pUsage">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-usage">DXGI_USAGE</a>*</b></para>
            /// <para>A pointer to a usage flag (see <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-usage">DXGI_USAGE</a>). For Direct3D 10, a surface can be used as a shader input or a render-target output.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getusage#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getusage">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetUsage(uint *pUsage)
            {
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->GetUsage_10(pThis, pUsage);
            }

            /// <summary>Set the priority for evicting the resource from memory.</summary>
            /// <param name = "EvictionPriority">Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-setevictionpriority">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetEvictionPriority(win32.Graphics.Dxgi.DXGI_RESOURCE_PRIORITY EvictionPriority)
            {
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->SetEvictionPriority_11(pThis, EvictionPriority);
            }

            /// <inheritdoc cref = "GetEvictionPriority(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetEvictionPriority(out uint pEvictionPriority)
            {
                fixed (uint *pEvictionPriorityLocal = &pEvictionPriority)
                {
                    win32.System.Com.HRESULT __result = this.GetEvictionPriority(pEvictionPriorityLocal);
                    return __result;
                }
            }

            /// <summary>Get the eviction priority.</summary>
            /// <param name = "pEvictionPriority">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a>*</b></para>
            /// <para>A pointer to the eviction priority, which determines when a resource can be evicted from memory.</para>
            /// <para>The following defined values are possible.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getevictionpriority#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/nf-dxgi-idxgiresource-getevictionpriority">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetEvictionPriority(uint *pEvictionPriority)
            {
                fixed (IDXGIResource*pThis = &this)
                    return lpVtbl->GetEvictionPriority_12(pThis, pEvictionPriority);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, win32.System.SystemServices.HANDLE*, win32.System.Com.HRESULT>GetSharedHandle_9;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, uint *, win32.System.Com.HRESULT>GetUsage_10;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, win32.Graphics.Dxgi.DXGI_RESOURCE_PRIORITY, win32.System.Com.HRESULT>SetEvictionPriority_11;
                internal delegate *unmanaged[Stdcall]<IDXGIResource*, uint *, win32.System.Com.HRESULT>GetEvictionPriority_12;
            }

            private Vtbl*lpVtbl;
        }
    }
}