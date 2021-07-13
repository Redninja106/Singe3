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

    namespace Graphics.Hlsl
    {
        [Guid("CEDB484A-D4E9-445A-B991-CA21CA157DC2")]
        internal unsafe struct IDxcOperationResult
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
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetStatus(win32.System.Com.HRESULT*)"/>
            internal unsafe win32.System.Com.HRESULT GetStatus(out win32.System.Com.HRESULT pStatus)
            {
                fixed (win32.System.Com.HRESULT*pStatusLocal = &pStatus)
                {
                    win32.System.Com.HRESULT __result = this.GetStatus(pStatusLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetStatus(win32.System.Com.HRESULT*pStatus)
            {
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->GetStatus_4(pThis, pStatus);
            }

            internal unsafe win32.System.Com.HRESULT GetResult([Optional] win32.Graphics.Hlsl.IDxcBlob**pResult)
            {
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->GetResult_5(pThis, pResult);
            }

            internal unsafe win32.System.Com.HRESULT GetErrorBuffer([Optional] win32.Graphics.Hlsl.IDxcBlobEncoding**pErrors)
            {
                fixed (IDxcOperationResult*pThis = &this)
                    return lpVtbl->GetErrorBuffer_6(pThis, pErrors);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, win32.System.Com.HRESULT*, win32.System.Com.HRESULT>GetStatus_4;
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, win32.Graphics.Hlsl.IDxcBlob**, win32.System.Com.HRESULT>GetResult_5;
                internal delegate *unmanaged[Stdcall]<IDxcOperationResult*, win32.Graphics.Hlsl.IDxcBlobEncoding**, win32.System.Com.HRESULT>GetErrorBuffer_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}