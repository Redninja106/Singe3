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
        /// <summary>Describes a shader scope variable.</summary>
        /// <remarks>
        /// <para>The <b>D3D10_SHADER_DEBUG_SCOPEVAR_INFO</b> structure is used with the <a href = "https://docs.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_info">D3D10_SHADER_DEBUG_INFO</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_SHADER_DEBUG_SCOPEVAR_INFO
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Index into variable token.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint TokenId;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d3d10_1shader/ne-d3d10_1shader-d3d10_shader_debug_vartype">D3D10_SHADER_DEBUG_VARTYPE</a></b></para>
            /// <para>Indicates whether this is a variable or function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D10.D3D10_SHADER_DEBUG_VARTYPE VarType;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_class">D3D10_SHADER_VARIABLE_CLASS</a></b></para>
            /// <para>Indicates the variable class.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SHADER_VARIABLE_CLASS Class;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of row for matrices.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Rows;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of columns for vectors or matrices.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Columns;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Gives a scope to look up struct members.  This member will be -1 if <b>D3D10_SHADER_DEBUG_SCOPEVAR_INFO</b> does not refer to a struct.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint StructMemberScope;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of array indices. For example a three dimensional array would have a value of 3 for <b>uArrayIndices</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint uArrayIndices;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Offset to an array of UINT values <b>uArrayIndices</b> long.  The array contains the maximum value for each index. For example an array a[3][2][1] would have the values {3,2,1} at the offset pointed to by <b>ArrayElements</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ArrayElements;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Offset to an array of UINT values <b>uArrayIndices</b> long.  The array contains the stride for each array index.  For example an array a[3][2][1] would have the values {2,1,1} at the offset pointed to by <b>ArrayStrides</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint ArrayStrides;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of variables.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint uVariables;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Index of the first variable, later variables are offsets from this one.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint uFirstVariable;
        }
    }
}