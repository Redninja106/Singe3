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

    namespace Graphics.Direct3D10
    {
        [Guid("6530D5C7-07E9-4271-A418-E7CE4BD1E480")]
        internal unsafe struct ID3D10EffectSamplerVariable
        {
            internal win32.System.SystemServices.BOOL IsValid()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->IsValid_1(pThis);
            }

            internal new unsafe win32.Graphics.Direct3D10.ID3D10EffectType*GetType()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetType_2(pThis);
            }

            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D10.D3D10_EFFECT_VARIABLE_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc(out win32.Graphics.Direct3D10.D3D10_EFFECT_VARIABLE_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D10.D3D10_EFFECT_VARIABLE_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc(pDescLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Direct3D10.D3D10_EFFECT_VARIABLE_DESC*pDesc)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetDesc_3(pThis, pDesc);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetAnnotationByIndex(uint Index)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetAnnotationByIndex_4(pThis, Index);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetAnnotationByName(win32.System.SystemServices.PCSTR Name)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetAnnotationByName_5(pThis, Name);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetMemberByIndex(uint Index)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetMemberByIndex_6(pThis, Index);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetMemberByName(win32.System.SystemServices.PCSTR Name)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetMemberByName_7(pThis, Name);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetMemberBySemantic(win32.System.SystemServices.PCSTR Semantic)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetMemberBySemantic_8(pThis, Semantic);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVariable*GetElement(uint Index)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetElement_9(pThis, Index);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectConstantBuffer*GetParentConstantBuffer()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetParentConstantBuffer_10(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectScalarVariable*AsScalar()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsScalar_11(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectVectorVariable*AsVector()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsVector_12(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectMatrixVariable*AsMatrix()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsMatrix_13(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectStringVariable*AsString()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsString_14(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectShaderResourceVariable*AsShaderResource()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsShaderResource_15(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectRenderTargetViewVariable*AsRenderTargetView()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsRenderTargetView_16(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectDepthStencilViewVariable*AsDepthStencilView()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsDepthStencilView_17(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectConstantBuffer*AsConstantBuffer()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsConstantBuffer_18(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectShaderVariable*AsShader()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsShader_19(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectBlendVariable*AsBlend()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsBlend_20(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectDepthStencilVariable*AsDepthStencil()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsDepthStencil_21(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectRasterizerVariable*AsRasterizer()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsRasterizer_22(pThis);
            }

            internal unsafe win32.Graphics.Direct3D10.ID3D10EffectSamplerVariable*AsSampler()
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->AsSampler_23(pThis);
            }

            internal unsafe win32.System.Com.HRESULT SetRawValue(void *pData, uint Offset, uint ByteCount)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->SetRawValue_24(pThis, pData, Offset, ByteCount);
            }

            internal unsafe win32.System.Com.HRESULT GetRawValue(void *pData, uint Offset, uint ByteCount)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetRawValue_25(pThis, pData, Offset, ByteCount);
            }

            /// <summary>Get a pointer to a sampler interface.</summary>
            /// <param name = "Index">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Index into an array of sampler interfaces. If there is only one sampler interface, use 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getsampler#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppSampler">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nn-d3d10-id3d10samplerstate">ID3D10SamplerState</a>**</b></para>
            /// <para>The address of a pointer to a sampler interface (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nn-d3d10-id3d10samplerstate">ID3D10SamplerState Interface</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getsampler#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getsampler">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetSampler(uint Index, win32.Graphics.Direct3D10.ID3D10SamplerState**ppSampler)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetSampler_26(pThis, Index, ppSampler);
            }

            /// <inheritdoc cref = "GetBackingStore(uint, win32.Graphics.Direct3D10.D3D10_SAMPLER_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetBackingStore(uint Index, out win32.Graphics.Direct3D10.D3D10_SAMPLER_DESC pSamplerDesc)
            {
                fixed (win32.Graphics.Direct3D10.D3D10_SAMPLER_DESC*pSamplerDescLocal = &pSamplerDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetBackingStore(Index, pSamplerDescLocal);
                    return __result;
                }
            }

            /// <summary>Get a pointer to a variable that contains sampler state.</summary>
            /// <param name = "Index">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Index into an array of sampler descriptions. If there is only one sampler variable in the effect, use 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getbackingstore#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pSamplerDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_sampler_desc">D3D10_SAMPLER_DESC</a>*</b></para>
            /// <para>A pointer to a sampler description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_sampler_desc">D3D10_SAMPLER_DESC</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getbackingstore#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getbackingstore">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetBackingStore(uint Index, win32.Graphics.Direct3D10.D3D10_SAMPLER_DESC*pSamplerDesc)
            {
                fixed (ID3D10EffectSamplerVariable*pThis = &this)
                    return lpVtbl->GetBackingStore_27(pThis, Index, pSamplerDesc);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.System.SystemServices.BOOL>IsValid_1;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectType*>GetType_2;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.D3D10_EFFECT_VARIABLE_DESC*, win32.System.Com.HRESULT>GetDesc_3;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, uint, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetAnnotationByIndex_4;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetAnnotationByName_5;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, uint, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetMemberByIndex_6;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetMemberByName_7;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetMemberBySemantic_8;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, uint, win32.Graphics.Direct3D10.ID3D10EffectVariable*>GetElement_9;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectConstantBuffer*>GetParentConstantBuffer_10;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectScalarVariable*>AsScalar_11;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectVectorVariable*>AsVector_12;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectMatrixVariable*>AsMatrix_13;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectStringVariable*>AsString_14;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectShaderResourceVariable*>AsShaderResource_15;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectRenderTargetViewVariable*>AsRenderTargetView_16;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectDepthStencilViewVariable*>AsDepthStencilView_17;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectConstantBuffer*>AsConstantBuffer_18;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectShaderVariable*>AsShader_19;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectBlendVariable*>AsBlend_20;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectDepthStencilVariable*>AsDepthStencil_21;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectRasterizerVariable*>AsRasterizer_22;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, win32.Graphics.Direct3D10.ID3D10EffectSamplerVariable*>AsSampler_23;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, void *, uint, uint, win32.System.Com.HRESULT>SetRawValue_24;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, void *, uint, uint, win32.System.Com.HRESULT>GetRawValue_25;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, uint, win32.Graphics.Direct3D10.ID3D10SamplerState**, win32.System.Com.HRESULT>GetSampler_26;
                internal delegate *unmanaged[Stdcall]<ID3D10EffectSamplerVariable*, uint, win32.Graphics.Direct3D10.D3D10_SAMPLER_DESC*, win32.System.Com.HRESULT>GetBackingStore_27;
            }

            private Vtbl*lpVtbl;
        }
    }
}