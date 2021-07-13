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
        /// <summary>Describes a shader-variable type.</summary>
        /// <remarks>
        /// <para>Get a shader-variable-type description by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getdesc">ID3D11ShaderReflectionType::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_SHADER_TYPE_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D_SHADER_VARIABLE_CLASS</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D_SHADER_VARIABLE_CLASS</a>-typed value that identifies the variable class as one of scalar, vector, matrix, object, and so on.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_CLASS Class;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D_SHADER_VARIABLE_TYPE</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D_SHADER_VARIABLE_TYPE</a>-typed value that identifies the variable type.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_TYPE Type;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of rows in a matrix. Otherwise a numeric type returns 1, any other type returns 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Rows;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of columns in a matrix. Otherwise a numeric type returns 1, any other type returns 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Columns;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of elements in an array; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Elements;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of members in the structure; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Members;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Offset, in bytes, between the start of the parent structure and this variable. Can be 0 if not a structure member.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Offset;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>Name of the shader-variable type. This member can be <b>NULL</b> if it isn't used. This member supports dynamic shader linkage interface types, which have names. For more info about dynamic shader linkage, see <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/overviews-direct3d-11-hlsl-dynamic-linking">Dynamic Linking</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shader/ns-d3d11shader-d3d11_shader_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCSTR Name;
        }
    }
}