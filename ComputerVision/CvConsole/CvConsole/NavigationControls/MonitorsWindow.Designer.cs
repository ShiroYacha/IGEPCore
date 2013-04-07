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
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_Console = new System.Windows.Forms.GroupBox();
            this.groupB_Monitor = new System.Windows.Forms.GroupBox();
            this.tableLP_Monitor = new System.Windows.Forms.TableLayoutPanel();
            this.listV_MonitorNavigation = new System.Windows.Forms.ListView();
            this.picB_MonitorView = new System.Windows.Forms.PictureBox();
            this.groupB_PropertyView = new System.Windows.Forms.GroupBox();
            this.propG_Monitor = new System.Windows.Forms.PropertyGrid();
            this.logC_LogViewer = new CvConsole.NavigationControls.LogControl();
            this.tableLP_Main.SuspendLayout();
            this.groupB_Monitor.SuspendLayout();
            this.tableLP_Monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_MonitorView)).BeginInit();
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
            this.groupB_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Console.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Console.Location = new System.Drawing.Point(590, 413);
            this.groupB_Console.Name = "groupB_Console";
            this.groupB_Console.Size = new System.Drawing.Size(290, 209);
            this.groupB_Console.TabIndex = 1;
            this.groupB_Console.TabStop = false;
            this.groupB_Console.Text = "Console";
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
            this.tableLP_Monitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.62064F));
            this.tableLP_Monitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.37936F));
            this.tableLP_Monitor.Controls.Add(this.listV_MonitorNavigation, 0, 0);
            this.tableLP_Monitor.Controls.Add(this.picB_MonitorView, 1, 0);
            this.tableLP_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Monitor.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Monitor.Name = "tableLP_Monitor";
            this.tableLP_Monitor.RowCount = 1;
            this.tableLP_Monitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Monitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tableLP_Monitor.Size = new System.Drawing.Size(575, 378);
            this.tableLP_Monitor.TabIndex = 3;
            // 
            // listV_MonitorNavigation
            // 
            this.listV_MonitorNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_MonitorNavigation.Location = new System.Drawing.Point(3, 3);
            this.listV_MonitorNavigation.Name = "listV_MonitorNavigation";
            this.listV_MonitorNavigation.Size = new System.Drawing.Size(83, 372);
            this.listV_MonitorNavigation.TabIndex = 0;
            this.listV_MonitorNavigation.UseCompatibleStateImageBehavior = false;
            // 
            // picB_MonitorView
            // 
            this.picB_MonitorView.BackColor = System.Drawing.Color.DarkGray;
            this.picB_MonitorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_MonitorView.Location = new System.Drawing.Point(92, 3);
            this.picB_MonitorView.Name = "picB_MonitorView";
            this.picB_MonitorView.Size = new System.Drawing.Size(480, 372);
            this.picB_MonitorView.TabIndex = 1;
            this.picB_MonitorView.TabStop = false;
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
            // logC_LogViewer
            // 
            this.logC_LogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logC_LogViewer.Location = new System.Drawing.Point(3, 413);
            this.logC_LogViewer.Name = "logC_LogViewer";
            this.logC_LogViewer.Size = new System.Drawing.Size(581, 209);
            this.logC_LogViewer.TabIndex = 0;
            // 
            // MonitorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "MonitorsWindow";
            this.Size = new System.Drawing.Size(883, 625);
            this.tableLP_Main.ResumeLayout(false);
            this.groupB_Monitor.ResumeLayout(false);
            this.tableLP_Monitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_MonitorView)).EndInit();
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
        private System.Windows.Forms.PictureBox picB_MonitorView;
        private System.Windows.Forms.GroupBox groupB_PropertyView;
        private System.Windows.Forms.PropertyGrid propG_Monitor;

    }
}
