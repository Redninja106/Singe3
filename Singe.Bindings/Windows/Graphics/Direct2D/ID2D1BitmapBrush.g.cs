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
        [Guid("2CD906AA-12E2-11DC-9FED-001143A055F9")]
        internal unsafe struct ID2D1BitmapBrush
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
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            internal void SetOpacity(float opacity)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetOpacity_5(pThis, opacity);
            }

            /// <inheritdoc cref = "SetTransform(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*)"/>
            internal unsafe void SetTransform(in win32.Graphics.Direct2D.D2D_MATRIX_3X2_F transform)
            {
                fixed (win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transformLocal = &transform)
                {
                    this.SetTransform(transformLocal);
                }
            }

            internal unsafe void SetTransform(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transform)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetTransform_6(pThis, transform);
            }

            internal float GetOpacity()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->GetOpacity_7(pThis);
            }

            /// <inheritdoc cref = "GetTransform(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*)"/>
            internal unsafe void GetTransform(out win32.Graphics.Direct2D.D2D_MATRIX_3X2_F transform)
            {
                fixed (win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transformLocal = &transform)
                {
                    this.GetTransform(transformLocal);
                }
            }

            internal unsafe void GetTransform(win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*transform)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->GetTransform_8(pThis, transform);
            }

            /// <summary>Specifies how the brush horizontally tiles those areas that extend past its bitmap.</summary>
            /// <param name = "extendModeX">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE</a></b></para>
            /// <para>A value that specifies how the brush horizontally tiles those areas that extend past its bitmap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodex#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>Sometimes, the  bitmap for a bitmap brush doesn't completely fill the area being painted. When this happens, Direct2D uses the brush's horizontal (<b>SetExtendModeX</b>) and vertical (<a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodey">SetExtendModeY</a>) extend mode settings to determine how to fill the remaining area.</para>
            /// <para>The following illustration shows the results from  every  possible combination of the extend modes for an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmapbrush">ID2D1BitmapBrush</a>: <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE_CLAMP</a> (CLAMP), <b>D2D1_EXTEND_MODE_WRAP</b> (WRAP), and <b>D2D1_EXTEND_MIRROR</b> (MIRROR).</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodex#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetExtendModeX(win32.Graphics.Direct2D.D2D1_EXTEND_MODE extendModeX)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetExtendModeX_9(pThis, extendModeX);
            }

            /// <summary>Specifies how the brush vertically tiles those areas that extend past its bitmap.</summary>
            /// <param name = "extendModeY">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE</a></b></para>
            /// <para>A value that specifies how the brush vertically tiles those areas that extend past its bitmap.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodey#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>Sometimes, the  bitmap for a bitmap brush doesn't completely fill the area being painted. When this happens, Direct2D uses the brush's horizontal (<a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodex">SetExtendModeX</a>) and vertical (<b>SetExtendModeY</b>) extend mode settings to determine how to fill the remaining area.</para>
            /// <para>The following illustration shows the results from  every  possible combination of the extend modes for an <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmapbrush">ID2D1BitmapBrush</a>: <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE_CLAMP</a> (CLAMP), <b>D2D1_EXTEND_MODE_WRAP</b> (WRAP), and <b>D2D1_EXTEND_MIRROR</b> (MIRROR).</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodey#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetExtendModeY(win32.Graphics.Direct2D.D2D1_EXTEND_MODE extendModeY)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetExtendModeY_10(pThis, extendModeY);
            }

            /// <summary>Specifies the interpolation mode used when the brush bitmap is scaled or rotated.</summary>
            /// <param name = "interpolationMode">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_bitmap_interpolation_mode">D2D1_BITMAP_INTERPOLATION_MODE</a></b></para>
            /// <para>The interpolation mode used when the brush bitmap is scaled or rotated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setinterpolationmode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>This method sets the interpolation mode for a bitmap, which is an enum value that is specified in the <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_bitmap_interpolation_mode">D2D1_BITMAP_INTERPOLATION_MODE</a> enumeration type.   D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR represents nearest neighbor filtering. It looks up the nearest bitmap pixel to the current rendering pixel and chooses its exact color. D2D1_BITMAP_INTERPOLATION_MODE_LINEAR represents linear filtering, and  interpolates a color from the four nearest bitmap pixels.</para>
            /// <para>The interpolation mode of a bitmap also affects subpixel translations. In a subpixel translation, bilinear interpolation positions the bitmap more precisely to the application requests, but blurs the bitmap in the process.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setinterpolationmode#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetInterpolationMode(win32.Graphics.Direct2D.D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetInterpolationMode_11(pThis, interpolationMode);
            }

            /// <summary>Specifies the bitmap source that this brush uses to paint.</summary>
            /// <param name = "bitmap">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmap">ID2D1Bitmap</a>*</b></para>
            /// <para>The bitmap source used by the brush.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setbitmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>This method specifies the bitmap source that this brush uses to paint. The bitmap is not resized or rescaled automatically to fit the geometry that it fills. The bitmap stays at its native size. To resize or translate the bitmap, use the <a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1brush-settransform(constd2d1_matrix_3x2_f)">SetTransform</a> method to apply  a transform to the brush.</para>
            /// <para>The native size of a bitmap is the width and height in bitmap pixels, divided by the bitmap DPI. This native size forms the base tile of the brush. To tile a subregion of the bitmap, you must generate a new bitmap containing this subregion and use <b>SetBitmap</b> to apply it to the brush.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-setbitmap#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void SetBitmap([Optional] win32.Graphics.Direct2D.ID2D1Bitmap*bitmap)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->SetBitmap_12(pThis, bitmap);
            }

            /// <summary>Gets the method by which the brush horizontally tiles those areas that extend past its bitmap.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE</a></b></para>
            /// <para>A value that specifies how the brush horizontally tiles those areas that extend past its bitmap.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-getextendmodex">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_EXTEND_MODE GetExtendModeX()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->GetExtendModeX_13(pThis);
            }

            /// <summary>Gets the method by which the brush vertically tiles those areas that extend past its bitmap.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode">D2D1_EXTEND_MODE</a></b></para>
            /// <para>A value that specifies how the brush vertically tiles those areas that extend past its bitmap.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-getextendmodey">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_EXTEND_MODE GetExtendModeY()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->GetExtendModeY_14(pThis);
            }

            /// <summary>Gets the interpolation method used when the brush bitmap is scaled or rotated.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/api/d2d1/ne-d2d1-d2d1_bitmap_interpolation_mode">D2D1_BITMAP_INTERPOLATION_MODE</a></b></para>
            /// <para>The interpolation method used when the brush bitmap is scaled or rotated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-getinterpolationmode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    return lpVtbl->GetInterpolationMode_15(pThis);
            }

            /// <summary>Gets the bitmap source that this brush uses to paint.</summary>
            /// <param name = "bitmap">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmap">ID2D1Bitmap</a>**</b></para>
            /// <para>When this method returns, contains the address to a pointer to the bitmap with which this brush paints.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-getbitmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1bitmapbrush-getbitmap">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetBitmap([Optional] win32.Graphics.Direct2D.ID2D1Bitmap**bitmap)
            {
                fixed (ID2D1BitmapBrush*pThis = &this)
                    lpVtbl->GetBitmap_16(pThis, bitmap);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, float, void>SetOpacity_5;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, void>SetTransform_6;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, float>GetOpacity_7;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, void>GetTransform_8;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_EXTEND_MODE, void>SetExtendModeX_9;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_EXTEND_MODE, void>SetExtendModeY_10;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_BITMAP_INTERPOLATION_MODE, void>SetInterpolationMode_11;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.ID2D1Bitmap*, void>SetBitmap_12;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_EXTEND_MODE>GetExtendModeX_13;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_EXTEND_MODE>GetExtendModeY_14;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.D2D1_BITMAP_INTERPOLATION_MODE>GetInterpolationMode_15;
                internal delegate *unmanaged[Stdcall]<ID2D1BitmapBrush*, win32.Graphics.Direct2D.ID2D1Bitmap**, void>GetBitmap_16;
            }

            private Vtbl*lpVtbl;
        }
    }
}