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

    namespace Graphics.Hlsl
    {
        [Guid("FB6904C4-42F0-4B62-9C46-983AF7DA7C83")]
        internal unsafe struct IDxcVersionInfo2
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
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <inheritdoc cref = "GetVersion(uint *, uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetVersion(out uint pMajor, out uint pMinor)
            {
                fixed (uint *pMinorLocal = &pMinor)
                {
                    fixed (uint *pMajorLocal = &pMajor)
                    {
                        win32.System.Com.HRESULT __result = this.GetVersion(pMajorLocal, pMinorLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetVersion(uint *pMajor, uint *pMinor)
            {
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->GetVersion_4(pThis, pMajor, pMinor);
            }

            /// <inheritdoc cref = "GetFlags(uint *)"/>
            internal unsafe win32.System.Com.HRESULT GetFlags(out uint pFlags)
            {
                fixed (uint *pFlagsLocal = &pFlags)
                {
                    win32.System.Com.HRESULT __result = this.GetFlags(pFlagsLocal);
                    return __result;
                }
            }

            internal unsafe win32.System.Com.HRESULT GetFlags(uint *pFlags)
            {
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->GetFlags_5(pThis, pFlags);
            }

            /// <inheritdoc cref = "GetCommitInfo(uint *, sbyte **)"/>
            internal unsafe win32.System.Com.HRESULT GetCommitInfo(out uint pCommitCount, out sbyte *pCommitHash)
            {
                fixed (sbyte **pCommitHashLocal = &pCommitHash)
                {
                    fixed (uint *pCommitCountLocal = &pCommitCount)
                    {
                        win32.System.Com.HRESULT __result = this.GetCommitInfo(pCommitCountLocal, pCommitHashLocal);
                        return __result;
                    }
                }
            }

            internal unsafe win32.System.Com.HRESULT GetCommitInfo(uint *pCommitCount, sbyte **pCommitHash)
            {
                fixed (IDxcVersionInfo2*pThis = &this)
                    return lpVtbl->GetCommitInfo_6(pThis, pCommitCount, pCommitHash);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, uint *, uint *, win32.System.Com.HRESULT>GetVersion_4;
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, uint *, win32.System.Com.HRESULT>GetFlags_5;
                internal delegate *unmanaged[Stdcall]<IDxcVersionInfo2*, uint *, sbyte **, win32.System.Com.HRESULT>GetCommitInfo_6;
            }

            private Vtbl*lpVtbl;
        }
    }
}