using EmbeddedSystemsTest.SensorNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedSystemsTest
{
    public partial class frmTcpTest : Form
    {
        bool runListenerThread;
        Thread listenerThread;
        TcpListener server;

        Thread clientThread;
        TcpClient client;

        SensorDataParser sensorNetwork;

        // Statistics
        long lastPacketGap;
        long lowPacketGap;
        long avgPacketGap;
        long highPacketGap;
        long totalPacketGap;
        int totalPackets;
        Stopwatch stopWatch;

        // Sensor initialization
        byte[] sensorInit;

        public frmTcpTest()
        {
            InitializeComponent();

            runListenerThread = false;
            sensorNetwork = new SensorDataParser();

            // Init the statistics
            lastPacketGap = 0;
            lowPacketGap = long.MaxValue;
            avgPacketGap = 0;
            highPacketGap = 0;
            totalPacketGap = 0;
            totalPackets = 0;
            stopWatch = new Stopwatch();

            // Init the sensor initialization w/ checkboxes
            sensorInit = new byte[9];
            sensorInit[0] = chkElTemp1Init.Checked ? (byte)1 : (byte)0;
            sensorInit[1] = chkElTemp2Init.Checked ? (byte)1 : (byte)0;
            sensorInit[2] = chkAzTemp1Init.Checked ? (byte)1 : (byte)0;
            sensorInit[3] = chkAzTemp2Init.Checked ? (byte)1 : (byte)0;
            sensorInit[4] = chkElEncInit.Checked ? (byte)1 : (byte)0;
            sensorInit[5] = chkAzEncInit.Checked ? (byte)1 : (byte)0;
            sensorInit[6] = chkAzAdxlInit.Checked ? (byte)1 : (byte)0;
            sensorInit[7] = chkElAdxlInit.Checked ? (byte)1 : (byte)0;
            sensorInit[8] = chkCbAdxlInit.Checked ? (byte)1 : (byte)0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // FOR TESTING PURPOSES ONLY!!!
            // This is so we don't have to keep typing stuff in
            txtListenIp.Text = "192.168.0.10";
            txtListenPort.Text = "1600";
            txtClientIp.Text = "192.168.0.197";
            txtClientPort.Text = "1680";
            
        }

        private void lblStartListen_Click(object sender, EventArgs e)
        {
            string errorStr = "";
            if (!Validator.ipValid(txtListenIp.Text)) errorStr += "Listener IP address is invalid\n";
            if (!Validator.isPort(txtListenPort.Text)) errorStr += "Listener port is invalid\n";
            if (errorStr.Equals("") && !Validator.serverIpExists(txtListenIp.Text, int.Parse(txtListenPort.Text))) errorStr += $"Could not start server at {txtListenIp.Text}:{txtListenPort.Text}\n";

            if (errorStr.Equals(""))
            {
                lblListenRunning.Text = "Running.";
                lblListenConnected.Text = "Waiting for data.";

                btnKillListen.Enabled = true;
                btnStartListen.Enabled = false;

                radSensorData.Enabled = false;
                radTCPData.Enabled = false;

                txtListenIp.Enabled = false;
                txtListenPort.Enabled = false;

                if(radSensorData.Checked)
                {
                    txtClientIp.Enabled = false;
                    txtClientPort.Enabled = false;
                }

                listenerThread = new Thread(() => listenerProcess(IPAddress.Parse(txtListenIp.Text), int.Parse(txtListenPort.Text)));
                listenerThread.Start();
            }
            else MessageBox.Show(errorStr, "Errors");
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            if (!radSensorData.Checked)
            {
                string errorStr = "";
                if (!Validator.ipValid(txtClientIp.Text)) errorStr += "Client IP address is invalid\n";
                if (!Validator.isPort(txtClientPort.Text)) errorStr += "Client port is invalid\n";
                if (errorStr.Equals("") && !Validator.clientIpExists(txtClientIp.Text, int.Parse(txtClientPort.Text))) errorStr += $"Could not find server at {txtClientIp.Text}:{txtClientPort.Text}\n";
                if (txtClientData.Text.Equals("")) errorStr += "No data is present\n";
                if (errorStr.Equals(""))
                {
                    if (!radSensorData.Checked) addToUiConsole("Sent to server: " + txtClientData.Text);
                    else addToUiConsole("Sent to Teensy: Sensor initialization");

                    clientThread = new Thread(() => clientProcess(txtClientIp.Text,
                                                                    int.Parse(txtClientPort.Text),
                                                                    Encoding.ASCII.GetBytes(txtClientData.Text)));
                    clientThread.Start();
                }
                else MessageBox.Show(errorStr, "Error");
            }
            else
            {
                addToUiConsole("Restarting Sensor Network; temporarily stopping TCP server...");
                btnStartClient.Enabled = false;
                btnKillListen.Enabled = false;
                server.Stop();
                runListenerThread = false;
                listenerThread.Join();

                // Wait a few seconds for the Teensy's watchdog timer to time out. The timeout is about 1.5 seconds,
                // so I added an additional 50 ms to really make sure it's out. This should be updated if the Teensy's
                // timeout is changed
                Thread.Sleep(1550);

                // Restart the listening thread
                listenerThread = new Thread(() => listenerProcess(IPAddress.Parse(txtListenIp.Text), int.Parse(txtListenPort.Text)));
                listenerThread.Start();
                btnKillListen.Enabled = true;
            }
        }

        private void clientProcess(string addr, int port, byte[] data) {
            client = new TcpClient(addr, port);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            // We only want to do this if we're not collecting sensor data
            if (!radSensorData.Checked)
            {
                int bytes = stream.Read(data, 0, data.Length);
                string response = Encoding.ASCII.GetString(data, 0, bytes);
                Utilities.WriteToGUIFromThread(this, () =>
                {
                    addToUiConsole("Received from server: " + response);
                });
            }

            stream.Close();
            stream.Dispose();
            client.Close();
            client.Dispose();
        }

        private void listenerProcess(IPAddress addr, int port) {
            server = new TcpListener(addr, port);
            server.Start();
            runListenerThread = true;
            
            TcpClient localClient;
            NetworkStream stream;

            byte[] bytes = new byte[2048];

            while (runListenerThread)
            {

                try { 
                    
                    localClient = server.AcceptTcpClient();
                    Utilities.WriteToGUIFromThread(this, () => 
                    {
                        lblListenConnected.Text = "Received data.";
                        addToUiConsole("Client connected to server");
                    });
                    stream = localClient.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0 && runListenerThread)
                    {
                        if(!radSensorData.Checked) stream.Write(bytes, 0, bytes.Length);

                        if (Encoding.ASCII.GetString(bytes, 0, i).Equals("Send Sensor Configuration") && radSensorData.Checked)
                        {
                            // Convert all sensor init checkboxes into byte array
                            sensorInit[0] = chkElTemp1Init.Checked ? (byte)1 : (byte)0;
                            sensorInit[1] = chkElTemp2Init.Checked ? (byte)1 : (byte)0;
                            sensorInit[2] = chkAzTemp1Init.Checked ? (byte)1 : (byte)0;
                            sensorInit[3] = chkAzTemp2Init.Checked ? (byte)1 : (byte)0;
                            sensorInit[4] = chkElEncInit.Checked ? (byte)1 : (byte)0;
                            sensorInit[5] = chkAzEncInit.Checked ? (byte)1 : (byte)0;
                            sensorInit[6] = chkAzAdxlInit.Checked ? (byte)1 : (byte)0;
                            sensorInit[7] = chkElAdxlInit.Checked ? (byte)1 : (byte)0;
                            sensorInit[8] = chkCbAdxlInit.Checked ? (byte)1 : (byte)0;

                            // Send data to the Teensy
                            clientProcess(txtClientIp.Text, int.Parse(txtClientPort.Text), sensorInit);


                            Utilities.WriteToGUIFromThread(this, () =>
                            {
                                // now that initial data has been sent, we can allow the user to update the configuration
                                btnStartClient.Enabled = true;

                                addToUiConsole("Sent sensor configuration to Teensy");

                                // Since we uploaded the sensor init, remove message telling user to update it
                                lblSensorInitChanged.Text = "";
                            });
                        }
                        else
                        {
                            totalPackets++;

                            // If this code is reached, then it means another packet came through and we can calculate the gap
                            if (stopWatch.IsRunning)
                            {
                                stopWatch.Stop();
                                totalPacketGap += lastPacketGap;
                                lastPacketGap = stopWatch.ElapsedMilliseconds;

                                if (lastPacketGap < lowPacketGap) lowPacketGap = lastPacketGap;
                                if (lastPacketGap > highPacketGap) highPacketGap = lastPacketGap;

                                avgPacketGap = totalPacketGap / totalPackets;

                                stopWatch.Reset();
                            }
                            stopWatch.Start();

                            // Interpret received data
                            sensorNetwork.ParseSensorData(bytes, i);

                            // Write all the information to the GUI                                            
                            Utilities.WriteToGUIFromThread(this, () =>
                            {
                                if (chkAccumulateServer.Checked)
                                {
                                    if (!radSensorData.Checked) addToUiConsole("Received TCP data from client: " + Encoding.ASCII.GetString(bytes, 0, i));
                                    else addToUiConsole("Received sensor data from Teensy with transmit ID: " + sensorNetwork.getTransmitId());
                                }
                                else
                                {
                                    if (!radSensorData.Checked) txtReceived.Text = Utilities.getCurrDate() + " - Received TCP data from client: " + Encoding.ASCII.GetString(bytes, 0, i) + "\r\n";
                                    else txtReceived.Text = Utilities.getCurrDate() + " - Received sensor data from Teensy with transmit ID: " + sensorNetwork.getTransmitId() + "\r\n";
                                }

                                if (totalPackets == 1) lblFirstReceived.Text = " First received: " + Utilities.getCurrDate();
                                lblDate.Text = "  Last received: " + Utilities.getCurrDate();
                                lblTotalReceived.Text = " Total received: " + totalPackets;

                                if (totalPackets > 1)
                                { // TODO: Convert these to hours, minutes, seconds, milliseconds instead of just ms
                                    lblLowGap.Text = " Low packet gap: " + lowPacketGap;
                                    lblAvgGap.Text = "Avg. packet gap: " + avgPacketGap;
                                    lblHighPacketGap.Text = "High packet gap: " + highPacketGap;
                                    lblLastGap.Text = "Last packet gap: " + lastPacketGap;
                                }

                                // Print the sensor data out on the UI
                                if (radSensorData.Checked)
                                {
                                    // Check the temp unit
                                    TemperatureUnitEnum tempUnit = TemperatureUnitEnum.NONE;
                                    if (radCelsius.Checked) tempUnit = TemperatureUnitEnum.CELSIUS;
                                    else if (radFahrenheit.Checked) tempUnit = TemperatureUnitEnum.FAHRENHEIT;
                                    else if (radKelvin.Checked) tempUnit = TemperatureUnitEnum.KELVIN;
                                    string tempUnitSym = $"\u00B0{tempUnit.ToString().ToCharArray()[0]}";

                                    SensorData sensorData = sensorNetwork.getLatestSensorData(tempUnit);
                                    if(chkElTemp1Init.Checked) lblEl1Temp.Text = $"Elevation Temperature 1: {sensorData.elTemp1} {tempUnitSym}";
                                    if(chkAzTemp1Init.Checked) lblAz1Temp.Text = $"Azimuth Temperature 1: {sensorData.azTemp1} {tempUnitSym}";
                                    if(chkAzAdxlInit.Checked) lblAzAdxl.Text = "Azimuth accelerometer data:\n" +
                                                        $"     X: {sensorData.azAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.azAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.azAdxlData.zAxis}";
                                    if(chkElAdxlInit.Checked) lblElAdxl.Text = "Elevation accelerometer data:\n" +
                                                        $"     X: {sensorData.elAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.elAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.elAdxlData.zAxis}";
                                    if(chkCbAdxlInit.Checked) lblCbAdxl.Text = "Counterbalance accelerometer data:\n" +
                                                        $"     X: {sensorData.cbAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.cbAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.cbAdxlData.zAxis}";

                                    if(chkAzEncInit.Checked) lblCurrAz.Text = $"Current azimuth position: {sensorData.orientation.Azimuth}";
                                    if(chkElEncInit.Checked) lblCurrEl.Text = $"Current elevation position: {sensorData.orientation.Elevation}";
                                }
                            });
                        }
                    }

                    localClient.Close();
                    localClient.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
        }

        private void lblKillListen_Click(object sender, EventArgs e)
        {
            server.Stop();
            runListenerThread = false;
            listenerThread.Join();
            lblListenRunning.Text = "Not running.";
            lblListenConnected.Text = "Not connected.";
            btnStartListen.Enabled = true;
            btnKillListen.Enabled = false;
            radSensorData.Enabled = true;
            radTCPData.Enabled = true;

            txtListenIp.Enabled = true;
            txtListenPort.Enabled = true;


            if (radSensorData.Checked)
            {
                txtClientIp.Enabled = true;
                txtClientPort.Enabled = true;
                btnStartClient.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Numeric statistics
            lastPacketGap = 0;
            lowPacketGap = long.MaxValue;
            avgPacketGap = 0;
            highPacketGap = 0;
            totalPacketGap = 0;
            totalPackets = 0;

            // UI statistics
            lblFirstReceived.Text = " First received: N/A";
            lblDate.Text = "  Last received: N/A";
            lblTotalReceived.Text = " Total received: N/A";
            lblLowGap.Text = " Low packet gap: N/A";
            lblAvgGap.Text = "Avg. packet gap: N/A";
            lblHighPacketGap.Text = "High packet gap: N/A";
            lblLastGap.Text = "Last packet gap: N/A";
            txtReceived.Text = "";

            // Data
            lblEl1Temp.Text = $"Elevation Temperature 1: N/A";
            lblAz1Temp.Text = $"Azimuth Temperature 1: N/A";
            lblAzAdxl.Text = "Azimuth accelerometer data:\n" +
                                                        $"     X: N/A\n" +
                                                        $"     Y: N/A\n" +
                                                        $"     Z: N/A";
            lblElAdxl.Text = "Elevation accelerometer data:\n" +
                                                        $"     X: N/A\n" +
                                                        $"     Y: N/A\n" +
                                                        $"     Z: N/A";
            lblCbAdxl.Text = "Counterbalance accelerometer data:\n" +
                                                        $"     X: N/A\n" +
                                                        $"     Y: N/A\n" +
                                                        $"     Z: N/A";

            lblCurrAz.Text = $"Current azimuth position: N/A";
            lblCurrEl.Text = $"Current elevation position: N/A";

            // Stopwatch
            if (stopWatch.IsRunning) stopWatch.Stop();
            stopWatch.Reset();
        }

        private void frmTcpTest_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 1);

            PointF p1 = new PointF(470, 10);
            PointF p2 = new PointF(470, this.Size.Height - 50);

            e.Graphics.DrawLine(pen, p1, p2);
        }

        private void radTCPData_CheckedChanged(object sender, EventArgs e)
        {
            if (radTCPData.Checked)
            {
                this.Size = new Size(493, this.Size.Height);
                btnStartClient.Enabled = true;
                btnStartClient.Text = "Send Data";
                txtClientData.Enabled = true;
            }
        }

        private void radSensorData_CheckedChanged(object sender, EventArgs e)
        {
            if (radSensorData.Checked)
            {
                this.Size = new Size(970, this.Size.Height);
                btnStartClient.Enabled = false;
                btnStartClient.Text = "Update Init Settings";
                txtClientData.Enabled = false;
            }
        }

        private bool CheckIfSensorInitHasChanged()
        {
            // If the sensorInit byte array is equal to the checkboxes, the sensor init has not changed
            if (Convert.ToBoolean(sensorInit[0]) == chkElTemp1Init.Checked &&
                    Convert.ToBoolean(sensorInit[1]) == chkElTemp2Init.Checked &&
                    Convert.ToBoolean(sensorInit[2]) == chkAzTemp1Init.Checked &&
                    Convert.ToBoolean(sensorInit[3]) == chkAzTemp2Init.Checked &&
                    Convert.ToBoolean(sensorInit[4]) == chkElEncInit.Checked &&
                    Convert.ToBoolean(sensorInit[5]) == chkAzEncInit.Checked &&
                    Convert.ToBoolean(sensorInit[6]) == chkAzAdxlInit.Checked &&
                    Convert.ToBoolean(sensorInit[7]) == chkElAdxlInit.Checked &&
                    Convert.ToBoolean(sensorInit[8]) == chkCbAdxlInit.Checked)
            {
                lblSensorInitChanged.Text = "";
                return false;
            }

            lblSensorInitChanged.Text = "Sensor initialization changed.\n";
            if (runListenerThread) lblSensorInitChanged.Text += "Please click \"Update Sensor Init\" to update.";
            else lblSensorInitChanged.Text += "Connect to the Teensy to update.";
            return true;
            
        }

        private void chkElTemp1Init_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkElTemp2Init_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkAzTemp1Init_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkAzTemp2Init_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkElAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkAzAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkCbAdxlInit_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkElEncInit_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void chkAzEncInit_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void addToUiConsole(string text)
        {
            txtReceived.AppendText(Utilities.getCurrDate() + "; " + text + "\r\n");
        }

        private void btnCustPacket_Click(object sender, EventArgs e)
        {
            frmCustomPacket customPacketWindow = new frmCustomPacket(txtListenIp.Text, int.Parse(txtListenPort.Text));
            Thread newFormThread = new Thread(() => { customPacketWindow.ShowDialog(); });
            newFormThread.Start();
        }

        private void btnCsvDrawing_Click(object sender, EventArgs e)
        {
            frmDataDrawer dataDrawerWindow = new frmDataDrawer();
            Thread newFormThread = new Thread(() => { dataDrawerWindow.ShowDialog(); });
            newFormThread.Start();
        }
    }
}
