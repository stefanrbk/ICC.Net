namespace ICC.Net
{
    public enum MeasurementUnitSignature : uint
    {
        StatusA = 0x53746141, // 'StaA'
        StatusE = 0x53746145, // 'StaE'
        StatusI = 0x53746149, // 'StaI'
        StatusT = 0x53746154, // 'StaT'
        StatusM = 0x5374614D, // 'StaM'
        DN      = 0x444E2020, // 'DN  '
        DNP     = 0x444E2050, // 'DN P'
        DNN     = 0x444E4E20, // 'DNN '
        DNNP    = 0x444E4E50, // 'DNNP'
    }
}
