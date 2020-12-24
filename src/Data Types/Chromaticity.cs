using System.IO;

namespace ICC.Net
{
    public record Chromaticity(uint X, uint Y)
    {
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
        }

        public static Chromaticity Read(BeBinaryReader reader)
        {
            var x = reader.ReadUInt32();
            var y = reader.ReadUInt32();

            return new Chromaticity(x, y);
        }
    }
}
