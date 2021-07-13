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
        [Guid("0AA1AE0A-FA0E-4B84-8644-E05FF8E5ACB5")]
        internal unsafe struct IDXGIAdapter2
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
                fixed (IDXGIAdapter2*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIAdapter2*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
                    return lpVtbl->GetParent_7(pThis, riid, ppParent);
            }

            internal unsafe win32.System.Com.HRESULT EnumOutputs(uint Output, win32.Graphics.Dxgi.IDXGIOutput**ppOutput)
            {
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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
                fixed (IDXGIAdapter2*pThis = &this)
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

            /// <summary>Gets a Microsoft DirectX Graphics Infrastructure (DXGI) 1.2 description of an adapter or video card.</summary>
            /// <param name = "pDesc">
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi1_2/ns-dxgi1_2-dxgi_adapter_desc2">DXGI_ADAPTER_DESC2</a> structure that describes the adapter. This parameter must not be <b>NULL</b>. On <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9 graphics hardware, earlier versions of  <b>GetDesc2</b> (<a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgiadapter-getdesc">GetDesc</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgiadapter1-getdesc1">GetDesc1</a>) return zeros for the PCI ID in the <b>VendorId</b>, <b>DeviceId</b>, <b>SubSysId</b>, and <b>Revision</b> members of the adapter description structure and “Software Adapter” for the description string in the <b>Description</b> member. <b>GetDesc2</b> returns the actual feature level 9 hardware values in these members.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiadapter2-getdesc2#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>Returns S_OK if successful; otherwise, returns E_INVALIDARG if the <i>pDesc</i> parameter is <b>NULL</b>.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi1_2/nf-dxgi1_2-idxgiadapter2-getdesc2">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDesc2(win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*pDesc)
            {
                fixed (IDXGIAdapter2*pThis = &this)
                    return lpVtbl->GetDesc2_12(pThis, pDesc);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_5;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetParent_7;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, uint, win32.Graphics.Dxgi.IDXGIOutput**, win32.System.Com.HRESULT>EnumOutputs_8;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC*, win32.System.Com.HRESULT>GetDesc_9;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, global::System.Guid*, long *, win32.System.Com.HRESULT>CheckInterfaceSupport_10;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC1*, win32.System.Com.HRESULT>GetDesc1_11;
                internal delegate *unmanaged[Stdcall]<IDXGIAdapter2*, win32.Graphics.Dxgi.DXGI_ADAPTER_DESC2*, win32.System.Com.HRESULT>GetDesc2_12;
            }

            private Vtbl*lpVtbl;
        }
    }
}