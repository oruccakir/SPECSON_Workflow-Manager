using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelDataReader;
using System.Diagnostics;
using System.IO.Ports;

using NModbus;
using NModbus.Device;
using NModbus.IO;

namespace SPECSON_WorkFlow_Manager
{
    public partial class MainPage : Form
    {
        public static MainPage instance;

        // for calculating the time
        Stopwatch stopwatch = new Stopwatch();
        int counter = 0;    
        //COM Port Page Datas
        public System.Windows.Forms.TextBox COMPortPage_COMPort;
        public System.Windows.Forms.TextBox COMPortPage_BaudRate;
        public System.Windows.Forms.TextBox COMPortPage_Parity;
        public System.Windows.Forms.TextBox COMPortPage_DataBits;
        public System.Windows.Forms.TextBox COMPortPage_StopBit;

        //Gas Paramaters Datas
        public System.Windows.Forms.TextBox GasTypesPage_MFC1GasName;
        public System.Windows.Forms.TextBox GasTypesPage_MFC2GasName;
        public System.Windows.Forms.TextBox GasTypesPage_MFC3GasName;
        public System.Windows.Forms.TextBox GasTypesPage_MFC4GasName;
        public System.Windows.Forms.TextBox GasTypesPage_MFC5GasName;

        //Gas Percentage Datas
        public System.Windows.Forms.TextBox GasTypesPage_MFC1GasParameter;
        public System.Windows.Forms.TextBox GasTypesPage_MFC2GasParameter;
        public System.Windows.Forms.TextBox GasTypesPage_MFC3GasParameter;
        public System.Windows.Forms.TextBox GasTypesPage_MFC4GasParameter;
        public System.Windows.Forms.TextBox GasTypesPage_MFC5GasParameter;

        //Temperature Datas
        public System.Windows.Forms.TextBox GasTypesPage_CellTemperature;
        public System.Windows.Forms.TextBox GasTypesPage_ResistanceTemperature;
        public System.Windows.Forms.Label GasTypesPage_CellTemperatureLabel;
        public System.Windows.Forms.Label GasTypesPage_ResistanceTemperatureLabel;
        public System.Windows.Forms.GroupBox GasTypesPage_Temperature;

        //K-Factors
        const double kFact_ArinAr = 1;
        const double kFact_O2inAr = 0.68;
        const double kFact_H2inAr = 0.70;
        const double kFact_CO2inAr = 0.51;
        const double kFact_ArinCH4 = 0.50;
        const double kFact_COinAr = 0.69;
        const double kFact_ArinNO = 0.68;


        const char foo_char = ' ';
        float ResistanceTemp = 0;
        float CellTemp = 0;

        //Set Values 
        int[] Set_MFCFlows = new int[7];
        double[] Get_MFCFlows = new double[7];
        float[] mfcData = new float[7];
        int Set_Temp = 0;
        int Set_Ramp = 0;
        int Write_Temp = 0;
        double[] FlowFactors = new double[7];

        //TIMERS
        int RealTimer = 0;

        //FLAGS
        bool SetTempFlag = false;
        bool[] MFCFlags = new bool[7];
        int[] MFCMultis = { 0, 0, 32, 64, 64, 640, 1600 };
        bool Ramp_Enable = false;
        bool[] MFCTimers = { false, false, false, false, false, false, false };
        bool automationMode = false;

        //Connections
        ModbusClient COM = new ModbusClient();
        const int DefaultTimeout = 200;
        const int DefaultSlaveNum = 1;
        const int TemperatureResSlaveNum = 1;
        const int MFC1SlaveNum = 2;
        const int MFC2SlaveNum = 3;
        const int MFC3SlaveNum = 4;
        const int MFC4SlaveNum = 5;
        const int MFC5SlaveNum = 6;
        const int TemperatureCellSlaveNum = 7;
        const int HoldingRegReadTemp = 0x1000;
        const int HoldingRegWriteTemp = 0x1001;
        const int HoldingRegReadFlow = 32;
        const int HoldingRegWriteFlow = 33;
        const int AnalogOutputSlaveNum = 1;
        const int AnalogInputSlaveNum = 2;
        double GraphFrequency = 1;
        int GraphTime = 0;

        //Automation Vars
        string autoTime = "";
        int autoRealTime = 0;
        public int row = 5;


        private SerialPort serialPort; 
        private IModbusSerialMaster master;
        public int readTimeout = 1000;
        public int writeTimeout = 1000;

        public MainPage()
        {
            InitializeComponent();
            instance = this;

            //Connection Parameters
            COMPortPage_COMPort = textBox_COMPort;
            COMPortPage_BaudRate = textBox_BaudRate;
            COMPortPage_Parity = textBox_Parity;
            COMPortPage_DataBits = textBox_DataBits;
            COMPortPage_StopBit = textBox_StopBit;

            //Gas Paramaters
            GasTypesPage_MFC1GasName = textBox_MFC1GasName;
            GasTypesPage_MFC2GasName = textBox_MFC2GasName;
            GasTypesPage_MFC3GasName = textBox_MFC3GasName;
            GasTypesPage_MFC4GasName = textBox_MFC4GasName;
            GasTypesPage_MFC5GasName = textBox_MFC5GasName;

            //Gas Percentages
            GasTypesPage_MFC1GasParameter = textBox_MFC1Percentage;
            GasTypesPage_MFC2GasParameter = textBox_MFC2Percentage;
            GasTypesPage_MFC3GasParameter = textBox_MFC3Percentage;
            GasTypesPage_MFC4GasParameter = textBox_MFC4Percentage;
            GasTypesPage_MFC5GasParameter = textBox_MFC5Percentage;

            //Temperature Enable Settings
            GasTypesPage_CellTemperature = textBox_CellTemp;
            GasTypesPage_ResistanceTemperature = textBox_ResistanceTemp;
            GasTypesPage_CellTemperatureLabel = label_CellTemp;
            GasTypesPage_ResistanceTemperatureLabel = label_ResistanceTemp;
            GasTypesPage_Temperature = groupBox_Temperature;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //Timer Inits
            timer_Write.Tick += timer_Write_Tick;
            timer_Write.Interval = 1000;

            timer_Read.Tick += timer_Read_Tick;
            timer_Read.Interval = 1000;


            //All boxes are default disable
            groupBox_MFC1.Enabled = false;
            groupBox_MFC2.Enabled = false;
            groupBox_MFC3.Enabled = false;
            groupBox_MFC4.Enabled = false;
            groupBox_MFC5.Enabled = false;

            //Disabled buttons
            button_Stop.Enabled = false;
            button_AutomationStop.Enabled = false;

            //Disabled Ramp
            label_TempRamp.Enabled = false;
            numericUpDown_TempRamp.Enabled = false;

            //Disabled MFC Times
            textBox_MFC1Time.Enabled = false;
            textBox_MFC2Time.Enabled = false;
            textBox_MFC3Time.Enabled = false;
            textBox_MFC4Time.Enabled = false;
            textBox_MFC5Time.Enabled = false;

        }

        //Other windows applications
        private void Click_COMPortSelection(object sender, EventArgs e)
        {
            COMPortPage COMPortSet = new COMPortPage();
            COMPortSet.Show();
        }

        private void Click_GasTypes(object sender, EventArgs e)
        {
            GasTypesPage GasType = new GasTypesPage();
            GasType.Show();
        }

        //MFC enable/disable status
        private void TextChanged_MFC1GasName(object sender, EventArgs e)
        {
            if (textBox_MFC1GasName.Text == "Disable")
                groupBox_MFC1.Enabled = false;
            else
                groupBox_MFC1.Enabled = true;
        }

        private void TextChanged_MFC2GasNam(object sender, EventArgs e)
        {
            if (textBox_MFC2GasName.Text == "Disable")
                groupBox_MFC2.Enabled = false;
            else
                groupBox_MFC2.Enabled = true;
        }

        private void TextChanged_MFC3GasNam(object sender, EventArgs e)
        {
            if (textBox_MFC3GasName.Text == "Disable")
                groupBox_MFC3.Enabled = false;
            else
                groupBox_MFC3.Enabled = true;
        }

        private void TextChanged_MFC4GasNam(object sender, EventArgs e)
        {
            if (textBox_MFC4GasName.Text == "Disable")
                groupBox_MFC4.Enabled = false;
            else
                groupBox_MFC4.Enabled = true;
        }

        private void TextChanged_MFC5GasNam(object sender, EventArgs e)
        {
            if (textBox_MFC5GasName.Text == "Disable")
                groupBox_MFC5.Enabled = false;
            else
                groupBox_MFC5.Enabled = true;
        }

        private void Click_SetMFC1(object sender, EventArgs e)
        {
            FlowFactors[2] = FlowFactor(textBox_MFC1GasName.Text, int.Parse(textBox_MFC1Percentage.Text));
            Set_MFCFlows[2] = (int)((double)numericUpDown_MFC1FlowRate.Value * FlowFactors[2]);
        }

        private void Click_SetMFC2(object sender, EventArgs e)
        {
            FlowFactors[3] = FlowFactor(textBox_MFC2GasName.Text, int.Parse(textBox_MFC2Percentage.Text));
            Set_MFCFlows[3] = (int)((double)numericUpDown_MFC2FlowRate.Value * FlowFactors[3]);
        }

        private void Click_SetMFC3(object sender, EventArgs e)
        {
            FlowFactors[4] = FlowFactor(textBox_MFC3GasName.Text, int.Parse(textBox_MFC3Percentage.Text));
            Set_MFCFlows[4] = (int)((double)numericUpDown_MFC3FlowRate.Value * FlowFactors[4]);
        }

        private void Click_SetMFC4(object sender, EventArgs e)
        {
            FlowFactors[5] = FlowFactor(textBox_MFC4GasName.Text, int.Parse(textBox_MFC4Percentage.Text));
            Set_MFCFlows[5] = (int)((double)numericUpDown_MFC4FlowRate.Value * FlowFactors[5]);
        }

        private void Click_SetMFC5(object sender, EventArgs e)
        {
            FlowFactors[6] = FlowFactor(textBox_MFC5GasName.Text, int.Parse(textBox_MFC5Percentage.Text));
            Set_MFCFlows[6] = (int)((double)numericUpDown_MFC5FlowRate.Value * FlowFactors[6]);
        }

        private void Click_SetAll(object sender, EventArgs e)
        {
            double MFC1_FlowFactor = FlowFactor(textBox_MFC1GasName.Text, int.Parse(textBox_MFC1Percentage.Text));
            Set_MFCFlows[2] = (int)((double)numericUpDown_MFC1FlowRate.Value * MFC1_FlowFactor);

            double MFC2_FlowFactor = FlowFactor(textBox_MFC2GasName.Text, int.Parse(textBox_MFC2Percentage.Text));
            Set_MFCFlows[3] = (int)((double)numericUpDown_MFC2FlowRate.Value * MFC2_FlowFactor);

            double MFC3_FlowFactor = FlowFactor(textBox_MFC3GasName.Text, int.Parse(textBox_MFC3Percentage.Text));
            Set_MFCFlows[4] = (int)((double)numericUpDown_MFC3FlowRate.Value * MFC3_FlowFactor);

            double MFC4_FlowFactor = FlowFactor(textBox_MFC4GasName.Text, int.Parse(textBox_MFC4Percentage.Text));
            Set_MFCFlows[5] = (int)((double)numericUpDown_MFC4FlowRate.Value * MFC4_FlowFactor);

            double MFC5_FlowFactor = FlowFactor(textBox_MFC5GasName.Text, int.Parse(textBox_MFC5Percentage.Text));
            Set_MFCFlows[6] = (int)((double)numericUpDown_MFC5FlowRate.Value * MFC5_FlowFactor);
        }

        private void Click_TempSet(object sender, EventArgs e)
        {
            Set_Temp = (int)numericUpDown_TempTarget.Value;
            Set_Ramp = (int)numericUpDown_TempRamp.Value;

            SetTempFlag = true;
        }

        private void Click_TempCool25(object sender, EventArgs e)
        {
            Set_Temp = 25;
            Set_Ramp = 0;
            numericUpDown_TempTarget.Value = 25;
            numericUpDown_TempRamp.Value = 0;
        }

        private void Click_GoTo105(object sender, EventArgs e)
        {
            Set_Temp = 105;
            Set_Ramp = 0;
            numericUpDown_TempTarget.Value = 105;
            numericUpDown_TempRamp.Value = 0;
        }

        private void Click_Start(object sender, EventArgs e)
        {
            //Communication Settings
            string COMPort = textBox_COMPort.Text;
            int BaudRate = int.Parse(textBox_BaudRate.Text);
            int Parity = 2;
            if (textBox_Parity.Text == "None")
                Parity = 0;
            else if (textBox_Parity.Text == "Odd")
                Parity = 1;
            else
                Parity = 2;
            /*
            //Communication Settings
            string COMPort = textBox_COMPort.Text;
            int BaudRate = int.Parse(textBox_BaudRate.Text);
            int Parity = 2;
            if (textBox_Parity.Text == "None")
                Parity = 0;
            else if (textBox_Parity.Text == "Odd")
                Parity = 1;
            else
                Parity = 2;
            COM = CommunicationSettings(COMPort, DefaultSlaveNum, BaudRate, Parity);
            COM.Connect();
            */
            /*
             */
            this.serialPort = new SerialPort(COMPort)
            {
                BaudRate = BaudRate,
                DataBits = 8,
                Parity = System.IO.Ports.Parity.None,
                StopBits = StopBits.One,
                ReadTimeout = readTimeout,
                WriteTimeout = writeTimeout
            };

            SerialPortAdapter adapter = new SerialPortAdapter(serialPort);
            IModbusFactory factory = new ModbusFactory();
            this.master = factory.CreateRtuMaster(adapter); 
            this.serialPort.Open();


            //State Checks

            if (groupBox_MFC1.Enabled == false)
                MFCFlags[2] = false;
            else
                MFCFlags[2] = true;

            if (groupBox_MFC2.Enabled == false)
                MFCFlags[3] = false;
            else
                MFCFlags[3] = true;

            if (groupBox_MFC3.Enabled == false)
                MFCFlags[4] = false;
            else
                MFCFlags[4] = true;

            if (groupBox_MFC4.Enabled == false)
                MFCFlags[5] = false;
            else
                MFCFlags[5] = true;

            if (groupBox_MFC5.Enabled == false)
                MFCFlags[6] = false;
            else
                MFCFlags[6] = true;

            //Timer Starts
            timer_Write.Start();
            timer_Read.Start();

            //Button States
            button_Start.Enabled = false;
            button_Stop.Enabled = true;
            button_BrowseAndLoadFile.Enabled = false;
            button_SkipNextStep.Enabled = false;
            button_AutomationStart.Enabled = false;
            button_AutomationStop.Enabled = false;
        }

        private void click_Stop(object sender, EventArgs e)
        {
            //Timer Stops
            timer_Write.Stop();
            timer_Read.Stop();

            /*
            //Return Initial States
            COM.UnitIdentifier = TemperatureResSlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteTemp, 0);
            COM.UnitIdentifier = MFC1SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC2SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC3SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC4SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            RealTimer = 0;

            textBox_OpTime.Text = "00 : 00 : 00";

            //Communication Stop
            COM.Disconnect();
            */

            this.master.WriteSingleRegister(TemperatureResSlaveNum, HoldingRegWriteTemp, 0);
            this.master.WriteSingleRegister(MFC1SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC2SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC3SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC4SlaveNum, HoldingRegWriteFlow, 0);
            RealTimer = 0;
            textBox_OpTime.Text = "00 : 00 : 00";
            this.serialPort.Close();


            //Button States
            button_Start.Enabled = true;
            button_Stop.Enabled = false;
            button_BrowseAndLoadFile.Enabled = true;
            button_SkipNextStep.Enabled = true;
            button_AutomationStart.Enabled = true;
            button_AutomationStop.Enabled = true;
        }

        private void CheckStateChanged_Ramp(object sender, EventArgs e)
        {
            numericUpDown_TempRamp.Value = 0;
            Set_Ramp = 0;
            if (Ramp_Enable == true)
            {
                label_TempRamp.Enabled = false;
                numericUpDown_TempRamp.Enabled = false;
                Ramp_Enable = false;
            }
            else
            {
                label_TempRamp.Enabled = true;
                numericUpDown_TempRamp.Enabled = true;
                Ramp_Enable = true;
            }
        }


        private void CheckStateChanged_MFC1Time(object sender, EventArgs e)
        {
            if (MFCTimers[2] == true)
            {
                textBox_MFC1Time.Enabled = false;
                MFCTimers[2] = false;
            }
            else
            {
                textBox_MFC1Time.Enabled = true;
                MFCTimers[2] = true;
            }
        }

        private void CheckStateChanged_MFC2Time(object sender, EventArgs e)
        {
            if (MFCTimers[3] == true)
            {
                textBox_MFC2Time.Enabled = false;
                MFCTimers[3] = false;
            }
            else
            {
                textBox_MFC2Time.Enabled = true;
                MFCTimers[3] = true;
            }
        }

        private void CheckStateChanged_MFC3Time(object sender, EventArgs e)
        {
            if (MFCTimers[4] == true)
            {
                textBox_MFC3Time.Enabled = false;
                MFCTimers[4] = false;
            }
            else
            {
                textBox_MFC3Time.Enabled = true;
                MFCTimers[4] = true;
            }
        }

        private void CheckStateChanged_MFC4Time(object sender, EventArgs e)
        {
            if (MFCTimers[5] == true)
            {
                textBox_MFC4Time.Enabled = false;
                MFCTimers[5] = false;
            }
            else
            {
                textBox_MFC4Time.Enabled = true;
                MFCTimers[5] = true;
            }
        }

        private void CheckStateChanged_MFC5Time(object sender, EventArgs e)
        {
            if (MFCTimers[6] == true)
            {
                textBox_MFC5Time.Enabled = false;
                MFCTimers[6] = false;
            }
            else
            {
                textBox_MFC5Time.Enabled = true;
                MFCTimers[6] = true;
            }
        }


        DataSet ds;
        private void Click_BrowseandLoadFile(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);

                    ds = reader.AsDataSet();
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }



        private void Click_AutoStart(object sender, EventArgs e)
        {
            automationMode = true;

            //Communication Settings
            string COMPort = textBox_COMPort.Text;
            int BaudRate = int.Parse(textBox_BaudRate.Text);
            int Parity = 2;
            if (textBox_Parity.Text == "None")
                Parity = 0;
            else if (textBox_Parity.Text == "Odd")
                Parity = 1;
            else
                Parity = 2;
            /*
            COM = CommunicationSettings(COMPort, DefaultSlaveNum, BaudRate, Parity);
            COM.Connect();
            */

            this.serialPort = new SerialPort(COMPort)
            {
                BaudRate = BaudRate,
                DataBits = 8,
                Parity = System.IO.Ports.Parity.None,
                StopBits = StopBits.One,
                ReadTimeout = readTimeout,
                WriteTimeout = writeTimeout
            };

            SerialPortAdapter adapter = new SerialPortAdapter(serialPort);
            IModbusFactory factory = new ModbusFactory();
            this.master = factory.CreateRtuMaster(adapter);
            this.serialPort.Open();

            GraphDelete();

            //Gas Speficiations
            textBox_AutoMFC1GasName.Text = dataGridView1.Rows[4].Cells[5].FormattedValue.ToString();
            textBox_AutoMFC2GasName.Text = dataGridView1.Rows[4].Cells[6].FormattedValue.ToString();
            textBox_AutoMFC3GasName.Text = dataGridView1.Rows[4].Cells[7].FormattedValue.ToString();
            textBox_AutoMFC4GasName.Text = dataGridView1.Rows[4].Cells[8].FormattedValue.ToString();
            textBox_AutoMFC5GasName.Text = dataGridView1.Rows[4].Cells[9].FormattedValue.ToString();

            textBox_AutoMFC1Percentage.Text = dataGridView1.Rows[2].Cells[5].FormattedValue.ToString();
            textBox_AutoMFC2Percentage.Text = dataGridView1.Rows[2].Cells[6].FormattedValue.ToString();
            textBox_AutoMFC3Percentage.Text = dataGridView1.Rows[2].Cells[7].FormattedValue.ToString();
            textBox_AutoMFC4Percentage.Text = dataGridView1.Rows[2].Cells[8].FormattedValue.ToString();
            textBox_AutoMFC5Percentage.Text = dataGridView1.Rows[2].Cells[9].FormattedValue.ToString();

            label_graphMFC1.Text = "MFC1 - " + dataGridView1.Rows[4].Cells[5].FormattedValue.ToString();
            label_graphMFC2.Text = "MFC2 - " + dataGridView1.Rows[4].Cells[6].FormattedValue.ToString();
            label_graphMFC3.Text = "MFC3 - " + dataGridView1.Rows[4].Cells[7].FormattedValue.ToString();
            label_graphMFC4.Text = "MFC4 - " + dataGridView1.Rows[4].Cells[8].FormattedValue.ToString();
            label_graphMFC5.Text = "MFC5 - " + dataGridView1.Rows[4].Cells[9].FormattedValue.ToString();

            SetTempFlag = true;

            //Timer Starts
            timer_Write.Start();
            timer_Read.Start();

            button_AutomationStop.Enabled = true;
            button_AutomationStart.Enabled = false;
        }

        private void Click_SkipNextStep(object sender, EventArgs e)
        {
            row++;
            autoRealTime = 0;
        }

        private void Click_AutoStop(object sender, EventArgs e)
        {
            //Timer Stops
            timer_Write.Stop();
            timer_Read.Stop();
            autoRealTime = 0;
            GraphTime = 0;

            /*
            //Return Initial States
            COM.UnitIdentifier = TemperatureResSlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteTemp, 0);
            COM.UnitIdentifier = MFC1SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC2SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC3SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC4SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            COM.UnitIdentifier = MFC5SlaveNum;
            COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
            RealTimer = 0;
            textBox_OpTime.Text = "00 : 00 : 00";
            row = 5;
            autoRealTime = 0;
            automationMode = false;

            //Communication Stop
            COM.Disconnect();
            */
            this.master.WriteSingleRegister(TemperatureResSlaveNum, HoldingRegWriteTemp, 0);
            this.master.WriteSingleRegister(MFC1SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC2SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC3SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC4SlaveNum, HoldingRegWriteFlow, 0);
            this.master.WriteSingleRegister(MFC5SlaveNum, HoldingRegWriteFlow, 0);
            RealTimer = 0;
            textBox_OpTime.Text = "00 : 00 : 00";
            row = 5;
            autoRealTime = 0;
            automationMode = false;

            this.serialPort.Close();

            button_AutomationStart.Enabled = true;
            button_AutomationStop.Enabled = false;
        }

        private void timer_Write_Tick(object sender, EventArgs e)
        {
            //Time Settings 
            int second = RealTimer % 60;
            int minute = (RealTimer / 60) % 3600;
            int hour = RealTimer / 3600;

            if(hour < 10 && minute < 10 && second < 10)
                textBox_OpTime.Text = "0" + hour.ToString() + " : 0" + minute.ToString() + " : 0" + second.ToString();
            else if (hour < 10 && minute < 10 && second > 9)
                textBox_OpTime.Text = "0" + hour.ToString() + " : 0" + minute.ToString() + " : " + second.ToString();
            else if (hour < 10 && minute > 9 && second < 10)
                textBox_OpTime.Text = "0" + hour.ToString() + " : " + minute.ToString() + " : 0" + second.ToString();
            else if (hour < 10 && minute > 9 && second > 9)
                textBox_OpTime.Text = "0" + hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();
            else if (hour > 9 && minute < 10 && second < 10)
                textBox_OpTime.Text = hour.ToString() + " : 0" + minute.ToString() + " : 0" + second.ToString();
            else if (hour > 9 && minute < 10 && second > 9)
                textBox_OpTime.Text = hour.ToString() + " : 0" + minute.ToString() + " : " + second.ToString();
            else if (hour > 9 && minute > 9 && second < 10)
                textBox_OpTime.Text = hour.ToString() + " : " + minute.ToString() + " : 0" + second.ToString();
            else if (hour > 9 && minute > 9 && second > 9)
                textBox_OpTime.Text = hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();

            if(automationMode == true)
            {

                autoTime = dataGridView1.Rows[row].Cells[1].FormattedValue.ToString();
                textBox_AutoTime.Text = (Int32.Parse(autoTime) - autoRealTime).ToString();
                AutoStepNum.Text = (row - 4).ToString();

                Set_Temp = Int32.Parse(dataGridView1.Rows[row].Cells[2].FormattedValue.ToString());
                Set_Ramp = Int32.Parse(dataGridView1.Rows[row].Cells[3].FormattedValue.ToString());

                mfcData[MFC1SlaveNum] = float.Parse(dataGridView1.Rows[row].Cells[5].FormattedValue.ToString());
                mfcData[MFC2SlaveNum] = float.Parse(dataGridView1.Rows[row].Cells[6].FormattedValue.ToString());
                mfcData[MFC3SlaveNum] = float.Parse(dataGridView1.Rows[row].Cells[7].FormattedValue.ToString());
                mfcData[MFC4SlaveNum] = float.Parse(dataGridView1.Rows[row].Cells[8].FormattedValue.ToString());
                mfcData[MFC5SlaveNum] = float.Parse(dataGridView1.Rows[row].Cells[9].FormattedValue.ToString());

                float mfc1Kfact = float.Parse(dataGridView1.Rows[3].Cells[5].FormattedValue.ToString());
                float mfc2Kfact = float.Parse(dataGridView1.Rows[3].Cells[6].FormattedValue.ToString());
                float mfc3Kfact = float.Parse(dataGridView1.Rows[3].Cells[7].FormattedValue.ToString());
                float mfc4Kfact = float.Parse(dataGridView1.Rows[3].Cells[8].FormattedValue.ToString());
                float mfc5Kfact = float.Parse(dataGridView1.Rows[3].Cells[9].FormattedValue.ToString());
                

                Set_MFCFlows[MFC1SlaveNum] = (int)(mfcData[MFC1SlaveNum] * mfc1Kfact);
                Set_MFCFlows[MFC2SlaveNum] = (int)(mfcData[MFC2SlaveNum] * mfc2Kfact);
                Set_MFCFlows[MFC3SlaveNum] = (int)(mfcData[MFC3SlaveNum] * mfc3Kfact);
                Set_MFCFlows[MFC4SlaveNum] = (int)(mfcData[MFC4SlaveNum] * mfc4Kfact);
                Set_MFCFlows[MFC5SlaveNum] = (int)(mfcData[MFC5SlaveNum] * mfc5Kfact);

                autoRealTime++;
                if (autoRealTime.ToString() == autoTime)
                {
                    autoRealTime = 0;
                    row++;
                    SetTempFlag = true;
                }

                if ((row + 1).ToString() == dataGridView1.RowCount.ToString())
                {
                    /*
                    COM.UnitIdentifier = 1;
                    COM.WriteSingleRegister(HoldingRegWriteTemp, 0);
                    COM.UnitIdentifier = 2;
                    COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
                    COM.UnitIdentifier = 3;
                    COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
                    COM.UnitIdentifier = 4;
                    COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
                    COM.UnitIdentifier = 5;
                    COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
                    COM.UnitIdentifier = 6;
                    COM.WriteSingleRegister(HoldingRegWriteFlow, 0);
                    COM.Disconnect();
                    row = 5;
                    autoRealTime = 0;
                    automationMode = false;
                    timer_Write.Stop();
                    timer_Read.Stop();
                    */
                    this.master.WriteSingleRegister(TemperatureResSlaveNum, HoldingRegWriteTemp, 0);    
                    this.master.WriteSingleRegister(MFC1SlaveNum, HoldingRegWriteFlow, 0);
                    this.master.WriteSingleRegister(MFC2SlaveNum, HoldingRegWriteFlow, 0);
                    this.master.WriteSingleRegister(MFC3SlaveNum, HoldingRegWriteFlow, 0);
                    this.master.WriteSingleRegister(MFC4SlaveNum, HoldingRegWriteFlow, 0);
                    this.master.WriteSingleRegister(MFC5SlaveNum, HoldingRegWriteFlow, 0);
                    this.serialPort.Close();
                    row = 5;
                    autoRealTime = 0;
                    automationMode = false;
                    timer_Write.Stop();
                    timer_Read.Stop();
                }
            }
            
            
            TemperatureWrite(COM);
            
            /*
            MFCWrite(MFC1SlaveNum);
            MFCWrite(MFC2SlaveNum);
            MFCWrite(MFC3SlaveNum);
            MFCWrite(MFC4SlaveNum);
            MFCWrite(MFC5SlaveNum);
            */

            //AnalogOutput(MFC1SlaveNum);
            //AnalogOutput(MFC2SlaveNum);
            AnalogOutput(MFC3SlaveNum);
            //AnalogOutput(MFC4SlaveNum);


            //Real Second Timer 
            RealTimer++;
        }

        private void timer_Read_Tick(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();

            if (automationMode == false)
            {
                //COM.UnitIdentifier = TemperatureResSlaveNum;
                //ResistanceTemp = (float)COM.ReadHoldingRegisters(HoldingRegReadTemp, 1)[0] / 10;
                ResistanceTemp = this.master.ReadHoldingRegisters(TemperatureResSlaveNum, HoldingRegReadTemp, 1)[0] / 10;   
                textBox_ResistanceTemp.Text = ResistanceTemp.ToString();
                /*
                COM.UnitIdentifier = TemperatureCellSlaveNum;
                CellTemp = (float)COM.ReadHoldingRegisters(HoldingRegReadTemp, 1)[0] / 10;
                textBox_CellTemp.Text = CellTemp.ToString();
                */

                /*
                Get_MFCFlows[MFC1SlaveNum] = MFCRead(MFC1SlaveNum);
                Get_MFCFlows[MFC2SlaveNum] = MFCRead(MFC2SlaveNum);
                Get_MFCFlows[MFC3SlaveNum] = MFCRead(MFC3SlaveNum);
                Get_MFCFlows[MFC4SlaveNum] = MFCRead(MFC4SlaveNum);
                Get_MFCFlows[MFC5SlaveNum] = MFCRead(MFC5SlaveNum);
                */

                Get_MFCFlows[MFC1SlaveNum] = AnalogInput(MFC1SlaveNum);
                Get_MFCFlows[MFC2SlaveNum] = AnalogInput(MFC2SlaveNum);
                Get_MFCFlows[MFC3SlaveNum] = AnalogInput(MFC3SlaveNum);
                Get_MFCFlows[MFC4SlaveNum] = AnalogInput(MFC4SlaveNum);

                textBox_MFC1ActualFlow.Text = Get_MFCFlows[MFC1SlaveNum].ToString();
                textBox_MFC2ActualFlow.Text = Get_MFCFlows[MFC2SlaveNum].ToString();
                textBox_MFC3ActualFlow.Text = Get_MFCFlows[MFC3SlaveNum].ToString();
                textBox_MFC4ActualFlow.Text = Get_MFCFlows[MFC4SlaveNum].ToString();
                textBox_MFC5ActualFlow.Text = Get_MFCFlows[MFC5SlaveNum].ToString();
            }
            else if (automationMode == true)
            {
               // COM.UnitIdentifier = TemperatureResSlaveNum;
               // ResistanceTemp = (float)COM.ReadHoldingRegisters(HoldingRegReadTemp, 1)[0] / 10;
               ResistanceTemp = this.master.ReadHoldingRegisters(TemperatureResSlaveNum, HoldingRegReadTemp, 1)[0] / 10;
               textBox_AutoResistanceTemp.Text = ResistanceTemp.ToString();
               // COM.UnitIdentifier = TemperatureCellSlaveNum;
               // CellTemp = (float)COM.ReadHoldingRegisters(HoldingRegReadTemp, 1)[0] / 10;
               CellTemp = this.master.ReadHoldingRegisters(TemperatureCellSlaveNum, HoldingRegReadTemp, 1)[0] / 10;
               textBox_AutoCellTemp.Text = CellTemp.ToString();

                float mfc1Kfact = float.Parse(dataGridView1.Rows[3].Cells[5].FormattedValue.ToString());
                float mfc2Kfact = float.Parse(dataGridView1.Rows[3].Cells[6].FormattedValue.ToString());
                float mfc3Kfact = float.Parse(dataGridView1.Rows[3].Cells[7].FormattedValue.ToString());
                float mfc4Kfact = float.Parse(dataGridView1.Rows[3].Cells[8].FormattedValue.ToString());
                float mfc5Kfact = float.Parse(dataGridView1.Rows[3].Cells[9].FormattedValue.ToString());

                Get_MFCFlows[MFC1SlaveNum] = MFCRead(MFC1SlaveNum, mfc1Kfact);
                Get_MFCFlows[MFC2SlaveNum] = MFCRead(MFC2SlaveNum, mfc2Kfact);
                Get_MFCFlows[MFC3SlaveNum] = MFCRead(MFC3SlaveNum, mfc3Kfact);
                Get_MFCFlows[MFC4SlaveNum] = MFCRead(MFC4SlaveNum, mfc4Kfact);
                Get_MFCFlows[MFC5SlaveNum] = MFCRead(MFC5SlaveNum, mfc5Kfact);


                textBox_AutoMFC1ActualFlow.Text = Get_MFCFlows[MFC1SlaveNum].ToString();
                textBox_AutoMFC2ActualFlow.Text = Get_MFCFlows[MFC2SlaveNum].ToString();
                textBox_AutoMFC3ActualFlow.Text = Get_MFCFlows[MFC3SlaveNum].ToString();
                textBox_AutoMFC4ActualFlow.Text = Get_MFCFlows[MFC4SlaveNum].ToString();
                textBox_AutoMFC5ActualFlow.Text = Get_MFCFlows[MFC5SlaveNum].ToString();
            }

            
            if (GraphTime % GraphFrequency == 0)
            {
                /*
                Thread TableThread = new Thread(() => TableFunction(dataGridView_All, MFC1SlaveNum));
                Thread Graph1Thread = new Thread(() => GraphFunction(chart_MFC1, MFC1SlaveNum));
                Thread Graph2Thread = new Thread(() => GraphFunction(chart_MFC2, MFC2SlaveNum));
                Thread Graph3Thread = new Thread(() => GraphFunction(chart_MFC3, MFC3SlaveNum));
                Thread Graph4Thread = new Thread(() => GraphFunction(chart_MFC4, MFC4SlaveNum));
                Thread Graph5Thread = new Thread(() => GraphFunction(chart_MFC5, MFC5SlaveNum));

                TableThread.Start();
                Graph1Thread.Start();
                Graph2Thread.Start();
                Graph3Thread.Start();
                Graph4Thread.Start();
                Graph5Thread.Start();
                */

                TableFunction(dataGridView_All, MFC1SlaveNum);
                //GraphFunction();

                /*
                GraphFunction(chart_MFC2, MFC2SlaveNum);
                GraphFunction(chart_MFC3, MFC3SlaveNum);
                GraphFunction(chart_MFC4, MFC4SlaveNum);
                GraphFunction(chart_MFC5, MFC5SlaveNum);
                */

                //chart_Temp.Series["Resistance"].Points.AddXY((GraphTime / 10), ResistanceTemp);
                //chart_Temp.Series["Set"].Points.AddXY((GraphTime / 10), Write_Temp);
                //chart_Temp.Series["Inside"].Points.AddXY((GraphTime / 10), CellTemp);
            }
            GraphTime += 1;
            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds);
            counter++;
            Console.WriteLine($"Couner {counter}");
        }



        public ModbusClient CommunicationSettings(string PortID, int SlaveNumID, int Baudrate, int Parity)
        {
            ModbusClient ComPort = new ModbusClient(PortID);
            ComPort.UnitIdentifier = (byte)SlaveNumID;
            ComPort.Baudrate = Baudrate;
            ComPort.Parity = System.IO.Ports.Parity.None;
            if (Parity == 0)
            {
                ComPort.Parity = System.IO.Ports.Parity.None;
            }
            else if (Parity == 1)
            {
                ComPort.Parity = System.IO.Ports.Parity.Odd;
            }
            else if (Parity == 2)
            {
                ComPort.Parity = System.IO.Ports.Parity.Even;
            }
            return ComPort;
        }

        public double FlowFactor(string GasName, int MFC_Percentage)
        {
            double MFC_Factor;

            double Percentage = (double)MFC_Percentage / 100;

            if (GasName == "Oxygen")
                MFC_Factor = kFact_O2inAr * Percentage + (1 - Percentage) * kFact_ArinAr;
            else if (GasName == "Hydrogen")
                MFC_Factor = kFact_H2inAr * Percentage + (1 - Percentage) * kFact_ArinAr;
            else if (GasName == "Carbon Monoxide")
                MFC_Factor = (kFact_COinAr * Percentage + (1 - Percentage) * kFact_ArinAr) * kFact_ArinNO;
            else if (GasName == "Carbon Dioxide")
                MFC_Factor = (kFact_CO2inAr * Percentage + (1 - Percentage) * kFact_ArinAr) * kFact_ArinCH4;
            else if (GasName == "Disable")
                MFC_Factor = 0;
            else 
                MFC_Factor = 1;

            return MFC_Factor;
        }

        public void TemperatureWrite(ModbusClient COM)
        {
            if (SetTempFlag == true)
            {
                //COM.UnitIdentifier = TemperatureResSlaveNum;
                //Write_Temp = COM.ReadHoldingRegisters(HoldingRegReadTemp, 1)[0] / 10;
                Write_Temp = this.master.ReadHoldingRegisters(TemperatureResSlaveNum, HoldingRegReadTemp, 1)[0] / 10;
                SetTempFlag = false;
            }

            if (Set_Ramp == 0 || Write_Temp >= Set_Temp)
                Write_Temp = Set_Temp;
            else if (RealTimer % Set_Ramp == 0 && Write_Temp < Set_Temp)
                Write_Temp += 1;

            //COM.UnitIdentifier = TemperatureResSlaveNum;
            //COM.WriteSingleRegister(HoldingRegWriteTemp, Write_Temp * 10);
            this.master.WriteSingleRegister(TemperatureResSlaveNum, HoldingRegWriteTemp, (ushort)(Write_Temp * 10));
        }

        public void MFCWrite(int MFCNum)
        {
            if (MFCFlags[MFCNum] == true || automationMode == true)
            {
                //COM.UnitIdentifier = (byte)MFCNum; 
               // COM.WriteSingleRegister(HoldingRegWriteFlow, (Set_MFCFlows[MFCNum] * MFCMultis[MFCNum]));
               this.master.WriteSingleRegister((byte)MFCNum, HoldingRegWriteFlow, (ushort)(Set_MFCFlows[MFCNum] * MFCMultis[MFCNum]));
            }
        }

        public double MFCRead(int MFCNum)
        {
            if (MFCFlags[MFCNum] == true || automationMode == true)
            {
                //COM.UnitIdentifier = (byte)MFCNum;
                //return (double) COM.ReadHoldingRegisters(HoldingRegReadFlow, 1)[0] / (MFCMultis[MFCNum] * FlowFactors[MFCNum]);
                return (double)this.master.ReadHoldingRegisters((byte)MFCNum, HoldingRegReadFlow, 1)[0] / (MFCMultis[MFCNum] * FlowFactors[MFCNum]);
            }
            return 0;
        }
        public double MFCRead(int MFCNum, float kFact)
        {
            if (automationMode == true)
            {
                //COM.UnitIdentifier = (byte)MFCNum;
                // return (double)COM.ReadHoldingRegisters(HoldingRegReadFlow, 1)[0] / (MFCMultis[MFCNum] * kFact);
                return this.master.ReadHoldingRegisters((byte)MFCNum, HoldingRegReadFlow, 1)[0] / (MFCMultis[MFCNum] * kFact);
            }
            return 0;
        }

        public double AnalogInput(int MFCNum)
        {
            
            if (MFCFlags[MFCNum] == true || automationMode == true)
            {
                //COM.UnitIdentifier = (byte)AnalogInputSlaveNum;
                //return (double)COM.ReadHoldingRegisters((MFCNum-1), 1)[0] / 100; // (MFCMultis[MFCNum] * FlowFactors[MFCNum]);
                return (double)this.master.ReadHoldingRegisters((byte)AnalogInputSlaveNum, (byte)(MFCNum - 1), 1)[0] / 100;
            }
            return 0;

        }

        public void AnalogOutput(int MFCNum)
        {
            if (MFCFlags[MFCNum] == true || automationMode == true)
            {
               // COM.UnitIdentifier = (byte)AnalogOutputSlaveNum;
                //COM.WriteSingleRegister(MFCNum-2, 758);// (Set_MFCFlows[MFCNum] * MFCMultis[MFCNum])
                this.master.WriteSingleRegister((byte)AnalogOutputSlaveNum, (byte)(MFCNum - 2), 758);
            }


        }

        public async void TableFunction(DataGridView GridName, int MFCSlaveNum)
        {
            Invoke((MethodInvoker)delegate
            {
                GridName.Rows.Add(
                    new object[] {
                    (double) GraphTime,
                    Get_MFCFlows[MFC1SlaveNum],
                    Get_MFCFlows[MFC2SlaveNum],
                    Get_MFCFlows[MFC3SlaveNum],
                    Get_MFCFlows[MFC4SlaveNum],
                    0, //foo_char atılacak ama bosluk ASCII 32 giriyo 
                    ResistanceTemp,
                    Set_Temp,
                    0,
                    (float)mfcData[MFC1SlaveNum],
                    (float)mfcData[MFC2SlaveNum],
                    (float)mfcData[MFC3SlaveNum],
                    (float)mfcData[MFC4SlaveNum]
                    }
                );
            });
        }

        private void click_GraphFqSetButton(object sender, EventArgs e)
        {
            GraphFrequency = (double)numericUpDown_MFC1fq.Value;
        }

        public async void GraphFunction()
        { 
            chart_MFC1.Series["Actual"].Points.AddXY((GraphTime / 10), Get_MFCFlows[MFC1SlaveNum]);
            if (automationMode == true)
                chart_MFC1.Series["Set"].Points.AddXY((GraphTime / 10), (float)mfcData[MFC1SlaveNum]);
            else
                chart_MFC1.Series["Set"].Points.AddXY((GraphTime / 10), (float)Set_MFCFlows[MFC1SlaveNum]);

            chart_MFC2.Series["Actual"].Points.AddXY((GraphTime / 10), Get_MFCFlows[MFC2SlaveNum]);
            if (automationMode == true)
                chart_MFC2.Series["Set"].Points.AddXY((GraphTime / 10), (float)mfcData[MFC2SlaveNum]);
            else
                chart_MFC2.Series["Set"].Points.AddXY((GraphTime / 10), (float)Set_MFCFlows[MFC2SlaveNum]);

            chart_MFC3.Series["Actual"].Points.AddXY((GraphTime / 10), Get_MFCFlows[MFC3SlaveNum]);
            if (automationMode == true)
                chart_MFC3.Series["Set"].Points.AddXY((GraphTime / 10), (float)mfcData[MFC3SlaveNum]);
            else
                chart_MFC3.Series["Set"].Points.AddXY((GraphTime / 10), (float)Set_MFCFlows[MFC3SlaveNum]);

            chart_MFC4.Series["Actual"].Points.AddXY((GraphTime / 10), Get_MFCFlows[MFC4SlaveNum]);
            if (automationMode == true)
                chart_MFC4.Series["Set"].Points.AddXY((GraphTime / 10), (float)mfcData[MFC4SlaveNum]);
            else
                chart_MFC4.Series["Set"].Points.AddXY((GraphTime / 10), (float)Set_MFCFlows[MFC4SlaveNum]);

            chart_MFC5.Series["Actual"].Points.AddXY((GraphTime / 10), Get_MFCFlows[MFC5SlaveNum]);
            if (automationMode == true)
                chart_MFC5.Series["Set"].Points.AddXY((GraphTime / 10), (float)mfcData[MFC5SlaveNum]);
            else
                chart_MFC5.Series["Set"].Points.AddXY((GraphTime / 10), (float)Set_MFCFlows[MFC5SlaveNum]);
        }

        public void GraphDelete()
        {
            foreach (var series in chart_MFC1.Series)
            {
                series.Points.Clear();
            }
        }

        private void click_ExportMFC1(object sender, EventArgs e)
        {
            bool exported = false;
            List<string> lines = new List<string>();

            DataGridViewColumnCollection header = dataGridView_All.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();
            
            foreach(DataGridViewColumn col in header)
            {
                if(!firstDone)
                {
                    headerLine.Append(col.HeaderText);
                    firstDone = true;
                }
                else
                    headerLine.Append("." + col.HeaderText);
            }

            lines.Add(headerLine.ToString());

            foreach(DataGridViewRow row in dataGridView_All.Rows)
            {
                StringBuilder dataLine = new StringBuilder();
                firstDone = false;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else if(cell.Value != null)
                        dataLine.Append("." + cell.Value);
                }
                lines.Add(dataLine.ToString());
            }
            string file = @"E:\\somecsvfile.csv";
            System.IO.File.WriteAllLines(file, lines);
            System.Diagnostics.Process.Start(file);
            
            /*
            excel.Application ExcelFile = new excel.Application();
            Workbook WorkBook = ExcelFile.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet Page = (Worksheet)WorkBook.Sheets[1];
            for (int i = 0; i < dataGridView_All.Columns.Count; i++)
            {
                Range alan = (Range)Page.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView_All.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView_All.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView_All.Rows.Count; j++)
                {
                    Range alan = (Range)Page.Cells[j + 1, i + 1];
                    alan.Cells[2, 1] = dataGridView_All[i, j].Value;
                }
            }

            ExcelFile.Visible = true;
            */
        }

        private void textBox_MFC2Percentage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
