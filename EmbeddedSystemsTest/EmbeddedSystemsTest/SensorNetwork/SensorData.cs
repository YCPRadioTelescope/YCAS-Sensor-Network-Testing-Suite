using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    struct AdxlData
    {
        public short xAxis { get; set; }
        public short yAxis { get; set; }
        public short zAxis { get; set; }
    }

    struct SensorData
    {
        public double elTemp1 { get; set; }
        public double elTemp2 { get; set; }
        public double azTemp1 { get; set; }
        public double azTemp2 { get; set; }
        public AdxlData elAdxlData { get; set; }
        public AdxlData azAdxlData { get; set; }
        public AdxlData cbAdxlData { get; set; }
        public Orientation orientation { get; set; }
    }
}
