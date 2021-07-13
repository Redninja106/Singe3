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
        /// <summary>Describes the subresources from a resource that are accessible by using an unordered-access view.</summary>
        /// <remarks>
        /// <para>Pass an unordered-access-view description into <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12device-createunorderedaccessview">ID3D12Device::CreateUnorderedAccessView</a> to create a view.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_unordered_access_view_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
        {
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/dxgiformat/ne-dxgiformat-dxgi_format">DXGI_FORMAT</a>-typed value that specifies the viewing format.</summary>
            internal win32.Graphics.Dxgi.DXGI_FORMAT Format;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_uav_dimension">D3D12_UAV_DIMENSION</a>-typed value that specifies the resource type of the view. This type specifies how the resource will be accessed. This member also determines which _UAV to use in the union below.</summary>
            internal win32.Graphics.Direct3D12.D3D12_UAV_DIMENSION ViewDimension;
            internal win32.Graphics.Direct3D12.D3D12_UNORDERED_ACCESS_VIEW_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_BUFFER_UAV Buffer;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX1D_UAV Texture1D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX1D_ARRAY_UAV Texture1DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2D_UAV Texture2D;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX2D_ARRAY_UAV Texture2DArray;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_TEX3D_UAV Texture3D;
            }
        }
    }
}