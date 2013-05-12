using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem
{
    public sealed class YawPitchRowRotatingModelStage : MovingModelStage
    {
        private float yawRotationPerFrame;
        private float pitchRotationPerFrame;
        private float rowRotationPerFrame;

        public float YawRotationPerFrame
        {
            get { return yawRotationPerFrame; }
            set { yawRotationPerFrame = value; }
        }

        public float PitchRotationPerFrame
        {
            get { return pitchRotationPerFrame; }
            set { pitchRotationPerFrame = value; }
        }

        public float RowRotationPerFrame
        {
            get { return rowRotationPerFrame; }
            set { rowRotationPerFrame = value; }
        }

        public YawPitchRowRotatingModelStage(Model stageModel, StageStatus initStageStatus, int millesecondsPerFrame
            , float yawRotationPerFrame, float pitchRotationPerFrame, float rowRotationPerFrame)
            : base(stageModel, initStageStatus,millesecondsPerFrame)
        {
            this.millesecondsPerFrame = millesecondsPerFrame;
            this.yawRotationPerFrame = yawRotationPerFrame;
            this.rowRotationPerFrame = rowRotationPerFrame;
            this.pitchRotationPerFrame = pitchRotationPerFrame;
        }


        public override void PerformMovement()
        {
            stageStatus.World *= Matrix.CreateFromYawPitchRoll(yawRotationPerFrame, pitchRotationPerFrame, rowRotationPerFrame);
        }

        public override void PerformReverseMovement()
        {
            stageStatus.World *= Matrix.CreateFromYawPitchRoll(-yawRotationPerFrame, -pitchRotationPerFrame, -rowRotationPerFrame);
        }

        public override void OnFinishToInit()
        {

        }


    }
}
