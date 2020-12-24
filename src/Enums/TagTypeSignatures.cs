namespace ICC.Net
{
    public abstract class TagTypeSignatures
    {
        public const TagTypeSignature ChromaticityType             = TagTypeSignature.ChromaticityType;
        public const TagTypeSignature ColorantOrderType            = TagTypeSignature.ColorantOrderType;
        public const TagTypeSignature ColorantTableType            = TagTypeSignature.ColorantTableType;
        public const TagTypeSignature CurveType                    = TagTypeSignature.CurveType;
        public const TagTypeSignature DataType                     = TagTypeSignature.DataType;
        public const TagTypeSignature DictType                     = TagTypeSignature.DictType;
        public const TagTypeSignature DateTimeType                 = TagTypeSignature.DateTimeType;
        public const TagTypeSignature Lut16Type                    = TagTypeSignature.Lut16Type;
        public const TagTypeSignature Lut8Type                     = TagTypeSignature.Lut8Type;
        public const TagTypeSignature LutAtoBType                  = TagTypeSignature.LutAtoBType;
        public const TagTypeSignature LutBtoAType                  = TagTypeSignature.LutBtoAType;
        public const TagTypeSignature MeasurementType              = TagTypeSignature.MeasurementType;
        public const TagTypeSignature MultiLocalizedUnicodeType    = TagTypeSignature.MultiLocalizedUnicodeType;
        public const TagTypeSignature MultiProcessElementType      = TagTypeSignature.MultiProcessElementType;
        public const TagTypeSignature NamedColor2Type              = TagTypeSignature.NamedColor2Type;
        public const TagTypeSignature ParametricCurveType          = TagTypeSignature.ParametricCurveType;
        public const TagTypeSignature ProfileSequenceDescType      = TagTypeSignature.ProfileSequenceDescType;
        public const TagTypeSignature ProfileSequceIdType          = TagTypeSignature.ProfileSequenceIdType;
        public const TagTypeSignature ResponseCurveSet16Type       = TagTypeSignature.ResponseCurveSet16Type;
        public const TagTypeSignature Fix16ArrayType               = TagTypeSignature.Fix16ArrayType;
        public const TagTypeSignature SignatureType                = TagTypeSignature.SignatureType;
        public const TagTypeSignature TextType                     = TagTypeSignature.TextType;
        public const TagTypeSignature U16Fixed16ArrayType          = TagTypeSignature.U16Fixed16ArrayType;
        public const TagTypeSignature UInt16ArrayType              = TagTypeSignature.UInt16ArrayType;
        public const TagTypeSignature UInt32ArrayType              = TagTypeSignature.UInt32ArrayType;
        public const TagTypeSignature UInt64ArrayType              = TagTypeSignature.UInt64ArrayType;
        public const TagTypeSignature UInt8ArrayType               = TagTypeSignature.UInt8ArrayType;
        public const TagTypeSignature ViewingConditionsType        = TagTypeSignature.ViewingConditionsType;
        public const TagTypeSignature XYZType                      = TagTypeSignature.XYZType;
        public const TagTypeSignature XYZArrayType                 = TagTypeSignature.XYZType;

        public static string GetName(TagTypeSignature sig) =>
            sig switch
            {
                TagTypeSignature.ChromaticityType => "chromaticityType",
                TagTypeSignature.ColorantOrderType => "colorantOrderType",
                TagTypeSignature.ColorantTableType => "colorantTableType",
                TagTypeSignature.CrdInfoType => "crdInfoType",
                TagTypeSignature.CurveType => "curveType",
                TagTypeSignature.DataType => "dataType",
                TagTypeSignature.DateTimeType => "dateTimeType",
                TagTypeSignature.DeviceSettingsType => "deviceSettingsType",
                TagTypeSignature.DictType => "dictType",
                TagTypeSignature.Lut16Type => "lut16Type",
                TagTypeSignature.Lut8Type => "lut8Type",
                TagTypeSignature.LutAtoBType => "lutAtoBType",
                TagTypeSignature.LutBtoAType => "lutBtoAType",
                TagTypeSignature.MeasurementType => "measurementType",
                TagTypeSignature.MultiLocalizedUnicodeType => "multiLocalizedUnicodeType",
                TagTypeSignature.MultiProcessElementType => "multiProcessElementType",
                TagTypeSignature.NamedColor2Type => "namedColor2Type",
                TagTypeSignature.ParametricCurveType => "parametricCurveType",
                TagTypeSignature.ProfileSequenceDescType => "profileSequenceDescType",
                TagTypeSignature.ProfileSequenceIdType => "profileSequenceIdentifierType",
                TagTypeSignature.ResponseCurveSet16Type => "responseCurveSet16Type",
                TagTypeSignature.Fix16ArrayType => "s15Fixed16 ArrayType",
                TagTypeSignature.ScreeningType => "screeningType",
                TagTypeSignature.SignatureType => "signatureType",
                TagTypeSignature.TextType => "textType",
                TagTypeSignature.TextDescriptionType => "textDescriptionType",
                TagTypeSignature.U16Fixed16ArrayType => "u16Fixed16 Type",
                TagTypeSignature.UcrBgType => "ucrBgType",
                TagTypeSignature.UInt16ArrayType => "uInt16 Type",
                TagTypeSignature.UInt32ArrayType => "uInt32 Type",
                TagTypeSignature.UInt64ArrayType => "uInt64 Type",
                TagTypeSignature.UInt8ArrayType => "uInt8 Type",
                TagTypeSignature.ViewingConditionsType => "viewingConditionsType",
                TagTypeSignature.XYZType => "XYZ Type",
                _ => ""
            };
    }
}
