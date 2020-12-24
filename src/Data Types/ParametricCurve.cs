using System;
using System.Collections.Immutable;
using System.IO;

namespace ICC.Net
{
    public record ParametricCurve(ushort FuncType, Fix16 Gamma, ImmutableArray<Fix16> Values)
    {
        private ushort _pad { get; init; }
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(FuncType);
            writer.Write(_pad);
            writer.Write(Gamma);

            foreach (var v in Values)
                writer.Write(v);
        }

        public static ParametricCurve Read(BeBinaryReader reader, int count)
        {
            var funcType = reader.ReadUInt16();
            var pad = reader.ReadUInt16();
            var gamma = reader.ReadFix16();
            var values = new Fix16[count];
            for (var i = 0; i < count; i++)
                values[i] = reader.ReadFix16();

            return new ParametricCurve(funcType, gamma, values.ToImmutableArray()) { _pad = pad };
        }
    }
}
