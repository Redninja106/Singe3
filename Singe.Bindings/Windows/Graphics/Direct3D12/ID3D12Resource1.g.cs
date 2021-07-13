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

    namespace Graphics.Direct3D12
    {
        [Guid("9D5E227A-4430-4161-88B3-3ECA6BB16E19")]
        internal unsafe struct ID3D12Resource1
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
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
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
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetPrivateData_4(pThis, guid, pDataSize, pData);
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
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->SetPrivateData_5(pThis, guid, DataSize, pData);
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
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_6(pThis, guid, pData);
            }

            /// <inheritdoc cref = "SetName(win32.System.SystemServices.PCWSTR)"/>
            internal unsafe win32.System.Com.HRESULT SetName(string Name)
            {
                fixed (char *NameLocal = Name)
                {
                    win32.System.Com.HRESULT __result = this.SetName(NameLocal);
                    return __result;
                }
            }

            internal win32.System.Com.HRESULT SetName(win32.System.SystemServices.PCWSTR Name)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->SetName_7(pThis, Name);
            }

            /// <inheritdoc cref = "GetDevice(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetDevice(in global::System.Guid riid, void **ppvDevice)
            {
                fixed (global::System.Guid*riidLocal = &riid)
                {
                    win32.System.Com.HRESULT __result = this.GetDevice(riidLocal, ppvDevice);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDevice(global::System.Guid*riid, [Optional] void **ppvDevice)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppvDevice);
            }

            /// <inheritdoc cref = "Map(uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void **)"/>
            internal unsafe win32.System.Com.HRESULT Map(uint Subresource, win32.Graphics.Direct3D12.D3D12_RANGE? pReadRange, void **ppData)
            {
                win32.Graphics.Direct3D12.D3D12_RANGE pReadRangeLocal = pReadRange.HasValue ? pReadRange.Value : default(win32.Graphics.Direct3D12.D3D12_RANGE);
                win32.System.Com.HRESULT __result = this.Map(Subresource, pReadRange.HasValue ? &pReadRangeLocal : null, ppData);
                return __result;
            }

            internal unsafe win32.System.Com.HRESULT Map(uint Subresource, [Optional] win32.Graphics.Direct3D12.D3D12_RANGE*pReadRange, [Optional] void **ppData)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->Map_9(pThis, Subresource, pReadRange, ppData);
            }

            /// <inheritdoc cref = "Unmap(uint, win32.Graphics.Direct3D12.D3D12_RANGE*)"/>
            internal unsafe void Unmap(uint Subresource, win32.Graphics.Direct3D12.D3D12_RANGE? pWrittenRange)
            {
                win32.Graphics.Direct3D12.D3D12_RANGE pWrittenRangeLocal = pWrittenRange.HasValue ? pWrittenRange.Value : default(win32.Graphics.Direct3D12.D3D12_RANGE);
                this.Unmap(Subresource, pWrittenRange.HasValue ? &pWrittenRangeLocal : null);
            }

            internal unsafe void Unmap(uint Subresource, [Optional] win32.Graphics.Direct3D12.D3D12_RANGE*pWrittenRange)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    lpVtbl->Unmap_10(pThis, Subresource, pWrittenRange);
            }

            internal win32.Graphics.Direct3D12.D3D12_RESOURCE_DESC GetDesc()
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetDesc_11(pThis);
            }

            internal ulong GetGPUVirtualAddress()
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetGPUVirtualAddress_12(pThis);
            }

            /// <inheritdoc cref = "WriteToSubresource(uint, win32.Graphics.Direct3D12.D3D12_BOX*, void *, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT WriteToSubresource(uint DstSubresource, win32.Graphics.Direct3D12.D3D12_BOX? pDstBox, void *pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
            {
                win32.Graphics.Direct3D12.D3D12_BOX pDstBoxLocal = pDstBox.HasValue ? pDstBox.Value : default(win32.Graphics.Direct3D12.D3D12_BOX);
                win32.System.Com.HRESULT __result = this.WriteToSubresource(DstSubresource, pDstBox.HasValue ? &pDstBoxLocal : null, pSrcData, SrcRowPitch, SrcDepthPitch);
                return __result;
            }

            internal unsafe win32.System.Com.HRESULT WriteToSubresource(uint DstSubresource, [Optional] win32.Graphics.Direct3D12.D3D12_BOX*pDstBox, void *pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->WriteToSubresource_13(pThis, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }

            /// <inheritdoc cref = "ReadFromSubresource(void *, uint, uint, uint, win32.Graphics.Direct3D12.D3D12_BOX*)"/>
            internal unsafe win32.System.Com.HRESULT ReadFromSubresource(void *pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, win32.Graphics.Direct3D12.D3D12_BOX? pSrcBox)
            {
                win32.Graphics.Direct3D12.D3D12_BOX pSrcBoxLocal = pSrcBox.HasValue ? pSrcBox.Value : default(win32.Graphics.Direct3D12.D3D12_BOX);
                win32.System.Com.HRESULT __result = this.ReadFromSubresource(pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox.HasValue ? &pSrcBoxLocal : null);
                return __result;
            }

            internal unsafe win32.System.Com.HRESULT ReadFromSubresource(void *pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Optional] win32.Graphics.Direct3D12.D3D12_BOX*pSrcBox)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->ReadFromSubresource_14(pThis, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
            }

            internal unsafe win32.System.Com.HRESULT GetHeapProperties([Optional] win32.Graphics.Direct3D12.D3D12_HEAP_PROPERTIES*pHeapProperties, [Optional] win32.Graphics.Direct3D12.D3D12_HEAP_FLAGS*pHeapFlags)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetHeapProperties_15(pThis, pHeapProperties, pHeapFlags);
            }

            /// <inheritdoc cref = "GetProtectedResourceSession(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetProtectedResourceSession(in global::System.Guid riid, void **ppProtectedSession)
            {
                fixed (global::System.Guid*riidLocal = &riid)
                {
                    win32.System.Com.HRESULT __result = this.GetProtectedResourceSession(riidLocal, ppProtectedSession);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetProtectedResourceSession(global::System.Guid*riid, [Optional] void **ppProtectedSession)
            {
                fixed (ID3D12Resource1*pThis = &this)
                    return lpVtbl->GetProtectedResourceSession_16(pThis, riid, ppProtectedSession);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_6;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, win32.System.SystemServices.PCWSTR, win32.System.Com.HRESULT>SetName_7;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void **, win32.System.Com.HRESULT>Map_9;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void>Unmap_10;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, win32.Graphics.Direct3D12.D3D12_RESOURCE_DESC>GetDesc_11;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, ulong>GetGPUVirtualAddress_12;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, uint, win32.Graphics.Direct3D12.D3D12_BOX*, void *, uint, uint, win32.System.Com.HRESULT>WriteToSubresource_13;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, void *, uint, uint, uint, win32.Graphics.Direct3D12.D3D12_BOX*, win32.System.Com.HRESULT>ReadFromSubresource_14;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, win32.Graphics.Direct3D12.D3D12_HEAP_PROPERTIES*, win32.Graphics.Direct3D12.D3D12_HEAP_FLAGS*, win32.System.Com.HRESULT>GetHeapProperties_15;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetProtectedResourceSession_16;
            }

            private Vtbl*lpVtbl;
        }
    }
}