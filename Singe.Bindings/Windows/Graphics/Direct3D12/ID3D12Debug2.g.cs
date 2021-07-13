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
        [Guid("93A665C4-A3B2-4E5D-B692-A26AE14E3374")]
        internal unsafe struct ID3D12Debug2
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
                fixed (ID3D12Debug2*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12Debug2*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12Debug2*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>This method configures the level of GPU-based validation that the debug device is to perform at runtime.</summary>
            /// <param name = "Flags">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_flags">D3D12_GPU_BASED_VALIDATION_FLAGS</a></b></para>
            /// <para>Specifies the level of GPU-based validation to perform at runtime.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug2-setgpubasedvalidationflags#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>This method overrides the default behavior of GPU-based validation so it must be called before creating the Direct3D 12 device. These settings can't be changed or cancelled after the device is created. If you want to change the behavior of GPU-based validation at a later time, the device must be destroyed and recreated with different parameters.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12sdklayers/nf-d3d12sdklayers-id3d12debug2-setgpubasedvalidationflags#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void SetGPUBasedValidationFlags(win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
            {
                fixed (ID3D12Debug2*pThis = &this)
                    lpVtbl->SetGPUBasedValidationFlags_4(pThis, Flags);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12Debug2*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug2*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug2*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12Debug2*, win32.Graphics.Direct3D12.D3D12_GPU_BASED_VALIDATION_FLAGS, void>SetGPUBasedValidationFlags_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}