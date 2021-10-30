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

// ReSharper disable StringLiteralTypo
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer
// ReSharper disable InvalidXmlDocComment
// ReSharper disable CommentTypo
namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL] Value of GL_FIXED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
        public const int FIXED = 0x140C;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data type. See
        ///     Gl.ReadPixels.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns a GLenum value indicating the implementation's preferred pixel data
        ///     type
        ///     for the framebuffer object. See Gl.ReadPixels.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the type chosen by the implementation with which pixels may be read from
        ///     the
        ///     color buffer of the currently bound framebuffer in conjunction with Gl.IMPLEMENTATION_COLOR_READ_FORMAT. See
        ///     Gl.ReadPixels.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
        public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data format. See
        ///     Gl.ReadPixels.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns a GLenum value indicating the preferred pixel data format for the
        ///     framebuffer object. See Gl.ReadPixels.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the format chosen by the implementation in which pixels may be read from
        ///     the
        ///     color buffer of the currently bound framebuffer in conjunction with Gl.IMPLEMENTATION_COLOR_READ_TYPE. See
        ///     Gl.ReadPixels.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
        public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

        /// <summary>
        /// [GL] Value of GL_LOW_FLOAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int LOW_FLOAT = 0x8DF0;

        /// <summary>
        /// [GL] Value of GL_MEDIUM_FLOAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int MEDIUM_FLOAT = 0x8DF1;

        /// <summary>
        /// [GL] Value of GL_HIGH_FLOAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int HIGH_FLOAT = 0x8DF2;

        /// <summary>
        /// [GL] Value of GL_LOW_INT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int LOW_INT = 0x8DF3;

        /// <summary>
        /// [GL] Value of GL_MEDIUM_INT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int MEDIUM_INT = 0x8DF4;

        /// <summary>
        /// [GL] Value of GL_HIGH_INT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int HIGH_INT = 0x8DF5;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single boolean value indicating whether an online shader compiler is present in the
        ///     implementation. All desktop OpenGL implementations must support online shader compilations, and therefore the value
        ///     of
        ///     Gl.SHADER_COMPILER will always be Gl.TRUE.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single boolean value indicating whether a shader compiler is supported. This value
        ///     is
        ///     always Gl.TRUE. See Gl.CompileShader.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int SHADER_COMPILER = 0x8DFA;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a list of symbolic constants of length Gl.NUM_SHADER_BINARY_FORMATS indicating which
        /// shader binary formats are available. See Gl.ShaderBinary.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int SHADER_BINARY_FORMATS = 0x8DF8;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of binary shader formats supported by the implementation. If this
        ///     value
        ///     is greater than zero, then the implementation supports loading binary shaders. If it is zero, then the loading of
        ///     binary
        ///     shaders by the implementation is not supported.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single integer value indicating the number of available shader binary formats. The
        ///     minimum value is 0. See Gl.ShaderBinary.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int NUM_SHADER_BINARY_FORMATS = 0x8DF9;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum number of 4-vectors that may be held in uniform variable storage
        ///     for
        ///     the vertex shader. The value of Gl.MAX_VERTEX_UNIFORM_VECTORS is equal to the value of
        ///     Gl.MAX_VERTEX_UNIFORM_COMPONENTS
        ///     and must be at least 256.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values
        ///     that
        ///     can be held in uniform variable storage for a vertex shader. The value must be at least 256. See Gl.Uniform.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number 4-vectors for varying variables, which is equal to the value of
        ///     Gl.MAX_VARYING_COMPONENTS and must be at least 15.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of interpolators available for processing varying
        ///     variables
        ///     used by vertex and fragment shaders. This value represents the number of vector values that can be interpolated;
        ///     varying
        ///     variables declared as matrices and arrays will consume multiple interpolators. The value must be at least 15.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int MAX_VARYING_VECTORS = 0x8DFC;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum number of individual 4-vectors of floating-point, integer, or
        ///     boolean
        ///     values that can be held in uniform variable storage for a fragment shader. The value is equal to the value of
        ///     Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS divided by 4 and must be at least 256. See Gl.Uniform.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values
        ///     that
        ///     can be held in uniform variable storage for a fragment shader. The value must be at least 224. See Gl.Uniform.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

        /// <summary>
        /// [GL] Value of GL_RGB565 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        [RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
        public const int RGB565 = 0x8D62;

        /// <summary>
        /// [GLES3.2] Gl.GetProgram: params returns the current value of whether the binary retrieval hint is enabled for program.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

        /// <summary>
        /// [GL4] Gl.GetProgram: params returns the length of the program binary, in bytes that will be returned by a call to
        /// Gl.GetProgramBinary. When a progam's Gl.LINK_STATUS is Gl.FALSE, its program binary length is zero.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public const int PROGRAM_BINARY_LENGTH = 0x8741;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of program binary formats supported by the implementation.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single integer value indicating the number of available program binary formats.
        ///     The
        ///     minimum value is 0. See Gl.ProgramBinary.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public const int NUM_PROGRAM_BINARY_FORMATS = 0x87FE;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data an array of Gl.NUM_PROGRAM_BINARY_FORMATS values, indicating the proram binary formats supported
        ///     by
        ///     the implementation.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a list of symbolic constants of length Gl.NUM_PROGRAM_BINARY_FORMATS indicating
        ///     which
        ///     program binary formats are available. See Gl.ProgramBinary.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public const int PROGRAM_BINARY_FORMATS = 0x87FF;

        /// <summary>
        /// [GL] Value of GL_VERTEX_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const uint VERTEX_SHADER_BIT = 0x00000001;

        /// <summary>
        /// [GL] Value of GL_FRAGMENT_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const uint FRAGMENT_SHADER_BIT = 0x00000002;

        /// <summary>
        /// [GL] Value of GL_GEOMETRY_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const uint GEOMETRY_SHADER_BIT = 0x00000004;

        /// <summary>
        /// [GL] Value of GL_TESS_CONTROL_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;

        /// <summary>
        /// [GL] Value of GL_TESS_EVALUATION_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;

        /// <summary>
        /// [GL] Value of GL_ALL_SHADER_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const uint ALL_SHADER_BITS = 0xFFFFFFFF;

        /// <summary>
        /// [GLES3.2] Gl.GetProgram: params returns Gl.TRUE if the program has been flagged for use as a separable program object
        /// that can be found to individual shader stages with Gl.UseProgramStages.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const int PROGRAM_SEPARABLE = 0x8258;

        /// <summary>
        /// [GL] Value of GL_ACTIVE_PROGRAM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const int ACTIVE_PROGRAM = 0x8259;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data a single value, the name of the currently bound program pipeline object, or zero if no
        /// program pipeline object is bound. See Gl.BindProgramPipeline.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
        public const int PROGRAM_PIPELINE_BINDING = 0x825A;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the maximum number of simultaneous viewports that are supported. The value must
        /// be
        /// at least 16. See Gl.ViewportIndexed.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int MAX_VIEWPORTS = 0x825B;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single value, the number of bits of sub-pixel precision which the GL uses to interpret the
        /// floating point viewport bounds. The minimum value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int VIEWPORT_SUBPIXEL_BITS = 0x825C;

        /// <summary>
        /// [GL4] Gl.Get: data returns two values, the minimum and maximum viewport bounds range. The minimum range should be at
        /// least [-32768, 32767].
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int VIEWPORT_BOUNDS_RANGE = 0x825D;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to
        ///     select
        ///     the rendering layer. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows
        ///     the
        ///     convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then
        ///     the
        ///     selection is always taken from the first vertex in the primitive. If the value returned is equivalent to
        ///     Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value
        ///     returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific
        ///     vertex
        ///     in the primitive.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used
        ///     to
        ///     select the rendering layer. If the value returned is Gl.FIRST_VERTEX_CONVENTION, then the selection is always taken
        ///     from
        ///     the first vertex in the primitive. If the value returned is Gl.LAST_VERTEX_CONVENTION, then the selection is always
        ///     taken from the last vertex in the primitive. If the value returned is Gl.UNDEFINED_VERTEX, then the selection is
        ///     not
        ///     guaranteed to be taken from any specific vertex in the primitive. Portable applications will therefore assign the
        ///     same
        ///     layer for all vertices in a primitive.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int LAYER_PROVOKING_VERTEX = 0x825E;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to select
        /// the viewport index. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows the
        /// convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then the
        /// selection is always taken from the first vertex in the primitive. If the value returned is equivalent to
        /// Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value
        /// returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific
        /// vertex
        /// in the primitive.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

        /// <summary>
        /// [GL] Value of GL_UNDEFINED_VERTEX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int UNDEFINED_VERTEX = 0x8260;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glReleaseShaderCompiler: release resources consumed by the implementation's shader compiler
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public static void ReleaseShaderCompiler()
        {
            Debug.Assert(Delegates.pglReleaseShaderCompiler != null, "pglReleaseShaderCompiler not implemented");
            Delegates.pglReleaseShaderCompiler();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glShaderBinary: load pre-compiled shader binaries
        ///     </para>
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in <paramref name="shaders" />.
        /// </param>
        /// <param name="shaders">
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="binary">
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in <paramref name="binary" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public static void ShaderBinary(int count, uint[] shaders, int binaryformat, object binary, int length)
        {
            GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
            try
            {
                ShaderBinary(count, shaders, binaryformat, pin_binary.AddrOfPinnedObject(), length);
            }
            finally
            {
                pin_binary.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glShaderBinary: load pre-compiled shader binaries
        ///     </para>
        /// </summary>
        /// <param name="shaders">
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="binary">
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in <paramref name="binary" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public static void ShaderBinary(uint[] shaders, int binaryformat, IntPtr binary, int length)
        {
            unsafe
            {
                fixed (uint* p_shaders = shaders)
                {
                    Debug.Assert(Delegates.pglShaderBinary != null, "pglShaderBinary not implemented");
                    Delegates.pglShaderBinary(shaders.Length, p_shaders, binaryformat, binary, length);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetShaderPrecisionFormat: retrieve the range and precision for numeric formats supported by the
        ///     shader
        ///     compiler
        ///     </para>
        /// </summary>
        /// <param name="shadertype">
        /// A <see cref="T:ShaderType" />.
        /// </param>
        /// <param name="precisiontype">
        /// A <see cref="T:PrecisionType" />.
        /// </param>
        /// <param name="range">
        /// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
        /// </param>
        /// <param name="precision">
        /// Specifies the address of an integer into which the numeric precision of the implementation is written.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, [Out] int[] range, out int precision)
        {
            Debug.Assert(range.Length >= 2);
            unsafe
            {
                fixed (int* p_range = range)
                fixed (int* p_precision = &precision)
                {
                    Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
                    Delegates.pglGetShaderPrecisionFormat((int) shadertype, (int) precisiontype, p_range, p_precision);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetShaderPrecisionFormat: retrieve the range and precision for numeric formats supported by the
        ///     shader
        ///     compiler
        ///     </para>
        /// </summary>
        /// <param name="shadertype">
        /// A <see cref="T:ShaderType" />.
        /// </param>
        /// <param name="precisiontype">
        /// A <see cref="T:PrecisionType" />.
        /// </param>
        /// <param name="range">
        /// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
        /// </param>
        /// <param name="precision">
        /// Specifies the address of an integer into which the numeric precision of the implementation is written.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, out int range, out int precision)
        {
            unsafe
            {
                fixed (int* p_range = &range)
                fixed (int* p_precision = &precision)
                {
                    Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
                    Delegates.pglGetShaderPrecisionFormat((int) shadertype, (int) precisiontype, p_range, p_precision);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDepthRangef: specify mapping of depth values from normalized device coordinates to window
        ///     coordinates
        ///     </para>
        /// </summary>
        /// <param name="n">
        /// A <see cref="T:float" />.
        /// </param>
        /// <param name="f">
        /// A <see cref="T:float" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
        public static void DepthRange(float n, float f)
        {
            Debug.Assert(Delegates.pglDepthRangef != null, "pglDepthRangef not implemented");
            Delegates.pglDepthRangef(n, f);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glClearDepthf: specify the clear value for the depth buffer
        ///     </para>
        /// </summary>
        /// <param name="d">
        /// A <see cref="T:float" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
        public static void ClearDepth(float d)
        {
            Debug.Assert(Delegates.pglClearDepthf != null, "pglClearDepthf not implemented");
            Delegates.pglClearDepthf(d);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramBinary: return a binary representation of a program object's compiled and linked
        ///     executable
        ///     source
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by <paramref name="binary" />.
        /// </param>
        /// <param name="length">
        /// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary" />.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// Specifies the address an array into which the GL will return <paramref name="program" />'s binary representation.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public static void GetProgramBinary(uint program, int bufSize, out int length, out int binaryFormat, IntPtr binary)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                fixed (int* p_binaryFormat = &binaryFormat)
                {
                    Debug.Assert(Delegates.pglGetProgramBinary != null, "pglGetProgramBinary not implemented");
                    Delegates.pglGetProgramBinary(program, bufSize, p_length, p_binaryFormat, binary);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramBinary: return a binary representation of a program object's compiled and linked
        ///     executable
        ///     source
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by <paramref name="binary" />.
        /// </param>
        /// <param name="length">
        /// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary" />.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// Specifies the address an array into which the GL will return <paramref name="program" />'s binary representation.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public static void GetProgramBinary(uint program, int bufSize, out int length, out int binaryFormat, object binary)
        {
            GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
            try
            {
                GetProgramBinary(program, bufSize, out length, out binaryFormat, pin_binary.AddrOfPinnedObject());
            }
            finally
            {
                pin_binary.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramBinary: load a program object with a program binary
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// Specifies the address an array containing the binary to be loaded into <paramref name="program" />.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in <paramref name="binary" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public static void ProgramBinary(uint program, int binaryFormat, IntPtr binary, int length)
        {
            Debug.Assert(Delegates.pglProgramBinary != null, "pglProgramBinary not implemented");
            Delegates.pglProgramBinary(program, binaryFormat, binary, length);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramBinary: load a program object with a program binary
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// Specifies the address an array containing the binary to be loaded into <paramref name="program" />.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in <paramref name="binary" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
        public static void ProgramBinary(uint program, int binaryFormat, object binary, int length)
        {
            GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
            try
            {
                ProgramBinary(program, binaryFormat, pin_binary.AddrOfPinnedObject(), length);
            }
            finally
            {
                pin_binary.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramParameteri: specify a parameter for a program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose parameter to modify.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to modify.
        /// </param>
        /// <param name="value">
        /// Specifies the new value of the parameter specified by <paramref name="pname" /> for <paramref name="program" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramParameter(uint program, ProgramParameterPName pname, int value)
        {
            Debug.Assert(Delegates.pglProgramParameteri != null, "pglProgramParameteri not implemented");
            Delegates.pglProgramParameteri(program, (int) pname, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUseProgramStages: bind stages of a program object to a program pipeline
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the program pipeline object to which to bind stages from <paramref name="program" />.
        /// </param>
        /// <param name="stages">
        /// Specifies a set of program stages to bind to the program pipeline object.
        /// </param>
        /// <param name="program">
        /// Specifies the program object containing the shader executables to use in <paramref name="pipeline" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void UseProgramStage(uint pipeline, UseProgramStageMask stages, uint program)
        {
            Debug.Assert(Delegates.pglUseProgramStages != null, "pglUseProgramStages not implemented");
            Delegates.pglUseProgramStages(pipeline, (uint) stages, program);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glActiveShaderProgram: set the active program object for a program pipeline object
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the program pipeline object to set the active program object for.
        /// </param>
        /// <param name="program">
        /// Specifies the program object to set as the active program pipeline object <paramref name="pipeline" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ActiveShaderProgram(uint pipeline, uint program)
        {
            Debug.Assert(Delegates.pglActiveShaderProgram != null, "pglActiveShaderProgram not implemented");
            Delegates.pglActiveShaderProgram(pipeline, program);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCreateShaderProgramv: create a stand-alone program from an array of null-terminated source code
        ///     strings
        ///     </para>
        /// </summary>
        /// <param name="type">
        /// Specifies the type of shader to create.
        /// </param>
        /// <param name="count">
        /// Specifies the number of source code strings in the array <paramref name="strings" />.
        /// </param>
        /// <param name="strings">
        /// Specifies the address of an array of pointers to source code strings from which to create the program object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static uint CreateShaderProgram(ShaderType type, int count, params string[] strings)
        {
            uint retValue;

            Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
            retValue = Delegates.pglCreateShaderProgramv((int) type, count, strings);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCreateShaderProgramv: create a stand-alone program from an array of null-terminated source code
        ///     strings
        ///     </para>
        /// </summary>
        /// <param name="type">
        /// Specifies the type of shader to create.
        /// </param>
        /// <param name="strings">
        /// Specifies the address of an array of pointers to source code strings from which to create the program object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static uint CreateShaderProgram(ShaderType type, params string[] strings)
        {
            uint retValue;

            Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
            retValue = Delegates.pglCreateShaderProgramv((int) type, strings.Length, strings);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindProgramPipeline: bind a program pipeline to the current context
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the name of the pipeline object to bind to the context.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void BindProgramPipeline(uint pipeline)
        {
            Debug.Assert(Delegates.pglBindProgramPipeline != null, "pglBindProgramPipeline not implemented");
            Delegates.pglBindProgramPipeline(pipeline);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteProgramPipelines: delete program pipeline objects
        ///     </para>
        /// </summary>
        /// <param name="pipelines">
        /// Specifies an array of names of program pipeline objects to delete.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void DeleteProgramPipelines(params uint[] pipelines)
        {
            unsafe
            {
                fixed (uint* p_pipelines = pipelines)
                {
                    Debug.Assert(Delegates.pglDeleteProgramPipelines != null, "pglDeleteProgramPipelines not implemented");
                    Delegates.pglDeleteProgramPipelines(pipelines.Length, p_pipelines);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenProgramPipelines: reserve program pipeline object names
        ///     </para>
        /// </summary>
        /// <param name="pipelines">
        /// Specifies an array of into which the reserved names will be written.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void GenProgramPipelines(uint[] pipelines)
        {
            unsafe
            {
                fixed (uint* p_pipelines = pipelines)
                {
                    Debug.Assert(Delegates.pglGenProgramPipelines != null, "pglGenProgramPipelines not implemented");
                    Delegates.pglGenProgramPipelines(pipelines.Length, p_pipelines);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenProgramPipelines: reserve program pipeline object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static uint GenProgramPipeline()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenProgramPipelines(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsProgramPipeline: determine if a name corresponds to a program pipeline object
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies a value that may be the name of a program pipeline object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static bool IsProgramPipeline(uint pipeline)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsProgramPipeline != null, "pglIsProgramPipeline not implemented");
            retValue = Delegates.pglIsProgramPipeline(pipeline);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramPipelineiv: retrieve properties of a program pipeline object
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the name of a program pipeline object whose parameter retrieve.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to retrieve.
        /// </param>
        /// <param name="params">
        /// Specifies the address of a variable into which will be written the value or values of <paramref name="pname" /> for
        /// <paramref name="pipeline" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void GetProgramPipeline(uint pipeline, PipelineParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetProgramPipelineiv != null, "pglGetProgramPipelineiv not implemented");
                    Delegates.pglGetProgramPipelineiv(pipeline, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramPipelineiv: retrieve properties of a program pipeline object
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the name of a program pipeline object whose parameter retrieve.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to retrieve.
        /// </param>
        /// <param name="params">
        /// Specifies the address of a variable into which will be written the value or values of <paramref name="pname" /> for
        /// <paramref name="pipeline" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void GetProgramPipeline(uint pipeline, PipelineParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetProgramPipelineiv != null, "pglGetProgramPipelineiv not implemented");
                    Delegates.pglGetProgramPipelineiv(pipeline, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1i: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, int v0)
        {
            Debug.Assert(Delegates.pglProgramUniform1i != null, "pglProgramUniform1i not implemented");
            Delegates.pglProgramUniform1i(program, location, v0);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, int[] value)
        {
            unsafe
            {
                fixed (int* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
                    Delegates.pglProgramUniform1iv(program, location, value.Length, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform1(uint program, int location, int count, int* value)
        {
            Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
            Delegates.pglProgramUniform1iv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1i<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform1iv(program, location, count, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform1iv(program, location, count, (int*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1f: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, float v0)
        {
            Debug.Assert(Delegates.pglProgramUniform1f != null, "pglProgramUniform1f not implemented");
            Delegates.pglProgramUniform1f(program, location, v0);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, float[] value)
        {
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
                    Delegates.pglProgramUniform1fv(program, location, value.Length, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform1(uint program, int location, int count, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
            Delegates.pglProgramUniform1fv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1f<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform1fv(program, location, count, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform1fv(program, location, count, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform1d: Binding for glProgramUniform1d.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="v0">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform1(uint program, int location, double v0)
        {
            Debug.Assert(Delegates.pglProgramUniform1d != null, "pglProgramUniform1d not implemented");
            Delegates.pglProgramUniform1d(program, location, v0);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform1dv: Binding for glProgramUniform1dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform1(uint program, int location, double[] value)
        {
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
                    Delegates.pglProgramUniform1dv(program, location, value.Length, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform1dv: Binding for glProgramUniform1dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniform1(uint program, int location, int count, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
            Delegates.pglProgramUniform1dv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform1dv: Binding for glProgramUniform1dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform1d<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform1dv(program, location, count, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform1dv(program, location, count, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1ui: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, uint v0)
        {
            Debug.Assert(Delegates.pglProgramUniform1ui != null, "pglProgramUniform1ui not implemented");
            Delegates.pglProgramUniform1ui(program, location, v0);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1(uint program, int location, uint[] value)
        {
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
                    Delegates.pglProgramUniform1uiv(program, location, value.Length, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform1(uint program, int location, int count, uint* value)
        {
            Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
            Delegates.pglProgramUniform1uiv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform1uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform1ui<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform1uiv(program, location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform1uiv(program, location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2i: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, int v0, int v1)
        {
            Debug.Assert(Delegates.pglProgramUniform2i != null, "pglProgramUniform2i not implemented");
            Delegates.pglProgramUniform2i(program, location, v0, v1);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, int[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 2 == 0, "empty or not multiple of 2");
            unsafe
            {
                fixed (int* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
                    Delegates.pglProgramUniform2iv(program, location, value.Length / 2, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform2(uint program, int location, int count, int* value)
        {
            Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
            Delegates.pglProgramUniform2iv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2i<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform2iv(program, location, count, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform2iv(program, location, count, (int*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2f: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, float v0, float v1)
        {
            Debug.Assert(Delegates.pglProgramUniform2f != null, "pglProgramUniform2f not implemented");
            Delegates.pglProgramUniform2f(program, location, v0, v1);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 2 == 0, "empty or not multiple of 2");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
                    Delegates.pglProgramUniform2fv(program, location, value.Length / 2, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform2(uint program, int location, int count, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
            Delegates.pglProgramUniform2fv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2f<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform2fv(program, location, count, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform2fv(program, location, count, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform2d: Binding for glProgramUniform2d.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="v0">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v1">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform2(uint program, int location, double v0, double v1)
        {
            Debug.Assert(Delegates.pglProgramUniform2d != null, "pglProgramUniform2d not implemented");
            Delegates.pglProgramUniform2d(program, location, v0, v1);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform2dv: Binding for glProgramUniform2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform2(uint program, int location, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 2 == 0, "empty or not multiple of 2");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
                    Delegates.pglProgramUniform2dv(program, location, value.Length / 2, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform2dv: Binding for glProgramUniform2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniform2(uint program, int location, int count, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
            Delegates.pglProgramUniform2dv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform2dv: Binding for glProgramUniform2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform2d<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform2dv(program, location, count, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform2dv(program, location, count, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2ui: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, uint v0, uint v1)
        {
            Debug.Assert(Delegates.pglProgramUniform2ui != null, "pglProgramUniform2ui not implemented");
            Delegates.pglProgramUniform2ui(program, location, v0, v1);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2(uint program, int location, uint[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 2 == 0, "empty or not multiple of 2");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
                    Delegates.pglProgramUniform2uiv(program, location, value.Length / 2, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform2(uint program, int location, int count, uint* value)
        {
            Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
            Delegates.pglProgramUniform2uiv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform2uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform2ui<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform2uiv(program, location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform2uiv(program, location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3i: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, int v0, int v1, int v2)
        {
            Debug.Assert(Delegates.pglProgramUniform3i != null, "pglProgramUniform3i not implemented");
            Delegates.pglProgramUniform3i(program, location, v0, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, int[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 3 == 0, "empty or not multiple of 3");
            unsafe
            {
                fixed (int* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
                    Delegates.pglProgramUniform3iv(program, location, value.Length / 3, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform3(uint program, int location, int count, int* value)
        {
            Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
            Delegates.pglProgramUniform3iv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3i<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform3iv(program, location, count, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform3iv(program, location, count, (int*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3f: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, float v0, float v1, float v2)
        {
            Debug.Assert(Delegates.pglProgramUniform3f != null, "pglProgramUniform3f not implemented");
            Delegates.pglProgramUniform3f(program, location, v0, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 3 == 0, "empty or not multiple of 3");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
                    Delegates.pglProgramUniform3fv(program, location, value.Length / 3, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform3(uint program, int location, int count, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
            Delegates.pglProgramUniform3fv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3f<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform3fv(program, location, count, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform3fv(program, location, count, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform3d: Binding for glProgramUniform3d.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="v0">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v1">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform3(uint program, int location, double v0, double v1, double v2)
        {
            Debug.Assert(Delegates.pglProgramUniform3d != null, "pglProgramUniform3d not implemented");
            Delegates.pglProgramUniform3d(program, location, v0, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform3dv: Binding for glProgramUniform3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform3(uint program, int location, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 3 == 0, "empty or not multiple of 3");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
                    Delegates.pglProgramUniform3dv(program, location, value.Length / 3, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform3dv: Binding for glProgramUniform3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniform3(uint program, int location, int count, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
            Delegates.pglProgramUniform3dv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform3dv: Binding for glProgramUniform3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform3d<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform3dv(program, location, count, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform3dv(program, location, count, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3ui: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, uint v0, uint v1, uint v2)
        {
            Debug.Assert(Delegates.pglProgramUniform3ui != null, "pglProgramUniform3ui not implemented");
            Delegates.pglProgramUniform3ui(program, location, v0, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3(uint program, int location, uint[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 3 == 0, "empty or not multiple of 3");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
                    Delegates.pglProgramUniform3uiv(program, location, value.Length / 3, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform3(uint program, int location, int count, uint* value)
        {
            Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
            Delegates.pglProgramUniform3uiv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform3uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform3ui<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform3uiv(program, location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform3uiv(program, location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4i: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, int v0, int v1, int v2, int v3)
        {
            Debug.Assert(Delegates.pglProgramUniform4i != null, "pglProgramUniform4i not implemented");
            Delegates.pglProgramUniform4i(program, location, v0, v1, v2, v3);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, int[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (int* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
                    Delegates.pglProgramUniform4iv(program, location, value.Length / 4, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform4(uint program, int location, int count, int* value)
        {
            Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
            Delegates.pglProgramUniform4iv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4iv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4i<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform4iv(program, location, count, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform4iv(program, location, count, (int*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4f: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, float v0, float v1, float v2, float v3)
        {
            Debug.Assert(Delegates.pglProgramUniform4f != null, "pglProgramUniform4f not implemented");
            Delegates.pglProgramUniform4f(program, location, v0, v1, v2, v3);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
                    Delegates.pglProgramUniform4fv(program, location, value.Length / 4, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform4(uint program, int location, int count, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
            Delegates.pglProgramUniform4fv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4f<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform4fv(program, location, count, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform4fv(program, location, count, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform4d: Binding for glProgramUniform4d.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="v0">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v1">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="v3">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform4(uint program, int location, double v0, double v1, double v2, double v3)
        {
            Debug.Assert(Delegates.pglProgramUniform4d != null, "pglProgramUniform4d not implemented");
            Delegates.pglProgramUniform4d(program, location, v0, v1, v2, v3);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform4dv: Binding for glProgramUniform4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform4(uint program, int location, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
                    Delegates.pglProgramUniform4dv(program, location, value.Length / 4, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform4dv: Binding for glProgramUniform4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniform4(uint program, int location, int count, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
            Delegates.pglProgramUniform4dv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniform4dv: Binding for glProgramUniform4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniform4d<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform4dv(program, location, count, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform4dv(program, location, count, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4ui: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, uint v0, uint v1, uint v2, uint v3)
        {
            Debug.Assert(Delegates.pglProgramUniform4ui != null, "pglProgramUniform4ui not implemented");
            Delegates.pglProgramUniform4ui(program, location, v0, v1, v2, v3);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4(uint program, int location, uint[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
                    Delegates.pglProgramUniform4uiv(program, location, value.Length / 4, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniform4(uint program, int location, int count, uint* value)
        {
            Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
            Delegates.pglProgramUniform4uiv(program, location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniform4uiv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniform4ui<T>(uint program, int location, int count, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniform4uiv(program, location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniform4uiv(program, location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
                    Delegates.pglProgramUniformMatrix2fv(program, location, value.Length / 4, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix2(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
            Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 9 == 0, "empty or not multiple of 9");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
                    Delegates.pglProgramUniformMatrix3fv(program, location, value.Length / 9, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix3(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
            Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 16 == 0, "empty or not multiple of 16");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
                    Delegates.pglProgramUniformMatrix4fv(program, location, value.Length / 16, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix4(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
            Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2dv: Binding for glProgramUniformMatrix2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
                    Delegates.pglProgramUniformMatrix2dv(program, location, value.Length / 4, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2dv: Binding for glProgramUniformMatrix2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix2(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
            Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2dv: Binding for glProgramUniformMatrix2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3dv: Binding for glProgramUniformMatrix3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 9 == 0, "empty or not multiple of 9");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
                    Delegates.pglProgramUniformMatrix3dv(program, location, value.Length / 9, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3dv: Binding for glProgramUniformMatrix3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix3(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
            Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3dv: Binding for glProgramUniformMatrix3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4dv: Binding for glProgramUniformMatrix4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 16 == 0, "empty or not multiple of 16");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
                    Delegates.pglProgramUniformMatrix4dv(program, location, value.Length / 16, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4dv: Binding for glProgramUniformMatrix4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix4(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
            Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4dv: Binding for glProgramUniformMatrix4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2x3(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 6 == 0, "empty or not multiple of 6");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
                    Delegates.pglProgramUniformMatrix2x3fv(program, location, value.Length / 6, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
            Delegates.pglProgramUniformMatrix2x3fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2x3f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3x2(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 6 == 0, "empty or not multiple of 6");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
                    Delegates.pglProgramUniformMatrix3x2fv(program, location, value.Length / 6, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix3x2(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
            Delegates.pglProgramUniformMatrix3x2fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3x2f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2x4(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 8 == 0, "empty or not multiple of 8");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
                    Delegates.pglProgramUniformMatrix2x4fv(program, location, value.Length / 8, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix2x4(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
            Delegates.pglProgramUniformMatrix2x4fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix2x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix2x4f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4x2(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 8 == 0, "empty or not multiple of 8");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
                    Delegates.pglProgramUniformMatrix4x2fv(program, location, value.Length / 8, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix4x2(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
            Delegates.pglProgramUniformMatrix4x2fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x2fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4x2f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3x4(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 12 == 0, "empty or not multiple of 12");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
                    Delegates.pglProgramUniformMatrix3x4fv(program, location, value.Length / 12, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix3x4(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
            Delegates.pglProgramUniformMatrix3x4fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix3x4fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix3x4f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4x3(uint program, int location, bool transpose, float[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 12 == 0, "empty or not multiple of 12");
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
                    Delegates.pglProgramUniformMatrix4x3fv(program, location, value.Length / 12, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static unsafe void ProgramUniformMatrix4x3(uint program, int location, int count, bool transpose, float* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
            Delegates.pglProgramUniformMatrix4x3fv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glProgramUniformMatrix4x3fv: Specify the value of a uniform variable for a specified program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be
        /// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="transpose">
        /// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
        public static void ProgramUniformMatrix4x3f<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x3dv: Binding for glProgramUniformMatrix2x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2x3(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 6 == 0, "empty or not multiple of 6");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
                    Delegates.pglProgramUniformMatrix2x3dv(program, location, value.Length / 6, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x3dv: Binding for glProgramUniformMatrix2x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
            Delegates.pglProgramUniformMatrix2x3dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x3dv: Binding for glProgramUniformMatrix2x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2x3d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x2dv: Binding for glProgramUniformMatrix3x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3x2(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 6 == 0, "empty or not multiple of 6");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
                    Delegates.pglProgramUniformMatrix3x2dv(program, location, value.Length / 6, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x2dv: Binding for glProgramUniformMatrix3x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix3x2(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
            Delegates.pglProgramUniformMatrix3x2dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x2dv: Binding for glProgramUniformMatrix3x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3x2d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x4dv: Binding for glProgramUniformMatrix2x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2x4(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 8 == 0, "empty or not multiple of 8");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
                    Delegates.pglProgramUniformMatrix2x4dv(program, location, value.Length / 8, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x4dv: Binding for glProgramUniformMatrix2x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix2x4(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
            Delegates.pglProgramUniformMatrix2x4dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix2x4dv: Binding for glProgramUniformMatrix2x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix2x4d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x2dv: Binding for glProgramUniformMatrix4x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4x2(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 8 == 0, "empty or not multiple of 8");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
                    Delegates.pglProgramUniformMatrix4x2dv(program, location, value.Length / 8, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x2dv: Binding for glProgramUniformMatrix4x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix4x2(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
            Delegates.pglProgramUniformMatrix4x2dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x2dv: Binding for glProgramUniformMatrix4x2dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4x2d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x4dv: Binding for glProgramUniformMatrix3x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3x4(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 12 == 0, "empty or not multiple of 12");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
                    Delegates.pglProgramUniformMatrix3x4dv(program, location, value.Length / 12, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x4dv: Binding for glProgramUniformMatrix3x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix3x4(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
            Delegates.pglProgramUniformMatrix3x4dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix3x4dv: Binding for glProgramUniformMatrix3x4dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix3x4d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x3dv: Binding for glProgramUniformMatrix4x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4x3(uint program, int location, bool transpose, double[] value)
        {
            Debug.Assert(value.Length > 0 && value.Length % 12 == 0, "empty or not multiple of 12");
            unsafe
            {
                fixed (double* p_value = value)
                {
                    Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
                    Delegates.pglProgramUniformMatrix4x3dv(program, location, value.Length / 12, transpose, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x3dv: Binding for glProgramUniformMatrix4x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:double*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static unsafe void ProgramUniformMatrix4x3(uint program, int location, int count, bool transpose, double* value)
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
            Delegates.pglProgramUniformMatrix4x3dv(program, location, count, transpose, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glProgramUniformMatrix4x3dv: Binding for glProgramUniformMatrix4x3dv.
        /// </summary>
        /// <param name="program">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="location">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="transpose">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ProgramUniformMatrix4x3d<T>(uint program, int location, int count, bool transpose, T value) where T : struct
        {
            Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glValidateProgramPipeline: validate a program pipeline object against current GL state
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the name of a program pipeline object to validate.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void ValidateProgramPipeline(uint pipeline)
        {
            Debug.Assert(Delegates.pglValidateProgramPipeline != null, "pglValidateProgramPipeline not implemented");
            Delegates.pglValidateProgramPipeline(pipeline);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramPipelineInfoLog: retrieve the info log string from a program pipeline object
        ///     </para>
        /// </summary>
        /// <param name="pipeline">
        /// Specifies the name of a program pipeline object from which to retrieve the info log.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the maximum number of characters, including the null terminator, that may be written into
        /// <paramref
        ///     name="infoLog" />
        /// .
        /// </param>
        /// <param name="length">
        /// Specifies the address of a variable into which will be written the number of characters written into
        /// <paramref
        ///     name="infoLog" />
        /// .
        /// </param>
        /// <param name="infoLog">
        /// Specifies the address of an array of characters into which will be written the info log for
        /// <paramref name="pipeline" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
        public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, StringBuilder infoLog)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                {
                    Debug.Assert(Delegates.pglGetProgramPipelineInfoLog != null, "pglGetProgramPipelineInfoLog not implemented");
                    Delegates.pglGetProgramPipelineInfoLog(pipeline, bufSize, p_length, infoLog);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL1d: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL1(uint index, double x)
        {
            Debug.Assert(Delegates.pglVertexAttribL1d != null, "pglVertexAttribL1d not implemented");
            Delegates.pglVertexAttribL1d(index, x);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL2d: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL2(uint index, double x, double y)
        {
            Debug.Assert(Delegates.pglVertexAttribL2d != null, "pglVertexAttribL2d not implemented");
            Delegates.pglVertexAttribL2d(index, x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL3d: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL3(uint index, double x, double y, double z)
        {
            Debug.Assert(Delegates.pglVertexAttribL3d != null, "pglVertexAttribL3d not implemented");
            Delegates.pglVertexAttribL3d(index, x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL4d: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="w">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL4(uint index, double x, double y, double z, double w)
        {
            Debug.Assert(Delegates.pglVertexAttribL4d != null, "pglVertexAttribL4d not implemented");
            Delegates.pglVertexAttribL4d(index, x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL1dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL1(uint index, double[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertexAttribL1dv != null, "pglVertexAttribL1dv not implemented");
                    Delegates.pglVertexAttribL1dv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL1dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static unsafe void VertexAttribL1(uint index, double* v)
        {
            Debug.Assert(Delegates.pglVertexAttribL1dv != null, "pglVertexAttribL1dv not implemented");
            Delegates.pglVertexAttribL1dv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL1dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL1d<T>(uint index, T v) where T : struct
        {
            Debug.Assert(Delegates.pglVertexAttribL1dv != null, "pglVertexAttribL1dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribL1dv(index, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribL1dv(index, (double*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL2dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL2(uint index, double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertexAttribL2dv != null, "pglVertexAttribL2dv not implemented");
                    Delegates.pglVertexAttribL2dv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL2dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static unsafe void VertexAttribL2(uint index, double* v)
        {
            Debug.Assert(Delegates.pglVertexAttribL2dv != null, "pglVertexAttribL2dv not implemented");
            Delegates.pglVertexAttribL2dv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL2dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL2d<T>(uint index, T v) where T : struct
        {
            Debug.Assert(Delegates.pglVertexAttribL2dv != null, "pglVertexAttribL2dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribL2dv(index, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribL2dv(index, (double*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL3dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL3(uint index, double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertexAttribL3dv != null, "pglVertexAttribL3dv not implemented");
                    Delegates.pglVertexAttribL3dv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL3dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static unsafe void VertexAttribL3(uint index, double* v)
        {
            Debug.Assert(Delegates.pglVertexAttribL3dv != null, "pglVertexAttribL3dv not implemented");
            Delegates.pglVertexAttribL3dv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL3dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL3d<T>(uint index, T v) where T : struct
        {
            Debug.Assert(Delegates.pglVertexAttribL3dv != null, "pglVertexAttribL3dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribL3dv(index, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribL3dv(index, (double*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL4dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL4(uint index, double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertexAttribL4dv != null, "pglVertexAttribL4dv not implemented");
                    Delegates.pglVertexAttribL4dv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL4dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static unsafe void VertexAttribL4(uint index, double* v)
        {
            Debug.Assert(Delegates.pglVertexAttribL4dv != null, "pglVertexAttribL4dv not implemented");
            Delegates.pglVertexAttribL4dv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribL4dv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribL4d<T>(uint index, T v) where T : struct
        {
            Debug.Assert(Delegates.pglVertexAttribL4dv != null, "pglVertexAttribL4dv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribL4dv(index, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribL4dv(index, (double*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribLPointer: define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size">
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic
        /// constant
        /// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer.
        /// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by
        /// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type" /> parameter for that function. The
        /// initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride" /> is 0, the
        /// generic
        /// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the
        /// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribLPointer(uint index, int size, VertexAttribType type, int stride, IntPtr pointer)
        {
            Debug.Assert(Delegates.pglVertexAttribLPointer != null, "pglVertexAttribLPointer not implemented");
            Delegates.pglVertexAttribLPointer(index, size, (int) type, stride, pointer);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribLPointer: define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size">
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic
        /// constant
        /// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer.
        /// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by
        /// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type" /> parameter for that function. The
        /// initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride" /> is 0, the
        /// generic
        /// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the
        /// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void VertexAttribLPointer(uint index, int size, VertexAttribType type, int stride, object pointer)
        {
            GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                VertexAttribLPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
            }
            finally
            {
                pin_pointer.Free();
            }
        }

        /// <summary>
        /// [GL4] glGetVertexAttribLdv: Return a generic vertex attribute parameter
        /// </summary>
        /// <param name="index">
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are
        /// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE,
        /// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED,
        /// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
        public static void GetVertexAttribL(uint index, VertexAttribEnum pname, [Out] double[] @params)
        {
            unsafe
            {
                fixed (double* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetVertexAttribLdv != null, "pglGetVertexAttribLdv not implemented");
                    Delegates.pglGetVertexAttribLdv(index, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glViewportArrayv: Binding for glViewportArrayv.
        /// </summary>
        /// <param name="first">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="count">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ViewportArray(uint first, int count, float[] v)
        {
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglViewportArrayv != null, "pglViewportArrayv not implemented");
                    Delegates.pglViewportArrayv(first, count, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glViewportIndexedf: Binding for glViewportIndexedf.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:float" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:float" />.
        /// </param>
        /// <param name="w">
        /// A <see cref="T:float" />.
        /// </param>
        /// <param name="h">
        /// A <see cref="T:float" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ViewportIndexed(uint index, float x, float y, float w, float h)
        {
            Debug.Assert(Delegates.pglViewportIndexedf != null, "pglViewportIndexedf not implemented");
            Delegates.pglViewportIndexedf(index, x, y, w, h);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glViewportIndexedfv: Binding for glViewportIndexedfv.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ViewportIndexed(uint index, float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglViewportIndexedfv != null, "pglViewportIndexedfv not implemented");
                    Delegates.pglViewportIndexedfv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glScissorArrayv: define the scissor box for multiple viewports
        /// </summary>
        /// <param name="first">
        /// Specifies the index of the first viewport whose scissor box to modify.
        /// </param>
        /// <param name="count">
        /// Specifies the number of scissor boxes to modify.
        /// </param>
        /// <param name="v">
        /// Specifies the address of an array containing the left, bottom, width and height of each scissor box, in that order.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ScissorArray(uint first, int count, int[] v)
        {
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglScissorArrayv != null, "pglScissorArrayv not implemented");
                    Delegates.pglScissorArrayv(first, count, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glScissorIndexed: define the scissor box for a specific viewport
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the viewport whose scissor box to modify.
        /// </param>
        /// <param name="left">
        /// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
        /// </param>
        /// <param name="bottom">
        /// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
        /// </param>
        /// <param name="width">
        /// Specify ths dimensions of the scissor box, in pixels.
        /// </param>
        /// <param name="height">
        /// Specify ths dimensions of the scissor box, in pixels.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ScissorIndexed(uint index, int left, int bottom, int width, int height)
        {
            Debug.Assert(Delegates.pglScissorIndexed != null, "pglScissorIndexed not implemented");
            Delegates.pglScissorIndexed(index, left, bottom, width, height);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glScissorIndexedv: define the scissor box for a specific viewport
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the viewport whose scissor box to modify.
        /// </param>
        /// <param name="v">
        /// For Gl.ScissorIndexedv, specifies the address of an array containing the left, bottom, width and height of each scissor
        /// box, in that order.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void ScissorIndexed(uint index, int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglScissorIndexedv != null, "pglScissorIndexedv not implemented");
                    Delegates.pglScissorIndexedv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glDepthRangeArrayv: specify mapping of depth values from normalized device coordinates to window coordinates for
        /// a
        /// specified set of viewports
        /// </summary>
        /// <param name="first">
        /// Specifies the index of the first viewport whose depth range to update.
        /// </param>
        /// <param name="count">
        /// Specifies the number of viewports whose depth range to update.
        /// </param>
        /// <param name="v">
        /// Specifies the address of an array containing the near and far values for the depth range of each modified viewport.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        public static void DepthRangeArray(uint first, int count, double[] v)
        {
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglDepthRangeArrayv != null, "pglDepthRangeArrayv not implemented");
                    Delegates.pglDepthRangeArrayv(first, count, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glDepthRangeIndexed: specify mapping of depth values from normalized device coordinates to window coordinates for
        /// a specified viewport
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the viewport whose depth range to update.
        /// </param>
        /// <param name="n">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="f">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        public static void DepthRangeIndexed(uint index, double n, double f)
        {
            Debug.Assert(Delegates.pglDepthRangeIndexed != null, "pglDepthRangeIndexed not implemented");
            Delegates.pglDepthRangeIndexed(index, n, f);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Get(int target, uint index, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
                    Delegates.pglGetFloati_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Get(GetPName target, uint index, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
                    Delegates.pglGetFloati_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Get(int target, uint index, out float data)
        {
            unsafe
            {
                fixed (float* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
                    Delegates.pglGetFloati_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Get(GetPName target, uint index, out float data)
        {
            unsafe
            {
                fixed (float* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
                    Delegates.pglGetFloati_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static unsafe void Get(GetPName target, uint index, [Out] float* data)
        {
            Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
            Delegates.pglGetFloati_v((int) target, index, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFloati_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void GetFloat<T>(GetPName target, uint index, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
            data = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(data);
			try {
				unsafe {
					Delegates.pglGetFloati_v((int)target, index, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetFloati_v((int) target, index, (float*) refDataPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static void Get(int target, uint index, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
                    Delegates.pglGetDoublei_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static void Get(GetPName target, uint index, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
                    Delegates.pglGetDoublei_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static void Get(int target, uint index, out double data)
        {
            unsafe
            {
                fixed (double* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
                    Delegates.pglGetDoublei_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static void Get(GetPName target, uint index, out double data)
        {
            unsafe
            {
                fixed (double* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
                    Delegates.pglGetDoublei_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static unsafe void Get(GetPName target, uint index, [Out] double* data)
        {
            Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
            Delegates.pglGetDoublei_v((int) target, index, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublei_v: return the value or values of a selected parameter
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_1")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        public static void GetDouble<T>(GetPName target, uint index, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
            data = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(data);
			try {
				unsafe {
					Delegates.pglGetDoublei_v((int)target, index, (double*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetDoublei_v((int) target, index, (double*) refDataPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glReleaseShaderCompiler();

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")] [ThreadStatic]
            public static glReleaseShaderCompiler pglReleaseShaderCompiler;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glShaderBinary(int count, uint* shaders, int binaryformat, IntPtr binary, int length);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")] [ThreadStatic]
            public static glShaderBinary pglShaderBinary;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetShaderPrecisionFormat(int shadertype, int precisiontype, int* range, int* precision);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")] [ThreadStatic]
            public static glGetShaderPrecisionFormat pglGetShaderPrecisionFormat;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDepthRangef(float n, float f);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1", EntryPoint = "glDepthRangefOES")]
            [ThreadStatic]
            public static glDepthRangef pglDepthRangef;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearDepthf(float d);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1", EntryPoint = "glClearDepthfOES")]
            [ThreadStatic]
            public static glClearDepthf pglClearDepthf;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramBinary(uint program, int bufSize, int* length, int* binaryFormat, IntPtr binary);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2", EntryPoint = "glGetProgramBinaryOES")]
            [ThreadStatic]
            public static glGetProgramBinary pglGetProgramBinary;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramBinary(uint program, int binaryFormat, IntPtr binary, int length);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_get_program_binary", Api = "gles2", EntryPoint = "glProgramBinaryOES")]
            [ThreadStatic]
            public static glProgramBinary pglProgramBinary;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_geometry_shader4")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramParameteri(uint program, int pname, int value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore", EntryPoint = "glProgramParameteriARB")]
            [RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_geometry_shader4", EntryPoint = "glProgramParameteriEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramParameteriEXT")]
            [ThreadStatic]
            public static glProgramParameteri pglProgramParameteri;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUseProgramStages(uint pipeline, uint stages, uint program);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glUseProgramStages pglUseProgramStages;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glActiveShaderProgram(uint pipeline, uint program);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glActiveShaderProgram pglActiveShaderProgram;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate uint glCreateShaderProgramv(int type, int count, string[] strings);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glCreateShaderProgramv pglCreateShaderProgramv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindProgramPipeline(uint pipeline);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glBindProgramPipeline pglBindProgramPipeline;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteProgramPipelines(int n, uint* pipelines);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glDeleteProgramPipelines pglDeleteProgramPipelines;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenProgramPipelines(int n, uint* pipelines);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGenProgramPipelines pglGenProgramPipelines;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsProgramPipeline(uint pipeline);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glIsProgramPipeline pglIsProgramPipeline;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramPipelineiv(uint pipeline, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramPipelineiv pglGetProgramPipelineiv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1i(uint program, int location, int v0);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1iEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1iEXT")]
            [ThreadStatic]
            public static glProgramUniform1i pglProgramUniform1i;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1iv(uint program, int location, int count, int* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1ivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1ivEXT")]
            [ThreadStatic]
            public static glProgramUniform1iv pglProgramUniform1iv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1f(uint program, int location, float v0);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1fEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1fEXT")]
            [ThreadStatic]
            public static glProgramUniform1f pglProgramUniform1f;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1fv(uint program, int location, int count, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1fvEXT")]
            [ThreadStatic]
            public static glProgramUniform1fv pglProgramUniform1fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1d(uint program, int location, double v0);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform1d pglProgramUniform1d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1dv(uint program, int location, int count, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform1dv pglProgramUniform1dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1ui(uint program, int location, uint v0);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1uiEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1uiEXT")]
            [ThreadStatic]
            public static glProgramUniform1ui pglProgramUniform1ui;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform1uiv(uint program, int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform1uivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform1uivEXT")]
            [ThreadStatic]
            public static glProgramUniform1uiv pglProgramUniform1uiv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2i(uint program, int location, int v0, int v1);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2iEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2iEXT")]
            [ThreadStatic]
            public static glProgramUniform2i pglProgramUniform2i;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2iv(uint program, int location, int count, int* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2ivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2ivEXT")]
            [ThreadStatic]
            public static glProgramUniform2iv pglProgramUniform2iv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2f(uint program, int location, float v0, float v1);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2fEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2fEXT")]
            [ThreadStatic]
            public static glProgramUniform2f pglProgramUniform2f;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2fv(uint program, int location, int count, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2fvEXT")]
            [ThreadStatic]
            public static glProgramUniform2fv pglProgramUniform2fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2d(uint program, int location, double v0, double v1);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform2d pglProgramUniform2d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2dv(uint program, int location, int count, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform2dv pglProgramUniform2dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2ui(uint program, int location, uint v0, uint v1);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2uiEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2uiEXT")]
            [ThreadStatic]
            public static glProgramUniform2ui pglProgramUniform2ui;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform2uiv(uint program, int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform2uivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform2uivEXT")]
            [ThreadStatic]
            public static glProgramUniform2uiv pglProgramUniform2uiv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3iEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3iEXT")]
            [ThreadStatic]
            public static glProgramUniform3i pglProgramUniform3i;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3iv(uint program, int location, int count, int* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3ivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3ivEXT")]
            [ThreadStatic]
            public static glProgramUniform3iv pglProgramUniform3iv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3fEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3fEXT")]
            [ThreadStatic]
            public static glProgramUniform3f pglProgramUniform3f;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3fv(uint program, int location, int count, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3fvEXT")]
            [ThreadStatic]
            public static glProgramUniform3fv pglProgramUniform3fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3d(uint program, int location, double v0, double v1, double v2);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform3d pglProgramUniform3d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3dv(uint program, int location, int count, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform3dv pglProgramUniform3dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3uiEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3uiEXT")]
            [ThreadStatic]
            public static glProgramUniform3ui pglProgramUniform3ui;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform3uiv(uint program, int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform3uivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform3uivEXT")]
            [ThreadStatic]
            public static glProgramUniform3uiv pglProgramUniform3uiv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4iEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4iEXT")]
            [ThreadStatic]
            public static glProgramUniform4i pglProgramUniform4i;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4iv(uint program, int location, int count, int* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4ivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4ivEXT")]
            [ThreadStatic]
            public static glProgramUniform4iv pglProgramUniform4iv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4fEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4fEXT")]
            [ThreadStatic]
            public static glProgramUniform4f pglProgramUniform4f;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4fv(uint program, int location, int count, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4fvEXT")]
            [ThreadStatic]
            public static glProgramUniform4fv pglProgramUniform4fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform4d pglProgramUniform4d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4dv(uint program, int location, int count, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniform4dv pglProgramUniform4dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4uiEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4uiEXT")]
            [ThreadStatic]
            public static glProgramUniform4ui pglProgramUniform4ui;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniform4uiv(uint program, int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniform4uivEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniform4uivEXT")]
            [ThreadStatic]
            public static glProgramUniform4uiv pglProgramUniform4uiv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix2fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix2fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix2fv pglProgramUniformMatrix2fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix3fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix3fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix3fv pglProgramUniformMatrix3fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix4fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix4fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix4fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix4fv pglProgramUniformMatrix4fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix2dv pglProgramUniformMatrix2dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix3dv pglProgramUniformMatrix3dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix4dv pglProgramUniformMatrix4dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2x3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix2x3fv pglProgramUniformMatrix2x3fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3x2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix3x2fv pglProgramUniformMatrix3x2fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2x4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix2x4fv pglProgramUniformMatrix2x4fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4x2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix4x2fv pglProgramUniformMatrix4x2fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3x4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix3x4fv pglProgramUniformMatrix3x4fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4x3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, float* value);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
            [RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2", EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
            [ThreadStatic]
            public static glProgramUniformMatrix4x3fv pglProgramUniformMatrix4x3fv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2x3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix2x3dv pglProgramUniformMatrix2x3dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3x2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix3x2dv pglProgramUniformMatrix3x2dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix2x4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix2x4dv pglProgramUniformMatrix2x4dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4x2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix4x2dv pglProgramUniformMatrix4x2dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix3x4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix3x4dv pglProgramUniformMatrix3x4dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProgramUniformMatrix4x3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, double* value);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glProgramUniformMatrix4x3dv pglProgramUniformMatrix4x3dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glValidateProgramPipeline(uint pipeline);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glValidateProgramPipeline pglValidateProgramPipeline;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramPipelineInfoLog pglGetProgramPipelineInfoLog;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL1d(uint index, double x);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL1dEXT")]
            [ThreadStatic]
            public static glVertexAttribL1d pglVertexAttribL1d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL2d(uint index, double x, double y);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL2dEXT")]
            [ThreadStatic]
            public static glVertexAttribL2d pglVertexAttribL2d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL3d(uint index, double x, double y, double z);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL3dEXT")]
            [ThreadStatic]
            public static glVertexAttribL3d pglVertexAttribL3d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL4d(uint index, double x, double y, double z, double w);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL4dEXT")]
            [ThreadStatic]
            public static glVertexAttribL4d pglVertexAttribL4d;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL1dv(uint index, double* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL1dvEXT")]
            [ThreadStatic]
            public static glVertexAttribL1dv pglVertexAttribL1dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL2dv(uint index, double* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL2dvEXT")]
            [ThreadStatic]
            public static glVertexAttribL2dv pglVertexAttribL2dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL3dv(uint index, double* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL3dvEXT")]
            [ThreadStatic]
            public static glVertexAttribL3dv pglVertexAttribL3dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribL4dv(uint index, double* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribL4dvEXT")]
            [ThreadStatic]
            public static glVertexAttribL4dv pglVertexAttribL4dv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribLPointer(uint index, int size, int type, int stride, IntPtr pointer);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glVertexAttribLPointerEXT")]
            [ThreadStatic]
            public static glVertexAttribLPointer pglVertexAttribLPointer;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetVertexAttribLdv(uint index, int pname, double* @params);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_vertex_attrib_64bit", EntryPoint = "glGetVertexAttribLdvEXT")]
            [ThreadStatic]
            public static glGetVertexAttribLdv pglGetVertexAttribLdv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glViewportArrayv(uint first, int count, float* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glViewportArrayvNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glViewportArrayvOES")]
            [ThreadStatic]
            public static glViewportArrayv pglViewportArrayv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glViewportIndexedf(uint index, float x, float y, float w, float h);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glViewportIndexedfNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glViewportIndexedfOES")]
            [ThreadStatic]
            public static glViewportIndexedf pglViewportIndexedf;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glViewportIndexedfv(uint index, float* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glViewportIndexedfvNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glViewportIndexedfvOES")]
            [ThreadStatic]
            public static glViewportIndexedfv pglViewportIndexedfv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glScissorArrayv(uint first, int count, int* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glScissorArrayvNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glScissorArrayvOES")]
            [ThreadStatic]
            public static glScissorArrayv pglScissorArrayv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glScissorIndexed(uint index, int left, int bottom, int width, int height);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glScissorIndexedNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glScissorIndexedOES")]
            [ThreadStatic]
            public static glScissorIndexed pglScissorIndexed;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glScissorIndexedv(uint index, int* v);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glScissorIndexedvNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glScissorIndexedvOES")]
            [ThreadStatic]
            public static glScissorIndexedv pglScissorIndexedv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDepthRangeArrayv(uint first, int count, double* v);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")] [ThreadStatic]
            public static glDepthRangeArrayv pglDepthRangeArrayv;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDepthRangeIndexed(uint index, double n, double f);

            [RequiredByFeature("GL_VERSION_4_1")] [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")] [ThreadStatic]
            public static glDepthRangeIndexed pglDepthRangeIndexed;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetFloati_v(int target, uint index, float* data);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetFloatIndexedvEXT")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetFloatIndexedvEXT")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glGetFloati_vNV")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glGetFloati_vOES")]
            [ThreadStatic]
            public static glGetFloati_v pglGetFloati_v;

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetDoublei_v(int target, uint index, double* data);

            [RequiredByFeature("GL_VERSION_4_1")]
            [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetDoubleIndexedvEXT")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetDoubleIndexedvEXT")]
            [ThreadStatic]
            public static glGetDoublei_v pglGetDoublei_v;
        }
    }
}