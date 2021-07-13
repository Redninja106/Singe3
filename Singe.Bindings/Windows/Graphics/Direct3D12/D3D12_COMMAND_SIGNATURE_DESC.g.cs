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
        /// <summary>Describes the arguments (parameters) of a command signature.</summary>
        /// <remarks>
        /// <para>Use this structure by <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommandsignature">CreateCommandSignature</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_command_signature_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_COMMAND_SIGNATURE_DESC
        {
            /// <summary>Specifies the size of each argument of a command signature, in bytes.</summary>
            internal uint ByteStride;
            /// <summary>Specifies the number of arguments in the command signature.</summary>
            internal uint NumArgumentDescs;
            /// <summary>
            /// <para>An array of <a href = "https://docs.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_indirect_argument_desc">D3D12_INDIRECT_ARGUMENT_DESC</a> structures, containing details of the arguments, including whether the argument is a vertex buffer, constant, constant buffer view, shader resource view, or unordered access view.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_command_signature_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC*pArgumentDescs;
            /// <summary>
            /// <para>For single GPU operation, set this to zero. If there are multiple GPU nodes, set bits to identify the nodes (the  device's physical adapters) for which the command signature is to apply. Each bit in the mask corresponds to a single node. Refer to <a href = "https://docs.microsoft.com/windows/win32/direct3d12/multi-engine">Multi-adapter systems</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_command_signature_desc#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint NodeMask;
        }
    }
}