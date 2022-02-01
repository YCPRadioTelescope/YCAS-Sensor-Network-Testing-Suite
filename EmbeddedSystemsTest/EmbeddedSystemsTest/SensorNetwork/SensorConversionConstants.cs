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

        /// <summary>
        /// This is the FIFO size used by the azimuth motor accelerometer
        /// </summary>
        public const int azAccelFIFOSize = 32;

        /// <summary>
        /// This is the FIFO size used by the elevation motor accelerometer
        /// </summary>
        public const int elAccelFIFOSize = 32;

        /// <summary>
        /// This is the FIFO size used by the counterbalance accelerometer
        /// </summary>
        public const int cbAccelFIFOSize = 32;
    }
}
