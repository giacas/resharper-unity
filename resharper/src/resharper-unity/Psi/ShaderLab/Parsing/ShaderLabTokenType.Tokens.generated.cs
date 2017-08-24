﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by TokenGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Plugins.Unity.Psi.ShaderLab.Parsing
{
  public partial class ShaderLabTokenType
  {
    //FragmentDelimiters
    public const int CG_PROGRAM_NODE_TYPE_INDEX = 1000;
    public static readonly TokenNodeType CG_PROGRAM = new KeywordTokenNodeType("CG_PROGRAM", CG_PROGRAM_NODE_TYPE_INDEX, representation: "CGPROGRAM");
    public const int CG_INCLUDE_NODE_TYPE_INDEX = 1001;
    public static readonly TokenNodeType CG_INCLUDE = new KeywordTokenNodeType("CG_INCLUDE", CG_INCLUDE_NODE_TYPE_INDEX, representation: "CGINCLUDE");
    public const int CG_END_NODE_TYPE_INDEX = 1002;
    public static readonly TokenNodeType CG_END = new KeywordTokenNodeType("CG_END", CG_END_NODE_TYPE_INDEX, representation: "ENDCG");
    public const int GLSL_PROGRAM_NODE_TYPE_INDEX = 1003;
    public static readonly TokenNodeType GLSL_PROGRAM = new KeywordTokenNodeType("GLSL_PROGRAM", GLSL_PROGRAM_NODE_TYPE_INDEX, representation: "GLSLPROGRAM");
    public const int GLSL_INCLUDE_NODE_TYPE_INDEX = 1004;
    public static readonly TokenNodeType GLSL_INCLUDE = new KeywordTokenNodeType("GLSL_INCLUDE", GLSL_INCLUDE_NODE_TYPE_INDEX, representation: "GLSLINCLUDE");
    public const int GLSL_END_NODE_TYPE_INDEX = 1005;
    public static readonly TokenNodeType GLSL_END = new KeywordTokenNodeType("GLSL_END", GLSL_END_NODE_TYPE_INDEX, representation: "ENDGLSL");
    public const int HLSL_PROGRAM_NODE_TYPE_INDEX = 1006;
    public static readonly TokenNodeType HLSL_PROGRAM = new KeywordTokenNodeType("HLSL_PROGRAM", HLSL_PROGRAM_NODE_TYPE_INDEX, representation: "HLSLPROGRAM");
    public const int HLSL_INCLUDE_NODE_TYPE_INDEX = 1007;
    public static readonly TokenNodeType HLSL_INCLUDE = new KeywordTokenNodeType("HLSL_INCLUDE", HLSL_INCLUDE_NODE_TYPE_INDEX, representation: "HLSLINCLUDE");
    public const int HLSL_END_NODE_TYPE_INDEX = 1008;
    public static readonly TokenNodeType HLSL_END = new KeywordTokenNodeType("HLSL_END", HLSL_END_NODE_TYPE_INDEX, representation: "ENDHLSL");

    //Tokens
    public const int LPAREN_NODE_TYPE_INDEX = 1009;
    public static readonly TokenNodeType LPAREN = new FixedTokenNodeType("LPAREN", LPAREN_NODE_TYPE_INDEX, representation: "(");
    public const int RPAREN_NODE_TYPE_INDEX = 1010;
    public static readonly TokenNodeType RPAREN = new FixedTokenNodeType("RPAREN", RPAREN_NODE_TYPE_INDEX, representation: ")");
    public const int LBRACK_NODE_TYPE_INDEX = 1011;
    public static readonly TokenNodeType LBRACK = new FixedTokenNodeType("LBRACK", LBRACK_NODE_TYPE_INDEX, representation: "[");
    public const int RBRACK_NODE_TYPE_INDEX = 1012;
    public static readonly TokenNodeType RBRACK = new FixedTokenNodeType("RBRACK", RBRACK_NODE_TYPE_INDEX, representation: "]");
    public const int LBRACE_NODE_TYPE_INDEX = 1013;
    public static readonly TokenNodeType LBRACE = new FixedTokenNodeType("LBRACE", LBRACE_NODE_TYPE_INDEX, representation: "{");
    public const int RBRACE_NODE_TYPE_INDEX = 1014;
    public static readonly TokenNodeType RBRACE = new FixedTokenNodeType("RBRACE", RBRACE_NODE_TYPE_INDEX, representation: "}");
    public const int COMMA_NODE_TYPE_INDEX = 1015;
    public static readonly TokenNodeType COMMA = new FixedTokenNodeType("COMMA", COMMA_NODE_TYPE_INDEX, representation: ",");
    public const int DOT_NODE_TYPE_INDEX = 1016;
    public static readonly TokenNodeType DOT = new FixedTokenNodeType("DOT", DOT_NODE_TYPE_INDEX, representation: ".");
    public const int EQUALS_NODE_TYPE_INDEX = 1017;
    public static readonly TokenNodeType EQUALS = new FixedTokenNodeType("EQUALS", EQUALS_NODE_TYPE_INDEX, representation: "=");
    public const int PLUS_NODE_TYPE_INDEX = 1018;
    public static readonly TokenNodeType PLUS = new FixedTokenNodeType("PLUS", PLUS_NODE_TYPE_INDEX, representation: "+");
    public const int MINUS_NODE_TYPE_INDEX = 1019;
    public static readonly TokenNodeType MINUS = new FixedTokenNodeType("MINUS", MINUS_NODE_TYPE_INDEX, representation: "-");
    public const int MULTIPLY_NODE_TYPE_INDEX = 1020;
    public static readonly TokenNodeType MULTIPLY = new FixedTokenNodeType("MULTIPLY", MULTIPLY_NODE_TYPE_INDEX, representation: "*");

    //Commands
    public const int SHADER_KEYWORD_NODE_TYPE_INDEX = 1021;
    public static readonly TokenNodeType SHADER_KEYWORD = new KeywordTokenNodeType("SHADER_KEYWORD", SHADER_KEYWORD_NODE_TYPE_INDEX, representation: "Shader");
    public const int PROPERTIES_KEYWORD_NODE_TYPE_INDEX = 1022;
    public static readonly TokenNodeType PROPERTIES_KEYWORD = new KeywordTokenNodeType("PROPERTIES_KEYWORD", PROPERTIES_KEYWORD_NODE_TYPE_INDEX, representation: "Properties");
    public const int CATEGORY_KEYWORD_NODE_TYPE_INDEX = 1023;
    public static readonly TokenNodeType CATEGORY_KEYWORD = new KeywordTokenNodeType("CATEGORY_KEYWORD", CATEGORY_KEYWORD_NODE_TYPE_INDEX, representation: "Category");
    public const int SUB_SHADER_KEYWORD_NODE_TYPE_INDEX = 1024;
    public static readonly TokenNodeType SUB_SHADER_KEYWORD = new KeywordTokenNodeType("SUB_SHADER_KEYWORD", SUB_SHADER_KEYWORD_NODE_TYPE_INDEX, representation: "SubShader");
    public const int FALLBACK_KEYWORD_NODE_TYPE_INDEX = 1025;
    public static readonly TokenNodeType FALLBACK_KEYWORD = new KeywordTokenNodeType("FALLBACK_KEYWORD", FALLBACK_KEYWORD_NODE_TYPE_INDEX, representation: "Fallback");
    public const int CUSTOM_EDITOR_KEYWORD_NODE_TYPE_INDEX = 1026;
    public static readonly TokenNodeType CUSTOM_EDITOR_KEYWORD = new KeywordTokenNodeType("CUSTOM_EDITOR_KEYWORD", CUSTOM_EDITOR_KEYWORD_NODE_TYPE_INDEX, representation: "CustomEditor");
    public const int DEPENDENCY_KEYWORD_NODE_TYPE_INDEX = 1027;
    public static readonly TokenNodeType DEPENDENCY_KEYWORD = new KeywordTokenNodeType("DEPENDENCY_KEYWORD", DEPENDENCY_KEYWORD_NODE_TYPE_INDEX, representation: "Dependency");

    //PropertyTypeKeywords
    public const int COLOR_KEYWORD_NODE_TYPE_INDEX = 1028;
    public static readonly TokenNodeType COLOR_KEYWORD = new KeywordTokenNodeType("COLOR_KEYWORD", COLOR_KEYWORD_NODE_TYPE_INDEX, representation: "Color");
    public const int CUBE_KEYWORD_NODE_TYPE_INDEX = 1029;
    public static readonly TokenNodeType CUBE_KEYWORD = new KeywordTokenNodeType("CUBE_KEYWORD", CUBE_KEYWORD_NODE_TYPE_INDEX, representation: "Cube");
    public const int FLOAT_KEYWORD_NODE_TYPE_INDEX = 1030;
    public static readonly TokenNodeType FLOAT_KEYWORD = new KeywordTokenNodeType("FLOAT_KEYWORD", FLOAT_KEYWORD_NODE_TYPE_INDEX, representation: "Float");
    public const int INT_KEYWORD_NODE_TYPE_INDEX = 1031;
    public static readonly TokenNodeType INT_KEYWORD = new KeywordTokenNodeType("INT_KEYWORD", INT_KEYWORD_NODE_TYPE_INDEX, representation: "Int");
    public const int RANGE_KEYWORD_NODE_TYPE_INDEX = 1032;
    public static readonly TokenNodeType RANGE_KEYWORD = new KeywordTokenNodeType("RANGE_KEYWORD", RANGE_KEYWORD_NODE_TYPE_INDEX, representation: "Range");
    public const int TEXTURE_2D_KEYWORD_NODE_TYPE_INDEX = 1033;
    public static readonly TokenNodeType TEXTURE_2D_KEYWORD = new KeywordTokenNodeType("TEXTURE_2D_KEYWORD", TEXTURE_2D_KEYWORD_NODE_TYPE_INDEX, representation: "2D");
    public const int TEXTURE_3D_KEYWORD_NODE_TYPE_INDEX = 1034;
    public static readonly TokenNodeType TEXTURE_3D_KEYWORD = new KeywordTokenNodeType("TEXTURE_3D_KEYWORD", TEXTURE_3D_KEYWORD_NODE_TYPE_INDEX, representation: "3D");
    public const int VECTOR_KEYWORD_NODE_TYPE_INDEX = 1035;
    public static readonly TokenNodeType VECTOR_KEYWORD = new KeywordTokenNodeType("VECTOR_KEYWORD", VECTOR_KEYWORD_NODE_TYPE_INDEX, representation: "Vector");

    //SubShaderCommands
    public const int TAGS_KEYWORD_NODE_TYPE_INDEX = 1036;
    public static readonly TokenNodeType TAGS_KEYWORD = new KeywordTokenNodeType("TAGS_KEYWORD", TAGS_KEYWORD_NODE_TYPE_INDEX, representation: "Tags");
    public const int PASS_KEYWORD_NODE_TYPE_INDEX = 1037;
    public static readonly TokenNodeType PASS_KEYWORD = new KeywordTokenNodeType("PASS_KEYWORD", PASS_KEYWORD_NODE_TYPE_INDEX, representation: "Pass");
    public const int USEPASS_KEYWORD_NODE_TYPE_INDEX = 1038;
    public static readonly TokenNodeType USEPASS_KEYWORD = new KeywordTokenNodeType("USEPASS_KEYWORD", USEPASS_KEYWORD_NODE_TYPE_INDEX, representation: "UsePass");
    public const int GRABPASS_KEYWORD_NODE_TYPE_INDEX = 1039;
    public static readonly TokenNodeType GRABPASS_KEYWORD = new KeywordTokenNodeType("GRABPASS_KEYWORD", GRABPASS_KEYWORD_NODE_TYPE_INDEX, representation: "GrabPass");

    //RenderStateCommands
    public const int CULL_KEYWORD_NODE_TYPE_INDEX = 1040;
    public static readonly TokenNodeType CULL_KEYWORD = new KeywordTokenNodeType("CULL_KEYWORD", CULL_KEYWORD_NODE_TYPE_INDEX, representation: "Cull");
    public const int ZTEST_KEYWORD_NODE_TYPE_INDEX = 1041;
    public static readonly TokenNodeType ZTEST_KEYWORD = new KeywordTokenNodeType("ZTEST_KEYWORD", ZTEST_KEYWORD_NODE_TYPE_INDEX, representation: "ZTest");
    public const int ZWRITE_KEYWORD_NODE_TYPE_INDEX = 1042;
    public static readonly TokenNodeType ZWRITE_KEYWORD = new KeywordTokenNodeType("ZWRITE_KEYWORD", ZWRITE_KEYWORD_NODE_TYPE_INDEX, representation: "ZWrite");
    public const int OFFSET_KEYWORD_NODE_TYPE_INDEX = 1043;
    public static readonly TokenNodeType OFFSET_KEYWORD = new KeywordTokenNodeType("OFFSET_KEYWORD", OFFSET_KEYWORD_NODE_TYPE_INDEX, representation: "Offset");
    public const int BLEND_KEYWORD_NODE_TYPE_INDEX = 1044;
    public static readonly TokenNodeType BLEND_KEYWORD = new KeywordTokenNodeType("BLEND_KEYWORD", BLEND_KEYWORD_NODE_TYPE_INDEX, representation: "Blend");
    public const int BLEND_OP_KEYWORD_NODE_TYPE_INDEX = 1045;
    public static readonly TokenNodeType BLEND_OP_KEYWORD = new KeywordTokenNodeType("BLEND_OP_KEYWORD", BLEND_OP_KEYWORD_NODE_TYPE_INDEX, representation: "BlendOp");
    public const int ALPHA_TO_MASK_KEYWORD_NODE_TYPE_INDEX = 1046;
    public static readonly TokenNodeType ALPHA_TO_MASK_KEYWORD = new KeywordTokenNodeType("ALPHA_TO_MASK_KEYWORD", ALPHA_TO_MASK_KEYWORD_NODE_TYPE_INDEX, representation: "AlphaToMask");
    public const int COLOR_MASK_KEYWORD_NODE_TYPE_INDEX = 1047;
    public static readonly TokenNodeType COLOR_MASK_KEYWORD = new KeywordTokenNodeType("COLOR_MASK_KEYWORD", COLOR_MASK_KEYWORD_NODE_TYPE_INDEX, representation: "ColorMask");
    public const int STENCIL_KEYWORD_NODE_TYPE_INDEX = 1048;
    public static readonly TokenNodeType STENCIL_KEYWORD = new KeywordTokenNodeType("STENCIL_KEYWORD", STENCIL_KEYWORD_NODE_TYPE_INDEX, representation: "Stencil");
    public const int NAME_KEYWORD_NODE_TYPE_INDEX = 1049;
    public static readonly TokenNodeType NAME_KEYWORD = new KeywordTokenNodeType("NAME_KEYWORD", NAME_KEYWORD_NODE_TYPE_INDEX, representation: "Name");
    public const int LOD_KEYWORD_NODE_TYPE_INDEX = 1050;
    public static readonly TokenNodeType LOD_KEYWORD = new KeywordTokenNodeType("LOD_KEYWORD", LOD_KEYWORD_NODE_TYPE_INDEX, representation: "LOD");
    public const int BIND_CHANNELS_KEYWORD_NODE_TYPE_INDEX = 1051;
    public static readonly TokenNodeType BIND_CHANNELS_KEYWORD = new KeywordTokenNodeType("BIND_CHANNELS_KEYWORD", BIND_CHANNELS_KEYWORD_NODE_TYPE_INDEX, representation: "BindChannels");

    //LegacyFixedFunctionCommands
    public const int LIGHTING_KEYWORD_NODE_TYPE_INDEX = 1052;
    public static readonly TokenNodeType LIGHTING_KEYWORD = new KeywordTokenNodeType("LIGHTING_KEYWORD", LIGHTING_KEYWORD_NODE_TYPE_INDEX, representation: "Lighting");
    public const int MATERIAL_KEYWORD_NODE_TYPE_INDEX = 1053;
    public static readonly TokenNodeType MATERIAL_KEYWORD = new KeywordTokenNodeType("MATERIAL_KEYWORD", MATERIAL_KEYWORD_NODE_TYPE_INDEX, representation: "Material");
    public const int SEPARATE_SPECULAR_KEYWORD_NODE_TYPE_INDEX = 1054;
    public static readonly TokenNodeType SEPARATE_SPECULAR_KEYWORD = new KeywordTokenNodeType("SEPARATE_SPECULAR_KEYWORD", SEPARATE_SPECULAR_KEYWORD_NODE_TYPE_INDEX, representation: "SeparateSpecular");
    public const int COLOR_MATERIAL_KEYWORD_NODE_TYPE_INDEX = 1055;
    public static readonly TokenNodeType COLOR_MATERIAL_KEYWORD = new KeywordTokenNodeType("COLOR_MATERIAL_KEYWORD", COLOR_MATERIAL_KEYWORD_NODE_TYPE_INDEX, representation: "ColorMaterial");
    public const int FOG_KEYWORD_NODE_TYPE_INDEX = 1056;
    public static readonly TokenNodeType FOG_KEYWORD = new KeywordTokenNodeType("FOG_KEYWORD", FOG_KEYWORD_NODE_TYPE_INDEX, representation: "Fog");
    public const int ALPHA_TEST_KEYWORD_NODE_TYPE_INDEX = 1057;
    public static readonly TokenNodeType ALPHA_TEST_KEYWORD = new KeywordTokenNodeType("ALPHA_TEST_KEYWORD", ALPHA_TEST_KEYWORD_NODE_TYPE_INDEX, representation: "AlphaTest");
    public const int SET_TEXTURE_KEYWORD_NODE_TYPE_INDEX = 1058;
    public static readonly TokenNodeType SET_TEXTURE_KEYWORD = new KeywordTokenNodeType("SET_TEXTURE_KEYWORD", SET_TEXTURE_KEYWORD_NODE_TYPE_INDEX, representation: "SetTexture");

    //LegacyMaterialCommands
    public const int DIFFUSE_KEYWORD_NODE_TYPE_INDEX = 1059;
    public static readonly TokenNodeType DIFFUSE_KEYWORD = new KeywordTokenNodeType("DIFFUSE_KEYWORD", DIFFUSE_KEYWORD_NODE_TYPE_INDEX, representation: "Diffuse");
    public const int AMBIENT_KEYWORD_NODE_TYPE_INDEX = 1060;
    public static readonly TokenNodeType AMBIENT_KEYWORD = new KeywordTokenNodeType("AMBIENT_KEYWORD", AMBIENT_KEYWORD_NODE_TYPE_INDEX, representation: "Ambient");
    public const int SPECULAR_KEYWORD_NODE_TYPE_INDEX = 1061;
    public static readonly TokenNodeType SPECULAR_KEYWORD = new KeywordTokenNodeType("SPECULAR_KEYWORD", SPECULAR_KEYWORD_NODE_TYPE_INDEX, representation: "Specular");
    public const int SHININESS_KEYWORD_NODE_TYPE_INDEX = 1062;
    public static readonly TokenNodeType SHININESS_KEYWORD = new KeywordTokenNodeType("SHININESS_KEYWORD", SHININESS_KEYWORD_NODE_TYPE_INDEX, representation: "Shininess");

    //LegacyTextureCommands
    public const int COMBINE_KEYWORD_NODE_TYPE_INDEX = 1063;
    public static readonly TokenNodeType COMBINE_KEYWORD = new KeywordTokenNodeType("COMBINE_KEYWORD", COMBINE_KEYWORD_NODE_TYPE_INDEX, representation: "Combine");
    public const int CONSTANT_COLOR_KEYWORD_NODE_TYPE_INDEX = 1064;
    public static readonly TokenNodeType CONSTANT_COLOR_KEYWORD = new KeywordTokenNodeType("CONSTANT_COLOR_KEYWORD", CONSTANT_COLOR_KEYWORD_NODE_TYPE_INDEX, representation: "ConstantColor");

    //LegacyTextureCombinerKeywords
    public const int PREVIOUS_KEYWORD_NODE_TYPE_INDEX = 1065;
    public static readonly TokenNodeType PREVIOUS_KEYWORD = new KeywordTokenNodeType("PREVIOUS_KEYWORD", PREVIOUS_KEYWORD_NODE_TYPE_INDEX, representation: "Previous");
    public const int PRIMARY_KEYWORD_NODE_TYPE_INDEX = 1066;
    public static readonly TokenNodeType PRIMARY_KEYWORD = new KeywordTokenNodeType("PRIMARY_KEYWORD", PRIMARY_KEYWORD_NODE_TYPE_INDEX, representation: "Primary");
    public const int TEXTURE_KEYWORD_NODE_TYPE_INDEX = 1067;
    public static readonly TokenNodeType TEXTURE_KEYWORD = new KeywordTokenNodeType("TEXTURE_KEYWORD", TEXTURE_KEYWORD_NODE_TYPE_INDEX, representation: "Texture");
    public const int CONSTANT_KEYWORD_NODE_TYPE_INDEX = 1068;
    public static readonly TokenNodeType CONSTANT_KEYWORD = new KeywordTokenNodeType("CONSTANT_KEYWORD", CONSTANT_KEYWORD_NODE_TYPE_INDEX, representation: "Constant");
    public const int DOUBLE_KEYWORD_NODE_TYPE_INDEX = 1069;
    public static readonly TokenNodeType DOUBLE_KEYWORD = new KeywordTokenNodeType("DOUBLE_KEYWORD", DOUBLE_KEYWORD_NODE_TYPE_INDEX, representation: "Double");
    public const int QUAD_KEYWORD_NODE_TYPE_INDEX = 1070;
    public static readonly TokenNodeType QUAD_KEYWORD = new KeywordTokenNodeType("QUAD_KEYWORD", QUAD_KEYWORD_NODE_TYPE_INDEX, representation: "Quad");
    public const int LERP_KEYWORD_NODE_TYPE_INDEX = 1071;
    public static readonly TokenNodeType LERP_KEYWORD = new KeywordTokenNodeType("LERP_KEYWORD", LERP_KEYWORD_NODE_TYPE_INDEX, representation: "Lerp");
    public const int ONE_KEYWORD_NODE_TYPE_INDEX = 1072;
    public static readonly TokenNodeType ONE_KEYWORD = new KeywordTokenNodeType("ONE_KEYWORD", ONE_KEYWORD_NODE_TYPE_INDEX, representation: "One");
    public const int ALPHA_KEYWORD_NODE_TYPE_INDEX = 1073;
    public static readonly TokenNodeType ALPHA_KEYWORD = new KeywordTokenNodeType("ALPHA_KEYWORD", ALPHA_KEYWORD_NODE_TYPE_INDEX, representation: "Alpha");

    //LegacyBindChannelsCommands
    public const int BIND_KEYWORD_NODE_TYPE_INDEX = 1074;
    public static readonly TokenNodeType BIND_KEYWORD = new KeywordTokenNodeType("BIND_KEYWORD", BIND_KEYWORD_NODE_TYPE_INDEX, representation: "Bind");

    //ColorMaterialKeywords
    public const int AMBIENT_AND_DIFFUSE_KEYWORD_NODE_TYPE_INDEX = 1075;
    public static readonly TokenNodeType AMBIENT_AND_DIFFUSE_KEYWORD = new KeywordTokenNodeType("AMBIENT_AND_DIFFUSE_KEYWORD", AMBIENT_AND_DIFFUSE_KEYWORD_NODE_TYPE_INDEX, representation: "AmbientAndDiffuse");
    public const int EMISSION_KEYWORD_NODE_TYPE_INDEX = 1076;
    public static readonly TokenNodeType EMISSION_KEYWORD = new KeywordTokenNodeType("EMISSION_KEYWORD", EMISSION_KEYWORD_NODE_TYPE_INDEX, representation: "Emission");

    //LegacyFogCommands
    public const int MODE_KEYWORD_NODE_TYPE_INDEX = 1077;
    public static readonly TokenNodeType MODE_KEYWORD = new KeywordTokenNodeType("MODE_KEYWORD", MODE_KEYWORD_NODE_TYPE_INDEX, representation: "Mode");
    public const int DENSITY_KEYWORD_NODE_TYPE_INDEX = 1078;
    public static readonly TokenNodeType DENSITY_KEYWORD = new KeywordTokenNodeType("DENSITY_KEYWORD", DENSITY_KEYWORD_NODE_TYPE_INDEX, representation: "Density");

    //FogModeKeywords
    public const int GLOBAL_KEYWORD_NODE_TYPE_INDEX = 1079;
    public static readonly TokenNodeType GLOBAL_KEYWORD = new KeywordTokenNodeType("GLOBAL_KEYWORD", GLOBAL_KEYWORD_NODE_TYPE_INDEX, representation: "Global");
    public const int LINEAR_KEYWORD_NODE_TYPE_INDEX = 1080;
    public static readonly TokenNodeType LINEAR_KEYWORD = new KeywordTokenNodeType("LINEAR_KEYWORD", LINEAR_KEYWORD_NODE_TYPE_INDEX, representation: "Linear");
    public const int EXP_KEYWORD_NODE_TYPE_INDEX = 1081;
    public static readonly TokenNodeType EXP_KEYWORD = new KeywordTokenNodeType("EXP_KEYWORD", EXP_KEYWORD_NODE_TYPE_INDEX, representation: "Exp");
    public const int EXP2_KEYWORD_NODE_TYPE_INDEX = 1082;
    public static readonly TokenNodeType EXP2_KEYWORD = new KeywordTokenNodeType("EXP2_KEYWORD", EXP2_KEYWORD_NODE_TYPE_INDEX, representation: "Exp2");

    //StencilCommands
    public const int REF_KEYWORD_NODE_TYPE_INDEX = 1083;
    public static readonly TokenNodeType REF_KEYWORD = new KeywordTokenNodeType("REF_KEYWORD", REF_KEYWORD_NODE_TYPE_INDEX, representation: "Ref");
    public const int READ_MASK_KEYWORD_NODE_TYPE_INDEX = 1084;
    public static readonly TokenNodeType READ_MASK_KEYWORD = new KeywordTokenNodeType("READ_MASK_KEYWORD", READ_MASK_KEYWORD_NODE_TYPE_INDEX, representation: "ReadMask");
    public const int WRITE_MASK_KEYWORD_NODE_TYPE_INDEX = 1085;
    public static readonly TokenNodeType WRITE_MASK_KEYWORD = new KeywordTokenNodeType("WRITE_MASK_KEYWORD", WRITE_MASK_KEYWORD_NODE_TYPE_INDEX, representation: "WriteMask");
    public const int PASS_FRONT_KEYWORD_NODE_TYPE_INDEX = 1086;
    public static readonly TokenNodeType PASS_FRONT_KEYWORD = new KeywordTokenNodeType("PASS_FRONT_KEYWORD", PASS_FRONT_KEYWORD_NODE_TYPE_INDEX, representation: "PassFront");
    public const int PASS_BACK_KEYWORD_NODE_TYPE_INDEX = 1087;
    public static readonly TokenNodeType PASS_BACK_KEYWORD = new KeywordTokenNodeType("PASS_BACK_KEYWORD", PASS_BACK_KEYWORD_NODE_TYPE_INDEX, representation: "PassBack");
    public const int COMP_KEYWORD_NODE_TYPE_INDEX = 1088;
    public static readonly TokenNodeType COMP_KEYWORD = new KeywordTokenNodeType("COMP_KEYWORD", COMP_KEYWORD_NODE_TYPE_INDEX, representation: "Comp");
    public const int COMP_FRONT_KEYWORD_NODE_TYPE_INDEX = 1089;
    public static readonly TokenNodeType COMP_FRONT_KEYWORD = new KeywordTokenNodeType("COMP_FRONT_KEYWORD", COMP_FRONT_KEYWORD_NODE_TYPE_INDEX, representation: "CompFront");
    public const int COMP_BACK_KEYWORD_NODE_TYPE_INDEX = 1090;
    public static readonly TokenNodeType COMP_BACK_KEYWORD = new KeywordTokenNodeType("COMP_BACK_KEYWORD", COMP_BACK_KEYWORD_NODE_TYPE_INDEX, representation: "CompBack");
    public const int FAIL_KEYWORD_NODE_TYPE_INDEX = 1091;
    public static readonly TokenNodeType FAIL_KEYWORD = new KeywordTokenNodeType("FAIL_KEYWORD", FAIL_KEYWORD_NODE_TYPE_INDEX, representation: "Fail");
    public const int FAIL_FRONT_KEYWORD_NODE_TYPE_INDEX = 1092;
    public static readonly TokenNodeType FAIL_FRONT_KEYWORD = new KeywordTokenNodeType("FAIL_FRONT_KEYWORD", FAIL_FRONT_KEYWORD_NODE_TYPE_INDEX, representation: "FailFront");
    public const int FAIL_BACK_KEYWORD_NODE_TYPE_INDEX = 1093;
    public static readonly TokenNodeType FAIL_BACK_KEYWORD = new KeywordTokenNodeType("FAIL_BACK_KEYWORD", FAIL_BACK_KEYWORD_NODE_TYPE_INDEX, representation: "FailBack");
    public const int ZFAIL_KEYWORD_NODE_TYPE_INDEX = 1094;
    public static readonly TokenNodeType ZFAIL_KEYWORD = new KeywordTokenNodeType("ZFAIL_KEYWORD", ZFAIL_KEYWORD_NODE_TYPE_INDEX, representation: "ZFail");
    public const int ZFAIL_FRONT_KEYWORD_NODE_TYPE_INDEX = 1095;
    public static readonly TokenNodeType ZFAIL_FRONT_KEYWORD = new KeywordTokenNodeType("ZFAIL_FRONT_KEYWORD", ZFAIL_FRONT_KEYWORD_NODE_TYPE_INDEX, representation: "ZFailFront");
    public const int ZFAIL_BACK_KEYWORD_NODE_TYPE_INDEX = 1096;
    public static readonly TokenNodeType ZFAIL_BACK_KEYWORD = new KeywordTokenNodeType("ZFAIL_BACK_KEYWORD", ZFAIL_BACK_KEYWORD_NODE_TYPE_INDEX, representation: "ZFailBack");

    //ComparisonFunctionKeywords
    public const int GREATER_KEYWORD_NODE_TYPE_INDEX = 1097;
    public static readonly TokenNodeType GREATER_KEYWORD = new KeywordTokenNodeType("GREATER_KEYWORD", GREATER_KEYWORD_NODE_TYPE_INDEX, representation: "Greater");
    public const int GEQUAL_KEYWORD_NODE_TYPE_INDEX = 1098;
    public static readonly TokenNodeType GEQUAL_KEYWORD = new KeywordTokenNodeType("GEQUAL_KEYWORD", GEQUAL_KEYWORD_NODE_TYPE_INDEX, representation: "GEqual");
    public const int LESS_KEYWORD_NODE_TYPE_INDEX = 1099;
    public static readonly TokenNodeType LESS_KEYWORD = new KeywordTokenNodeType("LESS_KEYWORD", LESS_KEYWORD_NODE_TYPE_INDEX, representation: "Less");
    public const int LEQUAL_KEYWORD_NODE_TYPE_INDEX = 1100;
    public static readonly TokenNodeType LEQUAL_KEYWORD = new KeywordTokenNodeType("LEQUAL_KEYWORD", LEQUAL_KEYWORD_NODE_TYPE_INDEX, representation: "LEqual");
    public const int EQUAL_KEYWORD_NODE_TYPE_INDEX = 1101;
    public static readonly TokenNodeType EQUAL_KEYWORD = new KeywordTokenNodeType("EQUAL_KEYWORD", EQUAL_KEYWORD_NODE_TYPE_INDEX, representation: "Equal");
    public const int NOT_EQUAL_KEYWORD_NODE_TYPE_INDEX = 1102;
    public static readonly TokenNodeType NOT_EQUAL_KEYWORD = new KeywordTokenNodeType("NOT_EQUAL_KEYWORD", NOT_EQUAL_KEYWORD_NODE_TYPE_INDEX, representation: "NotEqual");
    public const int ALWAYS_KEYWORD_NODE_TYPE_INDEX = 1103;
    public static readonly TokenNodeType ALWAYS_KEYWORD = new KeywordTokenNodeType("ALWAYS_KEYWORD", ALWAYS_KEYWORD_NODE_TYPE_INDEX, representation: "Always");
    public const int NEVER_KEYWORD_NODE_TYPE_INDEX = 1104;
    public static readonly TokenNodeType NEVER_KEYWORD = new KeywordTokenNodeType("NEVER_KEYWORD", NEVER_KEYWORD_NODE_TYPE_INDEX, representation: "Never");

    //StencilOperationKeywords
    public const int KEEP_KEYWORD_NODE_TYPE_INDEX = 1105;
    public static readonly TokenNodeType KEEP_KEYWORD = new KeywordTokenNodeType("KEEP_KEYWORD", KEEP_KEYWORD_NODE_TYPE_INDEX, representation: "Keep");
    public const int ZERO_KEYWORD_NODE_TYPE_INDEX = 1106;
    public static readonly TokenNodeType ZERO_KEYWORD = new KeywordTokenNodeType("ZERO_KEYWORD", ZERO_KEYWORD_NODE_TYPE_INDEX, representation: "Zero");
    public const int REPLACE_KEYWORD_NODE_TYPE_INDEX = 1107;
    public static readonly TokenNodeType REPLACE_KEYWORD = new KeywordTokenNodeType("REPLACE_KEYWORD", REPLACE_KEYWORD_NODE_TYPE_INDEX, representation: "Replace");
    public const int INCR_SAT_KEYWORD_NODE_TYPE_INDEX = 1108;
    public static readonly TokenNodeType INCR_SAT_KEYWORD = new KeywordTokenNodeType("INCR_SAT_KEYWORD", INCR_SAT_KEYWORD_NODE_TYPE_INDEX, representation: "IncrSat");
    public const int DECR_SAT_KEYWORD_NODE_TYPE_INDEX = 1109;
    public static readonly TokenNodeType DECR_SAT_KEYWORD = new KeywordTokenNodeType("DECR_SAT_KEYWORD", DECR_SAT_KEYWORD_NODE_TYPE_INDEX, representation: "DecrSat");
    public const int INVERT_KEYWORD_NODE_TYPE_INDEX = 1110;
    public static readonly TokenNodeType INVERT_KEYWORD = new KeywordTokenNodeType("INVERT_KEYWORD", INVERT_KEYWORD_NODE_TYPE_INDEX, representation: "Invert");
    public const int INCR_WRAP_KEYWORD_NODE_TYPE_INDEX = 1111;
    public static readonly TokenNodeType INCR_WRAP_KEYWORD = new KeywordTokenNodeType("INCR_WRAP_KEYWORD", INCR_WRAP_KEYWORD_NODE_TYPE_INDEX, representation: "IncrWrap");
    public const int DECR_WRAP_KEYWORD_NODE_TYPE_INDEX = 1112;
    public static readonly TokenNodeType DECR_WRAP_KEYWORD = new KeywordTokenNodeType("DECR_WRAP_KEYWORD", DECR_WRAP_KEYWORD_NODE_TYPE_INDEX, representation: "DecrWrap");

    //Keywords
    public const int TRUE_KEYWORD_NODE_TYPE_INDEX = 1113;
    public static readonly TokenNodeType TRUE_KEYWORD = new KeywordTokenNodeType("TRUE_KEYWORD", TRUE_KEYWORD_NODE_TYPE_INDEX, representation: "True");
    public const int ON_KEYWORD_NODE_TYPE_INDEX = 1114;
    public static readonly TokenNodeType ON_KEYWORD = new KeywordTokenNodeType("ON_KEYWORD", ON_KEYWORD_NODE_TYPE_INDEX, representation: "On");
    public const int OFF_KEYWORD_NODE_TYPE_INDEX = 1115;
    public static readonly TokenNodeType OFF_KEYWORD = new KeywordTokenNodeType("OFF_KEYWORD", OFF_KEYWORD_NODE_TYPE_INDEX, representation: "Off");
    public const int BACK_KEYWORD_NODE_TYPE_INDEX = 1116;
    public static readonly TokenNodeType BACK_KEYWORD = new KeywordTokenNodeType("BACK_KEYWORD", BACK_KEYWORD_NODE_TYPE_INDEX, representation: "Back");
    public const int FRONT_KEYWORD_NODE_TYPE_INDEX = 1117;
    public static readonly TokenNodeType FRONT_KEYWORD = new KeywordTokenNodeType("FRONT_KEYWORD", FRONT_KEYWORD_NODE_TYPE_INDEX, representation: "Front");
    public const int MATRIX_KEYWORD_NODE_TYPE_INDEX = 1118;
    public static readonly TokenNodeType MATRIX_KEYWORD = new KeywordTokenNodeType("MATRIX_KEYWORD", MATRIX_KEYWORD_NODE_TYPE_INDEX, representation: "Matrix");
    public const int ANY_KEYWORD_NODE_TYPE_INDEX = 1119;
    public static readonly TokenNodeType ANY_KEYWORD = new KeywordTokenNodeType("ANY_KEYWORD", ANY_KEYWORD_NODE_TYPE_INDEX, representation: "Any");
    public const int LIGHTMAP_MODE_KEYWORD_NODE_TYPE_INDEX = 1120;
    public static readonly TokenNodeType LIGHTMAP_MODE_KEYWORD = new KeywordTokenNodeType("LIGHTMAP_MODE_KEYWORD", LIGHTMAP_MODE_KEYWORD_NODE_TYPE_INDEX, representation: "LightmapMode");
    public const int TEXGEN_KEYWORD_NODE_TYPE_INDEX = 1121;
    public static readonly TokenNodeType TEXGEN_KEYWORD = new KeywordTokenNodeType("TEXGEN_KEYWORD", TEXGEN_KEYWORD_NODE_TYPE_INDEX, representation: "TexGen");

    //TexGenModeKeywords
    public const int CUBE_REFLECT_KEYWORD_NODE_TYPE_INDEX = 1122;
    public static readonly TokenNodeType CUBE_REFLECT_KEYWORD = new KeywordTokenNodeType("CUBE_REFLECT_KEYWORD", CUBE_REFLECT_KEYWORD_NODE_TYPE_INDEX, representation: "CubeReflect");
    public const int CUBE_NORMAL_KEYWORD_NODE_TYPE_INDEX = 1123;
    public static readonly TokenNodeType CUBE_NORMAL_KEYWORD = new KeywordTokenNodeType("CUBE_NORMAL_KEYWORD", CUBE_NORMAL_KEYWORD_NODE_TYPE_INDEX, representation: "CubeNormal");
    public const int OBJECT_LINEAR_KEYWORD_NODE_TYPE_INDEX = 1124;
    public static readonly TokenNodeType OBJECT_LINEAR_KEYWORD = new KeywordTokenNodeType("OBJECT_LINEAR_KEYWORD", OBJECT_LINEAR_KEYWORD_NODE_TYPE_INDEX, representation: "ObjectLinear");
    public const int EYE_LINEAR_KEYWORD_NODE_TYPE_INDEX = 1125;
    public static readonly TokenNodeType EYE_LINEAR_KEYWORD = new KeywordTokenNodeType("EYE_LINEAR_KEYWORD", EYE_LINEAR_KEYWORD_NODE_TYPE_INDEX, representation: "EyeLinear");
    public const int SPHERE_MAP_KEYWORD_NODE_TYPE_INDEX = 1126;
    public static readonly TokenNodeType SPHERE_MAP_KEYWORD = new KeywordTokenNodeType("SPHERE_MAP_KEYWORD", SPHERE_MAP_KEYWORD_NODE_TYPE_INDEX, representation: "SphereMap");

    private const int LAST_GENERATED_TOKEN_TYPE_INDEX = 1127;  }
}
