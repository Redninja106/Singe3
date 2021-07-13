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

    namespace Graphics.Direct3D10
    {
        /// <summary>Specifies the elements from a buffer resource to use in a render-target view.</summary>
        /// <remarks>
        /// <para>A render-target view is a member of a render-target-view description (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_render_target_view_desc">D3D10_RENDER_TARGET_VIEW_DESC</a>). Create a render-target view by calling <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10device-createrendertargetview">ID3D10Device::CreateRenderTargetView</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ns-d3d10-d3d10_buffer_rtv#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D10_BUFFER_RTV
        {
            internal win32.Graphics.Direct3D10.D3D10_BUFFER_RTV._Anonymous1_e__Union Anonymous1;
            internal win32.Graphics.Direct3D10.D3D10_BUFFER_RTV._Anonymous2_e__Union Anonymous2;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous1_e__Union
            {
                [FieldOffset(0)]
                internal uint FirstElement;
                [FieldOffset(0)]
                internal uint ElementOffset;
            }

            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous2_e__Union
            {
                [FieldOffset(0)]
                internal uint NumElements;
                [FieldOffset(0)]
                internal uint ElementWidth;
            }
        }
    }
}