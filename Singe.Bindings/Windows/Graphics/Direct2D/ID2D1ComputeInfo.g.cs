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
        [Guid("5598B14B-9FD7-48B7-9BDB-8F0964EB38BC")]
        internal unsafe struct ID2D1ComputeInfo
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
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal win32.System.Com.HRESULT SetInputDescription(uint inputIndex, win32.Graphics.Direct2D.D2D1_INPUT_DESCRIPTION inputDescription)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->SetInputDescription_4(pThis, inputIndex, inputDescription);
            }

            internal win32.System.Com.HRESULT SetOutputBuffer(win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION bufferPrecision, win32.Graphics.Direct2D.D2D1_CHANNEL_DEPTH channelDepth)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->SetOutputBuffer_5(pThis, bufferPrecision, channelDepth);
            }

            internal void SetCached(win32.System.SystemServices.BOOL isCached)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    lpVtbl->SetCached_6(pThis, isCached);
            }

            internal void SetInstructionCountHint(uint instructionCount)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    lpVtbl->SetInstructionCountHint_7(pThis, instructionCount);
            }

            /// <inheritdoc cref = "SetComputeShaderConstantBuffer(byte *, uint)"/>
            internal unsafe win32.System.Com.HRESULT SetComputeShaderConstantBuffer(ReadOnlySpan<byte> buffer)
            {
                fixed (byte *bufferLocal = buffer)
                {
                    win32.System.Com.HRESULT __result = this.SetComputeShaderConstantBuffer(bufferLocal, (uint)buffer.Length);
                    return __result;
                }
            }

            /// <summary>Establishes or changes the constant buffer data for this transform.</summary>
            /// <param name = "buffer">
            /// <para>Type: <b>const BYTE*</b></para>
            /// <para>The data applied to the constant buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshaderconstantbuffer#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "bufferCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of bytes of data in the constant buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshaderconstantbuffer#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>If this method succeeds, it returns <b xmlns: loc = "http://microsoft.com/wdcml/l10n">S_OK</b>. Otherwise, it returns an <b xmlns: loc = "http://microsoft.com/wdcml/l10n">HRESULT</b> error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshaderconstantbuffer">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetComputeShaderConstantBuffer(byte *buffer, uint bufferCount)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->SetComputeShaderConstantBuffer_8(pThis, buffer, bufferCount);
            }

            /// <inheritdoc cref = "SetComputeShader(global::System.Guid*)"/>
            internal unsafe win32.System.Com.HRESULT SetComputeShader(in global::System.Guid shaderId)
            {
                fixed (global::System.Guid*shaderIdLocal = &shaderId)
                {
                    win32.System.Com.HRESULT __result = this.SetComputeShader(shaderIdLocal);
                    return __result;
                }
            }

            /// <summary>Sets the compute shader to the given shader resource. The resource must be loaded before this call is made.</summary>
            /// <param name = "shaderId">
            /// <para>Type: <b>REFGUID</b></para>
            /// <para>The GUID of the shader.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshader#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshader">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetComputeShader(global::System.Guid*shaderId)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->SetComputeShader_9(pThis, shaderId);
            }

            /// <summary>Sets the resource texture corresponding to the given shader texture index to the given texture resource.</summary>
            /// <param name = "textureIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index to set the resource texture on.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setresourcetexture#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "resourceTexture">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1resourcetexture">ID2D1ResourceTexture</a>*</b></para>
            /// <para>The resource texture object to set on the shader texture index.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setresourcetexture#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setresourcetexture">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetResourceTexture(uint textureIndex, win32.Graphics.Direct2D.ID2D1ResourceTexture*resourceTexture)
            {
                fixed (ID2D1ComputeInfo*pThis = &this)
                    return lpVtbl->SetResourceTexture_10(pThis, textureIndex, resourceTexture);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, win32.Graphics.Direct2D.D2D1_INPUT_DESCRIPTION, win32.System.Com.HRESULT>SetInputDescription_4;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, win32.Graphics.Direct2D.D2D1_BUFFER_PRECISION, win32.Graphics.Direct2D.D2D1_CHANNEL_DEPTH, win32.System.Com.HRESULT>SetOutputBuffer_5;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, win32.System.SystemServices.BOOL, void>SetCached_6;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, void>SetInstructionCountHint_7;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, byte *, uint, win32.System.Com.HRESULT>SetComputeShaderConstantBuffer_8;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, global::System.Guid*, win32.System.Com.HRESULT>SetComputeShader_9;
                internal delegate *unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, win32.Graphics.Direct2D.ID2D1ResourceTexture*, win32.System.Com.HRESULT>SetResourceTexture_10;
            }

            private Vtbl*lpVtbl;
        }
    }
}