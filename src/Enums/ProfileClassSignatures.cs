namespace ICC.Net
{
    public abstract class ProfileClassSignatures
    {
        public const ProfileClassSignature InputClass = ProfileClassSignature.InputClass;
        public const ProfileClassSignature DisplayClass = ProfileClassSignature.DisplayClass;
        public const ProfileClassSignature OutputClass = ProfileClassSignature.OutputClass;
        public const ProfileClassSignature LinkClass = ProfileClassSignature.LinkClass;
        public const ProfileClassSignature AbstractClass = ProfileClassSignature.AbstractClass;
        public const ProfileClassSignature ColorSpaceClass = ProfileClassSignature.ColorSpaceClass;
        public const ProfileClassSignature NamedColorClass = ProfileClassSignature.NamedColorClass;

        public static string GetName(ProfileClassSignature sig) =>
            sig switch
            {
                ProfileClassSignature.InputClass => "InputClass",
                ProfileClassSignature.DisplayClass => "DisplayClass",
                ProfileClassSignature.OutputClass => "OutputClass",
                ProfileClassSignature.LinkClass => "LinkClass",
                ProfileClassSignature.AbstractClass => "AbstractClass",
                ProfileClassSignature.ColorSpaceClass => "ColorSpaceClass",
                ProfileClassSignature.NamedColorClass => "NamedColorClass",
                _ => "",
            };
    }
}
