using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    class SensorDataParser
    {
        private AdxlData[] elAdxlData { get; set; }
        private AdxlData[] azAdxlData { get; set; }
        private AdxlData[] cbAdxlData { get; set; }
        private int[] elTemp1 { get; set; }
        private int[] elTemp2 { get; set; }
        private int[] azTemp1 { get; set; }
        private int[] azTemp2 { get; set; }
        private int[] elEncoder { get; set; }
        private int[] azEncoder { get; set; }
        private string transmitId { get; set; }

        public void ParseSensorData(byte[] bytes, int buffer)
        {
            // Get transmit ID and data sizes from byte array
            transmitId = bytes[0].ToString();
            UInt32 dataSize = (UInt32)(bytes[1] << 24 | bytes[2] << 16 | bytes[3] << 8 | bytes[4]);
            UInt16 elAdxlSize = (UInt16)(bytes[5] << 8 | bytes[6]);
            UInt16 azAdxlSize = (UInt16)(bytes[7] << 8 | bytes[8]);
            UInt16 cbAdxlSize = (UInt16)(bytes[9] << 8 | bytes[10]);
            UInt16 elTempSensorSize = (UInt16)(bytes[11] << 8 | bytes[12]);
            UInt16 azTempSensorSize = (UInt16)(bytes[13] << 8 | bytes[14]);
            UInt16 elEncoderSize = (UInt16)(bytes[15] << 8 | bytes[16]);
            UInt16 azEncoderSize = (UInt16)(bytes[17] << 8 | bytes[18]);

            if (buffer >= dataSize)
            {
                int k = 19;

                // Accelerometer 1 (elevation)
                if (elAdxlSize > 0)
                {
                    elAdxlData = new AdxlData[elAdxlSize];
                    for (int j = 0; j < elAdxlSize; j++)
                    {
                        elAdxlData[j] = new AdxlData()
                        {
                            xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                        };
                    }
                }

                // Accelerometer 2 (azimuth)
                if (azAdxlSize > 0)
                {
                    azAdxlData = new AdxlData[azAdxlSize];
                    for (int j = 0; j < azAdxlSize; j++)
                    {
                        azAdxlData[j] = new AdxlData()
                        {
                            xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                        };
                    }
                }

                // Accelerometer 3
                if (cbAdxlSize > 0)
                {
                    cbAdxlData = new AdxlData[cbAdxlSize];
                    for (int j = 0; j < cbAdxlSize; j++)
                    {
                        cbAdxlData[j] = new AdxlData()
                        {
                            xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                            zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                        };
                    }
                }

                // Elevation temperature 1
                if (elTempSensorSize > 0)
                {
                    elTemp1 = new int[elTempSensorSize];
                    for (int j = 0; j < elTempSensorSize; j++)
                    {
                        elTemp1[j] = (bytes[k++] << 8 | bytes[k++]);
                    }
                }

                // Azimuth temperature 1
                if (azTempSensorSize > 0)
                {
                    azTemp1 = new int[azTempSensorSize];
                    for (int j = 0; j < azTempSensorSize; j++)
                    {
                        azTemp1[j] = (bytes[k++] << 8 | bytes[k++]);
                    }
                }

                // Elevation encoder
                if (elEncoderSize > 0)
                {
                    elEncoder = new int[elEncoderSize];
                    for (int j = 0; j < elEncoderSize; j++)
                    {
                        elEncoder[j] = (bytes[k++] << 8 | bytes[k++]);
                    }
                }

                // Azimuth encoder
                if (azEncoderSize > 0)
                {
                    azEncoder = new int[azEncoderSize];
                    for (int j = 0; j < azEncoderSize; j++)
                    {
                        azEncoder[j] = (bytes[k++] << 8 | bytes[k++]);

                    }
                }
            }
        }

        public string getTransmitId()
        {
            return transmitId;
        }

        public SensorData getLatestSensorData(TemperatureUnitEnum tempUnit)
        {
            SensorData s = new SensorData();

            if (azTemp1 != null && azTemp1.Length != 0)
            {
                s.azTemp1 = Math.Round(ConvertRawTempToUnit(azTemp1[azTemp1.Length - 1], tempUnit), 2);
            }
            if (azTemp2 != null && azTemp2.Length != 0)
            {
                s.azTemp2 = Math.Round(ConvertRawTempToUnit(azTemp2[azTemp2.Length - 1], tempUnit), 2);
            }
            if (elTemp1 != null && elTemp1.Length != 0)
            {
                s.elTemp1 = Math.Round(ConvertRawTempToUnit(elTemp1[elTemp1.Length - 1], tempUnit), 2);
            }
            if (elTemp2 != null && elTemp2.Length != 0)
            {
                s.elTemp2 = Math.Round(ConvertRawTempToUnit(elTemp2[elTemp2.Length - 1], tempUnit), 2);
            }
            if (azAdxlData != null && azAdxlData.Length != 0)
            {
                s.azAdxlData = azAdxlData[azAdxlData.Length - 1];
            }
            if (elAdxlData != null && elAdxlData.Length != 0)
            {
                s.elAdxlData = elAdxlData[elAdxlData.Length - 1];
            }
            if (cbAdxlData != null && cbAdxlData.Length != 0)
            {
                s.cbAdxlData = cbAdxlData[cbAdxlData.Length - 1];
            }
            
            double az = 0;
            double el = 0;
            if (azEncoder != null) az = Math.Round(ConvertAzPositionToDegrees(azEncoder[azEncoder.Length - 1]), 2);
            if (elEncoder != null) el = Math.Round(ConvertElPositionToDegrees(elEncoder[elEncoder.Length - 1]), 2);
           s.orientation = new Orientation(az, el);

            return s;
        }

        public double ConvertAzPositionToDegrees(int rawAzPosition)
        {
            return 360 / SensorConversionConstants.AZ_ENCODER_SCALING * rawAzPosition;
        }

        public double ConvertElPositionToDegrees(int rawElPosition)
        {
            return 0.25 * rawElPosition - 20.375;
        }

        public double ConvertRawTempToUnit(int rawTemp, TemperatureUnitEnum tempUnit)
        {
            if (tempUnit == TemperatureUnitEnum.CELSIUS) return rawTemp / 16.0;
            else if (tempUnit == TemperatureUnitEnum.FAHRENHEIT) return rawTemp / 16.0 * 1.8 + 32.0;
            else return rawTemp / 16.0 + 273.15;
        }
    }
}
