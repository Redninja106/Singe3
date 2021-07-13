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
        [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
        internal unsafe struct IWICPalette
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
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Initializes the palette to one of the pre-defined palettes specified by WICBitmapPaletteType and optionally adds a transparent color.</summary>
            /// <param name = "ePaletteType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/ne-wincodec-wicbitmappalettetype">WICBitmapPaletteType</a></b></para>
            /// <para>The desired pre-defined palette type.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializepredefined#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "fAddTransparentColor">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>The optional transparent color to add to the palette. If no transparent color is needed, use 0. When initializing to a grayscale or black and white palette, set this parameter to <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializepredefined#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializepredefined">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT InitializePredefined(win32.Graphics.Imaging.WICBitmapPaletteType ePaletteType, win32.System.SystemServices.BOOL fAddTransparentColor)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->InitializePredefined_4(pThis, ePaletteType, fAddTransparentColor);
            }

            /// <inheritdoc cref = "InitializeCustom(uint *, uint)"/>
            internal unsafe win32.System.Com.HRESULT InitializeCustom(Span<uint> pColors)
            {
                fixed (uint *pColorsLocal = pColors)
                {
                    win32.System.Com.HRESULT __result = this.InitializeCustom(pColorsLocal, (uint)pColors.Length);
                    return __result;
                }
            }

            /// <summary>Initializes a palette to the custom color entries provided.</summary>
            /// <param name = "pColors">
            /// <para>Type: <b>WICColor*</b></para>
            /// <para>Pointer to the color array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializecustom#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "cCount">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The number of colors in <i>pColors</i>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializecustom#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializecustom">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT InitializeCustom(uint *pColors, uint cCount)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->InitializeCustom_5(pThis, pColors, cCount);
            }

            /// <summary>Initializes a palette using a computed optimized values based on the reference bitmap.</summary>
            /// <param name = "pISurface">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwicbitmapsource">IWICBitmapSource</a>*</b></para>
            /// <para>Pointer to the source bitmap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrombitmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "cCount">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The number of colors to initialize the palette with.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrombitmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "fAddTransparentColor">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>A value to indicate whether to add a transparent color.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrombitmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrombitmap">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT InitializeFromBitmap(win32.Graphics.Imaging.IWICBitmapSource*pISurface, uint cCount, win32.System.SystemServices.BOOL fAddTransparentColor)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->InitializeFromBitmap_6(pThis, pISurface, cCount, fAddTransparentColor);
            }

            /// <summary>Initialize the palette based on a given palette.</summary>
            /// <param name = "pIPalette">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/nn-wincodec-iwicpalette">IWICPalette</a>*</b></para>
            /// <para>Pointer to the source palette.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrompalette#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-initializefrompalette">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT InitializeFromPalette(win32.Graphics.Imaging.IWICPalette*pIPalette)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->InitializeFromPalette_7(pThis, pIPalette);
            }

            /// <inheritdoc cref = "GetType(win32.Graphics.Imaging.WICBitmapPaletteType*)"/>
            internal unsafe win32.System.Com.HRESULT GetType(out win32.Graphics.Imaging.WICBitmapPaletteType pePaletteType)
            {
                fixed (win32.Graphics.Imaging.WICBitmapPaletteType*pePaletteTypeLocal = &pePaletteType)
                {
                    win32.System.Com.HRESULT __result = this.GetType(pePaletteTypeLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the WICBitmapPaletteType that describes the palette.</summary>
            /// <param name = "pePaletteType">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/wincodec/ne-wincodec-wicbitmappalettetype">WICBitmapPaletteType</a>*</b></para>
            /// <para>Pointer that receives the palette type of the bimtap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-gettype#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-gettype">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetType(win32.Graphics.Imaging.WICBitmapPaletteType*pePaletteType)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->GetType_8(pThis, pePaletteType);
            }

            /// <inheritdoc cref = "GetColorCount(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetColorCount(out uint pcCount)
            {
                fixed (uint *pcCountLocal = &pcCount)
                {
                    win32.System.Com.HRESULT __result = this.GetColorCount(pcCountLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves the number of colors in the color table.</summary>
            /// <param name = "pcCount">
            /// <para>Type: <b>UINT*</b></para>
            /// <para>Pointer that receives the number of colors in the color table.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolorcount#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolorcount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetColorCount(uint *pcCount)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->GetColorCount_9(pThis, pcCount);
            }

            /// <inheritdoc cref = "GetColors(uint, uint *, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetColors(Span<uint> pColors, out uint pcActualColors)
            {
                fixed (uint *pcActualColorsLocal = &pcActualColors)
                {
                    fixed (uint *pColorsLocal = pColors)
                    {
                        win32.System.Com.HRESULT __result = this.GetColors((uint)pColors.Length, pColorsLocal, pcActualColorsLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Fills out the supplied color array with the colors from the internal color table. The color array should be sized according to the return results from GetColorCount.</summary>
            /// <param name = "cCount">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The size of the <i>pColors</i> array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolors#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pColors">
            /// <para>Type: <b>WICColor*</b></para>
            /// <para>Pointer that receives the colors of the palette.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolors#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pcActualColors">
            /// <para>Type: <b>UINT*</b></para>
            /// <para>The actual size needed to obtain the palette colors.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolors#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-getcolors">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetColors(uint cCount, uint *pColors, uint *pcActualColors)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->GetColors_10(pThis, cCount, pColors, pcActualColors);
            }

            /// <inheritdoc cref = "IsBlackWhite(win32.System.SystemServices.BOOL*)"/>
            internal unsafe win32.System.Com.HRESULT IsBlackWhite(out win32.System.SystemServices.BOOL pfIsBlackWhite)
            {
                fixed (win32.System.SystemServices.BOOL*pfIsBlackWhiteLocal = &pfIsBlackWhite)
                {
                    win32.System.Com.HRESULT __result = this.IsBlackWhite(pfIsBlackWhiteLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves a value that describes whether the palette is black and white.</summary>
            /// <param name = "pfIsBlackWhite">
            /// <para>Type: <b>BOOL*</b></para>
            /// <para>A pointer to a variable  that receives a boolean value that indicates whether the palette is black and white. <b>TRUE</b> indicates that the palette is black and white; otherwise, <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-isblackwhite#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-isblackwhite">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT IsBlackWhite(win32.System.SystemServices.BOOL*pfIsBlackWhite)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->IsBlackWhite_11(pThis, pfIsBlackWhite);
            }

            /// <inheritdoc cref = "IsGrayscale(win32.System.SystemServices.BOOL*)"/>
            internal unsafe win32.System.Com.HRESULT IsGrayscale(out win32.System.SystemServices.BOOL pfIsGrayscale)
            {
                fixed (win32.System.SystemServices.BOOL*pfIsGrayscaleLocal = &pfIsGrayscale)
                {
                    win32.System.Com.HRESULT __result = this.IsGrayscale(pfIsGrayscaleLocal);
                    return __result;
                }
            }

            /// <summary>Retrieves a value that describes whether a palette is grayscale.</summary>
            /// <param name = "pfIsGrayscale">
            /// <para>Type: <b>BOOL*</b></para>
            /// <para>A pointer to a variable that receives a boolean value that indicates whether the palette is grayscale. <b>TRUE</b> indicates that the palette is grayscale; otherwise <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-isgrayscale#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-isgrayscale">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT IsGrayscale(win32.System.SystemServices.BOOL*pfIsGrayscale)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->IsGrayscale_12(pThis, pfIsGrayscale);
            }

            /// <inheritdoc cref = "HasAlpha(win32.System.SystemServices.BOOL*)"/>
            internal unsafe win32.System.Com.HRESULT HasAlpha(out win32.System.SystemServices.BOOL pfHasAlpha)
            {
                fixed (win32.System.SystemServices.BOOL*pfHasAlphaLocal = &pfHasAlpha)
                {
                    win32.System.Com.HRESULT __result = this.HasAlpha(pfHasAlphaLocal);
                    return __result;
                }
            }

            /// <summary>Indicates whether the palette contains an entry that is non-opaque (that is, an entry with an alpha that is less than 1).</summary>
            /// <param name = "pfHasAlpha">
            /// <para>Type: <b>BOOL*</b></para>
            /// <para>Pointer that receives <c>TRUE</code> if the palette contains a transparent color; otherwise, <code>FALSE</c>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-hasalpha#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/nf-wincodec-iwicpalette-hasalpha">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT HasAlpha(win32.System.SystemServices.BOOL*pfHasAlpha)
            {
                fixed (IWICPalette*pThis = &this)
                    return lpVtbl->HasAlpha_13(pThis, pfHasAlpha);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IWICPalette*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.Graphics.Imaging.WICBitmapPaletteType, win32.System.SystemServices.BOOL, win32.System.Com.HRESULT>InitializePredefined_4;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, uint *, uint, win32.System.Com.HRESULT>InitializeCustom_5;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.Graphics.Imaging.IWICBitmapSource*, uint, win32.System.SystemServices.BOOL, win32.System.Com.HRESULT>InitializeFromBitmap_6;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.Graphics.Imaging.IWICPalette*, win32.System.Com.HRESULT>InitializeFromPalette_7;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.Graphics.Imaging.WICBitmapPaletteType*, win32.System.Com.HRESULT>GetType_8;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, uint *, win32.System.Com.HRESULT>GetColorCount_9;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, uint, uint *, uint *, win32.System.Com.HRESULT>GetColors_10;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.System.SystemServices.BOOL*, win32.System.Com.HRESULT>IsBlackWhite_11;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.System.SystemServices.BOOL*, win32.System.Com.HRESULT>IsGrayscale_12;
                internal delegate *unmanaged[Stdcall]<IWICPalette*, win32.System.SystemServices.BOOL*, win32.System.Com.HRESULT>HasAlpha_13;
            }

            private Vtbl*lpVtbl;
        }
    }
}