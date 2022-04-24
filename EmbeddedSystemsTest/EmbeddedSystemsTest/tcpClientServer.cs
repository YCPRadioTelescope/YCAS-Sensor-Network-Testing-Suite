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

        bool logData = false;
        bool logSelfTest = true;
        bool setFanOnOff = false;
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

            comboElSamplingSpeed.Text = "800";
            comboElGRange.Text = "±16";

            comboAzSamplingSpeed.Text = "800";
            comboAzGRange.Text = "±16";

            comboCbSamplingSpeed.Text = "800";
            comboCbGRange.Text = "±16";

            // Init the sensor initialization w/ checkboxes
            sensorInit = GetBytesFromInitCheckboxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // FOR TESTING PURPOSES ONLY!!!
            // This is so we don't have to keep typing stuff in
            txtListenIp.Text = "192.168.0.10";
            txtListenPort.Text = "1600";
            txtClientIp.Text = "192.168.0.197";
            txtClientPort.Text = "1680";

            txtDataFileName.Text = "SensorData";

            lsbErrorLogging.Items.AddRange(new string[] {
                "Elevation ADXL Self-Test:",
                "Azimuth ADXL Self-Test:",
                "Counterbalance ADXL Self-Test:",
                "Elevation ADXL Error:",
                "Azimuth ADXL Error:",
                "Counterbalance ADXL Error:",
                "Azimuth Encoder Error:",
                "Elevation Temp1 Error:",
                "Elevation Temp2 Error:",
                "Azimuth Temp1 Error:",
                "Azimuth Temp2 Error:",
                "Ambient Temp and Humidity Error:"
            });
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

                if (radSensorData.Checked)
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

        private void clientProcess(string addr, int port, byte[] data)
        {
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

        private void listenerProcess(IPAddress addr, int port)
        {
            server = new TcpListener(addr, port);
            server.Start();
            runListenerThread = true;

            TcpClient localClient;
            NetworkStream stream;

            byte[] bytes = new byte[2048];

            while (runListenerThread)
            {

                try
                {

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
                        if (!radSensorData.Checked) stream.Write(bytes, 0, bytes.Length);

                        if (Encoding.ASCII.GetString(bytes, 0, i).Equals("Send Sensor Configuration") && radSensorData.Checked)
                        {
                            logSelfTest = true; // embeded system is initializing so we want to know the result of the self tests
                            // Convert all sensor init checkboxes into byte array
                            sensorInit = GetBytesFromInitCheckboxes();

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

                            stream.WriteByte(Convert.ToByte(setFanOnOff));

                            // Interpret received data
                            sensorNetwork.ParseSensorData(bytes, i, logData, txtDataFileName.Text);

                            // Write all the information to the GUI                                            
                            Utilities.WriteToGUIFromThread(this, () =>
                            {
                                if (chkAccumulateServer.Checked)
                                {
                                    if (!radSensorData.Checked) addToUiConsole("Received TCP data from client: " + Encoding.ASCII.GetString(bytes, 0, i));
                                    else if (totalPackets == 1) addToUiConsole("Currently receiving sensor data from Teensy with transmit ID: " + sensorNetwork.getTransmitId());
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
                                    if (chkElTemp1Init.Checked)
                                    {
                                        lblEl1Temp.Text = $"Elevation Temperature 1: {sensorData.elTemp1} {tempUnitSym}";
                                        lblElTempSensor1Status.Text = $"Elevation Temperature 1: {sensorData.elTemp1Status}";
                                        lblElTempSensor2Status.Text = $"Elevation Temperature 2: {sensorData.elTemp2Status}";
                                    }
                                    if (chkAzTemp1Init.Checked)
                                    {
                                        lblAz1Temp.Text = $"Azimuth Temperature 1: {sensorData.azTemp1} {tempUnitSym}";
                                        lblAzTempSensor1Status.Text = $"Azimuth Temperature 1: {sensorData.azTemp1Status}";
                                        lblAzTempSensor2Status.Text = $"Azimuth Temperature 2: {sensorData.azTemp2Status}";
                                    }
                                    if (chkAzAdxlInit.Checked)
                                    {
                                        lblAzAdxl.Text = "Azimuth accelerometer data:\n" +
                                                        $"     X: {sensorData.azAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.azAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.azAdxlData.zAxis}";
                                        lblAzAccStatus.Text = $"Azimuth Accelerometer: {sensorData.azAdxlStatus}";
                                    }
                                    if (chkElAdxlInit.Checked)
                                    {
                                        lblElAdxl.Text = "Elevation accelerometer data:\n" +
                                                        $"     X: {sensorData.elAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.elAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.elAdxlData.zAxis}";
                                        lblElAccStatus.Text = $"Elevation Accelerometer: {sensorData.elAdxlStatus}";
                                    }
                                    if (chkCbAdxlInit.Checked)
                                    {
                                        lblCbAdxl.Text = "Counterbalance accelerometer data:\n" +
                                                        $"     X: {sensorData.cbAdxlData.xAxis}\n" +
                                                        $"     Y: {sensorData.cbAdxlData.yAxis}\n" +
                                                        $"     Z: {sensorData.cbAdxlData.zAxis}";
                                        lblCbAccStatus.Text = $"Counterbalance Accelerometer: {sensorData.cbAdxlStatus}";
                                    }
                                    if (chkAzEncInit.Checked)
                                    {
                                        lblCurrAz.Text = $"Current azimuth position: {sensorData.orientation.Azimuth}";
                                        lblAzEncoderStatus.Text = $"Azimuth Encoder: {sensorData.azEncoderStatus}";
                                    }
                                    if (chkElEncInit.Checked)
                                    {
                                        lblCurrEl.Text = $"Current elevation position: {sensorData.orientation.Elevation}";
                                    }
                                    if (chkAmbTempHumid.Checked)
                                    {
                                        lblAmbientTemp.Text = $"Ambient Temperature: {sensorData.ambTemp} {tempUnitSym}";
                                        lblAmbientHumidity.Text = $"Ambient Humidity: {sensorData.ambHumidity} %";
                                        lblAmbTempHumidStatus.Text = $"Ambient Temp and Humidity: {sensorData.ambTempHumidityStatus}";
                                    }
                                    if (ckbLogErrors.Checked)
                                    {
                                        // Only log the self test status once since it is only done during the initialization of the embedded system
                                        if (logSelfTest)
                                        {
                                            logSelfTest = false;
                                            lsbErrorLogging.Items[0] = ($"Elevation ADXL Self-Test: {sensorData.adxlSelfTestState[(int)AdxlSensors.ELEVATION].ToString()}" + "\r\n");
                                            lsbErrorLogging.Items[1] = ($"Azimuth ADXL Self-Test: {sensorData.adxlSelfTestState[(int)AdxlSensors.AZIMUTH].ToString()}" + "\r\n");
                                            lsbErrorLogging.Items[2] = ($"Counterbalance ADXL Self-Test: {sensorData.adxlSelfTestState[(int)AdxlSensors.COUNTERBALANCE].ToString()}" + "\r\n");
                                        }
                                        lsbErrorLogging.Items[3] = ($"Elevation ADXL Error: {sensorData.adxlErrors[(int)AdxlSensors.ELEVATION].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[4] = ($"Azimuth ADXL Error: {sensorData.adxlErrors[(int)AdxlSensors.AZIMUTH].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[5] = ($"Counterbalance ADXL Error: {sensorData.adxlErrors[(int)AdxlSensors.COUNTERBALANCE].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[6] = ($"Azimuth Encoder Error: {sensorData.azEncderError.ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[7] = ($"Elevation Temp1 Error: {sensorData.temperatureErrors[(int)TemperatureSensors.ELEVATION1].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[8] = ($"Elevation Temp2 Error: {sensorData.temperatureErrors[(int)TemperatureSensors.ELEVATION2].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[9] = ($"Azimuth Temp1 Error: {sensorData.temperatureErrors[(int)TemperatureSensors.AZIMUTH1].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[10] = ($"Azimuth Temp2 Error: {sensorData.temperatureErrors[(int)TemperatureSensors.AZIMUTH2].ToString()}" + "\r\n");

                                        lsbErrorLogging.Items[11] = ($"Ambient Temp and Humidity Error: {sensorData.ambientTempHumidityError.ToString()}" + "\r\n");

                                    }

                                    lblFanState.Text = $"Fan State: {sensorData.isFanOn} %";
                                }
                            });
                        }
                    }

                    localClient.Close();
                    localClient.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
                catch (Exception e)
                {
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

            lblAmbientTemp.Text = $"Ambient Temperature: N/A";
            lblAmbientHumidity.Text = $"Ambient Humidity: N/A";

            lblFanState.Text = $"Fan State: N/A";

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
                this.Size = new Size(493, 430);
                btnStartClient.Enabled = true;
                btnStartClient.Text = "Send Data";
                txtClientData.Enabled = true;
            }
        }

        private void radSensorData_CheckedChanged(object sender, EventArgs e)
        {
            if (radSensorData.Checked)
            {
                this.Size = new Size(970, 738);
                btnStartClient.Enabled = false;
                btnStartClient.Text = "Update Init Settings";
                txtClientData.Enabled = false;
            }
        }

        private bool CheckIfSensorInitHasChanged()
        {
            // If the sensorInit byte array is equal to the checkboxes, the sensor init has not changed
            if (
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.ElevationTemp]) == chkElTemp1Init.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.AzimuthTemp]) == chkAzTemp1Init.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.ElevationEncoder]) == chkElEncInit.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.AzimuthEncoder]) == chkAzEncInit.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.AzimuthAccelerometer]) == chkAzAdxlInit.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.ElevationAccelerometer]) == chkElAdxlInit.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.CounterbalanceAccelerometer]) == chkCbAdxlInit.Checked &&
                    Convert.ToBoolean(sensorInit[(int)SensorInitializationEnum.AmbientTempAndHumidity]) == chkAmbTempHumid.Checked
               )
            {
                lblSensorInitChanged.Text = "";
                return false;
            }

            lblSensorInitChanged.Text = "Sensor initialization changed.\n";
            if (runListenerThread) lblSensorInitChanged.Text += "Please click \"Update Sensor Init\" to update.";
            else lblSensorInitChanged.Text += "Connect to the Teensy to update.";
            return true;

        }

        private byte[] GetBytesFromInitCheckboxes()
        {
            byte[] init = new byte[] {
                chkElTemp1Init.Checked ?    (byte)1 : (byte)0,
                chkAzTemp1Init.Checked ?    (byte)1 : (byte)0,
                chkElEncInit.Checked ?      (byte)1 : (byte)0,
                chkAzEncInit.Checked ?      (byte)1 : (byte)0,
                chkAzAdxlInit.Checked ?     (byte)1 : (byte)0,
                chkElAdxlInit.Checked ?     (byte)1 : (byte)0,
                chkCbAdxlInit.Checked ?     (byte)1 : (byte)0,
                chkAmbTempHumid.Checked ?   (byte)1 : (byte)0
            };

            // Build rest of init packet
            init = init.Concat(BitConverter.GetBytes(int.Parse(txtTimerPeriod.Text)))
                .Concat(BitConverter.GetBytes(int.Parse(txtEthernetPeriod.Text)))
                .Concat(BitConverter.GetBytes(int.Parse(txtTempPeriod.Text)))
                .Concat(BitConverter.GetBytes(int.Parse(txtEncoderPeriod.Text)))
                .ToArray();

            byte samplingFrequency = 0, gRange = 0;

            switch (int.Parse(comboElSamplingSpeed.Text))
            {
                case 800:
                    samplingFrequency = 0xD;
                    break;

                case 400:
                    samplingFrequency = 0xC;
                    break;

                case 200:
                    samplingFrequency = 0xB;
                    break;

                case 100:
                    samplingFrequency = 0xA;
                    break;

                case 50:
                    samplingFrequency = 0x9;
                    break;

                case 25:
                    samplingFrequency = 0x8;
                    break;
            }

            switch (int.Parse(comboElGRange.Text.Substring(1)))
            {
                case 16:
                    gRange = 0x3;
                    break;

                case 8:
                    gRange = 0x2;
                    break;

                case 4:
                    gRange = 0x1;
                    break;

                case 2:
                    gRange = 0x0;
                    break;
            }

            init = init.Concat(new byte[]
            {
                samplingFrequency,
                gRange,
                (byte)(numElFIFOSize.Value - 1),
                (byte)int.Parse(txtElX.Text),
                (byte)int.Parse(txtElX.Text),
                (byte)int.Parse(txtElX.Text),
                BitConverter.GetBytes(chkElBitResolution.Checked)[0]
            }).ToArray();

            switch (int.Parse(comboAzSamplingSpeed.Text))
            {
                case 800:
                    samplingFrequency = 0xD;
                    break;

                case 400:
                    samplingFrequency = 0xC;
                    break;

                case 200:
                    samplingFrequency = 0xB;
                    break;

                case 100:
                    samplingFrequency = 0xA;
                    break;

                case 50:
                    samplingFrequency = 0x9;
                    break;

                case 25:
                    samplingFrequency = 0x8;
                    break;
            }

            switch (int.Parse(comboAzGRange.Text.Substring(1)))
            {
                case 16:
                    gRange = 0x3;
                    break;

                case 8:
                    gRange = 0x2;
                    break;

                case 4:
                    gRange = 0x1;
                    break;

                case 2:
                    gRange = 0x0;
                    break;
            }

            init = init.Concat(new byte[]
            {
                samplingFrequency,
                gRange,
                (byte)(numAzFIFOSize.Value - 1),
                (byte)int.Parse(txtAzX.Text),
                (byte)int.Parse(txtAzX.Text),
                (byte)int.Parse(txtAzX.Text),
                BitConverter.GetBytes(chkAzBitResolution.Checked)[0]
            }).ToArray();

            switch (int.Parse(comboCbSamplingSpeed.Text))
            {
                case 800:
                    samplingFrequency = 0xD;
                    break;

                case 400:
                    samplingFrequency = 0xC;
                    break;

                case 200:
                    samplingFrequency = 0xB;
                    break;

                case 100:
                    samplingFrequency = 0xA;
                    break;

                case 50:
                    samplingFrequency = 0x9;
                    break;

                case 25:
                    samplingFrequency = 0x8;
                    break;
            }

            switch (int.Parse(comboCbGRange.Text.Substring(1)))
            {
                case 16:
                    gRange = 0x3;
                    break;

                case 8:
                    gRange = 0x2;
                    break;

                case 4:
                    gRange = 0x1;
                    break;

                case 2:
                    gRange = 0x0;
                    break;
            }

            init = init.Concat(new byte[]
            {
                samplingFrequency,
                gRange,
                (byte)(numCbFIFOSize.Value - 1),
                (byte)int.Parse(txtCbX.Text),
                (byte)int.Parse(txtCbX.Text),
                (byte)int.Parse(txtCbX.Text),
                BitConverter.GetBytes(chkCbBitResolution.Checked)[0]
            }).ToArray();

            return init;
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
            frmCustomPacket customPacketWindow = new frmCustomPacket(txtListenIp.Text, int.Parse(txtListenPort.Text), btnCustPacket, this);
            Thread newFormThread = new Thread(() => { customPacketWindow.ShowDialog(); });
            newFormThread.Start();
            btnCustPacket.Enabled = false;
        }

        private void btnCsvDrawing_Click(object sender, EventArgs e)
        {
            frmDataDrawer dataDrawerWindow = new frmDataDrawer(btnCsvDrawing, this);
            Thread newFormThread = new Thread(() => { dataDrawerWindow.ShowDialog(); });
            newFormThread.Start();
            btnCsvDrawing.Enabled = false;
        }

        private void btnStartDataLogging_Click(object sender, EventArgs e)
        {
            btnStartDataLogging.Enabled = false;
            btnStopLogging.Enabled = true;
            logData = true;
            txtDataFileName.Enabled = false;
        }

        private void btnStopLogging_Click(object sender, EventArgs e)
        {
            btnStartDataLogging.Enabled = true;
            btnStopLogging.Enabled = false;
            logData = false;
            txtDataFileName.Enabled = true;

        }

        private void chkAmbTempHumid_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfSensorInitHasChanged();
        }

        private void btnFanToggle_Click(object sender, EventArgs e)
        {
            setFanOnOff = !sensorNetwork.getLatestSensorData(TemperatureUnitEnum.FAHRENHEIT).isFanOn;
        }
    }
}
