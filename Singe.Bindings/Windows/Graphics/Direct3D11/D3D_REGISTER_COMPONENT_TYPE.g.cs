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
        /// <summary>Values that identify the data types that can be stored in a register.</summary>
        /// <remarks>
        /// <para>A register component type is specified in the <b>ComponentType</b> member of the <a href = "https://docs.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_signature_parameter_desc">D3D11_SIGNATURE_PARAMETER_DESC</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3dcommon/ne-d3dcommon-d3d_register_component_type#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D_REGISTER_COMPONENT_TYPE
        {
            /// <summary>The data type is unknown.</summary>
            D3D_REGISTER_COMPONENT_UNKNOWN = 0,
            /// <summary>32-bit unsigned integer.</summary>
            D3D_REGISTER_COMPONENT_UINT32 = 1,
            /// <summary>32-bit signed integer.</summary>
            D3D_REGISTER_COMPONENT_SINT32 = 2,
            /// <summary>32-bit floating-point number.</summary>
            D3D_REGISTER_COMPONENT_FLOAT32 = 3,
            /// <summary>The data type is unknown.</summary>
            D3D10_REGISTER_COMPONENT_UNKNOWN = 0,
            /// <summary>32-bit unsigned integer.</summary>
            D3D10_REGISTER_COMPONENT_UINT32 = 1,
            /// <summary>32-bit signed integer.</summary>
            D3D10_REGISTER_COMPONENT_SINT32 = 2,
            /// <summary>32-bit floating-point number.</summary>
            D3D10_REGISTER_COMPONENT_FLOAT32 = 3,
        }
    }
}