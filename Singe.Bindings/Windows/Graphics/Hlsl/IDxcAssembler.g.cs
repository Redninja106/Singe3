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
        [Guid("091F7A26-1C1F-4948-904B-E6E3A8A771D5")]
        internal unsafe struct IDxcAssembler
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
                fixed (IDxcAssembler*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcAssembler*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcAssembler*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe win32.System.Com.HRESULT AssembleToContainer(win32.Graphics.Hlsl.IDxcBlob*pShader, win32.Graphics.Hlsl.IDxcOperationResult**ppResult)
            {
                fixed (IDxcAssembler*pThis = &this)
                    return lpVtbl->AssembleToContainer_4(pThis, pShader, ppResult);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcAssembler*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcAssembler*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcAssembler*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcAssembler*, win32.Graphics.Hlsl.IDxcBlob*, win32.Graphics.Hlsl.IDxcOperationResult**, win32.System.Com.HRESULT>AssembleToContainer_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}