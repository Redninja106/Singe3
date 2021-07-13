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
        /// <summary>Specifies the type of a raytracing hit group state subobject. Use a value from this enumeration with the D3D12_HIT_GROUP_DESC structure.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_hit_group_type">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_HIT_GROUP_TYPE
        {
            /// <summary>The hit group uses a list of triangles to calculate ray hits. Hit groups that use triangles can’t contain an intersection shader.</summary>
            D3D12_HIT_GROUP_TYPE_TRIANGLES = 0,
            /// <summary>The hit group uses a procedural primitive within a bounding box to calculate ray hits. Hit groups that use procedural primitives must contain an intersection shader.</summary>
            D3D12_HIT_GROUP_TYPE_PROCEDURAL_PRIMITIVE = 1,
        }
    }
}