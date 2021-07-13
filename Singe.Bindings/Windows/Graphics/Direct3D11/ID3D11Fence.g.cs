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
        [Guid("AFFDE9D1-1DF7-4BB7-8A34-0F46251DAB80")]
        internal unsafe struct ID3D11Fence
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
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetDevice(win32.Graphics.Direct3D11.ID3D11Device**ppDevice)
            {
                fixed (ID3D11Fence*pThis = &this)
                    lpVtbl->GetDevice_4(pThis, ppDevice);
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
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->GetPrivateData_5(pThis, guid, pDataSize, pData);
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
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->SetPrivateData_6(pThis, guid, DataSize, pData);
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
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->SetPrivateDataInterface_7(pThis, guid, pData);
            }

            /// <inheritdoc cref = "CreateSharedHandle(win32.System.SystemServices.SECURITY_ATTRIBUTES*, uint, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.HANDLE*)"/>
            internal unsafe win32.System.Com.HRESULT CreateSharedHandle(win32.System.SystemServices.SECURITY_ATTRIBUTES? pAttributes, uint dwAccess, string lpName, out Microsoft.Win32.SafeHandles.SafeFileHandle pHandle)
            {
                fixed (char *lpNameLocal = lpName)
                {
                    win32.System.SystemServices.SECURITY_ATTRIBUTES pAttributesLocal = pAttributes.HasValue ? pAttributes.Value : default(win32.System.SystemServices.SECURITY_ATTRIBUTES);
                    win32.System.SystemServices.HANDLE pHandleLocal;
                    win32.System.Com.HRESULT __result = this.CreateSharedHandle(pAttributes.HasValue ? &pAttributesLocal : null, dwAccess, lpNameLocal, &pHandleLocal);
                    pHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle(pHandleLocal, ownsHandle: true);
                    return __result;
                }
            }

            /// <summary>Creates a shared handle to a fence object.</summary>
            /// <param name = "pAttributes">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/aa379560(v=vs.85)">SECURITY_ATTRIBUTES</a>*</b> A pointer to a <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/legacy/aa379560(v=vs.85)">SECURITY_ATTRIBUTES</a>structure that contains two separate but related data members: an optional security descriptor, and a <b>Boolean</b>value that determines whether child processes can inherit the returned handle.</para>
            /// <para>Set this parameter to <b>NULL</b> if you want child processes that the application might create to not  inherit  the handle returned by <b>CreateSharedHandle</b>, and if you want the resource that is associated with the returned handle to get a default security descriptor.</para>
            /// <para>The <b>lpSecurityDescriptor</b> member of the structure specifies a <a href = "https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-security_descriptor">SECURITY_DESCRIPTOR</a> for the resource. Set this member to <b>NULL</b> if you want the runtime to assign a default security descriptor to the resource that is associated with the returned handle. The ACLs in the default security descriptor for the resource come from the primary or impersonation token of the creator. For more info, see <a href = "https://docs.microsoft.com/windows/desktop/Sync/synchronization-object-security-and-access-rights">Synchronization Object Security and Access Rights</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "dwAccess">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">DWORD</a></b></para>
            /// <para>Currently the only value this parameter accepts is GENERIC_ALL.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "lpName">
            /// <para>Type: <b>LPCWSTR</b> A <b>NULL</b>-terminated <b>UNICODE</b> string that contains the name to associate with the shared heap. The name is limited to MAX_PATH characters. Name comparison is case-sensitive.</para>
            /// <para>If <i>Name</i> matches the name of an existing resource, <b>CreateSharedHandle</b> fails with <a href = "https://docs.microsoft.com/windows/desktop/direct3ddxgi/dxgi-error">DXGI_ERROR_NAME_ALREADY_EXISTS</a>. This occurs because these objects share the same namespace.</para>
            /// <para>The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\\). For more information, see <a href = "https://docs.microsoft.com/windows/desktop/TermServ/kernel-object-namespaces">Kernel Object Namespaces</a>. Fast user switching is implemented using Terminal Services sessions. Kernel object names must follow the guidelines outlined for Terminal Services so that applications can support multiple users.</para>
            /// <para>The object can be created in a private namespace. For more information, see <a href = "https://docs.microsoft.com/windows/desktop/Sync/object-namespaces">Object Namespaces</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pHandle">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HANDLE</a>*</b></para>
            /// <para>A pointer to a variable that receives the NT HANDLE value to the resource to share. You can use this handle in calls to access the resource.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b> Returns S_OK if successful; otherwise, returns one of the following values:</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT CreateSharedHandle([Optional] win32.System.SystemServices.SECURITY_ATTRIBUTES*pAttributes, uint dwAccess, win32.System.SystemServices.PCWSTR lpName, win32.System.SystemServices.HANDLE*pHandle)
            {
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->CreateSharedHandle_8(pThis, pAttributes, dwAccess, lpName, pHandle);
            }

            /// <summary>Gets the current value of the fence.</summary>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/WinProg/windows-data-types">UINT64</a></b></para>
            /// <para>Returns the current value of the fence.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-getcompletedvalue">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal ulong GetCompletedValue()
            {
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->GetCompletedValue_9(pThis);
            }

            /// <inheritdoc cref = "SetEventOnCompletion(ulong, win32.System.SystemServices.HANDLE)"/>
            internal unsafe win32.System.Com.HRESULT SetEventOnCompletion(ulong Value, SafeHandle hEvent)
            {
                bool hEventAddRef = false;
                try
                {
                    win32.System.SystemServices.HANDLE hEventLocal;
                    if (hEvent is object)
                    {
                        hEvent.DangerousAddRef(ref hEventAddRef);
                        hEventLocal = (win32.System.SystemServices.HANDLE)hEvent.DangerousGetHandle();
                    }
                    else
                        hEventLocal = default(win32.System.SystemServices.HANDLE);
                    win32.System.Com.HRESULT __result = this.SetEventOnCompletion(Value, hEventLocal);
                    return __result;
                }
                finally
                {
                    if (hEventAddRef)
                        hEvent.DangerousRelease();
                }
            }

            /// <summary>Specifies an event that should be fired when the fence reaches a certain value.</summary>
            /// <param name = "Value">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/WinProg/windows-data-types">UINT64</a></b></para>
            /// <para>The fence value when the event is to be signaled.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-seteventoncompletion#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "hEvent">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/win32/WinProg/windows-data-types">HANDLE</a></b></para>
            /// <para>A handle to the event object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-seteventoncompletion#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>This method returns <b>E_OUTOFMEMORY</b> if the kernel components don’t have sufficient memory to store the event in a list. See <a href = "/windows/win32/direct3d11/d3d11-graphics-reference-returnvalues">Direct3D 11 Return Codes</a> for other possible return values.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11_3/nf-d3d11_3-id3d11fence-seteventoncompletion">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetEventOnCompletion(ulong Value, win32.System.SystemServices.HANDLE hEvent)
            {
                fixed (ID3D11Fence*pThis = &this)
                    return lpVtbl->SetEventOnCompletion_10(pThis, Value, hEvent);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, win32.Graphics.Direct3D11.ID3D11Device**, void>GetDevice_4;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, global::System.Guid*, uint *, void *, win32.System.Com.HRESULT>GetPrivateData_5;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, global::System.Guid*, uint, void *, win32.System.Com.HRESULT>SetPrivateData_6;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, global::System.Guid*, win32.System.Com.IUnknown*, win32.System.Com.HRESULT>SetPrivateDataInterface_7;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, win32.System.SystemServices.SECURITY_ATTRIBUTES*, uint, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.HANDLE*, win32.System.Com.HRESULT>CreateSharedHandle_8;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, ulong>GetCompletedValue_9;
                internal delegate *unmanaged[Stdcall]<ID3D11Fence*, ulong, win32.System.SystemServices.HANDLE, win32.System.Com.HRESULT>SetEventOnCompletion_10;
            }

            private Vtbl*lpVtbl;
        }
    }
}