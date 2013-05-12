using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    public class SortViewByTimeStamp<TView>:IComparer<TView> where TView:IView
    {
        public int Compare(TView x, TView y)
        {
            return x.TimeStamp.CompareTo(y.TimeStamp);
        }
    }

    public class BasicInputSystem<TView> : IInputSystem
        where TView : class,IView
    {
        /// <summary>
        /// The input source (interface).
        /// </summary>
        private ISource<TView> source;
        /// <summary>
        /// The buffer in which stores the updated views.
        /// </summary>
        private SortedSet<TView> buffer=new SortedSet<TView>(new SortViewByTimeStamp<TView>());
        /// <summary>
        /// The on update view event handlers.
        /// </summary>
        public OnUpdateViewEventHandler<TView> OnUpdateHandler;

        /// <summary>
        /// Get or set the input source (interface).
        /// </summary>
        public ISource<TView> Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        /// <summary>
        /// Start the source.
        /// </summary>
        public void Start()
        {
            source.StartAsync((updatedView) => { buffer.Add(updatedView); if(OnUpdateHandler!=null) OnUpdateHandler(updatedView); });
        }
        /// <summary>
        /// Pause the source.
        /// </summary>
        public void Pause()
        {
            source.PauseAsync();
        }
        /// <summary>
        /// Stop the source.
        /// </summary>
        public void Stop()
        {
            source.StopAsync();
        }
        /// <summary>
        /// Resume the source.
        /// </summary>
        public void Resume()
        {
            source.ResumeAsync();
        }
        /// <summary>
        /// Query a view directly from the source (synchronous).
        /// </summary>
        public TView QueryView()
        {
            return source.QueryView();
        }
        /// <summary>
        /// Get the latest view stored in the buffer.
        /// </summary>
        public TView GetLatestView()
        {
            //return buffer.Count!=0?buffer.First():source.QueryView();
            return buffer.Count != 0 ? buffer.First() : null;
        }
        /// <summary>
        /// Clear the buffer.
        /// </summary>
        public void ClearBuffer()
        {
            buffer.Clear();
        }
        /// <summary>
        /// Display the image.
        /// </summary>
        /// <returns>The primary image.</returns>
        public IImage Display(int width,int height)
        {
            TView view =GetLatestView();
            if (view != null) return view.GetPrimaryView(width, height);
            else return null;
        }

    }
}
