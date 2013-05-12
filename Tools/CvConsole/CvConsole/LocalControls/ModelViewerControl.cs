using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MIConvexHull;

namespace CvConsole
{
    public enum DisplayMode { Static,YawRotation,PitchRotation,YawPitchRotation};

    public delegate void OnDisplayOperation();

    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, and displays
    /// a spinning 3D initStageEffect. The main form class is responsible for loading
    /// the initStageEffect: this control just displays it.
    /// </summary>
    class ModelViewerControl : GraphicsDeviceControl
    {
        private OnDisplayOperation onDisplayOperation;

        public Matrix World { get; private set; }
        public Matrix View { get; private set; }
        public Matrix Projection { get; private set; }
        public DisplayMode DisplayMode 
        { 
            get { return displayMode; } 
            set 
            {
                displayMode = value;
                if (initialized) UpdateDisplayMode();
            }
        }

        /// <summary>
        /// Gets or sets the current initStageEffect.
        /// </summary>
        public Model Model
        {
            get { return model; }

            set
            {
                model = value;

                if (model != null)
                {
                    MeasureModel();
                    DisplayMode = DisplayMode.YawRotation;
                }
            }
        }
        private Model model;

        // Cache information about the initStageEffect size and position.
        private Matrix[] boneTransforms;
        private Vector3 modelCenter;
        private float modelRadius;
        // Indicators
        private DisplayMode displayMode;
        private bool initialized;
        private bool isMouseDown;

        // Data
        private float zoomAngleFOV;
        private float displaySpeed = MathHelper.Pi / 960.0f;

        public PictureBox projViewer { get; set; } 

        #region UI event handlers
        private void ModelViewerControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(displayMode==DisplayMode.Static)
                isMouseDown = true;
        }
        private void ModelViewerControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(!this.Focused)  this.Focus();
            if (isMouseDown)
            {
                float pitch = ((float)e.Y - this.Height/2.0f)/(this.Height/2.0f) * MathHelper.PiOver2  /15.0f;
                float yaw = ((float)e.X - this.Width / 2.0f) / (this.Width / 2.0f) * MathHelper.PiOver2 / 15.0f;
                World *= Matrix.CreateFromYawPitchRoll(yaw, pitch, 0.0f);
            }
            this.Invalidate();
        }
        private void ModelViewerControl_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        private void ModelViewerControl_MouseWheel(object sender, MouseEventArgs e)
        {
            zoomAngleFOV += MathHelper.PiOver4 * e.Delta / 900.0f;
            if (zoomAngleFOV <= 0) zoomAngleFOV = 0.1f;
            if (zoomAngleFOV >= MathHelper.PiOver2) zoomAngleFOV = MathHelper.PiOver2;
            Projection = Matrix.CreatePerspectiveFieldOfView(zoomAngleFOV, projViewer.Width / (float)projViewer.Height, 0.001f, 1000);    
        }
        #endregion

        private void UpdateDisplayMode()
        {
            switch (displayMode)
            {
                case DisplayMode.Static:
                    InitializeModel();
                    onDisplayOperation = null;
                    break;
                case DisplayMode.YawRotation:
                    InitializeModel();
                    onDisplayOperation = () => { World *= Matrix.CreateFromYawPitchRoll(displaySpeed, 0, 0); };
                    break;
                case DisplayMode.PitchRotation:
                    InitializeModel();
                    onDisplayOperation = () => { World *= Matrix.CreateFromYawPitchRoll(0, displaySpeed, 0); };
                    break;
                case DisplayMode.YawPitchRotation:
                    InitializeModel();
                    onDisplayOperation = () => { World *= Matrix.CreateFromYawPitchRoll(displaySpeed, displaySpeed, 0); };
                    break;
            }
        }

        public void InitializeModel()
        {
            // Initialize views
            Vector3 eyePosition = modelCenter;

            eyePosition.Z += modelRadius * 2;
            eyePosition.Y += modelRadius;

            float aspectRatio = GraphicsDevice.Viewport.AspectRatio;

            World = Matrix.Identity;
            View = Matrix.CreateLookAt(eyePosition, modelCenter, Vector3.Up);
            zoomAngleFOV = 1;
            Projection = Matrix.CreatePerspectiveFieldOfView(zoomAngleFOV, aspectRatio,
                                                                0.001f, 1000);
        }

        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
            initialized = true;
            // Register events
            this.MouseDown += new MouseEventHandler(ModelViewerControl_MouseDown);
            this.MouseMove += new MouseEventHandler(ModelViewerControl_MouseMove);
            this.MouseUp += new MouseEventHandler(ModelViewerControl_MouseUp);
            this.MouseWheel += new MouseEventHandler(ModelViewerControl_MouseWheel);
            Application.Idle += (s,e) => { this.Invalidate(); };
            UpdateDisplayMode();

        }

        /// <summary>
        /// Draws the control.
        /// </summary>
        protected override void Draw()
        {
            // Display operation
            if(onDisplayOperation!=null) onDisplayOperation();
            // Clear to the default control background color.
            Color backColor = new Color(BackColor.R, BackColor.G, BackColor.B);
            GraphicsDevice.Clear(backColor);

            if (model != null)
            {
                // Draw the initStageEffect.
                foreach (ModelMesh mesh in model.Meshes)
                {
                    foreach (BasicEffect effect in mesh.Effects)
                    {
                        effect.World = boneTransforms[mesh.ParentBone.Index] * World;
                        effect.View = View;
                        effect.Projection = Projection;

                        effect.EnableDefaultLighting();
                        effect.PreferPerPixelLighting = true;
                        effect.SpecularPower = 16;
                    }
                    mesh.Draw();
                }
            }
            if(projViewer!=null) projViewer.Invalidate();
        }

        /// <summary>
        /// Whenever a new initStageEffect is selected, we examine it to see how big
        /// it is and where it is centered. This lets us automatically zoom
        /// the display, so we can correctly handle models of any scale.
        /// </summary>
        void MeasureModel()
        {
            // Look up the absolute bone transforms for this initStageEffect.
            boneTransforms = new Matrix[model.Bones.Count];
            
            model.CopyAbsoluteBoneTransformsTo(boneTransforms);

            // Compute an (approximate) initStageEffect center position by
            // averaging the center of each mesh bounding sphere.
            modelCenter = Vector3.Zero;

            foreach (ModelMesh mesh in model.Meshes)
            {
                BoundingSphere meshBounds = mesh.BoundingSphere;
                Matrix transform = boneTransforms[mesh.ParentBone.Index];
                Vector3 meshCenter = Vector3.Transform(meshBounds.Center, transform);

                modelCenter += meshCenter;
            }

            modelCenter /= model.Meshes.Count;

            // Now we know the center point, we can compute the initStageEffect radius
            // by examining the radius of each mesh bounding sphere.
            modelRadius = 0;

            foreach (ModelMesh mesh in model.Meshes)
            {
                BoundingSphere meshBounds = mesh.BoundingSphere;
                Matrix transform = boneTransforms[mesh.ParentBone.Index];
                Vector3 meshCenter = Vector3.Transform(meshBounds.Center, transform);

                float transformScale = transform.Forward.Length();
                
                float meshRadius = (meshCenter - modelCenter).Length() +
                                   (meshBounds.Radius * transformScale);

                modelRadius = Math.Max(modelRadius,  meshRadius);
            }
        }
    }
}
