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
        /// <summary>Describes the slot of a root signature version 1.0.</summary>
        /// <remarks>
        /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_root_signature_desc">D3D12_ROOT_SIGNATURE_DESC</a> can contain descriptor tables and inline constants. More capable hardware could support inline descriptors in the root signature as well. The number of bind slots in the root signature are most efficient if kept below a certain size, and can have an upper bound as well.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_root_parameter#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_ROOT_PARAMETER
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_root_parameter_type">D3D12_ROOT_PARAMETER_TYPE</a>-typed value that  specifies the type of root signature slot. This member determines which type to use in the union below.</summary>
            internal win32.Graphics.Direct3D12.D3D12_ROOT_PARAMETER_TYPE ParameterType;
            internal win32.Graphics.Direct3D12.D3D12_ROOT_PARAMETER._Anonymous_e__Union Anonymous;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_shader_visibility">D3D12_SHADER_VISIBILITY</a>-typed value that  specifies the shaders that can access the contents of the root signature slot.</summary>
            internal win32.Graphics.Direct3D12.D3D12_SHADER_VISIBILITY ShaderVisibility;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_ROOT_CONSTANTS Constants;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_ROOT_DESCRIPTOR Descriptor;
            }
        }
    }
}