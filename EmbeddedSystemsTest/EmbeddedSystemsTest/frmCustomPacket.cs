using EmbeddedSystemsTest.SensorNetwork;
using EmbeddedSystemsTest.SensorNetworkSimulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Button PreviousButton;
        frmTcpTest PreviousForm;

        public frmCustomPacket(string ipAddress, int port, Button btnCustPacket, frmTcpTest previousForm)
        {
            InitializeComponent();

            // TCP client info
            IPAddress = ipAddress;
            Port = port;

            PreviousButton = btnCustPacket;
            PreviousForm = previousForm;

            cboElTemp1Status.SelectedIndex = 1;
            cboElTemp2Status.SelectedIndex = 1;
            cboAzTemp1Status.SelectedIndex = 1;
            cboAzTemp2Status.SelectedIndex = 1;
            cboAzEncStatus.SelectedIndex = 1;
            cboAzAccStatus.SelectedIndex = 1;
            cboElAccStatus.SelectedIndex = 1;
            cboCbAccStatus.SelectedIndex = 1;
            cboAmbTempHumidityStatus.SelectedIndex = 1;
        }

        private void chkElTemp1Init_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElTempInit.Checked) grpElTemps.Enabled = true;
            else grpElTemps.Enabled = false;
        }

        private void chkAzTempInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzTempInit.Checked) grpAzTemps.Enabled = true;
            else grpAzTemps.Enabled = false;
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
            if (chkElEncInit.Checked) grpElEncoder.Enabled = true;
            else grpElEncoder.Enabled = false;
        }

        private void chkAzEncInit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzEncInit.Checked) grpAzEncoder.Enabled = true;
            else grpAzEncoder.Enabled = false;
        }

        private void chkAmbTempHumidity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmbTempHumidity.Checked) grpAmbientTemperatureHumidity.Enabled = true;
            else grpAmbientTemperatureHumidity.Enabled = false;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            byte[] dataToSave = CheckAndProcessAllTextboxes();

            if (dataToSave != null)
            {
                File.WriteAllBytes(txtFilename.Text + ".snp", dataToSave);
            }
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
            double[] elTemp = new double[0];
            double[] azTemp = new double[0];
            double[] elEnc = new double[0];
            double[] azEnc = new double[0];
            float[] ambTemp = new float[0];
            float[] ambHumidity = new float[0];
            RawAccelerometerData[] elAccl = new RawAccelerometerData[0];
            RawAccelerometerData[] azAccl = new RawAccelerometerData[0];
            RawAccelerometerData[] cbAccl = new RawAccelerometerData[0];

            // Motor temp validating
            if (chkElTempInit.Checked && (elTemp = PacketEncodingTools.ConvertStringToDoubleArray(txtElTemps.Text)) == null)
            {
                errorStr += "Error in elevation data.\n";
            }

            if (chkAzTempInit.Checked && (azTemp = PacketEncodingTools.ConvertStringToDoubleArray(txtAzTemps.Text)) == null)
            {
                errorStr += "Error in azimuth data.\n";
            }

            // Encoder validating
            if (chkElEncInit.Checked && (elEnc = PacketEncodingTools.ConvertStringToDoubleArray(txtElPositions.Text)) == null)
            {
                errorStr += "Error in elevation encoder data.\n";
            }

            if (chkAzEncInit.Checked && (azEnc = PacketEncodingTools.ConvertStringToDoubleArray(txtAzPositions.Text)) == null)
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

            // Ambient temp and humidity validating
            if (chkAmbTempHumidity.Checked && (ambTemp = PacketEncodingTools.ConvertStringToFloatArray(txtAmbTemps.Text)) == null)
            {
                errorStr += "Error in ambient temperature data.\n";
            }

            if (chkAmbTempHumidity.Checked && (ambHumidity = PacketEncodingTools.ConvertStringToFloatArray(txtAmbHumidity.Text)) == null)
            {
                errorStr += "Error in ambient humidity data.\n";
            }

            // We only want to do this if no errors were found in the data strings
            byte[] dataToSend = new byte[0];
            if (errorStr.Equals(""))
            {
                SensorStatuses statuses = ParseSensorStatuses();

                // This function will eventually be used to convert the arrays gotten from the CSV files
                dataToSend = PacketEncodingTools.ConvertDataArraysToBytes(elAccl, azAccl, cbAccl, elTemp, azTemp, elEnc, azEnc, ambTemp, ambHumidity, statuses);
                lblPacketSize.Text = "Packet bytes: " + dataToSend.Length;
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

        /// <summary>
        /// This is used to parse the sensor statuses into the SensorStatuses object.
        /// </summary>
        /// <param name="statuses">Regular statuses.</param>
        /// <param name="errors">Various error codes if there are errors.</param>
        /// <returns></returns>
        private SensorStatuses ParseSensorStatuses()
        {
            SensorStatuses s = new SensorStatuses
            {
                // Regular statuses
                AzimuthAbsoluteEncoderStatus = (SensorStatus)cboAzEncStatus.SelectedIndex,
                AzimuthTemperature1Status = (SensorStatus)cboAzTemp1Status.SelectedIndex,
                AzimuthTemperature2Status = (SensorStatus)cboAzTemp2Status.SelectedIndex,
                ElevationTemperature1Status = (SensorStatus)cboElTemp1Status.SelectedIndex,
                ElevationTemperature2Status = (SensorStatus)cboElTemp2Status.SelectedIndex,
                AzimuthAccelerometerStatus = (SensorStatus)cboAzAccStatus.SelectedIndex,
                ElevationAccelerometerStatus = (SensorStatus)cboElAccStatus.SelectedIndex,
                CounterbalanceAccelerometerStatus = (SensorStatus)cboCbAccStatus.SelectedIndex,
                AmbientTemperatureAndHumidityStatus = (SensorStatus)cboCbAccStatus.SelectedIndex
            };
            
            return s;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Utilities.WriteToGUIFromThread(PreviousForm, () =>
            {
                PreviousButton.Enabled = true;
            });
        }
    }
}
