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
        /// <summary>A state subobject that represents a raytracing pipeline configuration.</summary>
        /// <remarks>
        /// <para>A raytracing pipeline needs one raytracing pipeline configuration.  If multiple pipeline configurations are present they must all match in content.  There is no benefit to such duplication.  For example defining it once per collection doesn’t help drivers do early shader compilation before a raytracing pipeline is created.  This is unlike <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_raytracing_shader_config">D3D12_RAYTRACING_SHADER_CONFIG</a> which does benefit from duplication per collection.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ns-d3d12-d3d12_raytracing_pipeline_config#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_RAYTRACING_PIPELINE_CONFIG
        {
            /// <summary>Limit on ray recursion for the raytracing pipeline. It must be in the range of 0 to 31. Below the maximum recursion depth, shader invocations such as closest hit or miss shaders can call <b>TraceRay</b> any number of times.  At the maximum recursion depth, <b>TraceRay</b> calls result in the device going into removed state.</summary>
            internal uint MaxTraceRecursionDepth;
        }
    }
}