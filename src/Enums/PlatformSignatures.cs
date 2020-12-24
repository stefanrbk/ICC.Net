namespace ICC.Net
{
    public abstract class PlatformSignatures
    {
        public const PlatformSignature UnknownPlatform = PlatformSignature.UnknownPlatform;
        public const PlatformSignature Macintosh = PlatformSignature.Macintosh;
        public const PlatformSignature Microsoft = PlatformSignature.Microsoft;
        public const PlatformSignature Solaris = PlatformSignature.Solaris;
        public const PlatformSignature SGI = PlatformSignature.SGI;
        public const PlatformSignature Taligent = PlatformSignature.Taligent;

        public static string GetName(PlatformSignature sig) =>
            sig switch
            {
                PlatformSignature.UnknownPlatform => "Unknown",
                PlatformSignature.Macintosh => "Macintosh",
                PlatformSignature.Microsoft => "Microsoft",
                PlatformSignature.Solaris => "Solaris",
                PlatformSignature.SGI => "SGI",
                PlatformSignature.Taligent => "Taligent",
                _ => "",
            };
    }
}
