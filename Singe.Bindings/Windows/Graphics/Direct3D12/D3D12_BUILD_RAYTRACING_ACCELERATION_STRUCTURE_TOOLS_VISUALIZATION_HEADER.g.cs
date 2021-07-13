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
        /// <summary>Describes the GPU memory layout of an acceleration structure visualization.</summary>
        /// <remarks>
        /// <para>This structure functions like the inverse of the inputs to an acceleration structure build, focused on the instance or geometry details, depending on the acceleration structure type.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_tools_visualization_header#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_TOOLS_VISUALIZATION_HEADER
        {
            /// <summary>The type of acceleration structure.</summary>
            internal win32.Graphics.Direct3D12.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
            /// <summary>The number of descriptions.</summary>
            internal uint NumDescs;
        }
    }
}