using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;
using Singe3.Internal.Interop;
using System.Runtime.InteropServices;
using Windows.Win32.Graphics.Dxgi;
using Windows.Win32;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal static unsafe class D3D11Util
    {
        public static D3D11VertexShader GetAsD3D11(this IVertexShader shader)
        {
            return (D3D11VertexShader)shader;
        }

        public static DXGI_FORMAT ToD3D11(this DataFormat format)
        {
            switch (format)
            {
                case DataFormat.R8G8B8A8:
                    return DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                case DataFormat.R32G32B32A32:
                    return DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT;
                case DataFormat.R32G32B32:
                    return DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT;
                case DataFormat.R32G32:
                    return DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT;
                case DataFormat.R32:
                    return DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT;
                default:
                    return DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;
            }
        }
    }
}
