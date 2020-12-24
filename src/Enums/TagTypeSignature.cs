using System;

namespace ICC.Net
{
    public enum TagTypeSignature : uint
    {
        ChromaticityType               = 0x6368726D, // 'chrm'
        ColorantOrderType              = 0x636C726F, // 'clro'
        ColorantTableType              = 0x636C7274, // 'clrt'
        CrdInfoType                    = 0x63726469, // 'crdi'
        CurveType                      = 0x63757276, // 'curv'
        DataType                       = 0x64617461, // 'data'
        DictType                       = 0x64696374, // 'dict'
        DateTimeType                   = 0x6474696D, // 'dtim'
        DeviceSettingsType             = 0x64657673, // 'devs'
        Lut16Type                      = 0x6d667432, // 'mft2'
        Lut8Type                       = 0x6d667431, // 'mft1'
        LutAtoBType                    = 0x6d414220, // 'mAB '
        LutBtoAType                    = 0x6d424120, // 'mBA '
        MeasurementType                = 0x6D656173, // 'meas'
        MultiLocalizedUnicodeType      = 0x6D6C7563, // 'mluc'
        MultiProcessElementType        = 0x6D706574, // 'mpet'
        NamedColorType                 = 0x6E636f6C, // 'ncol'
        NamedColor2Type                = 0x6E636C32, // 'ncl2'
        ParametricCurveType            = 0x70617261, // 'para'
        ProfileSequenceDescType        = 0x70736571, // 'pseq'
        ProfileSequenceIdType          = 0x70736964, // 'psid'
        ResponseCurveSet16Type         = 0x72637332, // 'rcs2'
        Fix16ArrayType                 = 0x73663332, // 'sf32'
        ScreeningType                  = 0x7363726E, // 'scrn'
        SignatureType                  = 0x73696720, // 'sig '
        TextType                       = 0x74657874, // 'text'
        TextDescriptionType            = 0x64657363, // 'desc'
        U16Fixed16ArrayType            = 0x75663332, // 'uf32'
        UcrBgType                      = 0x62666420, // 'bfd '
        UInt16ArrayType                = 0x75693136, // 'ui16'
        UInt32ArrayType                = 0x75693332, // 'ui32'
        UInt64ArrayType                = 0x75693634, // 'ui64'
        UInt8ArrayType                 = 0x75693038, // 'ui08'
        ViewingConditionsType          = 0x76696577, // 'view'
        XYZType                        = 0x58595A20, // 'XYZ '
        Unknown                        = 0x3F3F3F3F, // '????'
    }
}
