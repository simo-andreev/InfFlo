#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective

#region Using

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Khronos;

#endregion

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL] Value of GL_UNSIGNED_BYTE_3_3_2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_packed_pixels")]
        public const int UNSIGNED_BYTE_3_3_2 = 0x8032;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_4_4_4_4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_packed_pixels")]
        public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_5_5_5_1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_packed_pixels")]
        public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_8_8_8_8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_packed_pixels")]
        public const int UNSIGNED_INT_8_8_8_8 = 0x8035;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_10_10_10_2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_packed_pixels")]
        public const int UNSIGNED_INT_10_10_10_2 = 0x8036;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_3D.
        /// The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
        public const int TEXTURE_BINDING_3D = 0x806A;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is written into memory.
        /// The initial value is 0. See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int PACK_SKIP_IMAGES = 0x806B;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the image height used for writing pixel data to memory. The initial value is 0.
        /// See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int PACK_IMAGE_HEIGHT = 0x806C;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is read from
        ///     memory. The
        ///     initial value is 0. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is read from
        ///     memory.
        ///     The initial value is 0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int UNPACK_SKIP_IMAGES = 0x806D;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the image height used for reading pixel data from memory. The initial is 0.
        ///     See
        ///     Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the image height used for reading pixel data from memory. The initial is
        ///     0.
        ///     See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int UNPACK_IMAGE_HEIGHT = 0x806E;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, three-dimensional texturing is performed (unless
        ///     cube-mapped texturing is also enabled). See Gl.TexImage3D.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 3D texture mapping is enabled. The initial
        ///     value is Gl.FALSE. See Gl.TexImage3D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture3D")]
        [RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
        public const int TEXTURE_3D = 0x806F;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_3D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int PROXY_TEXTURE_3D = 0x8070;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the depth of the texture image. The initial value
        /// is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D")]
        public const int TEXTURE_DEPTH = 0x8071;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued wrapping function for texture coordinate r, a
        ///     symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued wrapping function for texture coordinate r, a symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D")] [RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
        public const int TEXTURE_WRAP_R = 0x8072;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value
        ///     must
        ///     be at least 64. Use Gl.PROXY_TEXTURE_3D to determine if a texture is too large. See Gl.TexImage3D.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The
        ///     value
        ///     must be at least 256. See Gl.TexImage3D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D")] [RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
        public const int MAX_3D_TEXTURE_SIZE = 0x8073;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_BYTE_2_3_3_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] public const int UNSIGNED_BYTE_2_3_3_REV = 0x8362;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_5_6_5 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int UNSIGNED_SHORT_5_6_5 = 0x8363;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_5_6_5_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] public const int UNSIGNED_SHORT_5_6_5_REV = 0x8364;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_4_4_4_4_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")] [RequiredByFeature("GL_IMG_read_format", Api = "gles1|gles2")]
        public const int UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_SHORT_1_5_5_5_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
        public const int UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_8_8_8_8_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] public const int UNSIGNED_INT_8_8_8_8_REV = 0x8367;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_2_10_10_10_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_type_2_10_10_10_REV", Api = "gles2")]
        public const int UNSIGNED_INT_2_10_10_10_REV = 0x8368;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a three-component group: red first, followed by green, followed by blue; for
        ///     Gl.BGR, the first component is blue, followed by green and then red. Each component is converted to the internal
        ///     floating-point format in the same way the red, green, and blue components of an RGBA pixel are. The color triple is
        ///     converted to an RGBA pixel with alpha set to 1. After this conversion, the pixel is treated as if it had been read
        ///     as an
        ///     RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is an RGB triple. The GL converts it to floating point and assembles it into an
        ///     RGBA
        ///     element by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to
        ///     the
        ///     signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is an RGB triple. The GL converts it to floating point and assembles it into an
        ///     RGBA
        ///     element by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to
        ///     the
        ///     signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is an RGB triple. The GL converts it to floating point and assembles it into an
        ///     RGBA
        ///     element by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to
        ///     the
        ///     signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_bgra")]
        public const int BGR = 0x80E0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a four-component group: For Gl.RGBA, the red component is first, followed by
        ///     green,
        ///     followed by blue, followed by alpha; for Gl.BGRA the order is blue, green, red and then alpha. Floating-point
        ///     values are
        ///     converted directly to an internal floating-point format with unspecified precision. Signed integer values are
        ///     mapped
        ///     linearly to the internal floating-point format such that the most positive representable integer value maps to 1.0,
        ///     and
        ///     the most negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0.)
        ///     Unsigned integer data is mapped similarly: The largest integer value maps to 1.0, and 0 maps to 0.0. The resulting
        ///     floating-point color values are then multiplied by Gl.c_SCALE and added to Gl.c_BIAS, where c is RED, GREEN, BLUE,
        ///     and
        ///     ALPHA for the respective color components. The results are clamped to the range 01. If Gl.MAP_COLOR is true, each
        ///     color
        ///     component is scaled by the size of lookup table Gl.PIXEL_MAP_c_TO_c, then replaced by the value that it references
        ///     in
        ///     that table. c is R, G, B, or A respectively. The GL then converts the resulting RGBA colors to fragments by
        ///     attaching
        ///     the current raster position z coordinate and texture coordinates to each pixel, then assigning x and y window
        ///     coordinates to the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr is the current raster position.
        ///     These
        ///     pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or polygons.
        ///     Texture
        ///     mapping, fog, and all the fragment operations are applied before the fragments are written to the frame buffer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element contains all four components. Each component is multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element contains all four components. Each component is multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element contains all four components. Each component is multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ARB_vertex_array_bgra", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_array_bgra")]
        [RequiredByFeature("GL_APPLE_texture_format_BGRA8888", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_bgra")]
        [RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_texture_format_BGRA8888", Api = "gles1|gles2")]
        [RequiredByFeature("GL_IMG_read_format", Api = "gles1|gles2")]
        public const int BGRA = 0x80E1;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the recommended maximum number of vertex array vertices. See
        /// Gl.DrawRangeElements.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_draw_range_elements")]
        public const int MAX_ELEMENTS_VERTICES = 0x80E8;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the recommended maximum number of vertex array indices. See
        /// Gl.DrawRangeElements.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_draw_range_elements")]
        public const int MAX_ELEMENTS_INDICES = 0x80E9;

        /// <summary>
        /// [GL] Value of GL_CLAMP_TO_EDGE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_SGIS_texture_edge_clamp")]
        public const int CLAMP_TO_EDGE = 0x812F;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued texture minimum level-of-detail value. The initial
        ///     value
        ///     is -1000.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued texture minimum level-of-detail value. The initial
        ///     value is
        ///     -1000.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_SGIS_texture_lod")]
        public const int TEXTURE_MIN_LOD = 0x813A;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued texture maximum level-of-detail value. The initial
        ///     value
        ///     is 1000.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued texture maximum level-of-detail value. The initial
        ///     value is
        ///     1000.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_SGIS_texture_lod")]
        public const int TEXTURE_MAX_LOD = 0x813B;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued base texture mipmap level. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_SGIS_texture_lod")]
        public const int TEXTURE_BASE_LEVEL = 0x813C;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued maximum texture mipmap array level. The initial value is
        /// 1000.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_texture_max_level", Api = "gles1|gles2")]
        [RequiredByFeature("GL_SGIS_texture_lod")]
        public const int TEXTURE_MAX_LEVEL = 0x813D;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a pair of values indicating the range of widths supported for aliased lines. See
        /// Gl.LineWidth.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, normal vectors are scaled after transformation and
        ///     before
        ///     lighting by a factor computed from the modelview matrix. If the modelview matrix scales space uniformly, this has
        ///     the
        ///     effect of restoring the transformed normal to unit length. This method is generally more efficient than
        ///     Gl.NORMALIZE.
        ///     See Gl.Normal and Gl.NormalPointer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns single boolean value indicating whether normal rescaling is enabled. See Gl.Enable.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, normal vectors are scaled after transformation and before lighting by a factor
        ///     computed
        ///     from the modelview matrix. If the modelview matrix scales space uniformly, this has the effect of restoring the
        ///     transformed normal to unit length. This method is generally more efficient than Gl.NORMALIZE. See Gl.Normal and
        ///     Gl.NormalPointer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether rescaling of normals is enabled. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.Normal.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_EXT_rescale_normal")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RESCALE_NORMAL = 0x803A;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns single enumerated value indicating whether specular reflection calculations are
        ///     separated
        ///     from normal lighting computations. The initial value is Gl.SINGLE_COLOR.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.LightModel: params must be either Gl.SEPARATE_SPECULAR_COLOR or Gl.SINGLE_COLOR. Gl.SINGLE_COLOR
        ///     specifies
        ///     that a single color is generated from the lighting computation for a vertex. Gl.SEPARATE_SPECULAR_COLOR specifies
        ///     that
        ///     the specular color computation of lighting be stored separately from the remainder of the lighting computation. The
        ///     specular color is summed into the generated fragment's color after the application of texture mapping (if enabled).
        ///     The
        ///     initial value is Gl.SINGLE_COLOR.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_EXT_separate_specular_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns two values, the smallest and largest supported sizes for aliased points.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns two values: the smallest and largest supported sizes for points. The smallest size
        ///     must
        ///     be at most 1, and the largest size must be at least 1.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALIASED_POINT_SIZE_RANGE = 0x846D;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawRangeElements: render primitives from array data
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="start">
        /// Specifies the minimum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="end">
        /// Specifies the maximum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in <paramref name="indices" />. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or
        /// Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_range_elements")]
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
        {
            Debug.Assert(Delegates.pglDrawRangeElements != null, "pglDrawRangeElements not implemented");
            Delegates.pglDrawRangeElements((int) mode, start, end, count, (int) type, indices);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawRangeElements: render primitives from array data
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="start">
        /// Specifies the minimum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="end">
        /// Specifies the maximum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in <paramref name="indices" />. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or
        /// Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_range_elements")]
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, object indices)
        {
            GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawRangeElements(mode, start, end, count, type, pin_indices.AddrOfPinnedObject());
            }
            finally
            {
                pin_indices.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glTexImage3D: specify a three-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.LUMINANCE,
        /// Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4,
        /// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16,
        /// Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5,
        /// Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12,
        /// Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8, Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA,
        /// or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture
        /// images
        /// that are at least 16 texels high.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture
        /// images
        /// that are at least 16 texels deep.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture3D")]
        public static void TexImage3D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglTexImage3D != null, "pglTexImage3D not implemented");
            Delegates.pglTexImage3D((int) target, level, (int) internalFormat, width, height, depth, border, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexImage3D: specify a three-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.LUMINANCE,
        /// Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4,
        /// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16,
        /// Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5,
        /// Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12,
        /// Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8, Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA,
        /// or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture
        /// images
        /// that are at least 16 texels high.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture
        /// images
        /// that are at least 16 texels deep.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture3D")]
        public static void TexImage3D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_pixels = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                TexImage3D(target, level, internalFormat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTexSubImage3D: specify a three-dimensional texture subimage
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.TexSubImage3D. Must be Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="zoffset">
        /// Specifies a texel offset in the z direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR,
        /// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="pixels">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture3D")]
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Debug.Assert(Delegates.pglTexSubImage3D != null, "pglTexSubImage3D not implemented");
            Delegates.pglTexSubImage3D((int) target, level, xoffset, yoffset, zoffset, width, height, depth, (int) format, (int) type, pixels);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTexSubImage3D: specify a three-dimensional texture subimage
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.TexSubImage3D. Must be Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="zoffset">
        /// Specifies a texel offset in the z direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR,
        /// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="pixels">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture3D")]
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, object pixels)
        {
            GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glCopyTexSubImage3D: copy a three-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_3D
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="zoffset">
        /// Specifies a texel offset in the z direction within the texture array.
        /// </param>
        /// <param name="x">
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y">
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_copy_texture")]
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            Debug.Assert(Delegates.pglCopyTexSubImage3D != null, "pglCopyTexSubImage3D not implemented");
            Delegates.pglCopyTexSubImage3D((int) target, level, xoffset, yoffset, zoffset, x, y, width, height);
            DebugCheckErrors(null);
        }

        public static partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_EXT_draw_range_elements")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDrawRangeElements(int mode, uint start, uint end, int count, int type, IntPtr indices);

            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_EXT_draw_range_elements", EntryPoint = "glDrawRangeElementsEXT")]
            [ThreadStatic]
            public static glDrawRangeElements pglDrawRangeElements;

            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture3D")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D", EntryPoint = "glTexImage3DEXT")] [ThreadStatic]
            public static glTexImage3D pglTexImage3D;

            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture3D")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture3D", EntryPoint = "glTexSubImage3DEXT")] [ThreadStatic]
            public static glTexSubImage3D pglTexSubImage3D;

            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_copy_texture")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glCopyTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

            [RequiredByFeature("GL_VERSION_1_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_copy_texture", EntryPoint = "glCopyTexSubImage3DEXT")]
            [ThreadStatic]
            public static glCopyTexSubImage3D pglCopyTexSubImage3D;
        }
    }
}