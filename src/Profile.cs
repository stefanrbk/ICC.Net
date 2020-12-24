using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.Net
{
    public record Profile(ProfileHeader Header, TagList TagList, ImmutableArray<TagBase> TagData)
    {
        public static Profile Read(Stream stream) =>
            Read(new BeBinaryReader(stream));

        public static Profile Read(BeBinaryReader reader)
        {
            var header = ProfileHeader.Read(reader);
            var tagList = TagList.Read(reader);
            var tagData = new TagBase[tagList.Count];



            return new Profile(header, tagList, tagData.ToImmutableArray());
        }
    }
}
