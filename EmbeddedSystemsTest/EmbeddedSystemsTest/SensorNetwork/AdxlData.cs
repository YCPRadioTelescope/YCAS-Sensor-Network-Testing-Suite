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
}
