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

    namespace Graphics.DirectWrite
    {
        [Guid("739D886A-CEF5-47DC-8769-1A8B41BEBBB0")]
        internal unsafe struct IDWriteFontFile
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
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetReferenceKey(void **, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetReferenceKey(out void *fontFileReferenceKey, out uint fontFileReferenceKeySize)
            {
                fixed (uint *fontFileReferenceKeySizeLocal = &fontFileReferenceKeySize)
                {
                    fixed (void **fontFileReferenceKeyLocal = &fontFileReferenceKey)
                    {
                        win32.System.Com.HRESULT __result = this.GetReferenceKey(fontFileReferenceKeyLocal, fontFileReferenceKeySizeLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Obtains the pointer to the reference key of a font file. The returned pointer is valid until the font file object is released.</summary>
            /// <param name = "fontFileReferenceKey">
            /// <para>Type: <b>const void**</b></para>
            /// <para>When this method returns, contains an address of  a pointer to the font file reference key. Note that the pointer value is only valid until the font file object it is obtained from is released. This parameter is passed uninitialized.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-getreferencekey#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "fontFileReferenceKeySize">
            /// <para>Type: <b>UINT32*</b></para>
            /// <para>When this method returns, contains the size of the font file reference key in bytes. This parameter is passed uninitialized.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-getreferencekey#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-getreferencekey">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetReferenceKey(void **fontFileReferenceKey, uint *fontFileReferenceKeySize)
            {
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->GetReferenceKey_4(pThis, fontFileReferenceKey, fontFileReferenceKeySize);
            }

            /// <summary>Obtains the file loader associated with a font file object.</summary>
            /// <param name = "fontFileLoader">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfileloader">IDWriteFontFileLoader</a>**</b></para>
            /// <para>When this method returns, contains the address of  a pointer to the font file loader associated with the font file object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-getloader#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-getloader">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetLoader(win32.Graphics.DirectWrite.IDWriteFontFileLoader**fontFileLoader)
            {
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->GetLoader_5(pThis, fontFileLoader);
            }

            /// <inheritdoc cref = "Analyze(win32.System.SystemServices.BOOL*, win32.Graphics.DirectWrite.DWRITE_FONT_FILE_TYPE*, win32.Graphics.DirectWrite.DWRITE_FONT_FACE_TYPE*, uint *)"/>
            internal unsafe win32.System.Com.HRESULT Analyze(out win32.System.SystemServices.BOOL isSupportedFontType, out win32.Graphics.DirectWrite.DWRITE_FONT_FILE_TYPE fontFileType, win32.Graphics.DirectWrite.DWRITE_FONT_FACE_TYPE*fontFaceType, out uint numberOfFaces)
            {
                fixed (uint *numberOfFacesLocal = &numberOfFaces)
                {
                    fixed (win32.Graphics.DirectWrite.DWRITE_FONT_FILE_TYPE*fontFileTypeLocal = &fontFileType)
                    {
                        fixed (win32.System.SystemServices.BOOL*isSupportedFontTypeLocal = &isSupportedFontType)
                        {
                            win32.System.Com.HRESULT __result = this.Analyze(isSupportedFontTypeLocal, fontFileTypeLocal, fontFaceType, numberOfFacesLocal);
                            return __result;
                        }
                    }
                }
            }

            /// <summary>Analyzes a file and returns whether it represents a font, and whether the font type is supported by the font system.</summary>
            /// <param name = "isSupportedFontType">
            /// <para>Type: <b>BOOL*</b></para>
            /// <para><b>TRUE</b> if the font type is supported by the font system; otherwise, <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-analyze#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "fontFileType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_font_file_type">DWRITE_FONT_FILE_TYPE</a>*</b></para>
            /// <para>When this method returns, contains a value that indicates the type of the font file. Note that even if <i> isSupportedFontType</i> is <b>FALSE</b>, the <i>fontFileType</i> value may be different from <b>DWRITE_FONT_FILE_TYPE_UNKNOWN</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-analyze#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "fontFaceType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_font_face_type">DWRITE_FONT_FACE_TYPE</a>*</b></para>
            /// <para>When this method returns, contains a value that indicates the type of the font face. If <i>fontFileType</i> is not equal to <b>DWRITE_FONT_FILE_TYPE_UNKNOWN</b>, then that can be constructed from the font file.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-analyze#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "numberOfFaces">
            /// <para>Type: <b>UINT32*</b></para>
            /// <para>When this method returns, contains the number of font faces contained in the font file.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-analyze#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwritefontfile-analyze">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Analyze(win32.System.SystemServices.BOOL*isSupportedFontType, win32.Graphics.DirectWrite.DWRITE_FONT_FILE_TYPE*fontFileType, [Optional] win32.Graphics.DirectWrite.DWRITE_FONT_FACE_TYPE*fontFaceType, uint *numberOfFaces)
            {
                fixed (IDWriteFontFile*pThis = &this)
                    return lpVtbl->Analyze_6(pThis, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, void **, uint *, win32.System.Com.HRESULT>GetReferenceKey_4;
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, win32.Graphics.DirectWrite.IDWriteFontFileLoader**, win32.System.Com.HRESULT>GetLoader_5;
                internal delegate *unmanaged[Stdcall]<IDWriteFontFile*, win32.System.SystemServices.BOOL*, win32.Graphics.DirectWrite.DWRITE_FONT_FILE_TYPE*, win32.Graphics.DirectWrite.DWRITE_FONT_FACE_TYPE*, uint *, win32.System.Com.HRESULT>Analyze_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}