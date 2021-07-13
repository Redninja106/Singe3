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
        /// <summary>Defines the dimensions of a viewport.</summary>
        /// <remarks>
        /// <para>In all cases, <b>Width</b> and <b>Height</b> must be &gt;= 0 and <b>TopLeftX</b> + <b>Width</b> and <b>TopLeftY</b> + <b>Height</b> must be &lt;= D3D11_VIEWPORT_BOUNDS_MAX.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_VIEWPORT
        {
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>X position of the left hand side of the viewport. Ranges between D3D11_VIEWPORT_BOUNDS_MIN and D3D11_VIEWPORT_BOUNDS_MAX.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float TopLeftX;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Y position of the top of the viewport. Ranges between D3D11_VIEWPORT_BOUNDS_MIN and D3D11_VIEWPORT_BOUNDS_MAX.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float TopLeftY;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Width of the viewport.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float Width;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Height of the viewport.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float Height;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Minimum depth of the viewport. Ranges between 0 and 1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float MinDepth;
            /// <summary>
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">FLOAT</a></b></para>
            /// <para>Maximum depth of the viewport. Ranges between 0 and 1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_viewport#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal float MaxDepth;
        }
    }
}