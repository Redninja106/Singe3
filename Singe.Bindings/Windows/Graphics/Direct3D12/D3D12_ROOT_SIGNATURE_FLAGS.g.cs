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
        /// <summary>Specifies options for root signature layout.</summary>
        /// <remarks>
        /// <para>This enum is used in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_signature_desc">D3D12_ROOT_SIGNATURE_DESC</a> structure.</para>
        /// <para>The value in denying access to shader stages is a minor optimization on some hardware. If, for example, the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_shader_visibility">D3D12_SHADER_VISIBILITY_ALL</a> flag has been set to broadcast the root signature to all shader stages, then denying access can overrule this and save the hardware some work. Alternatively if the shader is so simple that no root signature resources are needed, then denying access could be used here too.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_root_signature_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D3D12_ROOT_SIGNATURE_FLAGS : uint
        {
            /// <summary>Indicates default behavior.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_NONE = 0x00000000,
            /// <summary>The app is opting in to using the Input Assembler (requiring an input layout that defines a set of vertex buffer bindings). Omitting this flag can result in one root argument space being saved on some hardware. Omit this flag if the Input Assembler is not required, though the optimization is minor.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT = 0x00000001,
            /// <summary>Denies the vertex shader access to the root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS = 0x00000002,
            /// <summary>Denies the hull shader access to the root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS = 0x00000004,
            /// <summary>Denies the domain shader access to the root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS = 0x00000008,
            /// <summary>Denies the geometry shader access to the root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS = 0x00000010,
            /// <summary>Denies the pixel shader access to the root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS = 0x00000020,
            /// <summary>The app is opting in to using Stream Output. Omitting this flag can result in one root argument space being saved on some hardware. Omit this flag if Stream Output is not required, though the optimization is minor.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT = 0x00000040,
            /// <summary>The root signature is to be used with raytracing shaders to define resource bindings sourced from shader records in shader tables.  This flag cannot be combined with any other root signature flags, which are all related to the graphics pipeline.  The absence of the flag means the root signature can be used with graphics or compute, where the compute version is also shared with raytracing’s global root signature.</summary>
            D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE = 0x00000080,
            D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS = 0x00000100,
            D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS = 0x00000200,
        }
    }
}