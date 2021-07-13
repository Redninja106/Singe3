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
        /// <summary>Describes a library.</summary>
        /// <remarks>
        /// <para>This structure is returned by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12shader/nf-d3d12shader-id3d12libraryreflection-getdesc">ID3D12LibraryReflection::GetDesc</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12shader/ns-d3d12shader-d3d12_library_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_LIBRARY_DESC
        {
            /// <summary>The name of the originator of the library.</summary>
            internal win32.System.SystemServices.PCSTR Creator;
            /// <summary>A combination of <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/d3dcompile-constants">D3DCOMPILE Constants</a> that are combined by using a bitwise OR operation. The resulting value specifies how the compiler compiles.</summary>
            internal uint Flags;
            /// <summary>The number of functions exported from the library.</summary>
            internal uint FunctionCount;
        }
    }
}