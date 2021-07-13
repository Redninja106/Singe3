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
        [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
        internal unsafe struct IDXGIDebug1
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
                fixed (IDXGIDebug1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDXGIDebug1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDXGIDebug1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal win32.System.Com.HRESULT ReportLiveObjects(global::System.Guid apiid, win32.Graphics.Dxgi.DXGI_DEBUG_RLO_FLAGS flags)
            {
                fixed (IDXGIDebug1*pThis = &this)
                    return lpVtbl->ReportLiveObjects_4(pThis, apiid, flags);
            }

            /// <summary>Starts tracking leaks for the current thread.</summary>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgidebug/nf-dxgidebug-idxgidebug1-enableleaktrackingforthread">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void EnableLeakTrackingForThread()
            {
                fixed (IDXGIDebug1*pThis = &this)
                    lpVtbl->EnableLeakTrackingForThread_5(pThis);
            }

            /// <summary>Stops tracking leaks for the current thread.</summary>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgidebug/nf-dxgidebug-idxgidebug1-disableleaktrackingforthread">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void DisableLeakTrackingForThread()
            {
                fixed (IDXGIDebug1*pThis = &this)
                    lpVtbl->DisableLeakTrackingForThread_6(pThis);
            }

            /// <summary>Gets a value indicating whether leak tracking is turned on for the current thread.</summary>
            /// <returns><b>TRUE</b> if leak tracking is turned on for the current thread; otherwise, <b>FALSE</b>.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgidebug/nf-dxgidebug-idxgidebug1-isleaktrackingenabledforthread">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.SystemServices.BOOL IsLeakTrackingEnabledForThread()
            {
                fixed (IDXGIDebug1*pThis = &this)
                    return lpVtbl->IsLeakTrackingEnabledForThread_7(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, global::System.Guid, win32.Graphics.Dxgi.DXGI_DEBUG_RLO_FLAGS, win32.System.Com.HRESULT>ReportLiveObjects_4;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, void>EnableLeakTrackingForThread_5;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, void>DisableLeakTrackingForThread_6;
                internal delegate *unmanaged[Stdcall]<IDXGIDebug1*, win32.System.SystemServices.BOOL>IsLeakTrackingEnabledForThread_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}