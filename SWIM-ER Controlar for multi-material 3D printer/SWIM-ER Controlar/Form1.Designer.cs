namespace SWIM_ER_Controlar
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.cmbBaudRates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.X_Label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgW_SerialDataSend = new System.ComponentModel.BackgroundWorker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb4_gCodeSend = new System.Windows.Forms.GroupBox();
            this.btnForSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNumberOfScan = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbNumberOfLayer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbOverDip = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOverDipWaitTime = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnForSaveAsGCODE = new System.Windows.Forms.Button();
            this.lbl_Stopwatch = new System.Windows.Forms.Label();
            this.txbGCode_cmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGCodeFileOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pB_gCodeSend = new System.Windows.Forms.ProgressBar();
            this.btnForSendRapRapSWIM_ER = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_Control = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmb_ExtSpeed = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_ExtLength = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_eReverse = new System.Windows.Forms.Button();
            this.btn_eExtrude = new System.Windows.Forms.Button();
            this.btnZ_N1 = new System.Windows.Forms.Button();
            this.btnZ_P100 = new System.Windows.Forms.Button();
            this.btnY_P10 = new System.Windows.Forms.Button();
            this.btnHM = new System.Windows.Forms.Button();
            this.btnY_N10 = new System.Windows.Forms.Button();
            this.btnY_P100 = new System.Windows.Forms.Button();
            this.btnY_N100 = new System.Windows.Forms.Button();
            this.btnZ_P1 = new System.Windows.Forms.Button();
            this.btnX_P1 = new System.Windows.Forms.Button();
            this.btnX_P100 = new System.Windows.Forms.Button();
            this.btnZ_N100 = new System.Windows.Forms.Button();
            this.btnY_P1 = new System.Windows.Forms.Button();
            this.btnX_P10 = new System.Windows.Forms.Button();
            this.btnZ_P10 = new System.Windows.Forms.Button();
            this.btnX_N1 = new System.Windows.Forms.Button();
            this.btnX_N100 = new System.Windows.Forms.Button();
            this.btnZ_N10 = new System.Windows.Forms.Button();
            this.btnY_N1 = new System.Windows.Forms.Button();
            this.btnX_N10 = new System.Windows.Forms.Button();
            this.gb_TempControl = new System.Windows.Forms.GroupBox();
            this.btnBedSet = new System.Windows.Forms.Button();
            this.btnHeaterSet = new System.Windows.Forms.Button();
            this.cmbHeaterTemp = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbBedTemp = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gb_Laser = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Laser_on_off = new System.Windows.Forms.Button();
            this.btn_Laser_on_off_dependTime = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLaserOnTime = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Y_Label = new System.Windows.Forms.Label();
            this.Z_Label = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.L_Label = new System.Windows.Forms.Label();
            this.rtxbCmd = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbl_LastBuild = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.timerForTempDebug = new System.Windows.Forms.Timer(this.components);
            this.cbTempDebug = new System.Windows.Forms.CheckBox();
            this.tabPage3.SuspendLayout();
            this.gb4_gCodeSend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Control.SuspendLayout();
            this.gb_TempControl.SuspendLayout();
            this.gb_Laser.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DtrEnable = true;
            this.serialPort.RtsEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // cmbPortList
            // 
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(12, 44);
            this.cmbPortList.Margin = new System.Windows.Forms.Padding(6);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(122, 33);
            this.cmbPortList.TabIndex = 0;
            // 
            // cmbBaudRates
            // 
            this.cmbBaudRates.FormattingEnabled = true;
            this.cmbBaudRates.Items.AddRange(new object[] {
            "4800 ",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "250000"});
            this.cmbBaudRates.Location = new System.Drawing.Point(166, 44);
            this.cmbBaudRates.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBaudRates.Name = "cmbBaudRates";
            this.cmbBaudRates.Size = new System.Drawing.Size(122, 33);
            this.cmbBaudRates.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(326, 52);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(170, 40);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(880, 696);
            this.txbSend.Margin = new System.Windows.Forms.Padding(6);
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(440, 31);
            this.txbSend.TabIndex = 32;
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.X_Label.ForeColor = System.Drawing.Color.Gray;
            this.X_Label.Location = new System.Drawing.Point(874, 12);
            this.X_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(71, 33);
            this.X_Label.TabIndex = 34;
            this.X_Label.Text = "X: 0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // bgW_SerialDataSend
            // 
            this.bgW_SerialDataSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_SerialDataSend_DoWork);
            this.bgW_SerialDataSend.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_SerialDataSend_ProgressChanged);
            this.bgW_SerialDataSend.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgW_SerialDataSend_RunWorkerCompleted);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gb4_gCodeSend);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(830, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "g-Code Translator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gb4_gCodeSend
            // 
            this.gb4_gCodeSend.Controls.Add(this.btnForSend);
            this.gb4_gCodeSend.Controls.Add(this.groupBox1);
            this.gb4_gCodeSend.Controls.Add(this.label15);
            this.gb4_gCodeSend.Controls.Add(this.btnForSaveAsGCODE);
            this.gb4_gCodeSend.Controls.Add(this.lbl_Stopwatch);
            this.gb4_gCodeSend.Controls.Add(this.txbGCode_cmd);
            this.gb4_gCodeSend.Controls.Add(this.label6);
            this.gb4_gCodeSend.Controls.Add(this.label5);
            this.gb4_gCodeSend.Controls.Add(this.btnGCodeFileOpen);
            this.gb4_gCodeSend.Controls.Add(this.label4);
            this.gb4_gCodeSend.Controls.Add(this.pB_gCodeSend);
            this.gb4_gCodeSend.Controls.Add(this.btnForSendRapRapSWIM_ER);
            this.gb4_gCodeSend.Location = new System.Drawing.Point(6, 12);
            this.gb4_gCodeSend.Margin = new System.Windows.Forms.Padding(6);
            this.gb4_gCodeSend.Name = "gb4_gCodeSend";
            this.gb4_gCodeSend.Padding = new System.Windows.Forms.Padding(6);
            this.gb4_gCodeSend.Size = new System.Drawing.Size(798, 564);
            this.gb4_gCodeSend.TabIndex = 5;
            this.gb4_gCodeSend.TabStop = false;
            this.gb4_gCodeSend.Text = "Send or Save g-Code";
            // 
            // btnForSend
            // 
            this.btnForSend.Location = new System.Drawing.Point(170, 38);
            this.btnForSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnForSend.Name = "btnForSend";
            this.btnForSend.Size = new System.Drawing.Size(222, 42);
            this.btnForSend.TabIndex = 23;
            this.btnForSend.Text = "Send to Printer";
            this.btnForSend.UseVisualStyleBackColor = true;
            this.btnForSend.Click += new System.EventHandler(this.btnForSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNumberOfScan);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbNumberOfLayer);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbOverDip);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbOverDipWaitTime);
            this.groupBox1.Location = new System.Drawing.Point(20, 216);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(372, 202);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Num. Of Scan:";
            // 
            // cmbNumberOfScan
            // 
            this.cmbNumberOfScan.FormattingEnabled = true;
            this.cmbNumberOfScan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNumberOfScan.Location = new System.Drawing.Point(14, 58);
            this.cmbNumberOfScan.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNumberOfScan.Name = "cmbNumberOfScan";
            this.cmbNumberOfScan.Size = new System.Drawing.Size(104, 33);
            this.cmbNumberOfScan.TabIndex = 13;
            this.cmbNumberOfScan.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 106);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "Wait Time:";
            // 
            // cmbNumberOfLayer
            // 
            this.cmbNumberOfLayer.FormattingEnabled = true;
            this.cmbNumberOfLayer.Items.AddRange(new object[] {
            "Full Object",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNumberOfLayer.Location = new System.Drawing.Point(14, 136);
            this.cmbNumberOfLayer.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNumberOfLayer.Name = "cmbNumberOfLayer";
            this.cmbNumberOfLayer.Size = new System.Drawing.Size(150, 33);
            this.cmbNumberOfLayer.TabIndex = 15;
            this.cmbNumberOfLayer.Text = "Full Object";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Over Dip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Num. Of Layer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "(mm)";
            // 
            // cmbOverDip
            // 
            this.cmbOverDip.FormattingEnabled = true;
            this.cmbOverDip.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOverDip.Location = new System.Drawing.Point(200, 58);
            this.cmbOverDip.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOverDip.Name = "cmbOverDip";
            this.cmbOverDip.Size = new System.Drawing.Size(96, 33);
            this.cmbOverDip.TabIndex = 20;
            this.cmbOverDip.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "(s)";
            // 
            // cmbOverDipWaitTime
            // 
            this.cmbOverDipWaitTime.FormattingEnabled = true;
            this.cmbOverDipWaitTime.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOverDipWaitTime.Location = new System.Drawing.Point(200, 136);
            this.cmbOverDipWaitTime.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOverDipWaitTime.Name = "cmbOverDipWaitTime";
            this.cmbOverDipWaitTime.Size = new System.Drawing.Size(96, 33);
            this.cmbOverDipWaitTime.TabIndex = 20;
            this.cmbOverDipWaitTime.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(238, 436);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Time:";
            // 
            // btnForSaveAsGCODE
            // 
            this.btnForSaveAsGCODE.Location = new System.Drawing.Point(168, 154);
            this.btnForSaveAsGCODE.Margin = new System.Windows.Forms.Padding(4);
            this.btnForSaveAsGCODE.Name = "btnForSaveAsGCODE";
            this.btnForSaveAsGCODE.Size = new System.Drawing.Size(226, 42);
            this.btnForSaveAsGCODE.TabIndex = 18;
            this.btnForSaveAsGCODE.Text = "Save as gCode";
            this.btnForSaveAsGCODE.UseVisualStyleBackColor = true;
            this.btnForSaveAsGCODE.Click += new System.EventHandler(this.btnForSaveAsGCODE_Click);
            // 
            // lbl_Stopwatch
            // 
            this.lbl_Stopwatch.AutoSize = true;
            this.lbl_Stopwatch.Location = new System.Drawing.Point(300, 436);
            this.lbl_Stopwatch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Stopwatch.Name = "lbl_Stopwatch";
            this.lbl_Stopwatch.Size = new System.Drawing.Size(96, 25);
            this.lbl_Stopwatch.TabIndex = 17;
            this.lbl_Stopwatch.Text = "00:00:00";
            // 
            // txbGCode_cmd
            // 
            this.txbGCode_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGCode_cmd.Location = new System.Drawing.Point(452, 36);
            this.txbGCode_cmd.Margin = new System.Windows.Forms.Padding(6);
            this.txbGCode_cmd.Multiline = true;
            this.txbGCode_cmd.Name = "txbGCode_cmd";
            this.txbGCode_cmd.Size = new System.Drawing.Size(334, 452);
            this.txbGCode_cmd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total g-Code Sent: 0";
            // 
            // btnGCodeFileOpen
            // 
            this.btnGCodeFileOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGCodeFileOpen.Location = new System.Drawing.Point(20, 56);
            this.btnGCodeFileOpen.Margin = new System.Windows.Forms.Padding(6);
            this.btnGCodeFileOpen.Name = "btnGCodeFileOpen";
            this.btnGCodeFileOpen.Size = new System.Drawing.Size(138, 76);
            this.btnGCodeFileOpen.TabIndex = 0;
            this.btnGCodeFileOpen.Text = "Browse...";
            this.btnGCodeFileOpen.UseVisualStyleBackColor = true;
            this.btnGCodeFileOpen.Click += new System.EventHandler(this.btnStlFileOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Object printed: 0%, ";
            // 
            // pB_gCodeSend
            // 
            this.pB_gCodeSend.Location = new System.Drawing.Point(12, 504);
            this.pB_gCodeSend.Margin = new System.Windows.Forms.Padding(6);
            this.pB_gCodeSend.Name = "pB_gCodeSend";
            this.pB_gCodeSend.Size = new System.Drawing.Size(774, 48);
            this.pB_gCodeSend.TabIndex = 5;
            // 
            // btnForSendRapRapSWIM_ER
            // 
            this.btnForSendRapRapSWIM_ER.Location = new System.Drawing.Point(168, 96);
            this.btnForSendRapRapSWIM_ER.Margin = new System.Windows.Forms.Padding(4);
            this.btnForSendRapRapSWIM_ER.Name = "btnForSendRapRapSWIM_ER";
            this.btnForSendRapRapSWIM_ER.Size = new System.Drawing.Size(224, 42);
            this.btnForSendRapRapSWIM_ER.TabIndex = 4;
            this.btnForSendRapRapSWIM_ER.Text = "Send to SWIM-ER";
            this.btnForSendRapRapSWIM_ER.UseVisualStyleBackColor = true;
            this.btnForSendRapRapSWIM_ER.Click += new System.EventHandler(this.btnForSendRapRapSWIM_ER_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_Control);
            this.tabPage1.Controls.Add(this.gb_TempControl);
            this.tabPage1.Controls.Add(this.gb_Laser);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(830, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machine Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_Control
            // 
            this.gb_Control.Controls.Add(this.label20);
            this.gb_Control.Controls.Add(this.label21);
            this.gb_Control.Controls.Add(this.cmb_ExtSpeed);
            this.gb_Control.Controls.Add(this.label19);
            this.gb_Control.Controls.Add(this.cmb_ExtLength);
            this.gb_Control.Controls.Add(this.label17);
            this.gb_Control.Controls.Add(this.btn_eReverse);
            this.gb_Control.Controls.Add(this.btn_eExtrude);
            this.gb_Control.Controls.Add(this.btnZ_N1);
            this.gb_Control.Controls.Add(this.btnZ_P100);
            this.gb_Control.Controls.Add(this.btnY_P10);
            this.gb_Control.Controls.Add(this.btnHM);
            this.gb_Control.Controls.Add(this.btnY_N10);
            this.gb_Control.Controls.Add(this.btnY_P100);
            this.gb_Control.Controls.Add(this.btnY_N100);
            this.gb_Control.Controls.Add(this.btnZ_P1);
            this.gb_Control.Controls.Add(this.btnX_P1);
            this.gb_Control.Controls.Add(this.btnX_P100);
            this.gb_Control.Controls.Add(this.btnZ_N100);
            this.gb_Control.Controls.Add(this.btnY_P1);
            this.gb_Control.Controls.Add(this.btnX_P10);
            this.gb_Control.Controls.Add(this.btnZ_P10);
            this.gb_Control.Controls.Add(this.btnX_N1);
            this.gb_Control.Controls.Add(this.btnX_N100);
            this.gb_Control.Controls.Add(this.btnZ_N10);
            this.gb_Control.Controls.Add(this.btnY_N1);
            this.gb_Control.Controls.Add(this.btnX_N10);
            this.gb_Control.Location = new System.Drawing.Point(4, 142);
            this.gb_Control.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Control.Name = "gb_Control";
            this.gb_Control.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Control.Size = new System.Drawing.Size(816, 450);
            this.gb_Control.TabIndex = 34;
            this.gb_Control.TabStop = false;
            this.gb_Control.Text = "Control Panel";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(748, 191);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 25);
            this.label20.TabIndex = 38;
            this.label20.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(708, 283);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 25);
            this.label21.TabIndex = 39;
            this.label21.Text = "mm/min";
            // 
            // cmb_ExtSpeed
            // 
            this.cmb_ExtSpeed.FormattingEnabled = true;
            this.cmb_ExtSpeed.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "300",
            "400"});
            this.cmb_ExtSpeed.Location = new System.Drawing.Point(684, 251);
            this.cmb_ExtSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ExtSpeed.Name = "cmb_ExtSpeed";
            this.cmb_ExtSpeed.Size = new System.Drawing.Size(102, 33);
            this.cmb_ExtSpeed.TabIndex = 37;
            this.cmb_ExtSpeed.Text = "200";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(678, 225);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "Speed:";
            // 
            // cmb_ExtLength
            // 
            this.cmb_ExtLength.FormattingEnabled = true;
            this.cmb_ExtLength.Items.AddRange(new object[] {
            "1",
            "10",
            "50",
            "100",
            "200"});
            this.cmb_ExtLength.Location = new System.Drawing.Point(684, 159);
            this.cmb_ExtLength.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ExtLength.Name = "cmb_ExtLength";
            this.cmb_ExtLength.Size = new System.Drawing.Size(102, 33);
            this.cmb_ExtLength.TabIndex = 35;
            this.cmb_ExtLength.Text = "100";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(678, 131);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 25);
            this.label17.TabIndex = 34;
            this.label17.Text = "Length:";
            // 
            // btn_eReverse
            // 
            this.btn_eReverse.Location = new System.Drawing.Point(684, 335);
            this.btn_eReverse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eReverse.Name = "btn_eReverse";
            this.btn_eReverse.Size = new System.Drawing.Size(120, 44);
            this.btn_eReverse.TabIndex = 33;
            this.btn_eReverse.Text = "Reverse";
            this.btn_eReverse.UseVisualStyleBackColor = true;
            this.btn_eReverse.Click += new System.EventHandler(this.btn_eReverse_Click);
            // 
            // btn_eExtrude
            // 
            this.btn_eExtrude.Location = new System.Drawing.Point(684, 67);
            this.btn_eExtrude.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eExtrude.Name = "btn_eExtrude";
            this.btn_eExtrude.Size = new System.Drawing.Size(120, 44);
            this.btn_eExtrude.TabIndex = 32;
            this.btn_eExtrude.Text = "Extrude";
            this.btn_eExtrude.UseVisualStyleBackColor = true;
            this.btn_eExtrude.Click += new System.EventHandler(this.btn_eExtrude_Click);
            // 
            // btnZ_N1
            // 
            this.btnZ_N1.Location = new System.Drawing.Point(58, 207);
            this.btnZ_N1.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N1.Name = "btnZ_N1";
            this.btnZ_N1.Size = new System.Drawing.Size(48, 42);
            this.btnZ_N1.TabIndex = 31;
            this.btnZ_N1.Text = "-1";
            this.btnZ_N1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZ_N1.UseVisualStyleBackColor = true;
            this.btnZ_N1.Click += new System.EventHandler(this.btnZ_N1_Click);
            // 
            // btnZ_P100
            // 
            this.btnZ_P100.Location = new System.Drawing.Point(14, 69);
            this.btnZ_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P100.Name = "btnZ_P100";
            this.btnZ_P100.Size = new System.Drawing.Size(196, 44);
            this.btnZ_P100.TabIndex = 23;
            this.btnZ_P100.Text = "Z100";
            this.btnZ_P100.UseVisualStyleBackColor = true;
            this.btnZ_P100.Click += new System.EventHandler(this.btnZ_P100_Click);
            // 
            // btnY_P10
            // 
            this.btnY_P10.Location = new System.Drawing.Point(352, 79);
            this.btnY_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P10.Name = "btnY_P10";
            this.btnY_P10.Size = new System.Drawing.Size(150, 44);
            this.btnY_P10.TabIndex = 9;
            this.btnY_P10.Text = "10";
            this.btnY_P10.UseVisualStyleBackColor = true;
            this.btnY_P10.Click += new System.EventHandler(this.btnY_P10_Click);
            // 
            // btnHM
            // 
            this.btnHM.Location = new System.Drawing.Point(388, 187);
            this.btnHM.Margin = new System.Windows.Forms.Padding(6);
            this.btnHM.Name = "btnHM";
            this.btnHM.Size = new System.Drawing.Size(82, 84);
            this.btnHM.TabIndex = 18;
            this.btnHM.Text = "HM";
            this.btnHM.UseVisualStyleBackColor = true;
            this.btnHM.Click += new System.EventHandler(this.btnHM_Click);
            // 
            // btnY_N10
            // 
            this.btnY_N10.Location = new System.Drawing.Point(352, 335);
            this.btnY_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_N10.Name = "btnY_N10";
            this.btnY_N10.Size = new System.Drawing.Size(150, 44);
            this.btnY_N10.TabIndex = 10;
            this.btnY_N10.Text = "- 10";
            this.btnY_N10.UseVisualStyleBackColor = true;
            this.btnY_N10.Click += new System.EventHandler(this.btnY_N10_Click);
            // 
            // btnY_P100
            // 
            this.btnY_P100.Location = new System.Drawing.Point(328, 27);
            this.btnY_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P100.Name = "btnY_P100";
            this.btnY_P100.Size = new System.Drawing.Size(198, 44);
            this.btnY_P100.TabIndex = 12;
            this.btnY_P100.Text = "Y100";
            this.btnY_P100.UseVisualStyleBackColor = true;
            this.btnY_P100.Click += new System.EventHandler(this.btnY_P100_Click);
            // 
            // btnY_N100
            // 
            this.btnY_N100.Location = new System.Drawing.Point(328, 391);
            this.btnY_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_N100.Name = "btnY_N100";
            this.btnY_N100.Size = new System.Drawing.Size(198, 44);
            this.btnY_N100.TabIndex = 13;
            this.btnY_N100.Text = "Y- 100";
            this.btnY_N100.UseVisualStyleBackColor = true;
            this.btnY_N100.Click += new System.EventHandler(this.btnY_N100_Click);
            // 
            // btnZ_P1
            // 
            this.btnZ_P1.Location = new System.Drawing.Point(118, 207);
            this.btnZ_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P1.Name = "btnZ_P1";
            this.btnZ_P1.Size = new System.Drawing.Size(48, 42);
            this.btnZ_P1.TabIndex = 21;
            this.btnZ_P1.Text = "1";
            this.btnZ_P1.UseVisualStyleBackColor = true;
            this.btnZ_P1.Click += new System.EventHandler(this.btnZ_P1_Click);
            // 
            // btnX_P1
            // 
            this.btnX_P1.Location = new System.Drawing.Point(484, 179);
            this.btnX_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P1.Name = "btnX_P1";
            this.btnX_P1.Size = new System.Drawing.Size(52, 100);
            this.btnX_P1.TabIndex = 8;
            this.btnX_P1.Text = "1";
            this.btnX_P1.UseVisualStyleBackColor = true;
            this.btnX_P1.Click += new System.EventHandler(this.btnX_P1_Click);
            // 
            // btnX_P100
            // 
            this.btnX_P100.Location = new System.Drawing.Point(604, 135);
            this.btnX_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P100.Name = "btnX_P100";
            this.btnX_P100.Size = new System.Drawing.Size(48, 188);
            this.btnX_P100.TabIndex = 17;
            this.btnX_P100.Text = "100";
            this.btnX_P100.UseVisualStyleBackColor = true;
            this.btnX_P100.Click += new System.EventHandler(this.btnX_P100_Click);
            // 
            // btnZ_N100
            // 
            this.btnZ_N100.Location = new System.Drawing.Point(14, 343);
            this.btnZ_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N100.Name = "btnZ_N100";
            this.btnZ_N100.Size = new System.Drawing.Size(196, 44);
            this.btnZ_N100.TabIndex = 25;
            this.btnZ_N100.Text = "Z-100";
            this.btnZ_N100.UseVisualStyleBackColor = true;
            this.btnZ_N100.Click += new System.EventHandler(this.btnZ_N100_Click);
            // 
            // btnY_P1
            // 
            this.btnY_P1.Location = new System.Drawing.Point(368, 135);
            this.btnY_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P1.Name = "btnY_P1";
            this.btnY_P1.Size = new System.Drawing.Size(118, 44);
            this.btnY_P1.TabIndex = 5;
            this.btnY_P1.Text = "1";
            this.btnY_P1.UseVisualStyleBackColor = true;
            this.btnY_P1.Click += new System.EventHandler(this.btnY_P1_Click);
            // 
            // btnX_P10
            // 
            this.btnX_P10.Location = new System.Drawing.Point(552, 159);
            this.btnX_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P10.Name = "btnX_P10";
            this.btnX_P10.Size = new System.Drawing.Size(38, 144);
            this.btnX_P10.TabIndex = 14;
            this.btnX_P10.Text = "10";
            this.btnX_P10.UseVisualStyleBackColor = true;
            this.btnX_P10.Click += new System.EventHandler(this.btnX_P10_Click);
            // 
            // btnZ_P10
            // 
            this.btnZ_P10.Location = new System.Drawing.Point(40, 143);
            this.btnZ_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P10.Name = "btnZ_P10";
            this.btnZ_P10.Size = new System.Drawing.Size(144, 44);
            this.btnZ_P10.TabIndex = 22;
            this.btnZ_P10.Text = "10";
            this.btnZ_P10.UseVisualStyleBackColor = true;
            this.btnZ_P10.Click += new System.EventHandler(this.btnZ_P10_Click);
            // 
            // btnX_N1
            // 
            this.btnX_N1.Location = new System.Drawing.Point(320, 179);
            this.btnX_N1.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N1.Name = "btnX_N1";
            this.btnX_N1.Size = new System.Drawing.Size(52, 100);
            this.btnX_N1.TabIndex = 7;
            this.btnX_N1.Text = "- 1";
            this.btnX_N1.UseVisualStyleBackColor = true;
            this.btnX_N1.Click += new System.EventHandler(this.btnX_N1_Click);
            // 
            // btnX_N100
            // 
            this.btnX_N100.Location = new System.Drawing.Point(208, 135);
            this.btnX_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N100.Name = "btnX_N100";
            this.btnX_N100.Size = new System.Drawing.Size(48, 188);
            this.btnX_N100.TabIndex = 16;
            this.btnX_N100.Text = "- 100";
            this.btnX_N100.UseVisualStyleBackColor = true;
            this.btnX_N100.Click += new System.EventHandler(this.btnX_N100_Click);
            // 
            // btnZ_N10
            // 
            this.btnZ_N10.Location = new System.Drawing.Point(40, 267);
            this.btnZ_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N10.Name = "btnZ_N10";
            this.btnZ_N10.Size = new System.Drawing.Size(144, 44);
            this.btnZ_N10.TabIndex = 24;
            this.btnZ_N10.Text = "-10";
            this.btnZ_N10.UseVisualStyleBackColor = true;
            this.btnZ_N10.Click += new System.EventHandler(this.btnZ_N10_Click);
            // 
            // btnY_N1
            // 
            this.btnY_N1.Location = new System.Drawing.Point(368, 283);
            this.btnY_N1.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_N1.Name = "btnY_N1";
            this.btnY_N1.Size = new System.Drawing.Size(118, 44);
            this.btnY_N1.TabIndex = 6;
            this.btnY_N1.Text = "- 1";
            this.btnY_N1.UseVisualStyleBackColor = true;
            this.btnY_N1.Click += new System.EventHandler(this.btnY_N1_Click);
            // 
            // btnX_N10
            // 
            this.btnX_N10.Location = new System.Drawing.Point(272, 159);
            this.btnX_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N10.Name = "btnX_N10";
            this.btnX_N10.Size = new System.Drawing.Size(34, 144);
            this.btnX_N10.TabIndex = 15;
            this.btnX_N10.Text = "- 10";
            this.btnX_N10.UseVisualStyleBackColor = true;
            this.btnX_N10.Click += new System.EventHandler(this.btnX_N10_Click);
            // 
            // gb_TempControl
            // 
            this.gb_TempControl.Controls.Add(this.cbTempDebug);
            this.gb_TempControl.Controls.Add(this.btnBedSet);
            this.gb_TempControl.Controls.Add(this.btnHeaterSet);
            this.gb_TempControl.Controls.Add(this.cmbHeaterTemp);
            this.gb_TempControl.Controls.Add(this.label18);
            this.gb_TempControl.Controls.Add(this.cmbBedTemp);
            this.gb_TempControl.Controls.Add(this.label16);
            this.gb_TempControl.Location = new System.Drawing.Point(424, 12);
            this.gb_TempControl.Margin = new System.Windows.Forms.Padding(6);
            this.gb_TempControl.Name = "gb_TempControl";
            this.gb_TempControl.Padding = new System.Windows.Forms.Padding(6);
            this.gb_TempControl.Size = new System.Drawing.Size(394, 145);
            this.gb_TempControl.TabIndex = 33;
            this.gb_TempControl.TabStop = false;
            this.gb_TempControl.Text = "Temprature Control";
            // 
            // btnBedSet
            // 
            this.btnBedSet.Location = new System.Drawing.Point(313, 45);
            this.btnBedSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnBedSet.Name = "btnBedSet";
            this.btnBedSet.Size = new System.Drawing.Size(72, 44);
            this.btnBedSet.TabIndex = 6;
            this.btnBedSet.Text = "Set";
            this.btnBedSet.UseVisualStyleBackColor = true;
            this.btnBedSet.Click += new System.EventHandler(this.btnBedSet_Click);
            // 
            // btnHeaterSet
            // 
            this.btnHeaterSet.Location = new System.Drawing.Point(118, 45);
            this.btnHeaterSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeaterSet.Name = "btnHeaterSet";
            this.btnHeaterSet.Size = new System.Drawing.Size(72, 44);
            this.btnHeaterSet.TabIndex = 5;
            this.btnHeaterSet.Text = "Set";
            this.btnHeaterSet.UseVisualStyleBackColor = true;
            this.btnHeaterSet.Click += new System.EventHandler(this.btnHeaterSet_Click);
            // 
            // cmbHeaterTemp
            // 
            this.cmbHeaterTemp.FormattingEnabled = true;
            this.cmbHeaterTemp.Items.AddRange(new object[] {
            "150",
            "180",
            "200",
            "220",
            "240",
            "250",
            "260"});
            this.cmbHeaterTemp.Location = new System.Drawing.Point(21, 56);
            this.cmbHeaterTemp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHeaterTemp.Name = "cmbHeaterTemp";
            this.cmbHeaterTemp.Size = new System.Drawing.Size(92, 33);
            this.cmbHeaterTemp.TabIndex = 3;
            this.cmbHeaterTemp.Text = "220";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 26);
            this.label18.TabIndex = 1;
            this.label18.Text = "Heater:";
            // 
            // cmbBedTemp
            // 
            this.cmbBedTemp.FormattingEnabled = true;
            this.cmbBedTemp.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbBedTemp.Location = new System.Drawing.Point(216, 56);
            this.cmbBedTemp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBedTemp.Name = "cmbBedTemp";
            this.cmbBedTemp.Size = new System.Drawing.Size(92, 33);
            this.cmbBedTemp.TabIndex = 4;
            this.cmbBedTemp.Text = "60";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(211, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "Bed:";
            // 
            // gb_Laser
            // 
            this.gb_Laser.Controls.Add(this.label10);
            this.gb_Laser.Controls.Add(this.btn_Laser_on_off);
            this.gb_Laser.Controls.Add(this.btn_Laser_on_off_dependTime);
            this.gb_Laser.Controls.Add(this.label8);
            this.gb_Laser.Controls.Add(this.label7);
            this.gb_Laser.Controls.Add(this.tbxLaserOnTime);
            this.gb_Laser.Location = new System.Drawing.Point(17, 12);
            this.gb_Laser.Margin = new System.Windows.Forms.Padding(6);
            this.gb_Laser.Name = "gb_Laser";
            this.gb_Laser.Padding = new System.Windows.Forms.Padding(6);
            this.gb_Laser.Size = new System.Drawing.Size(391, 145);
            this.gb_Laser.TabIndex = 32;
            this.gb_Laser.TabStop = false;
            this.gb_Laser.Text = "Laser Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(245, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Laser On Off:";
            // 
            // btn_Laser_on_off
            // 
            this.btn_Laser_on_off.Location = new System.Drawing.Point(251, 59);
            this.btn_Laser_on_off.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Laser_on_off.Name = "btn_Laser_on_off";
            this.btn_Laser_on_off.Size = new System.Drawing.Size(72, 44);
            this.btn_Laser_on_off.TabIndex = 4;
            this.btn_Laser_on_off.Text = "On";
            this.btn_Laser_on_off.UseVisualStyleBackColor = true;
            this.btn_Laser_on_off.Click += new System.EventHandler(this.btn_Laser_on_off_Click);
            // 
            // btn_Laser_on_off_dependTime
            // 
            this.btn_Laser_on_off_dependTime.Location = new System.Drawing.Point(164, 58);
            this.btn_Laser_on_off_dependTime.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Laser_on_off_dependTime.Name = "btn_Laser_on_off_dependTime";
            this.btn_Laser_on_off_dependTime.Size = new System.Drawing.Size(72, 44);
            this.btn_Laser_on_off_dependTime.TabIndex = 3;
            this.btn_Laser_on_off_dependTime.Text = "On";
            this.btn_Laser_on_off_dependTime.UseVisualStyleBackColor = true;
            this.btn_Laser_on_off_dependTime.Click += new System.EventHandler(this.btn_Laser_on_off_dependTime_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Laser On Time:";
            // 
            // tbxLaserOnTime
            // 
            this.tbxLaserOnTime.Location = new System.Drawing.Point(20, 62);
            this.tbxLaserOnTime.Margin = new System.Windows.Forms.Padding(6);
            this.tbxLaserOnTime.Name = "tbxLaserOnTime";
            this.tbxLaserOnTime.Size = new System.Drawing.Size(104, 31);
            this.tbxLaserOnTime.TabIndex = 0;
            this.tbxLaserOnTime.Text = "1";
            this.tbxLaserOnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 648);
            this.tabControl1.TabIndex = 33;
            // 
            // Y_Label
            // 
            this.Y_Label.AutoSize = true;
            this.Y_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Y_Label.ForeColor = System.Drawing.Color.Gray;
            this.Y_Label.Location = new System.Drawing.Point(1032, 12);
            this.Y_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Y_Label.Name = "Y_Label";
            this.Y_Label.Size = new System.Drawing.Size(71, 33);
            this.Y_Label.TabIndex = 36;
            this.Y_Label.Text = "Y: 0";
            // 
            // Z_Label
            // 
            this.Z_Label.AutoSize = true;
            this.Z_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Z_Label.ForeColor = System.Drawing.Color.Gray;
            this.Z_Label.Location = new System.Drawing.Point(1192, 12);
            this.Z_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Z_Label.Name = "Z_Label";
            this.Z_Label.Size = new System.Drawing.Size(70, 33);
            this.Z_Label.TabIndex = 37;
            this.Z_Label.Text = "Z: 0";
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.ForeColor = System.Drawing.Color.Green;
            this.btn_Pause.Location = new System.Drawing.Point(518, 8);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(146, 102);
            this.btn_Pause.TabIndex = 38;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(706, 8);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(146, 102);
            this.btn_Stop.TabIndex = 39;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(14, 747);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(156, 37);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(124, 32);
            this.toolStripStatusLabel.Text = "Directory: ";
            // 
            // L_Label
            // 
            this.L_Label.AutoSize = true;
            this.L_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Label.ForeColor = System.Drawing.Color.Gray;
            this.L_Label.Location = new System.Drawing.Point(1332, 12);
            this.L_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.L_Label.Name = "L_Label";
            this.L_Label.Size = new System.Drawing.Size(114, 33);
            this.L_Label.TabIndex = 41;
            this.L_Label.Text = "L: OFF";
            // 
            // rtxbCmd
            // 
            this.rtxbCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbCmd.ForeColor = System.Drawing.Color.Green;
            this.rtxbCmd.HideSelection = false;
            this.rtxbCmd.Location = new System.Drawing.Point(880, 56);
            this.rtxbCmd.Margin = new System.Windows.Forms.Padding(6);
            this.rtxbCmd.Name = "rtxbCmd";
            this.rtxbCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxbCmd.Size = new System.Drawing.Size(566, 616);
            this.rtxbCmd.TabIndex = 42;
            this.rtxbCmd.Text = "";
            this.rtxbCmd.TextChanged += new System.EventHandler(this.rtxbCmd_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Location = new System.Drawing.Point(326, 8);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 40);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "Refresh Ports";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbl_LastBuild
            // 
            this.lbl_LastBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LastBuild.AutoSize = true;
            this.lbl_LastBuild.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_LastBuild.Location = new System.Drawing.Point(1224, 750);
            this.lbl_LastBuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastBuild.Name = "lbl_LastBuild";
            this.lbl_LastBuild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LastBuild.Size = new System.Drawing.Size(113, 25);
            this.lbl_LastBuild.TabIndex = 44;
            this.lbl_LastBuild.Text = "Last Build:";
            this.lbl_LastBuild.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendCmd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.L_Label);
            this.panel1.Controls.Add(this.btn_Pause);
            this.panel1.Controls.Add(this.lbl_LastBuild);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.cmbPortList);
            this.panel1.Controls.Add(this.Z_Label);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.Y_Label);
            this.panel1.Controls.Add(this.cmbBaudRates);
            this.panel1.Controls.Add(this.rtxbCmd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txbSend);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.X_Label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 780);
            this.panel1.TabIndex = 45;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(1340, 688);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(104, 40);
            this.btnSendCmd.TabIndex = 45;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // timerForTempDebug
            // 
            this.timerForTempDebug.Interval = 3000;
            this.timerForTempDebug.Tick += new System.EventHandler(this.timerForTempDebug_Tick);
            // 
            // cbTempDebug
            // 
            this.cbTempDebug.AutoSize = true;
            this.cbTempDebug.Location = new System.Drawing.Point(21, 96);
            this.cbTempDebug.Name = "cbTempDebug";
            this.cbTempDebug.Size = new System.Drawing.Size(232, 29);
            this.cbTempDebug.TabIndex = 7;
            this.cbTempDebug.Text = "Temperature debug";
            this.cbTempDebug.UseVisualStyleBackColor = true;
            this.cbTempDebug.CheckedChanged += new System.EventHandler(this.cbTempDebug_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1476, 802);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "RepRap SWIM-ER Controlar [Developed by Furukawa Lab] V: 1.7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.gb4_gCodeSend.ResumeLayout(false);
            this.gb4_gCodeSend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gb_Control.ResumeLayout(false);
            this.gb_Control.PerformLayout();
            this.gb_TempControl.ResumeLayout(false);
            this.gb_TempControl.PerformLayout();
            this.gb_Laser.ResumeLayout(false);
            this.gb_Laser.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.ComboBox cmbBaudRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker bgW_SerialDataSend;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gb4_gCodeSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGCodeFileOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pB_gCodeSend;
        private System.Windows.Forms.Button btnForSendRapRapSWIM_ER;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnZ_N1;
        private System.Windows.Forms.Button btnY_P100;
        private System.Windows.Forms.Button btnY_P1;
        private System.Windows.Forms.Button btnY_N1;
        private System.Windows.Forms.Button btnX_N1;
        private System.Windows.Forms.Button btnX_P1;
        private System.Windows.Forms.Button btnY_P10;
        private System.Windows.Forms.Button btnY_N10;
        private System.Windows.Forms.Button btnY_N100;
        private System.Windows.Forms.Button btnZ_N100;
        private System.Windows.Forms.Button btnX_P10;
        private System.Windows.Forms.Button btnZ_N10;
        private System.Windows.Forms.Button btnX_N10;
        private System.Windows.Forms.Button btnZ_P100;
        private System.Windows.Forms.Button btnX_N100;
        private System.Windows.Forms.Button btnZ_P10;
        private System.Windows.Forms.Button btnX_P100;
        private System.Windows.Forms.Button btnZ_P1;
        private System.Windows.Forms.Button btnHM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txbGCode_cmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Y_Label;
        private System.Windows.Forms.Label Z_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNumberOfScan;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label L_Label;
        private System.Windows.Forms.GroupBox gb_Laser;
        private System.Windows.Forms.Button btn_Laser_on_off;
        private System.Windows.Forms.Button btn_Laser_on_off_dependTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLaserOnTime;
        private System.Windows.Forms.RichTextBox rtxbCmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNumberOfLayer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Stopwatch;
        private System.Windows.Forms.Button btnForSaveAsGCODE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbl_LastBuild;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOverDip;
        private System.Windows.Forms.ComboBox cmbOverDipWaitTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnForSend;
        private System.Windows.Forms.GroupBox gb_Control;
        private System.Windows.Forms.GroupBox gb_TempControl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBedSet;
        private System.Windows.Forms.Button btnHeaterSet;
        private System.Windows.Forms.ComboBox cmbBedTemp;
        private System.Windows.Forms.ComboBox cmbHeaterTemp;
        private System.Windows.Forms.Button btn_eReverse;
        private System.Windows.Forms.Button btn_eExtrude;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmb_ExtSpeed;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_ExtLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Timer timerForTempDebug;
        private System.Windows.Forms.CheckBox cbTempDebug;
    }
}

