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
    public abstract class MovingModelStage : BasicModelStage
    {
        private const float isInitErrorRange = 0.00001f;
        private const int dueTime = 500;
        private Timer stageTimer;

        private bool onPause=false;
        private bool isFinished;
        private bool isFirst=true;

        protected int millesecondsPerFrame;

        public MovingModelStage(Model stageModel, StageStatus initStageStatus, int millesecondsPerFrame)
            : base(stageModel, initStageStatus)
        {
            this.millesecondsPerFrame = millesecondsPerFrame;
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
                stageTimer = new Timer(StageCallback, stageStatus, dueTime, millesecondsPerFrame);
            }
        }

        protected virtual void StageCallback(object objectStatus)
        {
            // Check status if is finished
            float checkResult = stageStatus.CheckWorldRotation(initStageStatus);
            if (!isFirst && !isFinished && checkResult <= isInitErrorRange )
            {
                OnFinishToInit();
                isFinished = true;
            }
            else if (checkResult > isInitErrorRange)
            {
                isFinished = false;
                isFirst = false;
            }
            if (!onPause)
            {
                // PerformMovement 
                PerformMovement();
                // Update stage status
                modelViewerControl.UpdateStageStatus(stageStatus);
            }
        }

        public void Pause()
        {
            this.onPause = true;
        }
        public void Resume()
        {
            this.onPause = false;
        }
        public void StepNext()
        {
            // Pause
            Pause();
            // PerformMovement 
            PerformMovement();
            // Update stage status
            modelViewerControl.UpdateStageStatus(stageStatus);
        }
        public void StepPrevious()
        {
            // Pause
            Pause();
            // PerformReverseMovement 
            PerformReverseMovement();
            // Update stage status
            modelViewerControl.UpdateStageStatus(stageStatus);
        }

        public abstract void PerformMovement();
        public abstract void PerformReverseMovement();
        public abstract void OnFinishToInit();

        public override void DisposeStage()
        {
            base.DisposeStage();
            if(stageTimer!=null) stageTimer.Dispose();
        }


    }
}
