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
        [Guid("8339FDE3-106F-47AB-8373-1C6295EB10B3")]
        internal unsafe struct IDWriteInlineObject
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
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>The application implemented rendering callback (IDWriteTextRenderer::DrawInlineObject) can use this to draw the inline object without needing to cast or query the object type. The text layout does not call this method directly.</summary>
            /// <param name = "clientDrawingContext">
            /// <para>Type: <b>void*</b></para>
            /// <para>The drawing context passed to <a href = "https://docs.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-draw">IDWriteTextLayout::Draw</a>.  This parameter may be <b>NULL</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "renderer">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextrenderer">IDWriteTextRenderer</a>*</b></para>
            /// <para>The same renderer passed to <a href = "https://docs.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-draw">IDWriteTextLayout::Draw</a> as the object's containing parent.  This is useful if the inline object is recursive such as a nested layout.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "originX">
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The x-coordinate at the upper-left corner of the inline object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "originY">
            /// <para>Type: <b>FLOAT</b></para>
            /// <para>The y-coordinate at the upper-left corner of the inline object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "isSideways">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>A Boolean flag that indicates whether the object's baseline runs alongside the baseline axis of the line.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "isRightToLeft">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>A Boolean flag that indicates whether the object is in a right-to-left context and should be drawn flipped.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "clientDrawingEffect">
            /// <para>Type: <b>IUnknown*</b></para>
            /// <para>The drawing effect set in <a href = "https://docs.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setdrawingeffect">IDWriteTextLayout::SetDrawingEffect</a>.  Usually this effect is a foreground brush that  is used in glyph drawing.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-draw">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Draw([Optional] void *clientDrawingContext, win32.Graphics.DirectWrite.IDWriteTextRenderer*renderer, float originX, float originY, win32.System.SystemServices.BOOL isSideways, win32.System.SystemServices.BOOL isRightToLeft, [Optional] win32.System.Com.IUnknown*clientDrawingEffect)
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->Draw_4(pThis, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
            }

            /// <inheritdoc cref = "GetMetrics(win32.Graphics.DirectWrite.DWRITE_INLINE_OBJECT_METRICS*)"/>
            internal unsafe win32.System.Com.HRESULT GetMetrics(out win32.Graphics.DirectWrite.DWRITE_INLINE_OBJECT_METRICS metrics)
            {
                fixed (win32.Graphics.DirectWrite.DWRITE_INLINE_OBJECT_METRICS*metricsLocal = &metrics)
                {
                    win32.System.Com.HRESULT __result = this.GetMetrics(metricsLocal);
                    return __result;
                }
            }

            /// <summary>IDWriteTextLayout calls this callback function to get the measurement of the inline object.</summary>
            /// <param name = "metrics">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_inline_object_metrics">DWRITE_INLINE_OBJECT_METRICS</a>*</b></para>
            /// <para>When this method returns, contains a structure describing the geometric measurement of an application-defined inline object.  These metrics are in relation to the baseline of the adjacent text.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getmetrics#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getmetrics">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetMetrics(win32.Graphics.DirectWrite.DWRITE_INLINE_OBJECT_METRICS*metrics)
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->GetMetrics_5(pThis, metrics);
            }

            /// <inheritdoc cref = "GetOverhangMetrics(win32.Graphics.DirectWrite.DWRITE_OVERHANG_METRICS*)"/>
            internal unsafe win32.System.Com.HRESULT GetOverhangMetrics(out win32.Graphics.DirectWrite.DWRITE_OVERHANG_METRICS overhangs)
            {
                fixed (win32.Graphics.DirectWrite.DWRITE_OVERHANG_METRICS*overhangsLocal = &overhangs)
                {
                    win32.System.Com.HRESULT __result = this.GetOverhangMetrics(overhangsLocal);
                    return __result;
                }
            }

            /// <summary>IDWriteTextLayout calls this callback function to get the visible extents (in DIPs) of the inline object. In the case of a simple bitmap, with no padding and no overhang, all the overhangs will simply be zeroes.</summary>
            /// <param name = "overhangs">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_overhang_metrics">DWRITE_OVERHANG_METRICS</a>*</b></para>
            /// <para>Overshoot of visible extents (in DIPs) outside the object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getoverhangmetrics#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getoverhangmetrics">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetOverhangMetrics(win32.Graphics.DirectWrite.DWRITE_OVERHANG_METRICS*overhangs)
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->GetOverhangMetrics_6(pThis, overhangs);
            }

            /// <inheritdoc cref = "GetBreakConditions(win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*, win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*)"/>
            internal unsafe win32.System.Com.HRESULT GetBreakConditions(out win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION breakConditionBefore, out win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION breakConditionAfter)
            {
                fixed (win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*breakConditionAfterLocal = &breakConditionAfter)
                {
                    fixed (win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*breakConditionBeforeLocal = &breakConditionBefore)
                    {
                        win32.System.Com.HRESULT __result = this.GetBreakConditions(breakConditionBeforeLocal, breakConditionAfterLocal);
                        return __result;
                    }
                }
            }

            /// <summary>Layout uses this to determine the line-breaking behavior of the inline object among the text.</summary>
            /// <param name = "breakConditionBefore">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_break_condition">DWRITE_BREAK_CONDITION</a>*</b></para>
            /// <para>When this method returns, contains a value which indicates the line-breaking condition between the object and the content immediately preceding it.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getbreakconditions#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "breakConditionAfter">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_break_condition">DWRITE_BREAK_CONDITION</a>*</b></para>
            /// <para>When this method returns, contains a value which indicates the line-breaking condition between the object and the content immediately following it.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getbreakconditions#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dwrite/nf-dwrite-idwriteinlineobject-getbreakconditions">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetBreakConditions(win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*breakConditionBefore, win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*breakConditionAfter)
            {
                fixed (IDWriteInlineObject*pThis = &this)
                    return lpVtbl->GetBreakConditions_7(pThis, breakConditionBefore, breakConditionAfter);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, void *, win32.Graphics.DirectWrite.IDWriteTextRenderer*, float, float, win32.System.SystemServices.BOOL, win32.System.SystemServices.BOOL, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>Draw_4;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, win32.Graphics.DirectWrite.DWRITE_INLINE_OBJECT_METRICS*, win32.System.Com.HRESULT>GetMetrics_5;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, win32.Graphics.DirectWrite.DWRITE_OVERHANG_METRICS*, win32.System.Com.HRESULT>GetOverhangMetrics_6;
                internal delegate *unmanaged[Stdcall]<IDWriteInlineObject*, win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*, win32.Graphics.DirectWrite.DWRITE_BREAK_CONDITION*, win32.System.Com.HRESULT>GetBreakConditions_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}