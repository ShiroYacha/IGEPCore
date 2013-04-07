namespace CvConsole
{
    partial class StartupWindow
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
            this.groupB_Input = new System.Windows.Forms.GroupBox();
            this.tableLP_Input = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_RightCam = new System.Windows.Forms.Label();
            this.lbl_LeftCam = new System.Windows.Forms.Label();
            this.comboB_LeftCam = new System.Windows.Forms.ComboBox();
            this.comboB_RightCam = new System.Windows.Forms.ComboBox();
            this.groupB_Models = new System.Windows.Forms.GroupBox();
            this.tableLP_Models = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listV_RegisteredModels = new System.Windows.Forms.ListView();
            this.flowLP_InterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_MoveAllRight = new System.Windows.Forms.Button();
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.btn_MoveAllLeft = new System.Windows.Forms.Button();
            this.listV_LoadedModels = new System.Windows.Forms.ListView();
            this.lbl_leftTitle = new System.Windows.Forms.Label();
            this.lbl_Introduction = new System.Windows.Forms.Label();
            this.tableLP_Start = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tableLP_Main.SuspendLayout();
            this.groupB_Input.SuspendLayout();
            this.tableLP_Input.SuspendLayout();
            this.groupB_Models.SuspendLayout();
            this.tableLP_Models.SuspendLayout();
            this.flowLP_InterButtons.SuspendLayout();
            this.tableLP_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.AutoSize = true;
            this.tableLP_Main.ColumnCount = 2;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.Controls.Add(this.groupB_Input, 0, 1);
            this.tableLP_Main.Controls.Add(this.groupB_Models, 0, 2);
            this.tableLP_Main.Controls.Add(this.lbl_Introduction, 0, 0);
            this.tableLP_Main.Controls.Add(this.tableLP_Start, 0, 3);
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 5;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Main.Size = new System.Drawing.Size(473, 415);
            this.tableLP_Main.TabIndex = 0;
            // 
            // groupB_Input
            // 
            this.groupB_Input.AutoSize = true;
            this.groupB_Input.Controls.Add(this.tableLP_Input);
            this.groupB_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Input.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupB_Input.Location = new System.Drawing.Point(3, 33);
            this.groupB_Input.Name = "groupB_Input";
            this.groupB_Input.Size = new System.Drawing.Size(467, 80);
            this.groupB_Input.TabIndex = 3;
            this.groupB_Input.TabStop = false;
            this.groupB_Input.Text = "Input";
            // 
            // tableLP_Input
            // 
            this.tableLP_Input.AutoSize = true;
            this.tableLP_Input.ColumnCount = 2;
            this.tableLP_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Input.Controls.Add(this.lbl_RightCam, 0, 1);
            this.tableLP_Input.Controls.Add(this.lbl_LeftCam, 0, 0);
            this.tableLP_Input.Controls.Add(this.comboB_LeftCam, 1, 0);
            this.tableLP_Input.Controls.Add(this.comboB_RightCam, 1, 1);
            this.tableLP_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Input.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Input.Name = "tableLP_Input";
            this.tableLP_Input.RowCount = 2;
            this.tableLP_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Input.Size = new System.Drawing.Size(461, 54);
            this.tableLP_Input.TabIndex = 0;
            // 
            // lbl_RightCam
            // 
            this.lbl_RightCam.AutoSize = true;
            this.lbl_RightCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RightCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightCam.Location = new System.Drawing.Point(3, 27);
            this.lbl_RightCam.Name = "lbl_RightCam";
            this.lbl_RightCam.Size = new System.Drawing.Size(83, 27);
            this.lbl_RightCam.TabIndex = 5;
            this.lbl_RightCam.Text = "Right Camera";
            this.lbl_RightCam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LeftCam
            // 
            this.lbl_LeftCam.AutoSize = true;
            this.lbl_LeftCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LeftCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeftCam.Location = new System.Drawing.Point(3, 0);
            this.lbl_LeftCam.Name = "lbl_LeftCam";
            this.lbl_LeftCam.Size = new System.Drawing.Size(83, 27);
            this.lbl_LeftCam.TabIndex = 4;
            this.lbl_LeftCam.Text = "Left Camera";
            this.lbl_LeftCam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboB_LeftCam
            // 
            this.comboB_LeftCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_LeftCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_LeftCam.FormattingEnabled = true;
            this.comboB_LeftCam.Location = new System.Drawing.Point(92, 3);
            this.comboB_LeftCam.Name = "comboB_LeftCam";
            this.comboB_LeftCam.Size = new System.Drawing.Size(366, 28);
            this.comboB_LeftCam.TabIndex = 0;
            // 
            // comboB_RightCam
            // 
            this.comboB_RightCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_RightCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_RightCam.FormattingEnabled = true;
            this.comboB_RightCam.Location = new System.Drawing.Point(92, 30);
            this.comboB_RightCam.Name = "comboB_RightCam";
            this.comboB_RightCam.Size = new System.Drawing.Size(366, 28);
            this.comboB_RightCam.TabIndex = 1;
            // 
            // groupB_Models
            // 
            this.groupB_Models.AutoSize = true;
            this.groupB_Models.Controls.Add(this.tableLP_Models);
            this.groupB_Models.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Models.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupB_Models.Location = new System.Drawing.Point(3, 119);
            this.groupB_Models.Name = "groupB_Models";
            this.groupB_Models.Size = new System.Drawing.Size(467, 236);
            this.groupB_Models.TabIndex = 1;
            this.groupB_Models.TabStop = false;
            this.groupB_Models.Text = "Models";
            // 
            // tableLP_Models
            // 
            this.tableLP_Models.AutoScroll = true;
            this.tableLP_Models.AutoSize = true;
            this.tableLP_Models.ColumnCount = 3;
            this.tableLP_Models.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Models.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Models.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Models.Controls.Add(this.label2, 2, 0);
            this.tableLP_Models.Controls.Add(this.listV_RegisteredModels, 2, 1);
            this.tableLP_Models.Controls.Add(this.flowLP_InterButtons, 1, 1);
            this.tableLP_Models.Controls.Add(this.listV_LoadedModels, 0, 1);
            this.tableLP_Models.Controls.Add(this.lbl_leftTitle, 0, 0);
            this.tableLP_Models.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Models.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Models.Name = "tableLP_Models";
            this.tableLP_Models.RowCount = 2;
            this.tableLP_Models.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP_Models.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Models.Size = new System.Drawing.Size(461, 210);
            this.tableLP_Models.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registered Models";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listV_RegisteredModels
            // 
            this.listV_RegisteredModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_RegisteredModels.Location = new System.Drawing.Point(260, 23);
            this.listV_RegisteredModels.Name = "listV_RegisteredModels";
            this.listV_RegisteredModels.Size = new System.Drawing.Size(198, 184);
            this.listV_RegisteredModels.TabIndex = 2;
            this.listV_RegisteredModels.UseCompatibleStateImageBehavior = false;
            // 
            // flowLP_InterButtons
            // 
            this.flowLP_InterButtons.AutoSize = true;
            this.flowLP_InterButtons.Controls.Add(this.btn_MoveAllRight);
            this.flowLP_InterButtons.Controls.Add(this.btn_MoveRight);
            this.flowLP_InterButtons.Controls.Add(this.btn_MoveLeft);
            this.flowLP_InterButtons.Controls.Add(this.btn_MoveAllLeft);
            this.flowLP_InterButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLP_InterButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLP_InterButtons.Location = new System.Drawing.Point(207, 23);
            this.flowLP_InterButtons.Name = "flowLP_InterButtons";
            this.flowLP_InterButtons.Size = new System.Drawing.Size(47, 184);
            this.flowLP_InterButtons.TabIndex = 0;
            // 
            // btn_MoveAllRight
            // 
            this.btn_MoveAllRight.AutoSize = true;
            this.btn_MoveAllRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveAllRight.Location = new System.Drawing.Point(3, 3);
            this.btn_MoveAllRight.Name = "btn_MoveAllRight";
            this.btn_MoveAllRight.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveAllRight.Size = new System.Drawing.Size(41, 40);
            this.btn_MoveAllRight.TabIndex = 0;
            this.btn_MoveAllRight.Text = ">>";
            this.btn_MoveAllRight.UseVisualStyleBackColor = true;
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.AutoSize = true;
            this.btn_MoveRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveRight.Location = new System.Drawing.Point(3, 49);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveRight.Size = new System.Drawing.Size(40, 40);
            this.btn_MoveRight.TabIndex = 1;
            this.btn_MoveRight.Text = ">";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.AutoSize = true;
            this.btn_MoveLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveLeft.Location = new System.Drawing.Point(3, 95);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveLeft.Size = new System.Drawing.Size(40, 40);
            this.btn_MoveLeft.TabIndex = 2;
            this.btn_MoveLeft.Text = "<";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            // 
            // btn_MoveAllLeft
            // 
            this.btn_MoveAllLeft.AutoSize = true;
            this.btn_MoveAllLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveAllLeft.Location = new System.Drawing.Point(3, 141);
            this.btn_MoveAllLeft.Name = "btn_MoveAllLeft";
            this.btn_MoveAllLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveAllLeft.Size = new System.Drawing.Size(41, 40);
            this.btn_MoveAllLeft.TabIndex = 3;
            this.btn_MoveAllLeft.Text = "<<";
            this.btn_MoveAllLeft.UseVisualStyleBackColor = true;
            // 
            // listV_LoadedModels
            // 
            this.listV_LoadedModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_LoadedModels.Location = new System.Drawing.Point(3, 23);
            this.listV_LoadedModels.Name = "listV_LoadedModels";
            this.listV_LoadedModels.Size = new System.Drawing.Size(198, 184);
            this.listV_LoadedModels.TabIndex = 1;
            this.listV_LoadedModels.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_leftTitle
            // 
            this.lbl_leftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_leftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftTitle.Location = new System.Drawing.Point(3, 0);
            this.lbl_leftTitle.Name = "lbl_leftTitle";
            this.lbl_leftTitle.Size = new System.Drawing.Size(198, 20);
            this.lbl_leftTitle.TabIndex = 3;
            this.lbl_leftTitle.Text = "Loaded Models";
            this.lbl_leftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Introduction
            // 
            this.lbl_Introduction.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Introduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Introduction.Location = new System.Drawing.Point(3, 0);
            this.lbl_Introduction.Name = "lbl_Introduction";
            this.lbl_Introduction.Size = new System.Drawing.Size(467, 30);
            this.lbl_Introduction.TabIndex = 2;
            this.lbl_Introduction.Text = "Start up configurations.";
            this.lbl_Introduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLP_Start
            // 
            this.tableLP_Start.AutoSize = true;
            this.tableLP_Start.ColumnCount = 2;
            this.tableLP_Start.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Start.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Start.Controls.Add(this.btn_Save, 0, 0);
            this.tableLP_Start.Controls.Add(this.btn_Start, 1, 0);
            this.tableLP_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Start.Location = new System.Drawing.Point(3, 361);
            this.tableLP_Start.Name = "tableLP_Start";
            this.tableLP_Start.RowCount = 1;
            this.tableLP_Start.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Start.Size = new System.Drawing.Size(467, 29);
            this.tableLP_Start.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(227, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.Location = new System.Drawing.Point(236, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(228, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // StartupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "StartupWindow";
            this.Size = new System.Drawing.Size(473, 415);
            this.tableLP_Main.ResumeLayout(false);
            this.tableLP_Main.PerformLayout();
            this.groupB_Input.ResumeLayout(false);
            this.groupB_Input.PerformLayout();
            this.tableLP_Input.ResumeLayout(false);
            this.tableLP_Input.PerformLayout();
            this.groupB_Models.ResumeLayout(false);
            this.groupB_Models.PerformLayout();
            this.tableLP_Models.ResumeLayout(false);
            this.tableLP_Models.PerformLayout();
            this.flowLP_InterButtons.ResumeLayout(false);
            this.flowLP_InterButtons.PerformLayout();
            this.tableLP_Start.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private System.Windows.Forms.TableLayoutPanel tableLP_Models;
        private System.Windows.Forms.FlowLayoutPanel flowLP_InterButtons;
        private System.Windows.Forms.Button btn_MoveAllRight;
        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Button btn_MoveAllLeft;
        private System.Windows.Forms.GroupBox groupB_Models;
        private System.Windows.Forms.ListView listV_RegisteredModels;
        private System.Windows.Forms.ListView listV_LoadedModels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_leftTitle;
        private System.Windows.Forms.Label lbl_Introduction;
        private System.Windows.Forms.GroupBox groupB_Input;
        private System.Windows.Forms.TableLayoutPanel tableLP_Input;
        private System.Windows.Forms.ComboBox comboB_LeftCam;
        private System.Windows.Forms.ComboBox comboB_RightCam;
        private System.Windows.Forms.Label lbl_RightCam;
        private System.Windows.Forms.Label lbl_LeftCam;
        private System.Windows.Forms.TableLayoutPanel tableLP_Start;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Start;

    }
}
