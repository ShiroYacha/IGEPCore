using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgepCore.CV.InputSystem
{
    public delegate void OnUpdateViewEventHandler<TView>(TView view) where TView:IView;

    public interface ISource<TView> where TView:class,IView
    {
        /// <summary>
        /// Get the period of the asynchronous process in ms.
        /// </summary>
        long Period
        {
            get;
        }
        /// <summary>
        /// Synchronously query a view.
        /// </summary>
        TView QueryView();
        /// <summary>
        /// Start an asynchronous image query process.
        /// </summary>
        /// <param name="handler">The callback handler.</param>
        void StartAsync(OnUpdateViewEventHandler<TView> handler);
        /// <summary>
        /// Pause the asynchronous process.
        /// </summary>
        void PauseAsync();
        /// <summary>
        /// Resume the asynchronous process.
        /// </summary>
        void ResumeAsync();
        /// <summary>
        /// , dispose the underlying source.
        /// </summary>
        void StopAsync();
    }
}
