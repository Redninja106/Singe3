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
        /// <summary>Values that identify the indended use of a constant-data buffer.</summary>
        /// <remarks>
        /// <para><b>D3D_SHADER_CBUFFER_FLAGS</b>-typed values are specified in the <b>uFlags</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shader/ns-d3d11shader-d3d11_shader_buffer_desc">D3D11_SHADER_BUFFER_DESC</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/ne-d3dcommon-d3d_shader_cbuffer_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D_SHADER_CBUFFER_FLAGS
        {
            /// <summary>Bind the constant buffer to an input slot defined in HLSL code (instead of letting the compiler choose the input slot).</summary>
            D3D_CBF_USERPACKED = 1,
            /// <summary>Bind the constant buffer to an input slot defined in HLSL code (instead of letting the compiler choose the input slot).</summary>
            D3D10_CBF_USERPACKED = 1,
            /// <summary>This value is not used by a programmer; it exists to force the enumeration to compile to 32 bits.</summary>
            D3D_CBF_FORCE_DWORD = 2147483647,
        }
    }
}