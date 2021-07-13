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

    internal static partial class ComDlg32
    {
        /// <inheritdoc cref = "GetFileTitle(win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PWSTR, ushort)"/>
        internal static unsafe short GetFileTitle(string param0, win32.System.SystemServices.PWSTR Buf, ushort cchSize)
        {
            fixed (char *param0Local = param0)
            {
                short __result = ComDlg32.GetFileTitle(param0Local, Buf, cchSize);
                return __result;
            }
        }

        /// <summary>Retrieves the name of the specified file.</summary>
        /// <param name = "Buf">
        /// <para>Type: <b>LPTSTR</b></para>
        /// <para>The buffer that receives the name of the file.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//commdlg/nf-commdlg-getfiletitlew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "cchSize">
        /// <para>Type: <b>WORD</b></para>
        /// <para>The length, in characters, of the buffer pointed to by the <i>lpszTitle</i> parameter.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//commdlg/nf-commdlg-getfiletitlew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>short</b></para>
        /// <para>If the function succeeds, the return value is zero.</para>
        /// <para>If the file name is invalid, the return value is unknown. If there is an error, the return value is a negative number.</para>
        /// <para>If the buffer pointed to by the <i>lpszTitle</i> parameter is too small, the return value is a positive integer that specifies the required buffer size, in characters. The required buffer size includes the terminating null character.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//commdlg/nf-commdlg-getfiletitlew">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("ComDlg32", ExactSpelling = true, EntryPoint = "GetFileTitleW")]
        internal static extern short GetFileTitle(win32.System.SystemServices.PCWSTR param0, win32.System.SystemServices.PWSTR Buf, ushort cchSize);
        /// <summary>Returns a common dialog box error code. This code indicates the most recent error to occur during the execution of one of the common dialog box functions.</summary>
        /// <returns>
        /// <para>Type: <b>DWORD</b></para>
        /// <para>If the most recent call to a common dialog box function succeeded, the return value is undefined. If the common dialog box function returned <b>FALSE</b> because the user closed or canceled the dialog box, the return value is zero. Otherwise, the return value is a nonzero error code.</para>
        /// <para>The <b>CommDlgExtendedError</b> function can return general error codes for any of the common dialog box functions. In addition, there are error codes that are returned only for a specific common dialog box. All of these error codes are defined in Cderr.h. The following general error codes can be returned for any of the common dialog box functions.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//commdlg/nf-commdlg-commdlgextendederror">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("ComDlg32", ExactSpelling = true)]
        internal static extern uint CommDlgExtendedError();
    }
}