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
        /// <summary>Describes a shader signature.</summary>
        /// <remarks>
        /// <para>A shader can take n inputs and can produce m outputs. The order of the input (or output) parameters, their associated types, and any attached semantics make up the shader signature. Each shader has an input and an output signature.</para>
        /// <para>When compiling a shader or an effect, some API calls validate shader signatures  That is, they compare the output signature of one shader (like a vertex shader) with the input signature of another shader (like a pixel shader). This ensures that a shader outputs data that is compatible with a downstream shader that is consuming that data. Compatible means that a shader signature is a exact-match subset of the preceding shader stage. Exact match means parameter types and semantics must exactly match. Subset means that a parameter that is not required by a downstream stage, does not need to include that parameter in its shader signature.</para>
        /// <para>Get a shader-signature from a shader or an effect by calling APIs such as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getinputparameterdesc">ID3D11ShaderReflection::GetInputParameterDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_SIGNATURE_PARAMETER_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>A per-parameter string that identifies how the data will be used. For more info, see <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/dx-graphics-hlsl-semantics">Semantics</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCSTR SemanticName;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Semantic index that modifies the semantic. Used to differentiate different parameters that use the same semantic.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint SemanticIndex;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The register that will contain this variable's data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Register;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_name">D3D_NAME</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_name">D3D_NAME</a>-typed value that identifies a predefined string that determines the functionality of certain pipeline stages.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_NAME SystemValueType;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_register_component_type">D3D_REGISTER_COMPONENT_TYPE</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_register_component_type">D3D_REGISTER_COMPONENT_TYPE</a>-typed value that identifies the per-component-data type that is stored in a register.  Each register can store up to four-components of data.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_REGISTER_COMPONENT_TYPE ComponentType;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Mask which indicates which components of a register are used.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte Mask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BYTE</a></b></para>
            /// <para>Mask which indicates whether a given component is never written (if the signature is an output signature) or always read (if the signature is an input signature).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal byte ReadWriteMask;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Indicates which stream the geometry shader is using for the signature parameter.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Stream;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_min_precision">D3D_MIN_PRECISION</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_min_precision">D3D_MIN_PRECISION</a>-typed value that indicates the minimum desired interpolation precision. For more info, see <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/using-hlsl-minimum-precision">Using HLSL minimum precision</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_MIN_PRECISION MinPrecision;
        }
    }
}