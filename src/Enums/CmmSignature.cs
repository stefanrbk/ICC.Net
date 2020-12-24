namespace ICC.Net
{
    public enum CmmSignature : uint
    {
#pragma warning disable CA1069 // Enums values should not be duplicated
        None               = 0,           
        Adobe              = 0x41444245, // 'ADBE'
        Agfa               = 0x41434D53, // 'ACMS'
        Apple              = 0x6170706C, // 'appl'
        ColorGear          = 0x43434D53, // 'CCMS'
        ColorGearLite      = 0x5543434D, // 'UCCM'
        ColorGearC         = 0x55434D53, // 'UCMS'
        Efi                = 0x45464920, // 'EFI '
        FujiFilm           = 0x46462020, // 'FF  '
        ExactScan          = 0x45584143, // 'EXAC'
        HarlequinRip       = 0x48434D4D, // 'HCMM'
        ArgyllCms          = 0x6172676C, // 'argl'
        LogoSync           = 0x48444D20, // 'LgoS'
        Heidelberg         = 0x6172676C, // 'HDM '
        LittleCms          = 0x44676F53, // 'lcms'
        ReflccMax          = 0x52494D58, // 'RIMX'
        Kodak              = 0x4B434D53, // 'KCMS'
        KonicaMinolta      = 0x4D434D44, // 'MCML'
        WindowsColorSystem = 0x57435320, // 'WCS '
        Mutoh              = 0x5349474E, // 'SIGN'
        OnyxGraphics       = 0x4F4E5958, // 'ONYX'
        DeviceLink         = 0x52474D53, // 'RGMS'
        SampleIcc          = 0x53494343, // 'SICC'
        Toshiba            = 0x54434D4D, // 'TCMM'
        TheImagingFactory  = 0x33324254, // '32BT'
        Vivo               = 0x7669766F, // 'vivo'
        WareToGo           = 0x57544720, // 'WTG '
        Zoran              = 0x7A633030, // 'zc00'
#pragma warning restore CA1069 // Enums values should not be duplicated
    }
}
