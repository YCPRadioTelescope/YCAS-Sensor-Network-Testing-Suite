using EmbeddedSystemsTest.SensorNetwork;
using EmbeddedSystemsTest.SensorNetworkSimulation;
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
            byte[] dataToSave = CheckAndProcessAllTextboxes();

            if(dataToSave != null)
            {

            }
        }

        private void txtElTemps_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendOverTcp_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = CheckAndProcessAllTextboxes();
            
            if (dataToSend != null)
            {
                TcpClient client = new TcpClient(IPAddress, Port);

                NetworkStream stream = client.GetStream();

                stream.Write(dataToSend, 0, dataToSend.Length);

                stream.Close();
                stream.Dispose();
                client.Close();
                client.Dispose();
            }
        }

        // This function will not be needed in the simulation.
        private byte[] CheckAndProcessAllTextboxes()
        {
            string errorStr = "";
            short[] elTemp = new short[0];
            short[] azTemp = new short[0];
            short[] elEnc = new short[0];
            short[] azEnc = new short[0];
            RawAccelerometerData[] elAccl = new RawAccelerometerData[0];
            RawAccelerometerData[] azAccl = new RawAccelerometerData[0];
            RawAccelerometerData[] cbAccl = new RawAccelerometerData[0];

            // Motor temp validating
            if (chkElTempInit.Checked && (elTemp = PacketEncodingTools.ConvertStringToShortArray(txtElTemps.Text)) == null)
            {
                errorStr += "Error in elevation data.\n";
            }

            if (chkAzTempInit.Checked && (azTemp = PacketEncodingTools.ConvertStringToShortArray(txtAzTemps.Text)) == null)
            {
                errorStr += "Error in azimuth data.\n";
            }

            // Encoder validating
            if (chkElEncInit.Checked && (elEnc = PacketEncodingTools.ConvertStringToShortArray(txtElPositions.Text)) == null)
            {
                errorStr += "Error in elevation encoder data.\n";
            }

            if (chkAzEncInit.Checked && (azEnc = PacketEncodingTools.ConvertStringToShortArray(txtAzPositions.Text)) == null)
            {
                errorStr += "Error in azimuth encoder data.\n";
            }

            // Accelerometer validating
            if (chkElAdxlInit.Checked && (elAccl = PacketEncodingTools.ConvertStringsToAccelerometerData(txtElX.Text, txtElY.Text, txtElZ.Text)) == null)
            {
                errorStr += "Error in elevation accelerometer data.\n";
            }

            if (chkAzAdxlInit.Checked && (azAccl = PacketEncodingTools.ConvertStringsToAccelerometerData(txtAzX.Text, txtAzY.Text, txtAzZ.Text)) == null)
            {
                errorStr += "Error in azimuth accelerometer data.\n";
            }

            if (chkCbAdxlInit.Checked && (cbAccl = PacketEncodingTools.ConvertStringsToAccelerometerData(txtCbX.Text, txtCbY.Text, txtCbZ.Text)) == null)
            {
                errorStr += "Error in counterbalance accelerometer data.\n";
            }

            // We only want to do this if no errors were found in the data strings
            byte[] dataToSend = new byte[0];
            if (errorStr.Equals(""))
            {
                // This function will eventually be used to convert the arrays gotten from the CSV files
                dataToSend = PacketEncodingTools.ConvertDataArraysToBytes(elAccl, azAccl, cbAccl, elTemp, azTemp, elEnc, azEnc);
                lblPacketSize.Text = "Packet size (in bytes): " + dataToSend.Length;
            }

            // Validate data size
            if (dataToSend.Length > 2048) errorStr += "You have too much data! Please keep it under 2048 bytes.\n";

            if (errorStr.Equals("")) return dataToSend;
            else
            {
                MessageBox.Show(errorStr, "Error");
                return null;
            }
        }
    }
}
