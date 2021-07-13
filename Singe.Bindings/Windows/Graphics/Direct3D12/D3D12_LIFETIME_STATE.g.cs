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
        /// <summary>Defines constants that specify the lifetime state of a lifetime-tracked object.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_lifetime_state#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_LIFETIME_STATE
        {
            /// <summary>Specifies that the lifetime-tracked object is in use.</summary>
            D3D12_LIFETIME_STATE_IN_USE = 0,
            /// <summary>Specifies that the lifetime-tracked object is not in use.</summary>
            D3D12_LIFETIME_STATE_NOT_IN_USE = 1,
        }
    }
}