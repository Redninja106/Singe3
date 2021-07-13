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
        [Guid("EF1A287D-342A-4F76-8FDB-DA0D6EA9F92B")]
        internal unsafe struct ID2D1Transform
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
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal uint GetInputCount()
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->GetInputCount_4(pThis);
            }

            /// <inheritdoc cref = "MapOutputRectToInputRects(win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*, uint)"/>
            internal unsafe win32.System.Com.HRESULT MapOutputRectToInputRects(in win32.UI.DisplayDevices.RECT outputRect, Span<win32.UI.DisplayDevices.RECT> inputRects)
            {
                fixed (win32.UI.DisplayDevices.RECT*inputRectsLocal = inputRects)
                {
                    fixed (win32.UI.DisplayDevices.RECT*outputRectLocal = &outputRect)
                    {
                        win32.System.Com.HRESULT __result = this.MapOutputRectToInputRects(outputRectLocal, inputRectsLocal, (uint)inputRects.Length);
                        return __result;
                    }
                }
            }

            /// <summary>Allows a transform to state how it would map a rectangle requested on its output to a set of sample rectangles on its input.</summary>
            /// <param name = "outputRect">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>The output rectangle from which the inputs must be mapped.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapoutputrecttoinputrects#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "inputRects">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>The corresponding set of inputs. The inputs will directly correspond to the transform inputs.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapoutputrecttoinputrects#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "inputRectsCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of inputs specified. <a href = "https://docs.microsoft.com/windows/desktop/Direct2D/direct2d-portal">Direct2D</a> guarantees that this is equal to the number of inputs specified on the transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapoutputrecttoinputrects#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If the method succeeds, it returns <b>S_OK</b>. If it fails, it returns an <b>HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapoutputrecttoinputrects">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT MapOutputRectToInputRects(win32.UI.DisplayDevices.RECT*outputRect, win32.UI.DisplayDevices.RECT*inputRects, uint inputRectsCount)
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->MapOutputRectToInputRects_5(pThis, outputRect, inputRects, inputRectsCount);
            }

            /// <inheritdoc cref = "MapInputRectsToOutputRect(win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*, uint, win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*)"/>
            internal unsafe win32.System.Com.HRESULT MapInputRectsToOutputRect(ReadOnlySpan<win32.UI.DisplayDevices.RECT> inputRects, ReadOnlySpan<win32.UI.DisplayDevices.RECT> inputOpaqueSubRects, out win32.UI.DisplayDevices.RECT outputRect, out win32.UI.DisplayDevices.RECT outputOpaqueSubRect)
            {
                fixed (win32.UI.DisplayDevices.RECT*outputOpaqueSubRectLocal = &outputOpaqueSubRect)
                {
                    fixed (win32.UI.DisplayDevices.RECT*outputRectLocal = &outputRect)
                    {
                        fixed (win32.UI.DisplayDevices.RECT*inputOpaqueSubRectsLocal = inputOpaqueSubRects)
                        {
                            fixed (win32.UI.DisplayDevices.RECT*inputRectsLocal = inputRects)
                            {
                                if (inputRects.Length != inputOpaqueSubRects.Length)
                                    throw new ArgumentException();
                                win32.System.Com.HRESULT __result = this.MapInputRectsToOutputRect(inputRectsLocal, inputOpaqueSubRectsLocal, (uint)inputOpaqueSubRects.Length, outputRectLocal, outputOpaqueSubRectLocal);
                                return __result;
                            }
                        }
                    }
                }
            }

            /// <summary>Performs the inverse mapping to MapOutputRectToInputRects.</summary>
            /// <param name = "inputRects">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>An array of input rectangles to be mapped to the output rectangle.  The <i>inputRects</i> parameter is always equal to the input bounds.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "inputOpaqueSubRects">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>An array of input rectangles to be mapped to the opaque output rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "inputRectCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of inputs specified. The implementation guarantees that this is equal to the number of inputs specified on the transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "outputRect">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>The output rectangle that maps to the corresponding input rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "outputOpaqueSubRect">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>The output rectangle that maps to the corresponding opaque input rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If the method succeeds, it returns <b>S_OK</b>. If it fails, it returns an <b>HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT MapInputRectsToOutputRect(win32.UI.DisplayDevices.RECT*inputRects, win32.UI.DisplayDevices.RECT*inputOpaqueSubRects, uint inputRectCount, win32.UI.DisplayDevices.RECT*outputRect, win32.UI.DisplayDevices.RECT*outputOpaqueSubRect)
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->MapInputRectsToOutputRect_6(pThis, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            }

            /// <inheritdoc cref = "MapInvalidRect(uint, win32.UI.DisplayDevices.RECT, win32.UI.DisplayDevices.RECT*)"/>
            internal unsafe win32.System.Com.HRESULT MapInvalidRect(uint inputIndex, win32.UI.DisplayDevices.RECT invalidInputRect, out win32.UI.DisplayDevices.RECT invalidOutputRect)
            {
                fixed (win32.UI.DisplayDevices.RECT*invalidOutputRectLocal = &invalidOutputRect)
                {
                    win32.System.Com.HRESULT __result = this.MapInvalidRect(inputIndex, invalidInputRect, invalidOutputRectLocal);
                    return __result;
                }
            }

            /// <summary>Sets the input rectangles for this rendering pass into the transform.</summary>
            /// <param name = "inputIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index of the input rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinvalidrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "invalidInputRect">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a></b></para>
            /// <para>The invalid input rectangle.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinvalidrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "invalidOutputRect">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847950(v=vs.85)">D2D1_RECT_L</a>*</b></para>
            /// <para>The output rectangle to which the input rectangle must be mapped.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinvalidrect#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If the method succeeds, it returns <b>S_OK</b>. If it fails, it returns an <b>HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinvalidrect">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT MapInvalidRect(uint inputIndex, win32.UI.DisplayDevices.RECT invalidInputRect, win32.UI.DisplayDevices.RECT*invalidOutputRect)
            {
                fixed (ID2D1Transform*pThis = &this)
                    return lpVtbl->MapInvalidRect_7(pThis, inputIndex, invalidInputRect, invalidOutputRect);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, uint>GetInputCount_4;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*, uint, win32.System.Com.HRESULT>MapOutputRectToInputRects_5;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*, uint, win32.UI.DisplayDevices.RECT*, win32.UI.DisplayDevices.RECT*, win32.System.Com.HRESULT>MapInputRectsToOutputRect_6;
                internal delegate *unmanaged[Stdcall]<ID2D1Transform*, uint, win32.UI.DisplayDevices.RECT, win32.UI.DisplayDevices.RECT*, win32.System.Com.HRESULT>MapInvalidRect_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}