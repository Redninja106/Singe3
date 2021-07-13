using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Singe3.Internal.Interop;
using Windows.Win32;
using Windows.Win32.Graphics.Direct3D11;
using Windows.Win32.Graphics.Dxgi;

namespace Singe3.Rendering.Implementations.Direct3D11
{
    internal sealed unsafe class D3D11Mesh : Mesh
    {
        internal ID3D11Buffer* pVertexBuffer;
        internal ID3D11Buffer* pIndexBuffer;

        private PrimitiveType primitiveType;

        private int vertsCount;
        private int vertexSize;
        private int indsCount;

        private readonly D3D11Renderer renderer;

        public unsafe D3D11Mesh(D3D11Renderer renderer)
        {
            this.renderer = renderer;
        }

        public override void Dispose()
        {
            pVertexBuffer->Release();
            
            if (pIndexBuffer != null)
                pIndexBuffer->Release();
        }

        internal unsafe void CreateVertexBuffer<T>(T[] verts) where T : unmanaged
        {
            verts = verts ?? throw new ArgumentNullException(nameof(verts));

			var desc = new D3D11_BUFFER_DESC
			{
				ByteWidth = (uint)(sizeof(T) * verts.Length),
				BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_VERTEX_BUFFER,
				Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT,
				StructureByteStride = (uint)sizeof(T)
			};

			fixed (ID3D11Buffer** ppVertexBuffer = &pVertexBuffer)
                renderer.GetDevice()->CreateBuffer(&desc, null, ppVertexBuffer).ThrowOnFailure();

            vertsCount = verts.Length;
            vertexSize = sizeof(T);
        }

        internal void CreateIndexBuffer(uint[] indices)
        {
            indices = indices ?? throw new ArgumentNullException(nameof(indices));

			var desc = new D3D11_BUFFER_DESC
			{
				ByteWidth = (uint)(sizeof(uint) * indices.Length),
				BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_INDEX_BUFFER,
				Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT,
				StructureByteStride = sizeof(uint)
			};

			fixed (ID3D11Buffer** ppIndexBuffer = &pIndexBuffer)
                renderer.GetDevice()->CreateBuffer(&desc, null, ppIndexBuffer).ThrowOnFailure();
            
            indsCount = indices.Length;
        }

        public override void SetVertices<T>(T[] verts)
        {
            if (verts.Length != vertsCount)
                CreateVertexBuffer(verts);
            
            fixed (T* pVerts = verts)
                renderer.GetContext()->UpdateSubresource((ID3D11Resource*)pVertexBuffer, 0, (D3D11_BOX*)null, pVerts, 0, 0);
        }

        public override void SetIndices(uint[] indices)
        {
            if (indices.Length != indsCount)
                CreateIndexBuffer(indices);

            fixed (uint* pIndices = indices)
                renderer.GetContext()->UpdateSubresource((ID3D11Resource*)pIndexBuffer, 0, (D3D11_BOX*)null, pIndices, 0, 0);
        }

        public override void SetPrimitiveType(PrimitiveType primitiveType)
        {
            this.primitiveType = primitiveType;
        }

        public unsafe void Draw()
        {
            DrawPart(this.indsCount, 0, 0);
        }

        internal override void DrawPart(int indexCount, int indexOffset, int vertexOffset)
        {
            var context = renderer.GetContext();

            uint stride = (uint)vertexSize, offset = 0;
            fixed(ID3D11Buffer** ppVertexBuffer = &this.pVertexBuffer)
                context->IASetVertexBuffers(0, 1, ppVertexBuffer, &stride, &offset);
            
            context->IASetIndexBuffer(this.pIndexBuffer, DXGI_FORMAT.DXGI_FORMAT_R32_UINT, 0);
            context->IASetPrimitiveTopology(ConvertPrimitive(this.primitiveType));

            context->DrawIndexed((uint)indexCount, (uint)indexOffset, vertexOffset);
        }

        static D3D_PRIMITIVE_TOPOLOGY ConvertPrimitive(PrimitiveType type)
        {
            switch (type)
            {
                case PrimitiveType.TriangleList:
                    return D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST;
                case PrimitiveType.TriangleStrip:
                    return D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP;
                case PrimitiveType.LineList:
                    return D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINELIST;
                case PrimitiveType.LineStrip:
                    return D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINESTRIP;
                default:
                    return D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_UNDEFINED;
            }
        }
    }
}
