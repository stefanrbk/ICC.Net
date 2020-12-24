namespace ICC.Net
{
    public enum DMMediaType
    {
        Standard     = 0x0001, // Standard paper
        Transparancy = 0x0002, // Transparency
        Glossy       = 0x0003, // Glossy paper
        User         = 0x0100, // Device-specific type media are >= 256
    }
}
