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
        [Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
        internal unsafe struct ID2D1SpriteBatch
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
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            /// <inheritdoc cref = "AddSprites(uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, uint, uint, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT AddSprites(uint spriteCount, in win32.Graphics.Direct2D.D2D_RECT_F destinationRectangles, win32.Graphics.Direct2D.D2D_RECT_U? sourceRectangles, win32.Graphics.Direct2D.D2D1_COLOR_F? colors, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F? transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
            {
                fixed (win32.Graphics.Direct2D.D2D_RECT_F*destinationRectanglesLocal = &destinationRectangles)
                {
                    win32.Graphics.Direct2D.D2D_RECT_U sourceRectanglesLocal = sourceRectangles.HasValue ? sourceRectangles.Value : default(win32.Graphics.Direct2D.D2D_RECT_U);
                    win32.Graphics.Direct2D.D2D1_COLOR_F colorsLocal = colors.HasValue ? colors.Value : default(win32.Graphics.Direct2D.D2D1_COLOR_F);
                    win32.Graphics.Direct2D.D2D_MATRIX_3X2_F transformsLocal = transforms.HasValue ? transforms.Value : default(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F);
                    win32.System.Com.HRESULT __result = this.AddSprites(spriteCount, destinationRectanglesLocal, sourceRectangles.HasValue ? &sourceRectanglesLocal : null, colors.HasValue ? &colorsLocal : null, transforms.HasValue ? &transformsLocal : null, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                    return __result;
                }
            }

            /// <summary>Adds the given sprites to the end of this sprite batch.</summary>
            /// <param name = "spriteCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of sprites to be added. This determines how many strides into each given array Direct2D will read.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "destinationRectangles">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-f">D2D1_RECT_F</a>*</b></para>
            /// <para>A pointer to an array containing the destination rectangles specifying where to draw the sprites on the destination device context.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "sourceRectangles">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-u">D2D1_RECT_U</a>*</b></para>
            /// <para>A pointer to an array containing the source rectangles specifying the regions of the source bitmap to draw as sprites. Direct2D will use the entire source bitmap for sprites that are assigned a null value or the InfiniteRectU. If this parameter is omitted entirely or set to a null value, then Direct2D will use the entire source bitmap for all the added sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "colors">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-color-f">D2D1_COLOR_F</a>*</b> A pointer to an array containing the colors to apply to each sprite. The output color is the result of component-wise multiplication of the source bitmap color and the provided color. The output color is not clamped.</para>
            /// <para>Direct2D will not change the color of sprites that are assigned a null value. If this parameter is omitted entirely or set to a null value, then Direct2D will not change the color of any of the added sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "transforms">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a>*</b> A pointer to an array containing the transforms to apply to each sprite’s destination rectangle.</para>
            /// <para>Direct2D will not transform the destination rectangle of any sprites that are assigned a null value. If this parameter is omitted entirely or set to a null value, then Direct2D will not transform the destination rectangle of any of the added sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "destinationRectanglesStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each rectangle in the destinationRectangles array. If you provide a stride of 0, then the same destination rectangle will be used for each added sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "sourceRectanglesStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each rectangle in the sourceRectangles array (if that array is given). If you provide a stride of 0, then the same source rectangle will be used for each added sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "colorsStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each color in the colors array (if that array is given). If you provide a stride of 0, then the same color will be used for each added sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "transformsStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each transform in the transforms array (if that array is given). If you provide a stride of 0, then the same transform will be used for each added sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-addsprites">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT AddSprites(uint spriteCount, win32.Graphics.Direct2D.D2D_RECT_F*destinationRectangles, [Optional] win32.Graphics.Direct2D.D2D_RECT_U*sourceRectangles, [Optional] win32.Graphics.Direct2D.D2D1_COLOR_F*colors, [Optional] win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->AddSprites_5(pThis, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }

            /// <inheritdoc cref = "SetSprites(uint, uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, uint, uint, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT SetSprites(uint startIndex, uint spriteCount, win32.Graphics.Direct2D.D2D_RECT_F? destinationRectangles, win32.Graphics.Direct2D.D2D_RECT_U? sourceRectangles, win32.Graphics.Direct2D.D2D1_COLOR_F? colors, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F? transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
            {
                win32.Graphics.Direct2D.D2D_RECT_F destinationRectanglesLocal = destinationRectangles.HasValue ? destinationRectangles.Value : default(win32.Graphics.Direct2D.D2D_RECT_F);
                win32.Graphics.Direct2D.D2D_RECT_U sourceRectanglesLocal = sourceRectangles.HasValue ? sourceRectangles.Value : default(win32.Graphics.Direct2D.D2D_RECT_U);
                win32.Graphics.Direct2D.D2D1_COLOR_F colorsLocal = colors.HasValue ? colors.Value : default(win32.Graphics.Direct2D.D2D1_COLOR_F);
                win32.Graphics.Direct2D.D2D_MATRIX_3X2_F transformsLocal = transforms.HasValue ? transforms.Value : default(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F);
                win32.System.Com.HRESULT __result = this.SetSprites(startIndex, spriteCount, destinationRectangles.HasValue ? &destinationRectanglesLocal : null, sourceRectangles.HasValue ? &sourceRectanglesLocal : null, colors.HasValue ? &colorsLocal : null, transforms.HasValue ? &transformsLocal : null, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                return __result;
            }

            /// <summary>Updates the properties of the specified sprites in this sprite batch.</summary>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index of the first sprite in this sprite batch to update.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "spriteCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of sprites to update with new properties. This determines how many strides into each given array Direct2D will read.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "destinationRectangles">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-f">D2D1_RECT_F</a>*</b></para>
            /// <para>A pointer to an array containing the destination rectangles specifying where to draw the sprites on the destination device context.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "sourceRectangles">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-u">D2D1_RECT_U</a>*</b> A pointer to an array containing the source rectangles specifying the regions of the source bitmap to draw as sprites.</para>
            /// <para>Direct2D will use the entire source bitmap for sprites that are assigned a null value or the InfiniteRectU. If this parameter is omitted entirely or set to a null value, then Direct2D will use the entire source bitmap for all the updated sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "colors">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-color-f">D2D1_COLOR_F</a>*</b> A pointer to an array containing the colors to apply to each sprite. The output color is the result of component-wise multiplication of the source bitmap color and the provided color. The output color is not clamped.</para>
            /// <para>Direct2D will not change the color of sprites that are assigned a null value. If this parameter is omitted entirely or set to a null value, then Direct2D will not change the color of any of the updated sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "transforms">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a>*</b> A pointer to an array containing the transforms to apply to each sprite’s destination rectangle.</para>
            /// <para>Direct2D will not transform the destination rectangle of any sprites that are assigned a null value. If this parameter is omitted entirely or set to a null value, then Direct2D will not transform the destination rectangle of any of the updated sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "destinationRectanglesStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each rectangle in the destinationRectangles array. If you provide a stride of 0, then the same destination rectangle will be used for each updated sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "sourceRectanglesStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each rectangle in the sourceRectangles array (if that array is given). If you provide a stride of 0, then the same source rectangle will be used for each updated sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "colorsStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each color in the colors array (if that array is given). If you provide a stride of 0, then the same color will be used for each updated sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "transformsStride">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies the distance, in bytes, between each transform in the transforms array (if that array is given). If you provide a stride of 0, then the same transform will be used for each updated sprite.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns S_OK on success. Returns E_INVALIDARG if an invalid value was passed to the method. In this case, no sprites are modified by this call to SetSprites.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-setsprites">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetSprites(uint startIndex, uint spriteCount, [Optional] win32.Graphics.Direct2D.D2D_RECT_F*destinationRectangles, [Optional] win32.Graphics.Direct2D.D2D_RECT_U*sourceRectangles, [Optional] win32.Graphics.Direct2D.D2D1_COLOR_F*colors, [Optional] win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->SetSprites_6(pThis, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }

            /// <inheritdoc cref = "GetSprites(uint, uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*)"/>
            internal unsafe win32.System.Com.HRESULT GetSprites(uint startIndex, Span<win32.Graphics.Direct2D.D2D_RECT_F> destinationRectangles, Span<win32.Graphics.Direct2D.D2D_RECT_U> sourceRectangles, Span<win32.Graphics.Direct2D.D2D1_COLOR_F> colors, Span<win32.Graphics.Direct2D.D2D_MATRIX_3X2_F> transforms)
            {
                fixed (win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transformsLocal = transforms)
                {
                    fixed (win32.Graphics.Direct2D.D2D1_COLOR_F*colorsLocal = colors)
                    {
                        fixed (win32.Graphics.Direct2D.D2D_RECT_U*sourceRectanglesLocal = sourceRectangles)
                        {
                            fixed (win32.Graphics.Direct2D.D2D_RECT_F*destinationRectanglesLocal = destinationRectangles)
                            {
                                if (destinationRectangles.Length != sourceRectangles.Length)
                                    throw new ArgumentException();
                                if (destinationRectangles.Length != colors.Length)
                                    throw new ArgumentException();
                                if (destinationRectangles.Length != transforms.Length)
                                    throw new ArgumentException();
                                win32.System.Com.HRESULT __result = this.GetSprites(startIndex, (uint)transforms.Length, destinationRectanglesLocal, sourceRectanglesLocal, colorsLocal, transformsLocal);
                                return __result;
                            }
                        }
                    }
                }
            }

            /// <summary>Retrieves the specified subset of sprites from this sprite batch. For the best performance, use nullptr for properties that you do not need to retrieve.</summary>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index of the first sprite in this sprite batch to retrieve.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "spriteCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of sprites to retrieve.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "destinationRectangles">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-f">D2D1_RECT_F</a>*</b></para>
            /// <para>When this method returns, contains a pointer to an array containing the destination rectangles for the retrieved sprites.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "sourceRectangles">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-u">D2D1_RECT_U</a>*</b> When this method returns, contains a pointer to an array containing the source rectangles for the retrieved sprites.</para>
            /// <para>The InfiniteRectU is returned for any sprites that were not assigned a source rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "colors">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-color-f">D2D1_COLOR_F</a>*</b> When this method returns, contains a pointer to an array containing the colors to be applied to the retrieved sprites.</para>
            /// <para>The color {1.0f, 1.0f, 1.0f, 1.0f} is returned for any sprites that were not assigned a color.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "transforms">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-matrix-3x2-f">D2D1_MATRIX_3X2_F</a>*</b> When this method returns, contains a pointer to an array containing the transforms to be applied to the retrieved sprites.</para>
            /// <para>The identity matrix is returned for any sprites that were not assigned a transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getsprites">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetSprites(uint startIndex, uint spriteCount, [Optional] win32.Graphics.Direct2D.D2D_RECT_F*destinationRectangles, [Optional] win32.Graphics.Direct2D.D2D_RECT_U*sourceRectangles, [Optional] win32.Graphics.Direct2D.D2D1_COLOR_F*colors, [Optional] win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transforms)
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->GetSprites_7(pThis, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
            }

            /// <summary>Retrieves the number of sprites in this sprite batch.</summary>
            /// <returns>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Returns the number of sprites in this sprite batch</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-getspritecount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetSpriteCount()
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    return lpVtbl->GetSpriteCount_8(pThis);
            }

            /// <summary>Removes all sprites from this sprite batch.</summary>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1spritebatch-clear">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void Clear()
            {
                fixed (ID2D1SpriteBatch*pThis = &this)
                    lpVtbl->Clear_9(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, uint, uint, uint, uint, win32.System.Com.HRESULT>AddSprites_5;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, uint, uint, uint, uint, win32.System.Com.HRESULT>SetSprites_6;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, win32.Graphics.Direct2D.D2D_RECT_F*, win32.Graphics.Direct2D.D2D_RECT_U*, win32.Graphics.Direct2D.D2D1_COLOR_F*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, win32.System.Com.HRESULT>GetSprites_7;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>GetSpriteCount_8;
                internal delegate *unmanaged[Stdcall]<ID2D1SpriteBatch*, void>Clear_9;
            }

            private Vtbl*lpVtbl;
        }
    }
}