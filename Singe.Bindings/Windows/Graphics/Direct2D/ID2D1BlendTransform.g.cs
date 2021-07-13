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
        [Guid("63AC0B32-BA44-450F-8806-7F4CA1FF2F1B")]
        internal unsafe struct ID2D1BlendTransform
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
                fixed (ID2D1BlendTransform*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal uint GetInputCount()
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    return lpVtbl->GetInputCount_4(pThis);
            }

            internal win32.System.Com.HRESULT SetOutputBuffer(win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION bufferPrecision, win32.Graphics.Direct2D.D2D1_CHANNEL_DEPTH channelDepth)
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    return lpVtbl->SetOutputBuffer_5(pThis, bufferPrecision, channelDepth);
            }

            internal void SetCached(win32.System.SystemServices.BOOL isCached)
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    lpVtbl->SetCached_6(pThis, isCached);
            }

            /// <inheritdoc cref = "SetDescription(win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*)"/>
            internal unsafe void SetDescription(in win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION description)
            {
                fixed (win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*descriptionLocal = &description)
                {
                    this.SetDescription(descriptionLocal);
                }
            }

            /// <summary>Changes the blend description of the corresponding blend transform object.</summary>
            /// <param name = "description">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_blend_description">D2D1_BLEND_DESCRIPTION</a>*</b></para>
            /// <para>The new blend description specified for the blend transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-setdescription#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-setdescription">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void SetDescription(win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*description)
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    lpVtbl->SetDescription_7(pThis, description);
            }

            /// <inheritdoc cref = "GetDescription(win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*)"/>
            internal unsafe void GetDescription(out win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION description)
            {
                fixed (win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*descriptionLocal = &description)
                {
                    this.GetDescription(descriptionLocal);
                }
            }

            /// <summary>Gets the blend description of the corresponding blend transform object.</summary>
            /// <param name = "description">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_blend_description">D2D1_BLEND_DESCRIPTION</a>*</b></para>
            /// <para>When this method returns, contains the blend description specified for the blend transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-getdescription#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-getdescription">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void GetDescription(win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*description)
            {
                fixed (ID2D1BlendTransform*pThis = &this)
                    lpVtbl->GetDescription_8(pThis, description);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, uint>GetInputCount_4;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION, win32.Graphics.Direct2D.D2D1_CHANNEL_DEPTH, win32.System.Com.HRESULT>SetOutputBuffer_5;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, win32.System.SystemServices.BOOL, void>SetCached_6;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*, void>SetDescription_7;
                internal delegate *unmanaged[Stdcall]<ID2D1BlendTransform*, win32.Graphics.Direct2D.D2D1_BLEND_DESCRIPTION*, void>GetDescription_8;
            }

            private Vtbl*lpVtbl;
        }
    }
}