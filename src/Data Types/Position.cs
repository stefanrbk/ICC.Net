using System.IO;

namespace ICC.Net
{
    public record Position(uint Offset, uint Size)
    {
        public void Write(BeBinaryWriter writer)
        {
            writer.Write(Offset);
            writer.Write(Size);
        }

        public static Position Read(BeBinaryReader reader)
        {
            var offset = reader.ReadUInt32();
            var size = reader.ReadUInt32();

            return new Position(offset, size);
        }
    }
}
