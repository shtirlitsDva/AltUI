using AltUI.Controls;
using AltUI.Docking;

namespace Example.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mnuMain = new DarkMenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            mnuView = new System.Windows.Forms.ToolStripMenuItem();
            mnuDialog = new System.Windows.Forms.ToolStripMenuItem();
            themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            checkableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkableWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkedWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsole = new System.Windows.Forms.ToolStripMenuItem();
            mnuLayers = new System.Windows.Forms.ToolStripMenuItem();
            mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolMain = new DarkToolStrip();
            btnNewFile = new System.Windows.Forms.ToolStripButton();
            stripMain = new DarkStatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            DockPanel = new DarkDockPanel();
            darkSeparator1 = new DarkSeparator();
            mnuMain.SuspendLayout();
            toolMain.SuspendLayout();
            stripMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuMain.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile, mnuView, mnuTools, mnuWindow, mnuHelp });
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            mnuMain.Size = new System.Drawing.Size(944, 40);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "darkMenuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuNewFile, toolStripSeparator1, mnuClose });
            mnuFile.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(71, 36);
            mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            mnuNewFile.BackColor = System.Drawing.Color.Transparent;
            mnuNewFile.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuNewFile.Image = Icons.NewFile_6276;
            mnuNewFile.Name = "mnuNewFile";
            mnuNewFile.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            mnuNewFile.Size = new System.Drawing.Size(359, 44);
            mnuNewFile.Text = "&New file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = System.Drawing.Color.Transparent;
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // mnuClose
            // 
            mnuClose.BackColor = System.Drawing.Color.Transparent;
            mnuClose.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuClose.Image = Icons.Close_16xLG;
            mnuClose.Name = "mnuClose";
            mnuClose.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mnuClose.Size = new System.Drawing.Size(359, 44);
            mnuClose.Text = "&Close";
            // 
            // mnuView
            // 
            mnuView.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuDialog, themeToolStripMenuItem });
            mnuView.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuView.Name = "mnuView";
            mnuView.Size = new System.Drawing.Size(85, 36);
            mnuView.Text = "&View";
            // 
            // mnuDialog
            // 
            mnuDialog.BackColor = System.Drawing.Color.Transparent;
            mnuDialog.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuDialog.Image = Icons.properties_16xLG;
            mnuDialog.Name = "mnuDialog";
            mnuDialog.Size = new System.Drawing.Size(359, 44);
            mnuDialog.Text = "&Dialog test";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            themeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            darkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new System.Drawing.Size(200, 44);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            lightToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new System.Drawing.Size(200, 44);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // mnuTools
            // 
            mnuTools.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { checkableToolStripMenuItem, checkableWithIconToolStripMenuItem, toolStripSeparator2, checkedToolStripMenuItem, checkedWithIconToolStripMenuItem });
            mnuTools.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new System.Drawing.Size(89, 36);
            mnuTools.Text = "&Tools";
            // 
            // checkableToolStripMenuItem
            // 
            checkableToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            checkableToolStripMenuItem.CheckOnClick = true;
            checkableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            checkableToolStripMenuItem.Name = "checkableToolStripMenuItem";
            checkableToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            checkableToolStripMenuItem.Text = "Checkable";
            // 
            // checkableWithIconToolStripMenuItem
            // 
            checkableWithIconToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            checkableWithIconToolStripMenuItem.CheckOnClick = true;
            checkableWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            checkableWithIconToolStripMenuItem.Image = Icons.properties_16xLG;
            checkableWithIconToolStripMenuItem.Name = "checkableWithIconToolStripMenuItem";
            checkableWithIconToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            checkableWithIconToolStripMenuItem.Text = "Checkable with icon";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = System.Drawing.Color.Transparent;
            toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(358, 6);
            // 
            // checkedToolStripMenuItem
            // 
            checkedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            checkedToolStripMenuItem.Checked = true;
            checkedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            checkedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            checkedToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            checkedToolStripMenuItem.Text = "Checked";
            // 
            // checkedWithIconToolStripMenuItem
            // 
            checkedWithIconToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            checkedWithIconToolStripMenuItem.Checked = true;
            checkedWithIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            checkedWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            checkedWithIconToolStripMenuItem.Image = Icons.properties_16xLG;
            checkedWithIconToolStripMenuItem.Name = "checkedWithIconToolStripMenuItem";
            checkedWithIconToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            checkedWithIconToolStripMenuItem.Text = "Checked with icon";
            // 
            // mnuWindow
            // 
            mnuWindow.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProject, mnuProperties, mnuConsole, mnuLayers, mnuHistory });
            mnuWindow.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new System.Drawing.Size(121, 36);
            mnuWindow.Text = "&Window";
            // 
            // mnuProject
            // 
            mnuProject.BackColor = System.Drawing.Color.Transparent;
            mnuProject.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuProject.Image = Icons.application_16x;
            mnuProject.Name = "mnuProject";
            mnuProject.Size = new System.Drawing.Size(359, 44);
            mnuProject.Text = "&Project Explorer";
            // 
            // mnuProperties
            // 
            mnuProperties.BackColor = System.Drawing.Color.Transparent;
            mnuProperties.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuProperties.Image = Icons.properties_16xLG;
            mnuProperties.Name = "mnuProperties";
            mnuProperties.Size = new System.Drawing.Size(359, 44);
            mnuProperties.Text = "P&roperties";
            // 
            // mnuConsole
            // 
            mnuConsole.BackColor = System.Drawing.Color.Transparent;
            mnuConsole.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuConsole.Image = Icons.Console;
            mnuConsole.Name = "mnuConsole";
            mnuConsole.Size = new System.Drawing.Size(359, 44);
            mnuConsole.Text = "&Console";
            // 
            // mnuLayers
            // 
            mnuLayers.BackColor = System.Drawing.Color.Transparent;
            mnuLayers.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuLayers.Image = Icons.Collection_16xLG;
            mnuLayers.Name = "mnuLayers";
            mnuLayers.Size = new System.Drawing.Size(359, 44);
            mnuLayers.Text = "&Layers";
            // 
            // mnuHistory
            // 
            mnuHistory.BackColor = System.Drawing.Color.Transparent;
            mnuHistory.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuHistory.Image = (System.Drawing.Image)resources.GetObject("mnuHistory.Image");
            mnuHistory.Name = "mnuHistory";
            mnuHistory.Size = new System.Drawing.Size(359, 44);
            mnuHistory.Text = "&History";
            // 
            // mnuHelp
            // 
            mnuHelp.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuAbout });
            mnuHelp.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new System.Drawing.Size(84, 36);
            mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.BackColor = System.Drawing.Color.Transparent;
            mnuAbout.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuAbout.Image = Icons.StatusAnnotations_Information_16xLG_color;
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new System.Drawing.Size(270, 44);
            mnuAbout.Text = "&About AltUI";
            // 
            // toolMain
            // 
            toolMain.AutoSize = false;
            toolMain.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolMain.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNewFile });
            toolMain.Location = new System.Drawing.Point(0, 42);
            toolMain.Name = "toolMain";
            toolMain.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            toolMain.Size = new System.Drawing.Size(944, 28);
            toolMain.TabIndex = 1;
            toolMain.Text = "darkToolStrip1";
            // 
            // btnNewFile
            // 
            btnNewFile.AutoSize = false;
            btnNewFile.BackColor = System.Drawing.Color.FromArgb(31, 31, 32);
            btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnNewFile.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            btnNewFile.Image = Icons.NewFile_6276;
            btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new System.Drawing.Size(24, 24);
            btnNewFile.Text = "New file";
            // 
            // stripMain
            // 
            stripMain.AutoSize = false;
            stripMain.BackColor = System.Drawing.Color.Transparent;
            stripMain.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            stripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel6, toolStripStatusLabel5 });
            stripMain.Location = new System.Drawing.Point(0, 618);
            stripMain.Name = "stripMain";
            stripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            stripMain.Size = new System.Drawing.Size(944, 24);
            stripMain.SizingGrip = false;
            stripMain.TabIndex = 2;
            stripMain.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 2);
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new System.Drawing.Size(707, 14);
            toolStripStatusLabel6.Spring = true;
            toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new System.Drawing.Size(96, 16);
            toolStripStatusLabel5.Text = "120 MB";
            toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DockPanel
            // 
            DockPanel.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DockPanel.Location = new System.Drawing.Point(0, 70);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new System.Drawing.Size(944, 548);
            DockPanel.TabIndex = 3;
            // 
            // darkSeparator1
            // 
            darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            darkSeparator1.Location = new System.Drawing.Point(0, 40);
            darkSeparator1.Name = "darkSeparator1";
            darkSeparator1.Size = new System.Drawing.Size(944, 2);
            darkSeparator1.TabIndex = 4;
            darkSeparator1.Text = "darkSeparator1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(944, 642);
            Controls.Add(DockPanel);
            Controls.Add(stripMain);
            Controls.Add(toolMain);
            Controls.Add(darkSeparator1);
            Controls.Add(mnuMain);
            CornerStyle = CornerPreference.Default;
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnuMain;
            MinimumSize = new System.Drawing.Size(640, 480);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dark UI - Example";
            TransparencyKey = System.Drawing.Color.FromArgb(31, 31, 32);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            stripMain.ResumeLayout(false);
            stripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DarkMenuStrip mnuMain;
        private DarkToolStrip toolMain;
        private DarkStatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DarkDockPanel DockPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuConsole;
        private System.Windows.Forms.ToolStripMenuItem mnuLayers;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private DarkSeparator darkSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkableWithIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedWithIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
    }
}

