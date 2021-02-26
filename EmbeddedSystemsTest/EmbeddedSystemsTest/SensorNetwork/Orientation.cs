using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    public class Orientation
    {
        public Orientation(double azimuth, double elevation)
        {
            Azimuth = azimuth;
            Elevation = elevation;
        }

        public Orientation() : this(0, 0) { }
        
        public double Azimuth { get; set; }
        public double Elevation { get; set; }

        public override bool Equals(object obj)
        {
            Orientation other = obj as Orientation; //avoid double casting
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            // These are based off of 12 and 10 bit encoder precisions, respectively
            bool az_equal = Math.Abs(Azimuth - other.Azimuth) < (360.0 / 4096);
            bool el_equal = Math.Abs(Elevation - other.Elevation) < (360.0 / 1024);
            return az_equal && el_equal;
        }
    }
}
