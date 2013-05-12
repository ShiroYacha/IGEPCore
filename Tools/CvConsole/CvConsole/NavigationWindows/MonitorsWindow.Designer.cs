namespace CvConsole
{
    partial class MonitorsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_Console = new System.Windows.Forms.GroupBox();
            this.tableLP_Console = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Launch = new System.Windows.Forms.Button();
            this.logC_LogViewer = new CvConsole.NavigationControls.LogControl();
            this.groupB_Monitor = new System.Windows.Forms.GroupBox();
            this.tableLP_Monitor = new System.Windows.Forms.TableLayoutPanel();
            this.listV_MonitorNavigation = new System.Windows.Forms.ListView();
            this.panel_Monitor = new System.Windows.Forms.Panel();
            this.groupB_PropertyView = new System.Windows.Forms.GroupBox();
            this.propG_Monitor = new System.Windows.Forms.PropertyGrid();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLP_Main.SuspendLayout();
            this.groupB_Console.SuspendLayout();
            this.tableLP_Console.SuspendLayout();
            this.groupB_Monitor.SuspendLayout();
            this.tableLP_Monitor.SuspendLayout();
            this.groupB_PropertyView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.ColumnCount = 2;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.49899F));
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.50101F));
            this.tableLP_Main.Controls.Add(this.groupB_Console, 1, 1);
            this.tableLP_Main.Controls.Add(this.logC_LogViewer, 0, 1);
            this.tableLP_Main.Controls.Add(this.groupB_Monitor, 0, 0);
            this.tableLP_Main.Controls.Add(this.groupB_PropertyView, 1, 0);
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 2;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.71429F));
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
            this.tableLP_Main.Size = new System.Drawing.Size(883, 625);
            this.tableLP_Main.TabIndex = 0;
            // 
            // groupB_Console
            // 
            this.groupB_Console.Controls.Add(this.tableLP_Console);
            this.groupB_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Console.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Console.Location = new System.Drawing.Point(590, 413);
            this.groupB_Console.Name = "groupB_Console";
            this.groupB_Console.Size = new System.Drawing.Size(290, 209);
            this.groupB_Console.TabIndex = 1;
            this.groupB_Console.TabStop = false;
            this.groupB_Console.Text = "Console";
            // 
            // tableLP_Console
            // 
            this.tableLP_Console.ColumnCount = 1;
            this.tableLP_Console.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Console.Controls.Add(this.btn_Launch, 0, 0);
            this.tableLP_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Console.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Console.Name = "tableLP_Console";
            this.tableLP_Console.RowCount = 2;
            this.tableLP_Console.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Console.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Console.Size = new System.Drawing.Size(284, 183);
            this.tableLP_Console.TabIndex = 0;
            // 
            // btn_Launch
            // 
            this.btn_Launch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Launch.Location = new System.Drawing.Point(3, 3);
            this.btn_Launch.Name = "btn_Launch";
            this.btn_Launch.Size = new System.Drawing.Size(278, 30);
            this.btn_Launch.TabIndex = 0;
            this.btn_Launch.Text = "Launch";
            this.btn_Launch.UseVisualStyleBackColor = true;
            this.btn_Launch.Click += new System.EventHandler(this.btn_Launch_Click);
            // 
            // logC_LogViewer
            // 
            this.logC_LogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logC_LogViewer.Location = new System.Drawing.Point(3, 413);
            this.logC_LogViewer.Name = "logC_LogViewer";
            this.logC_LogViewer.Size = new System.Drawing.Size(581, 209);
            this.logC_LogViewer.TabIndex = 0;
            // 
            // groupB_Monitor
            // 
            this.groupB_Monitor.Controls.Add(this.tableLP_Monitor);
            this.groupB_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Monitor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Monitor.Location = new System.Drawing.Point(3, 3);
            this.groupB_Monitor.Name = "groupB_Monitor";
            this.groupB_Monitor.Size = new System.Drawing.Size(581, 404);
            this.groupB_Monitor.TabIndex = 2;
            this.groupB_Monitor.TabStop = false;
            this.groupB_Monitor.Text = "Monitors";
            // 
            // tableLP_Monitor
            // 
            this.tableLP_Monitor.ColumnCount = 2;
            this.tableLP_Monitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47826F));
            this.tableLP_Monitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.52174F));
            this.tableLP_Monitor.Controls.Add(this.listV_MonitorNavigation, 0, 0);
            this.tableLP_Monitor.Controls.Add(this.panel_Monitor, 1, 0);
            this.tableLP_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Monitor.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Monitor.Name = "tableLP_Monitor";
            this.tableLP_Monitor.RowCount = 1;
            this.tableLP_Monitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Monitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLP_Monitor.Size = new System.Drawing.Size(575, 378);
            this.tableLP_Monitor.TabIndex = 3;
            // 
            // listV_MonitorNavigation
            // 
            this.listV_MonitorNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_MonitorNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listV_MonitorNavigation.Location = new System.Drawing.Point(3, 3);
            this.listV_MonitorNavigation.Name = "listV_MonitorNavigation";
            this.listV_MonitorNavigation.Size = new System.Drawing.Size(128, 372);
            this.listV_MonitorNavigation.TabIndex = 0;
            this.listV_MonitorNavigation.UseCompatibleStateImageBehavior = false;
            this.listV_MonitorNavigation.View = System.Windows.Forms.View.List;
            this.listV_MonitorNavigation.SelectedIndexChanged += new System.EventHandler(this.listV_MonitorNavigation_SelectedIndexChanged);
            // 
            // panel_Monitor
            // 
            this.panel_Monitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Monitor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Monitor.Location = new System.Drawing.Point(137, 3);
            this.panel_Monitor.Name = "panel_Monitor";
            this.panel_Monitor.Size = new System.Drawing.Size(435, 372);
            this.panel_Monitor.TabIndex = 1;
            // 
            // groupB_PropertyView
            // 
            this.groupB_PropertyView.Controls.Add(this.propG_Monitor);
            this.groupB_PropertyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_PropertyView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_PropertyView.Location = new System.Drawing.Point(590, 3);
            this.groupB_PropertyView.Name = "groupB_PropertyView";
            this.groupB_PropertyView.Size = new System.Drawing.Size(290, 404);
            this.groupB_PropertyView.TabIndex = 3;
            this.groupB_PropertyView.TabStop = false;
            this.groupB_PropertyView.Text = "Data";
            // 
            // propG_Monitor
            // 
            this.propG_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propG_Monitor.Location = new System.Drawing.Point(3, 23);
            this.propG_Monitor.Name = "propG_Monitor";
            this.propG_Monitor.Size = new System.Drawing.Size(284, 378);
            this.propG_Monitor.TabIndex = 4;
            // 
            // displayTimer
            // 
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // MonitorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "MonitorsWindow";
            this.Size = new System.Drawing.Size(883, 625);
            this.Load += new System.EventHandler(this.MonitorsWindow_Load);
            this.tableLP_Main.ResumeLayout(false);
            this.groupB_Console.ResumeLayout(false);
            this.tableLP_Console.ResumeLayout(false);
            this.groupB_Monitor.ResumeLayout(false);
            this.tableLP_Monitor.ResumeLayout(false);
            this.groupB_PropertyView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private NavigationControls.LogControl logC_LogViewer;
        private System.Windows.Forms.GroupBox groupB_Console;
        private System.Windows.Forms.GroupBox groupB_Monitor;
        private System.Windows.Forms.TableLayoutPanel tableLP_Monitor;
        private System.Windows.Forms.ListView listV_MonitorNavigation;
        private System.Windows.Forms.GroupBox groupB_PropertyView;
        private System.Windows.Forms.PropertyGrid propG_Monitor;
        private System.Windows.Forms.TableLayoutPanel tableLP_Console;
        private System.Windows.Forms.Button btn_Launch;
        private System.Windows.Forms.Panel panel_Monitor;
        private System.Windows.Forms.Timer displayTimer;

    }
}
