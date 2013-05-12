namespace CvConsole
{
    partial class ModelsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelsWindow));
            this.tableLP_Viewers = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_DataViewer = new System.Windows.Forms.GroupBox();
            this.picB_ModelData2Viewer = new System.Windows.Forms.PictureBox();
            this.groupB_ModelViewer = new System.Windows.Forms.GroupBox();
            this.modelVC_Model = new CvModelSystem.ModelViewerControl();
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_ModelConsole = new System.Windows.Forms.GroupBox();
            this.tableLP_ModelConsole = new System.Windows.Forms.TableLayoutPanel();
            this.tableLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_DisplayOptions = new System.Windows.Forms.GroupBox();
            this.checkedLB_DisplayOptions = new System.Windows.Forms.CheckedListBox();
            this.btn_EditInBlender = new System.Windows.Forms.Button();
            this.btn_ResetStage = new System.Windows.Forms.Button();
            this.groupB_DisplayMode = new System.Windows.Forms.GroupBox();
            this.flowLP_Controls = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.comboBox_DisplayMode = new System.Windows.Forms.ComboBox();
            this.splitContainer_TreeListView = new System.Windows.Forms.SplitContainer();
            this.treeView_ModelData2 = new System.Windows.Forms.TreeView();
            this.listView_ModelData2 = new System.Windows.Forms.ListView();
            this.columnHeader_dataName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dataContext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuS_Model = new System.Windows.Forms.MenuStrip();
            this.loadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convexHullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendToExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_Model = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_ExportXml = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_ExportXml = new System.Windows.Forms.OpenFileDialog();
            this.tmr_NextPrevious = new System.Windows.Forms.Timer(this.components);
            this.tableLP_Viewers.SuspendLayout();
            this.groupB_DataViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ModelData2Viewer)).BeginInit();
            this.groupB_ModelViewer.SuspendLayout();
            this.tableLP_Main.SuspendLayout();
            this.groupB_ModelConsole.SuspendLayout();
            this.tableLP_ModelConsole.SuspendLayout();
            this.tableLP_Buttons.SuspendLayout();
            this.groupB_DisplayOptions.SuspendLayout();
            this.groupB_DisplayMode.SuspendLayout();
            this.flowLP_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TreeListView)).BeginInit();
            this.splitContainer_TreeListView.Panel1.SuspendLayout();
            this.splitContainer_TreeListView.Panel2.SuspendLayout();
            this.splitContainer_TreeListView.SuspendLayout();
            this.menuS_Model.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_Viewers
            // 
            this.tableLP_Viewers.ColumnCount = 1;
            this.tableLP_Viewers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Viewers.Controls.Add(this.groupB_DataViewer, 0, 2);
            this.tableLP_Viewers.Controls.Add(this.groupB_ModelViewer, 0, 1);
            this.tableLP_Viewers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Viewers.Location = new System.Drawing.Point(367, 3);
            this.tableLP_Viewers.Name = "tableLP_Viewers";
            this.tableLP_Viewers.RowCount = 3;
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.16573F));
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.83427F));
            this.tableLP_Viewers.Size = new System.Drawing.Size(359, 552);
            this.tableLP_Viewers.TabIndex = 0;
            // 
            // groupB_DataViewer
            // 
            this.groupB_DataViewer.Controls.Add(this.picB_ModelData2Viewer);
            this.groupB_DataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_DataViewer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_DataViewer.Location = new System.Drawing.Point(3, 290);
            this.groupB_DataViewer.Name = "groupB_DataViewer";
            this.groupB_DataViewer.Size = new System.Drawing.Size(353, 259);
            this.groupB_DataViewer.TabIndex = 4;
            this.groupB_DataViewer.TabStop = false;
            this.groupB_DataViewer.Text = "Convex hull";
            // 
            // picB_ModelData2Viewer
            // 
            this.picB_ModelData2Viewer.BackColor = System.Drawing.Color.White;
            this.picB_ModelData2Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_ModelData2Viewer.Location = new System.Drawing.Point(3, 23);
            this.picB_ModelData2Viewer.Name = "picB_ModelData2Viewer";
            this.picB_ModelData2Viewer.Size = new System.Drawing.Size(347, 233);
            this.picB_ModelData2Viewer.TabIndex = 1;
            this.picB_ModelData2Viewer.TabStop = false;
            // 
            // groupB_ModelViewer
            // 
            this.groupB_ModelViewer.Controls.Add(this.modelVC_Model);
            this.groupB_ModelViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_ModelViewer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_ModelViewer.Location = new System.Drawing.Point(3, 3);
            this.groupB_ModelViewer.Name = "groupB_ModelViewer";
            this.groupB_ModelViewer.Size = new System.Drawing.Size(353, 281);
            this.groupB_ModelViewer.TabIndex = 2;
            this.groupB_ModelViewer.TabStop = false;
            this.groupB_ModelViewer.Text = "Model Viewer";
            // 
            // modelVC_Model
            // 
            this.modelVC_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelVC_Model.Location = new System.Drawing.Point(3, 23);
            this.modelVC_Model.Model = null;
            this.modelVC_Model.Name = "modelVC_Model";
            this.modelVC_Model.Size = new System.Drawing.Size(347, 255);
            this.modelVC_Model.TabIndex = 0;
            this.modelVC_Model.Text = "ModelViewerControl";
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.ColumnCount = 2;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Main.Controls.Add(this.groupB_ModelConsole, 0, 0);
            this.tableLP_Main.Controls.Add(this.tableLP_Viewers, 1, 0);
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 1;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_Main.Size = new System.Drawing.Size(729, 558);
            this.tableLP_Main.TabIndex = 1;
            // 
            // groupB_ModelConsole
            // 
            this.groupB_ModelConsole.Controls.Add(this.tableLP_ModelConsole);
            this.groupB_ModelConsole.Controls.Add(this.menuS_Model);
            this.groupB_ModelConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_ModelConsole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_ModelConsole.Location = new System.Drawing.Point(3, 3);
            this.groupB_ModelConsole.Name = "groupB_ModelConsole";
            this.groupB_ModelConsole.Size = new System.Drawing.Size(358, 552);
            this.groupB_ModelConsole.TabIndex = 8;
            this.groupB_ModelConsole.TabStop = false;
            this.groupB_ModelConsole.Text = "Model Console";
            // 
            // tableLP_ModelConsole
            // 
            this.tableLP_ModelConsole.ColumnCount = 1;
            this.tableLP_ModelConsole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_ModelConsole.Controls.Add(this.tableLP_Buttons, 0, 1);
            this.tableLP_ModelConsole.Controls.Add(this.splitContainer_TreeListView, 0, 0);
            this.tableLP_ModelConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_ModelConsole.Location = new System.Drawing.Point(3, 47);
            this.tableLP_ModelConsole.Name = "tableLP_ModelConsole";
            this.tableLP_ModelConsole.RowCount = 2;
            this.tableLP_ModelConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.52589F));
            this.tableLP_ModelConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.4741F));
            this.tableLP_ModelConsole.Size = new System.Drawing.Size(352, 502);
            this.tableLP_ModelConsole.TabIndex = 8;
            // 
            // tableLP_Buttons
            // 
            this.tableLP_Buttons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLP_Buttons.ColumnCount = 2;
            this.tableLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Buttons.Controls.Add(this.groupB_DisplayOptions, 1, 1);
            this.tableLP_Buttons.Controls.Add(this.btn_EditInBlender, 0, 0);
            this.tableLP_Buttons.Controls.Add(this.btn_ResetStage, 1, 0);
            this.tableLP_Buttons.Controls.Add(this.groupB_DisplayMode, 0, 1);
            this.tableLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Buttons.Enabled = false;
            this.tableLP_Buttons.Location = new System.Drawing.Point(3, 347);
            this.tableLP_Buttons.Name = "tableLP_Buttons";
            this.tableLP_Buttons.RowCount = 2;
            this.tableLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Buttons.Size = new System.Drawing.Size(346, 152);
            this.tableLP_Buttons.TabIndex = 8;
            // 
            // groupB_DisplayOptions
            // 
            this.groupB_DisplayOptions.Controls.Add(this.checkedLB_DisplayOptions);
            this.groupB_DisplayOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_DisplayOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupB_DisplayOptions.Location = new System.Drawing.Point(177, 38);
            this.groupB_DisplayOptions.Name = "groupB_DisplayOptions";
            this.groupB_DisplayOptions.Size = new System.Drawing.Size(163, 109);
            this.groupB_DisplayOptions.TabIndex = 3;
            this.groupB_DisplayOptions.TabStop = false;
            this.groupB_DisplayOptions.Text = "Display options";
            // 
            // checkedLB_DisplayOptions
            // 
            this.checkedLB_DisplayOptions.CheckOnClick = true;
            this.checkedLB_DisplayOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedLB_DisplayOptions.FormattingEnabled = true;
            this.checkedLB_DisplayOptions.Items.AddRange(new object[] {
            "Display vertice\'s coordinate",
            "Fill faces with their color (Diffused color)"});
            this.checkedLB_DisplayOptions.Location = new System.Drawing.Point(3, 19);
            this.checkedLB_DisplayOptions.Name = "checkedLB_DisplayOptions";
            this.checkedLB_DisplayOptions.Size = new System.Drawing.Size(157, 40);
            this.checkedLB_DisplayOptions.TabIndex = 0;
            this.checkedLB_DisplayOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedLB_DisplayOptions_ItemCheck);
            // 
            // btn_EditInBlender
            // 
            this.btn_EditInBlender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EditInBlender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EditInBlender.Location = new System.Drawing.Point(6, 6);
            this.btn_EditInBlender.Name = "btn_EditInBlender";
            this.btn_EditInBlender.Size = new System.Drawing.Size(162, 23);
            this.btn_EditInBlender.TabIndex = 0;
            this.btn_EditInBlender.Text = "Edit in Blender";
            this.btn_EditInBlender.UseVisualStyleBackColor = true;
            this.btn_EditInBlender.Click += new System.EventHandler(this.btn_EditInBlender_Click);
            // 
            // btn_ResetStage
            // 
            this.btn_ResetStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ResetStage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ResetStage.Location = new System.Drawing.Point(177, 6);
            this.btn_ResetStage.Name = "btn_ResetStage";
            this.btn_ResetStage.Size = new System.Drawing.Size(163, 23);
            this.btn_ResetStage.TabIndex = 1;
            this.btn_ResetStage.Text = "Reset stage";
            this.btn_ResetStage.UseVisualStyleBackColor = true;
            this.btn_ResetStage.Click += new System.EventHandler(this.btn_ResetView_Click);
            // 
            // groupB_DisplayMode
            // 
            this.groupB_DisplayMode.Controls.Add(this.flowLP_Controls);
            this.groupB_DisplayMode.Controls.Add(this.comboBox_DisplayMode);
            this.groupB_DisplayMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_DisplayMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupB_DisplayMode.Location = new System.Drawing.Point(6, 38);
            this.groupB_DisplayMode.Name = "groupB_DisplayMode";
            this.groupB_DisplayMode.Size = new System.Drawing.Size(162, 109);
            this.groupB_DisplayMode.TabIndex = 2;
            this.groupB_DisplayMode.TabStop = false;
            this.groupB_DisplayMode.Text = "Display mode: Model";
            // 
            // flowLP_Controls
            // 
            this.flowLP_Controls.Controls.Add(this.btn_Run);
            this.flowLP_Controls.Controls.Add(this.btn_Pause);
            this.flowLP_Controls.Controls.Add(this.btn_Previous);
            this.flowLP_Controls.Controls.Add(this.btn_Next);
            this.flowLP_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLP_Controls.Location = new System.Drawing.Point(3, 42);
            this.flowLP_Controls.Name = "flowLP_Controls";
            this.flowLP_Controls.Size = new System.Drawing.Size(156, 37);
            this.flowLP_Controls.TabIndex = 1;
            this.flowLP_Controls.EnabledChanged += new System.EventHandler(this.flowLP_Controls_EnabledChanged);
            // 
            // btn_Run
            // 
            this.btn_Run.Image = ((System.Drawing.Image)(resources.GetObject("btn_Run.Image")));
            this.btn_Run.Location = new System.Drawing.Point(3, 3);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(27, 29);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pause.Image")));
            this.btn_Pause.Location = new System.Drawing.Point(36, 3);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(27, 29);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_Previous.Image")));
            this.btn_Previous.Location = new System.Drawing.Point(69, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(30, 29);
            this.btn_Previous.TabIndex = 3;
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Previous_MouseDown);
            this.btn_Previous.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Previous_MouseUp);
            // 
            // btn_Next
            // 
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.Location = new System.Drawing.Point(105, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(30, 29);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Next_MouseDown);
            this.btn_Next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Next_MouseUp);
            // 
            // comboBox_DisplayMode
            // 
            this.comboBox_DisplayMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_DisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DisplayMode.FormattingEnabled = true;
            this.comboBox_DisplayMode.Location = new System.Drawing.Point(3, 19);
            this.comboBox_DisplayMode.Name = "comboBox_DisplayMode";
            this.comboBox_DisplayMode.Size = new System.Drawing.Size(156, 23);
            this.comboBox_DisplayMode.TabIndex = 0;
            this.comboBox_DisplayMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_DisplayMode_SelectedIndexChanged);
            // 
            // splitContainer_TreeListView
            // 
            this.splitContainer_TreeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_TreeListView.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_TreeListView.Name = "splitContainer_TreeListView";
            // 
            // splitContainer_TreeListView.Panel1
            // 
            this.splitContainer_TreeListView.Panel1.Controls.Add(this.treeView_ModelData2);
            // 
            // splitContainer_TreeListView.Panel2
            // 
            this.splitContainer_TreeListView.Panel2.Controls.Add(this.listView_ModelData2);
            this.splitContainer_TreeListView.Size = new System.Drawing.Size(346, 338);
            this.splitContainer_TreeListView.SplitterDistance = 170;
            this.splitContainer_TreeListView.TabIndex = 9;
            // 
            // treeView_ModelData2
            // 
            this.treeView_ModelData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_ModelData2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_ModelData2.Location = new System.Drawing.Point(0, 0);
            this.treeView_ModelData2.Name = "treeView_ModelData2";
            this.treeView_ModelData2.Size = new System.Drawing.Size(170, 338);
            this.treeView_ModelData2.TabIndex = 8;
            this.treeView_ModelData2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_ModelData2_NodeMouseClick);
            // 
            // listView_ModelData2
            // 
            this.listView_ModelData2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_dataName,
            this.columnHeader_dataContext});
            this.listView_ModelData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ModelData2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ModelData2.Location = new System.Drawing.Point(0, 0);
            this.listView_ModelData2.Name = "listView_ModelData2";
            this.listView_ModelData2.Size = new System.Drawing.Size(172, 338);
            this.listView_ModelData2.TabIndex = 9;
            this.listView_ModelData2.UseCompatibleStateImageBehavior = false;
            this.listView_ModelData2.View = System.Windows.Forms.View.Details;
            this.listView_ModelData2.Resize += new System.EventHandler(this.listView_ModelData2_Resize);
            // 
            // columnHeader_dataName
            // 
            this.columnHeader_dataName.Text = "Name";
            this.columnHeader_dataName.Width = 80;
            // 
            // columnHeader_dataContext
            // 
            this.columnHeader_dataContext.Text = "Context";
            this.columnHeader_dataContext.Width = 87;
            // 
            // menuS_Model
            // 
            this.menuS_Model.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuS_Model.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModelToolStripMenuItem,
            this.dataViewerToolStripMenuItem,
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem});
            this.menuS_Model.Location = new System.Drawing.Point(3, 23);
            this.menuS_Model.Name = "menuS_Model";
            this.menuS_Model.Size = new System.Drawing.Size(352, 24);
            this.menuS_Model.TabIndex = 6;
            this.menuS_Model.Text = "menuStrip1";
            // 
            // loadModelToolStripMenuItem
            // 
            this.loadModelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadModelToolStripMenuItem.Name = "loadModelToolStripMenuItem";
            this.loadModelToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadModelToolStripMenuItem.Text = "&Load model";
            this.loadModelToolStripMenuItem.Click += new System.EventHandler(this.LoadModelToolStripMenuItem_Click);
            // 
            // dataViewerToolStripMenuItem
            // 
            this.dataViewerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convexHullToolStripMenuItem});
            this.dataViewerToolStripMenuItem.Name = "dataViewerToolStripMenuItem";
            this.dataViewerToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dataViewerToolStripMenuItem.Text = "&Data viewer";
            // 
            // convexHullToolStripMenuItem
            // 
            this.convexHullToolStripMenuItem.Checked = true;
            this.convexHullToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convexHullToolStripMenuItem.Name = "convexHullToolStripMenuItem";
            this.convexHullToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.convexHullToolStripMenuItem.Text = "&Convex hull";
            this.convexHullToolStripMenuItem.Click += new System.EventHandler(this.DataViewToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCurrentViewToolStripMenuItem});
            this.exportXMLToolStripMenuItem.Enabled = false;
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exportXMLToolStripMenuItem.Text = "&Export XML";
            // 
            // exportCurrentViewToolStripMenuItem
            // 
            this.exportCurrentViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.appendToExistingToolStripMenuItem});
            this.exportCurrentViewToolStripMenuItem.Name = "exportCurrentViewToolStripMenuItem";
            this.exportCurrentViewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exportCurrentViewToolStripMenuItem.Text = "Export &Current view";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.exportXmlCurrentNewToolStripMenuItem_Click);
            // 
            // appendToExistingToolStripMenuItem
            // 
            this.appendToExistingToolStripMenuItem.Name = "appendToExistingToolStripMenuItem";
            this.appendToExistingToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.appendToExistingToolStripMenuItem.Text = "&Append to existing";
            this.appendToExistingToolStripMenuItem.Click += new System.EventHandler(this.exportXmlCurrentAppendToExistingToolStripMenuItem_Click);
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.importXMLToolStripMenuItem.Text = "&Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXmlToolStripMenuItem_Click);
            // 
            // openFileDialog_ExportXml
            // 
            this.openFileDialog_ExportXml.FileName = "openFileDialog1";
            // 
            // tmr_NextPrevious
            // 
            this.tmr_NextPrevious.Interval = 20;
            this.tmr_NextPrevious.Tick += new System.EventHandler(this.tmr_NextPrevious_Tick);
            // 
            // ModelsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "ModelsWindow";
            this.Size = new System.Drawing.Size(729, 558);
            this.tableLP_Viewers.ResumeLayout(false);
            this.groupB_DataViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ModelData2Viewer)).EndInit();
            this.groupB_ModelViewer.ResumeLayout(false);
            this.tableLP_Main.ResumeLayout(false);
            this.groupB_ModelConsole.ResumeLayout(false);
            this.groupB_ModelConsole.PerformLayout();
            this.tableLP_ModelConsole.ResumeLayout(false);
            this.tableLP_Buttons.ResumeLayout(false);
            this.groupB_DisplayOptions.ResumeLayout(false);
            this.groupB_DisplayMode.ResumeLayout(false);
            this.flowLP_Controls.ResumeLayout(false);
            this.splitContainer_TreeListView.Panel1.ResumeLayout(false);
            this.splitContainer_TreeListView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TreeListView)).EndInit();
            this.splitContainer_TreeListView.ResumeLayout(false);
            this.menuS_Model.ResumeLayout(false);
            this.menuS_Model.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Viewers;
        private CvModelSystem.ModelViewerControl modelVC_Model;
        private System.Windows.Forms.GroupBox groupB_ModelViewer;
        private System.Windows.Forms.GroupBox groupB_DataViewer;
        private System.Windows.Forms.PictureBox picB_ModelData2Viewer;
        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private System.Windows.Forms.GroupBox groupB_ModelConsole;
        private System.Windows.Forms.MenuStrip menuS_Model;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Model;
        private System.Windows.Forms.ToolStripMenuItem dataViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convexHullToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLP_ModelConsole;
        private System.Windows.Forms.TableLayoutPanel tableLP_Buttons;
        private System.Windows.Forms.Button btn_EditInBlender;
        private System.Windows.Forms.Button btn_ResetStage;
        private System.Windows.Forms.GroupBox groupB_DisplayMode;
        private System.Windows.Forms.GroupBox groupB_DisplayOptions;
        private System.Windows.Forms.CheckedListBox checkedLB_DisplayOptions;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentViewToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ExportXml;
        private System.Windows.Forms.ToolStripMenuItem loadModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_DisplayMode;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendToExistingToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ExportXml;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.FlowLayoutPanel flowLP_Controls;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Timer tmr_NextPrevious;
        private System.Windows.Forms.SplitContainer splitContainer_TreeListView;
        private System.Windows.Forms.TreeView treeView_ModelData2;
        private System.Windows.Forms.ListView listView_ModelData2;
        private System.Windows.Forms.ColumnHeader columnHeader_dataName;
        private System.Windows.Forms.ColumnHeader columnHeader_dataContext;
    }
}
