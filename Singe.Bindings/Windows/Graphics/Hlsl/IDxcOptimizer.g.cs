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
        [Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
        internal unsafe struct IDxcOptimizer
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
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetAvailablePassCount(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetAvailablePassCount(out uint pCount)
            {
                fixed (uint *pCountLocal = &pCount)
                {
                    win32.System.Com.HRESULT __result = this.GetAvailablePassCount(pCountLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetAvailablePassCount(uint *pCount)
            {
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->GetAvailablePassCount_4(pThis, pCount);
            }

            internal unsafe win32.System.Com.HRESULT GetAvailablePass(uint index, win32.Graphics.Hlsl.IDxcOptimizerPass**ppResult)
            {
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->GetAvailablePass_5(pThis, index, ppResult);
            }

            /// <inheritdoc cref = "RunOptimizer(win32.Graphics.Hlsl.IDxcBlob*, win32.System.SystemServices.PWSTR*, uint, win32.Graphics.Hlsl.IDxcBlob**, win32.Graphics.Hlsl.IDxcBlobEncoding**)"/>
            internal unsafe win32.System.Com.HRESULT RunOptimizer(win32.Graphics.Hlsl.IDxcBlob*pBlob, Span<win32.System.SystemServices.PWSTR> ppOptions, win32.Graphics.Hlsl.IDxcBlob**pOutputModule, win32.Graphics.Hlsl.IDxcBlobEncoding**ppOutputText)
            {
                fixed (win32.System.SystemServices.PWSTR*ppOptionsLocal = ppOptions)
                {
                    win32.System.Com.HRESULT __result = this.RunOptimizer(pBlob, ppOptionsLocal, (uint)ppOptions.Length, pOutputModule, ppOutputText);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT RunOptimizer(win32.Graphics.Hlsl.IDxcBlob*pBlob, win32.System.SystemServices.PWSTR*ppOptions, uint optionCount, win32.Graphics.Hlsl.IDxcBlob**pOutputModule, [Optional] win32.Graphics.Hlsl.IDxcBlobEncoding**ppOutputText)
            {
                fixed (IDxcOptimizer*pThis = &this)
                    return lpVtbl->RunOptimizer_6(pThis, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, uint *, win32.System.Com.HRESULT>GetAvailablePassCount_4;
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, uint, win32.Graphics.Hlsl.IDxcOptimizerPass**, win32.System.Com.HRESULT>GetAvailablePass_5;
                internal delegate *unmanaged[Stdcall]<IDxcOptimizer*, win32.Graphics.Hlsl.IDxcBlob*, win32.System.SystemServices.PWSTR*, uint, win32.Graphics.Hlsl.IDxcBlob**, win32.Graphics.Hlsl.IDxcBlobEncoding**, win32.System.Com.HRESULT>RunOptimizer_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}