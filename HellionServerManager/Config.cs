using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellionServerManager
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();

            textBox1.Text = Properties.Settings.Default.HellionDedicatedPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Properties.Settings.Default.HellionDedicatedPath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Properties.Settings.Default.HellionDedicatedPath))
            {
                MessageBox.Show("The selected Path is not valid!", "Invalid Path", MessageBoxButtons.OK);
                button1_Click(this, null);

            }
            else
            {
                Properties.Settings.Default.Save();
                this.Visible = false;              
            }
            

            
        }
    }
}
