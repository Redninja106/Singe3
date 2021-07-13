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
        /// <summary>Describes a shader-resource view.</summary>
        /// <remarks>
        /// <para>A view is a format-specific way to look at the data in a resource. The view determines what data to look at, and how it is cast when read.</para>
        /// <para>When viewing a resource, the resource-view description must specify a typed format, that is compatible with the resource format. So that means that you cannot create a resource-view description using any format with _TYPELESS in the name. You can however view a typeless resource by specifying a typed format for the view. For example, a DXGI_FORMAT_R32G32B32_TYPELESS resource can be viewed with one of these typed formats: DXGI_FORMAT_R32G32B32_FLOAT, DXGI_FORMAT_R32G32B32_UINT, and DXGI_FORMAT_R32G32B32_SINT, since these typed formats are compatible with the typeless resource.</para>
        /// <para>Create a shader-resource-view description by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11device-createshaderresourceview">ID3D11Device::CreateShaderResourceView</a>. To view a shader-resource-view description, call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11shaderresourceview-getdesc">ID3D11ShaderResourceView::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_shader_resource_view_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_SHADER_RESOURCE_VIEW_DESC
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a></b></para>
            /// <para>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a> specifying the viewing format. See remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_shader_resource_view_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/ff476217(v=vs.85)">D3D11_SRV_DIMENSION</a></b></para>
            /// <para>The resource type of the view. See <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/ff476217(v=vs.85)">D3D11_SRV_DIMENSION</a>. You must set *ViewDimension* to the same resource type as that of the underlying resource. This parameter also determines which _SRV to use in the union below.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_shader_resource_view_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.Graphics.Direct3D11.D3D_SRV_DIMENSION ViewDimension;
            internal win32.Graphics.Direct3D11.D3D11_SHADER_RESOURCE_VIEW_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_BUFFER_SRV Buffer;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX1D_SRV Texture1D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX1D_ARRAY_SRV Texture1DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX2D_SRV Texture2D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX2D_ARRAY_SRV Texture2DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX2DMS_SRV Texture2DMS;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEX3D_SRV Texture3D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEXCUBE_SRV TextureCube;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D11.D3D11_BUFFEREX_SRV BufferEx;
            }
        }
    }
}