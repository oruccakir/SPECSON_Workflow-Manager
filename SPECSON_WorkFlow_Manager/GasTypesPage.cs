using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPECSON_WorkFlow_Manager
{
    public partial class GasTypesPage : Form
    {
        static public GasTypesPage instance;

        //MFC Status are default disable
        bool MFC1CheckedBit = false;
        bool MFC2CheckedBit = false;
        bool MFC3CheckedBit = false;
        bool MFC4CheckedBit = false;
        bool MFC5CheckedBit = false;

        //MFC Gas Names are default disable
        string MFC1GasName = "Disable";
        string MFC2GasName = "Disable";
        string MFC3GasName = "Disable";
        string MFC4GasName = "Disable";
        string MFC5GasName = "Disable";

        //MFC Gas Percentages are default 1
        decimal MFC1Percentage = 1;
        decimal MFC2Percentage = 1;
        decimal MFC3Percentage = 1;
        decimal MFC4Percentage = 1;
        decimal MFC5Percentage = 1;


        bool DefaultGasParamBit = false;

        public GasTypesPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void GasTypesPage_Load(object sender, EventArgs e)
        {
            //info is default disable
            label_info.Visible = false;

            //MFC Status are default disable
            groupBox_MFC1.Enabled = false;
            groupBox_MFC2.Enabled = false;
            groupBox_MFC3.Enabled = false;
            groupBox_MFC4.Enabled = false;
            groupBox_MFC5.Enabled = false;

            //checkBox_CellTemp.Checked = true;
            checkBox_ResistanceTemp.Checked = true;
        }

        //when mouse enter to the info box
        private void MouseEnter_info(object sender, EventArgs e)
        {
            label_info.Visible = true;
        }

        //when mouse leave to the info box
        private void MouseLeave_info(object sender, EventArgs e)
        {
            label_info.Visible = false;
        }

        //MFC Gas Parameters Changed
        private void SelectedIndexChanged_MFC1GasName(object sender, EventArgs e)
        {
            MFC1GasName = comboBox_MFC1GasType.SelectedItem.ToString();

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void SelectedIndexChanged_MFC2GasName(object sender, EventArgs e)
        {
            MFC2GasName = comboBox_MFC2GasType.SelectedItem.ToString();

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void SelectedIndexChanged_MFC3GasName(object sender, EventArgs e)
        {
            MFC3GasName = comboBox_MFC3GasType.SelectedItem.ToString();

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void SelectedIndexChanged_MFC4GasName(object sender, EventArgs e)
        {
            MFC4GasName = comboBox_MFC4GasType.SelectedItem.ToString();

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void SelectedIndexChanged_MFC5GasName(object sender, EventArgs e)
        {
            MFC5GasName = comboBox_MFC5GasType.SelectedItem.ToString();

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void ValueChanged_MFC1Percentage(object sender, EventArgs e)
        {
            MFC1Percentage = numericUpDown_MFC1Percentage.Value;
        }

        private void ValueChanged_MFC2Percentage(object sender, EventArgs e)
        {
            MFC2Percentage = numericUpDown_MFC2Percentage.Value;
        }

        private void ValueChanged_MFC3Percentage(object sender, EventArgs e)
        {
            MFC3Percentage = numericUpDown_MFC3Percentage.Value;
        }

        private void ValueChanged_MFC4Percentage(object sender, EventArgs e)
        {
            MFC4Percentage = numericUpDown_MFC4Percentage.Value;
        }

        private void ValueChanged_MFC5Percentage(object sender, EventArgs e)
        {
            MFC5Percentage = numericUpDown_MFC5Percentage.Value;
        }

        //when Check Box status changed
        private void CheckedChanged_MFC1(object sender, EventArgs e)
        {
            if (MFC1CheckedBit == false)
            {
                groupBox_MFC1.Enabled = true;
                MFC1CheckedBit = true;
                comboBox_MFC1GasType.Text = "Please Select Gas Type";
                MFC1GasName = "Please Select Gas Type";
            }
            else
            {
                groupBox_MFC1.Enabled = false;
                MFC1CheckedBit = false;
                comboBox_MFC1GasType.Text = "Disable";
                MFC1GasName = "Disable";
            }

            if(DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void CheckedChanged_MFC2(object sender, EventArgs e)
        {
            if (MFC2CheckedBit == false)
            {
                groupBox_MFC2.Enabled = true;
                MFC2CheckedBit = true;
                comboBox_MFC2GasType.Text = "Please Select Gas Type";
                MFC2GasName = "Please Select Gas Type";
            }
            else
            {
                groupBox_MFC2.Enabled = false;
                MFC2CheckedBit = false;
                comboBox_MFC2GasType.Text = "Disable";
                MFC2GasName = "Disable";
            }

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void CheckedChanged_MFC3(object sender, EventArgs e)
        {
            if (MFC3CheckedBit == false)
            {
                groupBox_MFC3.Enabled = true;
                MFC3CheckedBit = true;
                comboBox_MFC3GasType.Text = "Please Select Gas Type";
                MFC3GasName = "Please Select Gas Type";
            }
            else
            {
                groupBox_MFC3.Enabled = false;
                MFC3CheckedBit = false;
                comboBox_MFC3GasType.Text = "Disable";
                MFC3GasName = "Disable";
            }

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void CheckedChanged_MFC4(object sender, EventArgs e)
        {
            if (MFC4CheckedBit == false)
            {
                groupBox_MFC4.Enabled = true;
                MFC4CheckedBit = true;
                comboBox_MFC4GasType.Text = "Please Select Gas Type";
                MFC4GasName = "Please Select Gas Type";
            }
            else
            {
                groupBox_MFC4.Enabled = false;
                MFC4CheckedBit = false;
                comboBox_MFC4GasType.Text = "Disable";
                MFC4GasName = "Disable";
            }

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void CheckedChanged_MFC5(object sender, EventArgs e)
        {
            if (MFC5CheckedBit == false)
            {
                groupBox_MFC5.Enabled = true;
                MFC5CheckedBit = true;
                comboBox_MFC5GasType.Text = "Please Select Gas Type";
                MFC5GasName = "Please Select Gas Type";
            }
            else
            {
                groupBox_MFC5.Enabled = false;
                MFC5CheckedBit = false;
                comboBox_MFC5GasType.Text = "Disable";
                MFC5GasName = "Disable";
            }

            if (DefaultGasParamBit == true)
            {
                DefaultGasParamBit = false;
                button_UseDefParam.Enabled = true;
            }
        }

        private void Click_UseDefaultParameters(object sender, EventArgs e)
        {
            if (checkBox_MFC1.Checked == false)
                checkBox_MFC1.Checked = true;
            comboBox_MFC1GasType.Text = "Argon";
            MFC1GasName = "Argon";
            numericUpDown_MFC1Percentage.Value = 100;


            if (checkBox_MFC2.Checked == false)
                checkBox_MFC2.Checked = true;
            comboBox_MFC2GasType.Text = "Oxygen";
            MFC2GasName = "Oxygen";
            numericUpDown_MFC2Percentage.Value = 8;


            if (checkBox_MFC3.Checked == false)
                checkBox_MFC3.Checked = true;
            comboBox_MFC3GasType.Text = "Hydrogen";
            MFC3GasName = "Hydrogen";
            numericUpDown_MFC3Percentage.Value = 5;


            if (checkBox_MFC4.Checked == false)
                checkBox_MFC4.Checked = true;
            comboBox_MFC4GasType.Text = "Carbon Monoxide";
            MFC4GasName = "Carbon Monoxide";
            numericUpDown_MFC4Percentage.Value = 8;

            /*
            if (checkBox_MFC5.Checked == false)
                checkBox_MFC5.Checked = true;
            comboBox_MFC5GasType.Text = "Carbon Dioxide";
            MFC5GasName = "Carbon Dioxide";
            numericUpDown_MFC5Percentage.Value = 2;
            */


            DefaultGasParamBit = true;
            button_UseDefParam.Enabled = false;
        }

        private void Click_Save(object sender, EventArgs e)
        {
            //if any gasses did not select, fix that gas as a default
            if (MFC1GasName == "Please Select Gas Type")
                MFC1GasName = "Disable";
            if (MFC2GasName == "Please Select Gas Type")
                MFC2GasName = "Disable";
            if (MFC3GasName == "Please Select Gas Type")
                MFC3GasName = "Disable";
            if (MFC4GasName == "Please Select Gas Type")
                MFC4GasName = "Disable";
            if (MFC5GasName == "Please Select Gas Type")
                MFC5GasName = "Disable";

            //send gases to the main page
            MainPage.instance.GasTypesPage_MFC1GasName.Text = MFC1GasName;
            MainPage.instance.GasTypesPage_MFC2GasName.Text = MFC2GasName;
            MainPage.instance.GasTypesPage_MFC3GasName.Text = MFC3GasName;
            MainPage.instance.GasTypesPage_MFC4GasName.Text = MFC4GasName;
            MainPage.instance.GasTypesPage_MFC5GasName.Text = MFC5GasName;

            MainPage.instance.GasTypesPage_MFC1GasParameter.Text = MFC1Percentage.ToString();
            MainPage.instance.GasTypesPage_MFC2GasParameter.Text = MFC2Percentage.ToString();
            MainPage.instance.GasTypesPage_MFC3GasParameter.Text = MFC3Percentage.ToString();
            MainPage.instance.GasTypesPage_MFC4GasParameter.Text = MFC4Percentage.ToString();
            MainPage.instance.GasTypesPage_MFC5GasParameter.Text = MFC5Percentage.ToString();

            if (checkBox_CellTemp.Checked == false)
            {
                MainPage.instance.GasTypesPage_CellTemperature.Text = "Disabled";
                MainPage.instance.GasTypesPage_CellTemperature.Enabled = false;
                MainPage.instance.GasTypesPage_CellTemperatureLabel.Enabled = false;
            }
            else
            {
                MainPage.instance.GasTypesPage_CellTemperature.Text = "";
                MainPage.instance.GasTypesPage_CellTemperature.Enabled = true;
                MainPage.instance.GasTypesPage_CellTemperatureLabel.Enabled = true;

            }

            if (checkBox_ResistanceTemp.Checked == false)
            {
                MainPage.instance.GasTypesPage_ResistanceTemperature.Text = "Disabled";
                MainPage.instance.GasTypesPage_ResistanceTemperature.Enabled = false;
                MainPage.instance.GasTypesPage_ResistanceTemperatureLabel.Enabled = false;
            }
            else
            {
                MainPage.instance.GasTypesPage_ResistanceTemperature.Text = "";
                MainPage.instance.GasTypesPage_ResistanceTemperature.Enabled = true;
                MainPage.instance.GasTypesPage_ResistanceTemperatureLabel.Enabled = true;
            }

            if ((checkBox_CellTemp.Checked == false) && (checkBox_ResistanceTemp.Checked == false))
                MainPage.instance.GasTypesPage_Temperature.Enabled = false;
            else
                MainPage.instance.GasTypesPage_Temperature.Enabled = true;

            this.Hide();
        }

        private void Click_Close(object sender, EventArgs e)
        {
            this.Hide();
        }

    }

}
