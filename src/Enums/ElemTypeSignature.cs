namespace ICC.Net
{
    public enum ElemTypeSignature : uint
    {
        CurveSet = 0x63767374, // 'cvst'
        Matrix   = 0x6D617466, // 'matf'
        CLut     = 0x636C7574, // 'clut'
        BAcs     = 0x62414353, // 'bACS'
        EAcs     = 0x65414353, // 'eACS'
    }
}
