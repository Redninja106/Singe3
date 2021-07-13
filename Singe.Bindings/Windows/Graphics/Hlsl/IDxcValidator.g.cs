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
        [Guid("A6E82BD2-1FD7-4826-9811-2857E797F49A")]
        internal unsafe struct IDxcValidator
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
                fixed (IDxcValidator*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcValidator*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcValidator*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe win32.System.Com.HRESULT Validate(win32.Graphics.Hlsl.IDxcBlob*pShader, uint Flags, win32.Graphics.Hlsl.IDxcOperationResult**ppResult)
            {
                fixed (IDxcValidator*pThis = &this)
                    return lpVtbl->Validate_4(pThis, pShader, Flags, ppResult);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcValidator*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcValidator*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcValidator*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcValidator*, win32.Graphics.Hlsl.IDxcBlob*, uint, win32.Graphics.Hlsl.IDxcOperationResult**, win32.System.Com.HRESULT>Validate_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}