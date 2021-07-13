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
        /// <summary>Describes settings used by GPU-Based Validation.</summary>
        /// <remarks>
        /// <para>Point to an object using this structure with the <i>pData</i> member of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-setdebugparameter">ID3D12DebugDevice1::SetDebugParameter</a> to configure device-wide GPU-Based Validation settings.</para>
        /// <para>Individual command lists can override the default shader patch mode using <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist1-setdebugparameter">ID3D12DebugCommandList1::SetDebugParameter</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/ns-d3d12sdklayers-d3d12_debug_device_gpu_based_validation_settings#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS
        {
            /// <summary>Specifies a UINT that limits the number of messages that can be stored in the GPU-Based Validation message log.  The default value is 256.  Since many identical errors can be produced in a single Draw/Dispatch call it may be useful to increase this number.  Note this can become a memory burden if a large number of command lists are used as there is a committed message log per command list.</summary>
            internal uint MaxMessagesPerCommandList;
            /// <summary>Specifies the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_shader_patch_mode">D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE</a> that GPU-Based Validation uses when injecting validation code into shaders, except when overridden by per-command-list GPU-Based Validation settings (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_debug_command_list_gpu_based_validation_settings">D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS</a>).  The default value is D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION.</summary>
            internal win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE DefaultShaderPatchMode;
            /// <summary>Specifies one of the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_pipeline_state_create_flags">D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS</a> that indicates how GPU-Based Validation handles patching pipeline states.  The default value is D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_NONE.</summary>
            internal win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS PipelineStateCreateFlags;
        }
    }
}