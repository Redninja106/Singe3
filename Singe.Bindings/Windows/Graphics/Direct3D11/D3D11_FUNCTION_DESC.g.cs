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
        /// <summary>Describes a function.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_FUNCTION_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The shader version.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Version;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>The name of the originator of the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCSTR Creator;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>A combination of <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/d3dcompile-constants">D3DCOMPILE Constants</a> that are combined by using a bitwise OR operation. The resulting value specifies shader compilation and parsing.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Flags;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of constant buffers for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ConstantBuffers;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of bound resources for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint BoundResources;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of emitted instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint InstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of temporary registers used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TempRegisterCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of temporary arrays used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TempArrayCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of constant defines for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint DefCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of declarations (input + output) for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint DclCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of non-categorized texture instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TextureNormalInstructions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of texture load instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TextureLoadInstructions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of texture comparison instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TextureCompInstructions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of texture bias instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TextureBiasInstructions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of texture gradient instructions for the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TextureGradientInstructions;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of floating point arithmetic instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint FloatInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of signed integer arithmetic instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint IntInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of unsigned integer arithmetic instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint UintInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of static flow control instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint StaticFlowControlCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of dynamic flow control instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint DynamicFlowControlCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of macro instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MacroInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of array instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ArrayInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of mov instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MovInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of movc instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint MovcInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of type conversion instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ConversionInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of bitwise arithmetic instructions used by the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint BitwiseInstructionCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_feature_level">D3D_FEATURE_LEVEL</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_feature_level">D3D_FEATURE_LEVEL</a>-typed value that specifies the minimum Direct3D feature level target of the function byte code.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_FEATURE_LEVEL MinFeatureLevel;
            /// <summary>
            /// <para>Type: <b>UINT64</b></para>
            /// <para>A value that contains a combination of one or more shader requirements flags; each flag specifies a requirement of the shader. A default value of 0 means there are no requirements. For a list of values, see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/nf-d3d11shader-id3d11shaderreflection-getrequiresflags">ID3D11ShaderReflection::GetRequiresFlags</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal ulong RequiredFeatureFlags;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>The name of the function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCSTR Name;
            /// <summary>
            /// <para>Type: <b>INT</b></para>
            /// <para>The number of logical parameters in the function signature, not including the return value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal int FunctionParameterCount;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Indicates whether the function returns a value. <b>TRUE</b> indicates it returns a value; otherwise, <b>FALSE</b> (it is a subroutine).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL HasReturn;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Indicates whether there is a Direct3D 10Level9 vertex shader blob. <b>TRUE</b> indicates there is a 10Level9 vertex shader blob; otherwise, <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL Has10Level9VertexShader;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">BOOL</a></b></para>
            /// <para>Indicates whether there is a Direct3D 10Level9 pixel shader blob. <b>TRUE</b> indicates there is a 10Level9 pixel shader blob; otherwise, <b>FALSE</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_function_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL Has10Level9PixelShader;
        }
    }
}