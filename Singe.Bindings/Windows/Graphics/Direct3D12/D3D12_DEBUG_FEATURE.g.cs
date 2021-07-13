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
        /// <summary>Flags for optional D3D12 Debug Layer features.</summary>
        /// <remarks>
        /// <para>This enum is used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-setdebugparameter">ID3D12DebugDevice1::SetDebugParameter</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-getdebugparameter">ID3D12DebugDevice1::GetDebugParameter</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/ne-d3d12sdklayers-d3d12_debug_feature#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_DEBUG_FEATURE
        {
            /// <summary>The default. No optional Debug Layer features.</summary>
            D3D12_DEBUG_FEATURE_NONE = 0,
            /// <summary>The Debug Layer is allowed to deliberately change functional behavior of an application in order to help identify potential errors.  By default, the Debug Layer allows most invalid API usage to run the natural course.</summary>
            D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS = 1,
            /// <summary>Performs additional resource state validation of resources set in descriptors at the time <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12commandqueue-executecommandlists">ID3D12CommandQueue::ExecuteCommandLists</a> is called.  By design descriptors can be changed even after submitting command lists assuming proper synchronization.  Conservative resource state tracking ignores this allowance and validates all resources used in descriptor tables when <b>ExecuteCommandLists</b> is called.  The result may be false validation errors.</summary>
            D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING = 2,
            /// <summary>Disables validation of bundle commands by virtually injecting checks into the calling command list validation paths.</summary>
            D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION = 4,
            D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7 = 8,
        }
    }
}