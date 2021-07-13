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
        internal unsafe struct ID3DInclude
        {
            /// <inheritdoc cref = "Open(win32.Graphics.Direct3D11.D3D_INCLUDE_TYPE, win32.System.SystemServices.PCSTR, void *, void **, uint *)"/>
            internal unsafe win32.System.Com.HRESULT Open(win32.Graphics.Direct3D11.D3D_INCLUDE_TYPE IncludeType, win32.System.SystemServices.PCSTR pFileName, void *pParentData, ref void *ppData, ref uint pBytes)
            {
                fixed (uint *pBytesLocal = &pBytes)
                {
                    fixed (void **ppDataLocal = &ppData)
                    {
                        win32.System.Com.HRESULT __result = this.Open(IncludeType, pFileName, pParentData, ppDataLocal, pBytesLocal);
                        return __result;
                    }
                }
            }

            /// <summary>A user-implemented method for opening and reading the contents of a shader</summary>
            /// <param name = "IncludeType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_include_type">D3D_INCLUDE_TYPE</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_include_type">D3D_INCLUDE_TYPE</a>-typed value that indicates the location of the #include file.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pFileName">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>Name of the #include file.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pParentData">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCVOID</a></b></para>
            /// <para>Pointer to the container that includes the #include file. The compiler might pass NULL in <i>pParentData</i>. For more information, see the "Searching for Include Files" section in <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/d3d11-graphics-programming-guide-effects-compile">Compile an Effect (Direct3D 11)</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppData">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCVOID</a>*</b></para>
            /// <para>Pointer to the buffer  that contains the include directives. This pointer remains valid until you call<a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/nf-d3dcommon-id3dinclude-close">ID3DInclude::Close</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pBytes">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a>*</b></para>
            /// <para>Pointer to the number of bytes that <b>Open</b> returns in <i>ppData</i>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b> The user-implemented method must return S_OK. If <b>Open</b> fails when it reads the #include file, the application programming interface (API) that caused <b>Open</b> to be called fails. This failure can occur in one of the following situations:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-open">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Open(win32.Graphics.Direct3D11.D3D_INCLUDE_TYPE IncludeType, win32.System.SystemServices.PCSTR pFileName, void *pParentData, void **ppData, uint *pBytes)
            {
                fixed (ID3DInclude*pThis = &this)
                    return lpVtbl->Open_1(pThis, IncludeType, pFileName, pParentData, ppData, pBytes);
            }

            /// <summary>A user-implemented method for closing a shader</summary>
            /// <param name = "pData">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCVOID</a></b></para>
            /// <para>Pointer to the buffer that contains the include directives. This is the pointer that was returned by the corresponding <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/nf-d3dcommon-id3dinclude-open">ID3DInclude::Open</a> call.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-close#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b> The user-implemented <b>Close</b> method should return S_OK. If <b>Close</b> fails when it closes the #include file, the application programming interface (API) that caused <b>Close</b> to be called fails. This failure can occur in one of the following situations:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/nf-d3dcommon-id3dinclude-close">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Close(void *pData)
            {
                fixed (ID3DInclude*pThis = &this)
                    return lpVtbl->Close_2(pThis, pData);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3DInclude*, win32.Graphics.Direct3D11.D3D_INCLUDE_TYPE, win32.System.SystemServices.PCSTR, void *, void **, uint *, win32.System.Com.HRESULT>Open_1;
                internal delegate *unmanaged[Stdcall]<ID3DInclude*, void *, win32.System.Com.HRESULT>Close_2;
            }

            private Vtbl*lpVtbl;
        }
    }
}