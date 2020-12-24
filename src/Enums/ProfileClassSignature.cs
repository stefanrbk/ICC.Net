namespace ICC.Net
{
    public enum ProfileClassSignature : uint
    {
        InputClass      = 0x73636E72, // 'scnr'
        DisplayClass    = 0x6D6E7472, // 'mntr'
        OutputClass     = 0x70727472, // 'prtr'
        LinkClass       = 0x6C696E6B, // 'link'
        AbstractClass   = 0x61627374, // 'abst'
        ColorSpaceClass = 0x73706163, // 'spac'
        NamedColorClass = 0x6E6D636C, // 'nmcl'
    }
}
