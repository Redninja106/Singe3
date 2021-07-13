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
        /// <summary>Specifies the shaders that can access the contents of a given root signature slot.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_parameter">D3D12_ROOT_PARAMETER</a> structure.</para>
        /// <para>The compute queue always uses <b>D3D12_SHADER_VISIBILITY_ALL</b> because it has only one active stage. The 3D queue can choose values, but if it uses <b>D3D12_SHADER_VISIBILITY_ALL</b>, all shader stages can access whatever is bound at the root signature slot.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_shader_visibility#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_SHADER_VISIBILITY
        {
            /// <summary>Specifies that all shader stages can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_ALL = 0,
            /// <summary>Specifies that the vertex shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_VERTEX = 1,
            /// <summary>Specifies that the hull shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_HULL = 2,
            /// <summary>Specifies that the domain shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_DOMAIN = 3,
            /// <summary>Specifies that the geometry shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_GEOMETRY = 4,
            /// <summary>Specifies that the pixel shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_PIXEL = 5,
            /// <summary>Specifies that the amplification shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_AMPLIFICATION = 6,
            /// <summary>Specifies that the mesh shader stage can access whatever is bound at the root signature slot.</summary>
            D3D12_SHADER_VISIBILITY_MESH = 7,
        }
    }
}