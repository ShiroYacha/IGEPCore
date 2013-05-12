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
            this.tableLP_SubMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_Input = new System.Windows.Forms.GroupBox();
            this.tableLP_Input = new System.Windows.Forms.TableLayoutPanel();
            this.comboB_SourceType = new System.Windows.Forms.ComboBox();
            this.lbl_RightSource = new System.Windows.Forms.Label();
            this.lbl_LeftSource = new System.Windows.Forms.Label();
            this.comboB_LeftSource = new System.Windows.Forms.ComboBox();
            this.comboB_RightSource = new System.Windows.Forms.ComboBox();
            this.lbl_SourceType = new System.Windows.Forms.Label();
            this.groupB_Models = new System.Windows.Forms.GroupBox();
            this.tableLP_Models = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listV_LoadedModelData = new System.Windows.Forms.ListView();
            this.flowLP_InterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_MoveAllRight = new System.Windows.Forms.Button();
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.btn_MoveAllLeft = new System.Windows.Forms.Button();
            this.listV_FoundModelData = new System.Windows.Forms.ListView();
            this.lbl_leftTitle = new System.Windows.Forms.Label();
            this.lbl_Introduction = new System.Windows.Forms.Label();
            this.tableLP_Start = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.openFileDialog_Image = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_Video = new System.Windows.Forms.OpenFileDialog();
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLP_Summary = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_Summary = new System.Windows.Forms.GroupBox();
            this.panel_RichTB = new System.Windows.Forms.Panel();
            this.richTextB_Summary = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog_SaveStartUp = new System.Windows.Forms.SaveFileDialog();
            this.btn_Load = new System.Windows.Forms.Button();
            this.openFileDialog_Settings = new System.Windows.Forms.OpenFileDialog();
            this.tableLP_SubMain.SuspendLayout();
            this.groupB_Input.SuspendLayout();
            this.tableLP_Input.SuspendLayout();
            this.groupB_Models.SuspendLayout();
            this.tableLP_Models.SuspendLayout();
            this.flowLP_InterButtons.SuspendLayout();
            this.tableLP_Start.SuspendLayout();
            this.tableLP_Main.SuspendLayout();
            this.tableLP_Summary.SuspendLayout();
            this.groupB_Summary.SuspendLayout();
            this.panel_RichTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_SubMain
            // 
            this.tableLP_SubMain.AutoSize = true;
            this.tableLP_SubMain.ColumnCount = 2;
            this.tableLP_SubMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_SubMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLP_SubMain.Controls.Add(this.groupB_Input, 0, 1);
            this.tableLP_SubMain.Controls.Add(this.groupB_Models, 0, 2);
            this.tableLP_SubMain.Controls.Add(this.lbl_Introduction, 0, 0);
            this.tableLP_SubMain.Controls.Add(this.tableLP_Start, 0, 4);
            this.tableLP_SubMain.Location = new System.Drawing.Point(3, 3);
            this.tableLP_SubMain.Name = "tableLP_SubMain";
            this.tableLP_SubMain.RowCount = 6;
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_SubMain.Size = new System.Drawing.Size(508, 433);
            this.tableLP_SubMain.TabIndex = 0;
            // 
            // groupB_Input
            // 
            this.groupB_Input.AutoSize = true;
            this.groupB_Input.Controls.Add(this.tableLP_Input);
            this.groupB_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Input.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupB_Input.Location = new System.Drawing.Point(3, 33);
            this.groupB_Input.Name = "groupB_Input";
            this.groupB_Input.Size = new System.Drawing.Size(501, 113);
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
            this.tableLP_Input.Controls.Add(this.comboB_SourceType, 1, 0);
            this.tableLP_Input.Controls.Add(this.lbl_RightSource, 0, 2);
            this.tableLP_Input.Controls.Add(this.lbl_LeftSource, 0, 1);
            this.tableLP_Input.Controls.Add(this.comboB_LeftSource, 1, 1);
            this.tableLP_Input.Controls.Add(this.comboB_RightSource, 1, 2);
            this.tableLP_Input.Controls.Add(this.lbl_SourceType, 0, 0);
            this.tableLP_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Input.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Input.Name = "tableLP_Input";
            this.tableLP_Input.RowCount = 3;
            this.tableLP_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Input.Size = new System.Drawing.Size(495, 87);
            this.tableLP_Input.TabIndex = 0;
            // 
            // comboB_SourceType
            // 
            this.comboB_SourceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_SourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_SourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboB_SourceType.FormattingEnabled = true;
            this.comboB_SourceType.Items.AddRange(new object[] {
            "Image source",
            "Camera source",
            "Video source"});
            this.comboB_SourceType.Location = new System.Drawing.Point(87, 3);
            this.comboB_SourceType.Name = "comboB_SourceType";
            this.comboB_SourceType.Size = new System.Drawing.Size(405, 23);
            this.comboB_SourceType.TabIndex = 7;
            this.comboB_SourceType.SelectedIndexChanged += new System.EventHandler(this.comboB_SourceType_SelectedIndexChanged);
            // 
            // lbl_RightSource
            // 
            this.lbl_RightSource.AutoSize = true;
            this.lbl_RightSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RightSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightSource.Location = new System.Drawing.Point(3, 58);
            this.lbl_RightSource.Name = "lbl_RightSource";
            this.lbl_RightSource.Size = new System.Drawing.Size(78, 29);
            this.lbl_RightSource.TabIndex = 5;
            this.lbl_RightSource.Text = "Right Source";
            this.lbl_RightSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LeftSource
            // 
            this.lbl_LeftSource.AutoSize = true;
            this.lbl_LeftSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LeftSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeftSource.Location = new System.Drawing.Point(3, 29);
            this.lbl_LeftSource.Name = "lbl_LeftSource";
            this.lbl_LeftSource.Size = new System.Drawing.Size(78, 29);
            this.lbl_LeftSource.TabIndex = 4;
            this.lbl_LeftSource.Text = "Left Source";
            this.lbl_LeftSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboB_LeftSource
            // 
            this.comboB_LeftSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_LeftSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_LeftSource.Enabled = false;
            this.comboB_LeftSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboB_LeftSource.FormattingEnabled = true;
            this.comboB_LeftSource.Location = new System.Drawing.Point(87, 32);
            this.comboB_LeftSource.Name = "comboB_LeftSource";
            this.comboB_LeftSource.Size = new System.Drawing.Size(405, 23);
            this.comboB_LeftSource.TabIndex = 0;
            this.comboB_LeftSource.SelectedIndexChanged += new System.EventHandler(this.comboB_LeftSource_SelectedIndexChanged);
            // 
            // comboB_RightSource
            // 
            this.comboB_RightSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_RightSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_RightSource.Enabled = false;
            this.comboB_RightSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboB_RightSource.FormattingEnabled = true;
            this.comboB_RightSource.Location = new System.Drawing.Point(87, 61);
            this.comboB_RightSource.Name = "comboB_RightSource";
            this.comboB_RightSource.Size = new System.Drawing.Size(405, 23);
            this.comboB_RightSource.TabIndex = 1;
            this.comboB_RightSource.SelectedIndexChanged += new System.EventHandler(this.comboB_RightSource_SelectedIndexChanged);
            // 
            // lbl_SourceType
            // 
            this.lbl_SourceType.AutoSize = true;
            this.lbl_SourceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_SourceType.Location = new System.Drawing.Point(3, 0);
            this.lbl_SourceType.Name = "lbl_SourceType";
            this.lbl_SourceType.Size = new System.Drawing.Size(78, 29);
            this.lbl_SourceType.TabIndex = 6;
            this.lbl_SourceType.Text = "Source Type";
            this.lbl_SourceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupB_Models
            // 
            this.groupB_Models.AutoSize = true;
            this.groupB_Models.Controls.Add(this.tableLP_Models);
            this.groupB_Models.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Models.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupB_Models.Location = new System.Drawing.Point(3, 152);
            this.groupB_Models.Name = "groupB_Models";
            this.groupB_Models.Size = new System.Drawing.Size(501, 236);
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
            this.tableLP_Models.Controls.Add(this.listV_LoadedModelData, 2, 1);
            this.tableLP_Models.Controls.Add(this.flowLP_InterButtons, 1, 1);
            this.tableLP_Models.Controls.Add(this.listV_FoundModelData, 0, 1);
            this.tableLP_Models.Controls.Add(this.lbl_leftTitle, 0, 0);
            this.tableLP_Models.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Models.Location = new System.Drawing.Point(3, 23);
            this.tableLP_Models.Name = "tableLP_Models";
            this.tableLP_Models.RowCount = 2;
            this.tableLP_Models.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP_Models.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Models.Size = new System.Drawing.Size(495, 210);
            this.tableLP_Models.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loaded model data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listV_LoadedModelData
            // 
            this.listV_LoadedModelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_LoadedModelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listV_LoadedModelData.Location = new System.Drawing.Point(277, 23);
            this.listV_LoadedModelData.Name = "listV_LoadedModelData";
            this.listV_LoadedModelData.Size = new System.Drawing.Size(215, 184);
            this.listV_LoadedModelData.TabIndex = 2;
            this.listV_LoadedModelData.UseCompatibleStateImageBehavior = false;
            this.listV_LoadedModelData.View = System.Windows.Forms.View.List;
            this.listV_LoadedModelData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listV_LoadedModelData_ItemSelectionChanged);
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
            this.flowLP_InterButtons.Location = new System.Drawing.Point(224, 23);
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
            this.btn_MoveAllRight.Click += new System.EventHandler(this.btn_MoveAllRight_Click);
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.AutoSize = true;
            this.btn_MoveRight.Enabled = false;
            this.btn_MoveRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveRight.Location = new System.Drawing.Point(3, 49);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveRight.Size = new System.Drawing.Size(40, 40);
            this.btn_MoveRight.TabIndex = 1;
            this.btn_MoveRight.Text = ">";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            this.btn_MoveRight.Click += new System.EventHandler(this.btn_MoveRight_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.AutoSize = true;
            this.btn_MoveLeft.Enabled = false;
            this.btn_MoveLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveLeft.Location = new System.Drawing.Point(3, 95);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_MoveLeft.Size = new System.Drawing.Size(40, 40);
            this.btn_MoveLeft.TabIndex = 2;
            this.btn_MoveLeft.Text = "<";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            this.btn_MoveLeft.Click += new System.EventHandler(this.btn_MoveLeft_Click);
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
            this.btn_MoveAllLeft.Click += new System.EventHandler(this.btn_MoveAllLeft_Click);
            // 
            // listV_FoundModelData
            // 
            this.listV_FoundModelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV_FoundModelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listV_FoundModelData.Location = new System.Drawing.Point(3, 23);
            this.listV_FoundModelData.Name = "listV_FoundModelData";
            this.listV_FoundModelData.Size = new System.Drawing.Size(215, 184);
            this.listV_FoundModelData.TabIndex = 1;
            this.listV_FoundModelData.UseCompatibleStateImageBehavior = false;
            this.listV_FoundModelData.View = System.Windows.Forms.View.List;
            this.listV_FoundModelData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listV_FoundModelData_ItemSelectionChanged);
            // 
            // lbl_leftTitle
            // 
            this.lbl_leftTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_leftTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_leftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_leftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftTitle.Location = new System.Drawing.Point(3, 0);
            this.lbl_leftTitle.Name = "lbl_leftTitle";
            this.lbl_leftTitle.Size = new System.Drawing.Size(215, 20);
            this.lbl_leftTitle.TabIndex = 3;
            this.lbl_leftTitle.Text = "Found model data";
            this.lbl_leftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Introduction
            // 
            this.lbl_Introduction.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Introduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Introduction.Location = new System.Drawing.Point(3, 0);
            this.lbl_Introduction.Name = "lbl_Introduction";
            this.lbl_Introduction.Size = new System.Drawing.Size(501, 30);
            this.lbl_Introduction.TabIndex = 2;
            this.lbl_Introduction.Text = "Start up configurations.";
            this.lbl_Introduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLP_Start
            // 
            this.tableLP_Start.AutoSize = true;
            this.tableLP_Start.ColumnCount = 3;
            this.tableLP_Start.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Start.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Start.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Start.Controls.Add(this.btn_Load, 0, 0);
            this.tableLP_Start.Controls.Add(this.btn_Save, 0, 0);
            this.tableLP_Start.Controls.Add(this.btn_Start, 2, 0);
            this.tableLP_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Start.Location = new System.Drawing.Point(3, 394);
            this.tableLP_Start.Name = "tableLP_Start";
            this.tableLP_Start.RowCount = 1;
            this.tableLP_Start.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Start.Size = new System.Drawing.Size(501, 36);
            this.tableLP_Start.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(160, 30);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Start.Location = new System.Drawing.Point(335, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(163, 30);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.ColumnCount = 3;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Main.Controls.Add(this.tableLP_SubMain, 0, 0);
            this.tableLP_Main.Controls.Add(this.tableLP_Summary, 2, 0);
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 1;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Main.Size = new System.Drawing.Size(688, 442);
            this.tableLP_Main.TabIndex = 2;
            // 
            // tableLP_Summary
            // 
            this.tableLP_Summary.ColumnCount = 1;
            this.tableLP_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLP_Summary.Controls.Add(this.groupB_Summary, 0, 0);
            this.tableLP_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Summary.Location = new System.Drawing.Point(517, 3);
            this.tableLP_Summary.Name = "tableLP_Summary";
            this.tableLP_Summary.RowCount = 2;
            this.tableLP_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Summary.Size = new System.Drawing.Size(200, 436);
            this.tableLP_Summary.TabIndex = 1;
            // 
            // groupB_Summary
            // 
            this.groupB_Summary.Controls.Add(this.panel_RichTB);
            this.groupB_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_Summary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_Summary.Location = new System.Drawing.Point(3, 3);
            this.groupB_Summary.Name = "groupB_Summary";
            this.groupB_Summary.Size = new System.Drawing.Size(194, 420);
            this.groupB_Summary.TabIndex = 8;
            this.groupB_Summary.TabStop = false;
            this.groupB_Summary.Text = "Summary";
            // 
            // panel_RichTB
            // 
            this.panel_RichTB.Controls.Add(this.richTextB_Summary);
            this.panel_RichTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RichTB.Location = new System.Drawing.Point(3, 23);
            this.panel_RichTB.Name = "panel_RichTB";
            this.panel_RichTB.Padding = new System.Windows.Forms.Padding(10);
            this.panel_RichTB.Size = new System.Drawing.Size(188, 394);
            this.panel_RichTB.TabIndex = 1;
            // 
            // richTextB_Summary
            // 
            this.richTextB_Summary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextB_Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextB_Summary.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextB_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextB_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.richTextB_Summary.Location = new System.Drawing.Point(10, 10);
            this.richTextB_Summary.Name = "richTextB_Summary";
            this.richTextB_Summary.ReadOnly = true;
            this.richTextB_Summary.Size = new System.Drawing.Size(168, 374);
            this.richTextB_Summary.TabIndex = 0;
            this.richTextB_Summary.Text = "";
            // 
            // btn_Load
            // 
            this.btn_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Load.Location = new System.Drawing.Point(169, 3);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(160, 30);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // StartupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "StartupWindow";
            this.Size = new System.Drawing.Size(688, 442);
            this.Load += new System.EventHandler(this.StartupWindow_Load);
            this.tableLP_SubMain.ResumeLayout(false);
            this.tableLP_SubMain.PerformLayout();
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
            this.tableLP_Main.ResumeLayout(false);
            this.tableLP_Main.PerformLayout();
            this.tableLP_Summary.ResumeLayout(false);
            this.groupB_Summary.ResumeLayout(false);
            this.panel_RichTB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_SubMain;
        private System.Windows.Forms.TableLayoutPanel tableLP_Models;
        private System.Windows.Forms.FlowLayoutPanel flowLP_InterButtons;
        private System.Windows.Forms.Button btn_MoveAllRight;
        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Button btn_MoveAllLeft;
        private System.Windows.Forms.GroupBox groupB_Models;
        private System.Windows.Forms.ListView listV_LoadedModelData;
        private System.Windows.Forms.ListView listV_FoundModelData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_leftTitle;
        private System.Windows.Forms.Label lbl_Introduction;
        private System.Windows.Forms.GroupBox groupB_Input;
        private System.Windows.Forms.TableLayoutPanel tableLP_Input;
        private System.Windows.Forms.ComboBox comboB_LeftSource;
        private System.Windows.Forms.ComboBox comboB_RightSource;
        private System.Windows.Forms.Label lbl_RightSource;
        private System.Windows.Forms.Label lbl_LeftSource;
        private System.Windows.Forms.TableLayoutPanel tableLP_Start;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox comboB_SourceType;
        private System.Windows.Forms.Label lbl_SourceType;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Image;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Video;
        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private System.Windows.Forms.TableLayoutPanel tableLP_Summary;
        private System.Windows.Forms.GroupBox groupB_Summary;
        private System.Windows.Forms.RichTextBox richTextB_Summary;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveStartUp;
        private System.Windows.Forms.Panel panel_RichTB;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Settings;

    }
}
