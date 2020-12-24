using System.Collections.Immutable;
using System.IO;

namespace ICC.Net
{
    public record Curve(ImmutableArray<ushort> Data)
    {
        public uint Count => (uint)Data.Length;

        public void Write(BeBinaryWriter writer)
        {
            writer.Write(Count);
            foreach (var d in Data)
                writer.Write(d);
        }

        public static Curve Read(BeBinaryReader reader)
        {
            var count = reader.ReadUInt32();
            var data = new ushort[count];

            for (var i = 0; i < count; i++)
                data[i] = reader.ReadUInt16();

            return new Curve(data.ToImmutableArray());
        }
    }
}
