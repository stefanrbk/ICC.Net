namespace ICC.Net
{
    public enum DMHalftoneType
    {
        None           = 0x0001, // No dithering
        Coarse         = 0x0002, // Dither with a coarse brush
        Fine           = 0x0003, // Dither with a fine brush
        LineArt        = 0x0004, // LineArt dithering
        ErrorDiffusion = 0x0005, // Error Diffusion
        Grayscale      = 0x000A, // Device does gray scaling
        User           = 0x0100, // Device-specific halftones are >= 256
    }
}
