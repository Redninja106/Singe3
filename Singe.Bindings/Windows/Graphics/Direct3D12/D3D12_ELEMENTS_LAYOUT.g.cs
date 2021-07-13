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
        /// <summary>Describes how the locations of elements are identified.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_elements_layout">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_ELEMENTS_LAYOUT
        {
            /// <summary>For a data set of <i>n</i> elements, the pointer parameter points to the start of <i>n</i> elements in memory.</summary>
            D3D12_ELEMENTS_LAYOUT_ARRAY = 0,
            /// <summary>For a data set of <i>n</i> elements, the pointer parameter points to an array of <i>n</i> pointers in memory, each pointing to an individual element of the set.</summary>
            D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS = 1,
        }
    }
}