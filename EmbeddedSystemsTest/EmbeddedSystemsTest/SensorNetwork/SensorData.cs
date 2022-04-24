using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    public struct AdxlData
    {
        public short xAxis { get; set; }
        public short yAxis { get; set; }
        public short zAxis { get; set; }
    }

    public struct SensorData
    {
        public double elTemp1 { get; set; }
        public double elTemp2 { get; set; }
        public double azTemp1 { get; set; }
        public double azTemp2 { get; set; }
        public float ambTemp { get; set; }
        public float ambHumidity { get; set; }
        public AdxlData elAdxlData { get; set; }
        public AdxlData azAdxlData { get; set; }
        public AdxlData cbAdxlData { get; set; }
        public Orientation orientation { get; set; }
        public SensorStatus elTemp1Status { get; set; }
        public SensorStatus elTemp2Status { get; set; }
        public SensorStatus azTemp1Status { get; set; }
        public SensorStatus azTemp2Status { get; set; }
        public SensorStatus ambTempHumidityStatus { get; set; }
        public SensorStatus elAdxlStatus { get; set; }
        public SensorStatus azAdxlStatus { get; set; }
        public SensorStatus cbAdxlStatus { get; set; }
        public SensorStatus elEncoderStatus { get; set; }   // Embeded system does not know the status of the Elvation Encoder
        public SensorStatus azEncoderStatus { get; set; }   
        public AdxlSelfTestState[] adxlSelfTestState { get; set; }
        public AdxlError_Codes[] adxlErrors { get; set; }
        public AzEncoderError_Codes azEncderError { get; set; }
        public TemperatureError_Codes[] temperatureErrors { get; set; }
        public AmbientError_Code ambientTempHumidityError { get; set; }
    }
    /// <summary>Names of the temperature sensors</summary>
    public enum TemperatureSensors
    {
        /// <summary>First temperature sensor mounted on the elevation motor</summary>
        ELEVATION1,
        /// <summary>Second temperature sensor mounted on the elevation motor</summary>
        ELEVATION2,
        /// <summary>First temperature sensor mounted on the azimuth motor</summary>
        AZIMUTH1,
        /// <summary>Second temperature sensor mounted on the azimuth motor</summary>
        AZIMUTH2
    }
    /// <summary>Names of the ADXL345 sensors</summary>
    public enum AdxlSensors
    {
        /// <summary>ADXL345 sensor mounted on the elevation motor</summary>
        ELEVATION,
        /// <summary>ADXL345 sensor mounted on the azimuth motor</summary>
        AZIMUTH,
        /// <summary>ADXL345 sensor mounted on the counterbalance</summary>
        COUNTERBALANCE
    }
    /// <summary>Error codes for the two-ring encoder on the azimuth ring</summary>
    public enum AzEncoderError_Codes
    {
        /// <summary>Initial State. No errors present</summary>
        NO_ERROR,
        /// <summary>Valid flag returned false</summary>
        BAD_DATA,
        /// <summary>Sync flag returned false</summary>
        STALE_DATA
    }
    /// <summary>Error codes for the DS18B20 temperature sensors</summary>
    public enum TemperatureError_Codes
    {
        /// <summary>Initial State. No errors present</summary>
        NO_ERROR,
        /// <summary>No sensor data was found</summary>
        NO_DATA,
        /// <summary>Cyclic redundancy check was invalid</summary>
        CRC_INVALID
    }
    /// <summary>Error codes for the DHT22 temperature sensor</summary>
    public enum AmbientError_Code
    {
        /// <summary>Initial State. No errors present</summary>
        NO_ERROR,
        /// <summary>No sensor data was found</summary>
        NO_DATA,
        /// <summary>Readings are out of range</summary>
        OUT_OF_RANGE
    }
    /// <summary>Error codes for the ADXL345 accelermeter sensors</summary>
    public enum AdxlError_Codes
    {
        /// <summary>Initial State. No errors present</summary>
        NO_ERROR,
        /// <summary>Sensor stopped sampling</summary>
        NO_SAMPLES,
        /// <summary>Waterfall interupt was missed</summary>
        WATERFALL_MISSED
    }
    /// <summary>ADXL345 self-test status</summary>
    public enum AdxlSelfTestState
    {
        /// <summary>Self-test failed</summary>
        FAILED,
        /// <summary>Self-test passed</summary>
        PASSED
    }
    /// <summary>Sensor statuses</summary>
    public enum SensorStatus
    {
        /// <summary>Sensor is in an error state</summary>
        ERROR,
        /// <summary>No error detected</summary>
        OKAY
    }
}
