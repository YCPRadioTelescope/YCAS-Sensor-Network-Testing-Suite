
namespace EmbeddedSystemsTest
{
    partial class frmTcpTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTcpTest));
            this.btnStartListen = new System.Windows.Forms.Button();
            this.btnKillListen = new System.Windows.Forms.Button();
            this.txtListenIp = new System.Windows.Forms.TextBox();
            this.lblListenIp = new System.Windows.Forms.Label();
            this.lblListenRunning = new System.Windows.Forms.Label();
            this.lblListenPort = new System.Windows.Forms.Label();
            this.txtListenPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblClientIp = new System.Windows.Forms.Label();
            this.txtClientIp = new System.Windows.Forms.TextBox();
            this.btnStartClient = new System.Windows.Forms.Button();
            this.txtClientData = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.lblReceived = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkAccumulateServer = new System.Windows.Forms.CheckBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblLastGap = new System.Windows.Forms.Label();
            this.lblHighPacketGap = new System.Windows.Forms.Label();
            this.lblAvgGap = new System.Windows.Forms.Label();
            this.lblLowGap = new System.Windows.Forms.Label();
            this.lblTotalReceived = new System.Windows.Forms.Label();
            this.lblFirstReceived = new System.Windows.Forms.Label();
            this.lblSensorData = new System.Windows.Forms.Label();
            this.radTCPData = new System.Windows.Forms.RadioButton();
            this.radSensorData = new System.Windows.Forms.RadioButton();
            this.lblEl1Temp = new System.Windows.Forms.Label();
            this.lblAz1Temp = new System.Windows.Forms.Label();
            this.lblAzAdxl = new System.Windows.Forms.Label();
            this.lblElAdxl = new System.Windows.Forms.Label();
            this.lblCbAdxl = new System.Windows.Forms.Label();
            this.lblCurrOrientation = new System.Windows.Forms.Label();
            this.grpTempUnit = new System.Windows.Forms.GroupBox();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.radKelvin = new System.Windows.Forms.RadioButton();
            this.grpSensorInit = new System.Windows.Forms.GroupBox();
            this.chkAzEncInit = new System.Windows.Forms.CheckBox();
            this.chkElEncInit = new System.Windows.Forms.CheckBox();
            this.chkCbAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkElAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzTemp2Init = new System.Windows.Forms.CheckBox();
            this.chkAzTemp1Init = new System.Windows.Forms.CheckBox();
            this.chkElTemp2Init = new System.Windows.Forms.CheckBox();
            this.chkElTemp1Init = new System.Windows.Forms.CheckBox();
            this.lblListenConnected = new System.Windows.Forms.Label();
            this.grpStats.SuspendLayout();
            this.grpTempUnit.SuspendLayout();
            this.grpSensorInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartListen
            // 
            this.btnStartListen.Location = new System.Drawing.Point(11, 53);
            this.btnStartListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(104, 21);
            this.btnStartListen.TabIndex = 2;
            this.btnStartListen.Text = "Start Listening";
            this.btnStartListen.UseVisualStyleBackColor = true;
            this.btnStartListen.Click += new System.EventHandler(this.lblStartListen_Click);
            // 
            // btnKillListen
            // 
            this.btnKillListen.Enabled = false;
            this.btnKillListen.Location = new System.Drawing.Point(120, 53);
            this.btnKillListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnKillListen.Name = "btnKillListen";
            this.btnKillListen.Size = new System.Drawing.Size(104, 21);
            this.btnKillListen.TabIndex = 9;
            this.btnKillListen.Text = "Stop Listening";
            this.btnKillListen.UseVisualStyleBackColor = true;
            this.btnKillListen.Click += new System.EventHandler(this.lblKillListen_Click);
            // 
            // txtListenIp
            // 
            this.txtListenIp.Location = new System.Drawing.Point(124, 5);
            this.txtListenIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtListenIp.Name = "txtListenIp";
            this.txtListenIp.Size = new System.Drawing.Size(101, 20);
            this.txtListenIp.TabIndex = 0;
            // 
            // lblListenIp
            // 
            this.lblListenIp.AutoSize = true;
            this.lblListenIp.Location = new System.Drawing.Point(9, 7);
            this.lblListenIp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListenIp.Name = "lblListenIp";
            this.lblListenIp.Size = new System.Drawing.Size(111, 13);
            this.lblListenIp.TabIndex = 3;
            this.lblListenIp.Text = "IP address to listen to:";
            // 
            // lblListenRunning
            // 
            this.lblListenRunning.AutoSize = true;
            this.lblListenRunning.Location = new System.Drawing.Point(14, 74);
            this.lblListenRunning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListenRunning.Name = "lblListenRunning";
            this.lblListenRunning.Size = new System.Drawing.Size(65, 13);
            this.lblListenRunning.TabIndex = 4;
            this.lblListenRunning.Text = "Not running.";
            // 
            // lblListenPort
            // 
            this.lblListenPort.AutoSize = true;
            this.lblListenPort.Location = new System.Drawing.Point(9, 29);
            this.lblListenPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListenPort.Name = "lblListenPort";
            this.lblListenPort.Size = new System.Drawing.Size(80, 13);
            this.lblListenPort.TabIndex = 5;
            this.lblListenPort.Text = "Port to listen to:";
            // 
            // txtListenPort
            // 
            this.txtListenPort.Location = new System.Drawing.Point(124, 27);
            this.txtListenPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtListenPort.Name = "txtListenPort";
            this.txtListenPort.Size = new System.Drawing.Size(101, 20);
            this.txtListenPort.TabIndex = 1;
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(362, 27);
            this.txtClientPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(101, 20);
            this.txtClientPort.TabIndex = 4;
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(247, 29);
            this.lblClientPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(57, 13);
            this.lblClientPort.TabIndex = 12;
            this.lblClientPort.Text = "Client port:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(247, 51);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data:";
            // 
            // lblClientIp
            // 
            this.lblClientIp.AutoSize = true;
            this.lblClientIp.Location = new System.Drawing.Point(247, 7);
            this.lblClientIp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientIp.Name = "lblClientIp";
            this.lblClientIp.Size = new System.Drawing.Size(89, 13);
            this.lblClientIp.TabIndex = 10;
            this.lblClientIp.Text = "Client IP address:";
            // 
            // txtClientIp
            // 
            this.txtClientIp.Location = new System.Drawing.Point(362, 5);
            this.txtClientIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientIp.Name = "txtClientIp";
            this.txtClientIp.Size = new System.Drawing.Size(101, 20);
            this.txtClientIp.TabIndex = 3;
            // 
            // btnStartClient
            // 
            this.btnStartClient.Enabled = false;
            this.btnStartClient.Location = new System.Drawing.Point(354, 72);
            this.btnStartClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(108, 21);
            this.btnStartClient.TabIndex = 6;
            this.btnStartClient.Text = "Update Sensor Init";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // txtClientData
            // 
            this.txtClientData.Enabled = false;
            this.txtClientData.Location = new System.Drawing.Point(362, 49);
            this.txtClientData.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientData.Name = "txtClientData";
            this.txtClientData.Size = new System.Drawing.Size(101, 20);
            this.txtClientData.TabIndex = 5;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(16, 114);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ReadOnly = true;
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(446, 98);
            this.txtReceived.TabIndex = 20;
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(14, 98);
            this.lblReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(55, 13);
            this.lblReceived.TabIndex = 19;
            this.lblReceived.Text = "Event log:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 215);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 21);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear log/Stats";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(145, 11);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "  Last received: N/A";
            // 
            // chkAccumulateServer
            // 
            this.chkAccumulateServer.AutoSize = true;
            this.chkAccumulateServer.Checked = true;
            this.chkAccumulateServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccumulateServer.Location = new System.Drawing.Point(125, 218);
            this.chkAccumulateServer.Name = "chkAccumulateServer";
            this.chkAccumulateServer.Size = new System.Drawing.Size(106, 17);
            this.chkAccumulateServer.TabIndex = 22;
            this.chkAccumulateServer.Text = "Accumulate data";
            this.chkAccumulateServer.UseVisualStyleBackColor = true;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblLastGap);
            this.grpStats.Controls.Add(this.lblHighPacketGap);
            this.grpStats.Controls.Add(this.lblAvgGap);
            this.grpStats.Controls.Add(this.lblLowGap);
            this.grpStats.Controls.Add(this.lblTotalReceived);
            this.grpStats.Controls.Add(this.lblFirstReceived);
            this.grpStats.Controls.Add(this.lblDate);
            this.grpStats.Location = new System.Drawing.Point(16, 259);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(446, 120);
            this.grpStats.TabIndex = 24;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistics";
            // 
            // lblLastGap
            // 
            this.lblLastGap.AutoSize = true;
            this.lblLastGap.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGap.Location = new System.Drawing.Point(6, 65);
            this.lblLastGap.Name = "lblLastGap";
            this.lblLastGap.Size = new System.Drawing.Size(145, 11);
            this.lblLastGap.TabIndex = 27;
            this.lblLastGap.Text = "Last packet gap: N/A";
            // 
            // lblHighPacketGap
            // 
            this.lblHighPacketGap.AutoSize = true;
            this.lblHighPacketGap.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighPacketGap.Location = new System.Drawing.Point(6, 104);
            this.lblHighPacketGap.Name = "lblHighPacketGap";
            this.lblHighPacketGap.Size = new System.Drawing.Size(145, 11);
            this.lblHighPacketGap.TabIndex = 26;
            this.lblHighPacketGap.Text = "High packet gap: N/A";
            // 
            // lblAvgGap
            // 
            this.lblAvgGap.AutoSize = true;
            this.lblAvgGap.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGap.Location = new System.Drawing.Point(6, 93);
            this.lblAvgGap.Name = "lblAvgGap";
            this.lblAvgGap.Size = new System.Drawing.Size(145, 11);
            this.lblAvgGap.TabIndex = 25;
            this.lblAvgGap.Text = "Avg. packet gap: N/A";
            // 
            // lblLowGap
            // 
            this.lblLowGap.AutoSize = true;
            this.lblLowGap.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowGap.Location = new System.Drawing.Point(6, 82);
            this.lblLowGap.Name = "lblLowGap";
            this.lblLowGap.Size = new System.Drawing.Size(145, 11);
            this.lblLowGap.TabIndex = 24;
            this.lblLowGap.Text = " Low packet gap: N/A";
            // 
            // lblTotalReceived
            // 
            this.lblTotalReceived.AutoSize = true;
            this.lblTotalReceived.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceived.Location = new System.Drawing.Point(6, 44);
            this.lblTotalReceived.Name = "lblTotalReceived";
            this.lblTotalReceived.Size = new System.Drawing.Size(145, 11);
            this.lblTotalReceived.TabIndex = 23;
            this.lblTotalReceived.Text = " Total received: N/A";
            // 
            // lblFirstReceived
            // 
            this.lblFirstReceived.AutoSize = true;
            this.lblFirstReceived.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstReceived.Location = new System.Drawing.Point(6, 22);
            this.lblFirstReceived.Name = "lblFirstReceived";
            this.lblFirstReceived.Size = new System.Drawing.Size(145, 11);
            this.lblFirstReceived.TabIndex = 22;
            this.lblFirstReceived.Text = " First received: N/A";
            // 
            // lblSensorData
            // 
            this.lblSensorData.AutoSize = true;
            this.lblSensorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorData.Location = new System.Drawing.Point(629, 5);
            this.lblSensorData.Name = "lblSensorData";
            this.lblSensorData.Size = new System.Drawing.Size(165, 31);
            this.lblSensorData.TabIndex = 25;
            this.lblSensorData.Text = "Sensor Data";
            // 
            // radTCPData
            // 
            this.radTCPData.AutoSize = true;
            this.radTCPData.Location = new System.Drawing.Point(12, 241);
            this.radTCPData.Name = "radTCPData";
            this.radTCPData.Size = new System.Drawing.Size(105, 17);
            this.radTCPData.TabIndex = 26;
            this.radTCPData.Text = "Collect TCP data";
            this.radTCPData.UseVisualStyleBackColor = true;
            this.radTCPData.CheckedChanged += new System.EventHandler(this.radTCPData_CheckedChanged);
            // 
            // radSensorData
            // 
            this.radSensorData.AutoSize = true;
            this.radSensorData.Checked = true;
            this.radSensorData.Location = new System.Drawing.Point(124, 241);
            this.radSensorData.Name = "radSensorData";
            this.radSensorData.Size = new System.Drawing.Size(115, 17);
            this.radSensorData.TabIndex = 27;
            this.radSensorData.TabStop = true;
            this.radSensorData.Text = "Collect sensor data";
            this.radSensorData.UseVisualStyleBackColor = true;
            this.radSensorData.CheckedChanged += new System.EventHandler(this.radSensorData_CheckedChanged);
            // 
            // lblEl1Temp
            // 
            this.lblEl1Temp.AutoSize = true;
            this.lblEl1Temp.Location = new System.Drawing.Point(504, 49);
            this.lblEl1Temp.Name = "lblEl1Temp";
            this.lblEl1Temp.Size = new System.Drawing.Size(149, 13);
            this.lblEl1Temp.TabIndex = 28;
            this.lblEl1Temp.Text = "Elevation Temperature 1: N/A\r\n";
            // 
            // lblAz1Temp
            // 
            this.lblAz1Temp.AutoSize = true;
            this.lblAz1Temp.Location = new System.Drawing.Point(504, 96);
            this.lblAz1Temp.Name = "lblAz1Temp";
            this.lblAz1Temp.Size = new System.Drawing.Size(142, 13);
            this.lblAz1Temp.TabIndex = 30;
            this.lblAz1Temp.Text = "Azimuth Temperature 1: N/A";
            // 
            // lblAzAdxl
            // 
            this.lblAzAdxl.AutoSize = true;
            this.lblAzAdxl.Location = new System.Drawing.Point(504, 141);
            this.lblAzAdxl.Name = "lblAzAdxl";
            this.lblAzAdxl.Size = new System.Drawing.Size(141, 52);
            this.lblAzAdxl.TabIndex = 32;
            this.lblAzAdxl.Text = "Azimuth accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblElAdxl
            // 
            this.lblElAdxl.AutoSize = true;
            this.lblElAdxl.Location = new System.Drawing.Point(504, 206);
            this.lblElAdxl.Name = "lblElAdxl";
            this.lblElAdxl.Size = new System.Drawing.Size(148, 52);
            this.lblElAdxl.TabIndex = 33;
            this.lblElAdxl.Text = "Elevation accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblCbAdxl
            // 
            this.lblCbAdxl.AutoSize = true;
            this.lblCbAdxl.Location = new System.Drawing.Point(504, 268);
            this.lblCbAdxl.Name = "lblCbAdxl";
            this.lblCbAdxl.Size = new System.Drawing.Size(179, 52);
            this.lblCbAdxl.TabIndex = 34;
            this.lblCbAdxl.Text = "Counterbalance accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblCurrOrientation
            // 
            this.lblCurrOrientation.AutoSize = true;
            this.lblCurrOrientation.Location = new System.Drawing.Point(504, 339);
            this.lblCurrOrientation.Name = "lblCurrOrientation";
            this.lblCurrOrientation.Size = new System.Drawing.Size(193, 13);
            this.lblCurrOrientation.TabIndex = 35;
            this.lblCurrOrientation.Text = "Current orientation (AZ, EL): (N/A, N/A)";
            // 
            // grpTempUnit
            // 
            this.grpTempUnit.Controls.Add(this.radFahrenheit);
            this.grpTempUnit.Controls.Add(this.radCelsius);
            this.grpTempUnit.Controls.Add(this.radKelvin);
            this.grpTempUnit.Location = new System.Drawing.Point(738, 49);
            this.grpTempUnit.Name = "grpTempUnit";
            this.grpTempUnit.Size = new System.Drawing.Size(200, 100);
            this.grpTempUnit.TabIndex = 36;
            this.grpTempUnit.TabStop = false;
            this.grpTempUnit.Text = "Temperature Unit";
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Location = new System.Drawing.Point(11, 70);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radFahrenheit.TabIndex = 2;
            this.radFahrenheit.Text = "Fahrenheit";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Checked = true;
            this.radCelsius.Location = new System.Drawing.Point(11, 45);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(58, 17);
            this.radCelsius.TabIndex = 1;
            this.radCelsius.TabStop = true;
            this.radCelsius.Text = "Celsius";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // radKelvin
            // 
            this.radKelvin.AutoSize = true;
            this.radKelvin.Location = new System.Drawing.Point(11, 19);
            this.radKelvin.Name = "radKelvin";
            this.radKelvin.Size = new System.Drawing.Size(54, 17);
            this.radKelvin.TabIndex = 0;
            this.radKelvin.Text = "Kelvin";
            this.radKelvin.UseVisualStyleBackColor = true;
            // 
            // grpSensorInit
            // 
            this.grpSensorInit.Controls.Add(this.chkAzEncInit);
            this.grpSensorInit.Controls.Add(this.chkElEncInit);
            this.grpSensorInit.Controls.Add(this.chkCbAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkElAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzTemp2Init);
            this.grpSensorInit.Controls.Add(this.chkAzTemp1Init);
            this.grpSensorInit.Controls.Add(this.chkElTemp2Init);
            this.grpSensorInit.Controls.Add(this.chkElTemp1Init);
            this.grpSensorInit.Location = new System.Drawing.Point(738, 158);
            this.grpSensorInit.Name = "grpSensorInit";
            this.grpSensorInit.Size = new System.Drawing.Size(200, 194);
            this.grpSensorInit.TabIndex = 3;
            this.grpSensorInit.TabStop = false;
            this.grpSensorInit.Text = "Sensor Initialization";
            // 
            // chkAzEncInit
            // 
            this.chkAzEncInit.AutoSize = true;
            this.chkAzEncInit.Checked = true;
            this.chkAzEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzEncInit.Location = new System.Drawing.Point(11, 163);
            this.chkAzEncInit.Name = "chkAzEncInit";
            this.chkAzEncInit.Size = new System.Drawing.Size(106, 17);
            this.chkAzEncInit.TabIndex = 8;
            this.chkAzEncInit.Text = "Azimuth Encoder";
            this.chkAzEncInit.UseVisualStyleBackColor = true;
            // 
            // chkElEncInit
            // 
            this.chkElEncInit.AutoSize = true;
            this.chkElEncInit.Checked = true;
            this.chkElEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElEncInit.Location = new System.Drawing.Point(11, 145);
            this.chkElEncInit.Name = "chkElEncInit";
            this.chkElEncInit.Size = new System.Drawing.Size(113, 17);
            this.chkElEncInit.TabIndex = 7;
            this.chkElEncInit.Text = "Elevation Encoder";
            this.chkElEncInit.UseVisualStyleBackColor = true;
            // 
            // chkCbAdxlInit
            // 
            this.chkCbAdxlInit.AutoSize = true;
            this.chkCbAdxlInit.Checked = true;
            this.chkCbAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCbAdxlInit.Location = new System.Drawing.Point(11, 126);
            this.chkCbAdxlInit.Name = "chkCbAdxlInit";
            this.chkCbAdxlInit.Size = new System.Drawing.Size(172, 17);
            this.chkCbAdxlInit.TabIndex = 6;
            this.chkCbAdxlInit.Text = "Counterbalance Accelerometer";
            this.chkCbAdxlInit.UseVisualStyleBackColor = true;
            // 
            // chkAzAdxlInit
            // 
            this.chkAzAdxlInit.AutoSize = true;
            this.chkAzAdxlInit.Checked = true;
            this.chkAzAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzAdxlInit.Location = new System.Drawing.Point(11, 108);
            this.chkAzAdxlInit.Name = "chkAzAdxlInit";
            this.chkAzAdxlInit.Size = new System.Drawing.Size(134, 17);
            this.chkAzAdxlInit.TabIndex = 5;
            this.chkAzAdxlInit.Text = "Azimuth Accelerometer";
            this.chkAzAdxlInit.UseVisualStyleBackColor = true;
            // 
            // chkElAdxlInit
            // 
            this.chkElAdxlInit.AutoSize = true;
            this.chkElAdxlInit.Checked = true;
            this.chkElAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElAdxlInit.Location = new System.Drawing.Point(11, 90);
            this.chkElAdxlInit.Name = "chkElAdxlInit";
            this.chkElAdxlInit.Size = new System.Drawing.Size(141, 17);
            this.chkElAdxlInit.TabIndex = 4;
            this.chkElAdxlInit.Text = "Elevation Accelerometer";
            this.chkElAdxlInit.UseVisualStyleBackColor = true;
            // 
            // chkAzTemp2Init
            // 
            this.chkAzTemp2Init.AutoSize = true;
            this.chkAzTemp2Init.Checked = true;
            this.chkAzTemp2Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzTemp2Init.Location = new System.Drawing.Point(11, 72);
            this.chkAzTemp2Init.Name = "chkAzTemp2Init";
            this.chkAzTemp2Init.Size = new System.Drawing.Size(135, 17);
            this.chkAzTemp2Init.TabIndex = 3;
            this.chkAzTemp2Init.Text = "Azimuth Temperature 2";
            this.chkAzTemp2Init.UseVisualStyleBackColor = true;
            // 
            // chkAzTemp1Init
            // 
            this.chkAzTemp1Init.AutoSize = true;
            this.chkAzTemp1Init.Checked = true;
            this.chkAzTemp1Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzTemp1Init.Location = new System.Drawing.Point(11, 55);
            this.chkAzTemp1Init.Name = "chkAzTemp1Init";
            this.chkAzTemp1Init.Size = new System.Drawing.Size(135, 17);
            this.chkAzTemp1Init.TabIndex = 2;
            this.chkAzTemp1Init.Text = "Azimuth Temperature 1";
            this.chkAzTemp1Init.UseVisualStyleBackColor = true;
            // 
            // chkElTemp2Init
            // 
            this.chkElTemp2Init.AutoSize = true;
            this.chkElTemp2Init.Checked = true;
            this.chkElTemp2Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElTemp2Init.Location = new System.Drawing.Point(11, 37);
            this.chkElTemp2Init.Name = "chkElTemp2Init";
            this.chkElTemp2Init.Size = new System.Drawing.Size(142, 17);
            this.chkElTemp2Init.TabIndex = 1;
            this.chkElTemp2Init.Text = "Elevation Temperature 2";
            this.chkElTemp2Init.UseVisualStyleBackColor = true;
            // 
            // chkElTemp1Init
            // 
            this.chkElTemp1Init.AutoSize = true;
            this.chkElTemp1Init.Checked = true;
            this.chkElTemp1Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElTemp1Init.Location = new System.Drawing.Point(11, 19);
            this.chkElTemp1Init.Name = "chkElTemp1Init";
            this.chkElTemp1Init.Size = new System.Drawing.Size(142, 17);
            this.chkElTemp1Init.TabIndex = 0;
            this.chkElTemp1Init.Text = "Elevation Temperature 1";
            this.chkElTemp1Init.UseVisualStyleBackColor = true;
            // 
            // lblListenConnected
            // 
            this.lblListenConnected.AutoSize = true;
            this.lblListenConnected.Location = new System.Drawing.Point(122, 74);
            this.lblListenConnected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListenConnected.Name = "lblListenConnected";
            this.lblListenConnected.Size = new System.Drawing.Size(81, 13);
            this.lblListenConnected.TabIndex = 15;
            this.lblListenConnected.Text = "Not connected.";
            // 
            // frmTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 390);
            this.Controls.Add(this.grpSensorInit);
            this.Controls.Add(this.grpTempUnit);
            this.Controls.Add(this.lblCurrOrientation);
            this.Controls.Add(this.lblCbAdxl);
            this.Controls.Add(this.lblElAdxl);
            this.Controls.Add(this.lblAzAdxl);
            this.Controls.Add(this.lblAz1Temp);
            this.Controls.Add(this.lblEl1Temp);
            this.Controls.Add(this.radSensorData);
            this.Controls.Add(this.radTCPData);
            this.Controls.Add(this.lblSensorData);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.chkAccumulateServer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.txtClientData);
            this.Controls.Add(this.lblListenConnected);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.lblClientPort);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblClientIp);
            this.Controls.Add(this.txtClientIp);
            this.Controls.Add(this.btnStartClient);
            this.Controls.Add(this.txtListenPort);
            this.Controls.Add(this.lblListenPort);
            this.Controls.Add(this.lblListenRunning);
            this.Controls.Add(this.lblListenIp);
            this.Controls.Add(this.txtListenIp);
            this.Controls.Add(this.btnKillListen);
            this.Controls.Add(this.btnStartListen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmTcpTest";
            this.Text = "TCP Server/Client Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTcpTest_Paint);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpTempUnit.ResumeLayout(false);
            this.grpTempUnit.PerformLayout();
            this.grpSensorInit.ResumeLayout(false);
            this.grpSensorInit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.Button btnKillListen;
        private System.Windows.Forms.TextBox txtListenIp;
        private System.Windows.Forms.Label lblListenIp;
        private System.Windows.Forms.Label lblListenRunning;
        private System.Windows.Forms.Label lblListenPort;
        private System.Windows.Forms.TextBox txtListenPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblClientIp;
        private System.Windows.Forms.TextBox txtClientIp;
        private System.Windows.Forms.Button btnStartClient;
        private System.Windows.Forms.TextBox txtClientData;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkAccumulateServer;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblHighPacketGap;
        private System.Windows.Forms.Label lblAvgGap;
        private System.Windows.Forms.Label lblLowGap;
        private System.Windows.Forms.Label lblTotalReceived;
        private System.Windows.Forms.Label lblFirstReceived;
        private System.Windows.Forms.Label lblLastGap;
        private System.Windows.Forms.Label lblSensorData;
        private System.Windows.Forms.RadioButton radTCPData;
        private System.Windows.Forms.RadioButton radSensorData;
        private System.Windows.Forms.Label lblEl1Temp;
        private System.Windows.Forms.Label lblAz1Temp;
        private System.Windows.Forms.Label lblAzAdxl;
        private System.Windows.Forms.Label lblElAdxl;
        private System.Windows.Forms.Label lblCbAdxl;
        private System.Windows.Forms.Label lblCurrOrientation;
        private System.Windows.Forms.GroupBox grpTempUnit;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.RadioButton radCelsius;
        private System.Windows.Forms.RadioButton radKelvin;
        private System.Windows.Forms.GroupBox grpSensorInit;
        private System.Windows.Forms.CheckBox chkAzEncInit;
        private System.Windows.Forms.CheckBox chkElEncInit;
        private System.Windows.Forms.CheckBox chkCbAdxlInit;
        private System.Windows.Forms.CheckBox chkAzAdxlInit;
        private System.Windows.Forms.CheckBox chkElAdxlInit;
        private System.Windows.Forms.CheckBox chkAzTemp2Init;
        private System.Windows.Forms.CheckBox chkAzTemp1Init;
        private System.Windows.Forms.CheckBox chkElTemp2Init;
        private System.Windows.Forms.CheckBox chkElTemp1Init;
        private System.Windows.Forms.Label lblListenConnected;
    }
}

