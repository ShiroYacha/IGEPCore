using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    /// <summary>
    /// Single camera source.
    /// </summary>
    public class SingleCameraSource : ISource<SingleView>
    {
        /// <summary>
        /// The current capture of the camera.
        /// </summary>
        private SingleView currentCapturedImage;
        /// <summary>
        /// The primary capture.
        /// </summary>
        private Capture capture;

        /// <summary>
        /// Get or set the period of the asynchronous process in ms.
        /// </summary>
        /// <remarks>Default value for camera source depends on the webcam.</remarks>
        public long Period
        {
            get
            {
                return (long)(1000.0 / capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS));
            }
            set
            {
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS, 1000.0 / value);
            }
        }

        /// <summary>
        /// Configure the camera.
        /// </summary>
        /// <param name="channel">The channel of the camera.</param>
        public void ConfigCamera(int channel)
        {
            capture = new Capture(channel);
        }
        /// <summary>
        /// Synchronously query a view.
        /// </summary>
        public SingleView QueryView()
        {
            return new SingleView(capture.QueryFrame());
        }
        /// <summary>
        /// Start an asynchronous image query process.
        /// </summary>
        /// <param name="handler">The callback handler.</param>
        /// <remarks>Use the primary capture as trigger.</remarks>
        public void StartAsync(OnUpdateViewEventHandler<SingleView> handler)
        {
            capture.ImageGrabbed += (s, e) =>
            {
                currentCapturedImage = new SingleView(capture.RetrieveBgrFrame());
                // Invoke the event handler
                handler(currentCapturedImage);
            };
            capture.Start();
        }
        /// <summary>
        /// Pause the asynchronous process.
        /// </summary>
        public void PauseAsync()
        {
            if (capture == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            capture.Stop();
        }
        /// <summary>
        /// Resume the asynchronous process.
        /// </summary>
        public void ResumeAsync()
        {
            if (capture == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            capture.Start();
        }
        /// <summary>
        /// Stop the asynchronous process, dispose the underlying source.
        /// </summary>
        public void StopAsync()
        {
            if (capture == null) return;
            capture.Stop();
            capture.Dispose();
            capture = null;
        }

    }

    /// <summary>
    /// Stereo camera source.
    /// </summary>
    public class StereoCameraSource : ISource<StereoView>
    {
        /// <summary>
        /// The current capture of the camera.
        /// </summary>
        private StereoView currentCapturedImage;
        /// <summary>
        /// The primary capture.
        /// </summary>
        private Capture primaryCapture;
        /// <summary>
        /// The secondary capture.
        /// </summary>
        private Capture secondaryCapture;

        /// <summary>
        /// Get or set the period of the asynchronous process in ms.
        /// </summary>
        /// <remarks>Default value for camera source depends on the webcam.</remarks>
        public long Period
        {
            get
            {
                return (long)(1000.0/primaryCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS));
            }
            set
            {
                primaryCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS, 1000.0 / value);
            }
        }

        /// <summary>
        /// Configure the stereo camera.
        /// </summary>
        /// <param name="primaryChannel">The primary channel of the camera.</param>
        /// <param name="secondaryChannel">The secondary channel of the camera.</param>
        public void ConfigCamera(int primaryChannel, int secondaryChannel)
        {
            primaryCapture = new Capture(primaryChannel);
            secondaryCapture = new Capture(secondaryChannel);
        }
        /// <summary>
        /// Synchronously query a view.
        /// </summary>
        public StereoView QueryView()
        {
            return new StereoView(primaryCapture.QueryFrame(), secondaryCapture.QueryFrame());
        }
        /// <summary>
        /// Start an asynchronous image query process.
        /// </summary>
        /// <param name="handler">The callback handler.</param>
        /// <remarks>Use the primary capture as trigger.</remarks>
        public void StartAsync(OnUpdateViewEventHandler<StereoView> handler)
        {
            primaryCapture.ImageGrabbed += (s, e) =>
            {
                currentCapturedImage = new StereoView(primaryCapture.RetrieveBgrFrame(),secondaryCapture.QueryFrame());
                // Invoke the event handler
                handler(currentCapturedImage);
            };
        }
        /// <summary>
        /// Pause the asynchronous process.
        /// </summary>
        public void PauseAsync()
        {
            if (primaryCapture == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            primaryCapture.Stop();
        }
        /// <summary>
        /// Resume the asynchronous process.
        /// </summary>
        public void ResumeAsync()
        {
            if (primaryCapture == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            primaryCapture.Start();
        }
        /// <summary>
        /// , dispose the underlying source.
        /// </summary>
        public void StopAsync()
        {
            if (primaryCapture == null) return;
            primaryCapture.Dispose();
            secondaryCapture.Dispose();
            primaryCapture = null;
            secondaryCapture = null;
        }

    }
}
