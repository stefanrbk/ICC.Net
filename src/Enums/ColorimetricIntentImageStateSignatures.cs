namespace ICC.Net
{
    public abstract class ColorimetricIntentImageStateSignatures
    {
        public const ColorimetricIntentImageStateSignature SceneColorimetryEstimates             = ColorimetricIntentImageStateSignature.SceneColorimetryEstimates;
        public const ColorimetricIntentImageStateSignature SceneAppearanceEstimates              = ColorimetricIntentImageStateSignature.SceneAppearanceEstimates;
        public const ColorimetricIntentImageStateSignature FocalPlaneColorimetryEstimates        = ColorimetricIntentImageStateSignature.FocalPlaneColorimetryEstimates;
        public const ColorimetricIntentImageStateSignature ReflectionHardcopyOriginalColorimetry = ColorimetricIntentImageStateSignature.ReflectionHardcopyOriginalColorimetry;
        public const ColorimetricIntentImageStateSignature ReflectionPrintOutputColorimetry      = ColorimetricIntentImageStateSignature.ReflectionPrintOutputColorimetry;

        public static string GetName(ColorimetricIntentImageStateSignature sig) =>
            sig switch
            {
                ColorimetricIntentImageStateSignature.SceneColorimetryEstimates => "SceneColorimetryEstimates",
                ColorimetricIntentImageStateSignature.SceneAppearanceEstimates => "SceneAppearanceEstimates",
                ColorimetricIntentImageStateSignature.FocalPlaneColorimetryEstimates => "FocalPlaneColorimetryEstimates",
                ColorimetricIntentImageStateSignature.ReflectionHardcopyOriginalColorimetry => "ReflectionHardcopyOriginalColorimetry",
                ColorimetricIntentImageStateSignature.ReflectionPrintOutputColorimetry => "ReflectionPrintOutputColorimetry",
                _ => "",
            };
    }
}
