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
        [Guid("5CF4E58F-F671-4FF1-A542-3686E3D153D1")]
        internal unsafe struct ID3D12Debug3
        {
            /// <inheritdoc cref = "QueryInterface(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT QueryInterface(in global::System.Guid riid, out void *ppvObject)
            {
                fixed (void **ppvObjectLocal = &ppvObject)
                {
                    fixed (global::System.Guid*riidLocal = &riid)
                    {
                        win32.System.Com.HRESULT __result = this.QueryInterface(riidLocal, ppvObjectLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT QueryInterface(global::System.Guid*riid, void **ppvObject)
            {
                fixed (ID3D12Debug3*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12Debug3*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12Debug3*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal void EnableDebugLayer()
            {
                fixed (ID3D12Debug3*pThis = &this)
                    lpVtbl->EnableDebugLayer_4(pThis);
            }

            /// <summary>This method enables or disables GPU-based validation (GBV) before creating a device with the debug layer enabled.</summary>
            /// <param name = "Enable">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>TRUE to enable GPU-based validation, otherwise FALSE.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablegpubasedvalidation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>GPU-based validation can be enabled/disabled only prior to creating a device. By default, GPU-based validation is disabled. To disable GPU-based validation after initially enabling it, the device must be fully released and recreated.</para>
            /// <para>For more information, see <a href = "https://docs.microsoft.com/windows/win32/direct3d12/using-d3d12-debug-layer-gpu-based-validation">Using D3D12 Debug Layer GPU-based validation</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablegpubasedvalidation#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetEnableGPUBasedValidation(win32.System.SystemServices.BOOL Enable)
            {
                fixed (ID3D12Debug3*pThis = &this)
                    lpVtbl->SetEnableGPUBasedValidation_5(pThis, Enable);
            }

            /// <summary>Enables or disables dependent command queue synchronization when using a Direct3D 12 device with the debug layer enabled.</summary>
            /// <param name = "Enable">
            /// <para>Type: <b>BOOL</b></para>
            /// <para>TRUE to enable Dependent Command Queue Synchronization, otherwise FALSE.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablesynchronizedcommandqueuevalidation#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>Dependent Command Queue Synchronization is a D3D12 Debug Layer feature that gives the debug layer the ability to track resource states more accurately when enabled. Dependent Command Queue Synchronization is enabled by default.</para>
            /// <para>When Dependent Command Queue Synchronization is enabled, the debug layer holds back actual submission of GPU work until all outstanding fence <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12commandqueue-wait">Wait</a> conditions are met. This gives the debug layer the ability to make reasonable assumptions about GPU state (such as resource states) on the CPU-timeline when multiple command queues are potentially doing concurrent work.</para>
            /// <para>With Dependent Command Queue Synchronization disabled, all resource states tracked by the debug layer are cleared each time <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12commandqueue-signal">ID3D12CommandQueue::Signal</a> is called. This results in significantly less useful resource state validation.</para>
            /// <para>Disabling Dependent Command Queue Synchronization may reduce some debug layer performance overhead when using multiple command queues. However, it is suggested to leave it enabled unless this overhead is problematic. Note that applications that use only a single command queue will see no performance changes with Dependent Command Queue Synchronization disabled.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablesynchronizedcommandqueuevalidation#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetEnableSynchronizedCommandQueueValidation(win32.System.SystemServices.BOOL Enable)
            {
                fixed (ID3D12Debug3*pThis = &this)
                    lpVtbl->SetEnableSynchronizedCommandQueueValidation_6(pThis, Enable);
            }

            /// <summary>This method configures the level of GPU-based validation that the debug device is to perform at runtime.</summary>
            /// <param name = "Flags">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_flags">D3D12_GPU_BASED_VALIDATION_FLAGS</a></b></para>
            /// <para>Specifies the level of GPU-based validation to perform at runtime.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setgpubasedvalidationflags#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>This method overrides the default behavior of GPU-based validation so it must be called before creating the D3D12 Device. These settings can't be changed or cancelled after the device is created. If you want to change the behavior of GPU-based validation at a later time, the device must be destroyed and recreated with different parameters.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setgpubasedvalidationflags#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetGPUBasedValidationFlags(win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
            {
                fixed (ID3D12Debug3*pThis = &this)
                    lpVtbl->SetGPUBasedValidationFlags_7(pThis, Flags);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, void>EnableDebugLayer_4;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, win32.System.SystemServices.BOOL, void>SetEnableGPUBasedValidation_5;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, win32.System.SystemServices.BOOL, void>SetEnableSynchronizedCommandQueueValidation_6;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug3*, win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_FLAGS, void>SetGPUBasedValidationFlags_7;
            }

            private Vtbl*lpVtbl;
        }
    }
}