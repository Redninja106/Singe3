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

    namespace Storage.FileSystem
    {
        /// <summary>Contains extended parameters for the CopyFile2 function.</summary>
        /// <remarks>
        /// <para>To compile an application that uses this structure, define the <b>_WIN32_WINNT</b> macro as <b>_WIN32_WINNT_WIN8</b> or later. For more information, see <a href = "https://docs.microsoft.com/windows/desktop/WinProg/using-the-windows-headers">Using the Windows Headers</a>.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct COPYFILE2_EXTENDED_PARAMETERS
        {
            /// <summary>
            /// <para>Contains the size of this structure, <c>sizeof(COPYFILE2_EXTENDED_PARAMETERS)</c>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwSize;
            /// <summary>
            /// <para>Contains a combination of zero or more of these flag values.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal uint dwCopyFlags;
            /// <summary>
            /// <para>If this flag is set to <b>TRUE</b> during the copy operation then the copy operation is canceled.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe win32.System.SystemServices.BOOL*pfCancel;
            /// <summary>
            /// <para>The optional address of a callback function of type <b>PCOPYFILE2_PROGRESS_ROUTINE</b> that is called each time another portion of the file has been copied. This parameter can be <b>NULL</b>. For more information on the progress callback function, see the <a href = "https://docs.microsoft.com/windows/desktop/api/winbase/nc-winbase-pcopyfile2_progress_routine">CopyFile2ProgressRoutine</a> callback function.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe delegate *unmanaged[Stdcall]<win32.Storage.FileSystem.COPYFILE2_MESSAGE*, void *, win32.Storage.FileSystem.COPYFILE2_MESSAGE_ACTION>pProgressRoutine;
            /// <summary>
            /// <para>A pointer to application-specific context information to be passed to the <a href = "https://docs.microsoft.com/windows/desktop/api/winbase/nc-winbase-pcopyfile2_progress_routine">CopyFile2ProgressRoutine</a>.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-copyfile2_extended_parameters#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal unsafe void *pvCallbackContext;
        }
    }
}