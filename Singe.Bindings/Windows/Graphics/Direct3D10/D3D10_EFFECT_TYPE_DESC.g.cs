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
        /// <summary>Describes an effect-variable type.</summary>
        /// <remarks>
        /// <para>To get an effect-variable type, call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getdesc">ID3D10EffectType::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_EFFECT_TYPE_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LPCSTR</a></b></para>
            /// <para>A string that contains the variable name.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PCSTR TypeName;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D10_SHADER_VARIABLE_CLASS</a></b></para>
            /// <para>The variable class (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D10_SHADER_VARIABLE_CLASS</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_CLASS Class;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D10_SHADER_VARIABLE_TYPE</a></b></para>
            /// <para>The variable type (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_type">D3D10_SHADER_VARIABLE_TYPE</a>).</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_TYPE Type;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of elements if the variable is an array; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Elements;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of members if the variable is a structure; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Members;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of rows if the variable is a matrix; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Rows;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of columns if the variable is a matrix; otherwise 0.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Columns;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of bytes that the variable consumes when it is packed tightly by the compiler.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint PackedSize;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of bytes that the variable consumes before it is packed by the compiler.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint UnpackedSize;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The number of bytes between elements.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10effect/ns-d3d10effect-d3d10_effect_type_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Stride;
        }
    }
}