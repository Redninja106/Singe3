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

    namespace Graphics.Direct3D10
    {
        /// <summary>Query types.</summary>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d10/ne-d3d10-d3d10_query">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D10_QUERY
        {
            /// <summary>Determines whether or not the GPU is finished processing commands. When the GPU is finished processing commands <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> will return S_OK, and pData will point to a BOOL with a value of <b>TRUE</b>. When using this type of query, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> is disabled.</summary>
            D3D10_QUERY_EVENT = 0,
            /// <summary>Get the number of samples that passed the depth and stencil tests in between <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-end">End</a>. <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> returns a UINT64. If a depth or stencil test is disabled, then each of those tests will be counted as a pass.</summary>
            D3D10_QUERY_OCCLUSION = 1,
            /// <summary>Get a timestamp value where <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> returns a UINT64. This kind of query is only useful if two timestamp queries are done in the middle of a D3D10_QUERY_TIMESTAMP_DISJOINT query. The difference of two timestamps can be used to determine how many ticks have elapsed, and the D3D10_QUERY_TIMESTAMP_DISJOINT query will determine if that difference is a reliable value and also has a value that shows how to convert the number of ticks into seconds. See <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_query_data_timestamp_disjoint">D3D10_QUERY_DATA_TIMESTAMP_DISJOINT</a>. When using this type of query, <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> is disabled.</summary>
            D3D10_QUERY_TIMESTAMP = 2,
            /// <summary>Determines whether or not a D3D10_QUERY_TIMESTAMP is returning reliable values, and also gives the frequency of the processor enabling you to convert the number of elapsed ticks into seconds. <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> will return a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_query_data_timestamp_disjoint">D3D10_QUERY_DATA_TIMESTAMP_DISJOINT</a>. This type of query should only be invoked once per frame or less.</summary>
            D3D10_QUERY_TIMESTAMP_DISJOINT = 3,
            /// <summary>Get pipeline statistics, such as the number of pixel shader invocations in between <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-end">End</a>. <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> will return a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_query_data_pipeline_statistics">D3D10_QUERY_DATA_PIPELINE_STATISTICS</a>.</summary>
            D3D10_QUERY_PIPELINE_STATISTICS = 4,
            /// <summary>Similar to D3D10_QUERY_OCCLUSION, except <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> returns a BOOL indicating whether or not any samples passed the depth and stencil tests - <b>TRUE</b> meaning at least one passed, <b>FALSE</b> meaning none passed.</summary>
            D3D10_QUERY_OCCLUSION_PREDICATE = 5,
            /// <summary>Get streaming output statistics, such as the number of primitives streamed out in between <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-end">End</a>. <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> will return a <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/ns-d3d10-d3d10_query_data_so_statistics">D3D10_QUERY_DATA_SO_STATISTICS</a> structure.</summary>
            D3D10_QUERY_SO_STATISTICS = 6,
            /// <summary>Determines whether or not any of the streaming output buffers overflowed in between <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-begin">Begin</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-end">End</a>. <a href = "https://docs.microsoft.com/windows/desktop/api/d3d10/nf-d3d10-id3d10asynchronous-getdata">GetData</a> returns a BOOL - <b>TRUE</b> meaning there was an overflow, <b>FALSE</b> meaning there was not an overflow. If streaming output writes to multiple buffers, and one of the buffers overflows, then it will stop writing to all the output buffers. When an overflow is detected by Direct3D it is prevented from happening - no memory is corrupted. This predication may be used in conjunction with an SO_STATISTICS query so that when an overflow occurs the SO_STATISTIC query will let the application know how much memory was needed to prevent an overflow.</summary>
            D3D10_QUERY_SO_OVERFLOW_PREDICATE = 7,
        }
    }
}