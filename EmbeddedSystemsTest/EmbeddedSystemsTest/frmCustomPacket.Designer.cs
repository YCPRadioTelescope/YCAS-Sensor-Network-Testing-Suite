namespace EmbeddedSystemsTest
{
    partial class frmCustomPacket
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
            this.grpSensorInit = new System.Windows.Forms.GroupBox();
            this.chkAzEncInit = new System.Windows.Forms.CheckBox();
            this.chkElEncInit = new System.Windows.Forms.CheckBox();
            this.chkCbAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkElAdxlInit = new System.Windows.Forms.CheckBox();
            this.chkAzTempInit = new System.Windows.Forms.CheckBox();
            this.chkElTempInit = new System.Windows.Forms.CheckBox();
            this.lblAzTemps = new System.Windows.Forms.Label();
            this.lblElTemps = new System.Windows.Forms.Label();
            this.txtElTemps = new System.Windows.Forms.TextBox();
            this.txtAzTemps = new System.Windows.Forms.TextBox();
            this.txtAzPositions = new System.Windows.Forms.TextBox();
            this.txtElPositions = new System.Windows.Forms.TextBox();
            this.lblAzEncoderData = new System.Windows.Forms.Label();
            this.lblElEncoderData = new System.Windows.Forms.Label();
            this.grpElAcclData = new System.Windows.Forms.GroupBox();
            this.txtElZ = new System.Windows.Forms.TextBox();
            this.lblElZ = new System.Windows.Forms.Label();
            this.txtElY = new System.Windows.Forms.TextBox();
            this.lblElY = new System.Windows.Forms.Label();
            this.txtElX = new System.Windows.Forms.TextBox();
            this.lblElX = new System.Windows.Forms.Label();
            this.grpAzAcclData = new System.Windows.Forms.GroupBox();
            this.txtAzZ = new System.Windows.Forms.TextBox();
            this.lblAzZ = new System.Windows.Forms.Label();
            this.txtAzY = new System.Windows.Forms.TextBox();
            this.lblAzY = new System.Windows.Forms.Label();
            this.txtAzX = new System.Windows.Forms.TextBox();
            this.lblAzX = new System.Windows.Forms.Label();
            this.grpCbAcclData = new System.Windows.Forms.GroupBox();
            this.txtCbZ = new System.Windows.Forms.TextBox();
            this.lblCbZ = new System.Windows.Forms.Label();
            this.txtCbY = new System.Windows.Forms.TextBox();
            this.lblCbY = new System.Windows.Forms.Label();
            this.txtCbX = new System.Windows.Forms.TextBox();
            this.lblCbX = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnSendOverTcp = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblPacketSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSensorInit.SuspendLayout();
            this.grpElAcclData.SuspendLayout();
            this.grpAzAcclData.SuspendLayout();
            this.grpCbAcclData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSensorInit
            // 
            this.grpSensorInit.Controls.Add(this.chkAzEncInit);
            this.grpSensorInit.Controls.Add(this.chkElEncInit);
            this.grpSensorInit.Controls.Add(this.chkCbAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkElAdxlInit);
            this.grpSensorInit.Controls.Add(this.chkAzTempInit);
            this.grpSensorInit.Controls.Add(this.chkElTempInit);
            this.grpSensorInit.Location = new System.Drawing.Point(379, 9);
            this.grpSensorInit.Name = "grpSensorInit";
            this.grpSensorInit.Size = new System.Drawing.Size(195, 150);
            this.grpSensorInit.TabIndex = 4;
            this.grpSensorInit.TabStop = false;
            this.grpSensorInit.Text = "Sensor Initialization";
            // 
            // chkAzEncInit
            // 
            this.chkAzEncInit.AutoSize = true;
            this.chkAzEncInit.Checked = true;
            this.chkAzEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzEncInit.Location = new System.Drawing.Point(11, 70);
            this.chkAzEncInit.Name = "chkAzEncInit";
            this.chkAzEncInit.Size = new System.Drawing.Size(106, 17);
            this.chkAzEncInit.TabIndex = 8;
            this.chkAzEncInit.Text = "Azimuth Encoder";
            this.chkAzEncInit.UseVisualStyleBackColor = true;
            this.chkAzEncInit.CheckedChanged += new System.EventHandler(this.chkAzEncInit_CheckedChanged);
            // 
            // chkElEncInit
            // 
            this.chkElEncInit.AutoSize = true;
            this.chkElEncInit.Checked = true;
            this.chkElEncInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElEncInit.Location = new System.Drawing.Point(11, 53);
            this.chkElEncInit.Name = "chkElEncInit";
            this.chkElEncInit.Size = new System.Drawing.Size(113, 17);
            this.chkElEncInit.TabIndex = 7;
            this.chkElEncInit.Text = "Elevation Encoder";
            this.chkElEncInit.UseVisualStyleBackColor = true;
            this.chkElEncInit.CheckedChanged += new System.EventHandler(this.chkElEncInit_CheckedChanged);
            // 
            // chkCbAdxlInit
            // 
            this.chkCbAdxlInit.AutoSize = true;
            this.chkCbAdxlInit.Checked = true;
            this.chkCbAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCbAdxlInit.Location = new System.Drawing.Point(11, 123);
            this.chkCbAdxlInit.Name = "chkCbAdxlInit";
            this.chkCbAdxlInit.Size = new System.Drawing.Size(172, 17);
            this.chkCbAdxlInit.TabIndex = 6;
            this.chkCbAdxlInit.Text = "Counterbalance Accelerometer";
            this.chkCbAdxlInit.UseVisualStyleBackColor = true;
            this.chkCbAdxlInit.CheckedChanged += new System.EventHandler(this.chkCbAdxlInit_CheckedChanged);
            // 
            // chkAzAdxlInit
            // 
            this.chkAzAdxlInit.AutoSize = true;
            this.chkAzAdxlInit.Checked = true;
            this.chkAzAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzAdxlInit.Location = new System.Drawing.Point(11, 105);
            this.chkAzAdxlInit.Name = "chkAzAdxlInit";
            this.chkAzAdxlInit.Size = new System.Drawing.Size(134, 17);
            this.chkAzAdxlInit.TabIndex = 5;
            this.chkAzAdxlInit.Text = "Azimuth Accelerometer";
            this.chkAzAdxlInit.UseVisualStyleBackColor = true;
            this.chkAzAdxlInit.CheckedChanged += new System.EventHandler(this.chkAzAdxlInit_CheckedChanged);
            // 
            // chkElAdxlInit
            // 
            this.chkElAdxlInit.AutoSize = true;
            this.chkElAdxlInit.Checked = true;
            this.chkElAdxlInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElAdxlInit.Location = new System.Drawing.Point(11, 87);
            this.chkElAdxlInit.Name = "chkElAdxlInit";
            this.chkElAdxlInit.Size = new System.Drawing.Size(141, 17);
            this.chkElAdxlInit.TabIndex = 4;
            this.chkElAdxlInit.Text = "Elevation Accelerometer";
            this.chkElAdxlInit.UseVisualStyleBackColor = true;
            this.chkElAdxlInit.CheckedChanged += new System.EventHandler(this.chkElAdxlInit_CheckedChanged);
            // 
            // chkAzTempInit
            // 
            this.chkAzTempInit.AutoSize = true;
            this.chkAzTempInit.Checked = true;
            this.chkAzTempInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAzTempInit.Location = new System.Drawing.Point(11, 36);
            this.chkAzTempInit.Name = "chkAzTempInit";
            this.chkAzTempInit.Size = new System.Drawing.Size(126, 17);
            this.chkAzTempInit.TabIndex = 2;
            this.chkAzTempInit.Text = "Azimuth Temperature";
            this.chkAzTempInit.UseVisualStyleBackColor = true;
            this.chkAzTempInit.CheckedChanged += new System.EventHandler(this.chkAzTempInit_CheckedChanged);
            // 
            // chkElTempInit
            // 
            this.chkElTempInit.AutoSize = true;
            this.chkElTempInit.Checked = true;
            this.chkElTempInit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkElTempInit.Location = new System.Drawing.Point(11, 19);
            this.chkElTempInit.Name = "chkElTempInit";
            this.chkElTempInit.Size = new System.Drawing.Size(133, 17);
            this.chkElTempInit.TabIndex = 0;
            this.chkElTempInit.Text = "Elevation Temperature";
            this.chkElTempInit.UseVisualStyleBackColor = true;
            this.chkElTempInit.CheckedChanged += new System.EventHandler(this.chkElTemp1Init_CheckedChanged);
            // 
            // lblAzTemps
            // 
            this.lblAzTemps.AutoSize = true;
            this.lblAzTemps.Location = new System.Drawing.Point(35, 48);
            this.lblAzTemps.Name = "lblAzTemps";
            this.lblAzTemps.Size = new System.Drawing.Size(115, 13);
            this.lblAzTemps.TabIndex = 32;
            this.lblAzTemps.Text = "Azimuth Temperatures:";
            // 
            // lblElTemps
            // 
            this.lblElTemps.AutoSize = true;
            this.lblElTemps.Location = new System.Drawing.Point(28, 12);
            this.lblElTemps.Name = "lblElTemps";
            this.lblElTemps.Size = new System.Drawing.Size(122, 13);
            this.lblElTemps.TabIndex = 31;
            this.lblElTemps.Text = "Elevation Temperatures:\r\n";
            // 
            // txtElTemps
            // 
            this.txtElTemps.Location = new System.Drawing.Point(151, 9);
            this.txtElTemps.Name = "txtElTemps";
            this.txtElTemps.Size = new System.Drawing.Size(222, 20);
            this.txtElTemps.TabIndex = 33;
            // 
            // txtAzTemps
            // 
            this.txtAzTemps.Location = new System.Drawing.Point(151, 45);
            this.txtAzTemps.Name = "txtAzTemps";
            this.txtAzTemps.Size = new System.Drawing.Size(222, 20);
            this.txtAzTemps.TabIndex = 34;
            // 
            // txtAzPositions
            // 
            this.txtAzPositions.Location = new System.Drawing.Point(151, 117);
            this.txtAzPositions.Name = "txtAzPositions";
            this.txtAzPositions.Size = new System.Drawing.Size(222, 20);
            this.txtAzPositions.TabIndex = 38;
            // 
            // txtElPositions
            // 
            this.txtElPositions.Location = new System.Drawing.Point(151, 81);
            this.txtElPositions.Name = "txtElPositions";
            this.txtElPositions.Size = new System.Drawing.Size(222, 20);
            this.txtElPositions.TabIndex = 37;
            // 
            // lblAzEncoderData
            // 
            this.lblAzEncoderData.AutoSize = true;
            this.lblAzEncoderData.Location = new System.Drawing.Point(6, 120);
            this.lblAzEncoderData.Name = "lblAzEncoderData";
            this.lblAzEncoderData.Size = new System.Drawing.Size(144, 13);
            this.lblAzEncoderData.TabIndex = 36;
            this.lblAzEncoderData.Text = "Azimuth Encoder Orientation:";
            // 
            // lblElEncoderData
            // 
            this.lblElEncoderData.AutoSize = true;
            this.lblElEncoderData.Location = new System.Drawing.Point(-1, 84);
            this.lblElEncoderData.Name = "lblElEncoderData";
            this.lblElEncoderData.Size = new System.Drawing.Size(151, 13);
            this.lblElEncoderData.TabIndex = 35;
            this.lblElEncoderData.Text = "Elevation Encoder Orientation:";
            // 
            // grpElAcclData
            // 
            this.grpElAcclData.Controls.Add(this.txtElZ);
            this.grpElAcclData.Controls.Add(this.lblElZ);
            this.grpElAcclData.Controls.Add(this.txtElY);
            this.grpElAcclData.Controls.Add(this.lblElY);
            this.grpElAcclData.Controls.Add(this.txtElX);
            this.grpElAcclData.Controls.Add(this.lblElX);
            this.grpElAcclData.Location = new System.Drawing.Point(3, 268);
            this.grpElAcclData.Name = "grpElAcclData";
            this.grpElAcclData.Size = new System.Drawing.Size(571, 108);
            this.grpElAcclData.TabIndex = 39;
            this.grpElAcclData.TabStop = false;
            this.grpElAcclData.Text = "Elevation Accelerometer Data";
            // 
            // txtElZ
            // 
            this.txtElZ.Location = new System.Drawing.Point(39, 71);
            this.txtElZ.Name = "txtElZ";
            this.txtElZ.Size = new System.Drawing.Size(520, 20);
            this.txtElZ.TabIndex = 5;
            // 
            // lblElZ
            // 
            this.lblElZ.AutoSize = true;
            this.lblElZ.Location = new System.Drawing.Point(15, 74);
            this.lblElZ.Name = "lblElZ";
            this.lblElZ.Size = new System.Drawing.Size(17, 13);
            this.lblElZ.TabIndex = 4;
            this.lblElZ.Text = "Z:";
            // 
            // txtElY
            // 
            this.txtElY.Location = new System.Drawing.Point(39, 45);
            this.txtElY.Name = "txtElY";
            this.txtElY.Size = new System.Drawing.Size(520, 20);
            this.txtElY.TabIndex = 3;
            // 
            // lblElY
            // 
            this.lblElY.AutoSize = true;
            this.lblElY.Location = new System.Drawing.Point(16, 48);
            this.lblElY.Name = "lblElY";
            this.lblElY.Size = new System.Drawing.Size(17, 13);
            this.lblElY.TabIndex = 2;
            this.lblElY.Text = "Y:";
            // 
            // txtElX
            // 
            this.txtElX.Location = new System.Drawing.Point(39, 19);
            this.txtElX.Name = "txtElX";
            this.txtElX.Size = new System.Drawing.Size(520, 20);
            this.txtElX.TabIndex = 1;
            // 
            // lblElX
            // 
            this.lblElX.AutoSize = true;
            this.lblElX.Location = new System.Drawing.Point(16, 22);
            this.lblElX.Name = "lblElX";
            this.lblElX.Size = new System.Drawing.Size(17, 13);
            this.lblElX.TabIndex = 0;
            this.lblElX.Text = "X:";
            // 
            // grpAzAcclData
            // 
            this.grpAzAcclData.Controls.Add(this.txtAzZ);
            this.grpAzAcclData.Controls.Add(this.lblAzZ);
            this.grpAzAcclData.Controls.Add(this.txtAzY);
            this.grpAzAcclData.Controls.Add(this.lblAzY);
            this.grpAzAcclData.Controls.Add(this.txtAzX);
            this.grpAzAcclData.Controls.Add(this.lblAzX);
            this.grpAzAcclData.Location = new System.Drawing.Point(3, 158);
            this.grpAzAcclData.Name = "grpAzAcclData";
            this.grpAzAcclData.Size = new System.Drawing.Size(571, 108);
            this.grpAzAcclData.TabIndex = 40;
            this.grpAzAcclData.TabStop = false;
            this.grpAzAcclData.Text = "Azimuth Accelerometer Data";
            // 
            // txtAzZ
            // 
            this.txtAzZ.Location = new System.Drawing.Point(39, 71);
            this.txtAzZ.Name = "txtAzZ";
            this.txtAzZ.Size = new System.Drawing.Size(520, 20);
            this.txtAzZ.TabIndex = 5;
            // 
            // lblAzZ
            // 
            this.lblAzZ.AutoSize = true;
            this.lblAzZ.Location = new System.Drawing.Point(15, 74);
            this.lblAzZ.Name = "lblAzZ";
            this.lblAzZ.Size = new System.Drawing.Size(17, 13);
            this.lblAzZ.TabIndex = 4;
            this.lblAzZ.Text = "Z:";
            // 
            // txtAzY
            // 
            this.txtAzY.Location = new System.Drawing.Point(39, 45);
            this.txtAzY.Name = "txtAzY";
            this.txtAzY.Size = new System.Drawing.Size(520, 20);
            this.txtAzY.TabIndex = 3;
            // 
            // lblAzY
            // 
            this.lblAzY.AutoSize = true;
            this.lblAzY.Location = new System.Drawing.Point(16, 48);
            this.lblAzY.Name = "lblAzY";
            this.lblAzY.Size = new System.Drawing.Size(17, 13);
            this.lblAzY.TabIndex = 2;
            this.lblAzY.Text = "Y:";
            // 
            // txtAzX
            // 
            this.txtAzX.Location = new System.Drawing.Point(39, 19);
            this.txtAzX.Name = "txtAzX";
            this.txtAzX.Size = new System.Drawing.Size(520, 20);
            this.txtAzX.TabIndex = 1;
            // 
            // lblAzX
            // 
            this.lblAzX.AutoSize = true;
            this.lblAzX.Location = new System.Drawing.Point(16, 22);
            this.lblAzX.Name = "lblAzX";
            this.lblAzX.Size = new System.Drawing.Size(17, 13);
            this.lblAzX.TabIndex = 0;
            this.lblAzX.Text = "X:";
            // 
            // grpCbAcclData
            // 
            this.grpCbAcclData.Controls.Add(this.txtCbZ);
            this.grpCbAcclData.Controls.Add(this.lblCbZ);
            this.grpCbAcclData.Controls.Add(this.txtCbY);
            this.grpCbAcclData.Controls.Add(this.lblCbY);
            this.grpCbAcclData.Controls.Add(this.txtCbX);
            this.grpCbAcclData.Controls.Add(this.lblCbX);
            this.grpCbAcclData.Location = new System.Drawing.Point(3, 378);
            this.grpCbAcclData.Name = "grpCbAcclData";
            this.grpCbAcclData.Size = new System.Drawing.Size(571, 108);
            this.grpCbAcclData.TabIndex = 41;
            this.grpCbAcclData.TabStop = false;
            this.grpCbAcclData.Text = "Counterbalance Accelerometer Data";
            // 
            // txtCbZ
            // 
            this.txtCbZ.Location = new System.Drawing.Point(39, 71);
            this.txtCbZ.Name = "txtCbZ";
            this.txtCbZ.Size = new System.Drawing.Size(520, 20);
            this.txtCbZ.TabIndex = 5;
            // 
            // lblCbZ
            // 
            this.lblCbZ.AutoSize = true;
            this.lblCbZ.Location = new System.Drawing.Point(15, 74);
            this.lblCbZ.Name = "lblCbZ";
            this.lblCbZ.Size = new System.Drawing.Size(17, 13);
            this.lblCbZ.TabIndex = 4;
            this.lblCbZ.Text = "Z:";
            // 
            // txtCbY
            // 
            this.txtCbY.Location = new System.Drawing.Point(39, 45);
            this.txtCbY.Name = "txtCbY";
            this.txtCbY.Size = new System.Drawing.Size(520, 20);
            this.txtCbY.TabIndex = 3;
            // 
            // lblCbY
            // 
            this.lblCbY.AutoSize = true;
            this.lblCbY.Location = new System.Drawing.Point(16, 48);
            this.lblCbY.Name = "lblCbY";
            this.lblCbY.Size = new System.Drawing.Size(17, 13);
            this.lblCbY.TabIndex = 2;
            this.lblCbY.Text = "Y:";
            // 
            // txtCbX
            // 
            this.txtCbX.Location = new System.Drawing.Point(39, 19);
            this.txtCbX.Name = "txtCbX";
            this.txtCbX.Size = new System.Drawing.Size(520, 20);
            this.txtCbX.TabIndex = 1;
            // 
            // lblCbX
            // 
            this.lblCbX.AutoSize = true;
            this.lblCbX.Location = new System.Drawing.Point(16, 22);
            this.lblCbX.Name = "lblCbX";
            this.lblCbX.Size = new System.Drawing.Size(17, 13);
            this.lblCbX.TabIndex = 0;
            this.lblCbX.Text = "X:";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(501, 550);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(74, 23);
            this.btnSaveToFile.TabIndex = 42;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnSendOverTcp
            // 
            this.btnSendOverTcp.Location = new System.Drawing.Point(394, 550);
            this.btnSendOverTcp.Name = "btnSendOverTcp";
            this.btnSendOverTcp.Size = new System.Drawing.Size(101, 23);
            this.btnSendOverTcp.TabIndex = 43;
            this.btnSendOverTcp.Text = "Send Over TCP";
            this.btnSendOverTcp.UseVisualStyleBackColor = true;
            this.btnSendOverTcp.Click += new System.EventHandler(this.btnSendOverTcp_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(445, 524);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(97, 20);
            this.txtFilename.TabIndex = 44;
            this.txtFilename.Text = "newpacket";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(384, 527);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(183, 13);
            this.lblFilename.TabIndex = 45;
            this.lblFilename.Text = "File name:                                    .snp";
            // 
            // lblPacketSize
            // 
            this.lblPacketSize.AutoSize = true;
            this.lblPacketSize.Location = new System.Drawing.Point(329, 510);
            this.lblPacketSize.Name = "lblPacketSize";
            this.lblPacketSize.Size = new System.Drawing.Size(110, 13);
            this.lblPacketSize.TabIndex = 46;
            this.lblPacketSize.Text = "Packet size (in bytes):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type data in separated by comma. Ex: (1, 2, 3, 4)\r\nThe maximum packet size is 204" +
    "8 bytes.";
            // 
            // frmCustomPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPacketSize);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnSendOverTcp);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.grpCbAcclData);
            this.Controls.Add(this.grpAzAcclData);
            this.Controls.Add(this.grpElAcclData);
            this.Controls.Add(this.txtAzPositions);
            this.Controls.Add(this.txtElPositions);
            this.Controls.Add(this.lblAzEncoderData);
            this.Controls.Add(this.lblElEncoderData);
            this.Controls.Add(this.txtAzTemps);
            this.Controls.Add(this.txtElTemps);
            this.Controls.Add(this.lblAzTemps);
            this.Controls.Add(this.lblElTemps);
            this.Controls.Add(this.grpSensorInit);
            this.Controls.Add(this.lblFilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCustomPacket";
            this.Text = "Custom Packet Form";
            this.grpSensorInit.ResumeLayout(false);
            this.grpSensorInit.PerformLayout();
            this.grpElAcclData.ResumeLayout(false);
            this.grpElAcclData.PerformLayout();
            this.grpAzAcclData.ResumeLayout(false);
            this.grpAzAcclData.PerformLayout();
            this.grpCbAcclData.ResumeLayout(false);
            this.grpCbAcclData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSensorInit;
        private System.Windows.Forms.CheckBox chkAzEncInit;
        private System.Windows.Forms.CheckBox chkElEncInit;
        private System.Windows.Forms.CheckBox chkCbAdxlInit;
        private System.Windows.Forms.CheckBox chkAzAdxlInit;
        private System.Windows.Forms.CheckBox chkElAdxlInit;
        private System.Windows.Forms.CheckBox chkAzTempInit;
        private System.Windows.Forms.CheckBox chkElTempInit;
        private System.Windows.Forms.Label lblAzTemps;
        private System.Windows.Forms.Label lblElTemps;
        private System.Windows.Forms.TextBox txtElTemps;
        private System.Windows.Forms.TextBox txtAzTemps;
        private System.Windows.Forms.TextBox txtAzPositions;
        private System.Windows.Forms.TextBox txtElPositions;
        private System.Windows.Forms.Label lblAzEncoderData;
        private System.Windows.Forms.Label lblElEncoderData;
        private System.Windows.Forms.GroupBox grpElAcclData;
        private System.Windows.Forms.TextBox txtElZ;
        private System.Windows.Forms.Label lblElZ;
        private System.Windows.Forms.TextBox txtElY;
        private System.Windows.Forms.Label lblElY;
        private System.Windows.Forms.TextBox txtElX;
        private System.Windows.Forms.Label lblElX;
        private System.Windows.Forms.GroupBox grpAzAcclData;
        private System.Windows.Forms.TextBox txtAzZ;
        private System.Windows.Forms.Label lblAzZ;
        private System.Windows.Forms.TextBox txtAzY;
        private System.Windows.Forms.Label lblAzY;
        private System.Windows.Forms.TextBox txtAzX;
        private System.Windows.Forms.Label lblAzX;
        private System.Windows.Forms.GroupBox grpCbAcclData;
        private System.Windows.Forms.TextBox txtCbZ;
        private System.Windows.Forms.Label lblCbZ;
        private System.Windows.Forms.TextBox txtCbY;
        private System.Windows.Forms.Label lblCbY;
        private System.Windows.Forms.TextBox txtCbX;
        private System.Windows.Forms.Label lblCbX;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnSendOverTcp;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblPacketSize;
        private System.Windows.Forms.Label label1;
    }
}