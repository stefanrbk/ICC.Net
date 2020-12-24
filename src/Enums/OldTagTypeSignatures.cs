using System;

namespace ICC.Net
{
    public abstract class OldTagTypeSignatures : TagTypeSignatures
    {
        public const TagTypeSignature CrdInfoType                  = TagTypeSignature.CrdInfoType;
        public const TagTypeSignature DeviceSettingsType           = TagTypeSignature.DeviceSettingsType;
        [Obsolete("NamedColorType is obsolete, use NamedColor2Type instead.")]
        public const TagTypeSignature NamedColorType               = TagTypeSignature.NamedColorType;
        public const TagTypeSignature ScreeningType                = TagTypeSignature.ScreeningType;
        public const TagTypeSignature TextDescriptionType          = TagTypeSignature.TextDescriptionType;
        public const TagTypeSignature UcrBgType                    = TagTypeSignature.UcrBgType;
    }
}
