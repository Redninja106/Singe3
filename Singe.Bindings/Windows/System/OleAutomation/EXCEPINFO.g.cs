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

    namespace System.OleAutomation
    {
        /// <summary>Describes an exception that occurred during IDispatch::Invoke.</summary>
        /// <remarks>
        /// <para>Use the <b>pfnDeferredFillIn</b> field to enable an object to defer filling in the <b>bstrDescription</b>, <b>bstrHelpFile</b>, and <b>dwHelpContext</b> fields until they are needed. This field might be used, for example, if loading the string for the error is a time-consuming operation. To use deferred fill-in, the object puts a function pointer in this slot and does not fill any of the other fields except <b>wCode</b>, which is required.</para>
        /// <para>To get additional information, the caller passes the <b>EXCEPINFO</b> structure back to the <b>pexcepinfo</b> callback function, which fills in the additional information. When the ActiveX object and the ActiveX client are in different processes, the ActiveX object calls <b>pfnDeferredFillIn</b> before returning to the controller.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//oaidl/ns-oaidl-excepinfo#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct EXCEPINFO
        {
            /// <summary>The error code. Error codes should be greater than 1000. Either this field or the scode field must be filled in; the other must be set to 0.</summary>
            internal ushort wCode;
            /// <summary>Reserved. Should be 0.</summary>
            internal ushort wReserved;
            /// <summary>The name of the exception source. Typically, this is an application name. This field should be filled in by the implementor of <a href = "https://docs.microsoft.com/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch">IDispatch</a>.</summary>
            internal win32.System.OleAutomation.BSTR bstrSource;
            /// <summary>The exception description to display. If no description is available, use null.</summary>
            internal win32.System.OleAutomation.BSTR bstrDescription;
            /// <summary>The fully qualified help file path. If no Help is available, use null.</summary>
            internal win32.System.OleAutomation.BSTR bstrHelpFile;
            /// <summary>The help context ID.</summary>
            internal uint dwHelpContext;
            /// <summary>Reserved. Must be null.</summary>
            internal unsafe void *pvReserved;
            /// <summary>Provides deferred fill-in. If deferred fill-in is not desired, this field should be set to null.</summary>
            internal unsafe delegate *unmanaged[Stdcall]<win32.System.OleAutomation.EXCEPINFO*, win32.System.Com.HRESULT>pfnDeferredFillIn;
            /// <summary>A return value that describes the error. Either this field or wCode (but not both) must be filled in; the other must be set to 0. (16-bit Windows versions only.)</summary>
            internal int scode;
        }
    }
}