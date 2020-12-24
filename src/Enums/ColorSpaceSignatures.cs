namespace ICC.Net
{
    public abstract class ColorSpaceSignatures
    {
        public const ColorSpaceSignature XyzData     = ColorSpaceSignature.XyzData;
        public const ColorSpaceSignature LabData     = ColorSpaceSignature.LabData;
        public const ColorSpaceSignature LuvData     = ColorSpaceSignature.LuvData;
        public const ColorSpaceSignature YcbcrData   = ColorSpaceSignature.YcbcrData;
        public const ColorSpaceSignature YxyData     = ColorSpaceSignature.YxyData;
        public const ColorSpaceSignature RgbData     = ColorSpaceSignature.RgbData;
        public const ColorSpaceSignature GrayData    = ColorSpaceSignature.GrayData;
        public const ColorSpaceSignature HsvData     = ColorSpaceSignature.HsvData;
        public const ColorSpaceSignature HlsData     = ColorSpaceSignature.HlsData;
        public const ColorSpaceSignature CmykData    = ColorSpaceSignature.CmykData;
        public const ColorSpaceSignature CmyData     = ColorSpaceSignature.CmyData;
        public const ColorSpaceSignature MCH2Data    = ColorSpaceSignature.MCH2Data;
        public const ColorSpaceSignature MCH3Data    = ColorSpaceSignature.MCH3Data;
        public const ColorSpaceSignature MCH4Data    = ColorSpaceSignature.MCH4Data;
        public const ColorSpaceSignature MCH5Data    = ColorSpaceSignature.MCH5Data;
        public const ColorSpaceSignature MCH6Data    = ColorSpaceSignature.MCH6Data;
        public const ColorSpaceSignature MCH7Data    = ColorSpaceSignature.MCH7Data;
        public const ColorSpaceSignature MCH8Data    = ColorSpaceSignature.MCH8Data;
        public const ColorSpaceSignature MCH9Data    = ColorSpaceSignature.MCH9Data;
        public const ColorSpaceSignature MCHAData    = ColorSpaceSignature.MCHAData;
        public const ColorSpaceSignature MCHBData    = ColorSpaceSignature.MCHBData;
        public const ColorSpaceSignature MCHCData    = ColorSpaceSignature.MCHCData;
        public const ColorSpaceSignature MCHDData    = ColorSpaceSignature.MCHDData;
        public const ColorSpaceSignature MCHEData    = ColorSpaceSignature.MCHEData;
        public const ColorSpaceSignature MCHFData    = ColorSpaceSignature.MCHFData;
        public const ColorSpaceSignature NamedData   = ColorSpaceSignature.NamedData;
        public const ColorSpaceSignature Color2Data  = ColorSpaceSignature.MCH2Data;
        public const ColorSpaceSignature Color3Data  = ColorSpaceSignature.MCH3Data;
        public const ColorSpaceSignature Color4Data  = ColorSpaceSignature.MCH4Data;
        public const ColorSpaceSignature Color5Data  = ColorSpaceSignature.MCH5Data;
        public const ColorSpaceSignature Color6Data  = ColorSpaceSignature.MCH6Data;
        public const ColorSpaceSignature Color7Data  = ColorSpaceSignature.MCH7Data;
        public const ColorSpaceSignature Color8Data  = ColorSpaceSignature.MCH8Data;
        public const ColorSpaceSignature Color9Data  = ColorSpaceSignature.MCH9Data;
        public const ColorSpaceSignature Color10Data = ColorSpaceSignature.MCHAData;
        public const ColorSpaceSignature Color11Data = ColorSpaceSignature.MCHBData;
        public const ColorSpaceSignature Color12Data = ColorSpaceSignature.MCHCData;
        public const ColorSpaceSignature Color13Data = ColorSpaceSignature.MCHDData;
        public const ColorSpaceSignature Color14Data = ColorSpaceSignature.MCHEData;
        public const ColorSpaceSignature Color15Data = ColorSpaceSignature.MCHFData;
        public static string GetName(ColorSpaceSignature sig) =>
            sig switch
            {
                ColorSpaceSignature.XyzData => "XYZData",
                ColorSpaceSignature.LabData => "LabData",
                ColorSpaceSignature.LuvData => "LuvData",
                ColorSpaceSignature.YcbcrData => "YCbCrData",
                ColorSpaceSignature.YxyData => "YxyData",
                ColorSpaceSignature.RgbData => "RgbData",
                ColorSpaceSignature.GrayData => "GrayData",
                ColorSpaceSignature.HsvData => "HsvData",
                ColorSpaceSignature.HlsData => "HlsData",
                ColorSpaceSignature.CmykData => "CmykData",
                ColorSpaceSignature.CmyData => "CmyData",
                ColorSpaceSignature.MCH1Data => "MCH1Data/1ColorData",
                ColorSpaceSignature.MCH2Data => "MCH2Data/2ColorData",
                ColorSpaceSignature.MCH3Data => "MCH3Data/3ColorData",
                ColorSpaceSignature.MCH4Data => "MCH4Data/4ColorData",
                ColorSpaceSignature.MCH5Data => "MCH5Data/5ColorData",
                ColorSpaceSignature.MCH6Data => "MCH6Data/6ColorData",
                ColorSpaceSignature.MCH7Data => "MCH7Data/7ColorData",
                ColorSpaceSignature.MCH8Data => "MCH8Data/8ColorData",
                ColorSpaceSignature.MCH9Data => "MCH9Data/9ColorData",
                ColorSpaceSignature.MCHAData => "MCHAData/10ColorData",
                ColorSpaceSignature.MCHBData => "MCHBData/11ColorData",
                ColorSpaceSignature.MCHCData => "MCHCData/12ColorData",
                ColorSpaceSignature.MCHDData => "MCHDData/13ColorData",
                ColorSpaceSignature.MCHEData => "MCHEData/14ColorData",
                ColorSpaceSignature.MCHFData => "MCHFData/15ColorData",
                ColorSpaceSignature.MCHGData => "MCHGData/16ColorData",
                ColorSpaceSignature.NamedData => "NamedData",
                ColorSpaceSignature.GamutData => "GamutData",
                _ => "",
            };
    }
}
