using System;

namespace ICC.Net
{
    public abstract class OldTagSignatures : TagSignatures
    {
        public const TagSignature CrdInfoTag = TagSignature.CrdInfoTag;
        public const TagSignature DataTag = TagSignature.DataTag;
        public const TagSignature DateTimeTag = TagSignature.DateTimeTag;
        public const TagSignature DeviceSettingsTag = TagSignature.DeviceSettingsTag;
        [Obsolete("NamedColorTag is obsolete, use NamedColor2Tag instead")]
        public const TagSignature NamedColorTag = TagSignature.NamedColorTag;
        public const TagSignature Ps2CRD0Tag = TagSignature.Ps2Crd0Tag;
        public const TagSignature Ps2CRD1Tag = TagSignature.Ps2Crd1Tag;
        public const TagSignature Ps2CRD2Tag = TagSignature.Ps2Crd2Tag;
        public const TagSignature Ps2CRD3Tag = TagSignature.Ps2Crd3Tag;
        public const TagSignature Ps2CSATag = TagSignature.Ps2CsaTag;
        public const TagSignature ScreeningDescTag = TagSignature.ScreeningDescTag;
        public const TagSignature ScreeningTag = TagSignature.ScreeningTag;
        public const TagSignature UcrBgTag = TagSignature.UcrbgTag;
    }
}
