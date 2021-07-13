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
        [Guid("0C711683-2853-4846-9BB0-F3E60639E46A")]
        internal unsafe struct ID3D11Texture3D1
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
                fixed (ID3D11Texture3D1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D11.ID3D11Device**ppDevice)
            {
                fixed (ID3D11Texture3D1*pThis = &this)
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
                fixed (ID3D11Texture3D1*pThis = &this)
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
                fixed (ID3D11Texture3D1*pThis = &this)
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
                fixed (ID3D11Texture3D1*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            /// <inheritdoc cref = "GetType(win32.Graphics.Direct3D11.D3D11_RESOURCE_DIMENSION*)"/>
            internal unsafe void GetType(out win32.Graphics.Direct3D11.D3D11_RESOURCE_DIMENSION pResourceDimension)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_RESOURCE_DIMENSION*pResourceDimensionLocal = &pResourceDimension)
                {
                    this.GetType(pResourceDimensionLocal);
                }
            }

            internal unsafe void GetType(win32.Graphics.Direct3D11.D3D11_RESOURCE_DIMENSION*pResourceDimension)
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    lpVtbl->GetType_8(pThis, pResourceDimension);
            }

            internal void SetEvictionPriority(uint EvictionPriority)
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    lpVtbl->SetEvictionPriority_9(pThis, EvictionPriority);
            }

            internal uint GetEvictionPriority()
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    return lpVtbl->GetEvictionPriority_10(pThis);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC*)"/>
            internal unsafe void GetDesc(out win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC*pDescLocal = &pDesc)
                {
                    this.GetDesc(pDescLocal);
                }
            }

            internal unsafe void GetDesc(win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC*pDesc)
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    lpVtbl->GetDesc_11(pThis, pDesc);
            }

            /// <inheritdoc cref = "GetDesc1(win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC1*)"/>
            internal unsafe void GetDesc1(out win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC1 pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC1*pDescLocal = &pDesc)
                {
                    this.GetDesc1(pDescLocal);
                }
            }

            /// <summary>Gets the properties of the texture resource.</summary>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_3/ns-d3d11_3-cd3d11_texture3d_desc1">D3D11_TEXTURE3D_DESC1</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_3/ns-d3d11_3-cd3d11_texture3d_desc1">D3D11_TEXTURE3D_DESC1</a> structure that receives the description of the 3D texture.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11texture3d1-getdesc1#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11texture3d1-getdesc1">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetDesc1(win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC1*pDesc)
            {
                fixed (ID3D11Texture3D1*pThis = &this)
                    lpVtbl->GetDesc1_12(pThis, pDesc);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, win32.Graphics.Direct3D11.ID3D11Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, win32.Graphics.Direct3D11.D3D11_RESOURCE_DIMENSION*, void>GetType_8;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, uint, void>SetEvictionPriority_9;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, uint>GetEvictionPriority_10;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC*, void>GetDesc_11;
                internal delegate *unmanaged[Stdcall]<ID3D11Texture3D1*, win32.Graphics.Direct3D11.D3D11_TEXTURE3D_DESC1*, void>GetDesc1_12;
            }

            private Vtbl*lpVtbl;
        }
    }
}