
using System.IO;

namespace ICC.Net
{
    public record Tag(TagSignature Signature, uint Offset, uint Size)
    {
        public void Write(BeBinaryWriter writer)
        {
            writer.Write((uint)Signature);
            writer.Write(Offset);
            writer.Write(Size);
        }
        public static Tag Read(BeBinaryReader reader) =>
            new Tag((TagSignature)reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
    }
}
