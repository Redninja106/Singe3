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

    namespace Graphics.Direct3D10
    {
        [Guid("EDAD8D19-8A35-4D6D-8566-2EA276CDE161")]
        internal unsafe struct ID3D10BlendState
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
                fixed (ID3D10BlendState*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D10BlendState*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D10BlendState*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D10.ID3D10Device**ppDevice)
            {
                fixed (ID3D10BlendState*pThis = &this)
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
                fixed (ID3D10BlendState*pThis = &this)
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
                fixed (ID3D10BlendState*pThis = &this)
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
                fixed (ID3D10BlendState*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D10.D3D10_BLEND_DESC*)"/>
            internal unsafe void GetDesc(out win32.Graphics.Direct3D10.D3D10_BLEND_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D10.D3D10_BLEND_DESC*pDescLocal = &pDesc)
                {
                    this.GetDesc(pDescLocal);
                }
            }

            /// <summary>Get the blend state.</summary>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_blend_desc">D3D10_BLEND_DESC</a>*</b></para>
            /// <para>A pointer to the blend state (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_blend_desc">D3D10_BLEND_DESC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/nf-d3d10-id3d10blendstate-getdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/nf-d3d10-id3d10blendstate-getdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetDesc(win32.Graphics.Direct3D10.D3D10_BLEND_DESC*pDesc)
            {
                fixed (ID3D10BlendState*pThis = &this)
                    lpVtbl->GetDesc_8(pThis, pDesc);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, win32.Graphics.Direct3D10.ID3D10Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D10BlendState*, win32.Graphics.Direct3D10.D3D10_BLEND_DESC*, void>GetDesc_8;
            }

            private Vtbl*lpVtbl;
        }
    }
}