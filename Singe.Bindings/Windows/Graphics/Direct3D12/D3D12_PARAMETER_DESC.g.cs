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
        /// <summary>Describes a function parameter.</summary>
        /// <remarks>
        /// <para>Get a function-parameter description by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc">ID3D12FunctionParameterReflection::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12shader/ns-d3d12shader-d3d12_parameter_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_PARAMETER_DESC
        {
            /// <summary>The name of the function parameter.</summary>
            internal win32.System.SystemServices.PCSTR Name;
            /// <summary>The HLSL <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/dx-graphics-hlsl-semantics">semantic</a> that is associated with this function parameter. This name includes the index, for example, SV_Target[n].</summary>
            internal win32.System.SystemServices.PCSTR SemanticName;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D_SHADER_VARIABLE_TYPE</a>-typed value that identifies the variable type for the parameter.</summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_TYPE Type;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D_SHADER_VARIABLE_CLASS</a>-typed value that identifies the variable class for the parameter as one of scalar, vector, matrix, object, and so on.</summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_CLASS Class;
            /// <summary>The number of rows for a matrix parameter.</summary>
            internal uint Rows;
            /// <summary>The number of columns for a matrix parameter.</summary>
            internal uint Columns;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_interpolation_mode">D3D_INTERPOLATION_MODE</a>-typed value that identifies the interpolation mode for the parameter.</summary>
            internal win32.Graphics.Direct3D11.D3D_INTERPOLATION_MODE InterpolationMode;
            /// <summary>A combination of <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_parameter_flags">D3D_PARAMETER_FLAGS</a>-typed values that are combined by using a bitwise OR operation. The resulting value specifies semantic flags for the parameter.</summary>
            internal win32.Graphics.Direct3D11.D3D_PARAMETER_FLAGS Flags;
            /// <summary>The first input register for this parameter.</summary>
            internal uint FirstInRegister;
            /// <summary>The first input register component for this parameter.</summary>
            internal uint FirstInComponent;
            /// <summary>The first output register for this parameter.</summary>
            internal uint FirstOutRegister;
            /// <summary>The first output register component for this parameter.</summary>
            internal uint FirstOutComponent;
        }
    }
}