using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;

namespace ICC.Net
{
    public class TagList
    {
        public uint Count => (uint)Tags.Count;
        public ImmutableList<Tag> Tags { get; }

        public TagList(ImmutableList<Tag> tags) =>
            Tags = tags;

        public TagList(List<Tag> tags) =>
            Tags = tags.ToImmutableList<Tag>();

        public void Write(BeBinaryWriter writer)
        {
            writer.Write(Count);

            foreach (var i in Tags)
                i.Write(writer);
        }

        public static TagList Read(BeBinaryReader reader)
        {
            var count = reader.ReadUInt32();
            var list = new List<Tag>();
            for (var i = 0; i < count; i++)
                list.Add(Tag.Read(reader));

            return new TagList(list);
        }
    }
}
