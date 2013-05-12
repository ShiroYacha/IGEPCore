using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MIConvexHull;
using Emgu.CV.Structure;

using CvModelSystem;
using CvModelSystem.Structure;

namespace CvConsole
{
    enum RunningStatus { Manual,OnRun,OnPause,OnNext,OnPrevious};

    public partial class ModelsWindow : UserControl
    {
        private BasicModelStage modelStage;
        private IModelData2Generator generator;
        private IModelData2Projecter projecter;
        private IModelData3Extractor extractor;

        private ContentBuilder contentBuilder;
        private ContentManager contentManager;

        private ColorModelData2 currentModelData2;
        private ModelDataList<ColorConvexHull2> currentDataList;
        private int selectedIndexFromDataList;
        private string lastNodeKey;

        private string modelPath;

        private RunningStatus runningStatus;

        private bool showVertices;
        private bool fillFaceColor;

        public ModelsWindow()
        {
            InitializeComponent();
            // Initialize content builder
            contentBuilder = new ContentBuilder();
            contentManager = new ContentManager(modelVC_Model.Services,
                                                contentBuilder.OutputDirectory);
            // Model system initialization
            projecter = new DirectProjecter();
            extractor = new TriangularExtractor();
            generator = new ConvexHull2Generator();

            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            modelVC_Model.Invalidate();
            picB_ModelData2Viewer.Invalidate();
        }

        private void LoadModel(string fileName)
        {
            Cursor = Cursors.WaitCursor;
            // Unload any existing model.
            UnloadModel();
            // Tell the ContentBuilder what to build.
            contentBuilder.Clear();
            contentBuilder.Add(fileName, "Model", null, "ModelProcessor");
            // Build this new model data.
            string buildError = contentBuilder.Build();
            if (string.IsNullOrEmpty(buildError))
            {
                // If the build succeeded, use the ContentManager to
                // load the temporary .xnb file that we just created.
                modelVC_Model.Model = contentManager.Load<Model>("Model");
                // Set projection handler
            }
            else
            {
                // If the build failed, display an error message.
                MessageBox.Show(buildError, "Error");
            }
            Cursor = Cursors.Arrow;
            // Activate console buttons if not activated
            if (!tableLP_Buttons.Enabled) tableLP_Buttons.Enabled = true;
            if (!exportXMLToolStripMenuItem.Enabled) exportXMLToolStripMenuItem.Enabled = true;
            if (!importXMLToolStripMenuItem.Enabled) importXMLToolStripMenuItem.Enabled = true;
        }

        private void UnloadModel()
        {
            if (modelStage != null)
            {
                modelStage.DisposeStage();
                picB_ModelData2Viewer.Paint -= OnModelData2PaintFromModel;
            }
            modelVC_Model.Model = null;
            contentManager.Unload();
            // Desable console buttons if activated
            if (tableLP_Buttons.Enabled) tableLP_Buttons.Enabled = false;
            if (exportXMLToolStripMenuItem.Enabled) exportXMLToolStripMenuItem.Enabled = false;
            if (importXMLToolStripMenuItem.Enabled) importXMLToolStripMenuItem.Enabled = false;
      
        }

        private void GenerateModelData2()
        {
            ColorModelData3 modelData3=extractor.ExtractModelData(modelStage);
            ColorModelData2 projModelData2 = projecter.Project(modelData3, modelStage, modelVC_Model.GraphicsDevice.Viewport);
            currentModelData2 = generator.Generate(projModelData2);
        }

        private void OnModelData2PaintFromModel(object sender, PaintEventArgs e)
        {
            GenerateModelData2();
            currentModelData2.Draw(e, showVertices, fillFaceColor);
            currentModelData2.ModelPath = modelPath;
            currentModelData2.ObjectName = "Convex hull of <" + Path.GetFileName(modelPath) + ">";
            currentModelData2.Description = "Convex hull of the model.";
            currentModelData2.ComponentAdapter = new TreeAndListViewAdapter(currentModelData2, treeView_ModelData2, listView_ModelData2, lastNodeKey);
            currentModelData2.ComponentAdapter.BuildTree();

        }

        private void OnModelData2PaintFromXml(object sender, PaintEventArgs e)
        {
            currentModelData2.Draw(e, showVertices, fillFaceColor);
        }

        #region Model menu event handlers
        private void LoadModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Default to the directory which contains our content files.
            openFileDialog_Model.Title = "Load Model";
            openFileDialog_Model.Filter = "Model Files (*.fbx;*.x)|*.fbx;*.x|" +
                                "FBX Files (*.fbx)|*.fbx|" +
                                "X Files (*.x)|*.x|" +
                                "All Files (*.*)|*.*";
            openFileDialog_Model.InitialDirectory = StaticResources.GetFolderPathFromBin("Models");
            if (openFileDialog_Model.ShowDialog() == DialogResult.OK)
            {
                modelPath = openFileDialog_Model.FileName;
                LoadModel(modelPath);
                picB_ModelData2Viewer.Paint += OnModelData2PaintFromModel;
                // Setup display mode to "From model"
                groupB_DisplayMode.Text = "Display mode: Model";
                groupB_DataViewer.Text = "Convex Hull";
                comboBox_DisplayMode.DataSource = new string[] { "Manual", "YawRotating", "PitchRotating"};
                btn_EditInBlender.Enabled = true;
                btn_ResetStage.Enabled = true;
                // Set init display mode (create model stage)
                comboBox_DisplayMode.SelectedItem = "YawRotating";
                // Set init check box to check 
                for (int i = 0; i < checkedLB_DisplayOptions.Items.Count; i++)
                    checkedLB_DisplayOptions.SetItemChecked(i, true);
                // Handle model viewer events
                modelVC_Model.MouseUp += (s, ex) =>
                {
                    // Dispay tree and list view
                    currentModelData2.ComponentAdapter.DiscoveryComponentTreeNode();
                };
            }
        }
        private void DataViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem checkedItem = sender as ToolStripMenuItem;
            // Uncheck all elements
            foreach (ToolStripMenuItem item in dataViewerToolStripMenuItem.DropDownItems)
                item.Checked = false;
            // Check correct element 
            checkedItem.Checked = true;

        }
        private void exportXmlCurrentNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog_ExportXml.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog_ExportXml.Title = "Save an Xml File";
            saveFileDialog_ExportXml.InitialDirectory = StaticResources.GetFolderPathFromBin("Models","ModelDataXml");
            if (saveFileDialog_ExportXml.ShowDialog() == DialogResult.OK)
            {
                ModelDataList<ColorConvexHull2> dataList = new ModelDataList<ColorConvexHull2>(saveFileDialog_ExportXml.FileName);
                dataList.AddModel((ColorConvexHull2)currentModelData2);
                dataList.SaveToXml(saveFileDialog_ExportXml.FileName);
                MessageBox.Show("Save done.", "Export Xml");
            }
        }
        private void exportXmlCurrentAppendToExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_ExportXml.Filter = "XML files (*.xml)|*.xml";
            openFileDialog_ExportXml.Title = "Append to an Xml File";
            openFileDialog_ExportXml.InitialDirectory = StaticResources.GetFolderPathFromBin("Models", "ModelDataXml");
            if (openFileDialog_ExportXml.ShowDialog() == DialogResult.OK)
            {
                // Deserialize to get objects
                ModelDataList<ColorConvexHull2> dataList = ModelDataList<ColorConvexHull2>.CreateListFromXml(openFileDialog_ExportXml.FileName);
                // Generate new model data
                ColorConvexHull2 newModelData = (ColorConvexHull2)currentModelData2;
                dataList.AddModel(newModelData);
                dataList.SaveToXml(openFileDialog_ExportXml.FileName);
                MessageBox.Show("Save done.", "Export Xml");
            }
        }
        private void importXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_ExportXml.Filter = "XML files (*.xml)|*.xml";
            openFileDialog_ExportXml.Title = "Append to a Xml File";
            openFileDialog_ExportXml.InitialDirectory = StaticResources.GetFolderPathFromBin("Models", "ModelDataXml");
            if (openFileDialog_ExportXml.ShowDialog() == DialogResult.OK)
            {
                // Deserialize to get objects
                currentDataList = ModelDataList<ColorConvexHull2>.CreateListFromXml(openFileDialog_ExportXml.FileName);
                // Setup display mode to "From xml"
                groupB_DisplayMode.Text = "Display mode: XML";
                comboBox_DisplayMode.DataSource = new string[] { "View XML" };
                // Load and display model
                UnloadModel();
                LoadModel(currentDataList.DataList[0].ModelPath);
                modelStage = new YawPitchRowRotatingModelStage(modelVC_Model.Model, modelVC_Model.defaultInitStatus, 10, MathHelper.Pi / 360.0f, 0, 0);
                modelStage.ModelViewerControl = modelVC_Model;
                // Init other controls
                importXMLToolStripMenuItem.Enabled = true;
                exportXMLToolStripMenuItem.Enabled = false;
                tableLP_Buttons.Enabled = true;
                flowLP_Controls.Enabled = true;
                btn_EditInBlender.Enabled = false;
                btn_ResetStage.Enabled = false;
                btn_Run.Enabled = false;
                btn_Pause.Enabled = false;
                btn_Next.Enabled = true;
                btn_Previous.Enabled = true;
                // Set projection handler
                picB_ModelData2Viewer.Paint += OnModelData2PaintFromXml;
                // Set init display mode (create model stage)
                comboBox_DisplayMode.SelectedItem = "View XML";
                // Set init check box to check 
                for (int i = 0; i < checkedLB_DisplayOptions.Items.Count; i++)
                    checkedLB_DisplayOptions.SetItemChecked(i, true);
                // Init data list
                selectedIndexFromDataList = 0;
                // Notify changes
                notifyImportXml();
            }
        }
        #endregion

        #region Model console button event handlers
        private void btn_EditInBlender_Click(object sender, EventArgs e)
        {
            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = "";
            // Enter the executable to run, including the complete path
            string modelName=modelPath.Substring(modelPath.LastIndexOf("\\"));
            string modelNameNoExt = modelName.Remove(modelName.IndexOf(".")); // Remove extension
            string path=modelPath.Replace(modelName,modelNameNoExt + ".blend");
            start.FileName = path;
            // Do not show console
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            // Run the external process & wait for it to finish
            if (File.Exists(path))
            {
                using (Process proc = Process.Start(start))
                {
                    proc.WaitForExit();
                }
                // Reload modified initStageEffect
                LoadModel(modelPath);
            }
            else
                MessageBox.Show("Blend file not found.", "Error");
        }
        private void btn_ResetView_Click(object sender, EventArgs e)
        {
            modelStage.ResetStage();
        }
        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            //if(radioB_Static.Checked)
            //    modelVC_Model.DisplayMode=DisplayMode.Static;
            //else if(radioB_YawRotation.Checked)
            //    modelVC_Model.DisplayMode=DisplayMode.YawRotation;
            //else if(radioB_PitchRotation.Checked)
            //    modelVC_Model.DisplayMode = DisplayMode.PitchRotation;
            //else
            //    modelVC_Model.DisplayMode = DisplayMode.YawPitchRotation;
        }
        private void checkedLB_DisplayOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    if (e.NewValue == CheckState.Checked)
                        showVertices = true;
                    else showVertices = false;
                    break;
                case 1:
                    if (e.NewValue == CheckState.Checked)
                        fillFaceColor = true;
                    else fillFaceColor = false;
                    break;
            }
        }
        private void comboBox_DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupB_DisplayMode.Text == "Display mode: Model")
            {
                treeView_ModelData2.Nodes.Clear();
                listView_ModelData2.Items.Clear();
                if (modelVC_Model.Model != null)
                {
                    // Dispose previous stage
                    if (modelStage != null)
                    {
                        modelStage.ResetStage();
                        modelStage.DisposeStage();
                    }
                    // Set current stage
                    switch ((string)comboBox_DisplayMode.SelectedItem)
                    {
                        case "Manual":
                            modelStage = new ControlableModelStage(modelVC_Model.Model, modelVC_Model.defaultInitStatus);
                            flowLP_Controls.Enabled = false;
                            runningStatus = RunningStatus.Manual;
                            break;
                        case "YawRotating":
                            modelStage = new YawPitchRowRotatingModelStage(modelVC_Model.Model, modelVC_Model.defaultInitStatus, 10, MathHelper.Pi / 360.0f, 0, 0);
                            flowLP_Controls.Enabled = true;
                            runningStatus = RunningStatus.OnRun;
                            break;
                        case "PitchRotating":
                            modelStage = new YawPitchRowRotatingModelStage(modelVC_Model.Model, modelVC_Model.defaultInitStatus, 10, 0, MathHelper.Pi / 360.0f, 0);
                            flowLP_Controls.Enabled = true;
                            runningStatus = RunningStatus.OnRun;
                            break;
                    }
                    modelStage.ModelViewerControl = modelVC_Model;
                }
            }
        }
        private void flowLP_Controls_EnabledChanged(object sender, EventArgs e)
        {
            // Initialization
            if (flowLP_Controls.Enabled)
            {
                btn_Pause.Enabled = true;
                btn_Run.Enabled = false;
                btn_Next.Enabled = true;
                btn_Previous.Enabled = true;
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            (modelStage as MovingModelStage).Resume();
            runningStatus = RunningStatus.OnRun;
            btn_Run.Enabled = false;
            btn_Pause.Enabled = true;
            treeView_ModelData2.Nodes.Clear();
            listView_ModelData2.Items.Clear();
        }
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            // Pause
            (modelStage as MovingModelStage).Pause();
            runningStatus = RunningStatus.OnPause;
            btn_Run.Enabled = true;
            btn_Pause.Enabled = false;
            // Dispay tree and list view
            currentModelData2.ComponentAdapter.DiscoveryComponentTreeNode();
        }
        private void btn_Previous_MouseDown(object sender, MouseEventArgs e)
        {
            if (groupB_DisplayMode.Text == "Display mode: Model")
            {
                runningStatus = RunningStatus.OnPrevious;
                btn_Run.Enabled = true;
                btn_Pause.Enabled = false;
                tmr_NextPrevious.Enabled = true;
            }
        }
        private void btn_Previous_MouseUp(object sender, MouseEventArgs e)
        {
            if (groupB_DisplayMode.Text == "Display mode: Model")
            {
                tmr_NextPrevious.Enabled = false;
                runningStatus = RunningStatus.OnPause;
            }
            else
            {
                if (selectedIndexFromDataList == 0)
                    selectedIndexFromDataList = currentDataList.DataList.Count - 1;
                else selectedIndexFromDataList--;
                notifyImportXml();
            }
            // Dispay tree and list view
            currentModelData2.ComponentAdapter.DiscoveryComponentTreeNode();
        }
        private void btn_Next_MouseDown(object sender, MouseEventArgs e)
        {
            if (groupB_DisplayMode.Text == "Display mode: Model")
            {
                runningStatus = RunningStatus.OnNext;
                btn_Run.Enabled = true;
                btn_Pause.Enabled = false;
                tmr_NextPrevious.Enabled = true; 
            }
        }
        private void btn_Next_MouseUp(object sender, MouseEventArgs e)
        {
            if (groupB_DisplayMode.Text == "Display mode: Model")
            {
                tmr_NextPrevious.Enabled = false;
                runningStatus = RunningStatus.OnPause;
            }
            else
            {
                if (selectedIndexFromDataList == currentDataList.DataList.Count - 1)
                    selectedIndexFromDataList = 0;
                else selectedIndexFromDataList++;
                notifyImportXml();
            }
            // Dispay tree and list view
            currentModelData2.ComponentAdapter.DiscoveryComponentTreeNode();
        }
        private void tmr_NextPrevious_Tick(object sender, EventArgs e)
        {
            if(runningStatus==RunningStatus.OnNext)
                (modelStage as MovingModelStage).StepNext();
            else if(runningStatus==RunningStatus.OnPrevious)
                (modelStage as MovingModelStage).StepPrevious();
        }
        #endregion

        private void notifyImportXml()
        {
            // Select model data
            currentModelData2 = currentDataList.DataList[selectedIndexFromDataList];
            // Draw model data
            picB_ModelData2Viewer.Invalidate();
            // Update tree view and list view
            currentModelData2.ComponentAdapter = new TreeAndListViewAdapter(currentModelData2, treeView_ModelData2, listView_ModelData2, lastNodeKey);
            try{currentModelData2.ComponentAdapter.BuildTree();}catch (Exception ex) { }
            currentModelData2.ComponentAdapter.DiscoveryComponentTreeNode();
            // Change model data viewer label
            groupB_DataViewer.Text = "Convex Hull (" + (selectedIndexFromDataList+1) + "/" + currentDataList.DataList.Count+")";
        }

        private void treeView_ModelData2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lastNodeKey = e.Node.Name;
            currentModelData2.ComponentAdapter.DiscoveryComponentTreeLeaf(e.Node.Name);
        }

        private void listView_ModelData2_Resize(object sender, EventArgs e)
        {
            int width=listView_ModelData2.Width;
            listView_ModelData2.Columns[0].Width = width / 3;
            listView_ModelData2.Columns[1].Width = width / 3*2;
        }

    }

    public static class Vector2Extension
    {
        public static PointF ToPointF(this Vector2 vector2)
        {
            return new PointF(vector2.X, vector2.Y);
        }
    }
}
