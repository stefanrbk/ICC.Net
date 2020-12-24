using System;
using System.Collections.Immutable;
using System.IO;

namespace ICC.Net
{
    public record Xyz(Fix16 X, Fix16 Y, Fix16 Z)
    {
        public static Xyz Zero => new Xyz(Fix16.Zero, Fix16.Zero, Fix16.Zero);

        public static Xyz Read(BeBinaryReader reader)
        {
            var x = reader.ReadFix16();
            var y = reader.ReadFix16();
            var z = reader.ReadFix16();
            return new Xyz(x, y, z);
        }

        public void Write(BeBinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
        }
    }
}
