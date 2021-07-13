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
        /// <summary>Specifies the mode used by a WriteBufferImmediate operation.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_writebufferimmediate_mode">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_WRITEBUFFERIMMEDIATE_MODE
        {
            /// <summary>The write operation behaves the same as normal copy-write operations.</summary>
            D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT = 0,
            /// <summary>The write operation is guaranteed to occur after all preceding commands in the command stream have started, including previous <b>WriteBufferImmediate</b> operations.</summary>
            D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN = 1,
            /// <summary>The write operation is deferred until all previous commands in the command stream have completed through the GPU pipeline, including previous <b>WriteBufferImmediate</b> operations. Write operations that specify <b>D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT</b> don't block subsequent operations from starting. If there are no previous operations in the command stream, then the write operation behaves as if <b>D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN</b> was specified.</summary>
            D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT = 2,
        }
    }
}