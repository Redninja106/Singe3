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
        /// <summary>Describes an indirect argument (an indirect parameter), for use with a command signature.</summary>
        /// <remarks>
        /// <para>Use this structure with the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_command_signature_desc">D3D12_COMMAND_SIGNATURE_DESC</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_indirect_argument_desc#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_INDIRECT_ARGUMENT_DESC
        {
            /// <summary>A single <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_indirect_argument_type">D3D12_INDIRECT_ARGUMENT_TYPE</a> enumeration constant.</summary>
            internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_TYPE Type;
            internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union Anonymous;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union._VertexBuffer_e__Struct VertexBuffer;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union._Constant_e__Struct Constant;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union._ConstantBufferView_e__Struct ConstantBufferView;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union._ShaderResourceView_e__Struct ShaderResourceView;
                [FieldOffset(0)]
                internal win32.Graphics.Direct3D12.D3D12_INDIRECT_ARGUMENT_DESC._Anonymous_e__Union._UnorderedAccessView_e__Struct UnorderedAccessView;
                internal partial struct _VertexBuffer_e__Struct
                {
                    internal uint Slot;
                }

                internal partial struct _Constant_e__Struct
                {
                    internal uint RootParameterIndex;
                    internal uint DestOffsetIn32BitValues;
                    internal uint Num32BitValuesToSet;
                }

                internal partial struct _ConstantBufferView_e__Struct
                {
                    internal uint RootParameterIndex;
                }

                internal partial struct _ShaderResourceView_e__Struct
                {
                    internal uint RootParameterIndex;
                }

                internal partial struct _UnorderedAccessView_e__Struct
                {
                    internal uint RootParameterIndex;
                }
            }
        }
    }
}