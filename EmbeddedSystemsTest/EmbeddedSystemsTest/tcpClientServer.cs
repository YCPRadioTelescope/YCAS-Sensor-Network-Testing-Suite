﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int totalPackets;
        private static System.Timers.Timer timer;

        Thread clientThread;
        TcpClient client;

        public frmTcpTest()
        {
            InitializeComponent();

            runListenerThread = false;
            totalPackets = 0;
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
            if (errorStr.Equals("") && !Validator.clientIpExists(txtClientIp.Text, int.Parse(txtClientPort.Text))) errorStr += $"Could not find server at {txtClientIp.Text}:{txtClientPort.Text}\n";
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
            Utilities.WriteToGUIFromThread(this, () =>
            {
                if (chkAccumulateClient.Checked) txtResponse.Text = txtResponse.Text + response + "\r\n";
                else txtResponse.Text = response;
            });

            stream.Close();
            stream.Dispose();
            client.Close();
            client.Dispose();
        }

        private void listenerProcess(IPAddress addr, int port) {
            server = new TcpListener(addr, port);
            server.Start();
            runListenerThread = true;

            byte[] bytes = new byte[256];

            while(runListenerThread)
            {
                TcpClient localClient;
                NetworkStream stream;

                try { 
                    
                    localClient = server.AcceptTcpClient();
                    Utilities.WriteToGUIFromThread(this, () => 
                    {
                        lblListenConnected.Text = "Received data.";
                    });
                    stream = localClient.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        totalPackets++;
                        stream.Write(bytes, 0, bytes.Length);

                        Utilities.WriteToGUIFromThread(this, () =>
                        {
                            if (chkAccumulateServer.Checked) txtReceived.Text = txtReceived.Text + Encoding.ASCII.GetString(bytes, 0, i) + "\r\n";
                            else txtReceived.Text = Encoding.ASCII.GetString(bytes, 0, i);
                            if (totalPackets == 1) lblFirstReceived.Text = "First received: " + DateTime.Now.ToString("dd MMMM yyyy; hh:mm:ss");
                            lblDate.Text = "Last received:   " + DateTime.Now.ToString("dd MMMM yyyy; hh:mm:ss");
                            lblTotalReceived.Text = "Total received:  " + totalPackets;
                        });
                    }

                    localClient.Close();
                    localClient.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
                catch (Exception e) { /*Console.WriteLine(e);*/ }
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
            totalPackets = 0;
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
}
