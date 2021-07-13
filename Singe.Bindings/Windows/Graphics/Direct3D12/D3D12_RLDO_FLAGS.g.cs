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
        /// <summary>Specifies options for the amount of information to report about a live device object's lifetime.</summary>
        /// <remarks>
        /// <para>This enumeration is used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice-reportlivedeviceobjects">ID3D12DebugDevice::ReportLiveDeviceObjects</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/ne-d3d12sdklayers-d3d12_rldo_flags#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_RLDO_FLAGS
        {
            /// <summary></summary>
            D3D12_RLDO_NONE = 0,
            /// <summary>Obtain a summary about a live device object's lifetime.</summary>
            D3D12_RLDO_SUMMARY = 1,
            /// <summary>Obtain detailed information about a live device object's lifetime.</summary>
            D3D12_RLDO_DETAIL = 2,
            /// <summary>This flag indicates to ignore objects which have no external refcounts keeping them alive. D3D objects are printed using an external refcount and an internal refcount. Typically, all objects are printed. This flag means ignore the objects whose external refcount is 0, because the application is not responsible for keeping them alive.</summary>
            D3D12_RLDO_IGNORE_INTERNAL = 4,
        }
    }
}