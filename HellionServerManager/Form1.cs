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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        #region File Menu
        private void ToolBar_File_Update_Click(object sender, EventArgs e)
        {

        }

        private void ToolBar_Options_HSMConfig_Click(object sender, EventArgs e)
        {

        }

        private void ToolBar_File_Exit_Click(object sender, EventArgs e)
        {

        }

        private void ToolBar_Help_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Im the about messagebox!", "Fill me in!", MessageBoxButtons.OK );
        }
        #endregion


        #region Server Config

        private void Config_Button_Reload_Click(object sender, EventArgs e)
        {

        }

        private void Config_Button_Save_Click(object sender, EventArgs e)
        {

        }

        private void Config_Button_Cancel_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
