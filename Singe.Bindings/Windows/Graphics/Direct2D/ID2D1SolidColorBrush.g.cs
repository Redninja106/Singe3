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
        [Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
        internal unsafe struct ID2D1SolidColorBrush
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
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            internal void SetOpacity(float opacity)
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
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
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    lpVtbl->SetTransform_6(pThis, transform);
            }

            internal float GetOpacity()
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
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
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    lpVtbl->GetTransform_8(pThis, transform);
            }

            /// <inheritdoc cref = "SetColor(win32.Graphics.Direct2D.D2D1_COLOR_F*)"/>
            internal unsafe void SetColor(in win32.Graphics.Direct2D.D2D1_COLOR_F color)
            {
                fixed (win32.Graphics.Direct2D.D2D1_COLOR_F*colorLocal = &color)
                {
                    this.SetColor(colorLocal);
                }
            }

            internal unsafe void SetColor(win32.Graphics.Direct2D.D2D1_COLOR_F*color)
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    lpVtbl->SetColor_9(pThis, color);
            }

            /// <summary>Retrieves the color of the solid color brush.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/Direct2D/d2d1-color-f">D2D1_COLOR_F</a></b></para>
            /// <para>The color of this solid color brush.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1/nf-d2d1-id2d1solidcolorbrush-getcolor">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct2D.D2D1_COLOR_F GetColor()
            {
                fixed (ID2D1SolidColorBrush*pThis = &this)
                    return lpVtbl->GetColor_10(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, float, void>SetOpacity_5;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, void>SetTransform_6;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, float>GetOpacity_7;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, win32.Graphics.Direct2D.D2D_MATRIX_3X2_F*, void>GetTransform_8;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, win32.Graphics.Direct2D.D2D1_COLOR_F*, void>SetColor_9;
                internal delegate *unmanaged[Stdcall]<ID2D1SolidColorBrush*, win32.Graphics.Direct2D.D2D1_COLOR_F>GetColor_10;
            }

            private Vtbl*lpVtbl;
        }
    }
}