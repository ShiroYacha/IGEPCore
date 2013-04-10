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

namespace CvConsole
{
    public partial class ModelsWindow : UserControl
    {
        private ContentBuilder contentBuilder;
        private ContentManager contentManager;

        private string modelPath;

        public ModelsWindow()
        {
            InitializeComponent();

            contentBuilder = new ContentBuilder();
            contentManager = new ContentManager(modelVC_Model.Services,
                                                contentBuilder.OutputDirectory);
        }

        /// <summary>
        /// Loads a new 3D model file into the ModelViewerControl.
        /// </summary>
        private void LoadModel(string fileName)
        {
            Cursor = Cursors.WaitCursor;

            // Unload any existing model.
            modelVC_Model.Model = null;
            contentManager.Unload();

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
                picB_ProjectionViewer.Paint += OnPaintProjectionView;
                // Set projection viewer picture box
                modelVC_Model.projViewer = picB_ProjectionViewer;
            }
            else
            {
                // If the build failed, display an error message.
                MessageBox.Show(buildError, "Error");
            }

            Cursor = Cursors.Arrow;

        }

        private void OnPaintProjectionView(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
            System.Drawing.Brush brush = System.Drawing.Brushes.Black;
            // Extract vertices from model
            List<Vector3> vertices = new List<Vector3>();
            List<VertexHelper.TriangleVertexIndices> indices = new List<VertexHelper.TriangleVertexIndices>();
            VertexHelper.ExtractTrianglesFrom(modelVC_Model.Model, vertices, indices, modelVC_Model.World);
            // Project to screen
            List<Vertex2> projVertices = new List<Vertex2>();
            foreach (Vector3 vertex in vertices)
            {
                Vector3 projVertex = modelVC_Model.GraphicsDevice.Viewport.Project(vertex, modelVC_Model.Projection, modelVC_Model.View, Matrix.Identity);
                projVertices.Add(new Vertex2(projVertex));
            }
            const float radias = 5;
            // Get convex hull
            ConvexHull<Vertex2, DefaultConvexFace<Vertex2>> convexHull = ConvexHull.Create<Vertex2>(projVertices);
            // Clear 
            e.Graphics.Clear(System.Drawing.Color.White);
            // Draw
            foreach (Vertex2 projVertex in convexHull.Points)
            {
                PointF center=new PointF((float)projVertex.Position[0],(float)projVertex.Position[1]);
                // Draw points
                e.Graphics.DrawEllipse(pen, new System.Drawing.RectangleF(center.X - radias / 2.0f, center.Y - radias / 2.0f, radias, radias));
                // Draw coordinate strings
                e.Graphics.DrawString(
                    center.ToString(),
                    new Font(FontFamily.GenericSansSerif, 5.0f),
                    brush,
                    center
                    );
                // Draw lines
                foreach (DefaultConvexFace<Vertex2> vFace in convexHull.Faces)
                {
                    PointF[] pts = new PointF[vFace.Vertices.Length];
                    for (int i = 0; i < pts.Length; i++)
                        pts[i] = new PointF((float)vFace.Vertices[i].Position[0], (float)vFace.Vertices[i].Position[1]);
                    e.Graphics.DrawLines(pen, pts);
                }
            }
        }

        private void LoadModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Default to the directory which contains our content files.
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string relativePath = Path.Combine(assemblyLocation, "../../../../Models");
            string contentPath = Path.GetFullPath(relativePath);

            openFileDialog_Model.InitialDirectory = contentPath;

            openFileDialog_Model.Title = "Load Model";

            openFileDialog_Model.Filter = "Model Files (*.fbx;*.x)|*.fbx;*.x|" +
                                "FBX Files (*.fbx)|*.fbx|" +
                                "X Files (*.x)|*.x|" +
                                "All Files (*.*)|*.*";

            if (openFileDialog_Model.ShowDialog() == DialogResult.OK)
            {
                modelPath = openFileDialog_Model.FileName;
                LoadModel(modelPath);        
            }
            // Activate console buttons if not activated
            if (!tableLP_Buttons.Enabled) tableLP_Buttons.Enabled = true;
            // Set default display
            radioB_YawRotation.Checked = true;
        }

        private void btn_EditInBlender_Click(object sender, EventArgs e)
        {
            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = "";
            // Enter the executable to run, including the complete path
            string modelName=modelPath.Substring(modelPath.LastIndexOf("\\"));
            string modelNameNoExt = modelName.Remove(modelName.IndexOf(".")); // Remove extension
            start.FileName = modelPath.Replace(modelName,modelNameNoExt + ".blend");
            // Do not show console
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
            }
            // Reload modified model
            LoadModel(modelPath);
        }

        private void btn_ResetView_Click(object sender, EventArgs e)
        {
            modelVC_Model.InitializeModel();
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            if(radioB_Static.Checked)
                modelVC_Model.DisplayMode=DisplayMode.Static;
            else if(radioB_YawRotation.Checked)
                modelVC_Model.DisplayMode=DisplayMode.YawRotation;
            else if(radioB_PitchRotation.Checked)
                modelVC_Model.DisplayMode = DisplayMode.PitchRotation;
            else
                modelVC_Model.DisplayMode = DisplayMode.YawPitchRotation;
        }
    }
}
