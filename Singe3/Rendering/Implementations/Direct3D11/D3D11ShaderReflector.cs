using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32.Graphics.Dxgi;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal sealed unsafe class D3D11ShaderReflector : ShaderReflection, IDisposable
    {
        D3D11Renderer renderer;
        ID3D11ShaderReflection* reflection;
        public D3D11ShaderReflector(D3D11Renderer renderer, ID3D11ShaderReflection* reflection)
        {
            this.renderer = renderer;
            this.reflection = reflection;
        }

        public override string[] GetInputTextureNames()
        {
            string[] result = new string[renderer.Info.MaxTextureCount];

            var descs = new List<D3D11_SHADER_INPUT_BIND_DESC>();
            D3D11_SHADER_INPUT_BIND_DESC desc;
            int i = 0;
            while (reflection->GetResourceBindingDesc((uint)i++, &desc).Succeeded)
            {
                descs.Add(desc);
            }
            
            foreach (var rsrc in descs)
            {
                result[rsrc.BindPoint] = Marshal.PtrToStringAnsi((IntPtr)rsrc.Name.Value);
            }

            return result;
        }

        public override string[] GetConstantBufferNames()
        {
            string[] result = new string[renderer.Info.MaxConstantBufferCount];

            for (int i = 0; i < result.Length; i++)
            {
                var cbuffer = reflection->GetConstantBufferByIndex((uint)i);

                if (cbuffer == null)
                    break;

                D3D11_SHADER_BUFFER_DESC desc;

                cbuffer->GetDesc(&desc);

                result[i] = Marshal.PtrToStringAnsi((IntPtr)desc.Name.Value);
            }

            return result;
        }

        public D3D11_INPUT_ELEMENT_DESC[] GetInputLayoutDesc()
        {
            var inputParameters = new List<D3D11_SIGNATURE_PARAMETER_DESC>();

            int i = 0;
            D3D11_SIGNATURE_PARAMETER_DESC desc;
            while (reflection->GetInputParameterDesc((uint)i++, &desc).Succeeded)
            {
                inputParameters.Add(desc);
            }


            var result = new D3D11_INPUT_ELEMENT_DESC[inputParameters.Count];

            for (i = 0; i < result.Length; i++)
            {
                var p = inputParameters[i];
                DXGI_FORMAT format;
                string formatString = "DXGI_FORMAT_";
                int bbp = 32;

                if (p.Mask > 0) formatString += "R" + bbp;
                if (p.Mask > 1) formatString += "G" + bbp;
                if (p.Mask > 3) formatString += "B" + bbp;
                if (p.Mask > 7) formatString += "A" + bbp;

                switch (p.ComponentType)
                {
                    case D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT32:
                        formatString += "_UINT";
                        break;
                    case D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT32:
                        formatString += "_SINT";
                        break;
                    case D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT32:
                        formatString += "_FLOAT";
                        break;
                    default:
                        break;
                }

                format = Enum.Parse<DXGI_FORMAT>(formatString, true);

                result[i] = new D3D11_INPUT_ELEMENT_DESC()
                { 
                    SemanticName = p.SemanticName,
                    SemanticIndex = p.SemanticIndex,
                    Format = format
                }; // p.SemanticName, p.SemanticIndex, format, 0);
            }

            return result;
        }

        public void Dispose()
        {
            reflection->Release();
        }
    }
}
