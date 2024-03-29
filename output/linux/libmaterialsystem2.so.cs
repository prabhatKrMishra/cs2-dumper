// Generated using https://github.com/a2x/cs2-dumper
// 2024-03-29 21:16:02.890657436 UTC

namespace CS2Dumper.Schemas {
    // Module: libmaterialsystem2.so
    // Classes count: 13
    // Enums count: 0
    public static class Libmaterialsystem2 {
        // Parent: None
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParam_t {
            public const nint m_name = 0x0; // CUtlString
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamInt_t {
            public const nint m_nValue = 0x8; // int32
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamFloat_t {
            public const nint m_flValue = 0x8; // float32
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamVector_t {
            public const nint m_value = 0x8; // Vector4D
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamTexture_t {
            public const nint m_pValue = 0x8; // CStrongHandle<InfoForResourceTypeCTextureBase>
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamString_t {
            public const nint m_value = 0x8; // CUtlString
        }
        // Parent: MaterialParam_t
        // Fields count: 1
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialParamBuffer_t {
            public const nint m_value = 0x8; // CUtlBinaryBlock
        }
        // Parent: None
        // Fields count: 14
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class MaterialResourceData_t {
            public const nint m_materialName = 0x0; // CUtlString
            public const nint m_shaderName = 0x8; // CUtlString
            public const nint m_intParams = 0x10; // CUtlVector<MaterialParamInt_t>
            public const nint m_floatParams = 0x28; // CUtlVector<MaterialParamFloat_t>
            public const nint m_vectorParams = 0x40; // CUtlVector<MaterialParamVector_t>
            public const nint m_textureParams = 0x58; // CUtlVector<MaterialParamTexture_t>
            public const nint m_dynamicParams = 0x70; // CUtlVector<MaterialParamBuffer_t>
            public const nint m_dynamicTextureParams = 0x88; // CUtlVector<MaterialParamBuffer_t>
            public const nint m_intAttributes = 0xA0; // CUtlVector<MaterialParamInt_t>
            public const nint m_floatAttributes = 0xB8; // CUtlVector<MaterialParamFloat_t>
            public const nint m_vectorAttributes = 0xD0; // CUtlVector<MaterialParamVector_t>
            public const nint m_textureAttributes = 0xE8; // CUtlVector<MaterialParamTexture_t>
            public const nint m_stringAttributes = 0x100; // CUtlVector<MaterialParamString_t>
            public const nint m_renderAttributesUsed = 0x118; // CUtlVector<CUtlString>
        }
        // Parent: None
        // Fields count: 15
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class PostProcessingTonemapParameters_t {
            public const nint m_flExposureBias = 0x0; // float32
            public const nint m_flShoulderStrength = 0x4; // float32
            public const nint m_flLinearStrength = 0x8; // float32
            public const nint m_flLinearAngle = 0xC; // float32
            public const nint m_flToeStrength = 0x10; // float32
            public const nint m_flToeNum = 0x14; // float32
            public const nint m_flToeDenom = 0x18; // float32
            public const nint m_flWhitePoint = 0x1C; // float32
            public const nint m_flLuminanceSource = 0x20; // float32
            public const nint m_flExposureBiasShadows = 0x24; // float32
            public const nint m_flExposureBiasHighlights = 0x28; // float32
            public const nint m_flMinShadowLum = 0x2C; // float32
            public const nint m_flMaxShadowLum = 0x30; // float32
            public const nint m_flMinHighlightLum = 0x34; // float32
            public const nint m_flMaxHighlightLum = 0x38; // float32
        }
        // Parent: None
        // Fields count: 10
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class PostProcessingBloomParameters_t {
            public const nint m_blendMode = 0x0; // BloomBlendMode_t
            public const nint m_flBloomStrength = 0x4; // float32
            public const nint m_flScreenBloomStrength = 0x8; // float32
            public const nint m_flBlurBloomStrength = 0xC; // float32
            public const nint m_flBloomThreshold = 0x10; // float32
            public const nint m_flBloomThresholdWidth = 0x14; // float32
            public const nint m_flSkyboxBloomStrength = 0x18; // float32
            public const nint m_flBloomStartValue = 0x1C; // float32
            public const nint m_flBlurWeight = 0x20; // float32[5]
            public const nint m_vBlurTint = 0x34; // Vector[5]
        }
        // Parent: None
        // Fields count: 6
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class PostProcessingVignetteParameters_t {
            public const nint m_flVignetteStrength = 0x0; // float32
            public const nint m_vCenter = 0x4; // Vector2D
            public const nint m_flRadius = 0xC; // float32
            public const nint m_flRoundness = 0x10; // float32
            public const nint m_flFeather = 0x14; // float32
            public const nint m_vColorTint = 0x18; // Vector
        }
        // Parent: None
        // Fields count: 5
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class PostProcessingLocalContrastParameters_t {
            public const nint m_flLocalContrastStrength = 0x0; // float32
            public const nint m_flLocalContrastEdgeStrength = 0x4; // float32
            public const nint m_flLocalContrastVignetteStart = 0x8; // float32
            public const nint m_flLocalContrastVignetteEnd = 0xC; // float32
            public const nint m_flLocalContrastVignetteBlur = 0x10; // float32
        }
        // Parent: None
        // Fields count: 11
        //
        // Metadata:
        // MGetKV3ClassDefaults
        public static class PostProcessingResource_t {
            public const nint m_bHasTonemapParams = 0x0; // bool
            public const nint m_toneMapParams = 0x4; // PostProcessingTonemapParameters_t
            public const nint m_bHasBloomParams = 0x40; // bool
            public const nint m_bloomParams = 0x44; // PostProcessingBloomParameters_t
            public const nint m_bHasVignetteParams = 0xB4; // bool
            public const nint m_vignetteParams = 0xB8; // PostProcessingVignetteParameters_t
            public const nint m_bHasLocalContrastParams = 0xDC; // bool
            public const nint m_localConstrastParams = 0xE0; // PostProcessingLocalContrastParameters_t
            public const nint m_nColorCorrectionVolumeDim = 0xF4; // int32
            public const nint m_colorCorrectionVolumeData = 0xF8; // CUtlBinaryBlock
            public const nint m_bHasColorCorrection = 0x110; // bool
        }
    }
}
