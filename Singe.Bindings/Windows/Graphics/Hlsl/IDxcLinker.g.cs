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
        [Guid("F1B5BE2A-62DD-4327-A1C2-42AC1E1E78E6")]
        internal unsafe struct IDxcLinker
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
                fixed (IDxcLinker*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcLinker*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcLinker*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "RegisterLibrary(win32.System.SystemServices.PCWSTR, win32.Graphics.Hlsl.IDxcBlob*)"/>
            internal unsafe win32.System.Com.HRESULT RegisterLibrary(string pLibName, win32.Graphics.Hlsl.IDxcBlob*pLib)
            {
                fixed (char *pLibNameLocal = pLibName)
                {
                    win32.System.Com.HRESULT __result = this.RegisterLibrary(pLibNameLocal, pLib);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT RegisterLibrary(win32.System.SystemServices.PCWSTR pLibName, win32.Graphics.Hlsl.IDxcBlob*pLib)
            {
                fixed (IDxcLinker*pThis = &this)
                    return lpVtbl->RegisterLibrary_4(pThis, pLibName, pLib);
            }

            /// <inheritdoc cref = "Link(win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR*, uint, win32.System.SystemServices.PCWSTR*, uint, win32.Graphics.Hlsl.IDxcOperationResult**)"/>
            internal unsafe win32.System.Com.HRESULT Link(string pEntryName, string pTargetProfile, ReadOnlySpan<win32.System.SystemServices.PCWSTR> pLibNames, ReadOnlySpan<win32.System.SystemServices.PCWSTR> pArguments, win32.Graphics.Hlsl.IDxcOperationResult**ppResult)
            {
                fixed (win32.System.SystemServices.PCWSTR*pArgumentsLocal = pArguments)
                {
                    fixed (win32.System.SystemServices.PCWSTR*pLibNamesLocal = pLibNames)
                    {
                        fixed (char *pTargetProfileLocal = pTargetProfile)
                        {
                            fixed (char *pEntryNameLocal = pEntryName)
                            {
                                win32.System.Com.HRESULT __result = this.Link(pEntryNameLocal, pTargetProfileLocal, pLibNamesLocal, (uint)pLibNames.Length, pArgumentsLocal, (uint)pArguments.Length, ppResult);
                                return __result;
                            }
                        }
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT Link(win32.System.SystemServices.PCWSTR pEntryName, win32.System.SystemServices.PCWSTR pTargetProfile, win32.System.SystemServices.PCWSTR*pLibNames, uint libCount, win32.System.SystemServices.PCWSTR*pArguments, uint argCount, win32.Graphics.Hlsl.IDxcOperationResult**ppResult)
            {
                fixed (IDxcLinker*pThis = &this)
                    return lpVtbl->Link_5(pThis, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcLinker*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcLinker*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcLinker*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcLinker*, win32.System.SystemServices.PCWSTR, win32.Graphics.Hlsl.IDxcBlob*, win32.System.Com.HRESULT>RegisterLibrary_4;
                internal delegate *unmanaged[Stdcall]<IDxcLinker*, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR*, uint, win32.System.SystemServices.PCWSTR*, uint, win32.Graphics.Hlsl.IDxcOperationResult**, win32.System.Com.HRESULT>Link_5;
            }

            private Vtbl*lpVtbl;
        }
    }
}