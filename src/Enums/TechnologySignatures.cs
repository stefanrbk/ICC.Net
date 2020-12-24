namespace ICC.Net
{
    public static class TechnologySignatures
    {
        public const TechnologySignature DigitalCamera               = TechnologySignature.DigitalCamera;
        public const TechnologySignature FilmScanner                 = TechnologySignature.FilmScanner;                                         
        public const TechnologySignature ReflectiveScanner           = TechnologySignature.ReflectiveScanner;                                         
        public const TechnologySignature InkJetPrinter               = TechnologySignature.InkJetPrinter;                                         
        public const TechnologySignature ThermalWaxPrinter           = TechnologySignature.ThermalWaxPrinter;                                         
        public const TechnologySignature ElectrophotographicPrinter  = TechnologySignature.ElectrophotographicPrinter;
        public const TechnologySignature ElectrostaticPrinter        = TechnologySignature.ElectrostaticPrinter;                                         
        public const TechnologySignature DyeSublimationPrinter       = TechnologySignature.DyeSublimationPrinter;                                         
        public const TechnologySignature PhotographicPaperPrinter    = TechnologySignature.PhotographicPaperPrinter;                                         
        public const TechnologySignature FilmWriter                  = TechnologySignature.FilmWriter;                                         
        public const TechnologySignature VideoMonitor                = TechnologySignature.VideoMonitor;                                         
        public const TechnologySignature VideoCamera                 = TechnologySignature.VideoCamera;                                         
        public const TechnologySignature ProjectionTelevision        = TechnologySignature.ProjectionTelevision;                                         
        public const TechnologySignature CRTDisplay                  = TechnologySignature.CRTDisplay;                                         
        public const TechnologySignature PMDisplay                   = TechnologySignature.PMDisplay;                                         
        public const TechnologySignature AMDisplay                   = TechnologySignature.AMDisplay;                                         
        public const TechnologySignature PhotoCD                     = TechnologySignature.PhotoCD;                                         
        public const TechnologySignature PhotoImageSetter            = TechnologySignature.PhotoImageSetter;                                         
        public const TechnologySignature Gravure                     = TechnologySignature.Gravure;                                         
        public const TechnologySignature OffsetLithography           = TechnologySignature.OffsetLithography;                                         
        public const TechnologySignature Silkscreen                  = TechnologySignature.Silkscreen;                                         
        public const TechnologySignature Flexography                 = TechnologySignature.Flexography;                                         
        public const TechnologySignature MotionPictureFilmScanner    = TechnologySignature.MotionPictureFilmScanner;
        public const TechnologySignature MotionPictureFilmRecorder   = TechnologySignature.MotionPictureFilmRecorder;
        public const TechnologySignature DigitalMotionPictureCamera  = TechnologySignature.DigitalMotionPictureCamera;
        public const TechnologySignature DigitalCinemaProjector      = TechnologySignature.DigitalCinemaProjector;
        public static string GetName(TechnologySignature sig) =>
            sig switch
            {
                TechnologySignature.DigitalCamera => "DigitalCamera",
                TechnologySignature.FilmScanner => "FilmScanner",
                TechnologySignature.ReflectiveScanner => "ReflectiveScanner",
                TechnologySignature.InkJetPrinter => "InkJetPrinter",
                TechnologySignature.ThermalWaxPrinter => "ThermalWaxPrinter",
                TechnologySignature.ElectrophotographicPrinter => "ElectrophotographicPrinter",
                TechnologySignature.ElectrostaticPrinter => "ElectrostaticPrinter",
                TechnologySignature.DyeSublimationPrinter => "DyeSublimationPrinter",
                TechnologySignature.PhotographicPaperPrinter => "PhotographicPaperPrinter",
                TechnologySignature.FilmWriter => "FilmWriter",
                TechnologySignature.VideoMonitor => "VideoMonitor",
                TechnologySignature.VideoCamera => "VideoCamera",
                TechnologySignature.ProjectionTelevision => "ProjectionTelevision",
                TechnologySignature.CRTDisplay => "CRTDisplay",
                TechnologySignature.PMDisplay => "PMDisplay",
                TechnologySignature.AMDisplay => "AMDisplay",
                TechnologySignature.PhotoCD => "PhotoCD",
                TechnologySignature.PhotoImageSetter => "PhotoImageSetter",
                TechnologySignature.Gravure => "Gravure",
                TechnologySignature.OffsetLithography => "OffsetLithography",
                TechnologySignature.Silkscreen => "Silkscreen",
                TechnologySignature.Flexography => "Flexography",
                TechnologySignature.MotionPictureFilmScanner => "MotionPictureFilmScanner",
                TechnologySignature.MotionPictureFilmRecorder => "MotionPictureFilmRecorder",
                TechnologySignature.DigitalMotionPictureCamera => "DigitalMotionPictureCamera",
                TechnologySignature.DigitalCinemaProjector => "DigitalCinemaProjector",
                _ => ""
            };
    }
}
