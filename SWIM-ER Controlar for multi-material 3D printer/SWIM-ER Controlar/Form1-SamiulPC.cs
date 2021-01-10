using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace SWIM_ER_Controlar
{
    public partial class Form1 : Form
    {
        //public string browseGCode_Path;
        public string saveGCode_Path;
        public string gcodeLine;
        public string GCODE;
        string keepGCODE, keepCmd;
        string G, M, S, X, Y, Z, E, F;
        int TotalLineNumber, keepLineNumberForZ;
        Boolean laserStatusFlag = false, laserOnOffFlag = false;



        public string GCODE_Path;// = "C:\\Users\\SWER-ER\\Desktop\\Model1.gcode";
        public string GCODE_fileName;
        string line = string.Empty; //gcode line string
        public bool ack = true, PauseFlag = false, StopFlag = false, nubOfLayerFlug = false;
        int LineNumber = 0, numOfLayer = 0, ScanIncrement = 1, NumberOfScan = 0;
        string nmbOfLayerWant;
        float XpositionValue = 0, YpositionValue = 0, ZpositionValue = 0;
        string rxData;
        Int32 lineColorFlag;// Green, brown, gray;
        Color[] color = new Color[] { Color.Green, Color.Brown, Color.Gray };
        //Color.Red = green; //TextBox.ForeColor = Color.Red;


        public bool buttonForSend = false;
        public bool buttonForSaveText = false;


        Stopwatch stopWatch = new Stopwatch();


        public Form1()
        {
            InitializeComponent();

            bgW_SerialDataSend = new BackgroundWorker();
            // To report progress from the background worker we need to set this property
            bgW_SerialDataSend.WorkerReportsProgress = true;
            bgW_SerialDataSend.WorkerSupportsCancellation = true;
            bgW_SerialDataSend.DoWork += bgW_SerialDataSend_DoWork;
            bgW_SerialDataSend.ProgressChanged += bgW_SerialDataSend_ProgressChanged;
            bgW_SerialDataSend.RunWorkerCompleted += bgW_SerialDataSend_RunWorkerCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_LastBuild.Text = "Build Date: 4/23/2018 [Samiul]";
            //RepRap SWIM-ER Controlar[Developed by Furukawa Lab] V: 1.3

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortList.Items.Add(port);
            }
            //cmbPortList.Items.AddRange(ports);
            //cmbPortList.Text = ports[0];
            cmbBaudRates.Text = "115200";

            DisableButtons();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }
        void DisableButtons()
        {
            gb4_Laser.Enabled = false;
            gb4_Control.Enabled = false;
            //gb4_gCodeSend.Enabled = false;
            btnSend.Enabled = false;
            readgCode.Enabled = false;
        }

        void EnableButtons()
        {
            btnGCodeFileOpen.Enabled = true;
            gb4_Laser.Enabled = true;
            gb4_Control.Enabled = true;
            gb4_gCodeSend.Enabled = true;
            btnSend.Enabled = true;
            readgCode.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPortList.Items.Clear();
            cmbPortList.ResetText();

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortList.Items.Add(port);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPortList.Text == "" || cmbBaudRates.Text == "")
                {
                    MessageBox.Show("Choose COM Port or BaudRate");
                }
                else
                {
                    if (btnConnect.Text == "Connect")
                    {
                        serialPort.PortName = cmbPortList.Text;
                        serialPort.BaudRate = Convert.ToInt32(cmbBaudRates.Text);
                        serialPort.Open();
                        if (serialPort.IsOpen)
                        {
                            btnConnect.Text = "Disconnect";
                            EnableButtons();
                            rtxbCmd.AppendText(">SWEM-ER Online Successfully" + "\n");
                            //labelStatus.Text = "Connected Successfully.";
                        }
                    }
                    else if (serialPort.IsOpen)
                    {
                        btnConnect.Text = "Connect";
                        serialPort.Close();
                        DisableButtons();
                        rtxbCmd.AppendText(">SWEM-ER Disconnected Successfully" + "\n");
                    }
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void rtxbCmd_TextChanged(object sender, EventArgs e)
        {
            rtxbCmd.WordWrap = false; // for horizontal scrol 
            // set the current caret position to the end            
            rtxbCmd.SelectionStart = rtxbCmd.Text.Length;
            // scroll it automatically
            rtxbCmd.ScrollToCaret();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            serialPort = (SerialPort)sender;
            rxData = serialPort.ReadExisting();
            this.Invoke(new EventHandler(displaytext));
        }


        private void displaytext(object sender, EventArgs e)
        {
            //rtxbCmd.AppendText(rxData + "\n");
            string[] feedback = rxData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            if (feedback[0].Contains("ok"))
            {
                rtxbCmd.AppendText("RECEIVED: ok" + "\n");
                ack = true;
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(txbSend.Text + "\n");
        }


        private void btnHM_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("G28");
        }

        /*===========================================================================*/
        private void btnX_P1_Click(object sender, EventArgs e)
        {
            //label3.Text = "";
            XpositionValue = XpositionValue + 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnX_N1_Click(object sender, EventArgs e)
        {
            XpositionValue = XpositionValue - 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/

        private void btnX_P10_Click(object sender, EventArgs e)
        {
            XpositionValue = XpositionValue + 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnX_N10_Click(object sender, EventArgs e)
        {
            XpositionValue = XpositionValue - 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/
        private void btnX_P100_Click(object sender, EventArgs e)
        {
            XpositionValue = XpositionValue + 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnX_N100_Click(object sender, EventArgs e)
        {
            XpositionValue = XpositionValue - 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/
        private void btnY_P1_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue + 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnY_N1_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue - 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }
        /*===========================================================================*/

        private void btnY_P10_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue + 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnY_N10_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue - 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }
        /*===========================================================================*/
        private void btnY_P100_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue + 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnY_N100_Click(object sender, EventArgs e)
        {
            YpositionValue = YpositionValue - 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/
        private void btnZ_P1_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue + 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnZ_N1_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue - 1;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/
        private void btnZ_P10_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue + 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        private void btnZ_N10_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue - 10;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }

        /*===========================================================================*/
        private void btnZ_P100_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue + 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }


        private void btnZ_N100_Click(object sender, EventArgs e)
        {
            ZpositionValue = ZpositionValue - 100;
            serialPort.WriteLine("G1 X" + XpositionValue + " Y" + YpositionValue + " Z" + ZpositionValue);
            rtxbCmd.AppendText("SENT: X:" + XpositionValue + "  Y:" + YpositionValue + "  Z:" + ZpositionValue + "\n");
        }
        /*===========================================================================*/



        private void btnStlFileOpen_Click(object sender, EventArgs e)
        {
            Stream browseFile = null;
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Title = "Browse GCode";
            openFileDialog.Filter = "gcode files (*.gcode)|*.gcode|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((browseFile = openFileDialog.OpenFile()) != null)
                    {
                        using (browseFile)
                        {
                            GCODE_Path = openFileDialog.FileName;
                            toolStripStatusLabel.Text = "Directory: " + GCODE_Path;
                            GCODE_fileName = openFileDialog.SafeFileName;
                            browseFile.Close();
                        }
                    }
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
            else
                MessageBox.Show("Can't Open file");
        }


        private void readgCode_Click(object sender, EventArgs e)
        {
            if (GCODE_Path == null) { MessageBox.Show("Please select a G-CODE file with a .gcode extension from Browse."); }

            else
            {
                buttonForSend = true;
                buttonForSaveText = false;

                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
                StopFlag = false;
                //work goods read g-Code
                rtxbCmd.Text = "";
                txbGCode_cmd.Text = "";

                TotalLineNumber = 0;
                txbGCode_cmd.AppendText("> G-CODE Reading..." + "\n");

                TotalLineNumber = File.ReadAllLines(GCODE_Path).Length;

                txbGCode_cmd.AppendText("> Done Reading." + "\n");
                txbGCode_cmd.AppendText("> Total Line: " + TotalLineNumber + "\n" + "\n");
                txbGCode_cmd.AppendText("Start Printing..." + "\n");

                stopWatch.Start();//start stopwatch

                if (!bgW_SerialDataSend.IsBusy)
                {
                    //Start the asynchronous operation.
                    bgW_SerialDataSend.RunWorkerAsync(TotalLineNumber);
                }
            }
        }

        private void btnSaveSD_Click(object sender, EventArgs e)
        {
            if (GCODE_Path == null) { MessageBox.Show("Please select a G-CODE file with a .gcode extension from Browse."); }

            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save GCode";
                saveFileDialog.Filter = "gcode file (*.gcode)|*.gcode|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        saveGCode_Path = saveFileDialog.FileName;

                        buttonForSaveText = false;
                        buttonForSend = false;

                        btn_Pause.Enabled = true;
                        btn_Stop.Enabled = true;
                        StopFlag = false;
                        //work goods read g-Code
                        rtxbCmd.Text = "";
                        txbGCode_cmd.Text = "";

                        TotalLineNumber = 0;
                        txbGCode_cmd.AppendText("> G-CODE Reading..." + "\n");

                        TotalLineNumber = File.ReadAllLines(GCODE_Path).Length;

                        txbGCode_cmd.AppendText("> Done Reading." + "\n");
                        txbGCode_cmd.AppendText("> Total Line: " + TotalLineNumber + "\n" + "\n");
                        txbGCode_cmd.AppendText("Start Printing..." + "\n");

                        stopWatch.Start();//start stopwatch

                        if (!bgW_SerialDataSend.IsBusy)
                        {
                            //Start the asynchronous operation.
                            bgW_SerialDataSend.RunWorkerAsync(TotalLineNumber);
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                    MessageBox.Show("Can't save file");
            }
        }

        private void btnSendSWIMER_Click(object sender, EventArgs e)
        {
            if (GCODE_Path == null) { MessageBox.Show("Please select a G-CODE file with a .gcode extension from Browse."); }

            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save GCode";
                saveFileDialog.Filter = "text file (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        saveGCode_Path = saveFileDialog.FileName;

                        buttonForSaveText = true;
                        buttonForSend = false;

                        btn_Pause.Enabled = true;
                        btn_Stop.Enabled = true;
                        StopFlag = false;
                        //work goods read g-Code
                        rtxbCmd.Text = "";
                        txbGCode_cmd.Text = "";

                        TotalLineNumber = 0;
                        txbGCode_cmd.AppendText("> G-CODE Reading..." + "\n");

                        TotalLineNumber = File.ReadAllLines(GCODE_Path).Length;

                        txbGCode_cmd.AppendText("> Done Reading." + "\n");
                        txbGCode_cmd.AppendText("> Total Line: " + TotalLineNumber + "\n" + "\n");
                        txbGCode_cmd.AppendText("Start Printing..." + "\n");

                        stopWatch.Start();//start stopwatch

                        if (!bgW_SerialDataSend.IsBusy)
                        {
                            //Start the asynchronous operation.
                            bgW_SerialDataSend.RunWorkerAsync(TotalLineNumber);
                        }


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                    MessageBox.Show("Can't save file");
            }
        }


        public void readGCodeFromFile()
        {
            string[] allLines = File.ReadAllLines(GCODE_Path);
            gcodeLine = null;
            ScanIncrement = 0;
            while (allLines != null && LineNumber < TotalLineNumber)// read line by line
            {
                gcodeLine = allLines[LineNumber++];

                //---------For pause sending gcode--------//
                while (PauseFlag) { }
                //----------------------------------------//

                //---------For stop sending gcode---------//
                if (StopFlag)
                {
                    this.Invoke(new MethodInvoker(delegate { L_Label.Text = "L: OFF"; }));
                    this.Invoke(new MethodInvoker(delegate { txbGCode_cmd.AppendText("Stoped Printing. " + "\n"); }));//
                    //serialPort.WriteLine("M102" + "\n"); stop all motor
                    break;
                }
                //----------------------------------------//

                //-----------For Number of Layer----------//
                if (nubOfLayerFlug) { break; }
                //----------------------------------------//


                if (gcodeLine.Contains(';'))//delete after gcode comment. [eg: G90 ; use absolute coordinates]
                {
                    string[] cmdline = gcodeLine.Split(';');
                    gcodeLine = cmdline[0];
                }
                GCode_Interpreter();

                this.Invoke(new MethodInvoker(delegate { label5.Text = String.Format("Total g-Code Sent: {0}", LineNumber); }));// print cmd
                int percentage = ((LineNumber * 100) / TotalLineNumber);
                bgW_SerialDataSend.ReportProgress(percentage);
            }// end while

        }

        public string writeGCodeToFile(string gcode) //
        {
            using (var writeGCode = new StreamWriter(saveGCode_Path, true))
            {
                lineColorFlag = 0;
                if (GCODE.Contains("M")) lineColorFlag = 1;


                this.Invoke(new MethodInvoker(delegate { rtxbCmd.SelectionColor = color[lineColorFlag]; }));
                this.Invoke(new MethodInvoker(delegate { rtxbCmd.AppendText("SENT: #" + LineNumber + "  " + GCODE + "\n"); }));// print cmd


                writeGCode.WriteLine(gcode);
                writeGCode.Close();
            }
            return 0.ToString();
        }

        public void GCode_Interpreter() //
        {
            Regex GcodeLine = new Regex("[mgsxyzef;][+-]?[0-9]*\\.?[0-9]*", RegexOptions.IgnoreCase);
            MatchCollection line = GcodeLine.Matches(gcodeLine);
            bool copyFlug = false;
            laserOnOffFlag = false;
            G = M = S = X = Y = Z = E = F = null;

            foreach (Match code in line)
            {
                if (code.Value.StartsWith("G"))
                {
                    G = code.Value;
                    GCODE = G;
                }

                if (code.Value.StartsWith("M"))
                {
                    M = code.Value;
                    if (M == "M104" || M == "M109") { } // remove extruder temparature set command 
                    else GCODE = M;
                }

                if ((code.Value.StartsWith("X")))
                {
                    X = Regex.Replace(code.Value, "[^0-9.]", "");
                    this.Invoke(new MethodInvoker(delegate { X_Label.Text = "X: " + X; }));
                    GCODE = GCODE + " X" + X;
                }

                if (code.Value.StartsWith("Y"))
                {
                    Y = Regex.Replace(code.Value, "[^0-9.]", "");
                    this.Invoke(new MethodInvoker(delegate { Y_Label.Text = "Y: " + Y; }));
                    GCODE = GCODE + " Y" + Y;
                }

                if ((code.Value.StartsWith("Z")))
                {
                    Z = Regex.Replace(code.Value, "[^0-9.]", "");
                    this.Invoke(new MethodInvoker(delegate { Z_Label.Text = "Z: " + Z; }));
                    GCODE = GCODE + " Z" + Z;

                    if (ScanIncrement == 0 && Convert.ToDouble(Z) == 5) { } // skip only 1st Z code eg."G1 Z5 F5000 ; lift nozzle"
                    else
                    {
                        //--------------For Z Scanning------------//
                        if (ScanIncrement == 0) { keepLineNumberForZ = LineNumber; numOfLayer++; }
                        else { copyFlug = true; }

                        ScanIncrement++;
                        this.Invoke(new MethodInvoker(delegate { txbGCode_cmd.AppendText("#" + numOfLayer + " Layer scaning for " + ScanIncrement + " times" + "\n"); }));// print cmd
                        this.Invoke(new MethodInvoker(delegate { rtxbCmd.AppendText("------layer------" + "\n"); }));
                        this.Invoke(new Action(() => { NumberOfScan = Convert.ToInt32(cmbNumberOfScan.Text); }));// get number of scan

                        if (ScanIncrement >= NumberOfScan) { ScanIncrement = 0; }// here numberOfScan is how many number of copy g code 
                        //----------------------------------------//


                        //-----------For Number of Layer----------//
                        this.Invoke(new Action(() => { nmbOfLayerWant = cmbNumberOfLayer.Text; }));
                        if (nmbOfLayerWant == "Full Object Printing") { }
                        else
                        {
                            //nmbOfLayerWant = Convert.ToInt32(cmbNumberOfLayer.Text);
                            if (numOfLayer > Convert.ToInt32(nmbOfLayerWant))
                            {
                                this.Invoke(new MethodInvoker(delegate { txbGCode_cmd.AppendText("> Object print up to " + numOfLayer + " Layers " + "\n"); }));// print cmd
                                nubOfLayerFlug = true; // program break in readGCodeFromFile() 
                            }
                        }
                        //----------------------------------------//
                    }
                }//end Z

                if ((code.Value.StartsWith("E")))
                {
                    E = Regex.Replace(code.Value, "[^0-9.]", "");
                    if (GCODE.Contains("G92")) GCODE = GCODE + " E" + E;

                    //------------For Laser on/off----------//
                    double e = Convert.ToDouble(E);
                    if (e == 0) { laserOnOffFlag = false; }
                    if (e > 0) { laserOnOffFlag = true; }
                    //----------------------------------------//
                }

                if ((code.Value.StartsWith("F")))
                {
                    F = Regex.Replace(code.Value, "[^0-9.]", "");
                    GCODE = GCODE + " F" + F;
                }

            }//end forch each



            //------------For Laser on/off----------//
            if (laserOnOffFlag && !laserStatusFlag) { keepCmd = GCODE; Laser_ON(); }
            if (!laserOnOffFlag && laserStatusFlag) { keepCmd = GCODE; Laser_OFF(); }
            //----------------------------------------//


            if (keepGCODE != GCODE && !copyFlug && !nubOfLayerFlug) // print gcode   
            {
                whichWork();
                keepGCODE = GCODE;
            }


            //--------------For Z Scanning------------//
            if (copyFlug == true) { LineNumber = keepLineNumberForZ; copyFlug = false; }
            //----------------------------------------//

        }

        private void whichWork()
        {
            if (buttonForSaveText == true)
            {
                writeGCodeToFile(GCODE);
            }

            if (buttonForSend == true)
            {
                SentToSerialPort();
            }
        }

        private void Laser_ON()
        {
            laserStatusFlag = true;
            this.Invoke(new MethodInvoker(delegate { L_Label.Text = "L: ON"; }));

            GCODE = "G4 P0";
            whichWork();
            GCODE = "M101";
            whichWork();
            GCODE = "G4 P0";
            whichWork();

            GCODE = keepCmd;
        }

        private void Laser_OFF()
        {
            laserStatusFlag = false;
            this.Invoke(new MethodInvoker(delegate { L_Label.Text = "L: OFF"; }));

            GCODE = "G4 P0";
            whichWork();
            GCODE = "M102";
            whichWork();
            GCODE = "G4 P0";
            whichWork();

            GCODE = keepCmd;
        }

        private void SentToSerialPort()
        {
            lineColorFlag = 0;
            if (GCODE.Contains("M")) lineColorFlag = 1;


            this.Invoke(new MethodInvoker(delegate { rtxbCmd.SelectionColor = color[lineColorFlag]; }));
            this.Invoke(new MethodInvoker(delegate { rtxbCmd.AppendText("SENT: #" + LineNumber + "  " + GCODE + "\n"); }));// print cmd


            while (!ack) { }//wait for ack             
            ack = false;
            serialPort.WriteLine(GCODE);// sent cmd in mcu
            System.Threading.Thread.Sleep(100);
        }

        private void bgW_SerialDataSend_DoWork(object sender, DoWorkEventArgs e)
        {
            readGCodeFromFile();
        }//end bgW_SerialDataSend_DoWork

        private void bgW_SerialDataSend_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= 100)
            {
                pB_gCodeSend.Value = e.ProgressPercentage;
                label4.Text = String.Format("Object printed: {0} %, ", e.ProgressPercentage);
            }

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            lbl_Stopwatch.Text = Convert.ToString(elapsedTime);
        }

        private void bgW_SerialDataSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate { txbGCode_cmd.AppendText("Job Done... " + "\n"); }));//
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;

            buttonForSaveText = false;
            buttonForSend = false;

            bgW_SerialDataSend.CancelAsync();
            bgW_SerialDataSend.Dispose();
            //bgW_SerialDataSend = null;
            GC.Collect();

            stopWatch.Stop();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (btn_Pause.Text == "Pause")
            {
                PauseFlag = true;
                btn_Pause.Text = "Start";
            }
            else
            {
                PauseFlag = false;
                btn_Pause.Text = "Pause";
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            StopFlag = true;
        }

        private void btn_Laser_on_off_dependTime_Click(object sender, EventArgs e)
        {
            if (btn_Laser_on_off_dependTime.Text == "On")
            {
                string LaserOnTime = string.Empty;
                LaserOnTime = tbxLaserOnTime.Text;
                serialPort.WriteLine("M103 S" + LaserOnTime + "\n");
            }
        }


        private void btn_Laser_on_off_Click(object sender, EventArgs e)
        {
            if (btn_Laser_on_off.Text == "On")
            {
                btn_Laser_on_off.Text = "Off";
                serialPort.WriteLine("M101" + "\n");
            }
            else
            {
                btn_Laser_on_off.Text = "On";
                serialPort.WriteLine("M102" + "\n");
                laserStatusFlag = false;
            }
        }
    }
}
