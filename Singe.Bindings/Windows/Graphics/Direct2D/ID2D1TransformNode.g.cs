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
        [Guid("B2EFE1E7-729F-4102-949F-505FA21BF666")]
        internal unsafe struct ID2D1TransformNode
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
                fixed (ID2D1TransformNode*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1TransformNode*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1TransformNode*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Gets the number of inputs to the transform node.</summary>
            /// <returns>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>This method returns the number of inputs to this transform node.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformnode-getinputcount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetInputCount()
            {
                fixed (ID2D1TransformNode*pThis = &this)
                    return lpVtbl->GetInputCount_4(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1TransformNode*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformNode*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformNode*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformNode*, uint>GetInputCount_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}