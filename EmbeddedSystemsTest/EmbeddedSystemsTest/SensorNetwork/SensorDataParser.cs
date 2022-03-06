using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    class SensorDataParser
    {
        private List<AdxlData> elAdxlData { get; set; }
        private List<AdxlData> azAdxlData { get; set; }
        private List<AdxlData> cbAdxlData { get; set; }
        private int[] elTemp1 { get; set; }
        private int[] elTemp2 { get; set; }
        private int[] azTemp1 { get; set; }
        private int[] azTemp2 { get; set; }
        private float[] ambientTemp { get; set; }
        private float[] ambientHumidity { get; set; }
        private int[] elEncoder { get; set; }
        private int[] azEncoder { get; set; }
        private string transmitId { get; set; }
        private BitArray sensorStatuses { get; set; }
        private UInt32 sensorErrors { get; set; }

        public void ParseSensorData(byte[] bytes, int buffer, bool logData, string fileName)
        {
            StringBuilder adxlData = new StringBuilder();
            StringBuilder tempData = new StringBuilder();
            StringBuilder encoderData = new StringBuilder();
            if (logData == true)
            {
                //Add headers if file doesn't exist
                if (!File.Exists(fileName + "_AdxlData.csv"))
                {
                    adxlData.AppendLine("Date Time" + "," + "EL ADXL X Axis" + "," + "EL ADXL Y Axis" + "," + "EL ADXL Z Axis" + "," + "AZ ADXL X Axis" + "," + "AZ ADXL Y Axis" + "," + "AZ ADXL Z Axis" + "," + "CB ADXL X Axis" + "," + "CB ADXL Y Axis" + "," + "CB ADXL Z Axis");
                }
                if (!File.Exists(fileName + "_TempData.csv"))
                {
                    tempData.AppendLine("Date Time" + "," + "EL Temp °F" + "," + "AZ Temp °F" + "," + "Ambient Temp °F" + "Humidity %");
                }
                if (!File.Exists(fileName + "_EncoderData.csv"))
                {
                    encoderData.AppendLine("Date Time" + "," + "EL Encoder" + "," + "AZ Encoder");
                }
            }
            // Get transmit ID and data sizes from byte array
            transmitId = bytes[0].ToString();
            UInt32 dataSize = (UInt32)(bytes[1] << 24 | bytes[2] << 16 | bytes[3] << 8 | bytes[4]);
            sensorStatuses = new BitArray(new byte[] { bytes[5], bytes[6] }); // sensor statuses 
            sensorErrors = (UInt32)(bytes[7] << 16 | bytes[8] << 8 | bytes[9]); // sensor self-tests | adxl error codes and azimuth encoder error code | temp sensor error codes
            UInt16 elAdxlSize = (UInt16)(bytes[10] << 8 | bytes[11]);
            UInt16 azAdxlSize = (UInt16)(bytes[12] << 8 | bytes[13]);
            UInt16 cbAdxlSize = (UInt16)(bytes[14] << 8 | bytes[15]);
            UInt16 elTempSensorSize = (UInt16)(bytes[16] << 8 | bytes[17]);
            UInt16 azTempSensorSize = (UInt16)(bytes[18] << 8 | bytes[19]);
            UInt16 elEncoderSize = (UInt16)(bytes[20] << 8 | bytes[21]);
            UInt16 azEncoderSize = (UInt16)(bytes[22] << 8 | bytes[23]);
            UInt16 ambientTempSize = (UInt16)(bytes[24] << 8 | bytes[25]);
            UInt16 ambientHumiditySize = (UInt16)(bytes[26] << 8 | bytes[27]);

            if (buffer >= dataSize)
            {
                int k = 28;

                // Accelerometer 1 (elevation)
                if (elAdxlSize > 0)
                {
                    elAdxlData = new List<AdxlData>();
                    ParseAdxlData(ref bytes, ref k, elAdxlData, elAdxlSize);
                }

                // Accelerometer 2 (azimuth)
                if (azAdxlSize > 0)
                {
                    azAdxlData = new List<AdxlData>();
                    ParseAdxlData(ref bytes, ref k, azAdxlData, azAdxlSize);
                }

                // Accelerometer 3
                if (cbAdxlSize > 0)
                {
                    cbAdxlData = new List<AdxlData>();
                    ParseAdxlData(ref bytes, ref k, cbAdxlData, cbAdxlSize);
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

                // Elevation Ambient Temperature
                if (ambientTempSize > 0)
                {
                    ambientTemp = new float[ambientTempSize];
                    for (int j = 0; j < ambientTempSize; j++)
                    {
                        ambientTemp[j] = (bytes[k++] << 8 | bytes[k++]);
                    }
                }

                // Elevation Ambient Temperature
                if (ambientHumiditySize > 0)
                {
                    ambientHumidity = new float[ambientHumiditySize];
                    for (int j = 0; j < ambientHumiditySize; j++)
                    {
                        ambientHumidity[j] = (bytes[k++] << 8 | bytes[k++]);
                    }
                }

                if (logData)
                {
                    int[] adxlDataSizes = new int[3] { elAdxlData.Count, azAdxlData.Count, cbAdxlData.Count };
                    int maxAdxlSize = adxlDataSizes.Max();
                    for (int i = 0; i < maxAdxlSize; i++)
                    {
                        adxlData.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff") + ",");

                        if (i < elAdxlData.Count)
                        {
                            adxlData.Append(elAdxlData[i].xAxis.ToString() + "," + elAdxlData[i].yAxis.ToString() + "," + elAdxlData[i].zAxis.ToString() + ",");
                        }
                        if (i < azAdxlData.Count)
                        {
                            adxlData.Append(azAdxlData[i].xAxis.ToString() + "," + azAdxlData[i].yAxis.ToString() + "," + azAdxlData[i].zAxis.ToString() + ",");
                        }
                        if (i < cbAdxlData.Count)
                        {
                            adxlData.Append(cbAdxlData[i].xAxis.ToString() + "," + cbAdxlData[i].yAxis.ToString() + "," + cbAdxlData[i].zAxis.ToString());
                        }
                        adxlData.AppendLine();

                    }

                    UInt16[] tempDataSizes = new UInt16[4] { elTempSensorSize, azTempSensorSize, ambientTempSize, ambientHumiditySize };
                    int maxTempSize = tempDataSizes.Max();
                    for (int i = 0; i < maxTempSize; i++)
                    {
                        tempData.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff") + ",");

                        if (i < elTempSensorSize)
                        {
                            tempData.Append(ConvertRawTempToUnit(elTemp1[i], TemperatureUnitEnum.FAHRENHEIT).ToString() + ",");
                        }
                        if (i < azTempSensorSize)
                        {
                            tempData.Append(ConvertRawTempToUnit(azTemp1[i], TemperatureUnitEnum.FAHRENHEIT).ToString());
                        }
                        if (i < ambientTempSize)
                        {
                            tempData.Append(ambientTemp[i].ToString());
                        }
                        if (i < ambientHumiditySize)
                        {
                            tempData.Append(ambientHumidity[i].ToString());
                        }
                        tempData.AppendLine();
                    }
                    UInt16[] encoderDataSizes = new UInt16[2] { elEncoderSize, azEncoderSize };
                    int maxEncoderSize = encoderDataSizes.Max();
                    for (int i = 0; i < maxEncoderSize; i++)
                    {
                        encoderData.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff") + ",");

                        if (i < elEncoderSize)
                        {
                            encoderData.Append(ConvertElPositionToDegrees(elEncoder[i]).ToString() + ",");
                        }
                        if (i < azEncoderSize)
                        {
                            encoderData.Append(ConvertAzPositionToDegrees(azEncoder[i]).ToString());
                        }
                        encoderData.AppendLine();
                    }

                    if (adxlData.Length != 0)
                    {
                        using (StreamWriter sw = File.AppendText(fileName + "_AdxlData.csv"))
                        {
                            sw.Write(adxlData.ToString());
                        }
                    }
                    if (tempData.Length != 0)
                    {
                        using (StreamWriter sw = File.AppendText(fileName + "_TempData.csv"))
                        {
                            sw.Write(tempData.ToString());
                        }
                    }
                    if (encoderData.Length != 0)
                    {
                        using (StreamWriter sw = File.AppendText(fileName + "_EncoderData.csv"))
                        {
                            sw.Write(encoderData.ToString());
                        }
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
            if (ambientTemp != null && ambientTemp.Length != 0)
            {
                if (tempUnit == TemperatureUnitEnum.CELSIUS)
                {
                    s.ambTemp = (ambientTemp[ambientTemp.Length - 1] - 32) * 5 / 9;
                }
                else if (tempUnit == TemperatureUnitEnum.FAHRENHEIT)
                {
                    s.ambTemp = ambientTemp[ambientTemp.Length - 1];
                }
                else
                {
                    s.ambTemp = ((ambientTemp[ambientTemp.Length - 1] - 32) * 5 / 9) + 273;
                }
            }
            if (ambientTemp != null && ambientTemp.Length != 0)
            {
                s.ambHumidity = ambientHumidity[ambientHumidity.Length - 1];
            }
            if (azAdxlData != null && azAdxlData.Count != 0)
            {
                s.azAdxlData = azAdxlData[azAdxlData.Count - 1];
            }
            if (elAdxlData != null && elAdxlData.Count != 0)
            {
                s.elAdxlData = elAdxlData[elAdxlData.Count - 1];
            }
            if (cbAdxlData != null && cbAdxlData.Count != 0)
            {
                s.cbAdxlData = cbAdxlData[cbAdxlData.Count - 1];
            }
            if (sensorStatuses != null && sensorStatuses.Length != 0)
            {
                s.azEncoderStatus = sensorStatuses[0] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.azTemp2Status = sensorStatuses[1] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.azTemp1Status = sensorStatuses[2] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.elTemp2Status = sensorStatuses[3] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.elTemp1Status = sensorStatuses[4] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.cbAdxlStatus = sensorStatuses[5] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.azAdxlStatus = sensorStatuses[6] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.elAdxlStatus = sensorStatuses[7] ? SensorStatus.OKAY : SensorStatus.ERROR;
                s.ambTempHumidityStatus = sensorStatuses[8] ? SensorStatus.OKAY : SensorStatus.ERROR;
            }

            s.adxlSelfTestState = new AdxlSelfTestState[3];
            s.adxlSelfTestState[(int)AdxlSensors.ELEVATION] = (AdxlSelfTestState)((sensorErrors & 0x040000) >> 18);
            s.adxlSelfTestState[(int)AdxlSensors.AZIMUTH] = (AdxlSelfTestState)((sensorErrors & 0x020000) >> 17);
            s.adxlSelfTestState[(int)AdxlSensors.COUNTERBALANCE] = (AdxlSelfTestState)((sensorErrors & 0x010000) >> 16);
            s.adxlErrors = new AdxlError_Codes[3];
            s.adxlErrors[(int)AdxlSensors.ELEVATION] = (AdxlError_Codes)((sensorErrors & 0xC000) >> 14);
            s.adxlErrors[(int)AdxlSensors.AZIMUTH] = (AdxlError_Codes)((sensorErrors & 0x3000) >> 12);
            s.adxlErrors[(int)AdxlSensors.COUNTERBALANCE] = (AdxlError_Codes)((sensorErrors & 0x0C00) >> 10);
            s.azEncderError = (AzEncoderError_Codes)((sensorErrors & 0x0300) >> 8);
            s.temperatureErrors = new TemperatureError_Codes[4];
            s.temperatureErrors[(int)TemperatureSensors.ELEVATION1] = (TemperatureError_Codes)((sensorErrors & 0xC0) >> 6);
            s.temperatureErrors[(int)TemperatureSensors.ELEVATION2] = (TemperatureError_Codes)((sensorErrors & 0x30) >> 4);
            s.temperatureErrors[(int)TemperatureSensors.AZIMUTH1] = (TemperatureError_Codes)((sensorErrors & 0x0C) >> 2);
            s.temperatureErrors[(int)TemperatureSensors.AZIMUTH2] = (TemperatureError_Codes)(sensorErrors & 0x03);
            s.ambientTempHumidityError = (AmbientError_Code)((sensorErrors & 0x180000) >> 19);

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
            return -0.25 * rawElPosition + 104.375;
        }

        public double ConvertRawTempToUnit(int rawTemp, TemperatureUnitEnum tempUnit)
        {
            if (tempUnit == TemperatureUnitEnum.CELSIUS) return rawTemp / 16.0;
            else if (tempUnit == TemperatureUnitEnum.FAHRENHEIT) return rawTemp / 16.0 * 1.8 + 32.0;
            else return rawTemp / 16.0 + 273.15;
        }

        /// <summary>
        /// A helper function to parse acceleration data.
        /// </summary>
        /// <param name="bytes">The byte array to parse from.</param>
        /// <param name="k">Index to keep track of byte array position.</param>
        /// <param name="adxlData">List to store the parse acceleration data in.</param>
        /// <param name="numDumps">Number of acceleration fifo dumps to parse.</param>
        private void ParseAdxlData(ref byte[] bytes, ref int k, List<AdxlData> adxlData, int numDumps)
        {
            for (int j = 0; j < numDumps; j++)
            {
                long timeStamp = (bytes[k++] << 56 | bytes[k++] << 48 | bytes[k++] << 40 | bytes[k++] << 32
                    | bytes[k++] << 24 | bytes[k++] << 16 | bytes[k++] << 8 | bytes[k++]);

                short dumpSize = (short)(bytes[k++] << 8 | bytes[k++]);

                for (int i = 0; i < dumpSize; i++)
                {
                    adxlData.Add(new AdxlData()
                    {
                        xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                        yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                        zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                    });
                }
            }
        }
    }
}
