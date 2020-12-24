namespace ICC.Net
{
    public abstract class ReferenceMediumGamutSignatures
    {
        public const ReferenceMediumGamutSignature PerceptualReferenceMediumGamut = ReferenceMediumGamutSignature.PerceptualReferenceMediumGamut;

        public static string GetName(ReferenceMediumGamutSignature sig) =>
            sig switch
            {
                ReferenceMediumGamutSignature.PerceptualReferenceMediumGamut => "perceptualReferenceMediumGamut",
                _ => "",
            };
    }
}
