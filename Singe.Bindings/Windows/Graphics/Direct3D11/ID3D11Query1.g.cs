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

    namespace Graphics.Direct3D11
    {
        [Guid("631B4766-36DC-461D-8DB6-C47E13E60916")]
        internal unsafe struct ID3D11Query1
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
                fixed (ID3D11Query1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11Query1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11Query1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D11.ID3D11Device**ppDevice)
            {
                fixed (ID3D11Query1*pThis = &this)
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
                fixed (ID3D11Query1*pThis = &this)
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
                fixed (ID3D11Query1*pThis = &this)
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
                fixed (ID3D11Query1*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            internal uint GetDataSize()
            {
                fixed (ID3D11Query1*pThis = &this)
                    return lpVtbl->GetDataSize_8(pThis);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D11.D3D11_QUERY_DESC*)"/>
            internal unsafe void GetDesc(out win32.Graphics.Direct3D11.D3D11_QUERY_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_QUERY_DESC*pDescLocal = &pDesc)
                {
                    this.GetDesc(pDescLocal);
                }
            }

            internal unsafe void GetDesc(win32.Graphics.Direct3D11.D3D11_QUERY_DESC*pDesc)
            {
                fixed (ID3D11Query1*pThis = &this)
                    lpVtbl->GetDesc_9(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetDesc1(win32.Graphics.Direct3D11.D3D11_QUERY_DESC1*)"/>
            internal unsafe void GetDesc1(out win32.Graphics.Direct3D11.D3D11_QUERY_DESC1 pDesc1)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_QUERY_DESC1*pDesc1Local = &pDesc1)
                {
                    this.GetDesc1(pDesc1Local);
                }
            }

            /// <summary>Gets a query description.</summary>
            /// <param name = "pDesc1">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_3/ns-d3d11_3-cd3d11_query_desc1">D3D11_QUERY_DESC1</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_3/ns-d3d11_3-cd3d11_query_desc1">D3D11_QUERY_DESC1</a> structure that receives a description of the query.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11query1-getdesc1#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11query1-getdesc1">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetDesc1(win32.Graphics.Direct3D11.D3D11_QUERY_DESC1*pDesc1)
            {
                fixed (ID3D11Query1*pThis = &this)
                    lpVtbl->GetDesc1_10(pThis, pDesc1);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, win32.Graphics.Direct3D11.ID3D11Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, uint>GetDataSize_8;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, win32.Graphics.Direct3D11.D3D11_QUERY_DESC*, void>GetDesc_9;
                internal delegate *unmanaged[Stdcall]<ID3D11Query1*, win32.Graphics.Direct3D11.D3D11_QUERY_DESC1*, void>GetDesc1_10;
            }

            private Vtbl*lpVtbl;
        }
    }
}