using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CvModelSystem
{
    public delegate void OnDisplayOperation();

    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, and displays
    /// a spinning 3D initStageEffect. The main form class is responsible for loading
    /// the initStageEffect: this control just displays it.
    /// </summary>
    public class ModelViewerControl : GraphicsDeviceControl
    {
        public int test=0;
        // Model information
        private Model model;
        private StageStatus stageStatus;
        public StageStatus defaultInitStatus;
        // Cache information about the initStageEffect size and position.
        private Matrix[] boneTransforms;
        private Vector3 modelCenter;
        private float modelRadius;
        // Indicators
        private DisplayMode displayMode;
        private bool initialized;
        private bool isMouseDown;

        public Model Model 
        {
            get { return model; }
            set 
            {
                model = value;
                if (model != null)
                {
                    MeasureModel();
                }
            }
        }

        // Constants
        private float zoomAngleFOV;
        private float displaySpeed = MathHelper.Pi / 960.0f;

        public void UpdateStageStatus(StageStatus stageStatus)
        {
            this.stageStatus = stageStatus;
        }

        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
           
        }

        /// <summary>
        /// Draws the control.
        /// </summary>
        protected override void Draw()
        {
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
                        effect.World = boneTransforms[mesh.ParentBone.Index] * stageStatus.World;
                        effect.View = stageStatus.View;
                        effect.Projection = stageStatus.Projection;

                        effect.EnableDefaultLighting();
                        effect.PreferPerPixelLighting = true;
                        effect.SpecularPower = 16;
                    }
                    mesh.Draw();
                }
            }
        }

        /// <summary>
        /// Whenever a new model is selected, we examine it to see how big
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

            // Set init status
            Vector3 eyePosition = modelCenter;
            eyePosition.Z += modelRadius * 2;
            eyePosition.Y += modelRadius;
            zoomAngleFOV = 1;
            float aspectRatio = GraphicsDevice.Viewport.AspectRatio;
            defaultInitStatus = new StageStatus
            {             
                World = Matrix.Identity,
                View = Matrix.CreateLookAt(eyePosition, modelCenter, Vector3.Up),
                Projection = Matrix.CreatePerspectiveFieldOfView(zoomAngleFOV, aspectRatio,
                                                                    0.001f, 1000)
            };
        }
    }
}
