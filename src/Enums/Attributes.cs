using System;

namespace ICC.Net
{
    [Flags]
    public enum Attributes : uint
    {
#pragma warning disable CA1069 // Enum values should not be duplicated
        Reflective   = 0,
        Transparency = 1,

        Glossy       = 0,
        Matte        = 2,

        Positive     = 0,
        Negative     = 4,

        Color        = 0,
        BlackWhite   = 8,
#pragma warning restore CA1069 // Enum values should not be duplicated
    }
}
