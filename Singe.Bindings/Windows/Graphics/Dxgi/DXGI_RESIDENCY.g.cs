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

    namespace Graphics.Dxgi
    {
        /// <summary>Flags indicating the memory location of a resource.</summary>
        /// <remarks>
        /// <para>This enum is used by <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgidevice-queryresourceresidency">QueryResourceResidency</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//dxgi/ne-dxgi-dxgi_residency#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum DXGI_RESIDENCY
        {
            /// <summary>The resource is located in video memory.</summary>
            DXGI_RESIDENCY_FULLY_RESIDENT = 1,
            /// <summary>At least some of the resource is located in CPU memory.</summary>
            DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY = 2,
            /// <summary>At least some of the resource has been paged out to the hard drive.</summary>
            DXGI_RESIDENCY_EVICTED_TO_DISK = 3,
        }
    }
}