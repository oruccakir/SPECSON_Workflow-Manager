using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SPECSON_WorkFlow_Manager
{
    public partial class csvExportPage : Form
    {
        public csvExportPage()
        {
            InitializeComponent();
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox_path.Text = Path.GetFullPath(openFileDialog1.FileName);
            else
                MessageBox.Show("Please Select File You Want Copy");
        }
    }
}
