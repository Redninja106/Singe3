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
        /// <summary>Describes a shader-resource view.</summary>
        /// <remarks>
        /// <para>A view is a format-specific way to look at the data in a resource. The view determines what data to look at, and how it is cast when read.</para>
        /// <para>When viewing a resource, the resource-view description must specify a typed format, that is compatible with the resource format. So that means that you can't create a resource-view description using any format with _TYPELESS in the name. You can however view a typeless resource by specifying a typed format for the view. For example, a DXGI_FORMAT_R32G32B32_TYPELESS resource can be viewed with one of these typed formats: DXGI_FORMAT_R32G32B32_FLOAT, DXGI_FORMAT_R32G32B32_UINT, and DXGI_FORMAT_R32G32B32_SINT, since these typed formats are compatible with the typeless resource.</para>
        /// <para>Create a shader-resource-view description by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-createshaderresourceview">ID3D12Device::CreateShaderResourceView</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_shader_resource_view_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_SHADER_RESOURCE_VIEW_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a>-typed value that specifies the viewing format. See remarks.</summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_srv_dimension">D3D12_SRV_DIMENSION</a>-typed value that specifies the resource type of the view. This type is the same as the resource type of the underlying resource. This member also determines which _SRV to use in the union below.</summary>
            internal win32.Graphics.Direct3D12.D3D12_SRV_DIMENSION ViewDimension;
            /// <summary>A value, constructed using the <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_shader_component_mapping">D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING</a> macro. The **D3D12_SHADER_COMPONENT_MAPPING** enumeration specifies what values from memory should be returned when the texture is accessed in a shader via this shader resource view (SRV). For example, it can route component 1 (green) from memory, or the constant `0`, into component 2 (`.b`) of the value given to the shader.</summary>
            internal uint Shader4ComponentMapping;
            internal win32.Graphics.Direct3D12.D3D12_SHADER_RESOURCE_VIEW_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_BUFFER_SRV Buffer;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX1D_SRV Texture1D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX1D_ARRAY_SRV Texture1DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2D_SRV Texture2D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2D_ARRAY_SRV Texture2DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2DMS_SRV Texture2DMS;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX3D_SRV Texture3D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEXCUBE_SRV TextureCube;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure;
            }
        }
    }
}