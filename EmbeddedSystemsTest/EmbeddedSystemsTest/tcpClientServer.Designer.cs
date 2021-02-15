
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
            this.lblListenConnected = new System.Windows.Forms.Label();
            this.txtClientData = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.lblReceived = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAllResponses = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkAccumulateServer = new System.Windows.Forms.CheckBox();
            this.chkAccumulateClient = new System.Windows.Forms.CheckBox();
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
            this.btnStartClient.Location = new System.Drawing.Point(362, 72);
            this.btnStartClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(100, 21);
            this.btnStartClient.TabIndex = 6;
            this.btnStartClient.Text = "Send Data";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
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
            // txtClientData
            // 
            this.txtClientData.Location = new System.Drawing.Point(362, 49);
            this.txtClientData.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientData.Name = "txtClientData";
            this.txtClientData.Size = new System.Drawing.Size(101, 20);
            this.txtClientData.TabIndex = 5;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(247, 98);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(118, 13);
            this.lblResponse.TabIndex = 17;
            this.lblResponse.Text = "Responses from server:";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(249, 114);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(214, 98);
            this.txtResponse.TabIndex = 18;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(16, 114);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ReadOnly = true;
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(214, 98);
            this.txtReceived.TabIndex = 20;
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(14, 98);
            this.lblReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(107, 13);
            this.lblReceived.TabIndex = 19;
            this.lblReceived.Text = "Received from client:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 215);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 21);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAllResponses
            // 
            this.btnClearAllResponses.Location = new System.Drawing.Point(249, 216);
            this.btnClearAllResponses.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllResponses.Name = "btnClearAllResponses";
            this.btnClearAllResponses.Size = new System.Drawing.Size(104, 21);
            this.btnClearAllResponses.TabIndex = 8;
            this.btnClearAllResponses.Text = "Clear responses";
            this.btnClearAllResponses.UseVisualStyleBackColor = true;
            this.btnClearAllResponses.Click += new System.EventHandler(this.btnClearAllResponses_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 238);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 13);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Last received: Never";
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
            // chkAccumulateClient
            // 
            this.chkAccumulateClient.AutoSize = true;
            this.chkAccumulateClient.Checked = true;
            this.chkAccumulateClient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccumulateClient.Location = new System.Drawing.Point(358, 219);
            this.chkAccumulateClient.Name = "chkAccumulateClient";
            this.chkAccumulateClient.Size = new System.Drawing.Size(106, 17);
            this.chkAccumulateClient.TabIndex = 23;
            this.chkAccumulateClient.Text = "Accumulate data";
            this.chkAccumulateClient.UseVisualStyleBackColor = true;
            // 
            // frmTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 256);
            this.Controls.Add(this.chkAccumulateClient);
            this.Controls.Add(this.chkAccumulateServer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnClearAllResponses);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblResponse);
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
        private System.Windows.Forms.Label lblListenConnected;
        private System.Windows.Forms.TextBox txtClientData;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAllResponses;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkAccumulateServer;
        private System.Windows.Forms.CheckBox chkAccumulateClient;
    }
}

