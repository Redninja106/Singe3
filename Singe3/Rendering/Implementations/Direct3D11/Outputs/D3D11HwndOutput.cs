using Singe3.Platforms;
using Singe3.Platforms.Implementations.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Buffers;
using static Singe3.InteropUtils;
using Singe3.Internal.Interop;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32.Graphics.Dxgi;
using Windows.Win32.System.Com;
using Windows.Win32;
using Windows.Win32.System.SystemServices;

namespace Singe3.Rendering.Implementations.Direct3D11.Outputs
{
    internal sealed unsafe class D3D11HwndOutput : IRenderingOutput, IDisposable
    {
        readonly HwndManager HwndManager;
        readonly D3D11Renderer renderer;
        readonly D3D11Texture rt;
        readonly IDXGISwapChain1* pSwapchain;

        public D3D11HwndOutput(D3D11Renderer renderer, HwndManager hwndManager)
        {
            this.renderer = renderer;
            this.HwndManager = hwndManager;
            
            hwndManager.SizeChanged += OnSizeChanged;
            
            var device = renderer.GetDevice();
            
            IDXGIDevice* dxgidev;
            var guid = GetGuid<IDXGIDevice>();
            device->QueryInterface(&guid, (void**)&dxgidev).ThrowOnFailure();
            
            IDXGIAdapter* adapter;
            dxgidev->GetAdapter(&adapter).ThrowOnFailure();
            
            IDXGIFactory2* factory;
            adapter->GetParent(GetGuidPtr<IDXGIFactory2>(), (void**)&factory).ThrowOnFailure();

            adapter->Release();

            var size = hwndManager.GetSize();

            var swapDesc = new DXGI_SWAP_CHAIN_DESC1
            {
                AlphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_IGNORE,
                BufferCount = 2,
                BufferUsage = Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT | Constants.DXGI_USAGE_BACK_BUFFER,
                Flags = 0,
                Format = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                Height = (uint)size.Height,
                SampleDesc = new DXGI_SAMPLE_DESC
                {
                    Count = 1,
                    Quality = 0,
                },
                Scaling = DXGI_SCALING.DXGI_SCALING_NONE,
                Stereo = new BOOL(false),
                SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL,
                Width = (uint)size.Width,
            };

            IUnknown* deviceUnknown;
            device->QueryInterface(GetGuidPtr<IUnknown>(), (void**)&deviceUnknown).ThrowOnFailure();

            fixed (IDXGISwapChain1** ppSwapchain = &this.pSwapchain)
                factory->CreateSwapChainForHwnd(deviceUnknown, hwndManager.GetHwnd(), &swapDesc, null, null, ppSwapchain).ThrowOnFailure();

            ID3D11Texture2D* pBackBuffer;
            pSwapchain->GetBuffer(0, GetGuidPtr<ID3D11Texture2D>(), (void**)&pBackBuffer).ThrowOnFailure();
            rt = new D3D11Texture(renderer, pBackBuffer);
        }

        private void OnSizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            
            DestroyRenderTarget();
            
            pSwapchain->ResizeBuffers(0, (uint)e.NewSize.Width, (uint)e.NewSize.Height, 0, 0).ThrowOnFailure();
            
            CreateRenderTarget();
        }

        public void CreateRenderTarget()
        {
            ID3D11Texture2D* t;
            pSwapchain->GetBuffer(0, GetGuidPtr<ID3D11Texture2D>(), (void**)&t);
            rt.SetInternalTexture(t);
        }

        public void DestroyRenderTarget()
        {
            rt.SetInternalTexture(null);
        }

        public void Dispose()
        {
            pSwapchain->Release();
            rt.Dispose();
        }

        public GraphicsApi GetGraphicsApi()
        {
            return GraphicsApi.Direct3D11;
        }

        public Texture GetRenderTarget()
        {
            return this.rt;
        }

        public void Present(int vsync)
        {
            DXGI_PRESENT_PARAMETERS parameters = new DXGI_PRESENT_PARAMETERS
            {

            };
            pSwapchain->Present1((uint)vsync, 0, &parameters);
        }
    }
}
