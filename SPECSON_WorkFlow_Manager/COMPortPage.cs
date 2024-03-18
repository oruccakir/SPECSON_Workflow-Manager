using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPECSON_WorkFlow_Manager
{
    public partial class COMPortPage : Form
    {
        public static COMPortPage instance;
        string COMPort;
        string BaudRate = "9600";
        string Parity = "None";
        string DataBits = "8";
        string StopBit = "1";

        public COMPortPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void COMPortPage_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_COMPorts.Items.AddRange(ports);
        }

        private void SelectedIndexChanged_COMPort(object sender, EventArgs e)
        {
            COMPort = comboBox_COMPorts.SelectedItem.ToString();
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaudRate = comboBox_BaudRate.SelectedItem.ToString();
        }

        private void comboBox_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parity = comboBox_Parity.SelectedItem.ToString();
        }

        private void comboBox_DataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBits = comboBox_DataBits.SelectedItem.ToString();
        }

        private void comboBox_StopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopBit = comboBox_StopBit.SelectedItem.ToString();
        }

        private void Click_Save(object sender, EventArgs e)
        {
            //COM Port Elements sended to the main page by these commands
            MainPage.instance.COMPortPage_COMPort.Text = COMPort;
            MainPage.instance.COMPortPage_BaudRate.Text = BaudRate;
            MainPage.instance.COMPortPage_Parity.Text = Parity;
            MainPage.instance.COMPortPage_DataBits.Text = DataBits;
            MainPage.instance.COMPortPage_StopBit.Text = StopBit;
            this.Hide();
        }

        private void Click_Close(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
