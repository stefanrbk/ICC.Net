namespace ICC.Net
{
    public enum ColorimetricIntentImageStateSignature
    {
        SceneColorimetryEstimates             = 0x73636F65, // 'scoe'
        SceneAppearanceEstimates              = 0x73617065, // 'sape'
        FocalPlaneColorimetryEstimates        = 0x66706365, // 'fpce'
        ReflectionHardcopyOriginalColorimetry = 0x72686F63, // 'rhoc'
        ReflectionPrintOutputColorimetry      = 0x72706F63, // 'rpoc'
    }
}
