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

    namespace Storage.StructuredStorage
    {
        /// <summary>Contains statistical data about an open storage, stream, or byte-array object.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct STATSTG
        {
            /// <summary>
            /// <para>A pointer to a <b>NULL</b>-terminated Unicode string that contains the name. Space for this string is allocated by the method called and freed by the caller (for more information, see <a href = "https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemfree">CoTaskMemFree</a>). To  not return this member, specify the STATFLAG_NONAME value when you call a method that returns a <b>STATSTG</b> structure, except for calls to <a href = "https://docs.microsoft.com/windows/desktop/api/objidl/nn-objidl-ienumstatstg">IEnumSTATSTG::Next</a>, which provides no way to specify this value.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.PWSTR pwcsName;
            /// <summary>
            /// <para>Indicates the type of storage object. This is one of the values from the <a href = "https://docs.microsoft.com/windows/desktop/api/objidl/ne-objidl-stgty">STGTY</a> enumeration.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint type;
            /// <summary>Specifies the size, in bytes, of the stream or byte array.</summary>
            internal ulong cbSize;
            /// <summary>Indicates the last modification time for this storage, stream, or byte array.</summary>
            internal global::System.Runtime.InteropServices.ComTypes.FILETIME mtime;
            /// <summary>Indicates the creation time for this storage, stream, or byte array.</summary>
            internal global::System.Runtime.InteropServices.ComTypes.FILETIME ctime;
            /// <summary>Indicates the last access time for this storage, stream, or byte array.</summary>
            internal global::System.Runtime.InteropServices.ComTypes.FILETIME atime;
            /// <summary>
            /// <para>Indicates the access mode specified when the object was opened. This member is only valid in calls to <b>Stat</b> methods.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint grfMode;
            /// <summary>
            /// <para>Indicates the types of region locking supported by the stream or byte array. For more information about the values available, see the <a href = "https://docs.microsoft.com/windows/desktop/api/objidl/ne-objidl-locktype">LOCKTYPE</a> enumeration. This member is not used for storage objects.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint grfLocksSupported;
            /// <summary>Indicates the class identifier for the storage object; set to CLSID_NULL for new storage objects. This member is not used for streams or byte arrays.</summary>
            internal global::System.Guid clsid;
            /// <summary>
            /// <para>Indicates the current state bits of the storage object; that is, the value most recently set by the <a href = "https://docs.microsoft.com/windows/desktop/api/objidl/nf-objidl-istorage-setstatebits">IStorage::SetStateBits</a> method. This member is not valid for streams or byte arrays.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//objidl/ns-objidl-statstg#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint grfStateBits;
            /// <summary>Reserved for future use.</summary>
            internal uint reserved;
        }
    }
}