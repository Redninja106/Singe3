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
        /// <summary>Specifies the type of shader patching used by GPU-Based Validation at either the device or command list level.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_debug_device_gpu_based_validation_settings">D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS</a> structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_shader_patch_mode#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE
        {
            /// <summary>No shader patching is to be done.  This will retain the original shader bytecode.  Can lead to errors in some of the GPU-Based Validation state tracking as the unpatched shader may still change resource state (see <a href = "https://docs.microsoft.com/windows/desktop/direct3d12/using-resource-barriers-to-synchronize-resource-states-in-direct3d-12">Common state promotion</a>) but the promotion will be untracked without patching the shader.  This can improve performance but no validation will be performed and may also lead to misleading GPU-Based Validation errors. Use this mode very carefully.</summary>
            D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE = 0,
            /// <summary>Shaders can be patched with resource state tracking code but no validation.  This may improve performance but no validation will be performed.</summary>
            D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY = 1,
            /// <summary>The default. Shaders are patched with validation code but erroneous instructions will still be executed.</summary>
            D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION = 2,
            /// <summary>Shaders are patched with validation code and erroneous instructions are skipped in execution.  This can help avoid crashes or device removal.</summary>
            D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION = 3,
            /// <summary>Unused, simply the count of the number of modes.</summary>
            NUM_D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODES = 4,
        }
    }
}