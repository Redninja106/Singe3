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
        [Guid("9B7E4E01-342C-4106-A19F-4F2704F689F0")]
        internal unsafe struct ID3D10Debug
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
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Set a bitfield of flags that will turn debug features on and off.</summary>
            /// <param name = "Mask">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Feature-mask flags bitwise ORed together. If a flag is present, then that feature will be set to on, otherwise the feature will be set to off. See remarks for a list of flags.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setfeaturemask#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setfeaturemask">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetFeatureMask(uint Mask)
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->SetFeatureMask_4(pThis, Mask);
            }

            /// <summary>Get a bitfield of flags that indicates which debug features are on or off.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Mask of feature-mask flags bitwise ORed together. If a flag is present, then that feature will be set to on, otherwise the feature will be set to off. See <a href = "/windows/desktop/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setfeaturemask">ID3D10Debug::SetFeatureMask</a> for a list of possible feature-mask flags.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getfeaturemask">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetFeatureMask()
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->GetFeatureMask_5(pThis);
            }

            /// <summary>Set the number of milliseconds to sleep after Present is called.</summary>
            /// <param name = "Milliseconds">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of milliseconds to sleep after Present is called.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setpresentperrenderopdelay#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setpresentperrenderopdelay">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetPresentPerRenderOpDelay(uint Milliseconds)
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->SetPresentPerRenderOpDelay_6(pThis, Milliseconds);
            }

            /// <summary>Get the number of milliseconds to sleep after Present is called.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Number of milliseconds to sleep after Present is called.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getpresentperrenderopdelay">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetPresentPerRenderOpDelay()
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->GetPresentPerRenderOpDelay_7(pThis);
            }

            /// <summary>Set a swap chain that the runtime will use for automatically calling Present.</summary>
            /// <param name = "pSwapChain">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain">IDXGISwapChain</a>*</b></para>
            /// <para>Swap chain that the runtime will use for automatically calling <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgiswapchain-present">Present</a>; must have been created with the <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgifactory-createswapchain">DXGI_SWAP_EFFECT_SEQUENTIAL</a> swap-effect flag.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setswapchain#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setswapchain">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetSwapChain([Optional] win32.Graphics.Dxgi.IDXGISwapChain*pSwapChain)
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->SetSwapChain_8(pThis, pSwapChain);
            }

            /// <summary>Get the swap chain that the runtime will use for automatically calling Present.</summary>
            /// <param name = "ppSwapChain">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain">IDXGISwapChain</a>**</b></para>
            /// <para>Swap chain that the runtime will use for automatically calling <a href = "https://docs.microsoft.com/windows/desktop/api/dxgi/nf-dxgi-idxgiswapchain-present">Present</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getswapchain#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getswapchain">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetSwapChain(win32.Graphics.Dxgi.IDXGISwapChain**ppSwapChain)
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->GetSwapChain_9(pThis, ppSwapChain);
            }

            /// <summary>Check the validity of pipeline state.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the following <a href = "/windows/desktop/direct3d10/d3d10-graphics-reference-returnvalues">Direct3D 10 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-validate">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT Validate()
            {
                fixed (ID3D10Debug*pThis = &this)
                    return lpVtbl->Validate_10(pThis);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint, win32.System.Com.HRESULT>SetFeatureMask_4;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint>GetFeatureMask_5;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint, win32.System.Com.HRESULT>SetPresentPerRenderOpDelay_6;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, uint>GetPresentPerRenderOpDelay_7;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, win32.Graphics.Dxgi.IDXGISwapChain*, win32.System.Com.HRESULT>SetSwapChain_8;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, win32.Graphics.Dxgi.IDXGISwapChain**, win32.System.Com.HRESULT>GetSwapChain_9;
                internal delegate *unmanaged[Stdcall]<ID3D10Debug*, win32.System.Com.HRESULT>Validate_10;
            }

            private Vtbl*lpVtbl;
        }
    }
}