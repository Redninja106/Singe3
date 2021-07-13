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
        /// <summary>Defines general properties of a state object.</summary>
        /// <remarks>
        /// <para>The presence of this subobject in a state object is optional.  If present, all exports in the state object must be associated with the same subobject (or one with a matching definition).  This consistency requirement does not apply across existing collections that are included in a larger state object.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_state_object_config#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_STATE_OBJECT_CONFIG
        {
            /// <summary>A value from the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_state_object_flags">D3D12_STATE_OBJECT_FLAGS</a> flags enumeration that specifies the requirements for the state object.</summary>
            internal win32.Graphics.Direct3D12.D3D12_STATE_OBJECT_FLAGS Flags;
        }
    }
}