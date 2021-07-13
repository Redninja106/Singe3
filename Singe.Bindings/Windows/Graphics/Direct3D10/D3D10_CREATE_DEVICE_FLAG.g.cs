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
        /// <summary>Device creation flags.</summary>
        /// <remarks>
        /// <para>Device creation flags are used by <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10misc/nf-d3d10misc-d3d10createdevice">D3D10CreateDevice</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10misc/nf-d3d10misc-d3d10createdeviceandswapchain">D3D10CreateDeviceAndSwapChain</a>.</para>
        /// <para>An application might dynamically create (and destroy) threads to improve performance especially on a machine with multiple CPU cores. There may be cases, however, when an application needs to prevent extra threads from being created. This can happen when you want to simplify debugging, profile code or develop a tool for instance. For these cases, use D3D10_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS to request that the runtime and video driver not create any additional threads that might interfere with the application.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_CREATE_DEVICE_FLAG
        {
            /// <summary>
            /// <para>Use this flag if an application will only be calling D3D10 from a single thread. If this flag is not specified, the default behavior of D3D10 is to enter a lock during each API call to prevent multiple threads altering internal state. By using this flag no locks will be taken which can slightly increase performance, but could result in undefine behavior if D3D10 is called from multiple threads.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_SINGLETHREADED = 1,
            /// <summary>Create a device that supports the <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-api-features-layers">debug layer</a>.</summary>
            D3D10_CREATE_DEVICE_DEBUG = 2,
            /// <summary>
            /// <para>Create both a software (REF) and hardware (HAL) version of the device simultaneously, which allows an application to switch to a reference device to enable debugging. See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10sdklayers/nn-d3d10sdklayers-id3d10switchtoref">ID3D10SwitchToRef Interface</a> for more information.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_SWITCH_TO_REF = 4,
            /// <summary>
            /// <para>Prevents multiple threads from being created. When this flag is used with a WARP device, no additional threads will be created by WARP and all rasterization will occur on the calling thread. This flag is not recommended for general use. See remarks.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 8,
            /// <summary>
            /// <para>Return a <b>NULL</b> pointer instead of triggering an exception on memory exhaustion during invocations to Map. Without this flag an exception will be raised on memory exhaustion.  Only valid on Winodws 7.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_ALLOW_NULL_FROM_MAP = 16,
            /// <summary>
            /// <para>Causes device creation to fail if BGRA support is not available.</para>
            /// <para>BGRA support enables the following formats.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_BGRA_SUPPORT = 32,
            /// <summary>
            /// <para>Causes the Direct3D runtime to ignore registry settings that turn on the <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-api-features-layers">debug layer</a>. You can turn on the debug layer by using the <a href = "https://docs.microsoft.com/previous-versions/bb219725(v=vs.85)">DirectX Control Panel</a> that was included as part of the DirectX SDK. We shipped the last version of the DirectX SDK in June 2010; you can download it from the <a href = "https://www.microsoft.com/download/en/details.aspx?id=6812">Microsoft Download Center</a>. You can set this flag in your app, typically in release builds only, to prevent end users from using the <a href = "https://docs.microsoft.com/previous-versions/bb219725(v=vs.85)">DirectX Control Panel</a> to monitor how the app uses Direct3D.</para>
            /// <para><div class = "alert"><b>Note</b>  You can also set this flag in your app to prevent Direct3D debugging tools, such as Visual Studio Ultimate 2012, from hooking your app.</div> <div> </div> <b>Windows 8.1:  </b>This flag doesn't prevent Visual Studio 2013 and later running on Windows 8.1 and later from hooking your app. But, this flag still prevents Visual Studio 2013 and later running on Windows 8 and earlier from hooking your app.</para>
            /// <para><b>Direct3D 11:  </b>This value is not supported until Direct3D 11.1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 128,
            /// <summary>Reserved. This flag is currently not supported. Do not use.</summary>
            D3D10_CREATE_DEVICE_STRICT_VALIDATION = 512,
            /// <summary>
            /// <para>Causes the device and driver to keep information that you can use for shader debugging.  The exact impact from this flag will vary from driver to driver.  To use this flag, you must have D3D11_1SDKLayers.dll installed; otherwise, device creation fails. The created device supports the <a href = "https://docs.microsoft.com/windows/desktop/direct3d10/d3d10-graphics-programming-guide-api-features-layers">debug layer</a>. To get D3D11_1SDKLayers.dll, you must install the SDK for Windows 8.</para>
            /// <para><b>Direct3D 11:  </b>This value is not supported until Direct3D 11.1.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_create_device_flag#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            D3D10_CREATE_DEVICE_DEBUGGABLE = 1024,
        }
    }
}