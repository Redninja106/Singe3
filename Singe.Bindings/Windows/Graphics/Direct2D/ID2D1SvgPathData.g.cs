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
        [Guid("C095E4F4-BB98-43D6-9745-4D1B84EC9888")]
        internal unsafe struct ID2D1SvgPathData
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
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            internal unsafe void GetFactory(win32.Graphics.Direct2D.ID2D1Factory**factory)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    lpVtbl->GetFactory_4(pThis, factory);
            }

            internal unsafe void GetElement([Optional] win32.Graphics.Direct2D.ID2D1SvgElement**element)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    lpVtbl->GetElement_5(pThis, element);
            }

            internal unsafe win32.System.Com.HRESULT Clone(win32.Graphics.Direct2D.ID2D1SvgAttribute**attribute)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->Clone_6(pThis, attribute);
            }

            /// <summary>Removes data from the end of the segment data array.</summary>
            /// <param name = "dataCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies how much data to remove.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-removesegmentdataatend#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-removesegmentdataatend">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT RemoveSegmentDataAtEnd(uint dataCount)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->RemoveSegmentDataAtEnd_7(pThis, dataCount);
            }

            /// <inheritdoc cref = "UpdateSegmentData(float *, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT UpdateSegmentData(ReadOnlySpan<float> data, uint startIndex)
            {
                fixed (float *dataLocal = data)
                {
                    win32.System.Com.HRESULT __result = this.UpdateSegmentData(dataLocal, (uint)data.Length, startIndex);
                    return __result;
                }
            }

            /// <summary>Updates the segment data array. Existing segment data not updated by this method are preserved. The array is resized larger if necessary to accomodate the new segment data.</summary>
            /// <param name = "data">
            /// <para>Type: <b>const FLOAT*</b></para>
            /// <para>The data array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatesegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "dataCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of data to update.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatesegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index at which to begin updating segment data. Must be less than or equal to the size of the segment data array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatesegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatesegmentdata">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT UpdateSegmentData(float *data, uint dataCount, uint startIndex)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->UpdateSegmentData_8(pThis, data, dataCount, startIndex);
            }

            /// <inheritdoc cref = "GetSegmentData(float *, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT GetSegmentData(Span<float> data, uint startIndex)
            {
                fixed (float *dataLocal = data)
                {
                    win32.System.Com.HRESULT __result = this.GetSegmentData(dataLocal, (uint)data.Length, startIndex);
                    return __result;
                }
            }

            /// <summary>Gets data from the segment data array.</summary>
            /// <param name = "data">
            /// <para>Type: <b>FLOAT*</b></para>
            /// <para>Buffer to contain the segment data array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "dataCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The element count of the buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index of the first segment data to retrieve.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdata#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdata">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetSegmentData(float *data, uint dataCount, uint startIndex)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->GetSegmentData_9(pThis, data, dataCount, startIndex);
            }

            /// <summary>Gets the size of the segment data array.</summary>
            /// <returns>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Returns the size of the segment data array.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdatacount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetSegmentDataCount()
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->GetSegmentDataCount_10(pThis);
            }

            /// <summary>Removes commands from the end of the commands array.</summary>
            /// <param name = "commandsCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Specifies how many commands to remove.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-removecommandsatend#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-removecommandsatend">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT RemoveCommandsAtEnd(uint commandsCount)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->RemoveCommandsAtEnd_11(pThis, commandsCount);
            }

            /// <inheritdoc cref = "UpdateCommands(win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT UpdateCommands(ReadOnlySpan<win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND> commands, uint startIndex)
            {
                fixed (win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*commandsLocal = commands)
                {
                    win32.System.Com.HRESULT __result = this.UpdateCommands(commandsLocal, (uint)commands.Length, startIndex);
                    return __result;
                }
            }

            /// <summary>Updates the commands array. Existing commands not updated by this method are preserved. The array is resized larger if necessary to accomodate the new commands.</summary>
            /// <param name = "commands">
            /// <para>Type: <b>const <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1svg/ne-d2d1svg-d2d1_svg_path_command">D2D1_SVG_PATH_COMMAND</a>*</b></para>
            /// <para>The commands array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatecommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "commandsCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of commands to update.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatecommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index at which to begin updating commands. Must be less than or equal to the size of the commands array.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatecommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatecommands">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT UpdateCommands(win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*commands, uint commandsCount, uint startIndex)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->UpdateCommands_12(pThis, commands, commandsCount, startIndex);
            }

            /// <inheritdoc cref = "GetCommands(win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*, uint, uint)"/>
            internal unsafe win32.System.Com.HRESULT GetCommands(Span<win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND> commands, uint startIndex)
            {
                fixed (win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*commandsLocal = commands)
                {
                    win32.System.Com.HRESULT __result = this.GetCommands(commandsLocal, (uint)commands.Length, startIndex);
                    return __result;
                }
            }

            /// <summary>Gets commands from the commands array.</summary>
            /// <param name = "commands">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1svg/ne-d2d1svg-d2d1_svg_path_command">D2D1_SVG_PATH_COMMAND</a>*</b></para>
            /// <para>Buffer to contain the commands.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "commandsCount">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The element count of the buffer.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "startIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The index of the first commands to retrieve.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommands#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommands">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT GetCommands(win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*commands, uint commandsCount, uint startIndex)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->GetCommands_13(pThis, commands, commandsCount, startIndex);
            }

            /// <summary>Gets the size of the commands array.</summary>
            /// <returns>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>Returns the size of the commands array.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommandscount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetCommandsCount()
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->GetCommandsCount_14(pThis);
            }

            /// <summary>Creates a path geometry object representing the path data.</summary>
            /// <param name = "fillMode">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1/ne-d2d1-d2d1_fill_mode">D2D1_FILL_MODE</a></b></para>
            /// <para>Fill mode for the path geometry object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-createpathgeometry#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "pathGeometry">
            /// <para>Type: <b>ID2D1PathGeometry1**</b></para>
            /// <para>On completion, pathGeometry will contain a point to the created <a href = "https://docs.microsoft.com/windows/desktop/api/d2d1_1/nn-d2d1_1-id2d1pathgeometry1">ID2D1PathGeometry1</a> object.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-createpathgeometry#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b><a href = "/windows/win32/com/structure-of-com-error-codes">HRESULT</a></b></para>
            /// <para>This method returns an HRESULT success or error code.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1svg/nf-d2d1svg-id2d1svgpathdata-createpathgeometry">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT CreatePathGeometry(win32.Graphics.Direct2D.D2D1_FILL_MODE fillMode, win32.Graphics.Direct2D.ID2D1PathGeometry1**pathGeometry)
            {
                fixed (ID2D1SvgPathData*pThis = &this)
                    return lpVtbl->CreatePathGeometry_15(pThis, fillMode, pathGeometry);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.ID2D1Factory**, void>GetFactory_4;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.ID2D1SvgElement**, void>GetElement_5;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.ID2D1SvgAttribute**, win32.System.Com.HRESULT>Clone_6;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint, win32.System.Com.HRESULT>RemoveSegmentDataAtEnd_7;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, float *, uint, uint, win32.System.Com.HRESULT>UpdateSegmentData_8;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, float *, uint, uint, win32.System.Com.HRESULT>GetSegmentData_9;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint>GetSegmentDataCount_10;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint, win32.System.Com.HRESULT>RemoveCommandsAtEnd_11;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*, uint, uint, win32.System.Com.HRESULT>UpdateCommands_12;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.D2D1_SVG_PATH_COMMAND*, uint, uint, win32.System.Com.HRESULT>GetCommands_13;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, uint>GetCommandsCount_14;
                internal delegate *unmanaged[Stdcall]<ID2D1SvgPathData*, win32.Graphics.Direct2D.D2D1_FILL_MODE, win32.Graphics.Direct2D.ID2D1PathGeometry1**, win32.System.Com.HRESULT>CreatePathGeometry_15;
            }

            private Vtbl*lpVtbl;
        }
    }
}