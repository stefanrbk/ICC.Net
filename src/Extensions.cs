using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ICC.Net
{
    public static class Extensions
    {
        public static void Write(this BeBinaryWriter writer, Fix16 value) =>
            writer.Write(Unsafe.As<Fix16, uint>(ref value));
        public static Fix16 ReadFix16(this BeBinaryReader reader)
        {
            var value = reader.ReadUInt32();
            return Unsafe.As<uint, Fix16>(ref value);
        }

        //public static void Write(this BeBinaryWriter writer, U16Fixed16 value) =>
        //    writer.Write(Unsafe.As<U16Fixed16, uint>(ref value));
        //public static U16Fixed16 ReadU16Fixed16(this BeBinaryReader reader)
        //{
        //    var value = reader.ReadUInt32();
        //    return Unsafe.As<uint, U16Fixed16>(ref value);
        //}
        //public static void Write(this BeBinaryWriter writer, U8Fixed8 value) =>
        //    writer.Write(Unsafe.As<U8Fixed8, ushort>(ref value));
        //public static U8Fixed8 ReadU8Fixed8(this BeBinaryReader reader)
        //{
        //    var value = reader.ReadUInt16();
        //    return Unsafe.As<ushort, U8Fixed8>(ref value);
        //}
    }
}
