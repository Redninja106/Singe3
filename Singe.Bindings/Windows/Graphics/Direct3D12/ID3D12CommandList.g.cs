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
        [Guid("7116D91C-E7E4-47CE-B8C6-EC8168F437E5")]
        internal unsafe struct ID3D12CommandList
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
                fixed (ID3D12CommandList*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12CommandList*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12CommandList*pThis = &this)
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
                fixed (ID3D12CommandList*pThis = &this)
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
                fixed (ID3D12CommandList*pThis = &this)
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
                fixed (ID3D12CommandList*pThis = &this)
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
                fixed (ID3D12CommandList*pThis = &this)
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
                fixed (ID3D12CommandList*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppvDevice);
            }

            /// <summary>Gets the type of the command list, such as direct, bundle, compute, or copy.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d12/ne-d3d12-d3d12_command_list_type">D3D12_COMMAND_LIST_TYPE</a></b></para>
            /// <para>This method returns the type of the command list, as a <a href = "/windows/desktop/api/d3d12/ne-d3d12-d3d12_command_list_type">D3D12_COMMAND_LIST_TYPE</a> enumeration constant, such as direct, bundle, compute, or copy.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12commandlist-gettype">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal new win32.Graphics.Direct3D12.D3D12_COMMAND_LIST_TYPE GetType()
            {
                fixed (ID3D12CommandList*pThis = &this)
                    return lpVtbl->GetType_9(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_6;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, win32.System.SystemServices.PCWSTR, win32.System.Com.HRESULT>SetName_7;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<ID3D12CommandList*, win32.Graphics.Direct3D12.D3D12_COMMAND_LIST_TYPE>GetType_9;
            }

            private Vtbl*lpVtbl;
        }
    }
}