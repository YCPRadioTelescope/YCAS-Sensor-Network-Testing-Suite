using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    /// <summary>
    /// This contains all of the sensor statuses for the Sensor Network.
    /// </summary>
    public class SensorStatuses
    {
        /// <summary>
        /// The error state of the azimuth absolute encoder.
        /// </summary>
        public SensorStatus AzimuthAbsoluteEncoderStatus { get; set; }

        /// <summary>
        /// The error state of the elevation absolute encoder.
        /// </summary>
        public SensorStatus ElevationAbsoluteEncoderStatus { get; set; }

        /// <summary>
        /// The error state of the azimuth temperature sensor.
        /// </summary>
        public SensorStatus AzimuthTemperature1Status { get; set; }

        /// <summary>
        /// The error state of the redundant azimuth temperature sensor.
        /// </summary>
        public SensorStatus AzimuthTemperature2Status { get; set; }

        /// <summary>
        /// The error state of the elevation temperature sensor.
        /// </summary>
        public SensorStatus ElevationTemperature1Status { get; set; }

        /// <summary>
        /// The error state of the redundant elevation temperature sensor.
        /// </summary>
        public SensorStatus ElevationTemperature2Status { get; set; }

        /// <summary>
        /// The error state of the azimuth accelerometer status.
        /// </summary>
        public SensorStatus AzimuthAccelerometerStatus { get; set; }

        /// <summary>
        /// The error state of the elevation accelerometer status.
        /// </summary>
        public SensorStatus ElevationAccelerometerStatus { get; set; }

        /// <summary>
        /// The error state of the counterbalance accelerometer status.
        /// </summary>
        public SensorStatus CounterbalanceAccelerometerStatus { get; set; }
    }
}
