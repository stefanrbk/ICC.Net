using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.Net
{
    public enum MeasurementGeometry : uint
    {
        GeometryUnknown     = 0x00000000,   // Unknown geometry
        Geometry045or450    = 0x00000001,   // 0/45, 45/0
        Geometry0dord0      = 0x00000002,   // 0/d, d/0
    }
}
