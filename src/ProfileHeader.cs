using System.IO;
using System.Runtime.CompilerServices;

namespace ICC.Net
{
    public record ProfileHeader
    {
        public static ProfileHeader Read(Stream stream) =>
            Read(new BeBinaryReader(stream));

        public unsafe static ProfileHeader Read(BeBinaryReader reader)
        {
            var size = reader.ReadUInt32();
            var cmmid = (CmmSignature)reader.ReadUInt32();
            (var maj, var minBug) = (reader.ReadByte(), reader.ReadByte());
            _ = reader.ReadUInt16();
            var devClass = (ProfileClassSignature)reader.ReadUInt32();
            var colorSpace = (ColorSpaceSignature)reader.ReadUInt32();
            var pcs = (ColorSpaceSignature)reader.ReadUInt32();
            var date = ICCDateTime.Read(reader);
            var magic = reader.ReadUInt32();
            var platform = (PlatformSignature)reader.ReadUInt32();
            var flags = reader.ReadUInt32();
            var manuf = reader.ReadUInt32();
            var model = reader.ReadUInt32();
            var attr = (Attributes)reader.ReadUInt32();
            _ = reader.ReadUInt32();
            var rendInt = (RenderingIntent)reader.ReadUInt32();
            var illum = Xyz.Read(reader);
            var creator = reader.ReadUInt32();
            var profileId = default(ProfileID);
            fixed (byte* bytes = reader.ReadBytes(16))
                Unsafe.CopyBlock(profileId.Id8, bytes, 16);
            _ = reader.ReadBytes(28); // Reserved for future use


            return new ProfileHeader()
            {
                Size = size,
                CmmId = cmmid,
                Version = (maj, minBug),
                DeviceClass = devClass,
                ColorSpace = colorSpace,
                Pcs = pcs,
                Date = date,
                Magic = magic,
                Platform = platform,
                Flags = flags,
                Manufacturer = manuf,
                Model            = model,
                Attributes       = attr,
                RenderingIntent  = rendInt,
                Illuminant       = illum,
                CreatorSignature = creator,
                ProfileId        = profileId
            };
        }
        /// <summary>
        /// The total size of the profile in bytes.
        /// </summary>
        public uint Size;
        /// <summary>
        /// Identifies the preferred Color Management Module as registered by the ICC. Zero if no CMM is preferred.
        /// </summary>
        public CmmSignature CmmId;
        /// <summary>
        /// Profile version number.
        /// </summary>
        public (byte Major, byte MinorBugFix) Version;
        // 10..11 are reserved for future use.
        /// <summary>
        /// The profile or device class.
        /// </summary>
        public ProfileClassSignature DeviceClass;
        /// <summary>
        /// The type of color encoding.
        /// </summary>
        public ColorSpaceSignature ColorSpace;
        /// <summary>
        /// The type of connection color encoding.
        /// </summary>
        public ColorSpaceSignature Pcs;
        /// <summary>
        /// When the profile was created.
        /// </summary>
        public ICCDateTime Date = ICCDateTime.Zero;
        /// <summary>
        /// The file signature which must be 'acsp' (0x61637370).
        /// </summary>
        public uint Magic;
        /// <summary>
        /// Signature to indicate the primary platform/operating system framework for which the profile 
        /// was created. Zero indicates no primary platform.
        /// </summary>
        public PlatformSignature Platform;
        /// <summary>
        /// Flags for the CMM.
        /// </summary>
        /// <remarks>
        /// Bit 0 = Embedded Profile
        /// Bit 1 = Profile cannot be used independently from the embedded color data.
        /// </remarks>
        public uint Flags;
        /// <summary>
        /// The device manufacturer signature registered with ICC.
        /// </summary>
        public uint Manufacturer;
        /// <summary>
        /// The device model signature registered with ICC.
        /// </summary>
        public uint Model;
        /// <summary>
        /// Attributes unique to the particular device setup such as media type.
        /// </summary>
        public Attributes Attributes;
        // 60..63 are reserved for future use.
        /// <summary>
        /// The style of reproduction which should be used.
        /// </summary>
        public RenderingIntent RenderingIntent;
        /// <summary>
        /// The XYZ values of the illuminant of the Profile Connection Space. This must correspond to D50.
        /// </summary>
        public Xyz Illuminant = Xyz.Zero;
        /// <summary>
        /// The creator's signature registered with ICC.
        /// </summary>
        public uint CreatorSignature;

        public ProfileID ProfileId;
        
        // 84..127 reserved for future use.
    }
}
