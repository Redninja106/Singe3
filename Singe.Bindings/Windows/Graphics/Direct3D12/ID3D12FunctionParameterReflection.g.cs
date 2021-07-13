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

    namespace Graphics.Direct3D12
    {
        [Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
        internal unsafe struct ID3D12FunctionParameterReflection
        {
            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D12.D3D12_PARAMETER_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc(out win32.Graphics.Direct3D12.D3D12_PARAMETER_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D12.D3D12_PARAMETER_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc(pDescLocal);
                    return __result;
                }
            }

            /// <summary>Fills the parameter descriptor structure for the function's parameter.</summary>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12shader/ns-d3d12shader-d3d12_parameter_desc">D3D12_PARAMETER_DESC</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12shader/ns-d3d12shader-d3d12_parameter_desc">D3D12_PARAMETER_DESC</a> structure that receives a description of the function's parameter.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3d12/d3d12-graphics-reference-returnvalues">Direct3D 12 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Direct3D12.D3D12_PARAMETER_DESC*pDesc)
            {
                fixed (ID3D12FunctionParameterReflection*pThis = &this)
                    return lpVtbl->GetDesc_1(pThis, pDesc);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12FunctionParameterReflection*, win32.Graphics.Direct3D12.D3D12_PARAMETER_DESC*, win32.System.Com.HRESULT>GetDesc_1;
            }

            private Vtbl*lpVtbl;
        }
    }
}