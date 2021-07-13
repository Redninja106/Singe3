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

    namespace Graphics.Imaging
    {
        [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
        internal unsafe struct IWICColorContext
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
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "InitializeFromFilename(win32.System.SystemServices.PCWSTR)"/>
            internal unsafe win32.System.Com.HRESULT InitializeFromFilename(string wzFilename)
            {
                fixed (char *wzFilenameLocal = wzFilename)
                {
                    win32.System.Com.HRESULT __result = this.InitializeFromFilename(wzFilenameLocal);
                    return __result;
                }
            }

            /// <summary>Initializes the color context from the given file.</summary>
            /// <param name = "wzFilename">
            /// <para>Type: <b>LPCWSTR</b></para>
            /// <para>The name of the file.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefromfilename#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefromfilename">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT InitializeFromFilename(win32.System.SystemServices.PCWSTR wzFilename)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->InitializeFromFilename_4(pThis, wzFilename);
            }

            /// <inheritdoc cref = "InitializeFromMemory(byte *, uint)"/>
            internal unsafe win32.System.Com.HRESULT InitializeFromMemory(ReadOnlySpan<byte> pbBuffer)
            {
                fixed (byte *pbBufferLocal = pbBuffer)
                {
                    win32.System.Com.HRESULT __result = this.InitializeFromMemory(pbBufferLocal, (uint)pbBuffer.Length);
                    return __result;
                }
            }

            /// <summary>Initializes the color context from a memory block.</summary>
            /// <param name = "pbBuffer">
            /// <para>Type: <b>const BYTE*</b></para>
            /// <para>The buffer used to initialize the <a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwiccolorcontext">IWICColorContext</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefrommemory#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "cbBufferSize">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The size of the <i>pbBuffer</i> buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefrommemory#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefrommemory">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT InitializeFromMemory(byte *pbBuffer, uint cbBufferSize)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->InitializeFromMemory_5(pThis, pbBuffer, cbBufferSize);
            }

            /// <summary>Initializes the color context using an Exchangeable Image File (EXIF) color space.</summary>
            /// <param name = "value">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The value of the EXIF color space.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefromexifcolorspace#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-initializefromexifcolorspace">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT InitializeFromExifColorSpace(uint value)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->InitializeFromExifColorSpace_6(pThis, value);
            }

            /// <inheritdoc cref = "GetType(win32.Graphics.Imaging.WICColorContextType*)"/>
            internal unsafe win32.System.Com.HRESULT GetType(out win32.Graphics.Imaging.WICColorContextType pType)
            {
                fixed (win32.Graphics.Imaging.WICColorContextType*pTypeLocal = &pType)
                {
                    win32.System.Com.HRESULT __result = this.GetType(pTypeLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the color context type.</summary>
            /// <param name = "pType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/ne-wincodec-wiccolorcontexttype">WICColorContextType</a>*</b></para>
            /// <para>A pointer that receives the <a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/ne-wincodec-wiccolorcontexttype">WICColorContextType</a> of the color context.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-gettype#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-gettype">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetType(win32.Graphics.Imaging.WICColorContextType*pType)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->GetType_7(pThis, pType);
            }

            /// <inheritdoc cref = "GetProfileBytes(uint, byte *, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetProfileBytes(Span<byte> pbBuffer, out uint pcbActual)
            {
                fixed (uint *pcbActualLocal = &pcbActual)
                {
                    fixed (byte *pbBufferLocal = pbBuffer)
                    {
                        win32.System.Com.HRESULT __result = this.GetProfileBytes((uint)pbBuffer.Length, pbBufferLocal, pcbActualLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Retrieves the color context profile.</summary>
            /// <param name = "cbBuffer">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The size of the <i>pbBuffer</i> buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getprofilebytes#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pbBuffer">
            /// <para>Type: <b>BYTE*</b></para>
            /// <para>A pointer that receives the color context profile.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getprofilebytes#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pcbActual">
            /// <para>Type: <b>UINT*</b></para>
            /// <para>A pointer that receives the actual buffer size needed to retrieve the entire color context profile.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getprofilebytes#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getprofilebytes">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetProfileBytes(uint cbBuffer, byte *pbBuffer, uint *pcbActual)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->GetProfileBytes_8(pThis, cbBuffer, pbBuffer, pcbActual);
            }

            /// <inheritdoc cref = "GetExifColorSpace(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetExifColorSpace(out uint pValue)
            {
                fixed (uint *pValueLocal = &pValue)
                {
                    win32.System.Com.HRESULT __result = this.GetExifColorSpace(pValueLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the Exchangeable Image File (EXIF) color space color context.</summary>
            /// <param name = "pValue">
            /// <para>Type: <b>UINT*</b></para>
            /// <para>A pointer that receives the EXIF color space color context.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getexifcolorspace#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwiccolorcontext-getexifcolorspace">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetExifColorSpace(uint *pValue)
            {
                fixed (IWICColorContext*pThis = &this)
                    return lpVtbl->GetExifColorSpace_9(pThis, pValue);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, win32.System.SystemServices.PCWSTR, win32.System.Com.HRESULT>InitializeFromFilename_4;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, byte *, uint, win32.System.Com.HRESULT>InitializeFromMemory_5;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, uint, win32.System.Com.HRESULT>InitializeFromExifColorSpace_6;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, win32.Graphics.Imaging.WICColorContextType*, win32.System.Com.HRESULT>GetType_7;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, uint, byte *, uint *, win32.System.Com.HRESULT>GetProfileBytes_8;
                internal delegate *unmanaged[Stdcall]<IWICColorContext*, uint *, win32.System.Com.HRESULT>GetExifColorSpace_9;
            }

            private Vtbl*lpVtbl;
        }
    }
}