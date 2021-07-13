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
        [Guid("7F61FC7D-950D-467F-B3E3-3C02FB49187C")]
        internal unsafe struct IDxcIncludeHandler
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
                fixed (IDxcIncludeHandler*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcIncludeHandler*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcIncludeHandler*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "LoadSource(win32.System.SystemServices.PCWSTR, win32.Graphics.Hlsl.IDxcBlob**)"/>
            internal unsafe win32.System.Com.HRESULT LoadSource(string pFilename, win32.Graphics.Hlsl.IDxcBlob**ppIncludeSource)
            {
                fixed (char *pFilenameLocal = pFilename)
                {
                    win32.System.Com.HRESULT __result = this.LoadSource(pFilenameLocal, ppIncludeSource);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT LoadSource(win32.System.SystemServices.PCWSTR pFilename, [Optional] win32.Graphics.Hlsl.IDxcBlob**ppIncludeSource)
            {
                fixed (IDxcIncludeHandler*pThis = &this)
                    return lpVtbl->LoadSource_4(pThis, pFilename, ppIncludeSource);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcIncludeHandler*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcIncludeHandler*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcIncludeHandler*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcIncludeHandler*, win32.System.SystemServices.PCWSTR, win32.Graphics.Hlsl.IDxcBlob**, win32.System.Com.HRESULT>LoadSource_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}