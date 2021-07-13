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

    namespace Graphics.Direct2D
    {
        [Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
        internal unsafe struct ID2D1GdiMetafileSink1
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
                fixed (ID2D1GdiMetafileSink1*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1GdiMetafileSink1*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1GdiMetafileSink1*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Provides access to metafile records, including their type, data, and flags.</summary>
            /// <param name = "recordType">
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The type of metafile record being processed. Please see <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emf/91c257d7-c39d-4a36-9b1f-63e3f73d30ca">MS-EMF</a> and <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emfplus/5f92c789-64f2-46b5-9ed4-15a9bb0946c6">MS-EMFPLUS</a> for a list of record types.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "recordData">
            /// <para>Type: <b>const void*</b></para>
            /// <para>The data contained in this record. Please see <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emf/91c257d7-c39d-4a36-9b1f-63e3f73d30ca">MS-EMF</a> and <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emfplus/5f92c789-64f2-46b5-9ed4-15a9bb0946c6">MS-EMFPLUS</a> for information on record data layouts.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "recordDataSize">
            /// <para>Type: <b>UINT</b></para>
            /// <para>TThe size of the data pointed to by recordData.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>S_OK if successful, otherwise a failure HRESULT.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ProcessRecord(uint recordType, [Optional] void *recordData, uint recordDataSize)
            {
                fixed (ID2D1GdiMetafileSink1*pThis = &this)
                    return lpVtbl->ProcessRecord_4(pThis, recordType, recordData, recordDataSize);
            }

            /// <summary>Provides access to metafile records, including their type, data, and flags.</summary>
            /// <param name = "recordType">
            /// <para>Type: <b>DWORD</b></para>
            /// <para>The type of metafile record being processed. Please see <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emf/91c257d7-c39d-4a36-9b1f-63e3f73d30ca">MS-EMF</a> and <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emfplus/5f92c789-64f2-46b5-9ed4-15a9bb0946c6">MS-EMFPLUS</a> for a list of record types.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "recordData">
            /// <para>Type: <b>const void*</b></para>
            /// <para>The data contained in this record. Please see <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emf/91c257d7-c39d-4a36-9b1f-63e3f73d30ca">MS-EMF</a> and <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emfplus/5f92c789-64f2-46b5-9ed4-15a9bb0946c6">MS-EMFPLUS</a> for information on record data layouts.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "recordDataSize">
            /// <para>Type: <b>UINT</b></para>
            /// <para>TThe size of the data pointed to by recordData.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "flags">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The set of flags set for this record. Please see <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emf/91c257d7-c39d-4a36-9b1f-63e3f73d30ca">MS-EMF</a> and <a href = "https://docs.microsoft.com/openspecs/windows_protocols/ms-emfplus/5f92c789-64f2-46b5-9ed4-15a9bb0946c6">MS-EMFPLUS</a> for information on record flags.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>S_OK if successful, otherwise a failure HRESULT.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1_3/nf-d2d1_3-id2d1gdimetafilesink1-processrecord">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ProcessRecord(uint recordType, [Optional] void *recordData, uint recordDataSize, uint flags)
            {
                fixed (ID2D1GdiMetafileSink1*pThis = &this)
                    return lpVtbl->ProcessRecord_5(pThis, recordType, recordData, recordDataSize, flags);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void *, uint, win32.System.Com.HRESULT>ProcessRecord_4;
                internal delegate *unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void *, uint, uint, win32.System.Com.HRESULT>ProcessRecord_5;
            }

            private Vtbl*lpVtbl;
        }
    }
}