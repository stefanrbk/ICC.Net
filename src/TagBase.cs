using System.IO;

namespace ICC.Net
{
    public record TagBase(TagTypeSignature Signature)
    {
        public static TagBase Read(BeBinaryReader reader)
        {
            var sig = (TagTypeSignature)reader.ReadUInt32();
            _ = reader.ReadUInt32();
            return new TagBase(sig);
        }
        public virtual void Write(BeBinaryWriter writer)
        {
            writer.Write((uint)Signature);
            writer.Write((uint)0);
        }
    }
}
