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

        byte[] DataToSend;

        short[] elTemps;
        short[] azTemps;
        short[] elEnc;
        short[] azEnc;
        RawAccelerometerData[] elAccl;
        RawAccelerometerData[] azAccl;
        RawAccelerometerData[] cbAccl;

        string IPAddress;
        int Port;

        public frmCustomPacket(string ipAddress, int port)
        {
            InitializeComponent();

            // The total data that we are sending
            DataToSend = new byte[0];
            
            // Data that we can send
            elTemps = new short[0];
            azTemps = new short[0];
            elEnc = new short[0];
            azEnc = new short[0];
            elAccl = new RawAccelerometerData[0];
            azAccl = new RawAccelerometerData[0];
            cbAccl = new RawAccelerometerData[0];

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

        private uint CalcTransitSize(short Acc0Size, short Acc1Size, short Acc2Size, short Temp1Size, short Temp2Size, short ElEnSize, short AzEnSize)
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

        private void PrepareTransit(ref byte[] reply, uint dataSize, RawAccelerometerData[] elAcclData, RawAccelerometerData[] azAcclData, RawAccelerometerData[] cbAcclData, short[] elTemp, short[] azTemp, short[] elEnc, short[] azEnc)
        {
            uint i = 0;
            reply[0] = SensorConversionConstants.DataTransmitId;
            
            reply[1] = (byte)((dataSize & 0xFF000000) >> 24);
            reply[2] = (byte)((dataSize & 0x00FF0000) >> 16);
            reply[3] = (byte)((dataSize & 0x0000FF00) >> 8);
            reply[4] = (byte)(dataSize & 0x000000FF);

            // Store elevation accelerometer size 
            uint elAcclSize = (uint)elAcclData.Length;
            reply[5] = (byte)(((elAcclSize) & 0xFF00) >> 8);
            reply[6] = (byte)((elAcclSize) & 0x00FF);

            // Store azimuth accelerometer size
            uint azAcclSize = (uint)azAcclData.Length;
            reply[7] = (byte)(((azAcclSize) & 0xFF00) >> 8);
            reply[8] = (byte)((azAcclSize) & 0x00FF);

            // Store counterbalance accelerometer size
            uint cbAcclSize = (uint)cbAcclData.Length;
            reply[9] = (byte)(((cbAcclSize) & 0xFF00) >> 8);
            reply[10] = (byte)(((cbAcclSize & 0x00FF)));

            // Store elevation temperature size
            uint elTempSize = (uint)elTemp.Length;
            reply[11] = (byte)(((elTempSize) & 0xFF00) >> 8);
            reply[12] = (byte)(((elTempSize & 0x00FF)));

            // Store azimuth temperature size
            uint azTempSize = (uint)azTemp.Length;
            reply[13] = (byte)(((azTempSize) & 0xFF00) >> 8);
            reply[14] = (byte)(((azTempSize & 0x00FF)));

            // Store elevation encoder size
            uint elEncSize = (uint)elEnc.Length;
            reply[15] = (byte)(((elEncSize) & 0xFF00) >> 8);
            reply[16] = (byte)(((elEncSize & 0x00FF)));

            // Store azimuth encoder size
            uint azEncSize = (uint)azEnc.Length;
            reply[17] = (byte)(((azEncSize) & 0xFF00) >> 8);
            reply[18] = (byte)(((azEncSize & 0x00FF)));

            i = 19;

            // Store elevation accelerometer data
            for(uint j = 0; j < elAcclSize; j++)
            {
                reply[i++] = (byte)((elAcclData[j].X & 0xFF00) >> 8);
                reply[i++] = (byte)((elAcclData[j].X & 0x00FF));
                reply[i++] = (byte)((elAcclData[j].Y & 0xFF00) >> 8);
                reply[i++] = (byte)((elAcclData[j].Y & 0x00FF));
                reply[i++] = (byte)((elAcclData[j].Z & 0xFF00) >> 8);
                reply[i++] = (byte)((elAcclData[j].Z & 0x00FF));
            }

            // Store azimuth accelerometer data
            for (uint j = 0; j < azAcclSize; j++)
            {
                reply[i++] = (byte)((azAcclData[j].X & 0xFF00) >> 8);
                reply[i++] = (byte)((azAcclData[j].X & 0x00FF));
                reply[i++] = (byte)((azAcclData[j].Y & 0xFF00) >> 8);
                reply[i++] = (byte)((azAcclData[j].Y & 0x00FF));
                reply[i++] = (byte)((azAcclData[j].Z & 0xFF00) >> 8);
                reply[i++] = (byte)((azAcclData[j].Z & 0x00FF));
            }

            // Store counterbalance accelerometer data
            for (uint j = 0; j < cbAcclSize; j++)
            {
                reply[i++] = (byte)((cbAcclData[j].X & 0xFF00) >> 8);
                reply[i++] = (byte)((cbAcclData[j].X & 0x00FF));
                reply[i++] = (byte)((cbAcclData[j].Y & 0xFF00) >> 8);
                reply[i++] = (byte)((cbAcclData[j].Y & 0x00FF));
                reply[i++] = (byte)((cbAcclData[j].Z & 0xFF00) >> 8);
                reply[i++] = (byte)((cbAcclData[j].Z & 0x00FF));
            }

            // Store elevation temperature data
            for(uint j = 0; j < elTempSize; j++)
            {
                reply[i++] = (byte)((elTemp[j] & 0xFF00) >> 8);
                reply[i++] = (byte)((elTemp[j] & 0x00FF));
            }

            // Store azimuth temperature data
            for (uint j = 0; j < azTempSize; j++)
            {
                reply[i++] = (byte)((azTemp[j] & 0xFF00) >> 8);
                reply[i++] = (byte)((azTemp[j] & 0x00FF));
            }

            // Store elevation encoder data
            for (uint j = 0; j < elEncSize; j++)
            {
                reply[i++] = (byte)((elEnc[j] & 0xFF00) >> 8);
                reply[i++] = (byte)((elEnc[j] & 0x00FF));
            }

            // Store azimuth encoder data
            for (uint j = 0; j < azEncSize; j++)
            {
                reply[i++] = (byte)((azEnc[j] & 0xFF00) >> 8);
                reply[i++] = (byte)((azEnc[j] & 0x00FF));
            }
        }

        private void ConvertDataToBytes()
        {
            // Reset fields in case they have data in them from before
            elTemps = new short[0];
            azTemps = new short[0];
            elEnc = new short[0];
            azEnc = new short[0];
            elAccl = new RawAccelerometerData[0];
            azAccl = new RawAccelerometerData[0];
            cbAccl = new RawAccelerometerData[0];

            // get temp lists
            if (chkElTempInit.Checked) elTemps = txtElTemps.Text.Split(',').Select(short.Parse).ToArray();
            if (chkAzTempInit.Checked) azTemps = txtAzTemps.Text.Split(',').Select(short.Parse).ToArray();

            // get encoder lists
            if (chkElEncInit.Checked) elEnc = txtElPositions.Text.Split(',').Select(short.Parse).ToArray();
            if (chkAzEncInit.Checked) azEnc = txtAzPositions.Text.Split(',').Select(short.Parse).ToArray();

            // get elevation accelerometer lists
            if (chkElAdxlInit.Checked)
            {
                var elX = txtElX.Text.Split(',').Select(short.Parse).ToList();
                var elY = txtElY.Text.Split(',').Select(short.Parse).ToList();
                var elZ = txtElZ.Text.Split(',').Select(short.Parse).ToList();

                elAccl = new RawAccelerometerData[elX.Count];
                for (int i = 0; i < elX.Count; i++)
                {
                    elAccl[i].X = elX[i];
                    elAccl[i].Y = elY[i];
                    elAccl[i].Z = elZ[i];
                }
            }

            // get azimuth accelerometer lists
            if (chkAzAdxlInit.Checked)
            {
                var azX = txtAzX.Text.Split(',').Select(short.Parse).ToList();
                var azY = txtAzY.Text.Split(',').Select(short.Parse).ToList();
                var azZ = txtAzZ.Text.Split(',').Select(short.Parse).ToList();

                azAccl = new RawAccelerometerData[azX.Count];
                for (int i = 0; i < azX.Count; i++)
                {
                    azAccl[i].X = azX[i];
                    azAccl[i].Y = azY[i];
                    azAccl[i].Z = azZ[i];
                }
            }

            // get counterbalance accelerometer lists
            if (chkCbAdxlInit.Checked)
            {
                var cbX = txtCbX.Text.Split(',').Select(short.Parse).ToList();
                var cbY = txtCbY.Text.Split(',').Select(short.Parse).ToList();
                var cbZ = txtCbZ.Text.Split(',').Select(short.Parse).ToList();

                cbAccl = new RawAccelerometerData[cbX.Count];
                for (int i = 0; i < cbX.Count; i++)
                {
                    cbAccl[i].X = cbX[i];
                    cbAccl[i].Y = cbY[i];
                    cbAccl[i].Z = cbZ[i];
                }
            }

            // Calculate size of the data
            uint dataSize = CalcTransitSize((short)elAccl.Length, (short)azAccl.Length, (short)cbAccl.Length, (short)elTemps.Length, (short)azTemps.Length, (short)elEnc.Length, (short)azEnc.Length);

            DataToSend = new byte[dataSize];

            PrepareTransit(ref DataToSend, dataSize, elAccl, azAccl, cbAccl, elTemps, azTemps, elEnc, azEnc);
        }

        private void btnCreateBytes_Click(object sender, EventArgs e)
        {
            ConvertDataToBytes();

            // Validate that the user has not exceeded 2048 bytes
            if (DataToSend.Length <= 2048)
            {
                btnSaveToFile.Enabled = true;
                btnSendOverTcp.Enabled = true;
            }
            else
            {
                btnSaveToFile.Enabled = false;
                btnSendOverTcp.Enabled = false;
                MessageBox.Show("Error: You have too much data! Please keep it under 2048 bytes.", "Too Many Bytes");
            }

            lblPacketSize.Text = "Packet size (in bytes): " + DataToSend.Length;
        }

        private void btnSendOverTcp_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(IPAddress, Port);

            NetworkStream stream = client.GetStream();

            stream.Write(DataToSend, 0, DataToSend.Length);

            stream.Close();
            stream.Dispose();
            client.Close();
            client.Dispose();
        }
    }
}
