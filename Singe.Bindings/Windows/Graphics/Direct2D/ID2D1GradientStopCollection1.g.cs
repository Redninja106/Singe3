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
        [Guid("AE1572F4-5DD0-4777-998B-9279472AE63B")]
        internal unsafe struct ID2D1GradientStopCollection1
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
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            internal uint GetGradientStopCount()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetGradientStopCount_5(pThis);
            }

            /// <inheritdoc cref = "GetGradientStops(win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*, uint)"/>
            internal unsafe void GetGradientStops(Span<win32.Graphics.Direct2D.D2D1_GRADIENT_STOP> gradientStops)
            {
                fixed (win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*gradientStopsLocal = gradientStops)
                {
                    this.GetGradientStops(gradientStopsLocal, (uint)gradientStops.Length);
                }
            }

            internal unsafe void GetGradientStops(win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*gradientStops, uint gradientStopsCount)
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    lpVtbl->GetGradientStops_6(pThis, gradientStops, gradientStopsCount);
            }

            internal win32.Graphics.Direct2D.D2D1_GAMMA GetColorInterpolationGamma()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetColorInterpolationGamma_7(pThis);
            }

            internal win32.Graphics.Direct2D.D2D1_EXTEND_MODE GetExtendMode()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetExtendMode_8(pThis);
            }

            /// <inheritdoc cref = "GetGradientStops1(win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*, uint)"/>
            internal unsafe void GetGradientStops1(Span<win32.Graphics.Direct2D.D2D1_GRADIENT_STOP> gradientStops)
            {
                fixed (win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*gradientStopsLocal = gradientStops)
                {
                    this.GetGradientStops1(gradientStopsLocal, (uint)gradientStops.Length);
                }
            }

            /// <summary>Copies the gradient stops from the collection into memory.</summary>
            /// <param name = "gradientStops">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ns-d2d1-d2d1_gradient_stop">D2D1_GRADIENT_STOP</a>*</b></para>
            /// <para>When this method returns, contains a pointer to a one-dimensional array of <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ns-d2d1-d2d1_gradient_stop">D2D1_GRADIENT_STOP</a> structures.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getgradientstops1#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "gradientStopsCount">
            /// <para>Type: <b>UINT</b></para>
            /// <para>The number of gradient stops to copy.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getgradientstops1#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>If the [ID2D1DeviceContext::CreateGradientStopCollection](./nf-d2d1_1-id2d1devicecontext-creategradientstopcollection.md), this method returns the same values specified in the creation method. If the <b>ID2D1GradientStopCollection1</b> object was created using <b>ID2D1RenderTarget::CreateGradientStopCollection</b>, the stops returned here will first be transformed into the gamma space specified by the <i>colorInterpolationGamma</i> parameter. See the <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-creategradientstopcollection">ID2D1DeviceContext::CreateGradientStopCollection</a>  method for more info about color space and gamma space.</para>
            /// <para>If <i>gradientStopsCount</i> is less than the number of gradient stops in the collection, the remaining gradient stops are omitted. If <i>gradientStopsCount</i> is larger than the number of gradient stops in the collection, the extra gradient stops are set to <b>NULL</b>. To obtain the number of gradient stops in the collection, use the <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/nf-d2d1-id2d1gradientstopcollection-getgradientstopcount">GetGradientStopCount</a> method.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getgradientstops1#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetGradientStops1(win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*gradientStops, uint gradientStopsCount)
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    lpVtbl->GetGradientStops1_9(pThis, gradientStops, gradientStopsCount);
            }

            /// <summary>Gets the color space of the input colors as well as the space in which gradient stops are interpolated.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_color_space">D2D1_COLOR_SPACE</a></b></para>
            /// <para>This method returns the color space.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getpreinterpolationspace">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_COLOR_SPACE GetPreInterpolationSpace()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetPreInterpolationSpace_10(pThis);
            }

            /// <summary>Gets the color space after interpolation has occurred.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_color_space">D2D1_COLOR_SPACE</a></b></para>
            /// <para>This method returns the color space.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getpostinterpolationspace">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_COLOR_SPACE GetPostInterpolationSpace()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetPostInterpolationSpace_11(pThis);
            }

            /// <summary>Gets the precision of the gradient buffer.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_buffer_precision">D2D1_BUFFER_PRECISION</a></b></para>
            /// <para>The buffer precision of the gradient buffer.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getbufferprecision">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION GetBufferPrecision()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetBufferPrecision_12(pThis);
            }

            /// <summary>Retrieves the color interpolation mode that the gradient stop collection uses.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_color_interpolation_mode">D2D1_COLOR_INTERPOLATION_MODE</a></b></para>
            /// <para>The color interpolation mode.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gradientstopcollection1-getcolorinterpolationmode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode()
            {
                fixed (ID2D1GradientStopCollection1*pThis = &this)
                    return lpVtbl->GetColorInterpolationMode_13(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>GetGradientStopCount_5;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*, uint, void>GetGradientStops_6;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_GAMMA>GetColorInterpolationGamma_7;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_EXTEND_MODE>GetExtendMode_8;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_GRADIENT_STOP*, uint, void>GetGradientStops1_9;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_COLOR_SPACE>GetPreInterpolationSpace_10;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_COLOR_SPACE>GetPostInterpolationSpace_11;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION>GetBufferPrecision_12;
                internal delegate *unmanaged[Stdcall]<ID2D1GradientStopCollection1*, win32.Graphics.Direct2D.D2D1_COLOR_INTERPOLATION_MODE>GetColorInterpolationMode_13;
            }

            private Vtbl*lpVtbl;
        }
    }
}