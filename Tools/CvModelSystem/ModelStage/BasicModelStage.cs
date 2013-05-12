using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem
{
    public struct StageStatus
    {
        public Matrix World;
        public Matrix View;
        public Matrix Projection;

        public float CheckWorldRotation(StageStatus stageStatus)
        {
            Vector3 thisTranslation,thisScale; Quaternion thisRotation;
            Vector3 thatTranslation, thatScale; Quaternion thatRotation;
            World.Decompose(out thisTranslation, out thisRotation, out thisScale);
            stageStatus.World.Decompose(out thatTranslation, out thatRotation, out thatScale);
            return Math.Abs(thisRotation.W - thatRotation.W);
        }
    }

    public class BasicModelStage
    {
        protected StageStatus stageStatus;
        protected StageStatus initStageStatus;
        protected Model stageModel;
        protected ModelViewerControl modelViewerControl;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="stageModel">The model on the stage.</param>
        /// <param name="initStageEffect">The initial stage status.</param>

        public BasicModelStage(Model stageModel, StageStatus initStageStatus)
        {
            this.stageModel = stageModel;
            this.initStageStatus = initStageStatus;
            this.stageStatus = initStageStatus;
        }

        /// <summary>
        /// Get the model on the stage.
        /// </summary>
        public Model StageModel
        {
            get
            {
                return stageModel;
            }

        }

        /// <summary>
        /// Get the current stage status.
        /// </summary>
        public StageStatus StageStatus
        {
            get
            {
                return stageStatus;
            }
        }

        /// <summary>
        /// Get or set the model viewer control.
        /// </summary>
        public virtual ModelViewerControl ModelViewerControl
        {
            get
            {
                return modelViewerControl;
            }
            set
            {
                modelViewerControl = value;
                modelViewerControl.UpdateStageStatus(stageStatus);
            }
        }

        /// <summary>
        /// Reset stage status to initial stage status.
        /// </summary>
        public void ResetStage()
        {
            // Reset to init 
            stageStatus = initStageStatus;
            // Update stage status
            modelViewerControl.UpdateStageStatus(stageStatus); 
        }

        /// <summary>
        /// Rotate the model on the stage.
        /// </summary>
        /// <param name="yaw">The yaw angle (in radian).</param>
        /// <param name="pitch">The pitch angle (in radian).</param>
        /// <param name="row">The row angle (in radian).</param>
        public void Rotate(float yaw, float pitch, float row)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Translate the model on the stage.
        /// </summary>
        /// <param name="translationVector">Amounts to translate by on the x, y, and z axes</param>
        public void Translate(Vector3 translationVector)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DisposeStage() { }
    }
}
