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
        [Guid("3B16811B-6A43-4EC9-A813-3D930C13B940")]
        internal unsafe struct IWICBitmapFrameDecode
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
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetSize(uint *, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetSize(out uint puiWidth, out uint puiHeight)
            {
                fixed (uint *puiHeightLocal = &puiHeight)
                {
                    fixed (uint *puiWidthLocal = &puiWidth)
                    {
                        win32.System.Com.HRESULT __result = this.GetSize(puiWidthLocal, puiHeightLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetSize(uint *puiWidth, uint *puiHeight)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetSize_4(pThis, puiWidth, puiHeight);
            }

            /// <inheritdoc cref = "GetPixelFormat(global::System.Guid*)"/>
            internal unsafe win32.System.Com.HRESULT GetPixelFormat(out global::System.Guid pPixelFormat)
            {
                fixed (global::System.Guid*pPixelFormatLocal = &pPixelFormat)
                {
                    win32.System.Com.HRESULT __result = this.GetPixelFormat(pPixelFormatLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetPixelFormat(global::System.Guid*pPixelFormat)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetPixelFormat_5(pThis, pPixelFormat);
            }

            /// <inheritdoc cref = "GetResolution(double *, double *)"/>
            internal unsafe win32.System.Com.HRESULT GetResolution(out double pDpiX, out double pDpiY)
            {
                fixed (double *pDpiYLocal = &pDpiY)
                {
                    fixed (double *pDpiXLocal = &pDpiX)
                    {
                        win32.System.Com.HRESULT __result = this.GetResolution(pDpiXLocal, pDpiYLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetResolution(double *pDpiX, double *pDpiY)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetResolution_6(pThis, pDpiX, pDpiY);
            }

            internal unsafe win32.System.Com.HRESULT CopyPalette(win32.Graphics.Imaging.IWICPalette*pIPalette)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->CopyPalette_7(pThis, pIPalette);
            }

            /// <inheritdoc cref = "CopyPixels(win32.Graphics.Imaging.WICRect*, uint, uint, byte *)"/>
            internal unsafe win32.System.Com.HRESULT CopyPixels(in win32.Graphics.Imaging.WICRect prc, uint cbStride, Span<byte> pbBuffer)
            {
                fixed (byte *pbBufferLocal = pbBuffer)
                {
                    fixed (win32.Graphics.Imaging.WICRect*prcLocal = &prc)
                    {
                        win32.System.Com.HRESULT __result = this.CopyPixels(prcLocal, cbStride, (uint)pbBuffer.Length, pbBufferLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT CopyPixels(win32.Graphics.Imaging.WICRect*prc, uint cbStride, uint cbBufferSize, byte *pbBuffer)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->CopyPixels_8(pThis, prc, cbStride, cbBufferSize, pbBuffer);
            }

            /// <summary>Retrieves a metadata query reader for the frame.</summary>
            /// <param name = "ppIMetadataQueryReader">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwicmetadataqueryreader">IWICMetadataQueryReader</a>**</b></para>
            /// <para>When this method returns, contains a pointer to the frame's metadata query reader.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getmetadataqueryreader#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getmetadataqueryreader">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetMetadataQueryReader(win32.Graphics.Imaging.IWICMetadataQueryReader**ppIMetadataQueryReader)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetMetadataQueryReader_9(pThis, ppIMetadataQueryReader);
            }

            /// <inheritdoc cref = "GetColorContexts(uint, win32.Graphics.Imaging.IWICColorContext**, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetColorContexts(uint cCount, win32.Graphics.Imaging.IWICColorContext**ppIColorContexts, out uint pcActualCount)
            {
                fixed (uint *pcActualCountLocal = &pcActualCount)
                {
                    win32.System.Com.HRESULT __result = this.GetColorContexts(cCount, ppIColorContexts, pcActualCountLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the IWICColorContext associated with the image frame.</summary>
            /// <param name = "cCount">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The number of color contexts to retrieve.</para>
            /// <para>This value must be the size of, or smaller than, the size available to <i>ppIColorContexts</i>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppIColorContexts">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwiccolorcontext">IWICColorContext</a>**</b></para>
            /// <para>A pointer that receives a pointer to the <a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwiccolorcontext">IWICColorContext</a> objects.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pcActualCount">
            /// <para>Type: <b>UINT*</b></para>
            /// <para>A pointer that receives the number of color contexts contained in the image frame.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetColorContexts(uint cCount, win32.Graphics.Imaging.IWICColorContext**ppIColorContexts, uint *pcActualCount)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetColorContexts_10(pThis, cCount, ppIColorContexts, pcActualCount);
            }

            /// <summary>Retrieves a small preview of the frame, if supported by the codec.</summary>
            /// <param name = "ppIThumbnail">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwicbitmapsource">IWICBitmapSource</a>**</b></para>
            /// <para>A pointer that receives a pointer to the <a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwicbitmapsource">IWICBitmapSource</a> of the thumbnail.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getthumbnail#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicbitmapframedecode-getthumbnail">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetThumbnail(win32.Graphics.Imaging.IWICBitmapSource**ppIThumbnail)
            {
                fixed (IWICBitmapFrameDecode*pThis = &this)
                    return lpVtbl->GetThumbnail_11(pThis, ppIThumbnail);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint *, uint *, win32.System.Com.HRESULT>GetSize_4;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, global::System.Guid*, win32.System.Com.HRESULT>GetPixelFormat_5;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, double *, double *, win32.System.Com.HRESULT>GetResolution_6;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, win32.Graphics.Imaging.IWICPalette*, win32.System.Com.HRESULT>CopyPalette_7;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, win32.Graphics.Imaging.WICRect*, uint, uint, byte *, win32.System.Com.HRESULT>CopyPixels_8;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, win32.Graphics.Imaging.IWICMetadataQueryReader**, win32.System.Com.HRESULT>GetMetadataQueryReader_9;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, win32.Graphics.Imaging.IWICColorContext**, uint *, win32.System.Com.HRESULT>GetColorContexts_10;
                internal delegate *unmanaged[Stdcall]<IWICBitmapFrameDecode*, win32.Graphics.Imaging.IWICBitmapSource**, win32.System.Com.HRESULT>GetThumbnail_11;
            }

            private Vtbl*lpVtbl;
        }
    }
}