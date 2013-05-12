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
    /// Single image source.
    /// </summary>
    public class SingleImageSource : ISource<SingleView>
    {
        /// <summary>
        /// The current loaded image.
        /// </summary>
        private SingleView currentImage;
        /// <summary>
        /// The underlying emulating timer for periodic asynchronous query.
        /// </summary>
        private Timer asyncTimer;
        /// <summary>
        /// The period of the asynchronous timer.
        /// </summary>
        /// <remarks>Default value for image source is 1000ms.</remarks>
        private long period=1000;

        /// <summary>
        /// Get the period of the asynchronous process in ms.
        /// </summary>
        public long Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }

        /// <summary>
        /// Load static image.
        /// </summary>
        /// <param name="path">The image path (for stereo image, use semicolon as separator).</param>
        public void LoadImage(string path)
        {
            currentImage = new SingleView(new Image<Bgr, byte>(path));
        }
        /// <summary>
        /// Synchronously query a view.
        /// </summary>
        public SingleView QueryView()
        {
            return currentImage;
        }
        /// <summary>
        /// Start an asynchronous image query process.
        /// </summary>
        /// <param name="handler">The callback handler.</param>
        /// <remarks>The image source use a Threading.Timer as trigger. The updated view is always the same on as loaded.</remarks>
        public void StartAsync(OnUpdateViewEventHandler<SingleView> handler)
        {
            asyncTimer = new Timer((state) => { handler(currentImage); }, null, 0, period);
        }
        /// <summary>
        /// Pause the asynchronous process.
        /// </summary>
        /// <remarks> Change the period and due time to infinite.</remarks>
        public void PauseAsync()
        {
            if (asyncTimer == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            asyncTimer.Change(Timeout.Infinite,Timeout.Infinite);
        }
        /// <summary>
        /// Resume the asynchronous process.
        /// </summary>
        public void ResumeAsync()
        {
            if (asyncTimer == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            asyncTimer.Change(0,period);
        }
        /// <summary>
        /// Stop the aysnchrous process, dispose the underlying source.
        /// </summary>
        /// <remarks> Dispose the timer.</remarks>
        public void StopAsync()
        {
            if (asyncTimer == null) return;
            asyncTimer.Change(Timeout.Infinite, Timeout.Infinite);
            asyncTimer.Dispose();
            asyncTimer = null;
        }
    }

    /// <summary>
    /// Generic image source.
    /// </summary>
    public class StereoImageSource : ISource<StereoView>
    {
        /// <summary>
        /// The current loaded image.
        /// </summary>
        private StereoView currentImage;
        /// <summary>
        /// The underlying emulating timer for periodic asynchronous query.
        /// </summary>
        private Timer asyncTimer;
        /// <summary>
        /// The period of the asynchronous timer.
        /// </summary>
        /// <remarks>Default value for image source is 1000ms.</remarks>
        private long period = 1000;

        /// <summary>
        /// Get the period of the asynchronous process in ms.
        /// </summary>
        public long Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }
        /// <summary>
        /// Load static image.
        /// </summary>
        /// <param name="path">The image path (for stereo image, use semicolon as separator).</param>
        public void LoadImage(string leftPath, string rightPath)
        {
            currentImage = new StereoView(
                    new Image<Bgr, byte>(leftPath),
                    new Image<Bgr, byte>(rightPath));
        }
        /// <summary>
        /// Synchronously query a view.
        /// </summary>
        public StereoView QueryView()
        {
            return currentImage;
        }
        /// <summary>
        /// Start an asynchronous image query process.
        /// </summary>
        /// <param name="handler">The callback handler.</param>
        /// <remarks>The image source use a Threading.Timer as trigger. The updated view is always the same on as loaded.</remarks>
        public void StartAsync(OnUpdateViewEventHandler<StereoView> handler)
        {
            asyncTimer = new Timer((state) => { handler(currentImage); }, null, 0, period);
        }
        /// <summary>
        /// Pause the asynchronous process.
        /// </summary>
        /// <remarks> Change the period and due time to infinite.</remarks>
        public void PauseAsync()
        {
            if (asyncTimer == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            asyncTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }
        /// <summary>
        /// Resume the asynchronous process.
        /// </summary>
        public void ResumeAsync()
        {
            if (asyncTimer == null) throw new InvalidOperationException("The asynchronous process is never started. Use StartAsync() first.");
            asyncTimer.Change(0, period);
        }
        /// <summary>
        /// Stop the aysnchrous process, dispose the underlying source.
        /// </summary>
        /// <remarks> Dispose the timer.</remarks>
        public void StopAsync()
        {
            if (asyncTimer == null) return;
            asyncTimer.Change(Timeout.Infinite, Timeout.Infinite);
            asyncTimer.Dispose();
            asyncTimer = null;
        }
    }
}
