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

    namespace Graphics.Imaging
    {
        /// <summary>Specifies the type of Windows Imaging Component (WIC) component.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wincodec/ne-wincodec-wiccomponenttype">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum WICComponentType
        {
            /// <summary>A WIC decoder.</summary>
            WICDecoder = 1,
            /// <summary>A WIC encoder.</summary>
            WICEncoder = 2,
            /// <summary>A WIC pixel converter.</summary>
            WICPixelFormatConverter = 4,
            /// <summary>A WIC metadata reader.</summary>
            WICMetadataReader = 8,
            /// <summary>A WIC metadata writer.</summary>
            WICMetadataWriter = 16,
            /// <summary>A WIC pixel format.</summary>
            WICPixelFormat = 32,
            /// <summary>All WIC components.</summary>
            WICAllComponents = 63,
            /// <summary></summary>
            WICCOMPONENTTYPE_FORCE_DWORD = 2147483647,
        }
    }
}