using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;


namespace CvModelSystem
{
    public class ControlableModelStage : BasicModelStage
    {
        private bool isMouseDown;
        private float zoomAngleFOV;

        public ControlableModelStage(Model stageModel, StageStatus initStageStatus)
            : base(stageModel, initStageStatus)
        {
            zoomAngleFOV = 1;
        }

        public override ModelViewerControl ModelViewerControl
        {
            get
            {
                return modelViewerControl;
            }
            set
            {
                modelViewerControl = value;
                // Handle ui events
                modelViewerControl.MouseDown += MouseDownHandler;
                modelViewerControl.MouseMove += MouseMoveHandler;
                modelViewerControl.MouseUp += MouseUpHandler;
                modelViewerControl.MouseWheel += MouseWheelHandler;
            }
        }

        public void MouseDownHandler(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }
        public void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (!modelViewerControl.Focused) modelViewerControl.Focus();
            if (isMouseDown)
            {
                float pitch = ((float)e.Y - modelViewerControl.Height / 2.0f) / (modelViewerControl.Height / 2.0f) * MathHelper.PiOver2 / 15.0f;
                float yaw = ((float)e.X - modelViewerControl.Width / 2.0f) / (modelViewerControl.Width / 2.0f) * MathHelper.PiOver2 / 15.0f;
                stageStatus.World *= Matrix.CreateFromYawPitchRoll(yaw, pitch, 0.0f);
                // Update stage status
                modelViewerControl.UpdateStageStatus(stageStatus); 
            }
        }
        public void MouseUpHandler(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        public void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            zoomAngleFOV += MathHelper.PiOver4 * e.Delta / 900.0f;
            if (zoomAngleFOV <= 0) zoomAngleFOV = 0.1f;
            if (zoomAngleFOV >= MathHelper.PiOver2) zoomAngleFOV = MathHelper.PiOver2;
            stageStatus.Projection = Matrix.CreatePerspectiveFieldOfView(zoomAngleFOV, modelViewerControl.Width / (float)modelViewerControl.Height, 0.001f, 1000);
            // Update stage status
            modelViewerControl.UpdateStageStatus(stageStatus); 
        }

        public override void DisposeStage()
        {
            base.DisposeStage();
            if (modelViewerControl != null)
            {
                modelViewerControl.MouseDown -= MouseDownHandler;
                modelViewerControl.MouseMove -= MouseMoveHandler;
                modelViewerControl.MouseUp -= MouseUpHandler;
                modelViewerControl.MouseWheel -= MouseWheelHandler;
            }
        }
    }
}
