using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using HellionServerManager.Controls;

namespace HellionServerManager
{
    public partial class Form1 : Form
    {
        private GameServerIni m_gameServerIni;
        private Form m_config;

        public Form1()
        {
            InitializeComponent();

            m_config = new Config();
            m_config.Visible = false;

            m_gameServerIni = new GameServerIni();
            m_gameServerIni.LoadDefaults();
            m_gameServerIni.ServerPath = Properties.Settings.Default.HellionDedicatedPath;

            ServerConfig_PropertyGrid.ToolbarVisible = false;
            ServerConfig_PropertyGrid.SelectedObject = m_gameServerIni;

            if (Properties.Settings.Default.FirstRun && Properties.Settings.Default.HellionDedicatedPath == String.Empty)
            {
                m_config.ShowDialog();
                             
                Properties.Settings.Default.FirstRun = false;
                //Properties.Settings.Default.Save();
            }



            
            

        }


        #region File Menu
        private void ToolBar_File_Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet!","Not Implemented", MessageBoxButtons.OK);
        }

        private void ToolBar_Options_HSMConfig_Click(object sender, EventArgs e)
        {
            m_config.ShowDialog();
        }

        private void ToolBar_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolBar_Help_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" I'm the about message box!", "Fill me in!", MessageBoxButtons.OK );
        }
        #endregion


        #region Server Config

        private void GenerateProperties()
        {
            ServerConfig_PropertyGrid.Container.Add(new Component() { });
        }


        private void Config_Button_Reload_Click(object sender, EventArgs e)
        {
            m_gameServerIni.Load();
        }

        private void Config_Button_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet!", "Not Implemented", MessageBoxButtons.OK);
        }

        private void Config_Button_Cancel_Click(object sender, EventArgs e)
        {
            m_gameServerIni.Load();
            ServerConfig_PropertyGrid.Refresh();
        }


        #endregion

        private void ServerConfig_LoadDefaults_Click(object sender, EventArgs e)
        {
            m_gameServerIni.LoadDefaults();
            ServerConfig_PropertyGrid.Refresh();
        }
    }
}
