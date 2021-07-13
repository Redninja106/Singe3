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
        /// <summary>Categories of debug messages.</summary>
        /// <remarks>
        /// <para>This is part of the Information Queue feature. See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11infoqueue">ID3D11InfoQueue Interface</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11sdklayers/ne-d3d11sdklayers-d3d11_message_category#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D11_MESSAGE_CATEGORY
        {
            /// <summary>User defined message. See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-addmessage">ID3D11InfoQueue::AddMessage</a>.</summary>
            D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED = 0,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_MISCELLANEOUS = 1,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_INITIALIZATION = 2,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_CLEANUP = 3,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_COMPILATION = 4,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_STATE_CREATION = 5,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_STATE_SETTING = 6,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_STATE_GETTING = 7,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION = 8,
            /// <summary></summary>
            D3D11_MESSAGE_CATEGORY_EXECUTION = 9,
            /// <summary><b>Direct3D 11:  </b>This value is not supported until Direct3D 11.1.</summary>
            D3D11_MESSAGE_CATEGORY_SHADER = 10,
        }
    }
}