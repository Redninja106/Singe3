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
        /// <summary>Describes a shader-trace object.</summary>
        /// <remarks>
        /// <para>This API requires the Windows Software Development Kit (SDK) for Windows 8.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shadertracing/ns-d3d11shadertracing-d3d11_shader_trace_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_SHADER_TRACE_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shadertracing/ne-d3d11shadertracing-d3d11_shader_type">D3D11_SHADER_TYPE</a>-typed value that identifies the type of shader that the shader-trace object describes. This member also determines which shader-trace type to use in the following union.</summary>
            internal win32.Graphics.Direct3D11.D3D11_SHADER_TYPE Type;
            /// <summary>
            /// <para>A combination of the following flags that are combined by using a bitwise <b>OR</b> operation. The resulting value specifies how <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertracefactory-createshadertrace">ID3D11ShaderTraceFactory::CreateShaderTrace</a> creates the shader-trace object.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11shadertracing/ns-d3d11shadertracing-d3d11_shader_trace_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint Flags;
            internal win32.Graphics.Direct3D11.D3D11_SHADER_TRACE_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc;
            }
        }
    }
}