using EmbeddedSystemsTest.SensorNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedSystemsTest
{
    public partial class frmCustomPacket : Form
    {

        string IPAddress;
        int Port;

        public frmCustomPacket(string ipAddress, int port)
        {
            InitializeComponent();

            // TCP client info
            IPAddress = ipAddress;
            Port = port;
        }

        private void chkElTemp1Init_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElTempInit.Checked) txtElTemps.Enabled = true;
            else txtElTemps.Enabled = false;
        }

        private void chkAzTempInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzTempInit.Checked) txtAzTemps.Enabled = true;
            else txtAzTemps.Enabled = false;
        }

        private void chkElAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElAdxlInit.Checked) grpElAcclData.Enabled = true;
            else grpElAcclData.Enabled = false;
        }

        private void chkAzAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzAdxlInit.Checked) grpAzAcclData.Enabled = true;
            else grpAzAcclData.Enabled = false;
        }

        private void chkCbAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCbAdxlInit.Checked) grpCbAcclData.Enabled = true;
            else grpCbAcclData.Enabled = false;
        }

        private void chkElEncInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElEncInit.Checked) txtElPositions.Enabled = true;
            else txtElPositions.Enabled = false;
        }

        private void chkAzEncInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzEncInit.Checked) txtAzPositions.Enabled = true;
            else txtAzPositions.Enabled = false;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void txtElTemps_TextChanged(object sender, EventArgs e)
        {

        }

        private uint CalcDataSize(short Acc0Size, short Acc1Size, short Acc2Size, short Temp1Size, short Temp2Size, short ElEnSize, short AzEnSize)
        {
            uint length = 1 + 4 + 14;
            length += (uint)(Acc0Size * 6);
            length += (uint)(Acc1Size * 6);
            length += (uint)(Acc2Size * 6);
            length += (uint)(Temp1Size * 2);
            length += (uint)(Temp2Size * 2);
            length += (uint)(ElEnSize * 2);
            length += (uint)(AzEnSize * 2);

            return length;
        }

        private byte[] EncodeData(uint dataSize, RawAccelerometerData[] elAcclData, RawAccelerometerData[] azAcclData, RawAccelerometerData[] cbAcclData, short[] elTemp, short[] azTemp, short[] elEnc, short[] azEnc)
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
            for(uint j = 0; j < elAcclSize; j++)
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
            for(uint j = 0; j < elTempSize; j++)
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

        private byte[] ConvertDataArraysToBytes(RawAccelerometerData[] elAccl, RawAccelerometerData[] azAccl, RawAccelerometerData[] cbAccl, short[] elTemps, short[] azTemps, short[] elEnc, short[] azEnc)
        {
            uint dataSize = CalcDataSize((short)elAccl.Length, (short)azAccl.Length, (short)cbAccl.Length, (short)elTemps.Length, (short)azTemps.Length, (short)elEnc.Length, (short)azEnc.Length);
            
            return EncodeData(dataSize, elAccl, azAccl, cbAccl, elTemps, azTemps, elEnc, azEnc);
        }

        private void btnSendOverTcp_Click(object sender, EventArgs e)
        {
            string errorStr = "";
            short[] elTemp;
            short[] azTemp;
            short[] elEnc;
            short[] azEnc;
            RawAccelerometerData[] elAccl;
            RawAccelerometerData[] azAccl;
            RawAccelerometerData[] cbAccl;

            // Motor temp validating
            if ((elTemp = ConvertStringToShortArray(txtElTemps.Text)) == null) errorStr += "Error in elevation data.";
            if ((azTemp = ConvertStringToShortArray(txtAzTemps.Text)) == null) errorStr += "Error in azimuth data.";

            // Encoder validating
            if ((elEnc = ConvertStringToShortArray(txtElPositions.Text)) == null) errorStr += "Error in elevation encoder data.";
            if ((azEnc = ConvertStringToShortArray(txtAzPositions.Text)) == null) errorStr += "Error in azimuth encoder data.";

            // Accelerometer validating
            if ((elAccl = ConvertStringsToAccelerometerData(txtElX.Text, txtElY.Text, txtElZ.Text)) == null) errorStr += "Error in elevation accelerometer data.";
            if ((azAccl = ConvertStringsToAccelerometerData(txtAzX.Text, txtAzY.Text, txtAzZ.Text)) == null) errorStr += "Error in azimuth accelerometer data.";
            if ((cbAccl = ConvertStringsToAccelerometerData(txtCbX.Text, txtCbY.Text, txtCbZ.Text)) == null) errorStr += "Error in counterbalance accelerometer data.";

            // We only want to do this if no errors were found in the data strings
            byte[] dataToSend = new byte[0];
            if (errorStr.Equals(""))
            {
                // This function will eventually be used to convert the arrays gotten from the CSV files
                dataToSend = ConvertDataArraysToBytes(elAccl, azAccl, cbAccl, elTemp, azTemp, elEnc, azEnc);
                lblPacketSize.Text = "Packet size (in bytes): " + dataToSend.Length;
            }
            
            // Validate data size
            if (dataToSend.Length > 2048) errorStr += "You have too much data! Please keep it under 2048 bytes.\n";
                    
            if (errorStr.Equals(""))
            {
                TcpClient client = new TcpClient(IPAddress, Port);

                NetworkStream stream = client.GetStream();

                stream.Write(dataToSend, 0, dataToSend.Length);

                stream.Close();
                stream.Dispose();
                client.Close();
                client.Dispose();
            }
            else
            {
                MessageBox.Show(errorStr, "Error");
            }
        }

        // This also handles if the numbers are invalid, and will return null if so
        // This should not be needed in the simulation, because we should be getting short arrays from CSVs.
        private short[] ConvertStringToShortArray(string text)
        {
            short[] s;

            try
            {
                s = text.Split(',').Select(short.Parse).ToArray();
            }
            catch
            {
                return null;
            }

            return s;
        }

        // This also handles if the numbers are invalid, and will return null if so.
        // This should not be needed in the simulation, because we should be getting short arrays from CSVs.
        private RawAccelerometerData[] ConvertStringsToAccelerometerData(string x, string y, string z)
        {
            RawAccelerometerData[] acc;

            try
            {
                var azX = x.Split(',').Select(short.Parse).ToList();
                var azY = y.Split(',').Select(short.Parse).ToList();
                var azZ = z.Split(',').Select(short.Parse).ToList();

                acc = new RawAccelerometerData[azX.Count];
                for (int i = 0; i < azX.Count; i++)
                {
                    acc[i].X = azX[i];
                    acc[i].Y = azY[i];
                    acc[i].Z = azZ[i];
                }
            }
            catch
            {
                return null;
            }

            return acc;
        }
    }
}
