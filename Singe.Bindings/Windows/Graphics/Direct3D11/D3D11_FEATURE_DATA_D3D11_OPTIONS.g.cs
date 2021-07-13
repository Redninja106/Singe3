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

    namespace Graphics.Direct3D11
    {
        /// <summary>Describes Direct3D 11.1 feature options in the current graphics driver.</summary>
        /// <remarks>
        /// <para>If a Microsoft Direct3D device supports <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 11.1 (<a href = "https://docs.microsoft.com/windows/desktop/api/d3dcommon/ne-d3dcommon-d3d_feature_level">D3D_FEATURE_LEVEL_11_1</a>), when you call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11device-checkfeaturesupport">ID3D11Device::CheckFeatureSupport</a> with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_feature">D3D11_FEATURE_D3D11_OPTIONS</a>, <b>CheckFeatureSupport</b> returns a pointer to <b>D3D11_FEATURE_DATA_D3D11_OPTIONS</b> with all member set to <b>TRUE</b> except the <b>SAD4ShaderInstructions</b> and <b>ExtendedDoublesShaderInstructions</b> members, which are optionally supported by the hardware and driver and therefore can be <b>TRUE</b> or <b>FALSE</b>.</para>
        /// <para><a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">Feature level</a> 11.1 provides the following additional features:</para>
        /// <para></para>
        /// <para>This doc was truncated.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#">Read more on docs.microsoft.com</see>.</para>
        /// </remarks>
        internal partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
        {
            /// <summary>Specifies whether logic operations are available in blend state. The runtime sets this member to <b>TRUE</b> if logic operations are available in blend state and <b>FALSE</b> otherwise. This member is <b>FALSE</b> for <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3. This member is optional for feature level 10, 10.1, and 11. This member is <b>TRUE</b> for feature level 11.1.</summary>
            internal win32.System.SystemServices.BOOL OutputMergerLogicOp;
            /// <summary>Specifies whether the driver can render with no render target views (RTVs) or depth stencil views (DSVs), and only unordered access views (UAVs) bound. The runtime sets this member to <b>TRUE</b> if the driver can render with no RTVs or DSVs and only UAVs bound and <b>FALSE</b> otherwise. If <b>TRUE</b>, you can set the <b>ForcedSampleCount</b> member of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/ns-d3d11_1-cd3d11_rasterizer_desc1">D3D11_RASTERIZER_DESC1</a> to 1, 4, or 8 when you render with no RTVs or DSV and only UAVs bound. For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 11.1, this member is always <b>TRUE</b> and you can also set <b>ForcedSampleCount</b> to 16 in addition to 1, 4, or 8. The default value of <b>ForcedSampleCount</b> is 0, which means the same as if the value is set to 1. You can always set <b>ForcedSampleCount</b> to 0 or 1 for UAV-only rendering independently of how this member is set.</summary>
            internal win32.System.SystemServices.BOOL UAVOnlyRenderingForcedSampleCount;
            /// <summary>Specifies whether the driver supports the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardview">ID3D11DeviceContext1::DiscardView</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardresource">ID3D11DeviceContext1::DiscardResource</a> methods. The runtime sets this member to <b>TRUE</b> if the driver supports these methods and <b>FALSE</b> otherwise. How this member is set does not indicate whether the driver actually uses these methods; that is, the driver might ignore these methods if they are not useful to the hardware. If <b>FALSE</b>, the runtime does not expose these methods to the driver because the driver does not support them. You can monitor this member during development to rule out legacy drivers on hardware where these methods might have otherwise been beneficial. You are not required to write separate code paths based on whether this member is <b>TRUE</b> or <b>FALSE</b>; you can call these methods whenever applicable.</summary>
            internal win32.System.SystemServices.BOOL DiscardAPIsSeenByDriver;
            /// <summary>Specifies whether the driver supports new semantics for copy and update that are exposed by the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-copysubresourceregion1">ID3D11DeviceContext1::CopySubresourceRegion1</a> and <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-updatesubresource1">ID3D11DeviceContext1::UpdateSubresource1</a> methods. The runtime sets this member to <b>TRUE</b> if the driver supports new semantics for copy and update. The runtime sets this member to <b>FALSE</b> only for legacy drivers. The runtime handles this member similarly to the <b>DiscardAPIsSeenByDriver</b> member.</summary>
            internal win32.System.SystemServices.BOOL FlagsForUpdateAndCopySeenByDriver;
            /// <summary>
            /// <para>Specifies whether the driver supports the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-clearview">ID3D11DeviceContext1::ClearView</a> method. The runtime sets this member to <b>TRUE</b> if the driver supports this method and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime does not expose this method to the driver because the driver does not support it.</para>
            /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3, this member is always <b>TRUE</b> because the option is emulated by the runtime.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL ClearView;
            /// <summary>
            /// <para>Specifies whether you can call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-copysubresourceregion1">ID3D11DeviceContext1::CopySubresourceRegion1</a> with overlapping source and destination rectangles. The runtime sets this member to <b>TRUE</b> if you can call <b>CopySubresourceRegion1</b> with overlapping source and destination rectangles and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime does not expose this method to the driver because the driver does not support it.</para>
            /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3, this member is always <b>TRUE</b> because drivers already support the option for these feature levels.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL CopyWithOverlap;
            /// <summary>
            /// <para>Specifies whether the driver supports partial updates of constant buffers. The runtime sets this member to <b>TRUE</b> if the driver supports partial updates of constant buffers and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime does not expose this operation to the driver because the driver does not support it.</para>
            /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3, this member is always <b>TRUE</b> because the option is emulated by the runtime.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL ConstantBufferPartialUpdate;
            /// <summary>
            /// <para>Specifies whether the driver supports new semantics for setting offsets in constant buffers for a shader. The runtime sets this member to <b>TRUE</b> if the driver supports allowing you to specify offsets when you call new methods like the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-vssetconstantbuffers1">ID3D11DeviceContext1::VSSetConstantBuffers1</a> method and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime does not expose this operation to the driver because the driver does not support it.</para>
            /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3, this member is always <b>TRUE</b> because the option is emulated by the runtime.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL ConstantBufferOffsetting;
            /// <summary>
            /// <para>Specifies whether you can call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-map">ID3D11DeviceContext::Map</a> with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_map">D3D11_MAP_WRITE_NO_OVERWRITE</a> on a dynamic constant buffer (that is, whether the driver supports this operation). The runtime sets this member to <b>TRUE</b> if the driver supports this operation and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime fails this method because the driver does not support the operation.</para>
            /// <para><div class = "alert"><b>Note</b>  For <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 9.1, 9.2, and 9.3, this member is always <b>TRUE</b> because the option is emulated by the runtime.</div> <div> </div></para>
            /// <para><see href = "https://docs.microsoft.com/windows/win32/api//d3d11/ns-d3d11-d3d11_feature_data_d3d11_options#members">Read more on docs.microsoft.com</see>.</para>
            /// </summary>
            internal win32.System.SystemServices.BOOL MapNoOverwriteOnDynamicConstantBuffer;
            /// <summary>Specifies whether you can call <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-id3d11devicecontext-map">ID3D11DeviceContext::Map</a> with <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_map">D3D11_MAP_WRITE_NO_OVERWRITE</a> on a dynamic buffer SRV (that is, whether the driver supports this operation). The runtime sets this member to <b>TRUE</b> if the driver supports this operation and <b>FALSE</b> otherwise. If <b>FALSE</b>, the runtime fails this method because the driver does not support the operation.</summary>
            internal win32.System.SystemServices.BOOL MapNoOverwriteOnDynamicBufferSRV;
            /// <summary>Specifies whether the driver supports multisample rendering when you render with RTVs bound. If <b>TRUE</b>, you can set the <b>ForcedSampleCount</b> member of <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11_1/ns-d3d11_1-cd3d11_rasterizer_desc1">D3D11_RASTERIZER_DESC1</a> to 1 with a multisample RTV bound. The driver can support this option on <a href = "https://docs.microsoft.com/windows/desktop/direct3d11/overviews-direct3d-11-devices-downlevel-intro">feature level</a> 10 and higher. If <b>FALSE</b>, the rasterizer-state creation will fail because the driver is legacy or the feature level is too low.</summary>
            internal win32.System.SystemServices.BOOL MultisampleRTVWithForcedSampleCountOne;
            /// <summary>Specifies whether the hardware and driver support the <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/dx-graphics-hlsl-msad4">msad4</a> intrinsic function in shaders. The runtime sets this member to <b>TRUE</b> if the hardware and driver support calls to <b>msad4</b> intrinsic functions in shaders. If <b>FALSE</b>, the driver is legacy or the hardware does not support the option; the runtime will fail shader creation for shaders that use <b>msad4</b>.</summary>
            internal win32.System.SystemServices.BOOL SAD4ShaderInstructions;
            /// <summary>Specifies whether the hardware and driver support the <a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/dx-graphics-hlsl-fma">fma</a> intrinsic function and other extended doubles instructions (<b>DDIV</b> and <b>DRCP</b>) in shaders. The <b>fma</b> intrinsic function emits an extended doubles <b>DFMA</b> instruction. The runtime sets this member to <b>TRUE</b> if the hardware and driver support extended doubles instructions in shaders (<a href = "https://docs.microsoft.com/windows/desktop/direct3dhlsl/d3d11-graphics-reference-sm5">shader model 5</a> and higher). Support of this option implies support of basic double-precision shader instructions as well. You can use the <a href = "https://docs.microsoft.com/windows/desktop/api/d3d11/ne-d3d11-d3d11_feature">D3D11_FEATURE_DOUBLES</a> value to query for support of double-precision shaders. If <b>FALSE</b>, the hardware and driver do not support the option; the runtime will fail shader creation for shaders that use extended doubles instructions.</summary>
            internal win32.System.SystemServices.BOOL ExtendedDoublesShaderInstructions;
            /// <summary>Specifies whether the hardware and driver have [extended support for shared Texture2D resource types and formats](/windows/win32/direct3d11/direct3d-11-1-features#extended-support-for-shared-texture2d-resources). The runtime sets this member to <b>TRUE</b> if the hardware and driver support extended Texture2D resource sharing.</summary>
            internal win32.System.SystemServices.BOOL ExtendedResourceSharing;
        }
    }
}