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
        /// <summary>Unordered-access view options.</summary>
        /// <remarks>
        /// <para>This enumeration is used by a unordered access-view description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_unordered_access_view_desc">D3D11_UNORDERED_ACCESS_VIEW_DESC</a>).</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ne-d3d11-d3d11_uav_dimension#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_UAV_DIMENSION
        {
            /// <summary>The view type is unknown.</summary>
            D3D11_UAV_DIMENSION_UNKNOWN = 0,
            /// <summary>View the resource as a buffer.</summary>
            D3D11_UAV_DIMENSION_BUFFER = 1,
            /// <summary>View the resource as a 1D texture.</summary>
            D3D11_UAV_DIMENSION_TEXTURE1D = 2,
            /// <summary>View the resource as a 1D texture array.</summary>
            D3D11_UAV_DIMENSION_TEXTURE1DARRAY = 3,
            /// <summary>View the resource as a 2D texture.</summary>
            D3D11_UAV_DIMENSION_TEXTURE2D = 4,
            /// <summary>View the resource as a 2D texture array.</summary>
            D3D11_UAV_DIMENSION_TEXTURE2DARRAY = 5,
            /// <summary>View the resource as a 3D texture array.</summary>
            D3D11_UAV_DIMENSION_TEXTURE3D = 8,
        }
    }
}