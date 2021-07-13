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

    namespace Graphics.Direct3D11
    {
        [Guid("207BCECB-D683-4A06-A8A3-9B149B9F73A4")]
        internal unsafe struct ID3D11FunctionReflection
        {
            /// <inheritdoc cref = "GetDesc(win32.Graphics.Direct3D11.D3D11_FUNCTION_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetDesc(out win32.Graphics.Direct3D11.D3D11_FUNCTION_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_FUNCTION_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetDesc(pDescLocal);
                    return __result;
                }
            }

            /// <summary>Fills the function descriptor structure for the function.</summary>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/ns-d3d11shader-d3d11_function_desc">D3D11_FUNCTION_DESC</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/ns-d3d11shader-d3d11_function_desc">D3D11_FUNCTION_DESC</a> structure that receives a description of the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetDesc(win32.Graphics.Direct3D11.D3D11_FUNCTION_DESC*pDesc)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetDesc_1(pThis, pDesc);
            }

            /// <summary>Gets a constant buffer by index for a function.</summary>
            /// <param name = "BufferIndex">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Zero-based index.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyindex#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer">ID3D11ShaderReflectionConstantBuffer</a>*</b></para>
            /// <para>A pointer to a <a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer">ID3D11ShaderReflectionConstantBuffer</a> interface that represents the constant buffer.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyindex">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.Graphics.Direct3D11.ID3D11ShaderReflectionConstantBuffer*GetConstantBufferByIndex(uint BufferIndex)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetConstantBufferByIndex_2(pThis, BufferIndex);
            }

            /// <summary>Gets a constant buffer by name for a function.</summary>
            /// <param name = "Name">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>The constant-buffer name.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyname#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer">ID3D11ShaderReflectionConstantBuffer</a>*</b></para>
            /// <para>A pointer to a <a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer">ID3D11ShaderReflectionConstantBuffer</a> interface that represents the constant buffer.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyname">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.Graphics.Direct3D11.ID3D11ShaderReflectionConstantBuffer*GetConstantBufferByName(win32.System.SystemServices.PCSTR Name)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetConstantBufferByName_3(pThis, Name);
            }

            /// <inheritdoc cref = "GetResourceBindingDesc(uint, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetResourceBindingDesc(uint ResourceIndex, out win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetResourceBindingDesc(ResourceIndex, pDescLocal);
                    return __result;
                }
            }

            /// <summary>Gets a description of how a resource is bound to a function.</summary>
            /// <param name = "ResourceIndex">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A zero-based resource index.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_input_bind_desc">D3D11_SHADER_INPUT_BIND_DESC</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_input_bind_desc">D3D11_SHADER_INPUT_BIND_DESC</a> structure that describes input binding of the resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdesc#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetResourceBindingDesc(uint ResourceIndex, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*pDesc)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetResourceBindingDesc_4(pThis, ResourceIndex, pDesc);
            }

            /// <summary>Gets a variable by name.</summary>
            /// <param name = "Name">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>A pointer to a string containing the variable name.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getvariablebyname#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionvariable">ID3D11ShaderReflectionVariable</a>*</b></para>
            /// <para>Returns a <a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionvariable">ID3D11ShaderReflectionVariable Interface</a> interface.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getvariablebyname">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.Graphics.Direct3D11.ID3D11ShaderReflectionVariable*GetVariableByName(win32.System.SystemServices.PCSTR Name)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetVariableByName_5(pThis, Name);
            }

            /// <inheritdoc cref = "GetResourceBindingDescByName(win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*)"/>
            internal unsafe win32.System.Com.HRESULT GetResourceBindingDescByName(win32.System.SystemServices.PCSTR Name, out win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC pDesc)
            {
                fixed (win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*pDescLocal = &pDesc)
                {
                    win32.System.Com.HRESULT __result = this.GetResourceBindingDescByName(Name, pDescLocal);
                    return __result;
                }
            }

            /// <summary>Gets a description of how a resource is bound to a function.</summary>
            /// <param name = "Name">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>The constant-buffer name of the resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdescbyname#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pDesc">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_input_bind_desc">D3D11_SHADER_INPUT_BIND_DESC</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_input_bind_desc">D3D11_SHADER_INPUT_BIND_DESC</a> structure that describes input binding of the resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdescbyname#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>Returns one of the <a href = "/windows/desktop/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdescbyname">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetResourceBindingDescByName(win32.System.SystemServices.PCSTR Name, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*pDesc)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetResourceBindingDescByName_6(pThis, Name, pDesc);
            }

            /// <summary>Gets the function parameter reflector.</summary>
            /// <param name = "ParameterIndex">
            /// <para>Type: <b>INT</b></para>
            /// <para>The zero-based index of the function parameter reflector to retrieve.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getfunctionparameter#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11functionparameterreflection">ID3D11FunctionParameterReflection</a>*</b></para>
            /// <para>A pointer to a <a href = "/windows/desktop/api/d3d11shader/nn-d3d11shader-id3d11functionparameterreflection">ID3D11FunctionParameterReflection</a> interface that represents the function parameter reflector.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/nf-d3d11shader-id3d11functionreflection-getfunctionparameter">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.Graphics.Direct3D11.ID3D11FunctionParameterReflection*GetFunctionParameter(int ParameterIndex)
            {
                fixed (ID3D11FunctionReflection*pThis = &this)
                    return lpVtbl->GetFunctionParameter_7(pThis, ParameterIndex);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, win32.Graphics.Direct3D11.D3D11_FUNCTION_DESC*, win32.System.Com.HRESULT>GetDesc_1;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, win32.Graphics.Direct3D11.ID3D11ShaderReflectionConstantBuffer*>GetConstantBufferByIndex_2;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D11.ID3D11ShaderReflectionConstantBuffer*>GetConstantBufferByName_3;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*, win32.System.Com.HRESULT>GetResourceBindingDesc_4;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D11.ID3D11ShaderReflectionVariable*>GetVariableByName_5;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, win32.System.SystemServices.PCSTR, win32.Graphics.Direct3D11.D3D11_SHADER_INPUT_BIND_DESC*, win32.System.Com.HRESULT>GetResourceBindingDescByName_6;
                internal delegate *unmanaged[Stdcall]<ID3D11FunctionReflection*, int, win32.Graphics.Direct3D11.ID3D11FunctionParameterReflection*>GetFunctionParameter_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}