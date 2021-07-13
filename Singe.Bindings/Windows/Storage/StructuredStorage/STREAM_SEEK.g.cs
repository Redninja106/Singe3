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

    namespace Storage.StructuredStorage
    {
        /// <summary>The STREAM_SEEK enumeration values specify the origin from which to calculate the new seek-pointer location.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ne-objidl-stream_seek">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum STREAM_SEEK : uint
        {
            /// <summary>The new seek pointer is an offset relative to the beginning of the stream. In this case, the <i>dlibMove</i> parameter is the new seek position relative to the beginning of the stream.</summary>
            STREAM_SEEK_SET = 0U,
            /// <summary>The new seek pointer is an offset relative to the current seek pointer location. In this case, the <i>dlibMove</i> parameter is the signed displacement from the current seek position.</summary>
            STREAM_SEEK_CUR = 1U,
            /// <summary>The new seek pointer is an offset relative to the end of the stream. In this case, the <i>dlibMove</i> parameter is the new seek position relative to the end of the stream.</summary>
            STREAM_SEEK_END = 2U,
        }
    }
}