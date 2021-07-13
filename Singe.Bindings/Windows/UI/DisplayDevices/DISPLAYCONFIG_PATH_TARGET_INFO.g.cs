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

    namespace UI.DisplayDevices
    {
        /// <summary>The DISPLAYCONFIG_PATH_TARGET_INFO structure contains target information for a single path.</summary>
        /// <remarks>
        /// <para>A DISPLAYCONFIG_PATH_TARGET_INFO structure is specified in the <b>targetInfo</b> member of a <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_info">DISPLAYCONFIG_PATH_INFO</a> structure.</para>
        /// <para>A target corresponds to the number of possible video outputs on a display adapter. This number, however, does not equate to the number of physical connectors on the display adapter. Each connector exposes a number of targets that includes backward compatibility with older connector technology. For example, a DVI connector exposes a DVI target, as well as a VGA target. A DisplayPort connector, which was introduced in 2006, exposes DisplayPort, HDMI, DVI, legacy TV, and VGA targets.</para>
        /// <para>The <b>statusFlags</b> member is set when you call the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-querydisplayconfig">QueryDisplayConfig</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-displayconfig_path_target_info#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct DISPLAYCONFIG_PATH_TARGET_INFO
        {
            /// <summary>The identifier of the adapter that the path is on.</summary>
            internal win32.System.SystemServices.LUID adapterId;
            /// <summary>The target identifier on the specified adapter that this path relates to.</summary>
            internal uint id;
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_PATH_TARGET_INFO._Anonymous_e__Union Anonymous;
            /// <summary>The target's connector type. For a list of possible values, see the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ne-wingdi-displayconfig_video_output_technology">DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY</a> enumerated type.</summary>
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
            /// <summary>A value that specifies the rotation of the target. For a list of possible values, see the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ne-wingdi-displayconfig_rotation">DISPLAYCONFIG_ROTATION</a> enumerated type.</summary>
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_ROTATION rotation;
            /// <summary>A value that specifies how the source image is scaled to the target. For a list of possible values, see the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ne-wingdi-displayconfig_scaling">DISPLAYCONFIG_SCALING</a> enumerated type. For more information about scaling, see <a href = "https://docs.microsoft.com/windows-hardware/drivers/display/scaling-the-desktop-image">Scaling the Desktop Image</a>.</summary>
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_SCALING scaling;
            /// <summary>A <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_rational">DISPLAYCONFIG_RATIONAL</a> structure that specifies the refresh rate of the target. If the caller specifies target mode information, the operating system will instead use the refresh rate that is stored in the <b>vSyncFreq</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_video_signal_info">DISPLAYCONFIG_VIDEO_SIGNAL_INFO</a> structure. In this case, the caller specifies this value in the <b>targetVideoSignalInfo</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_target_mode">DISPLAYCONFIG_TARGET_MODE</a> structure. A refresh rate with both the numerator and denominator set to zero indicates that the caller does not specify a refresh rate and the operating system should use the most optimal refresh rate available. For this case, in a call to the <a href = "https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setdisplayconfig">SetDisplayConfig</a> function, the caller must set the <b>scanLineOrdering</b> member to the DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED value; otherwise, <b>SetDisplayConfig</b> fails.</summary>
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_RATIONAL refreshRate;
            /// <summary>A value that specifies the scan-line ordering of the output on the target. For a list of possible values, see the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ne-wingdi-displayconfig_scanline_ordering">DISPLAYCONFIG_SCANLINE_ORDERING</a> enumerated type. If the caller specifies target mode information, the operating system will instead use the scan-line ordering that is stored in the <b>scanLineOrdering</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_video_signal_info">DISPLAYCONFIG_VIDEO_SIGNAL_INFO</a> structure. In this case, the caller specifies this value in the <b>targetVideoSignalInfo</b> member of the <a href = "https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_target_mode">DISPLAYCONFIG_TARGET_MODE</a> structure.</summary>
            internal win32.UI.DisplayDevices.DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
            /// <summary>
            /// <para>A Boolean value that specifies whether the target is available. <b>TRUE</b> indicates that the target is available.</para>
            /// <para>Because the asynchronous nature of display topology changes when a monitor is removed, a path might still be marked as active even though the monitor has been removed. In such a case, <b>targetAvailable</b> could be <b>FALSE</b> for an active path. This is typically a transient situation that will change after the operating system  takes action on the monitor removal.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-displayconfig_path_target_info#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL targetAvailable;
            /// <summary>A bitwise OR of flag values that indicates the status of the target. The following values are supported:</summary>
            internal uint statusFlags;
            [StructLayout(LayoutKind.Explicit)]
            internal partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                internal uint modeInfoIdx;
                [FieldOffset(0)]
                internal win32.UI.DisplayDevices.DISPLAYCONFIG_PATH_TARGET_INFO._Anonymous_e__Union._Anonymous_e__Struct Anonymous;
                internal partial struct _Anonymous_e__Struct
                {
                    internal uint _bitfield;
                }
            }
        }
    }
}