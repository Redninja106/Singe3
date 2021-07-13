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

    namespace Graphics.Direct3D11
    {
        [Guid("03916615-C644-418C-9BF4-75DB5BE63CA0")]
        internal unsafe struct ID3D11RefDefaultTrackingOptions
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
                fixed (ID3D11RefDefaultTrackingOptions*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11RefDefaultTrackingOptions*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11RefDefaultTrackingOptions*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Sets graphics processing unit (GPU) debug reference default tracking options for specific resource types.</summary>
            /// <param name = "ResourceTypeFlags">A <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11sdklayers/ne-d3d11sdklayers-d3d11_shader_tracking_resource_type">D3D11_SHADER_TRACKING_RESOURCE_TYPE</a>-typed value that specifies the type of resource to track.</param>
            /// <param name = "Options">A combination of <a href = "https://docs.microsoft.com/windows/win32/api/d3d11sdklayers/ne-d3d11sdklayers-d3d11_shader_tracking_options">D3D11_SHADER_TRACKING_OPTIONS</a>-typed flags that are combined by using a bitwise <b>OR</b> operation. The resulting value identifies tracking options. If a flag is present, the tracking option that the flag represents is set to "on"; otherwise the tracking option is set to "off."</param>
            /// <returns>This method returns one of the <a href = "/windows/desktop/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 return codes</a>.</returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11sdklayers/nf-d3d11sdklayers-id3d11refdefaulttrackingoptions-settrackingoptions">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options)
            {
                fixed (ID3D11RefDefaultTrackingOptions*pThis = &this)
                    return lpVtbl->SetTrackingOptions_4(pThis, ResourceTypeFlags, Options);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11RefDefaultTrackingOptions*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11RefDefaultTrackingOptions*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11RefDefaultTrackingOptions*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11RefDefaultTrackingOptions*, uint, uint, win32.System.Com.HRESULT>SetTrackingOptions_4;
            }

            private Vtbl*lpVtbl;
        }
    }
}