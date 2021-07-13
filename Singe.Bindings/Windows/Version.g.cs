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

    internal static partial class Version
    {
        /// <inheritdoc cref = "VerFindFile(uint, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PWSTR, uint *, win32.System.SystemServices.PWSTR, uint *)"/>
        internal static unsafe uint VerFindFile(uint uFlags, string szFileName, string szWinDir, string szAppDir, win32.System.SystemServices.PWSTR szCurDir, ref uint puCurDirLen, win32.System.SystemServices.PWSTR szDestDir, ref uint puDestDirLen)
        {
            fixed (uint *puDestDirLenLocal = &puDestDirLen)
            {
                fixed (uint *puCurDirLenLocal = &puCurDirLen)
                {
                    fixed (char *szAppDirLocal = szAppDir)
                    {
                        fixed (char *szWinDirLocal = szWinDir)
                        {
                            fixed (char *szFileNameLocal = szFileName)
                            {
                                uint __result = Version.VerFindFile(uFlags, szFileNameLocal, szWinDirLocal, szAppDirLocal, szCurDir, puCurDirLenLocal, szDestDir, puDestDirLenLocal);
                                return __result;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>Determines where to install a file based on whether it locates another version of the file in the system. The values VerFindFile returns in the specified buffers are used in a subsequent call to the VerInstallFile function.</summary>
        /// <param name = "uFlags">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>This parameter can be the following value. All other bits are reserved.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szFileName">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file to be installed. Include only the file name and extension, not a path.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szWinDir">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The directory in which Windows is running or will be run. This string is returned by the  <a href = "https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-getwindowsdirectorya">GetWindowsDirectory</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szAppDir">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The directory where the installation program is installing a set of related files. If the installation program is installing an application, this is the directory where the application will reside. This parameter also points to the application's current directory unless otherwise specified.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szCurDir">
        /// <para>Type: <b>LPWSTR</b></para>
        /// <para>A buffer that receives the path to a current version of the file being installed. The path is a zero-terminated string. If a current version is not installed, the buffer will contain a zero-length string. The buffer should be at least <b>_MAX_PATH</b> characters long, although this is not required.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "puCurDirLen">
        /// <para>Type: <b>PUINT</b></para>
        /// <para>The length of the <i>szCurDir</i>  buffer. This pointer must not be <b>NULL</b>.</para>
        /// <para>When the function returns, <i>lpuCurDirLen</i> contains the size, in characters, of the data returned in <i>szCurDir</i>, including the terminating null character. If the buffer is too small to contain all the data, <i>lpuCurDirLen</i> will be the size of the buffer required to hold the path.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szDestDir">
        /// <para>Type: <b>LPTSTR</b></para>
        /// <para>A buffer that receives the path to the installation location recommended by <b>VerFindFile</b>. The path is a zero-terminated string. The buffer should be at least <b>_MAX_PATH</b> characters long, although this is not required.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "puDestDirLen">
        /// <para>Type: <b>PUINT</b></para>
        /// <para>A pointer to a variable that specifies the length of the <i>szDestDir</i> buffer. This pointer must not be <b>NULL</b>.</para>
        /// <para>When the function returns, <i>lpuDestDirLen</i> contains the size, in characters, of the data returned in <i>szDestDir</i>, including the terminating null character. If the buffer is too small to contain all the data, <i>lpuDestDirLen</i> will be the size of the buffer needed to hold the path.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>DWORD</b></para>
        /// <para>The return value is a bitmask that indicates the status of the file. It can be one or more of the following values. All other values are reserved.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verfindfilew">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "VerFindFileW")]
        internal static extern unsafe uint VerFindFile(uint uFlags, win32.System.SystemServices.PCWSTR szFileName, win32.System.SystemServices.PCWSTR szWinDir, win32.System.SystemServices.PCWSTR szAppDir, win32.System.SystemServices.PWSTR szCurDir, uint *puCurDirLen, win32.System.SystemServices.PWSTR szDestDir, uint *puDestDirLen);
        /// <inheritdoc cref = "VerInstallFile(win32.UI.WindowsAndMessaging.VER_INSTALL_FILE_FLAGS, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PCWSTR, win32.System.SystemServices.PWSTR, uint *)"/>
        internal static unsafe uint VerInstallFile(win32.UI.WindowsAndMessaging.VER_INSTALL_FILE_FLAGS uFlags, string szSrcFileName, string szDestFileName, string szSrcDir, string szDestDir, string szCurDir, win32.System.SystemServices.PWSTR szTmpFile, ref uint puTmpFileLen)
        {
            fixed (uint *puTmpFileLenLocal = &puTmpFileLen)
            {
                fixed (char *szCurDirLocal = szCurDir)
                {
                    fixed (char *szDestDirLocal = szDestDir)
                    {
                        fixed (char *szSrcDirLocal = szSrcDir)
                        {
                            fixed (char *szDestFileNameLocal = szDestFileName)
                            {
                                fixed (char *szSrcFileNameLocal = szSrcFileName)
                                {
                                    uint __result = Version.VerInstallFile(uFlags, szSrcFileNameLocal, szDestFileNameLocal, szSrcDirLocal, szDestDirLocal, szCurDirLocal, szTmpFile, puTmpFileLenLocal);
                                    return __result;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>Installs the specified file based on information returned from the VerFindFile function. VerInstallFile decompresses the file, if necessary, assigns a unique filename, and checks for errors, such as outdated files.</summary>
        /// <param name = "uFlags">Type: <b>DWORD</b></param>
        /// <param name = "szSrcFileName">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file to be installed. This is the filename in the directory pointed to by the <i>szSrcDir</i> parameter; the filename can include only the filename and extension, not a path.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szDestFileName">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name <b>VerInstallFile</b> will give the new file upon installation. This file name may be different from the filename in the <i>szSrcFileName</i> directory. The new name should include only the file name and extension, not a path.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szSrcDir">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the directory where the file can be found.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szDestDir">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the directory where the file should be installed. <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-verfindfilea">VerFindFile</a> returns this value in its <i>szDestDir</i> parameter.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szCurDir">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the directory where a preexisting version of this file can be found. <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-verfindfilea">VerFindFile</a> returns this value in its <i>szCurDir</i> parameter.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "szTmpFile">
        /// <para>Type: <b>LPTSTR</b></para>
        /// <para>The name of a temporary copy of the source file. The buffer should be at least <b>_MAX_PATH</b> characters long, although this is not required, and should be empty on input.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "puTmpFileLen">
        /// <para>Type: <b>PUINT</b></para>
        /// <para>The length of the <i>szTmpFile</i> buffer. This pointer must not be <b>NULL</b>.</para>
        /// <para>When the function returns, <i>lpuTmpFileLen</i> receives the size, in characters, of the data returned in <i>szTmpFile</i>, including the terminating null character. If the buffer is too small to contain all the data, <i>lpuTmpFileLen</i> will be the size of the buffer required to hold the data.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>DWORD</b></para>
        /// <para>The return value is a bitmask that indicates exceptions. It can be one or more of the following values. All other values are reserved.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verinstallfilew">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "VerInstallFileW")]
        internal static extern unsafe uint VerInstallFile(win32.UI.WindowsAndMessaging.VER_INSTALL_FILE_FLAGS uFlags, win32.System.SystemServices.PCWSTR szSrcFileName, win32.System.SystemServices.PCWSTR szDestFileName, win32.System.SystemServices.PCWSTR szSrcDir, win32.System.SystemServices.PCWSTR szDestDir, win32.System.SystemServices.PCWSTR szCurDir, win32.System.SystemServices.PWSTR szTmpFile, uint *puTmpFileLen);
        /// <inheritdoc cref = "GetFileVersionInfoSize(win32.System.SystemServices.PCWSTR, uint *)"/>
        internal static unsafe uint GetFileVersionInfoSize(string lptstrFilename, uint *lpdwHandle)
        {
            fixed (char *lptstrFilenameLocal = lptstrFilename)
            {
                uint __result = Version.GetFileVersionInfoSize(lptstrFilenameLocal, lpdwHandle);
                return __result;
            }
        }

        /// <summary>Determines whether the operating system can retrieve version information for a specified file. If version information is available, GetFileVersionInfoSize returns the size, in bytes, of that information.</summary>
        /// <param name = "lptstrFilename">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file of interest. The function uses the search sequence specified by the  <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpdwHandle">
        /// <para>Type: <b>LPDWORD</b></para>
        /// <para>A pointer to a variable that the function sets to zero.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>DWORD</b></para>
        /// <para>If the function succeeds, the return value is the size, in bytes, of the file's version information.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <a href = "/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizew">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "GetFileVersionInfoSizeW", SetLastError = true)]
        internal static extern unsafe uint GetFileVersionInfoSize(win32.System.SystemServices.PCWSTR lptstrFilename, [Optional] uint *lpdwHandle);
        /// <inheritdoc cref = "GetFileVersionInfo(win32.System.SystemServices.PCWSTR, uint, uint, void *)"/>
        internal static unsafe bool GetFileVersionInfo(string lptstrFilename, uint dwHandle, uint dwLen, void *lpData)
        {
            fixed (char *lptstrFilenameLocal = lptstrFilename)
            {
                bool __result = Version.GetFileVersionInfo(lptstrFilenameLocal, dwHandle, dwLen, lpData);
                return __result;
            }
        }

        /// <summary>Retrieves version information for the specified file.</summary>
        /// <param name = "lptstrFilename">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file. If a full path is not specified, the function uses the search sequence specified by the  <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfow#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "dwHandle">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>This parameter is ignored.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfow#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "dwLen">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>The size, in bytes, of the buffer pointed to by the <i>lpData</i> parameter.</para>
        /// <para>Call the <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-getfileversioninfosizea">GetFileVersionInfoSize</a> function first to determine the size, in bytes, of a file's version information. The <i>dwLen</i> member should be equal to or greater than that value.</para>
        /// <para>If the buffer pointed to by <i>lpData</i> is not large enough, the function truncates the file's version information to the size of the buffer.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfow#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpData">
        /// <para>Type: <b>LPVOID</b></para>
        /// <para>Pointer to a buffer that receives the file-version information.</para>
        /// <para>You can use this value in a subsequent call to the <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-verqueryvaluea">VerQueryValue</a> function to retrieve data from the buffer.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfow#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b></para>
        /// <para>If the function succeeds, the return value is nonzero.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <a href = "/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfow">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "GetFileVersionInfoW", SetLastError = true)]
        internal static extern unsafe bool GetFileVersionInfo(win32.System.SystemServices.PCWSTR lptstrFilename, uint dwHandle, uint dwLen, void *lpData);
        /// <inheritdoc cref = "GetFileVersionInfoSizeEx(uint, win32.System.SystemServices.PCWSTR, uint *)"/>
        internal static unsafe uint GetFileVersionInfoSizeEx(uint dwFlags, string lpwstrFilename, out uint lpdwHandle)
        {
            fixed (uint *lpdwHandleLocal = &lpdwHandle)
            {
                fixed (char *lpwstrFilenameLocal = lpwstrFilename)
                {
                    uint __result = Version.GetFileVersionInfoSizeEx(dwFlags, lpwstrFilenameLocal, lpdwHandleLocal);
                    return __result;
                }
            }
        }

        /// <summary>Determines whether the operating system can retrieve version information for a specified file. If version information is available, GetFileVersionInfoSizeEx returns the size, in bytes, of that information.</summary>
        /// <param name = "dwFlags">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>Controls which MUI DLLs (if any) from which the version resource is extracted. Zero or more of the following flags.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizeexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpwstrFilename">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file of interest. The function uses the search sequence specified by the  <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizeexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpdwHandle">
        /// <para>Type: <b>LPDWORD</b></para>
        /// <para>When this function returns, contains a pointer to a variable that is set to zero because this function sets it to zero. This parameter exists for historical reasons.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizeexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>DWORD</b> If the function succeeds, the return value is the size, in bytes, of the file's version information.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <a href = "/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfosizeexw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "GetFileVersionInfoSizeExW", SetLastError = true)]
        internal static extern unsafe uint GetFileVersionInfoSizeEx(uint dwFlags, win32.System.SystemServices.PCWSTR lpwstrFilename, uint *lpdwHandle);
        /// <inheritdoc cref = "GetFileVersionInfoEx(uint, win32.System.SystemServices.PCWSTR, uint, uint, void *)"/>
        internal static unsafe bool GetFileVersionInfoEx(uint dwFlags, string lpwstrFilename, uint dwHandle, uint dwLen, void *lpData)
        {
            fixed (char *lpwstrFilenameLocal = lpwstrFilename)
            {
                bool __result = Version.GetFileVersionInfoEx(dwFlags, lpwstrFilenameLocal, dwHandle, dwLen, lpData);
                return __result;
            }
        }

        /// <summary>Retrieves version information for the specified file.</summary>
        /// <param name = "dwFlags">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>Controls the MUI DLLs (if any) from which the version resource is extracted. The value of this flag must match the flags passed to the corresponding <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-getfileversioninfosizeexa">GetFileVersionInfoSizeEx</a> call, which was used to determine the buffer size that is passed in the <i>dwLen</i> parameter. Zero or more of the following flags.</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpwstrFilename">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The name of the file. If a full path is not specified, the function uses the search sequence specified by the <a href = "https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "dwHandle">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>This parameter is ignored.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "dwLen">
        /// <para>Type: <b>DWORD</b> The size, in bytes, of the buffer pointed to by the <i>lpData</i> parameter.</para>
        /// <para>Call the <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-getfileversioninfosizeexa">GetFileVersionInfoSizeEx</a> function first to determine the size, in bytes, of a file's version information. The <i>dwLen</i> parameter should be equal to or greater than that value. If the buffer pointed to by <i>lpData</i> is not large enough, the function truncates the file's version information to the size of the buffer.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpData">
        /// <para>Type: <b>LPVOID</b></para>
        /// <para>When this function returns, contains a pointer to a buffer that contains the file-version information.</para>
        /// <para>You can use this value in a subsequent call to the <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-verqueryvaluea">VerQueryValue</a> function to retrieve data from the buffer.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b></para>
        /// <para>If the function succeeds, the return value is nonzero.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <a href = "/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-getfileversioninfoexw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "GetFileVersionInfoExW", SetLastError = true)]
        internal static extern unsafe bool GetFileVersionInfoEx(uint dwFlags, win32.System.SystemServices.PCWSTR lpwstrFilename, uint dwHandle, uint dwLen, void *lpData);
        /// <inheritdoc cref = "VerQueryValue(void *, win32.System.SystemServices.PCWSTR, void **, uint *)"/>
        internal static unsafe bool VerQueryValue(void *pBlock, string lpSubBlock, out void *lplpBuffer, out uint puLen)
        {
            fixed (uint *puLenLocal = &puLen)
            {
                fixed (void **lplpBufferLocal = &lplpBuffer)
                {
                    fixed (char *lpSubBlockLocal = lpSubBlock)
                    {
                        bool __result = Version.VerQueryValue(pBlock, lpSubBlockLocal, lplpBufferLocal, puLenLocal);
                        return __result;
                    }
                }
            }
        }

        /// <summary>Retrieves specified version information from the specified version-information resource.</summary>
        /// <param name = "pBlock">
        /// <para>Type: <b>LPCVOID</b></para>
        /// <para>The version-information resource returned by the <a href = "https://docs.microsoft.com/windows/desktop/api/winver/nf-winver-getfileversioninfoa">GetFileVersionInfo</a> function.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verqueryvaluew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpSubBlock">
        /// <para>Type: <b>LPCTSTR</b></para>
        /// <para>The version-information value to be retrieved. The string must consist of names separated by backslashes (\\) and it must have one of the following forms.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verqueryvaluew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lplpBuffer">
        /// <para>Type: <b>LPVOID*</b></para>
        /// <para>When this method returns, contains the address of a pointer to the requested version information in the buffer pointed to by <i>pBlock</i>. The memory pointed to by <i>lplpBuffer</i> is freed when the associated <i>pBlock</i> memory is freed.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verqueryvaluew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "puLen">
        /// <para>Type: <b>PUINT</b></para>
        /// <para>When this method returns, contains a pointer to the size of the requested data pointed to by <i>lplpBuffer</i>: for version information values, the length in characters of the string stored at <i>lplpBuffer</i>; for translation array values, the size in bytes of the array stored at <i>lplpBuffer</i>; and for root block, the size in bytes of the structure.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verqueryvaluew#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b></para>
        /// <para>If the specified version-information structure exists, and version information is available, the return value is nonzero. If the address of the length buffer is zero, no value is available for the specified version-information name.</para>
        /// <para>If the specified name does not exist or the specified resource is not valid, the return value is zero.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//winver/nf-winver-verqueryvaluew">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Version", ExactSpelling = true, EntryPoint = "VerQueryValueW")]
        internal static extern unsafe bool VerQueryValue(void *pBlock, win32.System.SystemServices.PCWSTR lpSubBlock, void **lplpBuffer, uint *puLen);
    }
}