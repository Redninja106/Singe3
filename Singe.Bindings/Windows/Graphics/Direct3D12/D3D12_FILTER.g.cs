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

    namespace Graphics.Direct3D12
    {
        /// <summary>Specifies filtering options during texture sampling.</summary>
        /// <remarks>
        /// <para>This enum is used by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ns-d3d12-d3d12_sampler_desc">D3D12_SAMPLER_DESC</a> structure.</para>
        /// <para><div class = "alert"><b>Note</b>  If you use different filter types for min versus mag filter, undefined behavior occurs in certain cases where the choice between whether magnification or minification happens is ambiguous.  To prevent this undefined behavior, use filter modes that use similar filter operations for both min and mag (or use anisotropic filtering, which avoids the issue as well).</div> <div> </div> During texture sampling, one or more texels are read and combined (this is calling filtering) to produce a single value. Point sampling reads a single texel while linear sampling reads two texels (endpoints) and linearly interpolates a third value between the endpoints.</para>
        /// <para>Microsoft High Level Shader Language (HLSL) texture-sampling functions also support comparison filtering during texture sampling. Comparison filtering compares each sampled texel against a comparison value. The boolean result is blended the same way that normal texture filtering is blended.</para>
        /// <para>You can use HLSL intrinsic texture-sampling functions that implement texture filtering only or companion functions that use texture filtering with comparison filtering.</para>
        /// <para>Also note the following defines:</para>
        /// <para><pre class = "syntax"xml: space = "preserve"><code>#define	D3D12_FILTER_REDUCTION_TYPE_MASK	( 0x3 )</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d12/ne-d3d12-d3d12_filter#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal enum D3D12_FILTER
        {
            /// <summary>Use point sampling for minification, magnification, and mip-level sampling.</summary>
            D3D12_FILTER_MIN_MAG_MIP_POINT = 0,
            /// <summary>Use point sampling for minification and magnification; use linear interpolation for mip-level sampling.</summary>
            D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR = 1,
            /// <summary>Use point sampling for minification; use linear interpolation for magnification; use point sampling for mip-level sampling.</summary>
            D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 4,
            /// <summary>Use point sampling for minification; use linear interpolation for magnification and mip-level sampling.</summary>
            D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR = 5,
            /// <summary>Use linear interpolation for minification; use point sampling for magnification and mip-level sampling.</summary>
            D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT = 16,
            /// <summary>Use linear interpolation for minification; use point sampling for magnification; use linear interpolation for mip-level sampling.</summary>
            D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 17,
            /// <summary>Use linear interpolation for minification and magnification; use point sampling for mip-level sampling.</summary>
            D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT = 20,
            /// <summary>Use linear interpolation for minification, magnification, and mip-level sampling.</summary>
            D3D12_FILTER_MIN_MAG_MIP_LINEAR = 21,
            /// <summary>Use anisotropic interpolation for minification, magnification, and mip-level sampling.</summary>
            D3D12_FILTER_ANISOTROPIC = 85,
            /// <summary>Use point sampling for minification, magnification, and mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 128,
            /// <summary>Use point sampling for minification and magnification; use linear interpolation for mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 129,
            /// <summary>Use point sampling for minification; use linear interpolation for magnification; use point sampling for mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 132,
            /// <summary>Use point sampling for minification; use linear interpolation for magnification and mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 133,
            /// <summary>Use linear interpolation for minification; use point sampling for magnification and mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 144,
            /// <summary>Use linear interpolation for minification; use point sampling for magnification; use linear interpolation for mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 145,
            /// <summary>Use linear interpolation for minification and magnification; use point sampling for mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 148,
            /// <summary>Use linear interpolation for minification, magnification, and mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 149,
            /// <summary>Use anisotropic interpolation for minification, magnification, and mip-level sampling. Compare the result to the comparison value.</summary>
            D3D12_FILTER_COMPARISON_ANISOTROPIC = 213,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_MIP_POINT</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT = 256,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR = 257,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 260,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR = 261,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT = 272,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 273,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT = 276,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_MIP_LINEAR</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR = 277,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_ANISOTROPIC</a> and instead of filtering them return the minimum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the minimum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MINIMUM_ANISOTROPIC = 341,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_MIP_POINT</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT = 384,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR = 385,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 388,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR = 389,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT = 400,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 401,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT = 404,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_MIN_MAG_MIP_LINEAR</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR = 405,
            /// <summary>Fetch the same set of texels as <a href = "https://docs.microsoft.com/windows/desktop/api/d3d12/ne-d3d12-d3d12_filter">D3D12_FILTER_ANISOTROPIC</a> and instead of filtering them return the maximum of the texels.  Texels that are weighted 0 during filtering aren't counted towards the maximum.  You can query support for this filter type from the <b>MinMaxFiltering</b> member in the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1">D3D11_FEATURE_DATA_D3D11_OPTIONS1</a> structure.</summary>
            D3D12_FILTER_MAXIMUM_ANISOTROPIC = 469,
        }
    }
}