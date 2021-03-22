namespace EmbeddedSystemsTest
{
    partial class frmDataDrawer
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
            this.panDrawData = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl40 = new System.Windows.Forms.Label();
            this.lbl60 = new System.Windows.Forms.Label();
            this.lbl80 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl120 = new System.Windows.Forms.Label();
            this.lbl140 = new System.Windows.Forms.Label();
            this.lbl160 = new System.Windows.Forms.Label();
            this.lbl180 = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl220 = new System.Windows.Forms.Label();
            this.lbl240 = new System.Windows.Forms.Label();
            this.lbl260 = new System.Windows.Forms.Label();
            this.lbl280 = new System.Windows.Forms.Label();
            this.lbl300 = new System.Windows.Forms.Label();
            this.lbl320 = new System.Windows.Forms.Label();
            this.lbl340 = new System.Windows.Forms.Label();
            this.lbl360 = new System.Windows.Forms.Label();
            this.lbl380 = new System.Windows.Forms.Label();
            this.lbl400 = new System.Windows.Forms.Label();
            this.lbl420 = new System.Windows.Forms.Label();
            this.lbl440 = new System.Windows.Forms.Label();
            this.lbl460 = new System.Windows.Forms.Label();
            this.lbln20 = new System.Windows.Forms.Label();
            this.lbln40 = new System.Windows.Forms.Label();
            this.lbln60 = new System.Windows.Forms.Label();
            this.lbln80 = new System.Windows.Forms.Label();
            this.lbln100 = new System.Windows.Forms.Label();
            this.lbln120 = new System.Windows.Forms.Label();
            this.lbln140 = new System.Windows.Forms.Label();
            this.lbln160 = new System.Windows.Forms.Label();
            this.lbln180 = new System.Windows.Forms.Label();
            this.lbln200 = new System.Windows.Forms.Label();
            this.lblDataPoints = new System.Windows.Forms.Label();
            this.lblCurrValue = new System.Windows.Forms.Label();
            this.radSinglePoint = new System.Windows.Forms.RadioButton();
            this.radDrawPoints = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panDrawData
            // 
            this.panDrawData.BackColor = System.Drawing.Color.DarkGray;
            this.panDrawData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panDrawData.Location = new System.Drawing.Point(58, 27);
            this.panDrawData.Name = "panDrawData";
            this.panDrawData.Size = new System.Drawing.Size(700, 660);
            this.panDrawData.TabIndex = 0;
            this.panDrawData.Paint += new System.Windows.Forms.PaintEventHandler(this.panDrawData_Paint);
            this.panDrawData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDrawData_MouseDown);
            this.panDrawData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panDrawData_MouseMove);
            this.panDrawData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panDrawData_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(641, 730);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save as CSV";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(525, 730);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Panel";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(641, 704);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(97, 20);
            this.txtFilename.TabIndex = 46;
            this.txtFilename.Text = "newcsv";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(588, 707);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(177, 13);
            this.lblFilename.TabIndex = 47;
            this.lblFilename.Text = "File name:                                  .csv";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(39, 480);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(19, 13);
            this.lbl0.TabIndex = 0;
            this.lbl0.Text = "0 -";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(33, 460);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(25, 13);
            this.lbl20.TabIndex = 48;
            this.lbl20.Text = "20 -";
            // 
            // lbl40
            // 
            this.lbl40.AutoSize = true;
            this.lbl40.Location = new System.Drawing.Point(33, 440);
            this.lbl40.Name = "lbl40";
            this.lbl40.Size = new System.Drawing.Size(25, 13);
            this.lbl40.TabIndex = 49;
            this.lbl40.Text = "40 -";
            // 
            // lbl60
            // 
            this.lbl60.AutoSize = true;
            this.lbl60.Location = new System.Drawing.Point(33, 420);
            this.lbl60.Name = "lbl60";
            this.lbl60.Size = new System.Drawing.Size(25, 13);
            this.lbl60.TabIndex = 50;
            this.lbl60.Text = "60 -";
            // 
            // lbl80
            // 
            this.lbl80.AutoSize = true;
            this.lbl80.Location = new System.Drawing.Point(33, 400);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(25, 13);
            this.lbl80.TabIndex = 51;
            this.lbl80.Text = "80 -";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(27, 380);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(31, 13);
            this.lbl100.TabIndex = 52;
            this.lbl100.Text = "100 -";
            // 
            // lbl120
            // 
            this.lbl120.AutoSize = true;
            this.lbl120.Location = new System.Drawing.Point(27, 360);
            this.lbl120.Name = "lbl120";
            this.lbl120.Size = new System.Drawing.Size(31, 13);
            this.lbl120.TabIndex = 53;
            this.lbl120.Text = "120 -";
            // 
            // lbl140
            // 
            this.lbl140.AutoSize = true;
            this.lbl140.Location = new System.Drawing.Point(27, 340);
            this.lbl140.Name = "lbl140";
            this.lbl140.Size = new System.Drawing.Size(31, 13);
            this.lbl140.TabIndex = 54;
            this.lbl140.Text = "140 -";
            // 
            // lbl160
            // 
            this.lbl160.AutoSize = true;
            this.lbl160.Location = new System.Drawing.Point(27, 320);
            this.lbl160.Name = "lbl160";
            this.lbl160.Size = new System.Drawing.Size(31, 13);
            this.lbl160.TabIndex = 55;
            this.lbl160.Text = "160 -";
            // 
            // lbl180
            // 
            this.lbl180.AutoSize = true;
            this.lbl180.Location = new System.Drawing.Point(27, 300);
            this.lbl180.Name = "lbl180";
            this.lbl180.Size = new System.Drawing.Size(31, 13);
            this.lbl180.TabIndex = 56;
            this.lbl180.Text = "180 -";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Location = new System.Drawing.Point(27, 280);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(31, 13);
            this.lbl200.TabIndex = 57;
            this.lbl200.Text = "200 -";
            // 
            // lbl220
            // 
            this.lbl220.AutoSize = true;
            this.lbl220.Location = new System.Drawing.Point(27, 260);
            this.lbl220.Name = "lbl220";
            this.lbl220.Size = new System.Drawing.Size(31, 13);
            this.lbl220.TabIndex = 58;
            this.lbl220.Text = "220 -";
            // 
            // lbl240
            // 
            this.lbl240.AutoSize = true;
            this.lbl240.Location = new System.Drawing.Point(27, 240);
            this.lbl240.Name = "lbl240";
            this.lbl240.Size = new System.Drawing.Size(31, 13);
            this.lbl240.TabIndex = 59;
            this.lbl240.Text = "240 -";
            // 
            // lbl260
            // 
            this.lbl260.AutoSize = true;
            this.lbl260.Location = new System.Drawing.Point(27, 220);
            this.lbl260.Name = "lbl260";
            this.lbl260.Size = new System.Drawing.Size(31, 13);
            this.lbl260.TabIndex = 60;
            this.lbl260.Text = "260 -";
            // 
            // lbl280
            // 
            this.lbl280.AutoSize = true;
            this.lbl280.Location = new System.Drawing.Point(27, 200);
            this.lbl280.Name = "lbl280";
            this.lbl280.Size = new System.Drawing.Size(31, 13);
            this.lbl280.TabIndex = 61;
            this.lbl280.Text = "280 -";
            // 
            // lbl300
            // 
            this.lbl300.AutoSize = true;
            this.lbl300.Location = new System.Drawing.Point(27, 180);
            this.lbl300.Name = "lbl300";
            this.lbl300.Size = new System.Drawing.Size(31, 13);
            this.lbl300.TabIndex = 62;
            this.lbl300.Text = "300 -";
            // 
            // lbl320
            // 
            this.lbl320.AutoSize = true;
            this.lbl320.Location = new System.Drawing.Point(27, 160);
            this.lbl320.Name = "lbl320";
            this.lbl320.Size = new System.Drawing.Size(31, 13);
            this.lbl320.TabIndex = 63;
            this.lbl320.Text = "320 -";
            // 
            // lbl340
            // 
            this.lbl340.AutoSize = true;
            this.lbl340.Location = new System.Drawing.Point(27, 140);
            this.lbl340.Name = "lbl340";
            this.lbl340.Size = new System.Drawing.Size(31, 13);
            this.lbl340.TabIndex = 64;
            this.lbl340.Text = "340 -";
            // 
            // lbl360
            // 
            this.lbl360.AutoSize = true;
            this.lbl360.Location = new System.Drawing.Point(27, 120);
            this.lbl360.Name = "lbl360";
            this.lbl360.Size = new System.Drawing.Size(31, 13);
            this.lbl360.TabIndex = 65;
            this.lbl360.Text = "360 -";
            // 
            // lbl380
            // 
            this.lbl380.AutoSize = true;
            this.lbl380.Location = new System.Drawing.Point(27, 100);
            this.lbl380.Name = "lbl380";
            this.lbl380.Size = new System.Drawing.Size(31, 13);
            this.lbl380.TabIndex = 66;
            this.lbl380.Text = "380 -";
            // 
            // lbl400
            // 
            this.lbl400.AutoSize = true;
            this.lbl400.Location = new System.Drawing.Point(27, 80);
            this.lbl400.Name = "lbl400";
            this.lbl400.Size = new System.Drawing.Size(31, 13);
            this.lbl400.TabIndex = 67;
            this.lbl400.Text = "400 -";
            // 
            // lbl420
            // 
            this.lbl420.AutoSize = true;
            this.lbl420.Location = new System.Drawing.Point(27, 60);
            this.lbl420.Name = "lbl420";
            this.lbl420.Size = new System.Drawing.Size(31, 13);
            this.lbl420.TabIndex = 68;
            this.lbl420.Text = "420 -";
            // 
            // lbl440
            // 
            this.lbl440.AutoSize = true;
            this.lbl440.Location = new System.Drawing.Point(27, 40);
            this.lbl440.Name = "lbl440";
            this.lbl440.Size = new System.Drawing.Size(31, 13);
            this.lbl440.TabIndex = 69;
            this.lbl440.Text = "440 -";
            // 
            // lbl460
            // 
            this.lbl460.AutoSize = true;
            this.lbl460.Location = new System.Drawing.Point(27, 20);
            this.lbl460.Name = "lbl460";
            this.lbl460.Size = new System.Drawing.Size(31, 13);
            this.lbl460.TabIndex = 70;
            this.lbl460.Text = "460 -";
            // 
            // lbln20
            // 
            this.lbln20.AutoSize = true;
            this.lbln20.Location = new System.Drawing.Point(30, 500);
            this.lbln20.Name = "lbln20";
            this.lbln20.Size = new System.Drawing.Size(28, 13);
            this.lbln20.TabIndex = 71;
            this.lbln20.Text = "-20 -";
            // 
            // lbln40
            // 
            this.lbln40.AutoSize = true;
            this.lbln40.Location = new System.Drawing.Point(30, 520);
            this.lbln40.Name = "lbln40";
            this.lbln40.Size = new System.Drawing.Size(28, 13);
            this.lbln40.TabIndex = 72;
            this.lbln40.Text = "-40 -";
            // 
            // lbln60
            // 
            this.lbln60.AutoSize = true;
            this.lbln60.Location = new System.Drawing.Point(30, 540);
            this.lbln60.Name = "lbln60";
            this.lbln60.Size = new System.Drawing.Size(28, 13);
            this.lbln60.TabIndex = 73;
            this.lbln60.Text = "-60 -";
            // 
            // lbln80
            // 
            this.lbln80.AutoSize = true;
            this.lbln80.Location = new System.Drawing.Point(30, 560);
            this.lbln80.Name = "lbln80";
            this.lbln80.Size = new System.Drawing.Size(28, 13);
            this.lbln80.TabIndex = 74;
            this.lbln80.Text = "-80 -";
            // 
            // lbln100
            // 
            this.lbln100.AutoSize = true;
            this.lbln100.Location = new System.Drawing.Point(24, 580);
            this.lbln100.Name = "lbln100";
            this.lbln100.Size = new System.Drawing.Size(34, 13);
            this.lbln100.TabIndex = 75;
            this.lbln100.Text = "-100 -";
            // 
            // lbln120
            // 
            this.lbln120.AutoSize = true;
            this.lbln120.Location = new System.Drawing.Point(24, 600);
            this.lbln120.Name = "lbln120";
            this.lbln120.Size = new System.Drawing.Size(34, 13);
            this.lbln120.TabIndex = 76;
            this.lbln120.Text = "-120 -";
            // 
            // lbln140
            // 
            this.lbln140.AutoSize = true;
            this.lbln140.Location = new System.Drawing.Point(24, 620);
            this.lbln140.Name = "lbln140";
            this.lbln140.Size = new System.Drawing.Size(34, 13);
            this.lbln140.TabIndex = 77;
            this.lbln140.Text = "-140 -";
            // 
            // lbln160
            // 
            this.lbln160.AutoSize = true;
            this.lbln160.Location = new System.Drawing.Point(24, 640);
            this.lbln160.Name = "lbln160";
            this.lbln160.Size = new System.Drawing.Size(34, 13);
            this.lbln160.TabIndex = 78;
            this.lbln160.Text = "-160 -";
            // 
            // lbln180
            // 
            this.lbln180.AutoSize = true;
            this.lbln180.Location = new System.Drawing.Point(24, 660);
            this.lbln180.Name = "lbln180";
            this.lbln180.Size = new System.Drawing.Size(34, 13);
            this.lbln180.TabIndex = 79;
            this.lbln180.Text = "-180 -";
            // 
            // lbln200
            // 
            this.lbln200.AutoSize = true;
            this.lbln200.Location = new System.Drawing.Point(24, 680);
            this.lbln200.Name = "lbln200";
            this.lbln200.Size = new System.Drawing.Size(34, 13);
            this.lbln200.TabIndex = 80;
            this.lbln200.Text = "-200 -";
            // 
            // lblDataPoints
            // 
            this.lblDataPoints.AutoSize = true;
            this.lblDataPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPoints.Location = new System.Drawing.Point(70, 730);
            this.lblDataPoints.Name = "lblDataPoints";
            this.lblDataPoints.Size = new System.Drawing.Size(108, 20);
            this.lblDataPoints.TabIndex = 81;
            this.lblDataPoints.Text = "Data points: 0";
            // 
            // lblCurrValue
            // 
            this.lblCurrValue.AutoSize = true;
            this.lblCurrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrValue.Location = new System.Drawing.Point(54, 707);
            this.lblCurrValue.Name = "lblCurrValue";
            this.lblCurrValue.Size = new System.Drawing.Size(124, 20);
            this.lblCurrValue.TabIndex = 82;
            this.lblCurrValue.Text = "Current Value: 0";
            // 
            // radSinglePoint
            // 
            this.radSinglePoint.AutoSize = true;
            this.radSinglePoint.Location = new System.Drawing.Point(376, 710);
            this.radSinglePoint.Name = "radSinglePoint";
            this.radSinglePoint.Size = new System.Drawing.Size(104, 17);
            this.radSinglePoint.TabIndex = 83;
            this.radSinglePoint.Text = "Plot single points";
            this.radSinglePoint.UseVisualStyleBackColor = true;
            // 
            // radDrawPoints
            // 
            this.radDrawPoints.AutoSize = true;
            this.radDrawPoints.Checked = true;
            this.radDrawPoints.Location = new System.Drawing.Point(376, 733);
            this.radDrawPoints.Name = "radDrawPoints";
            this.radDrawPoints.Size = new System.Drawing.Size(109, 17);
            this.radDrawPoints.TabIndex = 84;
            this.radDrawPoints.TabStop = true;
            this.radDrawPoints.Text = "Draw many points";
            this.radDrawPoints.UseVisualStyleBackColor = true;
            // 
            // frmDataDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 765);
            this.Controls.Add(this.radDrawPoints);
            this.Controls.Add(this.lblCurrValue);
            this.Controls.Add(this.radSinglePoint);
            this.Controls.Add(this.lblDataPoints);
            this.Controls.Add(this.lbln200);
            this.Controls.Add(this.lbln180);
            this.Controls.Add(this.lbln160);
            this.Controls.Add(this.lbln140);
            this.Controls.Add(this.lbln120);
            this.Controls.Add(this.lbln100);
            this.Controls.Add(this.lbln80);
            this.Controls.Add(this.lbln60);
            this.Controls.Add(this.lbln40);
            this.Controls.Add(this.lbln20);
            this.Controls.Add(this.lbl460);
            this.Controls.Add(this.lbl440);
            this.Controls.Add(this.lbl420);
            this.Controls.Add(this.lbl400);
            this.Controls.Add(this.lbl380);
            this.Controls.Add(this.lbl360);
            this.Controls.Add(this.lbl340);
            this.Controls.Add(this.lbl320);
            this.Controls.Add(this.lbl300);
            this.Controls.Add(this.lbl280);
            this.Controls.Add(this.lbl260);
            this.Controls.Add(this.lbl240);
            this.Controls.Add(this.lbl220);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lbl180);
            this.Controls.Add(this.lbl160);
            this.Controls.Add(this.lbl140);
            this.Controls.Add(this.lbl120);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl80);
            this.Controls.Add(this.lbl60);
            this.Controls.Add(this.lbl40);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panDrawData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmDataDrawer";
            this.Text = "CSV Data Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panDrawData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl40;
        private System.Windows.Forms.Label lbl60;
        private System.Windows.Forms.Label lbl80;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl120;
        private System.Windows.Forms.Label lbl140;
        private System.Windows.Forms.Label lbl160;
        private System.Windows.Forms.Label lbl180;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl220;
        private System.Windows.Forms.Label lbl240;
        private System.Windows.Forms.Label lbl260;
        private System.Windows.Forms.Label lbl280;
        private System.Windows.Forms.Label lbl300;
        private System.Windows.Forms.Label lbl320;
        private System.Windows.Forms.Label lbl340;
        private System.Windows.Forms.Label lbl360;
        private System.Windows.Forms.Label lbl380;
        private System.Windows.Forms.Label lbl400;
        private System.Windows.Forms.Label lbl420;
        private System.Windows.Forms.Label lbl440;
        private System.Windows.Forms.Label lbl460;
        private System.Windows.Forms.Label lbln20;
        private System.Windows.Forms.Label lbln40;
        private System.Windows.Forms.Label lbln60;
        private System.Windows.Forms.Label lbln80;
        private System.Windows.Forms.Label lbln100;
        private System.Windows.Forms.Label lbln120;
        private System.Windows.Forms.Label lbln140;
        private System.Windows.Forms.Label lbln160;
        private System.Windows.Forms.Label lbln180;
        private System.Windows.Forms.Label lbln200;
        private System.Windows.Forms.Label lblDataPoints;
        private System.Windows.Forms.Label lblCurrValue;
        private System.Windows.Forms.RadioButton radSinglePoint;
        private System.Windows.Forms.RadioButton radDrawPoints;
    }
}