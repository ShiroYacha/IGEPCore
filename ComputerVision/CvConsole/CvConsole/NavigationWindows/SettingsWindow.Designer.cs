namespace CvConsole
{
    partial class SettingsWindow
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
            this.lbl_Introduction = new System.Windows.Forms.Label();
            this.groupB_Basics = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tableLP_Save = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_Logs = new System.Windows.Forms.GroupBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.tableLP_Main.SuspendLayout();
            this.tableLP_Save.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.ColumnCount = 2;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.Controls.Add(this.tableLP_Save, 0, 3);
            this.tableLP_Main.Controls.Add(this.lbl_Introduction, 0, 0);
            this.tableLP_Main.Controls.Add(this.groupB_Basics, 0, 1);
            this.tableLP_Main.Controls.Add(this.groupB_Logs, 0, 2);
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 5;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.Size = new System.Drawing.Size(631, 519);
            this.tableLP_Main.TabIndex = 0;
            // 
            // lbl_Introduction
            // 
            this.lbl_Introduction.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Introduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Introduction.Location = new System.Drawing.Point(3, 0);
            this.lbl_Introduction.Name = "lbl_Introduction";
            this.lbl_Introduction.Size = new System.Drawing.Size(466, 30);
            this.lbl_Introduction.TabIndex = 3;
            this.lbl_Introduction.Text = "Local app settings.";
            this.lbl_Introduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupB_Basics
            // 
            this.groupB_Basics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Basics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Basics.Location = new System.Drawing.Point(3, 33);
            this.groupB_Basics.Name = "groupB_Basics";
            this.groupB_Basics.Size = new System.Drawing.Size(466, 187);
            this.groupB_Basics.TabIndex = 4;
            this.groupB_Basics.TabStop = false;
            this.groupB_Basics.Text = "Basics";
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Location = new System.Drawing.Point(236, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(227, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // tableLP_Save
            // 
            this.tableLP_Save.AutoSize = true;
            this.tableLP_Save.ColumnCount = 2;
            this.tableLP_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Save.Controls.Add(this.btn_Restore, 0, 0);
            this.tableLP_Save.Controls.Add(this.btn_Save, 1, 0);
            this.tableLP_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Save.Location = new System.Drawing.Point(3, 399);
            this.tableLP_Save.Name = "tableLP_Save";
            this.tableLP_Save.RowCount = 1;
            this.tableLP_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Save.Size = new System.Drawing.Size(466, 29);
            this.tableLP_Save.TabIndex = 6;
            // 
            // groupB_Logs
            // 
            this.groupB_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Logs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Logs.Location = new System.Drawing.Point(3, 226);
            this.groupB_Logs.Name = "groupB_Logs";
            this.groupB_Logs.Size = new System.Drawing.Size(466, 167);
            this.groupB_Logs.TabIndex = 5;
            this.groupB_Logs.TabStop = false;
            this.groupB_Logs.Text = "Logs";
            // 
            // btn_Restore
            // 
            this.btn_Restore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Restore.Location = new System.Drawing.Point(3, 3);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(227, 23);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "Restore default";
            this.btn_Restore.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "SettingsWindow";
            this.Size = new System.Drawing.Size(631, 519);
            this.tableLP_Main.ResumeLayout(false);
            this.tableLP_Main.PerformLayout();
            this.tableLP_Save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private System.Windows.Forms.Label lbl_Introduction;
        private System.Windows.Forms.GroupBox groupB_Basics;
        private System.Windows.Forms.TableLayoutPanel tableLP_Save;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupB_Logs;
        private System.Windows.Forms.Button btn_Restore;
    }
}
