namespace CvConsole.NavigationControls
{
    partial class LogControl
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
            this.menuS_Main = new System.Windows.Forms.MenuStrip();
            this.clearScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listV_Main = new System.Windows.Forms.ListView();
            this.colH_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupB_Main = new System.Windows.Forms.GroupBox();
            this.clearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuS_Main.SuspendLayout();
            this.groupB_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuS_Main
            // 
            this.menuS_Main.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearScreenToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.clearFilterToolStripMenuItem});
            this.menuS_Main.Location = new System.Drawing.Point(3, 23);
            this.menuS_Main.Name = "menuS_Main";
            this.menuS_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuS_Main.Size = new System.Drawing.Size(573, 24);
            this.menuS_Main.TabIndex = 0;
            this.menuS_Main.Text = "menuStrip";
            // 
            // clearScreenToolStripMenuItem
            // 
            this.clearScreenToolStripMenuItem.Name = "clearScreenToolStripMenuItem";
            this.clearScreenToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.clearScreenToolStripMenuItem.Text = "&Clear Screen";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeFilterToolStripMenuItem,
            this.typeFilterToolStripMenuItem,
            this.sourceFilterToolStripMenuItem,
            this.processFilterToolStripMenuItem,
            this.messageFilterToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "&Filter";
            // 
            // timeFilterToolStripMenuItem
            // 
            this.timeFilterToolStripMenuItem.Name = "timeFilterToolStripMenuItem";
            this.timeFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timeFilterToolStripMenuItem.Text = "&Time Filter";
            // 
            // typeFilterToolStripMenuItem
            // 
            this.typeFilterToolStripMenuItem.Name = "typeFilterToolStripMenuItem";
            this.typeFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.typeFilterToolStripMenuItem.Text = "&Type Filter";
            // 
            // sourceFilterToolStripMenuItem
            // 
            this.sourceFilterToolStripMenuItem.Name = "sourceFilterToolStripMenuItem";
            this.sourceFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sourceFilterToolStripMenuItem.Text = "&Source Filter";
            // 
            // processFilterToolStripMenuItem
            // 
            this.processFilterToolStripMenuItem.Name = "processFilterToolStripMenuItem";
            this.processFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processFilterToolStripMenuItem.Text = "&Process Filter";
            // 
            // messageFilterToolStripMenuItem
            // 
            this.messageFilterToolStripMenuItem.Name = "messageFilterToolStripMenuItem";
            this.messageFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.messageFilterToolStripMenuItem.Text = "&Message Filter";
            // 
            // listV_Main
            // 
            this.listV_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_Time,
            this.colH_Type,
            this.colH_Source,
            this.colH_Process,
            this.colH_Message});
            this.listV_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_Main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listV_Main.Location = new System.Drawing.Point(3, 47);
            this.listV_Main.Margin = new System.Windows.Forms.Padding(6);
            this.listV_Main.Name = "listV_Main";
            this.listV_Main.Size = new System.Drawing.Size(573, 207);
            this.listV_Main.TabIndex = 1;
            this.listV_Main.UseCompatibleStateImageBehavior = false;
            this.listV_Main.View = System.Windows.Forms.View.Details;
            // 
            // colH_Time
            // 
            this.colH_Time.Text = "Time";
            // 
            // colH_Type
            // 
            this.colH_Type.Text = "Type";
            this.colH_Type.Width = 77;
            // 
            // colH_Source
            // 
            this.colH_Source.Text = "Source";
            this.colH_Source.Width = 79;
            // 
            // colH_Process
            // 
            this.colH_Process.Text = "Process";
            this.colH_Process.Width = 110;
            // 
            // colH_Message
            // 
            this.colH_Message.Text = "Message";
            this.colH_Message.Width = 250;
            // 
            // groupB_Main
            // 
            this.groupB_Main.Controls.Add(this.listV_Main);
            this.groupB_Main.Controls.Add(this.menuS_Main);
            this.groupB_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Main.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Main.Location = new System.Drawing.Point(0, 0);
            this.groupB_Main.Name = "groupB_Main";
            this.groupB_Main.Size = new System.Drawing.Size(579, 257);
            this.groupB_Main.TabIndex = 2;
            this.groupB_Main.TabStop = false;
            this.groupB_Main.Text = "Log Viewer";
            // 
            // clearFilterToolStripMenuItem
            // 
            this.clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            this.clearFilterToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.clearFilterToolStripMenuItem.Text = "&Clear Filter";
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupB_Main);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(579, 257);
            this.menuS_Main.ResumeLayout(false);
            this.menuS_Main.PerformLayout();
            this.groupB_Main.ResumeLayout(false);
            this.groupB_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuS_Main;
        private System.Windows.Forms.ListView listV_Main;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colH_Type;
        private System.Windows.Forms.ColumnHeader colH_Source;
        private System.Windows.Forms.ColumnHeader colH_Process;
        private System.Windows.Forms.ColumnHeader colH_Message;
        private System.Windows.Forms.ToolStripMenuItem typeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageFilterToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colH_Time;
        private System.Windows.Forms.ToolStripMenuItem timeFilterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupB_Main;
        private System.Windows.Forms.ToolStripMenuItem clearFilterToolStripMenuItem;
    }
}
