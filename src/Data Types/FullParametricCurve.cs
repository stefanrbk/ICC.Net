using System;
using System.IO;

namespace ICC.Net
{
    public record FullParametricCurve(ushort FuncType, Fix16 Gamma, Fix16 A, Fix16 B, Fix16 C, Fix16 D, Fix16 E, Fix16 F)
    {
        private ushort _pad { get; init; }
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(FuncType);
            writer.Write(_pad);
            writer.Write(Gamma);
            writer.Write(A);
            writer.Write(B);
            writer.Write(C);
            writer.Write(D);
            writer.Write(E);
            writer.Write(F);
        }

        public static FullParametricCurve Read(BeBinaryReader reader)
        {
            var funcType = reader.ReadUInt16();
            var pad = reader.ReadUInt16();
            var gamma = reader.ReadFix16();
            var a = reader.ReadFix16();
            var b = reader.ReadFix16();
            var c = reader.ReadFix16();
            var d = reader.ReadFix16();
            var e = reader.ReadFix16();
            var f = reader.ReadFix16();

            return new FullParametricCurve(funcType, gamma, a, b, c, d, e, f) { _pad = pad };
        }
    }
}
