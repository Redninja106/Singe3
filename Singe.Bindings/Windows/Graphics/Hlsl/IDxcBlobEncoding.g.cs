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
        [Guid("7241D424-2646-4191-97C0-98E96E42FC68")]
        internal unsafe struct IDxcBlobEncoding
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
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void *GetBufferPointer()
            {
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->GetBufferPointer_4(pThis);
            }

            internal nuint GetBufferSize()
            {
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->GetBufferSize_5(pThis);
            }

            /// <inheritdoc cref = "GetEncoding(win32.System.SystemServices.BOOL*, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetEncoding(out win32.System.SystemServices.BOOL pKnown, out uint pCodePage)
            {
                fixed (uint *pCodePageLocal = &pCodePage)
                {
                    fixed (win32.System.SystemServices.BOOL*pKnownLocal = &pKnown)
                    {
                        win32.System.Com.HRESULT __result = this.GetEncoding(pKnownLocal, pCodePageLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetEncoding(win32.System.SystemServices.BOOL*pKnown, uint *pCodePage)
            {
                fixed (IDxcBlobEncoding*pThis = &this)
                    return lpVtbl->GetEncoding_6(pThis, pKnown, pCodePage);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, void *>GetBufferPointer_4;
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, nuint>GetBufferSize_5;
                internal delegate *unmanaged[Stdcall]<IDxcBlobEncoding*, win32.System.SystemServices.BOOL*, uint *, win32.System.Com.HRESULT>GetEncoding_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}