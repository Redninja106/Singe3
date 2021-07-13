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

    namespace Graphics.Direct2D
    {
        /// <summary>Controls option flags for a new ID2D1ImageSource when it is created.</summary>
        /// <remarks>
        /// <para>D2D1_IMAGE_SOURCE_CREATION_OPTIONS_RELEASE_SOURCE causes the image source to not retain a reference to the source object used to create it. It can decrease the quality and efficiency of printing.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_image_source_loading_options#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        [Flags]
        internal enum D2D1_IMAGE_SOURCE_LOADING_OPTIONS : uint
        {
            /// <summary>No options are used.</summary>
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE = 0x00000000,
            /// <summary>
            /// <para>Indicates the image source should release its reference to the WIC bitmap source after it has initialized. By default, the image source retains a reference to the WIC bitmap source for the lifetime of the object to enable quality and speed optimizations for printing. This option disables that optimization.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_image_source_loading_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE = 0x00000001,
            /// <summary>
            /// <para>Indicates the image source should only populate subregions of the image cache on-demand. You can control this behavior using the <a href = "https://docs.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesourcefromwic-ensurecached(constd2d1_rect_u)">EnsureCached</a> and <a href = "https://docs.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesourcefromwic-trimcache(constd2d1_rect_u)">TrimCache</a> methods. This options provides the ability to improve memory usage by only keeping needed portions of the image in memory. This option requires that the image source has a reference to the WIC bitmap source, and is incompatible with D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/ne-d2d1_3-d2d1_image_source_loading_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND = 0x00000002,
            /// <summary></summary>
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD = 0xFFFFFFFF,
        }
    }
}