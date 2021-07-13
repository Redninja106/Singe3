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
        [Guid("2F543DC3-CFC1-4211-864F-CFD91C6F3395")]
        internal unsafe struct ID2D1GdiMetafile
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
                fixed (ID2D1GdiMetafile*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1GdiMetafile*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1GdiMetafile*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1GdiMetafile*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            /// <summary>This method streams the contents of the command to the given metafile sink.</summary>
            /// <param name = "sink">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nn-d2d1_1-id2d1gdimetafilesink">ID2D1GdiMetafileSink</a></b></para>
            /// <para>The sink into which Direct2D  will call back.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gdimetafile-stream#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gdimetafile-stream">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Stream(win32.Graphics.Direct2D.ID2D1GdiMetafileSink*sink)
            {
                fixed (ID2D1GdiMetafile*pThis = &this)
                    return lpVtbl->Stream_5(pThis, sink);
            }

            /// <inheritdoc cref = "GetBounds(win32.Graphics.Direct2D.D2D_RECT_F*)"/>
            internal unsafe win32.System.Com.HRESULT GetBounds(out win32.Graphics.Direct2D.D2D_RECT_F bounds)
            {
                fixed (win32.Graphics.Direct2D.D2D_RECT_F*boundsLocal = &bounds)
                {
                    win32.System.Com.HRESULT __result = this.GetBounds(boundsLocal);
                    return __result;
                }
            }

            /// <summary>Gets the bounds of the metafile, in device-independent pixels (DIPs), as reported in the metafile’s header.</summary>
            /// <param name = "bounds">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/Direct2D/d2d1-rect-f">D2D1_RECT_F</a>*</b></para>
            /// <para>The bounds, in DIPs, of the metafile.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gdimetafile-getbounds#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_1/nf-d2d1_1-id2d1gdimetafile-getbounds">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetBounds(win32.Graphics.Direct2D.D2D_RECT_F*bounds)
            {
                fixed (ID2D1GdiMetafile*pThis = &this)
                    return lpVtbl->GetBounds_6(pThis, bounds);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, win32.Graphics.Direct2D.ID2D1GdiMetafileSink*, win32.System.Com.HRESULT>Stream_5;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafile*, win32.Graphics.Direct2D.D2D_RECT_F*, win32.System.Com.HRESULT>GetBounds_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}