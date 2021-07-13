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
        /// <summary>Describes a shader-variable type.</summary>
        /// <remarks>
        /// <para>Get a shader-variable-type description by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getdesc">ID3D12ShaderReflectionType::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12shader/ns-d3d12shader-d3d12_shader_type_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_SHADER_TYPE_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D_SHADER_VARIABLE_CLASS</a>-typed value that identifies the variable class as one of scalar, vector, matrix, object, and so on.</summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_CLASS Class;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D_SHADER_VARIABLE_TYPE</a>-typed value that identifies the variable type.</summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_TYPE Type;
            /// <summary>Number of rows in a matrix. Otherwise a numeric type returns 1, any other type returns 0.</summary>
            internal uint Rows;
            /// <summary>Number of columns in a matrix. Otherwise a numeric type returns 1, any other type returns 0.</summary>
            internal uint Columns;
            /// <summary>Number of elements in an array; otherwise 0.</summary>
            internal uint Elements;
            /// <summary>Number of members in the structure; otherwise 0.</summary>
            internal uint Members;
            /// <summary>Offset, in bytes, between the start of the parent structure and this variable. Can be 0 if not a structure member.</summary>
            internal uint Offset;
            /// <summary>Name of the shader-variable type. This member can be <b>NULL</b> if it isn't used. This member supports dynamic shader linkage interface types, which have names. For more info about dynamic shader linkage, see <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/overviews-direct3d-11-hlsl-dynamic-linking">Dynamic Linking</a>.</summary>
            internal win32.System.SystemServices.PCSTR Name;
        }
    }
}