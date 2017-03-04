namespace HellionServerManager
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar_File_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar_Options_HSMConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Config_Button_Cancel = new System.Windows.Forms.Button();
            this.Config_Button_Reload = new System.Windows.Forms.Button();
            this.Config_Button_Save = new System.Windows.Forms.Button();
            this.ServerConfig_PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.ServerConfig_SetDefaults = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBar_File_Update,
            this.ToolBar_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ToolBar_File_Update
            // 
            this.ToolBar_File_Update.Name = "ToolBar_File_Update";
            this.ToolBar_File_Update.Size = new System.Drawing.Size(121, 22);
            this.ToolBar_File_Update.Text = "Update...";
            this.ToolBar_File_Update.Click += new System.EventHandler(this.ToolBar_File_Update_Click);
            // 
            // ToolBar_File_Exit
            // 
            this.ToolBar_File_Exit.Name = "ToolBar_File_Exit";
            this.ToolBar_File_Exit.Size = new System.Drawing.Size(121, 22);
            this.ToolBar_File_Exit.Text = "Exit";
            this.ToolBar_File_Exit.Click += new System.EventHandler(this.ToolBar_File_Exit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBar_Options_HSMConfig});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ToolBar_Options_HSMConfig
            // 
            this.ToolBar_Options_HSMConfig.Name = "ToolBar_Options_HSMConfig";
            this.ToolBar_Options_HSMConfig.Size = new System.Drawing.Size(139, 22);
            this.ToolBar_Options_HSMConfig.Text = "HSM Config";
            this.ToolBar_Options_HSMConfig.Click += new System.EventHandler(this.ToolBar_Options_HSMConfig_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBar_Help_About});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // ToolBar_Help_About
            // 
            this.ToolBar_Help_About.Name = "ToolBar_Help_About";
            this.ToolBar_Help_About.Size = new System.Drawing.Size(107, 22);
            this.ToolBar_Help_About.Text = "About";
            this.ToolBar_Help_About.Click += new System.EventHandler(this.ToolBar_Help_About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 455);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ServerConfig_SetDefaults);
            this.splitContainer1.Panel1.Controls.Add(this.Config_Button_Cancel);
            this.splitContainer1.Panel1.Controls.Add(this.Config_Button_Reload);
            this.splitContainer1.Panel1.Controls.Add(this.Config_Button_Save);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ServerConfig_PropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(727, 423);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // Config_Button_Cancel
            // 
            this.Config_Button_Cancel.Location = new System.Drawing.Point(566, 11);
            this.Config_Button_Cancel.Name = "Config_Button_Cancel";
            this.Config_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Config_Button_Cancel.TabIndex = 2;
            this.Config_Button_Cancel.Text = "Cancel";
            this.Config_Button_Cancel.UseVisualStyleBackColor = true;
            this.Config_Button_Cancel.Click += new System.EventHandler(this.Config_Button_Cancel_Click);
            // 
            // Config_Button_Reload
            // 
            this.Config_Button_Reload.Location = new System.Drawing.Point(5, 11);
            this.Config_Button_Reload.Name = "Config_Button_Reload";
            this.Config_Button_Reload.Size = new System.Drawing.Size(75, 23);
            this.Config_Button_Reload.TabIndex = 1;
            this.Config_Button_Reload.Text = "Reload";
            this.Config_Button_Reload.UseVisualStyleBackColor = true;
            this.Config_Button_Reload.Click += new System.EventHandler(this.Config_Button_Reload_Click);
            // 
            // Config_Button_Save
            // 
            this.Config_Button_Save.Location = new System.Drawing.Point(647, 11);
            this.Config_Button_Save.Name = "Config_Button_Save";
            this.Config_Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Config_Button_Save.TabIndex = 0;
            this.Config_Button_Save.Text = "Save";
            this.Config_Button_Save.UseVisualStyleBackColor = true;
            this.Config_Button_Save.Click += new System.EventHandler(this.Config_Button_Save_Click);
            // 
            // ServerConfig_PropertyGrid
            // 
            this.ServerConfig_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerConfig_PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.ServerConfig_PropertyGrid.Name = "ServerConfig_PropertyGrid";
            this.ServerConfig_PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.ServerConfig_PropertyGrid.Size = new System.Drawing.Size(727, 378);
            this.ServerConfig_PropertyGrid.TabIndex = 0;
            // 
            // ServerConfig_SetDefaults
            // 
            this.ServerConfig_SetDefaults.Location = new System.Drawing.Point(437, 11);
            this.ServerConfig_SetDefaults.Name = "ServerConfig_SetDefaults";
            this.ServerConfig_SetDefaults.Size = new System.Drawing.Size(95, 23);
            this.ServerConfig_SetDefaults.TabIndex = 3;
            this.ServerConfig_SetDefaults.Text = "Set Defaults";
            this.ServerConfig_SetDefaults.UseVisualStyleBackColor = true;
            this.ServerConfig_SetDefaults.Click += new System.EventHandler(this.ServerConfig_LoadDefaults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Hellion Server Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolBar_File_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolBar_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolBar_Options_HSMConfig;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolBar_Help_About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Config_Button_Cancel;
        private System.Windows.Forms.Button Config_Button_Reload;
        private System.Windows.Forms.Button Config_Button_Save;
        private System.Windows.Forms.PropertyGrid ServerConfig_PropertyGrid;
        private System.Windows.Forms.Button ServerConfig_SetDefaults;
    }
}

