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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.cmbBaudRates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.X_Label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgW_SerialDataSend = new System.ComponentModel.BackgroundWorker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb4_gCodeSend = new System.Windows.Forms.GroupBox();
            this.btnSendSWIMER = new System.Windows.Forms.Button();
            this.btnSaveSD = new System.Windows.Forms.Button();
            this.lbl_Stopwatch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNumberOfLayer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNumberOfScan = new System.Windows.Forms.ComboBox();
            this.txbGCode_cmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGCodeFileOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pB_gCodeSend = new System.Windows.Forms.ProgressBar();
            this.readgCode = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb4_Control = new System.Windows.Forms.GroupBox();
            this.btnZ_N1 = new System.Windows.Forms.Button();
            this.btnZ_P100 = new System.Windows.Forms.Button();
            this.btnHM = new System.Windows.Forms.Button();
            this.btnY_P100 = new System.Windows.Forms.Button();
            this.btnZ_P1 = new System.Windows.Forms.Button();
            this.btnX_P100 = new System.Windows.Forms.Button();
            this.btnY_P1 = new System.Windows.Forms.Button();
            this.btnZ_P10 = new System.Windows.Forms.Button();
            this.btnX_N100 = new System.Windows.Forms.Button();
            this.btnY_N1 = new System.Windows.Forms.Button();
            this.btnX_N10 = new System.Windows.Forms.Button();
            this.btnZ_N10 = new System.Windows.Forms.Button();
            this.btnX_N1 = new System.Windows.Forms.Button();
            this.btnX_P10 = new System.Windows.Forms.Button();
            this.btnZ_N100 = new System.Windows.Forms.Button();
            this.btnX_P1 = new System.Windows.Forms.Button();
            this.btnY_N100 = new System.Windows.Forms.Button();
            this.btnY_N10 = new System.Windows.Forms.Button();
            this.btnY_P10 = new System.Windows.Forms.Button();
            this.gb4_Laser = new System.Windows.Forms.GroupBox();
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
            this.tabPage3.SuspendLayout();
            this.gb4_gCodeSend.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb4_Control.SuspendLayout();
            this.gb4_Laser.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // cmbPortList
            // 
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(16, 52);
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
            "230400"});
            this.cmbBaudRates.Location = new System.Drawing.Point(170, 52);
            this.cmbBaudRates.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBaudRates.Name = "cmbBaudRates";
            this.cmbBaudRates.Size = new System.Drawing.Size(122, 33);
            this.cmbBaudRates.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(330, 58);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(170, 40);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1316, 704);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 44);
            this.btnSend.TabIndex = 31;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(884, 706);
            this.txbSend.Margin = new System.Windows.Forms.Padding(6);
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(402, 31);
            this.txbSend.TabIndex = 32;
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.X_Label.ForeColor = System.Drawing.Color.Gray;
            this.X_Label.Location = new System.Drawing.Point(876, 18);
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
            this.gb4_gCodeSend.Controls.Add(this.btnSendSWIMER);
            this.gb4_gCodeSend.Controls.Add(this.btnSaveSD);
            this.gb4_gCodeSend.Controls.Add(this.lbl_Stopwatch);
            this.gb4_gCodeSend.Controls.Add(this.label9);
            this.gb4_gCodeSend.Controls.Add(this.cmbNumberOfLayer);
            this.gb4_gCodeSend.Controls.Add(this.label3);
            this.gb4_gCodeSend.Controls.Add(this.cmbNumberOfScan);
            this.gb4_gCodeSend.Controls.Add(this.txbGCode_cmd);
            this.gb4_gCodeSend.Controls.Add(this.label6);
            this.gb4_gCodeSend.Controls.Add(this.label5);
            this.gb4_gCodeSend.Controls.Add(this.btnGCodeFileOpen);
            this.gb4_gCodeSend.Controls.Add(this.label4);
            this.gb4_gCodeSend.Controls.Add(this.pB_gCodeSend);
            this.gb4_gCodeSend.Controls.Add(this.readgCode);
            this.gb4_gCodeSend.Location = new System.Drawing.Point(6, 14);
            this.gb4_gCodeSend.Margin = new System.Windows.Forms.Padding(6);
            this.gb4_gCodeSend.Name = "gb4_gCodeSend";
            this.gb4_gCodeSend.Padding = new System.Windows.Forms.Padding(6);
            this.gb4_gCodeSend.Size = new System.Drawing.Size(798, 564);
            this.gb4_gCodeSend.TabIndex = 5;
            this.gb4_gCodeSend.TabStop = false;
            this.gb4_gCodeSend.Text = "Send g-Code to SWEM-ER";
            // 
            // btnSendSWIMER
            // 
            this.btnSendSWIMER.Location = new System.Drawing.Point(151, 158);
            this.btnSendSWIMER.Name = "btnSendSWIMER";
            this.btnSendSWIMER.Size = new System.Drawing.Size(211, 46);
            this.btnSendSWIMER.TabIndex = 19;
            this.btnSendSWIMER.Text = "Save for SWIM-ER";
            this.btnSendSWIMER.UseVisualStyleBackColor = true;
            this.btnSendSWIMER.Click += new System.EventHandler(this.btnSendSWIMER_Click);
            // 
            // btnSaveSD
            // 
            this.btnSaveSD.Location = new System.Drawing.Point(151, 96);
            this.btnSaveSD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSD.Name = "btnSaveSD";
            this.btnSaveSD.Size = new System.Drawing.Size(211, 46);
            this.btnSaveSD.TabIndex = 18;
            this.btnSaveSD.Text = "Save as gCode";
            this.btnSaveSD.UseVisualStyleBackColor = true;
            this.btnSaveSD.Click += new System.EventHandler(this.btnSaveSD_Click);
            // 
            // lbl_Stopwatch
            // 
            this.lbl_Stopwatch.AutoSize = true;
            this.lbl_Stopwatch.Location = new System.Drawing.Point(246, 434);
            this.lbl_Stopwatch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Stopwatch.Name = "lbl_Stopwatch";
            this.lbl_Stopwatch.Size = new System.Drawing.Size(96, 25);
            this.lbl_Stopwatch.TabIndex = 17;
            this.lbl_Stopwatch.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number Of Layer:";
            // 
            // cmbNumberOfLayer
            // 
            this.cmbNumberOfLayer.FormattingEnabled = true;
            this.cmbNumberOfLayer.Items.AddRange(new object[] {
            "Full Object Printing",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNumberOfLayer.Location = new System.Drawing.Point(18, 344);
            this.cmbNumberOfLayer.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNumberOfLayer.Name = "cmbNumberOfLayer";
            this.cmbNumberOfLayer.Size = new System.Drawing.Size(344, 33);
            this.cmbNumberOfLayer.TabIndex = 15;
            this.cmbNumberOfLayer.Text = "Full Object Printing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number Of Scan:";
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
            this.cmbNumberOfScan.Location = new System.Drawing.Point(18, 252);
            this.cmbNumberOfScan.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNumberOfScan.Name = "cmbNumberOfScan";
            this.cmbNumberOfScan.Size = new System.Drawing.Size(344, 33);
            this.cmbNumberOfScan.TabIndex = 13;
            this.cmbNumberOfScan.Text = "1";
            // 
            // txbGCode_cmd
            // 
            this.txbGCode_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGCode_cmd.Location = new System.Drawing.Point(486, 34);
            this.txbGCode_cmd.Margin = new System.Windows.Forms.Padding(6);
            this.txbGCode_cmd.Multiline = true;
            this.txbGCode_cmd.Name = "txbGCode_cmd";
            this.txbGCode_cmd.Size = new System.Drawing.Size(300, 452);
            this.txbGCode_cmd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total g-Code Sent: 0";
            // 
            // btnGCodeFileOpen
            // 
            this.btnGCodeFileOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGCodeFileOpen.Location = new System.Drawing.Point(15, 75);
            this.btnGCodeFileOpen.Margin = new System.Windows.Forms.Padding(6);
            this.btnGCodeFileOpen.Name = "btnGCodeFileOpen";
            this.btnGCodeFileOpen.Size = new System.Drawing.Size(127, 83);
            this.btnGCodeFileOpen.TabIndex = 0;
            this.btnGCodeFileOpen.Text = "Browse...";
            this.btnGCodeFileOpen.UseVisualStyleBackColor = true;
            this.btnGCodeFileOpen.Click += new System.EventHandler(this.btnStlFileOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 434);
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
            // readgCode
            // 
            this.readgCode.Location = new System.Drawing.Point(151, 34);
            this.readgCode.Margin = new System.Windows.Forms.Padding(4);
            this.readgCode.Name = "readgCode";
            this.readgCode.Size = new System.Drawing.Size(211, 46);
            this.readgCode.TabIndex = 4;
            this.readgCode.Text = "Send to Printer";
            this.readgCode.UseVisualStyleBackColor = true;
            this.readgCode.Click += new System.EventHandler(this.readgCode_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb4_Control);
            this.tabPage1.Controls.Add(this.gb4_Laser);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(830, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machine Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb4_Control
            // 
            this.gb4_Control.Controls.Add(this.btnZ_N1);
            this.gb4_Control.Controls.Add(this.btnZ_P100);
            this.gb4_Control.Controls.Add(this.btnHM);
            this.gb4_Control.Controls.Add(this.btnY_P100);
            this.gb4_Control.Controls.Add(this.btnZ_P1);
            this.gb4_Control.Controls.Add(this.btnX_P100);
            this.gb4_Control.Controls.Add(this.btnY_P1);
            this.gb4_Control.Controls.Add(this.btnZ_P10);
            this.gb4_Control.Controls.Add(this.btnX_N100);
            this.gb4_Control.Controls.Add(this.btnY_N1);
            this.gb4_Control.Controls.Add(this.btnX_N10);
            this.gb4_Control.Controls.Add(this.btnZ_N10);
            this.gb4_Control.Controls.Add(this.btnX_N1);
            this.gb4_Control.Controls.Add(this.btnX_P10);
            this.gb4_Control.Controls.Add(this.btnZ_N100);
            this.gb4_Control.Controls.Add(this.btnX_P1);
            this.gb4_Control.Controls.Add(this.btnY_N100);
            this.gb4_Control.Controls.Add(this.btnY_N10);
            this.gb4_Control.Controls.Add(this.btnY_P10);
            this.gb4_Control.Location = new System.Drawing.Point(12, 123);
            this.gb4_Control.Margin = new System.Windows.Forms.Padding(6);
            this.gb4_Control.Name = "gb4_Control";
            this.gb4_Control.Padding = new System.Windows.Forms.Padding(6);
            this.gb4_Control.Size = new System.Drawing.Size(806, 466);
            this.gb4_Control.TabIndex = 33;
            this.gb4_Control.TabStop = false;
            this.gb4_Control.Text = "Control Panel";
            // 
            // btnZ_N1
            // 
            this.btnZ_N1.Location = new System.Drawing.Point(96, 216);
            this.btnZ_N1.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N1.Name = "btnZ_N1";
            this.btnZ_N1.Size = new System.Drawing.Size(62, 43);
            this.btnZ_N1.TabIndex = 31;
            this.btnZ_N1.Text = "-1";
            this.btnZ_N1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZ_N1.UseVisualStyleBackColor = true;
            this.btnZ_N1.Click += new System.EventHandler(this.btnZ_N1_Click);
            // 
            // btnZ_P100
            // 
            this.btnZ_P100.Location = new System.Drawing.Point(40, 54);
            this.btnZ_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P100.Name = "btnZ_P100";
            this.btnZ_P100.Size = new System.Drawing.Size(242, 44);
            this.btnZ_P100.TabIndex = 23;
            this.btnZ_P100.Text = "Z100";
            this.btnZ_P100.UseVisualStyleBackColor = true;
            this.btnZ_P100.Click += new System.EventHandler(this.btnZ_P100_Click);
            // 
            // btnHM
            // 
            this.btnHM.Location = new System.Drawing.Point(480, 194);
            this.btnHM.Margin = new System.Windows.Forms.Padding(6);
            this.btnHM.Name = "btnHM";
            this.btnHM.Size = new System.Drawing.Size(82, 84);
            this.btnHM.TabIndex = 18;
            this.btnHM.Text = "HM";
            this.btnHM.UseVisualStyleBackColor = true;
            this.btnHM.Click += new System.EventHandler(this.btnHM_Click);
            // 
            // btnY_P100
            // 
            this.btnY_P100.Location = new System.Drawing.Point(426, 21);
            this.btnY_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P100.Name = "btnY_P100";
            this.btnY_P100.Size = new System.Drawing.Size(198, 44);
            this.btnY_P100.TabIndex = 12;
            this.btnY_P100.Text = "Y100";
            this.btnY_P100.UseVisualStyleBackColor = true;
            this.btnY_P100.Click += new System.EventHandler(this.btnY_P100_Click);
            // 
            // btnZ_P1
            // 
            this.btnZ_P1.Location = new System.Drawing.Point(168, 216);
            this.btnZ_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P1.Name = "btnZ_P1";
            this.btnZ_P1.Size = new System.Drawing.Size(62, 43);
            this.btnZ_P1.TabIndex = 21;
            this.btnZ_P1.Text = "1";
            this.btnZ_P1.UseVisualStyleBackColor = true;
            this.btnZ_P1.Click += new System.EventHandler(this.btnZ_P1_Click);
            // 
            // btnX_P100
            // 
            this.btnX_P100.Location = new System.Drawing.Point(720, 143);
            this.btnX_P100.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P100.Name = "btnX_P100";
            this.btnX_P100.Size = new System.Drawing.Size(48, 189);
            this.btnX_P100.TabIndex = 17;
            this.btnX_P100.Text = "100";
            this.btnX_P100.UseVisualStyleBackColor = true;
            this.btnX_P100.Click += new System.EventHandler(this.btnX_P100_Click);
            // 
            // btnY_P1
            // 
            this.btnY_P1.Location = new System.Drawing.Point(466, 134);
            this.btnY_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P1.Name = "btnY_P1";
            this.btnY_P1.Size = new System.Drawing.Size(118, 44);
            this.btnY_P1.TabIndex = 5;
            this.btnY_P1.Text = "1";
            this.btnY_P1.UseVisualStyleBackColor = true;
            this.btnY_P1.Click += new System.EventHandler(this.btnY_P1_Click);
            // 
            // btnZ_P10
            // 
            this.btnZ_P10.Location = new System.Drawing.Point(72, 136);
            this.btnZ_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_P10.Name = "btnZ_P10";
            this.btnZ_P10.Size = new System.Drawing.Size(178, 44);
            this.btnZ_P10.TabIndex = 22;
            this.btnZ_P10.Text = "10";
            this.btnZ_P10.UseVisualStyleBackColor = true;
            this.btnZ_P10.Click += new System.EventHandler(this.btnZ_P10_Click);
            // 
            // btnX_N100
            // 
            this.btnX_N100.Location = new System.Drawing.Point(280, 143);
            this.btnX_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N100.Name = "btnX_N100";
            this.btnX_N100.Size = new System.Drawing.Size(48, 189);
            this.btnX_N100.TabIndex = 16;
            this.btnX_N100.Text = "- 100";
            this.btnX_N100.UseVisualStyleBackColor = true;
            this.btnX_N100.Click += new System.EventHandler(this.btnX_N100_Click);
            // 
            // btnY_N1
            // 
            this.btnY_N1.Location = new System.Drawing.Point(466, 293);
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
            this.btnX_N10.Location = new System.Drawing.Point(352, 166);
            this.btnX_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N10.Name = "btnX_N10";
            this.btnX_N10.Size = new System.Drawing.Size(34, 144);
            this.btnX_N10.TabIndex = 15;
            this.btnX_N10.Text = "- 10";
            this.btnX_N10.UseVisualStyleBackColor = true;
            this.btnX_N10.Click += new System.EventHandler(this.btnX_N10_Click);
            // 
            // btnZ_N10
            // 
            this.btnZ_N10.Location = new System.Drawing.Point(78, 293);
            this.btnZ_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N10.Name = "btnZ_N10";
            this.btnZ_N10.Size = new System.Drawing.Size(166, 44);
            this.btnZ_N10.TabIndex = 24;
            this.btnZ_N10.Text = "-10";
            this.btnZ_N10.UseVisualStyleBackColor = true;
            this.btnZ_N10.Click += new System.EventHandler(this.btnZ_N10_Click);
            // 
            // btnX_N1
            // 
            this.btnX_N1.Location = new System.Drawing.Point(412, 184);
            this.btnX_N1.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_N1.Name = "btnX_N1";
            this.btnX_N1.Size = new System.Drawing.Size(52, 100);
            this.btnX_N1.TabIndex = 7;
            this.btnX_N1.Text = "- 1";
            this.btnX_N1.UseVisualStyleBackColor = true;
            this.btnX_N1.Click += new System.EventHandler(this.btnX_N1_Click);
            // 
            // btnX_P10
            // 
            this.btnX_P10.Location = new System.Drawing.Point(654, 166);
            this.btnX_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P10.Name = "btnX_P10";
            this.btnX_P10.Size = new System.Drawing.Size(38, 144);
            this.btnX_P10.TabIndex = 14;
            this.btnX_P10.Text = "10";
            this.btnX_P10.UseVisualStyleBackColor = true;
            this.btnX_P10.Click += new System.EventHandler(this.btnX_P10_Click);
            // 
            // btnZ_N100
            // 
            this.btnZ_N100.Location = new System.Drawing.Point(40, 371);
            this.btnZ_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnZ_N100.Name = "btnZ_N100";
            this.btnZ_N100.Size = new System.Drawing.Size(242, 44);
            this.btnZ_N100.TabIndex = 25;
            this.btnZ_N100.Text = "Z-100";
            this.btnZ_N100.UseVisualStyleBackColor = true;
            this.btnZ_N100.Click += new System.EventHandler(this.btnZ_N100_Click);
            // 
            // btnX_P1
            // 
            this.btnX_P1.Location = new System.Drawing.Point(578, 184);
            this.btnX_P1.Margin = new System.Windows.Forms.Padding(6);
            this.btnX_P1.Name = "btnX_P1";
            this.btnX_P1.Size = new System.Drawing.Size(52, 100);
            this.btnX_P1.TabIndex = 8;
            this.btnX_P1.Text = "1";
            this.btnX_P1.UseVisualStyleBackColor = true;
            this.btnX_P1.Click += new System.EventHandler(this.btnX_P1_Click);
            // 
            // btnY_N100
            // 
            this.btnY_N100.Location = new System.Drawing.Point(426, 406);
            this.btnY_N100.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_N100.Name = "btnY_N100";
            this.btnY_N100.Size = new System.Drawing.Size(198, 44);
            this.btnY_N100.TabIndex = 13;
            this.btnY_N100.Text = "Y- 100";
            this.btnY_N100.UseVisualStyleBackColor = true;
            this.btnY_N100.Click += new System.EventHandler(this.btnY_N100_Click);
            // 
            // btnY_N10
            // 
            this.btnY_N10.Location = new System.Drawing.Point(450, 350);
            this.btnY_N10.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_N10.Name = "btnY_N10";
            this.btnY_N10.Size = new System.Drawing.Size(150, 44);
            this.btnY_N10.TabIndex = 10;
            this.btnY_N10.Text = "- 10";
            this.btnY_N10.UseVisualStyleBackColor = true;
            this.btnY_N10.Click += new System.EventHandler(this.btnY_N10_Click);
            // 
            // btnY_P10
            // 
            this.btnY_P10.Location = new System.Drawing.Point(450, 77);
            this.btnY_P10.Margin = new System.Windows.Forms.Padding(6);
            this.btnY_P10.Name = "btnY_P10";
            this.btnY_P10.Size = new System.Drawing.Size(150, 44);
            this.btnY_P10.TabIndex = 9;
            this.btnY_P10.Text = "10";
            this.btnY_P10.UseVisualStyleBackColor = true;
            this.btnY_P10.Click += new System.EventHandler(this.btnY_P10_Click);
            // 
            // gb4_Laser
            // 
            this.gb4_Laser.Controls.Add(this.label10);
            this.gb4_Laser.Controls.Add(this.btn_Laser_on_off);
            this.gb4_Laser.Controls.Add(this.btn_Laser_on_off_dependTime);
            this.gb4_Laser.Controls.Add(this.label8);
            this.gb4_Laser.Controls.Add(this.label7);
            this.gb4_Laser.Controls.Add(this.tbxLaserOnTime);
            this.gb4_Laser.Location = new System.Drawing.Point(12, 11);
            this.gb4_Laser.Margin = new System.Windows.Forms.Padding(6);
            this.gb4_Laser.Name = "gb4_Laser";
            this.gb4_Laser.Padding = new System.Windows.Forms.Padding(6);
            this.gb4_Laser.Size = new System.Drawing.Size(806, 121);
            this.gb4_Laser.TabIndex = 32;
            this.gb4_Laser.TabStop = false;
            this.gb4_Laser.Text = "Laser Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(572, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Laser On Off:";
            // 
            // btn_Laser_on_off
            // 
            this.btn_Laser_on_off.Location = new System.Drawing.Point(578, 57);
            this.btn_Laser_on_off.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Laser_on_off.Name = "btn_Laser_on_off";
            this.btn_Laser_on_off.Size = new System.Drawing.Size(104, 44);
            this.btn_Laser_on_off.TabIndex = 4;
            this.btn_Laser_on_off.Text = "On";
            this.btn_Laser_on_off.UseVisualStyleBackColor = true;
            this.btn_Laser_on_off.Click += new System.EventHandler(this.btn_Laser_on_off_Click);
            // 
            // btn_Laser_on_off_dependTime
            // 
            this.btn_Laser_on_off_dependTime.Location = new System.Drawing.Point(256, 57);
            this.btn_Laser_on_off_dependTime.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Laser_on_off_dependTime.Name = "btn_Laser_on_off_dependTime";
            this.btn_Laser_on_off_dependTime.Size = new System.Drawing.Size(104, 44);
            this.btn_Laser_on_off_dependTime.TabIndex = 3;
            this.btn_Laser_on_off_dependTime.Text = "On";
            this.btn_Laser_on_off_dependTime.UseVisualStyleBackColor = true;
            this.btn_Laser_on_off_dependTime.Click += new System.EventHandler(this.btn_Laser_on_off_dependTime_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 66);
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
            this.label7.Location = new System.Drawing.Point(88, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Laser On Time:";
            // 
            // tbxLaserOnTime
            // 
            this.tbxLaserOnTime.Location = new System.Drawing.Point(94, 61);
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
            this.tabControl1.Location = new System.Drawing.Point(16, 100);
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
            this.Y_Label.Location = new System.Drawing.Point(1032, 18);
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
            this.Z_Label.Location = new System.Drawing.Point(1212, 18);
            this.Z_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Z_Label.Name = "Z_Label";
            this.Z_Label.Size = new System.Drawing.Size(70, 33);
            this.Z_Label.TabIndex = 37;
            this.Z_Label.Text = "Z: 0";
            // 
            // btn_Pause
            // 
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.ForeColor = System.Drawing.Color.Green;
            this.btn_Pause.Location = new System.Drawing.Point(531, 11);
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
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(708, 11);
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
            this.statusStrip1.Location = new System.Drawing.Point(16, 755);
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
            this.L_Label.Location = new System.Drawing.Point(1350, 16);
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
            this.rtxbCmd.Location = new System.Drawing.Point(884, 71);
            this.rtxbCmd.Margin = new System.Windows.Forms.Padding(6);
            this.rtxbCmd.Name = "rtxbCmd";
            this.rtxbCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxbCmd.Size = new System.Drawing.Size(566, 618);
            this.rtxbCmd.TabIndex = 42;
            this.rtxbCmd.Text = "";
            this.rtxbCmd.TextChanged += new System.EventHandler(this.rtxbCmd_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(330, 11);
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
            this.lbl_LastBuild.Location = new System.Drawing.Point(1164, 767);
            this.lbl_LastBuild.Name = "lbl_LastBuild";
            this.lbl_LastBuild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LastBuild.Size = new System.Drawing.Size(111, 25);
            this.lbl_LastBuild.TabIndex = 44;
            this.lbl_LastBuild.Text = "Build Date";
            this.lbl_LastBuild.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 797);
            this.Controls.Add(this.lbl_LastBuild);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rtxbCmd);
            this.Controls.Add(this.L_Label);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.Z_Label);
            this.Controls.Add(this.Y_Label);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaudRates);
            this.Controls.Add(this.cmbPortList);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "RepRap SWIM-ER Controlar [Developed by Furukawa Lab] V: 1.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.gb4_gCodeSend.ResumeLayout(false);
            this.gb4_gCodeSend.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gb4_Control.ResumeLayout(false);
            this.gb4_Laser.ResumeLayout(false);
            this.gb4_Laser.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.ComboBox cmbBaudRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
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
        private System.Windows.Forms.Button readgCode;
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
        private System.Windows.Forms.GroupBox gb4_Laser;
        private System.Windows.Forms.Button btn_Laser_on_off;
        private System.Windows.Forms.Button btn_Laser_on_off_dependTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLaserOnTime;
        private System.Windows.Forms.GroupBox gb4_Control;
        private System.Windows.Forms.RichTextBox rtxbCmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNumberOfLayer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Stopwatch;
        private System.Windows.Forms.Button btnSaveSD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbl_LastBuild;
        private System.Windows.Forms.Button btnSendSWIMER;
    }
}

