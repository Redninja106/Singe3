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
        [Guid("119E7452-DE9E-40FE-8806-88F90C12B441")]
        internal unsafe struct IDXGIDebug
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
                fixed (IDXGIDebug*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIDebug*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIDebug*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Reports info about the lifetime of an object or objects.</summary>
            /// <param name = "apiid">The globally unique identifier (GUID) of the object or objects to get info about. Use one of the <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-debug-id">DXGI_DEBUG_ID</a> GUIDs.</param>
            /// <param name = "flags">A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgidebug/ne-dxgidebug-dxgi_debug_rlo_flags">DXGI_DEBUG_RLO_FLAGS</a>-typed value that specifies the amount of info to report.</param>
            /// <returns>Returns S_OK if successful; an error code otherwise. For a list of error codes, see <a href = "/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR</a>.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgidebug/nf-dxgidebug-idxgidebug-reportliveobjects">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT ReportLiveObjects(global::System.Guid apiid, win32.Graphics.Dxgi.DXGI_DEBUG_RLO_FLAGS flags)
            {
                fixed (IDXGIDebug*pThis = &this)
                    return lpVtbl->ReportLiveObjects_4(pThis, apiid, flags);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIDebug*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug*, global::System.Guid, win32.Graphics.Dxgi.DXGI_DEBUG_RLO_FLAGS, win32.System.Com.HRESULT>ReportLiveObjects_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}