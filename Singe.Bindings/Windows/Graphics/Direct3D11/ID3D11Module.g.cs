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

    namespace Graphics.Direct3D11
    {
        [Guid("CAC701EE-80FC-4122-8242-10B39C8CEC34")]
        internal unsafe struct ID3D11Module
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
                fixed (ID3D11Module*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11Module*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11Module*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Initializes an instance of a shader module that is used for resource rebinding.</summary>
            /// <param name = "pNamespace">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>The name of a shader module to initialize. This can be <b>NULL</b> if you don't want to specify a name for the module.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11module-createinstance#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppModuleInstance">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11moduleinstance">ID3D11ModuleInstance</a>**</b></para>
            /// <para>The address of a pointer to an <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11moduleinstance">ID3D11ModuleInstance</a> interface to initialize.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11module-createinstance#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK if successful; otherwise, returns one of the <a href = "/windows/desktop/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11module-createinstance">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT CreateInstance(win32.System.SystemServices.PCSTR pNamespace, win32.Graphics.Direct3D11.ID3D11ModuleInstance**ppModuleInstance)
            {
                fixed (ID3D11Module*pThis = &this)
                    return lpVtbl->CreateInstance_4(pThis, pNamespace, ppModuleInstance);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11Module*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11Module*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11Module*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11Module*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D11.ID3D11ModuleInstance**, win32.System.Com.HRESULT>CreateInstance_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}