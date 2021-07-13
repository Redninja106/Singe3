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

    namespace Graphics.Direct3D10
    {
        /// <summary>Specifies the subresource(s) from a multisampled 2D texture to use in a shader-resource view.</summary>
        /// <remarks>
        /// <para>Since a multisampled 2D texture contains a single subresource, there is actually nothing to specify in <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_tex2dms_rtv">D3D10_TEX2DMS_RTV</a>. Consequently, <b>UnusedField_NothingToDefine</b> is included so that this structure will compile in C.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_tex2dms_srv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_TEX2DMS_SRV
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Integer of any value. See remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_tex2dms_srv#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint UnusedField_NothingToDefine;
        }
    }
}