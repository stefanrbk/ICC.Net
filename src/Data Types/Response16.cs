using System;
using System.IO;

namespace ICC.Net
{
    public record Response16(ushort Interval, Fix16 Measurement)
    {
        private ushort _reserved { get; init; }
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(Interval);
            writer.Write(_reserved);
            writer.Write(Measurement);
        }

        public static Response16 Read(BeBinaryReader reader)
        {
            var interval = reader.ReadUInt16();
            var reserved = reader.ReadUInt16();
            var measurement = reader.ReadFix16();

            return new Response16(interval, measurement) { _reserved = reserved };
        }
    }
}
