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
        [Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
        internal unsafe struct ID3D12PipelineLibrary1
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
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetPrivateData(global::System.Guid*, uint *, void *)"/>
            internal unsafe win32.System.Com.HRESULT GetPrivateData(in global::System.Guid guid, ref uint pDataSize, void *pData)
            {
                fixed (uint *pDataSizeLocal = &pDataSize)
                {
                    fixed (global::System.Guid*guidLocal = &guid)
                    {
                        win32.System.Com.HRESULT __result = this.GetPrivateData(guidLocal, pDataSizeLocal, pData);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetPrivateData(global::System.Guid*guid, uint *pDataSize, [Optional] void *pData)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->GetPrivateData_4(pThis, guid, pDataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateData(global::System.Guid*, uint, void *)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateData(in global::System.Guid guid, uint DataSize, void *pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateData(guidLocal, DataSize, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateData(global::System.Guid*guid, uint DataSize, [Optional] void *pData)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->SetPrivateData_5(pThis, guid, DataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateDataInterface(global::System.Guid*, win32.System.Com.IUnknown*)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(in global::System.Guid guid, win32.System.Com.IUnknown*pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateDataInterface(guidLocal, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(global::System.Guid*guid, [Optional] win32.System.Com.IUnknown*pData)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_6(pThis, guid, pData);
            }

            /// <inheritdoc cref = "SetName(win32.System.SystemServices.PCWSTR)"/>
            internal unsafe win32.System.Com.HRESULT SetName(string Name)
            {
                fixed (char *NameLocal = Name)
                {
                    win32.System.Com.HRESULT __result = this.SetName(NameLocal);
                    return __result;
                }
            }

            internal win32.System.Com.HRESULT SetName(win32.System.SystemServices.PCWSTR Name)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->SetName_7(pThis, Name);
            }

            /// <inheritdoc cref = "GetDevice(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetDevice(in global::System.Guid riid, void **ppvDevice)
            {
                fixed (global::System.Guid*riidLocal = &riid)
                {
                    win32.System.Com.HRESULT __result = this.GetDevice(riidLocal, ppvDevice);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDevice(global::System.Guid*riid, [Optional] void **ppvDevice)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppvDevice);
            }

            /// <inheritdoc cref = "StorePipeline(win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.ID3D12PipelineState*)"/>
            internal unsafe win32.System.Com.HRESULT StorePipeline(string pName, win32.Graphics.Direct3D12.ID3D12PipelineState*pPipeline)
            {
                fixed (char *pNameLocal = pName)
                {
                    win32.System.Com.HRESULT __result = this.StorePipeline(pNameLocal, pPipeline);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT StorePipeline(win32.System.SystemServices.PCWSTR pName, win32.Graphics.Direct3D12.ID3D12PipelineState*pPipeline)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->StorePipeline_9(pThis, pName, pPipeline);
            }

            /// <inheritdoc cref = "LoadGraphicsPipeline(win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_GRAPHICS_PIPELINE_STATE_DESC*, global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT LoadGraphicsPipeline(string pName, in win32.Graphics.Direct3D12.D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, in global::System.Guid riid, out void *ppPipelineState)
            {
                fixed (void **ppPipelineStateLocal = &ppPipelineState)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        fixed (win32.Graphics.Direct3D12.D3D12_GRAPHICS_PIPELINE_STATE_DESC*pDescLocal = &pDesc)
                        {
                            fixed (char *pNameLocal = pName)
                            {
                                win32.System.Com.HRESULT __result = this.LoadGraphicsPipeline(pNameLocal, pDescLocal, riidLocal, ppPipelineStateLocal);
                                return __result;
                            }
                        }
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT LoadGraphicsPipeline(win32.System.SystemServices.PCWSTR pName, win32.Graphics.Direct3D12.D3D12_GRAPHICS_PIPELINE_STATE_DESC*pDesc, global::System.Guid*riid, void **ppPipelineState)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->LoadGraphicsPipeline_10(pThis, pName, pDesc, riid, ppPipelineState);
            }

            /// <inheritdoc cref = "LoadComputePipeline(win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_COMPUTE_PIPELINE_STATE_DESC*, global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT LoadComputePipeline(string pName, in win32.Graphics.Direct3D12.D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, in global::System.Guid riid, out void *ppPipelineState)
            {
                fixed (void **ppPipelineStateLocal = &ppPipelineState)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        fixed (win32.Graphics.Direct3D12.D3D12_COMPUTE_PIPELINE_STATE_DESC*pDescLocal = &pDesc)
                        {
                            fixed (char *pNameLocal = pName)
                            {
                                win32.System.Com.HRESULT __result = this.LoadComputePipeline(pNameLocal, pDescLocal, riidLocal, ppPipelineStateLocal);
                                return __result;
                            }
                        }
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT LoadComputePipeline(win32.System.SystemServices.PCWSTR pName, win32.Graphics.Direct3D12.D3D12_COMPUTE_PIPELINE_STATE_DESC*pDesc, global::System.Guid*riid, void **ppPipelineState)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->LoadComputePipeline_11(pThis, pName, pDesc, riid, ppPipelineState);
            }

            internal nuint GetSerializedSize()
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->GetSerializedSize_12(pThis);
            }

            internal unsafe win32.System.Com.HRESULT Serialize(void *pData, nuint DataSizeInBytes)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->Serialize_13(pThis, pData, DataSizeInBytes);
            }

            /// <inheritdoc cref = "LoadPipeline(win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_PIPELINE_STATE_STREAM_DESC*, global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT LoadPipeline(string pName, in win32.Graphics.Direct3D12.D3D12_PIPELINE_STATE_STREAM_DESC pDesc, in global::System.Guid riid, out void *ppPipelineState)
            {
                fixed (void **ppPipelineStateLocal = &ppPipelineState)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        fixed (win32.Graphics.Direct3D12.D3D12_PIPELINE_STATE_STREAM_DESC*pDescLocal = &pDesc)
                        {
                            fixed (char *pNameLocal = pName)
                            {
                                win32.System.Com.HRESULT __result = this.LoadPipeline(pNameLocal, pDescLocal, riidLocal, ppPipelineStateLocal);
                                return __result;
                            }
                        }
                    }
                }
            }

            /// <summary>Retrieves the requested PSO from the library. The pipeline stream description is matched against the library database and remembered in order to prevent duplication of PSO contents.</summary>
            /// <param name = "pName">
            /// <para>Type: <b>LPCWSTR</b></para>
            /// <para><a href = "https://docs.microsoft.com/visualstudio/code-quality/annotating-function-parameters-and-return-values?view=vs-2015">SAL</a>: <c>_In_</c></para>
            /// <para>The unique name of the PSO.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pDesc">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_pipeline_state_stream_desc">D3D12_PIPELINE_STATE_STREAM_DESC</a>*</b></para>
            /// <para><a href = "https://docs.microsoft.com/visualstudio/code-quality/annotating-function-parameters-and-return-values?view=vs-2015">SAL</a>: <c>_In_</c></para>
            /// <para>Describes the required PSO using a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_pipeline_state_stream_desc">D3D12_PIPELINE_STATE_STREAM_DESC</a> structure. This description is matched against the library database and stored in order to prevent duplication of PSO contents.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "riid">
            /// <para>Type: <b>REFIID</b></para>
            /// <para>Specifies a REFIID for the ID3D12PipelineStateState object.</para>
            /// <para>Applications should typically set this argument and the following argument, ppPipelineState, by using the macro IID_PPV_ARGS(&amp;PSO1), where PSO1 is the name of the object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppPipelineState">
            /// <para>Type: <b>void**</b></para>
            /// <para><a href = "https://docs.microsoft.com/visualstudio/code-quality/annotating-function-parameters-and-return-values?view=vs-2015">SAL</a>: <c>_COM_Outptr_</c></para>
            /// <para>Specifies the pointer that will reference the PSO after the function successfully returns.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code, which can include E_INVALIDARG if the name doesn't exist or the stream description doesn't match the data in the library, and E_OUTOFMEMORY if the function is unable to allocate the resulting PSO.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT LoadPipeline(win32.System.SystemServices.PCWSTR pName, win32.Graphics.Direct3D12.D3D12_PIPELINE_STATE_STREAM_DESC*pDesc, global::System.Guid*riid, void **ppPipelineState)
            {
                fixed (ID3D12PipelineLibrary1*pThis = &this)
                    return lpVtbl->LoadPipeline_14(pThis, pName, pDesc, riid, ppPipelineState);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_6;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, win32.System.SystemServices.PCWSTR, win32.System.Com.HRESULT>SetName_7;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.ID3D12PipelineState*, win32.System.Com.HRESULT>StorePipeline_9;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_GRAPHICS_PIPELINE_STATE_DESC*, global::System.Guid*, void **, win32.System.Com.HRESULT>LoadGraphicsPipeline_10;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_COMPUTE_PIPELINE_STATE_DESC*, global::System.Guid*, void **, win32.System.Com.HRESULT>LoadComputePipeline_11;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, nuint>GetSerializedSize_12;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void *, nuint, win32.System.Com.HRESULT>Serialize_13;
                internal delegate *unmanaged[Stdcall]<ID3D12PipelineLibrary1*, win32.System.SystemServices.PCWSTR, win32.Graphics.Direct3D12.D3D12_PIPELINE_STATE_STREAM_DESC*, global::System.Guid*, void **, win32.System.Com.HRESULT>LoadPipeline_14;
            }

            private Vtbl*lpVtbl;
        }
    }
}