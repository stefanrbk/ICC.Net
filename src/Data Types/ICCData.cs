using System;
using System.Collections.Immutable;
using System.IO;

namespace ICC.Net
{
    public record ICCData(uint Flags, ImmutableArray<byte> Data)
    {
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write(Data.AsSpan());
        }

        public static ICCData Read(BeBinaryReader reader, int length)
        {
            var flags = reader.ReadUInt32();
            var data = new byte[length];
            reader.Read(data.AsSpan());

            return new ICCData(flags, data.ToImmutableArray());
        }
    }
}
