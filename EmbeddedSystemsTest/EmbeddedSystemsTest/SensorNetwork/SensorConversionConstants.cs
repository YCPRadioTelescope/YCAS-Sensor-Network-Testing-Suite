using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    class SensorConversionConstants
    {
        public const double AZ_ENCODER_SCALING = 2047;


        // This is the transmit ID we are using for successful data transfer with no errors
        public const int DataTransmitId = 129;
    }
}
