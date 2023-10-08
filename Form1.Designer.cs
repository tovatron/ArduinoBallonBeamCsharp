namespace ArduinoBallonBeam
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pboxStatus = new System.Windows.Forms.PictureBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxPortname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtboxKdread = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtboxKiread = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtboxKpread = new System.Windows.Forms.TextBox();
            this.pboxSetpoint = new System.Windows.Forms.PictureBox();
            this.txtboxCodesend = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxSP_show = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxCP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxAngle = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxKd = new System.Windows.Forms.TextBox();
            this.txtboxKi = new System.Windows.Forms.TextBox();
            this.txtboxKp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxSP = new System.Windows.Forms.TextBox();
            this.pboxBall = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zgpane01 = new ZedGraph.ZedGraphControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMode1 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStatus)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSetpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pboxStatus);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxPortname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pboxStatus
            // 
            this.pboxStatus.BackColor = System.Drawing.Color.Red;
            this.pboxStatus.Location = new System.Drawing.Point(95, 167);
            this.pboxStatus.Name = "pboxStatus";
            this.pboxStatus.Size = new System.Drawing.Size(10, 10);
            this.pboxStatus.TabIndex = 9;
            this.pboxStatus.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(109, 164);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(73, 13);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.Text = "Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Connect status:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(213, 118);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 25);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(95, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 25);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baud Rate";
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.FormattingEnabled = true;
            this.cboxBaudrate.Location = new System.Drawing.Point(136, 81);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(144, 21);
            this.cboxBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Name";
            // 
            // cboxPortname
            // 
            this.cboxPortname.FormattingEnabled = true;
            this.cboxPortname.Location = new System.Drawing.Point(136, 51);
            this.cboxPortname.Name = "cboxPortname";
            this.cboxPortname.Size = new System.Drawing.Size(144, 21);
            this.cboxPortname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtboxKdread);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtboxKiread);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtboxKpread);
            this.groupBox2.Controls.Add(this.pboxSetpoint);
            this.groupBox2.Controls.Add(this.txtboxCodesend);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtboxSP_show);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtboxCP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtboxAngle);
            this.groupBox2.Controls.Add(this.btnSet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtboxKd);
            this.groupBox2.Controls.Add(this.txtboxKi);
            this.groupBox2.Controls.Add(this.txtboxKp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtboxSP);
            this.groupBox2.Controls.Add(this.pboxBall);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Kd";
            // 
            // txtboxKdread
            // 
            this.txtboxKdread.Location = new System.Drawing.Point(231, 278);
            this.txtboxKdread.Name = "txtboxKdread";
            this.txtboxKdread.ReadOnly = true;
            this.txtboxKdread.Size = new System.Drawing.Size(88, 20);
            this.txtboxKdread.TabIndex = 23;
            this.txtboxKdread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ki";
            // 
            // txtboxKiread
            // 
            this.txtboxKiread.Location = new System.Drawing.Point(231, 229);
            this.txtboxKiread.Name = "txtboxKiread";
            this.txtboxKiread.ReadOnly = true;
            this.txtboxKiread.Size = new System.Drawing.Size(88, 20);
            this.txtboxKiread.TabIndex = 21;
            this.txtboxKiread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Kp";
            // 
            // txtboxKpread
            // 
            this.txtboxKpread.Location = new System.Drawing.Point(231, 183);
            this.txtboxKpread.Name = "txtboxKpread";
            this.txtboxKpread.ReadOnly = true;
            this.txtboxKpread.Size = new System.Drawing.Size(88, 20);
            this.txtboxKpread.TabIndex = 19;
            this.txtboxKpread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pboxSetpoint
            // 
            this.pboxSetpoint.BackColor = System.Drawing.Color.Transparent;
            this.pboxSetpoint.Image = ((System.Drawing.Image)(resources.GetObject("pboxSetpoint.Image")));
            this.pboxSetpoint.Location = new System.Drawing.Point(179, 20);
            this.pboxSetpoint.Name = "pboxSetpoint";
            this.pboxSetpoint.Size = new System.Drawing.Size(31, 31);
            this.pboxSetpoint.TabIndex = 18;
            this.pboxSetpoint.TabStop = false;
            // 
            // txtboxCodesend
            // 
            this.txtboxCodesend.Location = new System.Drawing.Point(22, 278);
            this.txtboxCodesend.Name = "txtboxCodesend";
            this.txtboxCodesend.ReadOnly = true;
            this.txtboxCodesend.Size = new System.Drawing.Size(139, 20);
            this.txtboxCodesend.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Setpoint";
            // 
            // txtboxSP_show
            // 
            this.txtboxSP_show.Location = new System.Drawing.Point(231, 135);
            this.txtboxSP_show.Name = "txtboxSP_show";
            this.txtboxSP_show.ReadOnly = true;
            this.txtboxSP_show.Size = new System.Drawing.Size(88, 20);
            this.txtboxSP_show.TabIndex = 15;
            this.txtboxSP_show.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current point";
            // 
            // txtboxCP
            // 
            this.txtboxCP.Location = new System.Drawing.Point(231, 86);
            this.txtboxCP.Name = "txtboxCP";
            this.txtboxCP.ReadOnly = true;
            this.txtboxCP.Size = new System.Drawing.Size(88, 20);
            this.txtboxCP.TabIndex = 13;
            this.txtboxCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Góc quay";
            // 
            // txtboxAngle
            // 
            this.txtboxAngle.Location = new System.Drawing.Point(231, 35);
            this.txtboxAngle.Name = "txtboxAngle";
            this.txtboxAngle.ReadOnly = true;
            this.txtboxAngle.Size = new System.Drawing.Size(88, 20);
            this.txtboxAngle.TabIndex = 11;
            this.txtboxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(35, 230);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(96, 25);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ki";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kp";
            // 
            // txtboxKd
            // 
            this.txtboxKd.Location = new System.Drawing.Point(58, 190);
            this.txtboxKd.Name = "txtboxKd";
            this.txtboxKd.Size = new System.Drawing.Size(90, 20);
            this.txtboxKd.TabIndex = 6;
            // 
            // txtboxKi
            // 
            this.txtboxKi.Location = new System.Drawing.Point(58, 143);
            this.txtboxKi.Name = "txtboxKi";
            this.txtboxKi.Size = new System.Drawing.Size(90, 20);
            this.txtboxKi.TabIndex = 5;
            // 
            // txtboxKp
            // 
            this.txtboxKp.Location = new System.Drawing.Point(58, 96);
            this.txtboxKp.Name = "txtboxKp";
            this.txtboxKp.Size = new System.Drawing.Size(90, 20);
            this.txtboxKp.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Setpoint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hiệu chỉnh";
            // 
            // txtboxSP
            // 
            this.txtboxSP.Location = new System.Drawing.Point(58, 49);
            this.txtboxSP.Name = "txtboxSP";
            this.txtboxSP.Size = new System.Drawing.Size(90, 20);
            this.txtboxSP.TabIndex = 1;
            // 
            // pboxBall
            // 
            this.pboxBall.BackColor = System.Drawing.Color.Transparent;
            this.pboxBall.Image = ((System.Drawing.Image)(resources.GetObject("pboxBall.Image")));
            this.pboxBall.Location = new System.Drawing.Point(179, 20);
            this.pboxBall.Name = "pboxBall";
            this.pboxBall.Size = new System.Drawing.Size(31, 31);
            this.pboxBall.TabIndex = 0;
            this.pboxBall.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(172, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zgpane01);
            this.groupBox3.Location = new System.Drawing.Point(371, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 452);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // zgpane01
            // 
            this.zgpane01.Enabled = false;
            this.zgpane01.Location = new System.Drawing.Point(6, 10);
            this.zgpane01.Name = "zgpane01";
            this.zgpane01.ScrollGrace = 0D;
            this.zgpane01.ScrollMaxX = 0D;
            this.zgpane01.ScrollMaxY = 0D;
            this.zgpane01.ScrollMaxY2 = 0D;
            this.zgpane01.ScrollMinX = 0D;
            this.zgpane01.ScrollMinY = 0D;
            this.zgpane01.ScrollMinY2 = 0D;
            this.zgpane01.Size = new System.Drawing.Size(742, 436);
            this.zgpane01.TabIndex = 0;
            this.zgpane01.UseExtendedPrintDialog = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMode1
            // 
            this.btnMode1.Location = new System.Drawing.Point(601, 475);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(96, 25);
            this.btnMode1.TabIndex = 15;
            this.btnMode1.Text = "Mode 1";
            this.btnMode1.UseVisualStyleBackColor = true;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Location = new System.Drawing.Point(778, 475);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(96, 25);
            this.btnMode2.TabIndex = 15;
            this.btnMode2.Text = "Mode 2";
            this.btnMode2.UseVisualStyleBackColor = true;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 522);
            this.Controls.Add(this.btnMode2);
            this.Controls.Add(this.btnMode1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BallonBeam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStatus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSetpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxPortname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pboxStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxKd;
        private System.Windows.Forms.TextBox txtboxKi;
        private System.Windows.Forms.TextBox txtboxKp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxSP;
        private ZedGraph.ZedGraphControl zgpane01;
        private System.Windows.Forms.Button btnSet;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxCP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxSP_show;
        private System.Windows.Forms.TextBox txtboxCodesend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtboxKpread;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtboxKdread;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtboxKiread;
        private System.Windows.Forms.PictureBox pboxSetpoint;
        private System.Windows.Forms.PictureBox pboxBall;
    }
}

