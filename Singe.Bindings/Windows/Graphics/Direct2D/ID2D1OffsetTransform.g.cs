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
        [Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
        internal unsafe struct ID2D1OffsetTransform
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
                fixed (ID2D1OffsetTransform*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1OffsetTransform*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1OffsetTransform*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal uint GetInputCount()
            {
                fixed (ID2D1OffsetTransform*pThis = &this)
                    return lpVtbl->GetInputCount_4(pThis);
            }

            /// <summary>Sets the offset in the current offset transform.</summary>
            /// <param name = "offset">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh847948(v=vs.85)">D2D1_POINT_2L</a></b></para>
            /// <para>The new offset to apply to the offset transform.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1offsettransform-setoffset#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1offsettransform-setoffset">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetOffset(win32.UI.DisplayDevices.POINT offset)
            {
                fixed (ID2D1OffsetTransform*pThis = &this)
                    lpVtbl->SetOffset_5(pThis, offset);
            }

            /// <summary>Gets the offset currently in the offset transform.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/previous-versions/windows/desktop/legacy/hh847948(v=vs.85)">D2D1_POINT_2L</a></b></para>
            /// <para>The current transform offset.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1offsettransform-getoffset">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.UI.DisplayDevices.POINT GetOffset()
            {
                fixed (ID2D1OffsetTransform*pThis = &this)
                    return lpVtbl->GetOffset_6(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, uint>GetInputCount_4;
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, win32.UI.DisplayDevices.POINT, void>SetOffset_5;
                internal delegate *unmanaged[Stdcall]<ID2D1OffsetTransform*, win32.UI.DisplayDevices.POINT>GetOffset_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}