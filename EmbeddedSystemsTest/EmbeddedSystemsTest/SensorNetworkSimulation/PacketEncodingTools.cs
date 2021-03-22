using EmbeddedSystemsTest.SensorNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetworkSimulation
{
    public class PacketEncodingTools
    {
        // This is important for the simulation. This will convert the data arrays we get from CSV files
        // to bytes that we can send to the SensorNetworkServer
        public static byte[] ConvertDataArraysToBytes(RawAccelerometerData[] elAccl, RawAccelerometerData[] azAccl, RawAccelerometerData[] cbAccl, double[] elTemps, double[] azTemps, double[] elEnc, double[] azEnc)
        {
            int dataSize = CalcDataSize(elAccl.Length, azAccl.Length, cbAccl.Length, elTemps.Length, azTemps.Length, elEnc.Length, azEnc.Length);

            // Convert elevation temperature to raw data
            short[] rawElTemps = new short[elTemps.Length];
            for (int i = 0; i < elTemps.Length; i++)
            {
                rawElTemps[i] = ConvertTempCToRawData(elTemps[i]);
            }

            // Convert azimuth temperature to raw data
            short[] rawAzTemps = new short[azTemps.Length];
            for (int i = 0; i < azTemps.Length; i++)
            {
                rawAzTemps[i] = ConvertTempCToRawData(azTemps[i]);
            }

            // Convert elevation position to raw data
            short[] rawElEnc = new short[elEnc.Length];
            for(int i = 0; i < elEnc.Length; i++)
            {
                rawElEnc[i] = ConvertDegreesToRawElData(elEnc[i]);
            }

            // Convert azimuth position to raw data
            short[] rawAzEnc = new short[azEnc.Length];
            for (int i = 0; i < azEnc.Length; i++)
            {
                rawAzEnc[i] = ConvertDegreesToRawAzData(azEnc[i]);
            }

            return EncodeData(dataSize, elAccl, azAccl, cbAccl, rawElTemps, rawAzTemps, rawElEnc, rawAzEnc);
        }

        // This will take the size and actually encode all the data arrays into a byte array that we can send
        public static byte[] EncodeData(int dataSize, RawAccelerometerData[] elAcclData, RawAccelerometerData[] azAcclData, RawAccelerometerData[] cbAcclData, short[] elTemp, short[] azTemp, short[] elEnc, short[] azEnc)
        {
            byte[] data = new byte[dataSize];

            uint i = 0;
            data[0] = SensorConversionConstants.DataTransmitId;

            data[1] = (byte)((dataSize & 0xFF000000) >> 24);
            data[2] = (byte)((dataSize & 0x00FF0000) >> 16);
            data[3] = (byte)((dataSize & 0x0000FF00) >> 8);
            data[4] = (byte)(dataSize & 0x000000FF);

            // Store elevation accelerometer size 
            uint elAcclSize = (uint)elAcclData.Length;
            data[5] = (byte)(((elAcclSize) & 0xFF00) >> 8);
            data[6] = (byte)((elAcclSize) & 0x00FF);

            // Store azimuth accelerometer size
            uint azAcclSize = (uint)azAcclData.Length;
            data[7] = (byte)(((azAcclSize) & 0xFF00) >> 8);
            data[8] = (byte)((azAcclSize) & 0x00FF);

            // Store counterbalance accelerometer size
            uint cbAcclSize = (uint)cbAcclData.Length;
            data[9] = (byte)(((cbAcclSize) & 0xFF00) >> 8);
            data[10] = (byte)(((cbAcclSize & 0x00FF)));

            // Store elevation temperature size
            uint elTempSize = (uint)elTemp.Length;
            data[11] = (byte)(((elTempSize) & 0xFF00) >> 8);
            data[12] = (byte)(((elTempSize & 0x00FF)));

            // Store azimuth temperature size
            uint azTempSize = (uint)azTemp.Length;
            data[13] = (byte)(((azTempSize) & 0xFF00) >> 8);
            data[14] = (byte)(((azTempSize & 0x00FF)));

            // Store elevation encoder size
            uint elEncSize = (uint)elEnc.Length;
            data[15] = (byte)(((elEncSize) & 0xFF00) >> 8);
            data[16] = (byte)(((elEncSize & 0x00FF)));

            // Store azimuth encoder size
            uint azEncSize = (uint)azEnc.Length;
            data[17] = (byte)(((azEncSize) & 0xFF00) >> 8);
            data[18] = (byte)(((azEncSize & 0x00FF)));

            i = 19;

            // Store elevation accelerometer data
            for (uint j = 0; j < elAcclSize; j++)
            {
                data[i++] = (byte)((elAcclData[j].X & 0xFF00) >> 8);
                data[i++] = (byte)((elAcclData[j].X & 0x00FF));
                data[i++] = (byte)((elAcclData[j].Y & 0xFF00) >> 8);
                data[i++] = (byte)((elAcclData[j].Y & 0x00FF));
                data[i++] = (byte)((elAcclData[j].Z & 0xFF00) >> 8);
                data[i++] = (byte)((elAcclData[j].Z & 0x00FF));
            }

            // Store azimuth accelerometer data
            for (uint j = 0; j < azAcclSize; j++)
            {
                data[i++] = (byte)((azAcclData[j].X & 0xFF00) >> 8);
                data[i++] = (byte)((azAcclData[j].X & 0x00FF));
                data[i++] = (byte)((azAcclData[j].Y & 0xFF00) >> 8);
                data[i++] = (byte)((azAcclData[j].Y & 0x00FF));
                data[i++] = (byte)((azAcclData[j].Z & 0xFF00) >> 8);
                data[i++] = (byte)((azAcclData[j].Z & 0x00FF));
            }

            // Store counterbalance accelerometer data
            for (uint j = 0; j < cbAcclSize; j++)
            {
                data[i++] = (byte)((cbAcclData[j].X & 0xFF00) >> 8);
                data[i++] = (byte)((cbAcclData[j].X & 0x00FF));
                data[i++] = (byte)((cbAcclData[j].Y & 0xFF00) >> 8);
                data[i++] = (byte)((cbAcclData[j].Y & 0x00FF));
                data[i++] = (byte)((cbAcclData[j].Z & 0xFF00) >> 8);
                data[i++] = (byte)((cbAcclData[j].Z & 0x00FF));
            }

            // Store elevation temperature data
            for (uint j = 0; j < elTempSize; j++)
            {
                data[i++] = (byte)((elTemp[j] & 0xFF00) >> 8);
                data[i++] = (byte)((elTemp[j] & 0x00FF));
            }

            // Store azimuth temperature data
            for (uint j = 0; j < azTempSize; j++)
            {
                data[i++] = (byte)((azTemp[j] & 0xFF00) >> 8);
                data[i++] = (byte)((azTemp[j] & 0x00FF));
            }

            // Store elevation encoder data
            for (uint j = 0; j < elEncSize; j++)
            {
                data[i++] = (byte)((elEnc[j] & 0xFF00) >> 8);
                data[i++] = (byte)((elEnc[j] & 0x00FF));
            }

            // Store azimuth encoder data
            for (uint j = 0; j < azEncSize; j++)
            {
                data[i++] = (byte)((azEnc[j] & 0xFF00) >> 8);
                data[i++] = (byte)((azEnc[j] & 0x00FF));
            }

            return data;
        }

        // Calculates the size of the packet that will be sent to the sensor network
        // This value will be used to create the byte array
        public static int CalcDataSize(int Acc0Size, int Acc1Size, int Acc2Size, int Temp1Size, int Temp2Size, int ElEnSize, int AzEnSize)
        {
            int length = 1 + 4 + 14;
            length += Acc0Size * 6;
            length += Acc1Size * 6;
            length += Acc2Size * 6;
            length += Temp1Size * 2;
            length += Temp2Size * 2;
            length += ElEnSize * 2;
            length += AzEnSize * 2;

            return length;
        }

        // This is so we can give the simulation "real" data, where it will be converted to raw
        // before being encoded. This is approximate, and may not be exact.
        public static short ConvertDegreesToRawElData(double dataToConvert)
        {
            return (short)Math.Round((dataToConvert + 20.375) / 0.25);
        }

        // This is so we can give the simulation "real" data, where it will be converted to raw
        // before being encoded. This is approximate, and may not be exact.
        public static short ConvertDegreesToRawAzData(double dataToConvert)
        {
            return (short)((SensorConversionConstants.AZ_ENCODER_SCALING * dataToConvert) / 360);
        }

        // This converts the degrees from celsius into raw data. This is approximate.
        public static short ConvertTempCToRawData(double dataToConvert)
        {
            return (short)(dataToConvert * 16);
        }

        // This also handles if the numbers are invalid, and will return null if so
        // This should not be needed in the simulation, because we should be getting short arrays from CSVs.
        public static double[] ConvertStringToDoubleArray(string text)
        {
            double[] s;

            try
            {
                s = text.Split(',').Select(double.Parse).ToArray();
            }
            catch
            {
                return null;
            }

            return s;
        }

        // This also handles if the numbers are invalid, and will return null if so.
        // This should not be needed in the simulation, because we should be getting short arrays from CSVs.
        public static RawAccelerometerData[] ConvertStringsToAccelerometerData(string x, string y, string z)
        {
            RawAccelerometerData[] acc;

            try
            {
                var azX = x.Split(',').Select(short.Parse).ToArray();
                var azY = y.Split(',').Select(short.Parse).ToArray();
                var azZ = z.Split(',').Select(short.Parse).ToArray();

                // All the accelerometer axes should have the same length
                if (azX.Length == azY.Length && azX.Length == azZ.Length)
                {
                    acc = new RawAccelerometerData[azX.Length];
                    for (int i = 0; i < azX.Length; i++)
                    {
                        acc[i].X = azX[i];
                        acc[i].Y = azY[i];
                        acc[i].Z = azZ[i];
                    }
                }
                else return null;
            }
            catch
            {
                return null;
            }

            return acc;
        }
    }
}
