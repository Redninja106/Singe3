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

    namespace Graphics.Direct2D
    {
        [Guid("A16907D7-BC02-4801-99E8-8CF7F485F774")]
        internal unsafe struct ID2D1GeometryRealization
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
                fixed (ID2D1GeometryRealization*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1GeometryRealization*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1GeometryRealization*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1GeometryRealization*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1GeometryRealization*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1GeometryRealization*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1GeometryRealization*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1GeometryRealization*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}