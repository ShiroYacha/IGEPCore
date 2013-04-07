namespace CvConsole
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusS_Status = new System.Windows.Forms.StatusStrip();
            this.toolSPB_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolSS_AppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolS_NavBar = new System.Windows.Forms.ToolStrip();
            this.toolSB_NavToStartup = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Monitors = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Models = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Settings = new System.Windows.Forms.ToolStripButton();
            this.panel_MainContainer = new System.Windows.Forms.Panel();
            this.statusS_Status.SuspendLayout();
            this.toolS_NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusS_Status
            // 
            this.statusS_Status.BackColor = System.Drawing.SystemColors.ControlText;
            this.statusS_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSPB_ProgressBar,
            this.toolSS_AppStatus});
            this.statusS_Status.Location = new System.Drawing.Point(0, 606);
            this.statusS_Status.Name = "statusS_Status";
            this.statusS_Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusS_Status.Size = new System.Drawing.Size(941, 25);
            this.statusS_Status.TabIndex = 0;
            this.statusS_Status.Text = "statusStrip1";
            // 
            // toolSPB_ProgressBar
            // 
            this.toolSPB_ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSPB_ProgressBar.AutoSize = false;
            this.toolSPB_ProgressBar.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.toolSPB_ProgressBar.Name = "toolSPB_ProgressBar";
            this.toolSPB_ProgressBar.Size = new System.Drawing.Size(150, 17);
            // 
            // toolSS_AppStatus
            // 
            this.toolSS_AppStatus.AutoSize = false;
            this.toolSS_AppStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSS_AppStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolSS_AppStatus.Name = "toolSS_AppStatus";
            this.toolSS_AppStatus.Size = new System.Drawing.Size(100, 20);
            this.toolSS_AppStatus.Text = "Status : Ready";
            // 
            // toolS_NavBar
            // 
            this.toolS_NavBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolS_NavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSB_NavToStartup,
            this.toolSB_Monitors,
            this.toolSB_Models,
            this.toolSB_Settings});
            this.toolS_NavBar.Location = new System.Drawing.Point(0, 0);
            this.toolS_NavBar.Name = "toolS_NavBar";
            this.toolS_NavBar.Size = new System.Drawing.Size(941, 32);
            this.toolS_NavBar.TabIndex = 1;
            this.toolS_NavBar.Text = "toolStrip1";
            this.toolS_NavBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolS_NavBar_ItemClicked);
            // 
            // toolSB_NavToStartup
            // 
            this.toolSB_NavToStartup.AutoSize = false;
            this.toolSB_NavToStartup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_NavToStartup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSB_NavToStartup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolSB_NavToStartup.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_NavToStartup.Image")));
            this.toolSB_NavToStartup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_NavToStartup.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolSB_NavToStartup.Name = "toolSB_NavToStartup";
            this.toolSB_NavToStartup.Size = new System.Drawing.Size(90, 29);
            this.toolSB_NavToStartup.Text = "Startup";
            this.toolSB_NavToStartup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolSB_Monitors
            // 
            this.toolSB_Monitors.AutoSize = false;
            this.toolSB_Monitors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_Monitors.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSB_Monitors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolSB_Monitors.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Monitors.Image")));
            this.toolSB_Monitors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Monitors.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolSB_Monitors.Name = "toolSB_Monitors";
            this.toolSB_Monitors.Size = new System.Drawing.Size(90, 29);
            this.toolSB_Monitors.Text = "Monitors";
            this.toolSB_Monitors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolSB_Models
            // 
            this.toolSB_Models.AutoSize = false;
            this.toolSB_Models.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_Models.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSB_Models.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolSB_Models.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Models.Image")));
            this.toolSB_Models.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Models.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolSB_Models.Name = "toolSB_Models";
            this.toolSB_Models.Size = new System.Drawing.Size(90, 29);
            this.toolSB_Models.Text = "Models";
            this.toolSB_Models.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolSB_Settings
            // 
            this.toolSB_Settings.AutoSize = false;
            this.toolSB_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_Settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSB_Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolSB_Settings.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Settings.Image")));
            this.toolSB_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Settings.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolSB_Settings.Name = "toolSB_Settings";
            this.toolSB_Settings.Size = new System.Drawing.Size(90, 29);
            this.toolSB_Settings.Text = "Settings";
            this.toolSB_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_MainContainer
            // 
            this.panel_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainContainer.Location = new System.Drawing.Point(0, 32);
            this.panel_MainContainer.Name = "panel_MainContainer";
            this.panel_MainContainer.Size = new System.Drawing.Size(941, 574);
            this.panel_MainContainer.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(941, 631);
            this.Controls.Add(this.panel_MainContainer);
            this.Controls.Add(this.toolS_NavBar);
            this.Controls.Add(this.statusS_Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Console";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusS_Status.ResumeLayout(false);
            this.statusS_Status.PerformLayout();
            this.toolS_NavBar.ResumeLayout(false);
            this.toolS_NavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusS_Status;
        private System.Windows.Forms.ToolStrip toolS_NavBar;
        private System.Windows.Forms.ToolStripButton toolSB_NavToStartup;
        private System.Windows.Forms.ToolStripButton toolSB_Monitors;
        private System.Windows.Forms.ToolStripButton toolSB_Models;
        private System.Windows.Forms.ToolStripButton toolSB_Settings;
        private System.Windows.Forms.ToolStripStatusLabel toolSS_AppStatus;
        private System.Windows.Forms.ToolStripProgressBar toolSPB_ProgressBar;
        private System.Windows.Forms.Panel panel_MainContainer;
    }
}