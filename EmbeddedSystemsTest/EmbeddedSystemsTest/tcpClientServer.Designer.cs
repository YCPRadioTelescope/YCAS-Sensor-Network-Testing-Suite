
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
            this.lblCurrAz = new System.Windows.Forms.Label();
            this.grpTempUnit = new System.Windows.Forms.GroupBox();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.radKelvin = new System.Windows.Forms.RadioButton();
            this.grpSensorInit = new System.Windows.Forms.GroupBox();
            this.chkAmbTempHumid = new System.Windows.Forms.CheckBox();
            this.chkAzEncInit = new System.Windows.Forms.CheckBox();
            this.chkElEncInit = new System.Windows.Forms.CheckBox();
            this.chkCbAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkElAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzTemp1Init = new System.Windows.Forms.CheckBox();
            this.chkElTemp1Init = new System.Windows.Forms.CheckBox();
            this.lblListenConnected = new System.Windows.Forms.Label();
            this.lblSensorInitChanged = new System.Windows.Forms.Label();
            this.lblCurrEl = new System.Windows.Forms.Label();
            this.btnCustPacket = new System.Windows.Forms.Button();
            this.btnCsvDrawing = new System.Windows.Forms.Button();
            this.gbDataLogging = new System.Windows.Forms.GroupBox();
            this.btnStopLogging = new System.Windows.Forms.Button();
            this.btnStartDataLogging = new System.Windows.Forms.Button();
            this.lblDataFileName = new System.Windows.Forms.Label();
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.gbSensorStatuses = new System.Windows.Forms.GroupBox();
            this.lblAmbTempHumidStatus = new System.Windows.Forms.Label();
            this.lblAzEncoderStatus = new System.Windows.Forms.Label();
            this.lblElEncoderStatus = new System.Windows.Forms.Label();
            this.lblCbAccStatus = new System.Windows.Forms.Label();
            this.lblAzAccStatus = new System.Windows.Forms.Label();
            this.lblElAccStatus = new System.Windows.Forms.Label();
            this.lblAzTempSensor2Status = new System.Windows.Forms.Label();
            this.lblAzTempSensor1Status = new System.Windows.Forms.Label();
            this.lblElTempSensor2Status = new System.Windows.Forms.Label();
            this.lblElTempSensor1Status = new System.Windows.Forms.Label();
            this.lblErrorLogging = new System.Windows.Forms.Label();
            this.ckbLogErrors = new System.Windows.Forms.CheckBox();
            this.lsbErrorLogging = new System.Windows.Forms.ListBox();
            this.lblAmbientHumidity = new System.Windows.Forms.Label();
            this.lblAmbientTemp = new System.Windows.Forms.Label();
            this.lblFanState = new System.Windows.Forms.Label();
            this.btnFanToggle = new System.Windows.Forms.Button();
            this.txtElZ = new System.Windows.Forms.TextBox();
            this.txtElY = new System.Windows.Forms.TextBox();
            this.txtElX = new System.Windows.Forms.TextBox();
            this.lblElZ = new System.Windows.Forms.Label();
            this.lblElY = new System.Windows.Forms.Label();
            this.lblElX = new System.Windows.Forms.Label();
            this.lblElOffsets = new System.Windows.Forms.Label();
            this.chkElBitResolution = new System.Windows.Forms.CheckBox();
            this.numElFIFOSize = new System.Windows.Forms.NumericUpDown();
            this.lblElFIFOSize = new System.Windows.Forms.Label();
            this.lblElGRange = new System.Windows.Forms.Label();
            this.comboElGRange = new System.Windows.Forms.ComboBox();
            this.lblElSamplingSpeed = new System.Windows.Forms.Label();
            this.comboElSamplingSpeed = new System.Windows.Forms.ComboBox();
            this.lblElAccelSettings = new System.Windows.Forms.Label();
            this.txtAzZ = new System.Windows.Forms.TextBox();
            this.txtAzY = new System.Windows.Forms.TextBox();
            this.txtAzX = new System.Windows.Forms.TextBox();
            this.lblAzZ = new System.Windows.Forms.Label();
            this.lblAzY = new System.Windows.Forms.Label();
            this.lblAzX = new System.Windows.Forms.Label();
            this.lblAzOffsets = new System.Windows.Forms.Label();
            this.chkAzBitResolution = new System.Windows.Forms.CheckBox();
            this.numAzFIFOSize = new System.Windows.Forms.NumericUpDown();
            this.lblAzFIFOSize = new System.Windows.Forms.Label();
            this.lblAzGRange = new System.Windows.Forms.Label();
            this.comboAzGRange = new System.Windows.Forms.ComboBox();
            this.lblAzSamplingSpeed = new System.Windows.Forms.Label();
            this.comboAzSamplingSpeed = new System.Windows.Forms.ComboBox();
            this.lblAzAccelSettings = new System.Windows.Forms.Label();
            this.txtCbZ = new System.Windows.Forms.TextBox();
            this.txtCbY = new System.Windows.Forms.TextBox();
            this.txtCbX = new System.Windows.Forms.TextBox();
            this.lblCbZ = new System.Windows.Forms.Label();
            this.lblCbY = new System.Windows.Forms.Label();
            this.lblCbX = new System.Windows.Forms.Label();
            this.lblCbOffsets = new System.Windows.Forms.Label();
            this.chkCbBitResolution = new System.Windows.Forms.CheckBox();
            this.numCbFIFOSize = new System.Windows.Forms.NumericUpDown();
            this.lblCbFIFOSize = new System.Windows.Forms.Label();
            this.lblCbGRange = new System.Windows.Forms.Label();
            this.comboCbGRange = new System.Windows.Forms.ComboBox();
            this.lblCbSamplingSpeed = new System.Windows.Forms.Label();
            this.comboCbSamplingSpeed = new System.Windows.Forms.ComboBox();
            this.lblCbAccelSettings = new System.Windows.Forms.Label();
            this.txtTimerPeriod = new System.Windows.Forms.TextBox();
            this.lblTimerPeriod = new System.Windows.Forms.Label();
            this.txtEthernetPeriod = new System.Windows.Forms.TextBox();
            this.lblEthernetPeriod = new System.Windows.Forms.Label();
            this.txtTempPeriod = new System.Windows.Forms.TextBox();
            this.lblTempPeriod = new System.Windows.Forms.Label();
            this.txtEncoderPeriod = new System.Windows.Forms.TextBox();
            this.lblEncoderPeriod = new System.Windows.Forms.Label();
            this.grpStats.SuspendLayout();
            this.grpTempUnit.SuspendLayout();
            this.grpSensorInit.SuspendLayout();
            this.gbDataLogging.SuspendLayout();
            this.gbSensorStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElFIFOSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAzFIFOSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCbFIFOSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartListen
            // 
            this.btnStartListen.Location = new System.Drawing.Point(11, 53);
            this.btnStartListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(104, 21);
            this.btnStartListen.TabIndex = 5;
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
            this.txtClientPort.TabIndex = 3;
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
            this.txtClientIp.TabIndex = 2;
            // 
            // btnStartClient
            // 
            this.btnStartClient.Enabled = false;
            this.btnStartClient.Location = new System.Drawing.Point(354, 72);
            this.btnStartClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(108, 21);
            this.btnStartClient.TabIndex = 19;
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
            this.txtClientData.TabIndex = 4;
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
            this.txtReceived.TabIndex = 25;
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
            this.btnClear.TabIndex = 15;
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
            this.chkAccumulateServer.TabIndex = 16;
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
            this.radTCPData.TabIndex = 17;
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
            this.radSensorData.TabIndex = 18;
            this.radSensorData.TabStop = true;
            this.radSensorData.Text = "Collect sensor data";
            this.radSensorData.UseVisualStyleBackColor = true;
            this.radSensorData.CheckedChanged += new System.EventHandler(this.radSensorData_CheckedChanged);
            // 
            // lblEl1Temp
            // 
            this.lblEl1Temp.AutoSize = true;
            this.lblEl1Temp.Location = new System.Drawing.Point(505, 48);
            this.lblEl1Temp.Name = "lblEl1Temp";
            this.lblEl1Temp.Size = new System.Drawing.Size(140, 13);
            this.lblEl1Temp.TabIndex = 28;
            this.lblEl1Temp.Text = "Elevation Temperature: N/A\r\n";
            // 
            // lblAz1Temp
            // 
            this.lblAz1Temp.AutoSize = true;
            this.lblAz1Temp.Location = new System.Drawing.Point(512, 61);
            this.lblAz1Temp.Name = "lblAz1Temp";
            this.lblAz1Temp.Size = new System.Drawing.Size(133, 13);
            this.lblAz1Temp.TabIndex = 30;
            this.lblAz1Temp.Text = "Azimuth Temperature: N/A";
            // 
            // lblAzAdxl
            // 
            this.lblAzAdxl.AutoSize = true;
            this.lblAzAdxl.Location = new System.Drawing.Point(504, 86);
            this.lblAzAdxl.Name = "lblAzAdxl";
            this.lblAzAdxl.Size = new System.Drawing.Size(141, 52);
            this.lblAzAdxl.TabIndex = 32;
            this.lblAzAdxl.Text = "Azimuth accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblElAdxl
            // 
            this.lblElAdxl.AutoSize = true;
            this.lblElAdxl.Location = new System.Drawing.Point(505, 146);
            this.lblElAdxl.Name = "lblElAdxl";
            this.lblElAdxl.Size = new System.Drawing.Size(148, 52);
            this.lblElAdxl.TabIndex = 33;
            this.lblElAdxl.Text = "Elevation accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblCbAdxl
            // 
            this.lblCbAdxl.AutoSize = true;
            this.lblCbAdxl.Location = new System.Drawing.Point(505, 206);
            this.lblCbAdxl.Name = "lblCbAdxl";
            this.lblCbAdxl.Size = new System.Drawing.Size(179, 52);
            this.lblCbAdxl.TabIndex = 34;
            this.lblCbAdxl.Text = "Counterbalance accelerometer data:\r\n     X: N/A\r\n     Y: N/A\r\n     Z: N/A";
            // 
            // lblCurrAz
            // 
            this.lblCurrAz.AutoSize = true;
            this.lblCurrAz.Location = new System.Drawing.Point(500, 267);
            this.lblCurrAz.Name = "lblCurrAz";
            this.lblCurrAz.Size = new System.Drawing.Size(145, 13);
            this.lblCurrAz.TabIndex = 35;
            this.lblCurrAz.Text = "Current azimuth position: N/A";
            // 
            // grpTempUnit
            // 
            this.grpTempUnit.Controls.Add(this.radFahrenheit);
            this.grpTempUnit.Controls.Add(this.radCelsius);
            this.grpTempUnit.Controls.Add(this.radKelvin);
            this.grpTempUnit.Location = new System.Drawing.Point(738, 49);
            this.grpTempUnit.Name = "grpTempUnit";
            this.grpTempUnit.Size = new System.Drawing.Size(208, 100);
            this.grpTempUnit.TabIndex = 20;
            this.grpTempUnit.TabStop = false;
            this.grpTempUnit.Text = "Temperature Unit";
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Location = new System.Drawing.Point(11, 70);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radFahrenheit.TabIndex = 22;
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
            this.radCelsius.TabIndex = 21;
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
            this.radKelvin.TabIndex = 20;
            this.radKelvin.Text = "Kelvin";
            this.radKelvin.UseVisualStyleBackColor = true;
            // 
            // grpSensorInit
            // 
            this.grpSensorInit.Controls.Add(this.txtEncoderPeriod);
            this.grpSensorInit.Controls.Add(this.lblEncoderPeriod);
            this.grpSensorInit.Controls.Add(this.txtTempPeriod);
            this.grpSensorInit.Controls.Add(this.lblTempPeriod);
            this.grpSensorInit.Controls.Add(this.txtEthernetPeriod);
            this.grpSensorInit.Controls.Add(this.lblEthernetPeriod);
            this.grpSensorInit.Controls.Add(this.txtTimerPeriod);
            this.grpSensorInit.Controls.Add(this.lblTimerPeriod);
            this.grpSensorInit.Controls.Add(this.txtCbZ);
            this.grpSensorInit.Controls.Add(this.txtCbY);
            this.grpSensorInit.Controls.Add(this.txtCbX);
            this.grpSensorInit.Controls.Add(this.lblCbZ);
            this.grpSensorInit.Controls.Add(this.lblCbY);
            this.grpSensorInit.Controls.Add(this.lblCbX);
            this.grpSensorInit.Controls.Add(this.lblCbOffsets);
            this.grpSensorInit.Controls.Add(this.chkCbBitResolution);
            this.grpSensorInit.Controls.Add(this.numCbFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblCbFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblCbGRange);
            this.grpSensorInit.Controls.Add(this.comboCbGRange);
            this.grpSensorInit.Controls.Add(this.lblCbSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.comboCbSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.lblCbAccelSettings);
            this.grpSensorInit.Controls.Add(this.txtAzZ);
            this.grpSensorInit.Controls.Add(this.txtAzY);
            this.grpSensorInit.Controls.Add(this.txtAzX);
            this.grpSensorInit.Controls.Add(this.lblAzZ);
            this.grpSensorInit.Controls.Add(this.lblAzY);
            this.grpSensorInit.Controls.Add(this.lblAzX);
            this.grpSensorInit.Controls.Add(this.lblAzOffsets);
            this.grpSensorInit.Controls.Add(this.chkAzBitResolution);
            this.grpSensorInit.Controls.Add(this.numAzFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblAzFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblAzGRange);
            this.grpSensorInit.Controls.Add(this.comboAzGRange);
            this.grpSensorInit.Controls.Add(this.lblAzSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.comboAzSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.lblAzAccelSettings);
            this.grpSensorInit.Controls.Add(this.txtElZ);
            this.grpSensorInit.Controls.Add(this.txtElY);
            this.grpSensorInit.Controls.Add(this.txtElX);
            this.grpSensorInit.Controls.Add(this.lblElZ);
            this.grpSensorInit.Controls.Add(this.lblElY);
            this.grpSensorInit.Controls.Add(this.lblElX);
            this.grpSensorInit.Controls.Add(this.lblElOffsets);
            this.grpSensorInit.Controls.Add(this.chkElBitResolution);
            this.grpSensorInit.Controls.Add(this.numElFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblElFIFOSize);
            this.grpSensorInit.Controls.Add(this.lblElGRange);
            this.grpSensorInit.Controls.Add(this.comboElGRange);
            this.grpSensorInit.Controls.Add(this.lblElSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.comboElSamplingSpeed);
            this.grpSensorInit.Controls.Add(this.lblElAccelSettings);
            this.grpSensorInit.Controls.Add(this.chkAmbTempHumid);
            this.grpSensorInit.Controls.Add(this.chkAzEncInit);
            this.grpSensorInit.Controls.Add(this.chkElEncInit);
            this.grpSensorInit.Controls.Add(this.chkCbAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkElAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzTemp1Init);
            this.grpSensorInit.Controls.Add(this.chkElTemp1Init);
            this.grpSensorInit.Location = new System.Drawing.Point(479, 390);
            this.grpSensorInit.Name = "grpSensorInit";
            this.grpSensorInit.Size = new System.Drawing.Size(467, 266);
            this.grpSensorInit.TabIndex = 6;
            this.grpSensorInit.TabStop = false;
            this.grpSensorInit.Text = "Sensor Initialization";
            // 
            // chkAmbTempHumid
            // 
            this.chkAmbTempHumid.AutoSize = true;
            this.chkAmbTempHumid.Checked = true;
            this.chkAmbTempHumid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmbTempHumid.Location = new System.Drawing.Point(11, 142);
            this.chkAmbTempHumid.Name = "chkAmbTempHumid";
            this.chkAmbTempHumid.Size = new System.Drawing.Size(158, 17);
            this.chkAmbTempHumid.TabIndex = 15;
            this.chkAmbTempHumid.Text = "Ambient Temp and Humidity";
            this.chkAmbTempHumid.UseVisualStyleBackColor = true;
            this.chkAmbTempHumid.CheckedChanged += new System.EventHandler(this.chkAmbTempHumid_CheckedChanged);
            // 
            // chkAzEncInit
            // 
            this.chkAzEncInit.AutoSize = true;
            this.chkAzEncInit.Checked = true;
            this.chkAzEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzEncInit.Location = new System.Drawing.Point(11, 126);
            this.chkAzEncInit.Name = "chkAzEncInit";
            this.chkAzEncInit.Size = new System.Drawing.Size(106, 17);
            this.chkAzEncInit.TabIndex = 14;
            this.chkAzEncInit.Text = "Azimuth Encoder";
            this.chkAzEncInit.UseVisualStyleBackColor = true;
            this.chkAzEncInit.CheckedChanged += new System.EventHandler(this.chkAzEncInit_CheckedChanged);
            // 
            // chkElEncInit
            // 
            this.chkElEncInit.AutoSize = true;
            this.chkElEncInit.Checked = true;
            this.chkElEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElEncInit.Location = new System.Drawing.Point(11, 108);
            this.chkElEncInit.Name = "chkElEncInit";
            this.chkElEncInit.Size = new System.Drawing.Size(113, 17);
            this.chkElEncInit.TabIndex = 13;
            this.chkElEncInit.Text = "Elevation Encoder";
            this.chkElEncInit.UseVisualStyleBackColor = true;
            this.chkElEncInit.CheckedChanged += new System.EventHandler(this.chkElEncInit_CheckedChanged);
            // 
            // chkCbAdxlInit
            // 
            this.chkCbAdxlInit.AutoSize = true;
            this.chkCbAdxlInit.Checked = true;
            this.chkCbAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCbAdxlInit.Location = new System.Drawing.Point(11, 89);
            this.chkCbAdxlInit.Name = "chkCbAdxlInit";
            this.chkCbAdxlInit.Size = new System.Drawing.Size(172, 17);
            this.chkCbAdxlInit.TabIndex = 12;
            this.chkCbAdxlInit.Text = "Counterbalance Accelerometer";
            this.chkCbAdxlInit.UseVisualStyleBackColor = true;
            this.chkCbAdxlInit.CheckedChanged += new System.EventHandler(this.chkCbAdxlInit_CheckedChanged);
            // 
            // chkAzAdxlInit
            // 
            this.chkAzAdxlInit.AutoSize = true;
            this.chkAzAdxlInit.Checked = true;
            this.chkAzAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzAdxlInit.Location = new System.Drawing.Point(11, 71);
            this.chkAzAdxlInit.Name = "chkAzAdxlInit";
            this.chkAzAdxlInit.Size = new System.Drawing.Size(134, 17);
            this.chkAzAdxlInit.TabIndex = 11;
            this.chkAzAdxlInit.Text = "Azimuth Accelerometer";
            this.chkAzAdxlInit.UseVisualStyleBackColor = true;
            this.chkAzAdxlInit.CheckedChanged += new System.EventHandler(this.chkAzAdxlInit_CheckedChanged);
            // 
            // chkElAdxlInit
            // 
            this.chkElAdxlInit.AutoSize = true;
            this.chkElAdxlInit.Checked = true;
            this.chkElAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElAdxlInit.Location = new System.Drawing.Point(11, 53);
            this.chkElAdxlInit.Name = "chkElAdxlInit";
            this.chkElAdxlInit.Size = new System.Drawing.Size(141, 17);
            this.chkElAdxlInit.TabIndex = 10;
            this.chkElAdxlInit.Text = "Elevation Accelerometer";
            this.chkElAdxlInit.UseVisualStyleBackColor = true;
            this.chkElAdxlInit.CheckedChanged += new System.EventHandler(this.chkElAdxlInit_CheckedChanged);
            // 
            // chkAzTemp1Init
            // 
            this.chkAzTemp1Init.AutoSize = true;
            this.chkAzTemp1Init.Checked = true;
            this.chkAzTemp1Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzTemp1Init.Location = new System.Drawing.Point(11, 36);
            this.chkAzTemp1Init.Name = "chkAzTemp1Init";
            this.chkAzTemp1Init.Size = new System.Drawing.Size(126, 17);
            this.chkAzTemp1Init.TabIndex = 8;
            this.chkAzTemp1Init.Text = "Azimuth Temperature";
            this.chkAzTemp1Init.UseVisualStyleBackColor = true;
            this.chkAzTemp1Init.CheckedChanged += new System.EventHandler(this.chkAzTemp1Init_CheckedChanged);
            // 
            // chkElTemp1Init
            // 
            this.chkElTemp1Init.AutoSize = true;
            this.chkElTemp1Init.Checked = true;
            this.chkElTemp1Init.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElTemp1Init.Location = new System.Drawing.Point(11, 19);
            this.chkElTemp1Init.Name = "chkElTemp1Init";
            this.chkElTemp1Init.Size = new System.Drawing.Size(133, 17);
            this.chkElTemp1Init.TabIndex = 6;
            this.chkElTemp1Init.Text = "Elevation Temperature";
            this.chkElTemp1Init.UseVisualStyleBackColor = true;
            this.chkElTemp1Init.CheckedChanged += new System.EventHandler(this.chkElTemp1Init_CheckedChanged);
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
            // lblSensorInitChanged
            // 
            this.lblSensorInitChanged.AutoSize = true;
            this.lblSensorInitChanged.ForeColor = System.Drawing.Color.Red;
            this.lblSensorInitChanged.Location = new System.Drawing.Point(500, 350);
            this.lblSensorInitChanged.Name = "lblSensorInitChanged";
            this.lblSensorInitChanged.Size = new System.Drawing.Size(0, 13);
            this.lblSensorInitChanged.TabIndex = 37;
            // 
            // lblCurrEl
            // 
            this.lblCurrEl.AutoSize = true;
            this.lblCurrEl.Location = new System.Drawing.Point(493, 280);
            this.lblCurrEl.Name = "lblCurrEl";
            this.lblCurrEl.Size = new System.Drawing.Size(152, 13);
            this.lblCurrEl.TabIndex = 38;
            this.lblCurrEl.Text = "Current elevation position: N/A";
            // 
            // btnCustPacket
            // 
            this.btnCustPacket.Location = new System.Drawing.Point(752, 662);
            this.btnCustPacket.Name = "btnCustPacket";
            this.btnCustPacket.Size = new System.Drawing.Size(120, 23);
            this.btnCustPacket.TabIndex = 24;
            this.btnCustPacket.Text = "Custom Packet Form";
            this.btnCustPacket.UseVisualStyleBackColor = true;
            this.btnCustPacket.Click += new System.EventHandler(this.btnCustPacket_Click);
            // 
            // btnCsvDrawing
            // 
            this.btnCsvDrawing.Location = new System.Drawing.Point(625, 662);
            this.btnCsvDrawing.Name = "btnCsvDrawing";
            this.btnCsvDrawing.Size = new System.Drawing.Size(120, 23);
            this.btnCsvDrawing.TabIndex = 23;
            this.btnCsvDrawing.Text = "Data Drawing Form";
            this.btnCsvDrawing.UseVisualStyleBackColor = true;
            this.btnCsvDrawing.Click += new System.EventHandler(this.btnCsvDrawing_Click);
            // 
            // gbDataLogging
            // 
            this.gbDataLogging.Controls.Add(this.btnStopLogging);
            this.gbDataLogging.Controls.Add(this.btnStartDataLogging);
            this.gbDataLogging.Controls.Add(this.lblDataFileName);
            this.gbDataLogging.Controls.Add(this.txtDataFileName);
            this.gbDataLogging.Location = new System.Drawing.Point(17, 575);
            this.gbDataLogging.Name = "gbDataLogging";
            this.gbDataLogging.Size = new System.Drawing.Size(274, 100);
            this.gbDataLogging.TabIndex = 39;
            this.gbDataLogging.TabStop = false;
            this.gbDataLogging.Text = "Data Logging";
            // 
            // btnStopLogging
            // 
            this.btnStopLogging.Enabled = false;
            this.btnStopLogging.Location = new System.Drawing.Point(140, 71);
            this.btnStopLogging.Name = "btnStopLogging";
            this.btnStopLogging.Size = new System.Drawing.Size(103, 23);
            this.btnStopLogging.TabIndex = 3;
            this.btnStopLogging.Text = "Stop Logging";
            this.btnStopLogging.UseVisualStyleBackColor = true;
            this.btnStopLogging.Click += new System.EventHandler(this.btnStopLogging_Click);
            // 
            // btnStartDataLogging
            // 
            this.btnStartDataLogging.Location = new System.Drawing.Point(18, 71);
            this.btnStartDataLogging.Name = "btnStartDataLogging";
            this.btnStartDataLogging.Size = new System.Drawing.Size(103, 23);
            this.btnStartDataLogging.TabIndex = 2;
            this.btnStartDataLogging.Text = "Start Logging";
            this.btnStartDataLogging.UseVisualStyleBackColor = true;
            this.btnStartDataLogging.Click += new System.EventHandler(this.btnStartDataLogging_Click);
            // 
            // lblDataFileName
            // 
            this.lblDataFileName.AutoSize = true;
            this.lblDataFileName.Location = new System.Drawing.Point(15, 33);
            this.lblDataFileName.Name = "lblDataFileName";
            this.lblDataFileName.Size = new System.Drawing.Size(57, 13);
            this.lblDataFileName.TabIndex = 1;
            this.lblDataFileName.Text = "File Name:";
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.Location = new System.Drawing.Point(76, 30);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.Size = new System.Drawing.Size(131, 20);
            this.txtDataFileName.TabIndex = 0;
            // 
            // gbSensorStatuses
            // 
            this.gbSensorStatuses.Controls.Add(this.lblAmbTempHumidStatus);
            this.gbSensorStatuses.Controls.Add(this.lblAzEncoderStatus);
            this.gbSensorStatuses.Controls.Add(this.lblElEncoderStatus);
            this.gbSensorStatuses.Controls.Add(this.lblCbAccStatus);
            this.gbSensorStatuses.Controls.Add(this.lblAzAccStatus);
            this.gbSensorStatuses.Controls.Add(this.lblElAccStatus);
            this.gbSensorStatuses.Controls.Add(this.lblAzTempSensor2Status);
            this.gbSensorStatuses.Controls.Add(this.lblAzTempSensor1Status);
            this.gbSensorStatuses.Controls.Add(this.lblElTempSensor2Status);
            this.gbSensorStatuses.Controls.Add(this.lblElTempSensor1Status);
            this.gbSensorStatuses.Location = new System.Drawing.Point(738, 155);
            this.gbSensorStatuses.Name = "gbSensorStatuses";
            this.gbSensorStatuses.Size = new System.Drawing.Size(208, 230);
            this.gbSensorStatuses.TabIndex = 40;
            this.gbSensorStatuses.TabStop = false;
            this.gbSensorStatuses.Text = "Sensor Statuses";
            // 
            // lblAmbTempHumidStatus
            // 
            this.lblAmbTempHumidStatus.AutoSize = true;
            this.lblAmbTempHumidStatus.Location = new System.Drawing.Point(11, 205);
            this.lblAmbTempHumidStatus.Name = "lblAmbTempHumidStatus";
            this.lblAmbTempHumidStatus.Size = new System.Drawing.Size(142, 13);
            this.lblAmbTempHumidStatus.TabIndex = 9;
            this.lblAmbTempHumidStatus.Text = "Ambient Temp and Humidity:";
            // 
            // lblAzEncoderStatus
            // 
            this.lblAzEncoderStatus.AutoSize = true;
            this.lblAzEncoderStatus.Location = new System.Drawing.Point(11, 181);
            this.lblAzEncoderStatus.Name = "lblAzEncoderStatus";
            this.lblAzEncoderStatus.Size = new System.Drawing.Size(90, 13);
            this.lblAzEncoderStatus.TabIndex = 8;
            this.lblAzEncoderStatus.Text = "Azimuth Encoder:";
            // 
            // lblElEncoderStatus
            // 
            this.lblElEncoderStatus.AutoSize = true;
            this.lblElEncoderStatus.Location = new System.Drawing.Point(11, 159);
            this.lblElEncoderStatus.Name = "lblElEncoderStatus";
            this.lblElEncoderStatus.Size = new System.Drawing.Size(97, 13);
            this.lblElEncoderStatus.TabIndex = 7;
            this.lblElEncoderStatus.Text = "Elevation Encoder:";
            // 
            // lblCbAccStatus
            // 
            this.lblCbAccStatus.AutoSize = true;
            this.lblCbAccStatus.Location = new System.Drawing.Point(11, 140);
            this.lblCbAccStatus.Name = "lblCbAccStatus";
            this.lblCbAccStatus.Size = new System.Drawing.Size(156, 13);
            this.lblCbAccStatus.TabIndex = 6;
            this.lblCbAccStatus.Text = "Counterbalance Accelerometer:";
            // 
            // lblAzAccStatus
            // 
            this.lblAzAccStatus.AutoSize = true;
            this.lblAzAccStatus.Location = new System.Drawing.Point(11, 121);
            this.lblAzAccStatus.Name = "lblAzAccStatus";
            this.lblAzAccStatus.Size = new System.Drawing.Size(118, 13);
            this.lblAzAccStatus.TabIndex = 5;
            this.lblAzAccStatus.Text = "Azimuth Accelerometer:";
            // 
            // lblElAccStatus
            // 
            this.lblElAccStatus.AutoSize = true;
            this.lblElAccStatus.Location = new System.Drawing.Point(11, 102);
            this.lblElAccStatus.Name = "lblElAccStatus";
            this.lblElAccStatus.Size = new System.Drawing.Size(125, 13);
            this.lblElAccStatus.TabIndex = 4;
            this.lblElAccStatus.Text = "Elevation Accelerometer:";
            // 
            // lblAzTempSensor2Status
            // 
            this.lblAzTempSensor2Status.AutoSize = true;
            this.lblAzTempSensor2Status.Location = new System.Drawing.Point(11, 82);
            this.lblAzTempSensor2Status.Name = "lblAzTempSensor2Status";
            this.lblAzTempSensor2Status.Size = new System.Drawing.Size(119, 13);
            this.lblAzTempSensor2Status.TabIndex = 3;
            this.lblAzTempSensor2Status.Text = "Azimuth Temperature 2:";
            // 
            // lblAzTempSensor1Status
            // 
            this.lblAzTempSensor1Status.AutoSize = true;
            this.lblAzTempSensor1Status.Location = new System.Drawing.Point(11, 64);
            this.lblAzTempSensor1Status.Name = "lblAzTempSensor1Status";
            this.lblAzTempSensor1Status.Size = new System.Drawing.Size(119, 13);
            this.lblAzTempSensor1Status.TabIndex = 2;
            this.lblAzTempSensor1Status.Text = "Azimuth Temperature 1:";
            // 
            // lblElTempSensor2Status
            // 
            this.lblElTempSensor2Status.AutoSize = true;
            this.lblElTempSensor2Status.Location = new System.Drawing.Point(11, 46);
            this.lblElTempSensor2Status.Name = "lblElTempSensor2Status";
            this.lblElTempSensor2Status.Size = new System.Drawing.Size(126, 13);
            this.lblElTempSensor2Status.TabIndex = 1;
            this.lblElTempSensor2Status.Text = "Elevation Temperature 2:";
            // 
            // lblElTempSensor1Status
            // 
            this.lblElTempSensor1Status.AutoSize = true;
            this.lblElTempSensor1Status.Location = new System.Drawing.Point(11, 27);
            this.lblElTempSensor1Status.Name = "lblElTempSensor1Status";
            this.lblElTempSensor1Status.Size = new System.Drawing.Size(126, 13);
            this.lblElTempSensor1Status.TabIndex = 0;
            this.lblElTempSensor1Status.Text = "Elevation Temperature 1:";
            // 
            // lblErrorLogging
            // 
            this.lblErrorLogging.AutoSize = true;
            this.lblErrorLogging.Location = new System.Drawing.Point(21, 390);
            this.lblErrorLogging.Name = "lblErrorLogging";
            this.lblErrorLogging.Size = new System.Drawing.Size(73, 13);
            this.lblErrorLogging.TabIndex = 42;
            this.lblErrorLogging.Text = "Error Logging:";
            // 
            // ckbLogErrors
            // 
            this.ckbLogErrors.AutoSize = true;
            this.ckbLogErrors.Checked = true;
            this.ckbLogErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLogErrors.Location = new System.Drawing.Point(143, 389);
            this.ckbLogErrors.Name = "ckbLogErrors";
            this.ckbLogErrors.Size = new System.Drawing.Size(74, 17);
            this.ckbLogErrors.TabIndex = 44;
            this.ckbLogErrors.Text = "Log Errors";
            this.ckbLogErrors.UseVisualStyleBackColor = true;
            // 
            // lsbErrorLogging
            // 
            this.lsbErrorLogging.FormattingEnabled = true;
            this.lsbErrorLogging.Location = new System.Drawing.Point(16, 407);
            this.lsbErrorLogging.Name = "lsbErrorLogging";
            this.lsbErrorLogging.Size = new System.Drawing.Size(410, 160);
            this.lsbErrorLogging.TabIndex = 45;
            // 
            // lblAmbientHumidity
            // 
            this.lblAmbientHumidity.AutoSize = true;
            this.lblAmbientHumidity.Location = new System.Drawing.Point(512, 320);
            this.lblAmbientHumidity.Name = "lblAmbientHumidity";
            this.lblAmbientHumidity.Size = new System.Drawing.Size(114, 13);
            this.lblAmbientHumidity.TabIndex = 47;
            this.lblAmbientHumidity.Text = "Ambient Humidity: N/A";
            // 
            // lblAmbientTemp
            // 
            this.lblAmbientTemp.AutoSize = true;
            this.lblAmbientTemp.Location = new System.Drawing.Point(505, 307);
            this.lblAmbientTemp.Name = "lblAmbientTemp";
            this.lblAmbientTemp.Size = new System.Drawing.Size(134, 13);
            this.lblAmbientTemp.TabIndex = 46;
            this.lblAmbientTemp.Text = "Ambient Temperature: N/A\r\n";
            // 
            // lblFanState
            // 
            this.lblFanState.AutoSize = true;
            this.lblFanState.Location = new System.Drawing.Point(493, 341);
            this.lblFanState.Name = "lblFanState";
            this.lblFanState.Size = new System.Drawing.Size(79, 13);
            this.lblFanState.TabIndex = 48;
            this.lblFanState.Text = "Fan State: N/A";
            // 
            // btnFanToggle
            // 
            this.btnFanToggle.Location = new System.Drawing.Point(612, 336);
            this.btnFanToggle.Name = "btnFanToggle";
            this.btnFanToggle.Size = new System.Drawing.Size(120, 23);
            this.btnFanToggle.TabIndex = 49;
            this.btnFanToggle.Text = "Toggle Fan On/Off";
            this.btnFanToggle.UseVisualStyleBackColor = true;
            this.btnFanToggle.Click += new System.EventHandler(this.btnFanToggle_Click);
            // 
            // txtElZ
            // 
            this.txtElZ.Location = new System.Drawing.Point(441, 57);
            this.txtElZ.Name = "txtElZ";
            this.txtElZ.Size = new System.Drawing.Size(22, 20);
            this.txtElZ.TabIndex = 111;
            this.txtElZ.Text = "0";
            // 
            // txtElY
            // 
            this.txtElY.Location = new System.Drawing.Point(399, 57);
            this.txtElY.Name = "txtElY";
            this.txtElY.Size = new System.Drawing.Size(22, 20);
            this.txtElY.TabIndex = 110;
            this.txtElY.Text = "0";
            // 
            // txtElX
            // 
            this.txtElX.Location = new System.Drawing.Point(358, 57);
            this.txtElX.Name = "txtElX";
            this.txtElX.Size = new System.Drawing.Size(22, 20);
            this.txtElX.TabIndex = 109;
            this.txtElX.Text = "0";
            // 
            // lblElZ
            // 
            this.lblElZ.AutoSize = true;
            this.lblElZ.ForeColor = System.Drawing.Color.Black;
            this.lblElZ.Location = new System.Drawing.Point(425, 60);
            this.lblElZ.Name = "lblElZ";
            this.lblElZ.Size = new System.Drawing.Size(14, 13);
            this.lblElZ.TabIndex = 108;
            this.lblElZ.Text = "Z";
            // 
            // lblElY
            // 
            this.lblElY.AutoSize = true;
            this.lblElY.ForeColor = System.Drawing.Color.Black;
            this.lblElY.Location = new System.Drawing.Point(382, 60);
            this.lblElY.Name = "lblElY";
            this.lblElY.Size = new System.Drawing.Size(14, 13);
            this.lblElY.TabIndex = 107;
            this.lblElY.Text = "Y";
            // 
            // lblElX
            // 
            this.lblElX.AutoSize = true;
            this.lblElX.ForeColor = System.Drawing.Color.Black;
            this.lblElX.Location = new System.Drawing.Point(342, 60);
            this.lblElX.Name = "lblElX";
            this.lblElX.Size = new System.Drawing.Size(14, 13);
            this.lblElX.TabIndex = 106;
            this.lblElX.Text = "X";
            // 
            // lblElOffsets
            // 
            this.lblElOffsets.AutoSize = true;
            this.lblElOffsets.ForeColor = System.Drawing.Color.Black;
            this.lblElOffsets.Location = new System.Drawing.Point(300, 60);
            this.lblElOffsets.Name = "lblElOffsets";
            this.lblElOffsets.Size = new System.Drawing.Size(43, 13);
            this.lblElOffsets.TabIndex = 105;
            this.lblElOffsets.Text = "Offsets:";
            // 
            // chkElBitResolution
            // 
            this.chkElBitResolution.AutoSize = true;
            this.chkElBitResolution.Checked = true;
            this.chkElBitResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElBitResolution.Location = new System.Drawing.Point(298, 13);
            this.chkElBitResolution.Name = "chkElBitResolution";
            this.chkElBitResolution.Size = new System.Drawing.Size(110, 17);
            this.chkElBitResolution.TabIndex = 104;
            this.chkElBitResolution.Text = "Full Bit Resolution";
            this.chkElBitResolution.UseVisualStyleBackColor = true;
            // 
            // numElFIFOSize
            // 
            this.numElFIFOSize.Location = new System.Drawing.Point(244, 57);
            this.numElFIFOSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numElFIFOSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numElFIFOSize.Name = "numElFIFOSize";
            this.numElFIFOSize.Size = new System.Drawing.Size(43, 20);
            this.numElFIFOSize.TabIndex = 103;
            this.numElFIFOSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblElFIFOSize
            // 
            this.lblElFIFOSize.AutoSize = true;
            this.lblElFIFOSize.ForeColor = System.Drawing.Color.Black;
            this.lblElFIFOSize.Location = new System.Drawing.Point(182, 60);
            this.lblElFIFOSize.Name = "lblElFIFOSize";
            this.lblElFIFOSize.Size = new System.Drawing.Size(56, 13);
            this.lblElFIFOSize.TabIndex = 102;
            this.lblElFIFOSize.Text = "FIFO Size:";
            // 
            // lblElGRange
            // 
            this.lblElGRange.AutoSize = true;
            this.lblElGRange.ForeColor = System.Drawing.Color.Black;
            this.lblElGRange.Location = new System.Drawing.Point(356, 37);
            this.lblElGRange.Name = "lblElGRange";
            this.lblElGRange.Size = new System.Drawing.Size(53, 13);
            this.lblElGRange.TabIndex = 101;
            this.lblElGRange.Text = "G-Range:";
            // 
            // comboElGRange
            // 
            this.comboElGRange.BackColor = System.Drawing.SystemColors.Window;
            this.comboElGRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElGRange.FormattingEnabled = true;
            this.comboElGRange.Items.AddRange(new object[] {
            "±16",
            "±8",
            "±4",
            "±2"});
            this.comboElGRange.Location = new System.Drawing.Point(412, 34);
            this.comboElGRange.Name = "comboElGRange";
            this.comboElGRange.Size = new System.Drawing.Size(51, 21);
            this.comboElGRange.TabIndex = 100;
            // 
            // lblElSamplingSpeed
            // 
            this.lblElSamplingSpeed.AutoSize = true;
            this.lblElSamplingSpeed.ForeColor = System.Drawing.Color.Black;
            this.lblElSamplingSpeed.Location = new System.Drawing.Point(182, 37);
            this.lblElSamplingSpeed.Name = "lblElSamplingSpeed";
            this.lblElSamplingSpeed.Size = new System.Drawing.Size(109, 13);
            this.lblElSamplingSpeed.TabIndex = 99;
            this.lblElSamplingSpeed.Text = "Sampling Speed (Hz):";
            // 
            // comboElSamplingSpeed
            // 
            this.comboElSamplingSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.comboElSamplingSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElSamplingSpeed.FormattingEnabled = true;
            this.comboElSamplingSpeed.Items.AddRange(new object[] {
            "800",
            "400",
            "200",
            "100",
            "50",
            "25"});
            this.comboElSamplingSpeed.Location = new System.Drawing.Point(297, 34);
            this.comboElSamplingSpeed.Name = "comboElSamplingSpeed";
            this.comboElSamplingSpeed.Size = new System.Drawing.Size(51, 21);
            this.comboElSamplingSpeed.TabIndex = 98;
            // 
            // lblElAccelSettings
            // 
            this.lblElAccelSettings.AutoSize = true;
            this.lblElAccelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblElAccelSettings.ForeColor = System.Drawing.Color.Black;
            this.lblElAccelSettings.Location = new System.Drawing.Point(182, 14);
            this.lblElAccelSettings.Name = "lblElAccelSettings";
            this.lblElAccelSettings.Size = new System.Drawing.Size(107, 13);
            this.lblElAccelSettings.TabIndex = 96;
            this.lblElAccelSettings.Text = "El Accelerometer:";
            // 
            // txtAzZ
            // 
            this.txtAzZ.Location = new System.Drawing.Point(441, 127);
            this.txtAzZ.Name = "txtAzZ";
            this.txtAzZ.Size = new System.Drawing.Size(22, 20);
            this.txtAzZ.TabIndex = 126;
            this.txtAzZ.Text = "0";
            // 
            // txtAzY
            // 
            this.txtAzY.Location = new System.Drawing.Point(399, 127);
            this.txtAzY.Name = "txtAzY";
            this.txtAzY.Size = new System.Drawing.Size(22, 20);
            this.txtAzY.TabIndex = 125;
            this.txtAzY.Text = "0";
            // 
            // txtAzX
            // 
            this.txtAzX.Location = new System.Drawing.Point(358, 127);
            this.txtAzX.Name = "txtAzX";
            this.txtAzX.Size = new System.Drawing.Size(22, 20);
            this.txtAzX.TabIndex = 124;
            this.txtAzX.Text = "0";
            // 
            // lblAzZ
            // 
            this.lblAzZ.AutoSize = true;
            this.lblAzZ.ForeColor = System.Drawing.Color.Black;
            this.lblAzZ.Location = new System.Drawing.Point(425, 130);
            this.lblAzZ.Name = "lblAzZ";
            this.lblAzZ.Size = new System.Drawing.Size(14, 13);
            this.lblAzZ.TabIndex = 123;
            this.lblAzZ.Text = "Z";
            // 
            // lblAzY
            // 
            this.lblAzY.AutoSize = true;
            this.lblAzY.ForeColor = System.Drawing.Color.Black;
            this.lblAzY.Location = new System.Drawing.Point(382, 130);
            this.lblAzY.Name = "lblAzY";
            this.lblAzY.Size = new System.Drawing.Size(14, 13);
            this.lblAzY.TabIndex = 122;
            this.lblAzY.Text = "Y";
            // 
            // lblAzX
            // 
            this.lblAzX.AutoSize = true;
            this.lblAzX.ForeColor = System.Drawing.Color.Black;
            this.lblAzX.Location = new System.Drawing.Point(342, 130);
            this.lblAzX.Name = "lblAzX";
            this.lblAzX.Size = new System.Drawing.Size(14, 13);
            this.lblAzX.TabIndex = 121;
            this.lblAzX.Text = "X";
            // 
            // lblAzOffsets
            // 
            this.lblAzOffsets.AutoSize = true;
            this.lblAzOffsets.ForeColor = System.Drawing.Color.Black;
            this.lblAzOffsets.Location = new System.Drawing.Point(300, 130);
            this.lblAzOffsets.Name = "lblAzOffsets";
            this.lblAzOffsets.Size = new System.Drawing.Size(43, 13);
            this.lblAzOffsets.TabIndex = 120;
            this.lblAzOffsets.Text = "Offsets:";
            // 
            // chkAzBitResolution
            // 
            this.chkAzBitResolution.AutoSize = true;
            this.chkAzBitResolution.Checked = true;
            this.chkAzBitResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzBitResolution.Location = new System.Drawing.Point(298, 83);
            this.chkAzBitResolution.Name = "chkAzBitResolution";
            this.chkAzBitResolution.Size = new System.Drawing.Size(110, 17);
            this.chkAzBitResolution.TabIndex = 119;
            this.chkAzBitResolution.Text = "Full Bit Resolution";
            this.chkAzBitResolution.UseVisualStyleBackColor = true;
            // 
            // numAzFIFOSize
            // 
            this.numAzFIFOSize.Location = new System.Drawing.Point(244, 127);
            this.numAzFIFOSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numAzFIFOSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAzFIFOSize.Name = "numAzFIFOSize";
            this.numAzFIFOSize.Size = new System.Drawing.Size(43, 20);
            this.numAzFIFOSize.TabIndex = 118;
            this.numAzFIFOSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblAzFIFOSize
            // 
            this.lblAzFIFOSize.AutoSize = true;
            this.lblAzFIFOSize.ForeColor = System.Drawing.Color.Black;
            this.lblAzFIFOSize.Location = new System.Drawing.Point(182, 130);
            this.lblAzFIFOSize.Name = "lblAzFIFOSize";
            this.lblAzFIFOSize.Size = new System.Drawing.Size(56, 13);
            this.lblAzFIFOSize.TabIndex = 117;
            this.lblAzFIFOSize.Text = "FIFO Size:";
            // 
            // lblAzGRange
            // 
            this.lblAzGRange.AutoSize = true;
            this.lblAzGRange.ForeColor = System.Drawing.Color.Black;
            this.lblAzGRange.Location = new System.Drawing.Point(356, 107);
            this.lblAzGRange.Name = "lblAzGRange";
            this.lblAzGRange.Size = new System.Drawing.Size(53, 13);
            this.lblAzGRange.TabIndex = 116;
            this.lblAzGRange.Text = "G-Range:";
            // 
            // comboAzGRange
            // 
            this.comboAzGRange.BackColor = System.Drawing.SystemColors.Window;
            this.comboAzGRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAzGRange.FormattingEnabled = true;
            this.comboAzGRange.Items.AddRange(new object[] {
            "±16",
            "±8",
            "±4",
            "±2"});
            this.comboAzGRange.Location = new System.Drawing.Point(412, 104);
            this.comboAzGRange.Name = "comboAzGRange";
            this.comboAzGRange.Size = new System.Drawing.Size(51, 21);
            this.comboAzGRange.TabIndex = 115;
            // 
            // lblAzSamplingSpeed
            // 
            this.lblAzSamplingSpeed.AutoSize = true;
            this.lblAzSamplingSpeed.ForeColor = System.Drawing.Color.Black;
            this.lblAzSamplingSpeed.Location = new System.Drawing.Point(182, 107);
            this.lblAzSamplingSpeed.Name = "lblAzSamplingSpeed";
            this.lblAzSamplingSpeed.Size = new System.Drawing.Size(109, 13);
            this.lblAzSamplingSpeed.TabIndex = 114;
            this.lblAzSamplingSpeed.Text = "Sampling Speed (Hz):";
            // 
            // comboAzSamplingSpeed
            // 
            this.comboAzSamplingSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.comboAzSamplingSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAzSamplingSpeed.FormattingEnabled = true;
            this.comboAzSamplingSpeed.Items.AddRange(new object[] {
            "800",
            "400",
            "200",
            "100",
            "50",
            "25"});
            this.comboAzSamplingSpeed.Location = new System.Drawing.Point(297, 104);
            this.comboAzSamplingSpeed.Name = "comboAzSamplingSpeed";
            this.comboAzSamplingSpeed.Size = new System.Drawing.Size(51, 21);
            this.comboAzSamplingSpeed.TabIndex = 113;
            // 
            // lblAzAccelSettings
            // 
            this.lblAzAccelSettings.AutoSize = true;
            this.lblAzAccelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAzAccelSettings.ForeColor = System.Drawing.Color.Black;
            this.lblAzAccelSettings.Location = new System.Drawing.Point(182, 84);
            this.lblAzAccelSettings.Name = "lblAzAccelSettings";
            this.lblAzAccelSettings.Size = new System.Drawing.Size(110, 13);
            this.lblAzAccelSettings.TabIndex = 112;
            this.lblAzAccelSettings.Text = "Az Accelerometer:";
            // 
            // txtCbZ
            // 
            this.txtCbZ.Location = new System.Drawing.Point(441, 195);
            this.txtCbZ.Name = "txtCbZ";
            this.txtCbZ.Size = new System.Drawing.Size(22, 20);
            this.txtCbZ.TabIndex = 141;
            this.txtCbZ.Text = "0";
            // 
            // txtCbY
            // 
            this.txtCbY.Location = new System.Drawing.Point(399, 195);
            this.txtCbY.Name = "txtCbY";
            this.txtCbY.Size = new System.Drawing.Size(22, 20);
            this.txtCbY.TabIndex = 140;
            this.txtCbY.Text = "0";
            // 
            // txtCbX
            // 
            this.txtCbX.Location = new System.Drawing.Point(358, 195);
            this.txtCbX.Name = "txtCbX";
            this.txtCbX.Size = new System.Drawing.Size(22, 20);
            this.txtCbX.TabIndex = 139;
            this.txtCbX.Text = "0";
            // 
            // lblCbZ
            // 
            this.lblCbZ.AutoSize = true;
            this.lblCbZ.ForeColor = System.Drawing.Color.Black;
            this.lblCbZ.Location = new System.Drawing.Point(425, 198);
            this.lblCbZ.Name = "lblCbZ";
            this.lblCbZ.Size = new System.Drawing.Size(14, 13);
            this.lblCbZ.TabIndex = 138;
            this.lblCbZ.Text = "Z";
            // 
            // lblCbY
            // 
            this.lblCbY.AutoSize = true;
            this.lblCbY.ForeColor = System.Drawing.Color.Black;
            this.lblCbY.Location = new System.Drawing.Point(382, 198);
            this.lblCbY.Name = "lblCbY";
            this.lblCbY.Size = new System.Drawing.Size(14, 13);
            this.lblCbY.TabIndex = 137;
            this.lblCbY.Text = "Y";
            // 
            // lblCbX
            // 
            this.lblCbX.AutoSize = true;
            this.lblCbX.ForeColor = System.Drawing.Color.Black;
            this.lblCbX.Location = new System.Drawing.Point(342, 198);
            this.lblCbX.Name = "lblCbX";
            this.lblCbX.Size = new System.Drawing.Size(14, 13);
            this.lblCbX.TabIndex = 136;
            this.lblCbX.Text = "X";
            // 
            // lblCbOffsets
            // 
            this.lblCbOffsets.AutoSize = true;
            this.lblCbOffsets.ForeColor = System.Drawing.Color.Black;
            this.lblCbOffsets.Location = new System.Drawing.Point(300, 198);
            this.lblCbOffsets.Name = "lblCbOffsets";
            this.lblCbOffsets.Size = new System.Drawing.Size(43, 13);
            this.lblCbOffsets.TabIndex = 135;
            this.lblCbOffsets.Text = "Offsets:";
            // 
            // chkCbBitResolution
            // 
            this.chkCbBitResolution.AutoSize = true;
            this.chkCbBitResolution.Checked = true;
            this.chkCbBitResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCbBitResolution.Location = new System.Drawing.Point(298, 151);
            this.chkCbBitResolution.Name = "chkCbBitResolution";
            this.chkCbBitResolution.Size = new System.Drawing.Size(110, 17);
            this.chkCbBitResolution.TabIndex = 134;
            this.chkCbBitResolution.Text = "Full Bit Resolution";
            this.chkCbBitResolution.UseVisualStyleBackColor = true;
            // 
            // numCbFIFOSize
            // 
            this.numCbFIFOSize.Location = new System.Drawing.Point(244, 195);
            this.numCbFIFOSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numCbFIFOSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCbFIFOSize.Name = "numCbFIFOSize";
            this.numCbFIFOSize.Size = new System.Drawing.Size(43, 20);
            this.numCbFIFOSize.TabIndex = 133;
            this.numCbFIFOSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblCbFIFOSize
            // 
            this.lblCbFIFOSize.AutoSize = true;
            this.lblCbFIFOSize.ForeColor = System.Drawing.Color.Black;
            this.lblCbFIFOSize.Location = new System.Drawing.Point(182, 198);
            this.lblCbFIFOSize.Name = "lblCbFIFOSize";
            this.lblCbFIFOSize.Size = new System.Drawing.Size(56, 13);
            this.lblCbFIFOSize.TabIndex = 132;
            this.lblCbFIFOSize.Text = "FIFO Size:";
            // 
            // lblCbGRange
            // 
            this.lblCbGRange.AutoSize = true;
            this.lblCbGRange.ForeColor = System.Drawing.Color.Black;
            this.lblCbGRange.Location = new System.Drawing.Point(356, 175);
            this.lblCbGRange.Name = "lblCbGRange";
            this.lblCbGRange.Size = new System.Drawing.Size(53, 13);
            this.lblCbGRange.TabIndex = 131;
            this.lblCbGRange.Text = "G-Range:";
            // 
            // comboCbGRange
            // 
            this.comboCbGRange.BackColor = System.Drawing.SystemColors.Window;
            this.comboCbGRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCbGRange.FormattingEnabled = true;
            this.comboCbGRange.Items.AddRange(new object[] {
            "±16",
            "±8",
            "±4",
            "±2"});
            this.comboCbGRange.Location = new System.Drawing.Point(412, 172);
            this.comboCbGRange.Name = "comboCbGRange";
            this.comboCbGRange.Size = new System.Drawing.Size(51, 21);
            this.comboCbGRange.TabIndex = 130;
            // 
            // lblCbSamplingSpeed
            // 
            this.lblCbSamplingSpeed.AutoSize = true;
            this.lblCbSamplingSpeed.ForeColor = System.Drawing.Color.Black;
            this.lblCbSamplingSpeed.Location = new System.Drawing.Point(182, 175);
            this.lblCbSamplingSpeed.Name = "lblCbSamplingSpeed";
            this.lblCbSamplingSpeed.Size = new System.Drawing.Size(109, 13);
            this.lblCbSamplingSpeed.TabIndex = 129;
            this.lblCbSamplingSpeed.Text = "Sampling Speed (Hz):";
            // 
            // comboCbSamplingSpeed
            // 
            this.comboCbSamplingSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.comboCbSamplingSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCbSamplingSpeed.FormattingEnabled = true;
            this.comboCbSamplingSpeed.Items.AddRange(new object[] {
            "800",
            "400",
            "200",
            "100",
            "50",
            "25"});
            this.comboCbSamplingSpeed.Location = new System.Drawing.Point(297, 172);
            this.comboCbSamplingSpeed.Name = "comboCbSamplingSpeed";
            this.comboCbSamplingSpeed.Size = new System.Drawing.Size(51, 21);
            this.comboCbSamplingSpeed.TabIndex = 128;
            // 
            // lblCbAccelSettings
            // 
            this.lblCbAccelSettings.AutoSize = true;
            this.lblCbAccelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCbAccelSettings.ForeColor = System.Drawing.Color.Black;
            this.lblCbAccelSettings.Location = new System.Drawing.Point(182, 152);
            this.lblCbAccelSettings.Name = "lblCbAccelSettings";
            this.lblCbAccelSettings.Size = new System.Drawing.Size(111, 13);
            this.lblCbAccelSettings.TabIndex = 127;
            this.lblCbAccelSettings.Text = "Cb Accelerometer:";
            // 
            // txtTimerPeriod
            // 
            this.txtTimerPeriod.Location = new System.Drawing.Point(121, 161);
            this.txtTimerPeriod.Name = "txtTimerPeriod";
            this.txtTimerPeriod.Size = new System.Drawing.Size(36, 20);
            this.txtTimerPeriod.TabIndex = 143;
            this.txtTimerPeriod.Text = "1";
            // 
            // lblTimerPeriod
            // 
            this.lblTimerPeriod.AutoSize = true;
            this.lblTimerPeriod.ForeColor = System.Drawing.Color.Black;
            this.lblTimerPeriod.Location = new System.Drawing.Point(14, 164);
            this.lblTimerPeriod.Name = "lblTimerPeriod";
            this.lblTimerPeriod.Size = new System.Drawing.Size(91, 13);
            this.lblTimerPeriod.TabIndex = 142;
            this.lblTimerPeriod.Text = "Timer Period (ms):";
            // 
            // txtEthernetPeriod
            // 
            this.txtEthernetPeriod.Location = new System.Drawing.Point(121, 182);
            this.txtEthernetPeriod.Name = "txtEthernetPeriod";
            this.txtEthernetPeriod.Size = new System.Drawing.Size(36, 20);
            this.txtEthernetPeriod.TabIndex = 145;
            this.txtEthernetPeriod.Text = "250";
            // 
            // lblEthernetPeriod
            // 
            this.lblEthernetPeriod.AutoSize = true;
            this.lblEthernetPeriod.ForeColor = System.Drawing.Color.Black;
            this.lblEthernetPeriod.Location = new System.Drawing.Point(14, 185);
            this.lblEthernetPeriod.Name = "lblEthernetPeriod";
            this.lblEthernetPeriod.Size = new System.Drawing.Size(105, 13);
            this.lblEthernetPeriod.TabIndex = 144;
            this.lblEthernetPeriod.Text = "Ethernet Period (ms):";
            // 
            // txtTempPeriod
            // 
            this.txtTempPeriod.Location = new System.Drawing.Point(121, 203);
            this.txtTempPeriod.Name = "txtTempPeriod";
            this.txtTempPeriod.Size = new System.Drawing.Size(36, 20);
            this.txtTempPeriod.TabIndex = 147;
            this.txtTempPeriod.Text = "1000";
            // 
            // lblTempPeriod
            // 
            this.lblTempPeriod.AutoSize = true;
            this.lblTempPeriod.ForeColor = System.Drawing.Color.Black;
            this.lblTempPeriod.Location = new System.Drawing.Point(14, 206);
            this.lblTempPeriod.Name = "lblTempPeriod";
            this.lblTempPeriod.Size = new System.Drawing.Size(92, 13);
            this.lblTempPeriod.TabIndex = 146;
            this.lblTempPeriod.Text = "Temp Period (ms):";
            // 
            // txtEncoderPeriod
            // 
            this.txtEncoderPeriod.Location = new System.Drawing.Point(121, 224);
            this.txtEncoderPeriod.Name = "txtEncoderPeriod";
            this.txtEncoderPeriod.Size = new System.Drawing.Size(36, 20);
            this.txtEncoderPeriod.TabIndex = 149;
            this.txtEncoderPeriod.Text = "20";
            // 
            // lblEncoderPeriod
            // 
            this.lblEncoderPeriod.AutoSize = true;
            this.lblEncoderPeriod.ForeColor = System.Drawing.Color.Black;
            this.lblEncoderPeriod.Location = new System.Drawing.Point(14, 227);
            this.lblEncoderPeriod.Name = "lblEncoderPeriod";
            this.lblEncoderPeriod.Size = new System.Drawing.Size(105, 13);
            this.lblEncoderPeriod.TabIndex = 148;
            this.lblEncoderPeriod.Text = "Encoder Period (ms):";
            // 
            // frmTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 687);
            this.Controls.Add(this.btnFanToggle);
            this.Controls.Add(this.lblFanState);
            this.Controls.Add(this.lblAmbientHumidity);
            this.Controls.Add(this.lblAmbientTemp);
            this.Controls.Add(this.lsbErrorLogging);
            this.Controls.Add(this.ckbLogErrors);
            this.Controls.Add(this.lblErrorLogging);
            this.Controls.Add(this.gbSensorStatuses);
            this.Controls.Add(this.gbDataLogging);
            this.Controls.Add(this.btnCsvDrawing);
            this.Controls.Add(this.btnCustPacket);
            this.Controls.Add(this.lblCurrEl);
            this.Controls.Add(this.lblSensorInitChanged);
            this.Controls.Add(this.grpSensorInit);
            this.Controls.Add(this.grpTempUnit);
            this.Controls.Add(this.lblCurrAz);
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
            this.Text = "Sensor Network Demo and Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTcpTest_Paint);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpTempUnit.ResumeLayout(false);
            this.grpTempUnit.PerformLayout();
            this.grpSensorInit.ResumeLayout(false);
            this.grpSensorInit.PerformLayout();
            this.gbDataLogging.ResumeLayout(false);
            this.gbDataLogging.PerformLayout();
            this.gbSensorStatuses.ResumeLayout(false);
            this.gbSensorStatuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElFIFOSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAzFIFOSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCbFIFOSize)).EndInit();
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
        private System.Windows.Forms.Label lblCurrAz;
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
        private System.Windows.Forms.CheckBox chkAzTemp1Init;
        private System.Windows.Forms.CheckBox chkElTemp1Init;
        private System.Windows.Forms.Label lblListenConnected;
        private System.Windows.Forms.Label lblSensorInitChanged;
        private System.Windows.Forms.Label lblCurrEl;
        private System.Windows.Forms.Button btnCustPacket;
        private System.Windows.Forms.Button btnCsvDrawing;
        private System.Windows.Forms.GroupBox gbDataLogging;
        private System.Windows.Forms.Button btnStopLogging;
        private System.Windows.Forms.Button btnStartDataLogging;
        private System.Windows.Forms.Label lblDataFileName;
        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.GroupBox gbSensorStatuses;
        private System.Windows.Forms.Label lblElTempSensor1Status;
        private System.Windows.Forms.Label lblAzEncoderStatus;
        private System.Windows.Forms.Label lblElEncoderStatus;
        private System.Windows.Forms.Label lblCbAccStatus;
        private System.Windows.Forms.Label lblAzAccStatus;
        private System.Windows.Forms.Label lblElAccStatus;
        private System.Windows.Forms.Label lblAzTempSensor2Status;
        private System.Windows.Forms.Label lblAzTempSensor1Status;
        private System.Windows.Forms.Label lblElTempSensor2Status;
        private System.Windows.Forms.Label lblErrorLogging;
        private System.Windows.Forms.CheckBox ckbLogErrors;
        private System.Windows.Forms.ListBox lsbErrorLogging;
        private System.Windows.Forms.Label lblAmbTempHumidStatus;
        private System.Windows.Forms.Label lblAmbientHumidity;
        private System.Windows.Forms.Label lblAmbientTemp;
        private System.Windows.Forms.CheckBox chkAmbTempHumid;
        private System.Windows.Forms.Label lblFanState;
        private System.Windows.Forms.Button btnFanToggle;
        private System.Windows.Forms.TextBox txtEncoderPeriod;
        private System.Windows.Forms.Label lblEncoderPeriod;
        private System.Windows.Forms.TextBox txtTempPeriod;
        private System.Windows.Forms.Label lblTempPeriod;
        private System.Windows.Forms.TextBox txtEthernetPeriod;
        private System.Windows.Forms.Label lblEthernetPeriod;
        private System.Windows.Forms.TextBox txtTimerPeriod;
        private System.Windows.Forms.Label lblTimerPeriod;
        private System.Windows.Forms.TextBox txtCbZ;
        private System.Windows.Forms.TextBox txtCbY;
        private System.Windows.Forms.TextBox txtCbX;
        private System.Windows.Forms.Label lblCbZ;
        private System.Windows.Forms.Label lblCbY;
        private System.Windows.Forms.Label lblCbX;
        private System.Windows.Forms.Label lblCbOffsets;
        private System.Windows.Forms.CheckBox chkCbBitResolution;
        private System.Windows.Forms.NumericUpDown numCbFIFOSize;
        private System.Windows.Forms.Label lblCbFIFOSize;
        private System.Windows.Forms.Label lblCbGRange;
        private System.Windows.Forms.ComboBox comboCbGRange;
        private System.Windows.Forms.Label lblCbSamplingSpeed;
        private System.Windows.Forms.ComboBox comboCbSamplingSpeed;
        private System.Windows.Forms.Label lblCbAccelSettings;
        private System.Windows.Forms.TextBox txtAzZ;
        private System.Windows.Forms.TextBox txtAzY;
        private System.Windows.Forms.TextBox txtAzX;
        private System.Windows.Forms.Label lblAzZ;
        private System.Windows.Forms.Label lblAzY;
        private System.Windows.Forms.Label lblAzX;
        private System.Windows.Forms.Label lblAzOffsets;
        private System.Windows.Forms.CheckBox chkAzBitResolution;
        private System.Windows.Forms.NumericUpDown numAzFIFOSize;
        private System.Windows.Forms.Label lblAzFIFOSize;
        private System.Windows.Forms.Label lblAzGRange;
        private System.Windows.Forms.ComboBox comboAzGRange;
        private System.Windows.Forms.Label lblAzSamplingSpeed;
        private System.Windows.Forms.ComboBox comboAzSamplingSpeed;
        private System.Windows.Forms.Label lblAzAccelSettings;
        private System.Windows.Forms.TextBox txtElZ;
        private System.Windows.Forms.TextBox txtElY;
        private System.Windows.Forms.TextBox txtElX;
        private System.Windows.Forms.Label lblElZ;
        private System.Windows.Forms.Label lblElY;
        private System.Windows.Forms.Label lblElX;
        private System.Windows.Forms.Label lblElOffsets;
        private System.Windows.Forms.CheckBox chkElBitResolution;
        private System.Windows.Forms.NumericUpDown numElFIFOSize;
        private System.Windows.Forms.Label lblElFIFOSize;
        private System.Windows.Forms.Label lblElGRange;
        private System.Windows.Forms.ComboBox comboElGRange;
        private System.Windows.Forms.Label lblElSamplingSpeed;
        private System.Windows.Forms.ComboBox comboElSamplingSpeed;
        private System.Windows.Forms.Label lblElAccelSettings;
    }
}

