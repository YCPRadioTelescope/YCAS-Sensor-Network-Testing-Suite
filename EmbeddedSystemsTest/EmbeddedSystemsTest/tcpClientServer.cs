using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public frmTcpTest()
        {
            InitializeComponent();

            runListenerThread = false;

            //Set default values
            txtListenIp.Text = "192.168.0.10";
            txtListenPort.Text = "1600";
            txtClientIp.Text = "192.168.0.197";
            txtClientPort.Text = "1680";
            txtClientData.Text = "Test";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

                listenerThread = new Thread(() => listenerProcess(IPAddress.Parse(txtListenIp.Text), int.Parse(txtListenPort.Text)));
                listenerThread.Start();
            }
            else MessageBox.Show(errorStr, "Errors");
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            string errorStr = "";
            if (!Validator.ipValid(txtClientIp.Text)) errorStr += "Client IP address is invalid\n";
            if (!Validator.isPort(txtClientPort.Text)) errorStr += "Client port is invalid\n";
            //if (errorStr.Equals("") && !Validator.clientIpExists(txtClientIp.Text, int.Parse(txtClientPort.Text))) errorStr += $"Could not find server at {txtClientIp.Text}:{txtClientPort.Text}\n";
            if (txtClientData.Text.Equals("")) errorStr += "No data is present\n";
            if (errorStr.Equals(""))
            {
                clientThread = new Thread(() => clientProcess(txtClientIp.Text, 
                                                                int.Parse(txtClientPort.Text), 
                                                                Encoding.ASCII.GetBytes(txtClientData.Text)));
                clientThread.Start();
            }
            else MessageBox.Show(errorStr, "Error");
        }

        private void clientProcess(string addr, int port, byte[] data) {
            client = new TcpClient(addr, port);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            int bytes = stream.Read(data, 0, data.Length);
            string response = Encoding.ASCII.GetString(data, 0, bytes);

            Utilities.writeToTextFromThread(this, txtResponse, response, chkAccumulateClient.Checked);

            stream.Close();
            stream.Dispose();
            client.Close();
            client.Dispose();
        }

        private void listenerProcess(IPAddress addr, int port) {
            server = new TcpListener(addr, port);
            server.Start();
            runListenerThread = true;


            while(runListenerThread)
            {
                TcpClient localClient;
                NetworkStream stream;

                try { 
                    
                    localClient = server.AcceptTcpClient();
                    Utilities.writeToLabelFromThread(this, lblListenConnected, "Received data.");
                    stream = localClient.GetStream();

                    // Reads NetworkStream into a byte buffer.
                    byte[] bytes = new byte[localClient.ReceiveBufferSize];

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {

                        StringBuilder displayText = new StringBuilder();
                        //stream.Write(bytes, 0, bytes.Length);
                        string transmitID = bytes[0].ToString();
                        UInt32 dataSize = (UInt32)(bytes[1] << 24 | bytes[2] << 16 | bytes[3] << 8 | bytes[4]);
                        UInt16 elAdxlSize = (UInt16)(bytes[5] << 8 | bytes[6]);
                        UInt16 azAdxlSize = (UInt16)(bytes[7] << 8 | bytes[8]);
                        UInt16 cbAdxlSize = (UInt16)(bytes[9] << 8 | bytes[10]);
                        UInt16 elTempSensorSize = (UInt16)(bytes[11] << 8 | bytes[12]);
                        UInt16 azTempSensorSize = (UInt16)(bytes[13] << 8 | bytes[14]);
                        UInt16 elEncoderSize = (UInt16)(bytes[15] << 8 | bytes[16]);
                        UInt16 azEncoderSize = (UInt16)(bytes[17] << 8 | bytes[18]);

                        /*
                        int k = 0;

                        int test;
                        for(int j = 0; j < dataSize; j++)
                        {
                            //test = (bytes[k++] << 8 | bytes[k++]);
                            displayText.AppendFormat("{0:x2}",bytes[k++]);
                            displayText.Append(" ");
                            if (k % 10 == 0)
                            {
                                displayText.AppendLine();
                            }
                        }
                        File.WriteAllText("SensorData.txt",displayText.ToString());
                        */
                        if (i >= dataSize)
                        {
                            int k = 19;
                            AdxlData[] elAdxlData = new AdxlData[elAdxlSize];
                            for (int j = 0; j < elAdxlSize; j++)
                            {
                                elAdxlData[j] = new AdxlData()
                                {
                                    xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                                };

                            }

                            AdxlData[] azAdxlData = new AdxlData[azAdxlSize];
                            for (int j = 0; j < azAdxlSize; j++)
                            {
                                azAdxlData[j] = new AdxlData()
                                {
                                    xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                                };

                            }

                            AdxlData[] cbAdxlData = new AdxlData[cbAdxlSize];
                            for (int j = 0; j < cbAdxlSize; j++)
                            {
                                cbAdxlData[j] = new AdxlData()
                                {
                                    xAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    yAxis = (short)(bytes[k++] << 8 | bytes[k++]),
                                    zAxis = (short)(bytes[k++] << 8 | bytes[k++])
                                };

                            }

                            int[] elTempData = new int[elTempSensorSize];
                            for (int j = 0; j < elTempSensorSize; j++)
                            {
                                elTempData[j] = (bytes[k++] << 8 | bytes[k++]);

                            }

                            int[] azTempData = new int[azTempSensorSize];
                            for (int j = 0; j < azTempSensorSize; j++)
                            {
                                azTempData[j] = (bytes[k++] << 8 | bytes[k++]);

                            }

                            int[] elEncoderData = new int[elEncoderSize];
                            for (int j = 0; j < azTempSensorSize; j++)
                            {
                                elEncoderData[j] = (bytes[k++] << 8 | bytes[k++]);

                            }

                            int[] azEncoderData = new int[azEncoderSize];
                            for (int j = 0; j < azTempSensorSize; j++)
                            {
                                azEncoderData[j] = (bytes[k++] << 8 | bytes[k++]);

                            }

                        }
                        Utilities.writeToTextFromThread(this, txtReceived, transmitID, chkAccumulateServer.Checked);
                        Utilities.writeToLabelFromThread(this, lblDate, "Last received: " + DateTime.Now.ToString("dd MMMM yyyy; hh:mm:ss"));
                    }

                    localClient.Close();
                    localClient.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
                catch(Exception ex) {

                    Console.WriteLine(ex.Message);
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceived.Text = "";
        }

        private void btnClearAllResponses_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "";
        }
    }
    public class AdxlData
    {
        public short xAxis { get; set; }
        public short yAxis { get; set; }
        public short zAxis { get; set; }

    }
}
