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
            this.tableLP_Viewers = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_DataViewer = new System.Windows.Forms.GroupBox();
            this.picB_ProjectionViewer = new System.Windows.Forms.PictureBox();
            this.groupB_ModelViewer = new System.Windows.Forms.GroupBox();
            this.modelVC_Model = new CvConsole.ModelViewerControl();
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupB_ModelConsole = new System.Windows.Forms.GroupBox();
            this.tableLP_ModelConsole = new System.Windows.Forms.TableLayoutPanel();
            this.treeV_ModelData = new System.Windows.Forms.TreeView();
            this.tableLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EditInBlender = new System.Windows.Forms.Button();
            this.btn_ResetView = new System.Windows.Forms.Button();
            this.groupB_DisplayMode = new System.Windows.Forms.GroupBox();
            this.tableLP_DisplayMode = new System.Windows.Forms.TableLayoutPanel();
            this.radioB_YawPitchRotation = new System.Windows.Forms.RadioButton();
            this.radioB_Static = new System.Windows.Forms.RadioButton();
            this.radioB_PitchRotation = new System.Windows.Forms.RadioButton();
            this.radioB_YawRotation = new System.Windows.Forms.RadioButton();
            this.menuS_Model = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convexHullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleProjectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_Model = new System.Windows.Forms.OpenFileDialog();
            this.tableLP_Viewers.SuspendLayout();
            this.groupB_DataViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ProjectionViewer)).BeginInit();
            this.groupB_ModelViewer.SuspendLayout();
            this.tableLP_Main.SuspendLayout();
            this.groupB_ModelConsole.SuspendLayout();
            this.tableLP_ModelConsole.SuspendLayout();
            this.tableLP_Buttons.SuspendLayout();
            this.groupB_DisplayMode.SuspendLayout();
            this.tableLP_DisplayMode.SuspendLayout();
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
            this.tableLP_Viewers.Location = new System.Drawing.Point(313, 3);
            this.tableLP_Viewers.Name = "tableLP_Viewers";
            this.tableLP_Viewers.RowCount = 3;
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.16573F));
            this.tableLP_Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.83427F));
            this.tableLP_Viewers.Size = new System.Drawing.Size(305, 552);
            this.tableLP_Viewers.TabIndex = 0;
            // 
            // groupB_DataViewer
            // 
            this.groupB_DataViewer.Controls.Add(this.picB_ProjectionViewer);
            this.groupB_DataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_DataViewer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_DataViewer.Location = new System.Drawing.Point(3, 290);
            this.groupB_DataViewer.Name = "groupB_DataViewer";
            this.groupB_DataViewer.Size = new System.Drawing.Size(299, 259);
            this.groupB_DataViewer.TabIndex = 4;
            this.groupB_DataViewer.TabStop = false;
            this.groupB_DataViewer.Text = "Data Viewer : Convex hull";
            // 
            // picB_ProjectionViewer
            // 
            this.picB_ProjectionViewer.BackColor = System.Drawing.Color.White;
            this.picB_ProjectionViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_ProjectionViewer.Location = new System.Drawing.Point(3, 23);
            this.picB_ProjectionViewer.Name = "picB_ProjectionViewer";
            this.picB_ProjectionViewer.Size = new System.Drawing.Size(293, 233);
            this.picB_ProjectionViewer.TabIndex = 1;
            this.picB_ProjectionViewer.TabStop = false;
            // 
            // groupB_ModelViewer
            // 
            this.groupB_ModelViewer.Controls.Add(this.modelVC_Model);
            this.groupB_ModelViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB_ModelViewer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupB_ModelViewer.Location = new System.Drawing.Point(3, 3);
            this.groupB_ModelViewer.Name = "groupB_ModelViewer";
            this.groupB_ModelViewer.Size = new System.Drawing.Size(299, 281);
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
            this.modelVC_Model.projViewer = null;
            this.modelVC_Model.Size = new System.Drawing.Size(293, 255);
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
            this.tableLP_Main.Size = new System.Drawing.Size(621, 558);
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
            this.groupB_ModelConsole.Size = new System.Drawing.Size(304, 552);
            this.groupB_ModelConsole.TabIndex = 8;
            this.groupB_ModelConsole.TabStop = false;
            this.groupB_ModelConsole.Text = "Model Console";
            // 
            // tableLP_ModelConsole
            // 
            this.tableLP_ModelConsole.ColumnCount = 1;
            this.tableLP_ModelConsole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_ModelConsole.Controls.Add(this.treeV_ModelData, 0, 0);
            this.tableLP_ModelConsole.Controls.Add(this.tableLP_Buttons, 0, 1);
            this.tableLP_ModelConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_ModelConsole.Location = new System.Drawing.Point(3, 47);
            this.tableLP_ModelConsole.Name = "tableLP_ModelConsole";
            this.tableLP_ModelConsole.RowCount = 2;
            this.tableLP_ModelConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.97211F));
            this.tableLP_ModelConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.02789F));
            this.tableLP_ModelConsole.Size = new System.Drawing.Size(298, 502);
            this.tableLP_ModelConsole.TabIndex = 8;
            // 
            // treeV_ModelData
            // 
            this.treeV_ModelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeV_ModelData.Location = new System.Drawing.Point(3, 3);
            this.treeV_ModelData.Name = "treeV_ModelData";
            this.treeV_ModelData.Size = new System.Drawing.Size(292, 279);
            this.treeV_ModelData.TabIndex = 7;
            // 
            // tableLP_Buttons
            // 
            this.tableLP_Buttons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLP_Buttons.ColumnCount = 2;
            this.tableLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Buttons.Controls.Add(this.btn_EditInBlender, 0, 0);
            this.tableLP_Buttons.Controls.Add(this.btn_ResetView, 1, 0);
            this.tableLP_Buttons.Controls.Add(this.groupB_DisplayMode, 0, 1);
            this.tableLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Buttons.Enabled = false;
            this.tableLP_Buttons.Location = new System.Drawing.Point(3, 288);
            this.tableLP_Buttons.Name = "tableLP_Buttons";
            this.tableLP_Buttons.RowCount = 3;
            this.tableLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP_Buttons.Size = new System.Drawing.Size(292, 211);
            this.tableLP_Buttons.TabIndex = 8;
            // 
            // btn_EditInBlender
            // 
            this.btn_EditInBlender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EditInBlender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EditInBlender.Location = new System.Drawing.Point(6, 6);
            this.btn_EditInBlender.Name = "btn_EditInBlender";
            this.btn_EditInBlender.Size = new System.Drawing.Size(135, 23);
            this.btn_EditInBlender.TabIndex = 0;
            this.btn_EditInBlender.Text = "Edit in Blender";
            this.btn_EditInBlender.UseVisualStyleBackColor = true;
            this.btn_EditInBlender.Click += new System.EventHandler(this.btn_EditInBlender_Click);
            // 
            // btn_ResetView
            // 
            this.btn_ResetView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ResetView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ResetView.Location = new System.Drawing.Point(150, 6);
            this.btn_ResetView.Name = "btn_ResetView";
            this.btn_ResetView.Size = new System.Drawing.Size(136, 23);
            this.btn_ResetView.TabIndex = 1;
            this.btn_ResetView.Text = "Reset view";
            this.btn_ResetView.UseVisualStyleBackColor = true;
            this.btn_ResetView.Click += new System.EventHandler(this.btn_ResetView_Click);
            // 
            // groupB_DisplayMode
            // 
            this.groupB_DisplayMode.Controls.Add(this.tableLP_DisplayMode);
            this.groupB_DisplayMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupB_DisplayMode.Location = new System.Drawing.Point(6, 38);
            this.groupB_DisplayMode.Name = "groupB_DisplayMode";
            this.groupB_DisplayMode.Size = new System.Drawing.Size(135, 118);
            this.groupB_DisplayMode.TabIndex = 2;
            this.groupB_DisplayMode.TabStop = false;
            this.groupB_DisplayMode.Text = "Display mode";
            // 
            // tableLP_DisplayMode
            // 
            this.tableLP_DisplayMode.ColumnCount = 1;
            this.tableLP_DisplayMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_DisplayMode.Controls.Add(this.radioB_YawPitchRotation, 0, 3);
            this.tableLP_DisplayMode.Controls.Add(this.radioB_Static, 0, 0);
            this.tableLP_DisplayMode.Controls.Add(this.radioB_PitchRotation, 0, 2);
            this.tableLP_DisplayMode.Controls.Add(this.radioB_YawRotation, 0, 1);
            this.tableLP_DisplayMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_DisplayMode.Location = new System.Drawing.Point(3, 19);
            this.tableLP_DisplayMode.Name = "tableLP_DisplayMode";
            this.tableLP_DisplayMode.RowCount = 4;
            this.tableLP_DisplayMode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_DisplayMode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_DisplayMode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_DisplayMode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLP_DisplayMode.Size = new System.Drawing.Size(129, 96);
            this.tableLP_DisplayMode.TabIndex = 0;
            // 
            // radioB_YawPitchRotation
            // 
            this.radioB_YawPitchRotation.AutoSize = true;
            this.radioB_YawPitchRotation.Location = new System.Drawing.Point(3, 78);
            this.radioB_YawPitchRotation.Name = "radioB_YawPitchRotation";
            this.radioB_YawPitchRotation.Size = new System.Drawing.Size(123, 19);
            this.radioB_YawPitchRotation.TabIndex = 3;
            this.radioB_YawPitchRotation.Text = "yaw/pitch rotation";
            this.radioB_YawPitchRotation.UseVisualStyleBackColor = true;
            this.radioB_YawPitchRotation.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioB_Static
            // 
            this.radioB_Static.AutoSize = true;
            this.radioB_Static.Location = new System.Drawing.Point(3, 3);
            this.radioB_Static.Name = "radioB_Static";
            this.radioB_Static.Size = new System.Drawing.Size(53, 19);
            this.radioB_Static.TabIndex = 0;
            this.radioB_Static.Text = "static";
            this.radioB_Static.UseVisualStyleBackColor = true;
            this.radioB_Static.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioB_PitchRotation
            // 
            this.radioB_PitchRotation.AutoSize = true;
            this.radioB_PitchRotation.Location = new System.Drawing.Point(3, 53);
            this.radioB_PitchRotation.Name = "radioB_PitchRotation";
            this.radioB_PitchRotation.Size = new System.Drawing.Size(97, 19);
            this.radioB_PitchRotation.TabIndex = 2;
            this.radioB_PitchRotation.Text = "pitch rotation";
            this.radioB_PitchRotation.UseVisualStyleBackColor = true;
            this.radioB_PitchRotation.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioB_YawRotation
            // 
            this.radioB_YawRotation.AutoSize = true;
            this.radioB_YawRotation.Checked = true;
            this.radioB_YawRotation.Location = new System.Drawing.Point(3, 28);
            this.radioB_YawRotation.Name = "radioB_YawRotation";
            this.radioB_YawRotation.Size = new System.Drawing.Size(91, 19);
            this.radioB_YawRotation.TabIndex = 1;
            this.radioB_YawRotation.TabStop = true;
            this.radioB_YawRotation.Text = "yaw rotation";
            this.radioB_YawRotation.UseVisualStyleBackColor = true;
            this.radioB_YawRotation.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // menuS_Model
            // 
            this.menuS_Model.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuS_Model.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuS_Model.Location = new System.Drawing.Point(3, 23);
            this.menuS_Model.Name = "menuS_Model";
            this.menuS_Model.Size = new System.Drawing.Size(298, 24);
            this.menuS_Model.TabIndex = 6;
            this.menuS_Model.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fileToolStripMenuItem.Text = "&Load model";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.LoadModelToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convexHullToolStripMenuItem,
            this.simpleProjectionToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.viewToolStripMenuItem.Text = "&Data viewer";
            // 
            // convexHullToolStripMenuItem
            // 
            this.convexHullToolStripMenuItem.Checked = true;
            this.convexHullToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convexHullToolStripMenuItem.Name = "convexHullToolStripMenuItem";
            this.convexHullToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.convexHullToolStripMenuItem.Text = "&Convex hull";
            // 
            // simpleProjectionToolStripMenuItem
            // 
            this.simpleProjectionToolStripMenuItem.Name = "simpleProjectionToolStripMenuItem";
            this.simpleProjectionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.simpleProjectionToolStripMenuItem.Text = "&Simple projection";
            // 
            // ModelsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "ModelsWindow";
            this.Size = new System.Drawing.Size(621, 558);
            this.tableLP_Viewers.ResumeLayout(false);
            this.groupB_DataViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ProjectionViewer)).EndInit();
            this.groupB_ModelViewer.ResumeLayout(false);
            this.tableLP_Main.ResumeLayout(false);
            this.groupB_ModelConsole.ResumeLayout(false);
            this.groupB_ModelConsole.PerformLayout();
            this.tableLP_ModelConsole.ResumeLayout(false);
            this.tableLP_Buttons.ResumeLayout(false);
            this.groupB_DisplayMode.ResumeLayout(false);
            this.tableLP_DisplayMode.ResumeLayout(false);
            this.tableLP_DisplayMode.PerformLayout();
            this.menuS_Model.ResumeLayout(false);
            this.menuS_Model.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Viewers;
        private ModelViewerControl modelVC_Model;
        private System.Windows.Forms.GroupBox groupB_ModelViewer;
        private System.Windows.Forms.GroupBox groupB_DataViewer;
        private System.Windows.Forms.PictureBox picB_ProjectionViewer;
        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
        private System.Windows.Forms.GroupBox groupB_ModelConsole;
        private System.Windows.Forms.MenuStrip menuS_Model;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Model;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TreeView treeV_ModelData;
        private System.Windows.Forms.ToolStripMenuItem convexHullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleProjectionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLP_ModelConsole;
        private System.Windows.Forms.TableLayoutPanel tableLP_Buttons;
        private System.Windows.Forms.Button btn_EditInBlender;
        private System.Windows.Forms.Button btn_ResetView;
        private System.Windows.Forms.GroupBox groupB_DisplayMode;
        private System.Windows.Forms.RadioButton radioB_Static;
        private System.Windows.Forms.RadioButton radioB_YawRotation;
        private System.Windows.Forms.RadioButton radioB_PitchRotation;
        private System.Windows.Forms.RadioButton radioB_YawPitchRotation;
        private System.Windows.Forms.TableLayoutPanel tableLP_DisplayMode;
    }
}
