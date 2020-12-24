namespace ICC.Net
{
    public enum PlatformSignature : uint
    {
        UnknownPlatform = 0,
        Macintosh       = 0x4150504C, // 'APPL'
        Microsoft       = 0x4D534654, // 'MSFT'
        Solaris         = 0x53554E57, // 'SUNW'
        SGI             = 0x53474920, // 'SGI '
        Taligent        = 0x54474E54, // 'TGNT'
    }
}
