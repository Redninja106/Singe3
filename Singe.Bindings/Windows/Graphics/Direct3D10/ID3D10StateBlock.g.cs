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
        [Guid("0803425A-57F5-4DD6-9465-A87570834A08")]
        internal unsafe struct ID3D10StateBlock
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
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Capture the current value of states that are included in a stateblock.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10stateblock-capture">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT Capture()
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->Capture_4(pThis);
            }

            /// <summary>Apply the state block to the current device state.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10stateblock-apply">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT Apply()
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->Apply_5(pThis);
            }

            /// <summary>Release all references to device objects.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10stateblock-releasealldeviceobjects">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT ReleaseAllDeviceObjects()
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->ReleaseAllDeviceObjects_6(pThis);
            }

            /// <summary>Get the device.</summary>
            /// <param name = "ppDevice">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nn-d3d10-id3d10device">ID3D10Device</a>**</b></para>
            /// <para>Pointer to the ID3D10Device interface that is returned.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10stateblock-getdevice#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10stateblock-getdevice">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDevice(win32.Graphics.Direct3D10.ID3D10Device**ppDevice)
            {
                fixed (ID3D10StateBlock*pThis = &this)
                    return lpVtbl->GetDevice_7(pThis, ppDevice);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, win32.System.Com.HRESULT>Capture_4;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, win32.System.Com.HRESULT>Apply_5;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, win32.System.Com.HRESULT>ReleaseAllDeviceObjects_6;
                internal delegate *unmanaged[Stdcall]<ID3D10StateBlock*, win32.Graphics.Direct3D10.ID3D10Device**, win32.System.Com.HRESULT>GetDevice_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}