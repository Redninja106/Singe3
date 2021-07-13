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
        /// <summary>Identifies a shader type for tracing.</summary>
        /// <remarks>
        /// <para><b>D3D11_SHADER_TYPE</b> identifies the type of shader in a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_shader_trace_desc">D3D11_SHADER_TRACE_DESC</a> structure.</para>
        /// <para><div class = "alert"><b>Note</b>  This API requires the Windows Software Development Kit (SDK) for Windows 8.</div> <div> </div></para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shadertracing/ne-d3d11shadertracing-d3d11_shader_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_SHADER_TYPE
        {
            /// <summary>Identifies a vertex shader.</summary>
            D3D11_VERTEX_SHADER = 1,
            /// <summary>Identifies a hull shader.</summary>
            D3D11_HULL_SHADER = 2,
            /// <summary>Identifies a domain shader.</summary>
            D3D11_DOMAIN_SHADER = 3,
            /// <summary>Identifies a geometry shader.</summary>
            D3D11_GEOMETRY_SHADER = 4,
            /// <summary>Identifies a pixel shader.</summary>
            D3D11_PIXEL_SHADER = 5,
            /// <summary>Identifies a compute shader.</summary>
            D3D11_COMPUTE_SHADER = 6,
        }
    }
}