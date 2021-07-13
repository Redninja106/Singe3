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
        /// <summary>Identifies the type of resource being used.</summary>
        /// <remarks>
        /// <para>This enumeration is used in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11resource-gettype">ID3D11Resource::GetType</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_resource_dimension#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_RESOURCE_DIMENSION
        {
            /// <summary>Resource is of unknown type.</summary>
            D3D11_RESOURCE_DIMENSION_UNKNOWN = 0,
            /// <summary>Resource is a buffer.</summary>
            D3D11_RESOURCE_DIMENSION_BUFFER = 1,
            /// <summary>Resource is a 1D texture.</summary>
            D3D11_RESOURCE_DIMENSION_TEXTURE1D = 2,
            /// <summary>Resource is a 2D texture.</summary>
            D3D11_RESOURCE_DIMENSION_TEXTURE2D = 3,
            /// <summary>Resource is a 3D texture.</summary>
            D3D11_RESOURCE_DIMENSION_TEXTURE3D = 4,
        }
    }
}