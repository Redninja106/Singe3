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
        [Guid("13D29038-C3E6-4034-9081-13B53A417992")]
        internal unsafe struct ID2D1TransformGraph
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
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->QueryInterface_1(pThis, riid, ppvObject);
            }

            internal uint AddRef()
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->AddRef_2(pThis);
            }

            internal uint Release()
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->Release_3(pThis);
            }

            /// <summary>Returns the number of inputs to the transform graph.</summary>
            /// <returns>
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The number of inputs to this transform graph.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-getinputcount">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal uint GetInputCount()
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->GetInputCount_4(pThis);
            }

            /// <summary>Sets a single transform node as being equivalent to the whole graph.</summary>
            /// <param name = "node">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node to be set.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setsingletransformnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setsingletransformnode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetSingleTransformNode(win32.Graphics.Direct2D.ID2D1TransformNode*node)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->SetSingleTransformNode_5(pThis, node);
            }

            /// <summary>Adds the provided node to the transform graph.</summary>
            /// <param name = "node">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node that will be added to the transform graph.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-addnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-addnode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT AddNode(win32.Graphics.Direct2D.ID2D1TransformNode*node)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->AddNode_6(pThis, node);
            }

            /// <summary>Removes the provided node from the transform graph.</summary>
            /// <param name = "node">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node that will be removed from the transform graph.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-removenode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-removenode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT RemoveNode(win32.Graphics.Direct2D.ID2D1TransformNode*node)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->RemoveNode_7(pThis, node);
            }

            /// <summary>Sets the output node for the transform graph.</summary>
            /// <param name = "node">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node that will be considered the output of the transform node.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setoutputnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setoutputnode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT SetOutputNode(win32.Graphics.Direct2D.ID2D1TransformNode*node)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->SetOutputNode_8(pThis, node);
            }

            /// <summary>Connects two nodes inside the transform graph.</summary>
            /// <param name = "fromNode">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node from which the connection will be made.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "toNode">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node to which the connection will be made.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "toNodeInputIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The node input that will be connected.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ConnectNode(win32.Graphics.Direct2D.ID2D1TransformNode*fromNode, win32.Graphics.Direct2D.ID2D1TransformNode*toNode, uint toNodeInputIndex)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->ConnectNode_9(pThis, fromNode, toNode, toNodeInputIndex);
            }

            /// <summary>Connects a transform node inside the graph to the corresponding effect input of the encapsulating effect.</summary>
            /// <param name = "toEffectInputIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The effect input to which the transform node will be bound.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "node">
            /// <para>Type: <b><a href = "https://docs.microsoft.com/windows/desktop/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode">ID2D1TransformNode</a>*</b></para>
            /// <para>The node to which the connection will be made.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <param name = "toNodeInputIndex">
            /// <para>Type: <b>UINT32</b></para>
            /// <para>The node input that will be connected.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput#parameters">Read more on docs.microsoft.com</see>.</para>
            /// </param>
            /// <returns>
            /// <para>Type: <b>HRESULT</b></para>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal unsafe win32.System.Com.HRESULT ConnectToEffectInput(uint toEffectInputIndex, win32.Graphics.Direct2D.ID2D1TransformNode*node, uint toNodeInputIndex)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->ConnectToEffectInput_10(pThis, toEffectInputIndex, node, toNodeInputIndex);
            }

            /// <summary>Clears the transform nodes and all connections from the transform graph.</summary>
            /// <remarks>
            /// <para>Used when enough changes to transfoms would make  editing of the transform graph inefficient.</para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-clear#">Read more on docs.microsoft.com</see>.</para>
            /// </remarks>
            internal void Clear()
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    lpVtbl->Clear_11(pThis);
            }

            /// <summary>Uses the specified input as the effect output.</summary>
            /// <param name = "effectInputIndex">The index of the input to the effect.</param>
            /// <returns>
            /// <para>The method returns an <b>HRESULT</b>. Possible values include, but are not limited to, those in the following table.</para>
            /// <para></para>
            /// <para>This doc was truncated.</para>
            /// </returns>
            /// <remarks>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setpassthroughgraph">Learn more about this API from docs.microsoft.com</see>.</para>
            /// </remarks>
            internal win32.System.Com.HRESULT SetPassthroughGraph(uint effectInputIndex)
            {
                fixed (ID2D1TransformGraph*pThis = &this)
                    return lpVtbl->SetPassthroughGraph_12(pThis, effectInputIndex);
            }

            private struct Vtbl
            {
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, global::System.Guid*, void **, win32.System.Com.HRESULT>QueryInterface_1;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, uint>AddRef_2;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, uint>Release_3;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, uint>GetInputCount_4;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, win32.Graphics.Direct2D.ID2D1TransformNode*, win32.System.Com.HRESULT>SetSingleTransformNode_5;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, win32.Graphics.Direct2D.ID2D1TransformNode*, win32.System.Com.HRESULT>AddNode_6;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, win32.Graphics.Direct2D.ID2D1TransformNode*, win32.System.Com.HRESULT>RemoveNode_7;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, win32.Graphics.Direct2D.ID2D1TransformNode*, win32.System.Com.HRESULT>SetOutputNode_8;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, win32.Graphics.Direct2D.ID2D1TransformNode*, win32.Graphics.Direct2D.ID2D1TransformNode*, uint, win32.System.Com.HRESULT>ConnectNode_9;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, uint, win32.Graphics.Direct2D.ID2D1TransformNode*, uint, win32.System.Com.HRESULT>ConnectToEffectInput_10;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, void>Clear_11;
                internal delegate *unmanaged[Stdcall]<ID2D1TransformGraph*, uint, win32.System.Com.HRESULT>SetPassthroughGraph_12;
            }

            private Vtbl*lpVtbl;
        }
    }
}