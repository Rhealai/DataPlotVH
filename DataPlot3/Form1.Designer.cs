namespace DataPlot3
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
            this.ComPortGroupBox = new System.Windows.Forms.GroupBox();
            this.COMPortStatusLight = new PolyMonControls.StatusLight();
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.COMBaudComboBox = new System.Windows.Forms.ComboBox();
            this.COMConnectButton = new System.Windows.Forms.Button();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.RawTextBox = new System.Windows.Forms.TextBox();
            this.ZedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOfDataNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SampleTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ZedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComPortGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ComPortGroupBox
            // 
            this.ComPortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortGroupBox.Controls.Add(this.COMPortStatusLight);
            this.ComPortGroupBox.Controls.Add(this.COMPortComboBox);
            this.ComPortGroupBox.Controls.Add(this.COMBaudComboBox);
            this.ComPortGroupBox.Controls.Add(this.COMConnectButton);
            this.ComPortGroupBox.Location = new System.Drawing.Point(1022, 452);
            this.ComPortGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Name = "ComPortGroupBox";
            this.ComPortGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Size = new System.Drawing.Size(105, 86);
            this.ComPortGroupBox.TabIndex = 0;
            this.ComPortGroupBox.TabStop = false;
            this.ComPortGroupBox.Text = "COM Port";
            // 
            // COMPortStatusLight
            // 
            this.COMPortStatusLight.BackgroundImage = System.Drawing.Color.Empty;
            this.COMPortStatusLight.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.COMPortStatusLight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMPortStatusLight.Location = new System.Drawing.Point(10, 62);
            this.COMPortStatusLight.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortStatusLight.Name = "COMPortStatusLight";
            this.COMPortStatusLight.OffColor = System.Drawing.Color.Black;
            this.COMPortStatusLight.Size = new System.Drawing.Size(18, 20);
            this.COMPortStatusLight.TabIndex = 3;
            this.COMPortStatusLight.Text = "COMPortStatusLight";
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM12",
            "COM13",
            "COM14"});
            this.COMPortComboBox.Location = new System.Drawing.Point(4, 38);
            this.COMPortComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(97, 20);
            this.COMPortComboBox.TabIndex = 2;
            this.COMPortComboBox.Text = "COM3";
            // 
            // COMBaudComboBox
            // 
            this.COMBaudComboBox.FormattingEnabled = true;
            this.COMBaudComboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "14400",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.COMBaudComboBox.Location = new System.Drawing.Point(4, 16);
            this.COMBaudComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMBaudComboBox.Name = "COMBaudComboBox";
            this.COMBaudComboBox.Size = new System.Drawing.Size(97, 20);
            this.COMBaudComboBox.TabIndex = 1;
            this.COMBaudComboBox.Text = "9600";
            // 
            // COMConnectButton
            // 
            this.COMConnectButton.Location = new System.Drawing.Point(32, 62);
            this.COMConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.COMConnectButton.Name = "COMConnectButton";
            this.COMConnectButton.Size = new System.Drawing.Size(68, 20);
            this.COMConnectButton.TabIndex = 0;
            this.COMConnectButton.Text = "Connect";
            this.COMConnectButton.UseVisualStyleBackColor = true;
            this.COMConnectButton.Click += new System.EventHandler(this.COMConnectBtn_Click);
            // 
            // SerialPort
            // 
            this.SerialPort.ReadBufferSize = 1024;
            this.SerialPort.ReadTimeout = 2000;
            this.SerialPort.ReceivedBytesThreshold = 2;
            this.SerialPort.WriteBufferSize = 1024;
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // RawTextBox
            // 
            this.RawTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RawTextBox.Location = new System.Drawing.Point(9, 452);
            this.RawTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RawTextBox.MaxLength = 1000;
            this.RawTextBox.Multiline = true;
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RawTextBox.Size = new System.Drawing.Size(1009, 87);
            this.RawTextBox.TabIndex = 1;
            // 
            // ZedGraphControl1
            // 
            this.ZedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZedGraphControl1.AutoSize = true;
            this.ZedGraphControl1.BackColor = System.Drawing.SystemColors.InfoText;
            this.ZedGraphControl1.IsAutoScrollRange = true;
            this.ZedGraphControl1.Location = new System.Drawing.Point(9, 10);
            this.ZedGraphControl1.Name = "ZedGraphControl1";
            this.ZedGraphControl1.ScrollGrace = 0D;
            this.ZedGraphControl1.ScrollMaxX = 0D;
            this.ZedGraphControl1.ScrollMaxY = 0D;
            this.ZedGraphControl1.ScrollMaxY2 = 0D;
            this.ZedGraphControl1.ScrollMinX = 0D;
            this.ZedGraphControl1.ScrollMinY = 0D;
            this.ZedGraphControl1.ScrollMinY2 = 0D;
            this.ZedGraphControl1.Size = new System.Drawing.Size(480, 437);
            this.ZedGraphControl1.TabIndex = 2;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.OptionsGroupBox.Controls.Add(this.MinTextBox);
            this.OptionsGroupBox.Controls.Add(this.label4);
            this.OptionsGroupBox.Controls.Add(this.MaxTextBox);
            this.OptionsGroupBox.Controls.Add(this.label3);
            this.OptionsGroupBox.Controls.Add(this.button1);
            this.OptionsGroupBox.Controls.Add(this.NoOfDataNumericUpDown);
            this.OptionsGroupBox.Controls.Add(this.label2);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.SampleTextBox);
            this.OptionsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionsGroupBox.Location = new System.Drawing.Point(1022, 10);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.OptionsGroupBox.Size = new System.Drawing.Size(105, 392);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // NoOfDataNumericUpDown
            // 
            this.NoOfDataNumericUpDown.Location = new System.Drawing.Point(4, 40);
            this.NoOfDataNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.NoOfDataNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NoOfDataNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoOfDataNumericUpDown.Name = "NoOfDataNumericUpDown";
            this.NoOfDataNumericUpDown.Size = new System.Drawing.Size(96, 22);
            this.NoOfDataNumericUpDown.TabIndex = 5;
            this.NoOfDataNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samples";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of data sets";
            // 
            // SampleTextBox
            // 
            this.SampleTextBox.Location = new System.Drawing.Point(4, 87);
            this.SampleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SampleTextBox.Name = "SampleTextBox";
            this.SampleTextBox.Size = new System.Drawing.Size(97, 22);
            this.SampleTextBox.TabIndex = 1;
            this.SampleTextBox.Text = "1000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ZedGraphControl2
            // 
            this.ZedGraphControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZedGraphControl2.AutoSize = true;
            this.ZedGraphControl2.Location = new System.Drawing.Point(494, 10);
            this.ZedGraphControl2.Name = "ZedGraphControl2";
            this.ZedGraphControl2.ScrollGrace = 0D;
            this.ZedGraphControl2.ScrollMaxX = 0D;
            this.ZedGraphControl2.ScrollMaxY = 0D;
            this.ZedGraphControl2.ScrollMaxY2 = 0D;
            this.ZedGraphControl2.ScrollMinX = 0D;
            this.ZedGraphControl2.ScrollMinY = 0D;
            this.ZedGraphControl2.ScrollMinY2 = 0D;
            this.ZedGraphControl2.Size = new System.Drawing.Size(480, 437);
            this.ZedGraphControl2.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "DEMO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max.(Outer Circle)";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(3, 148);
            this.MaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(97, 22);
            this.MaxTextBox.TabIndex = 7;
            this.MaxTextBox.Text = "3350";
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(4, 192);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(97, 22);
            this.MinTextBox.TabIndex = 9;
            this.MinTextBox.Text = "3250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min.(Inner Circle)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 548);
            this.Controls.Add(this.ZedGraphControl2);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ZedGraphControl1);
            this.Controls.Add(this.RawTextBox);
            this.Controls.Add(this.ComPortGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DataPlot V1.0 (U1-1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ComPortGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ComPortGroupBox;
        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.ComboBox COMBaudComboBox;
        private System.Windows.Forms.Button COMConnectButton;
        private PolyMonControls.StatusLight COMPortStatusLight;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.TextBox RawTextBox;
        private ZedGraph.ZedGraphControl ZedGraphControl1;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SampleTextBox;
        private System.Windows.Forms.NumericUpDown NoOfDataNumericUpDown;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl ZedGraphControl2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label label3;
    }
}

