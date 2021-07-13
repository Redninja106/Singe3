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
        [Guid("696442BE-A72E-4059-BC79-5B5C98040FAD")]
        internal unsafe struct ID3D12Resource
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
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetPrivateData(global::System.Guid*, uint *, void *)"/>
            internal unsafe win32.System.Com.HRESULT GetPrivateData(in global::System.Guid guid, ref uint pDataSize, void *pData)
            {
                fixed (uint *pDataSizeLocal = &pDataSize)
                {
                    fixed (global::System.Guid*guidLocal = &guid)
                    {
                        win32.System.Com.HRESULT __result = this.GetPrivateData(guidLocal, pDataSizeLocal, pData);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetPrivateData(global::System.Guid*guid, uint *pDataSize, [Optional] void *pData)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->GetPrivateData_4(pThis, guid, pDataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateData(global::System.Guid*, uint, void *)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateData(in global::System.Guid guid, uint DataSize, void *pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateData(guidLocal, DataSize, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateData(global::System.Guid*guid, uint DataSize, [Optional] void *pData)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->SetPrivateData_5(pThis, guid, DataSize, pData);
            }

            /// <inheritdoc cref = "SetPrivateDataInterface(global::System.Guid*, win32.System.Com.IUnknown*)"/>
            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(in global::System.Guid guid, win32.System.Com.IUnknown*pData)
            {
                fixed (global::System.Guid*guidLocal = &guid)
                {
                    win32.System.Com.HRESULT __result = this.SetPrivateDataInterface(guidLocal, pData);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT SetPrivateDataInterface(global::System.Guid*guid, [Optional] win32.System.Com.IUnknown*pData)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_6(pThis, guid, pData);
            }

            /// <inheritdoc cref = "SetName(win32.System.SystemServices.PCWSTR)"/>
            internal unsafe win32.System.Com.HRESULT SetName(string Name)
            {
                fixed (char *NameLocal = Name)
                {
                    win32.System.Com.HRESULT __result = this.SetName(NameLocal);
                    return __result;
                }
            }

            internal win32.System.Com.HRESULT SetName(win32.System.SystemServices.PCWSTR Name)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->SetName_7(pThis, Name);
            }

            /// <inheritdoc cref = "GetDevice(global::System.Guid*, void **)"/>
            internal unsafe win32.System.Com.HRESULT GetDevice(in global::System.Guid riid, void **ppvDevice)
            {
                fixed (global::System.Guid*riidLocal = &riid)
                {
                    win32.System.Com.HRESULT __result = this.GetDevice(riidLocal, ppvDevice);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetDevice(global::System.Guid*riid, [Optional] void **ppvDevice)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->GetDevice_8(pThis, riid, ppvDevice);
            }

            /// <inheritdoc cref = "Map(uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void **)"/>
            internal unsafe win32.System.Com.HRESULT Map(uint Subresource, win32.Graphics.Direct3D12.D3D12_RANGE? pReadRange, void **ppData)
            {
                win32.Graphics.Direct3D12.D3D12_RANGE pReadRangeLocal = pReadRange.HasValue ? pReadRange.Value : default(win32.Graphics.Direct3D12.D3D12_RANGE);
                win32.System.Com.HRESULT __result = this.Map(Subresource, pReadRange.HasValue ? &pReadRangeLocal : null, ppData);
                return __result;
            }

            /// <summary>Gets a CPU pointer to the specified subresource in the resource, but may not disclose the pointer value to applications. Map also invalidates the CPU cache, when necessary, so that CPU reads to this address reflect any modifications made by the GPU.</summary>
            /// <param name = "Subresource">
            /// <para>Type: <b>UINT</b></para>
            /// <para>Specifies the index number of the subresource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-map#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pReadRange">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_range">D3D12_RANGE</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_range">D3D12_RANGE</a> structure that describes the range of memory to access.</para>
            /// <para>This indicates the region the CPU might read, and the coordinates are subresource-relative. A null pointer indicates the entire subresource might be read by the CPU. It is valid to specify the CPU won't read any data by passing a range where <b>End</b> is less than or equal to <b>Begin</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-map#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "ppData">
            /// <para>Type: <b><b>void</b>**</b></para>
            /// <para>A pointer to a memory block that receives a pointer to the resource data.</para>
            /// <para>A null pointer is valid and is useful to cache a CPU virtual address range for methods like <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12resource-writetosubresource">WriteToSubresource</a>. When <i>ppData</i> is not NULL, the pointer returned is never offset by any values in <i>pReadRange</i>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-map#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the <a href = "/windows/desktop/direct3d12/d3d12-graphics-reference-returnvalues">Direct3D 12 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-map">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT Map(uint Subresource, [Optional] win32.Graphics.Direct3D12.D3D12_RANGE*pReadRange, [Optional] void **ppData)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->Map_9(pThis, Subresource, pReadRange, ppData);
            }

            /// <inheritdoc cref = "Unmap(uint, win32.Graphics.Direct3D12.D3D12_RANGE*)"/>
            internal unsafe void Unmap(uint Subresource, win32.Graphics.Direct3D12.D3D12_RANGE? pWrittenRange)
            {
                win32.Graphics.Direct3D12.D3D12_RANGE pWrittenRangeLocal = pWrittenRange.HasValue ? pWrittenRange.Value : default(win32.Graphics.Direct3D12.D3D12_RANGE);
                this.Unmap(Subresource, pWrittenRange.HasValue ? &pWrittenRangeLocal : null);
            }

            /// <summary>Invalidates the CPU pointer to the specified subresource in the resource. Unmap also flushes the CPU cache, when necessary, so that GPU reads to this address reflect any modifications made by the CPU.</summary>
            /// <param name = "Subresource">
            /// <para>Type: <b>UINT</b></para>
            /// <para>Specifies the index of the subresource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-unmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pWrittenRange">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_range">D3D12_RANGE</a>*</b></para>
            /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_range">D3D12_RANGE</a> structure that describes the range of memory to unmap.</para>
            /// <para>This indicates the region the CPU might have modified, and the coordinates are subresource-relative. A null pointer indicates the entire subresource might have been modified by the CPU. It is valid to specify the CPU didn't write any data by passing a range where <b>End</b> is less than or equal to <b>Begin</b>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-unmap#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <remarks>
            /// <para>Refer to the extensive Remarks and Examples for the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/nf-d3d12-id3d12resource-map">Map</a> method.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-unmap#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe void Unmap(uint Subresource, [Optional] win32.Graphics.Direct3D12.D3D12_RANGE*pWrittenRange)
            {
                fixed (ID3D12Resource*pThis = &this)
                    lpVtbl->Unmap_10(pThis, Subresource, pWrittenRange);
            }

            /// <summary>Gets the resource description.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/desktop/api/d3d12/ns-d3d12-d3d12_resource_desc">D3D12_RESOURCE_DESC</a></b></para>
            /// <para>A Direct3D 12 resource description structure.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-getdesc">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.Graphics.Direct3D12.D3D12_RESOURCE_DESC GetDesc()
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->GetDesc_11(pThis);
            }

            /// <summary>This method returns the GPU virtual address of a buffer resource.</summary>
            /// <returns>
            /// <para>Type: <b>D3D12_GPU_VIRTUAL_ADDRESS</b></para>
            /// <para>This method returns the GPU virtual address. D3D12_GPU_VIRTUAL_ADDRESS is a typedef'd synonym of UINT64.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-getgpuvirtualaddress">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal ulong GetGPUVirtualAddress()
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->GetGPUVirtualAddress_12(pThis);
            }

            /// <inheritdoc cref = "WriteToSubresource(uint, win32.Graphics.Direct3D12.D3D12_BOX*, void *, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT WriteToSubresource(uint DstSubresource, win32.Graphics.Direct3D12.D3D12_BOX? pDstBox, void *pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
            {
                win32.Graphics.Direct3D12.D3D12_BOX pDstBoxLocal = pDstBox.HasValue ? pDstBox.Value : default(win32.Graphics.Direct3D12.D3D12_BOX);
                win32.System.Com.HRESULT __result = this.WriteToSubresource(DstSubresource, pDstBox.HasValue ? &pDstBoxLocal : null, pSrcData, SrcRowPitch, SrcDepthPitch);
                return __result;
            }

            /// <summary>Uses the CPU to copy data into a subresource, enabling the CPU to modify the contents of most textures with undefined layouts.</summary>
            /// <param name = "DstSubresource">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Specifies the index of the subresource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pDstBox">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_box">D3D12_BOX</a>*</b> A pointer to a box that defines the portion of the destination subresource to copy the resource data into. If NULL, the data is written to the destination subresource with no offset. The dimensions of the source must fit the destination (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_box">D3D12_BOX</a>).</para>
            /// <para>An empty box results in a no-op. A box is empty if the top value is greater than or equal to the bottom value, or the left value is greater than or equal to the right value, or the front value is greater than or equal to the back value. When the box is empty, this method doesn't perform any operation.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pSrcData">
            /// <para>Type: <b>const void*</b></para>
            /// <para>A pointer to the source data in memory.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "SrcRowPitch">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The distance from one row of source data to the next row.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "SrcDepthPitch">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The distance from one depth slice of source data to the next.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the <a href = "/windows/desktop/direct3d12/d3d12-graphics-reference-returnvalues">Direct3D 12 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-writetosubresource">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT WriteToSubresource(uint DstSubresource, [Optional] win32.Graphics.Direct3D12.D3D12_BOX*pDstBox, void *pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->WriteToSubresource_13(pThis, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }

            /// <inheritdoc cref = "ReadFromSubresource(void *, uint, uint, uint, win32.Graphics.Direct3D12.D3D12_BOX*)"/>
            internal unsafe win32.System.Com.HRESULT ReadFromSubresource(void *pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, win32.Graphics.Direct3D12.D3D12_BOX? pSrcBox)
            {
                win32.Graphics.Direct3D12.D3D12_BOX pSrcBoxLocal = pSrcBox.HasValue ? pSrcBox.Value : default(win32.Graphics.Direct3D12.D3D12_BOX);
                win32.System.Com.HRESULT __result = this.ReadFromSubresource(pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox.HasValue ? &pSrcBoxLocal : null);
                return __result;
            }

            /// <summary>Uses the CPU to copy data from a subresource, enabling the CPU to read the contents of most textures with undefined layouts.</summary>
            /// <param name = "pDstData">
            /// <para>Type: <b>void*</b></para>
            /// <para>A pointer to the destination data in memory.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "DstRowPitch">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The distance from one row of destination data to the next row.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "DstDepthPitch">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>The distance from one depth slice of destination data to the next.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "SrcSubresource">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">UINT</a></b></para>
            /// <para>Specifies the index of the subresource to read from.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pSrcBox">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_box">D3D12_BOX</a>*</b> A pointer to a box that defines the portion of the destination subresource to copy the resource data from. If NULL, the data is read from the destination subresource with no offset. The dimensions of the destination must fit the destination (see <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_box">D3D12_BOX</a>).</para>
            /// <para>An empty box results in a no-op. A box is empty if the top value is greater than or equal to the bottom value, or the left value is greater than or equal to the right value, or the front value is greater than or equal to the back value. When the box is empty, this method doesn't perform any operation.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the <a href = "/windows/desktop/direct3d12/d3d12-graphics-reference-returnvalues">Direct3D 12 Return Codes</a>.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-readfromsubresource">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ReadFromSubresource(void *pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Optional] win32.Graphics.Direct3D12.D3D12_BOX*pSrcBox)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->ReadFromSubresource_14(pThis, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
            }

            /// <summary>Retrieves the properties of the resource heap, for placed and committed resources.</summary>
            /// <param name = "pHeapProperties">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_heap_properties">D3D12_HEAP_PROPERTIES</a>*</b></para>
            /// <para>Pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_heap_properties">D3D12_HEAP_PROPERTIES</a> structure, that on successful completion of the method will contain the resource heap properties.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-getheapproperties#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pHeapFlags">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_heap_flags">D3D12_HEAP_FLAGS</a>*</b></para>
            /// <para>Specifies a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_heap_flags">D3D12_HEAP_FLAGS</a> variable, that on successful completion of the method will contain any miscellaneous heap flags.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-getheapproperties#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns one of the <a href = "/windows/desktop/direct3d12/d3d12-graphics-reference-returnvalues">Direct3D 12 Return Codes</a>. If the resource was created as reserved, E_INVALIDARG is returned.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/nf-d3d12-id3d12resource-getheapproperties">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetHeapProperties([Optional] win32.Graphics.Direct3D12.D3D12_HEAP_PROPERTIES*pHeapProperties, [Optional] win32.Graphics.Direct3D12.D3D12_HEAP_FLAGS*pHeapFlags)
            {
                fixed (ID3D12Resource*pThis = &this)
                    return lpVtbl->GetHeapProperties_15(pThis, pHeapProperties, pHeapFlags);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_4;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_6;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, win32.System.SystemServices.PCWSTR, win32.System.Com.HRESULT>SetName_7;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, global::System.Guid*, void **, win32.System.Com.HRESULT>GetDevice_8;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void **, win32.System.Com.HRESULT>Map_9;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, uint, win32.Graphics.Direct3D12.D3D12_RANGE*, void>Unmap_10;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, win32.Graphics.Direct3D12.D3D12_RESOURCE_DESC>GetDesc_11;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, ulong>GetGPUVirtualAddress_12;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, uint, win32.Graphics.Direct3D12.D3D12_BOX*, void *, uint, uint, win32.System.Com.HRESULT>WriteToSubresource_13;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, void *, uint, uint, uint, win32.Graphics.Direct3D12.D3D12_BOX*, win32.System.Com.HRESULT>ReadFromSubresource_14;
                internal delegate *unmanaged[Stdcall]<ID3D12Resource*, win32.Graphics.Direct3D12.D3D12_HEAP_PROPERTIES*, win32.Graphics.Direct3D12.D3D12_HEAP_FLAGS*, win32.System.Com.HRESULT>GetHeapProperties_15;
            }

            private Vtbl*lpVtbl;
        }
    }
}