using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    public interface IInputSystem : IDisplayable
    {
        void Start();
        void Pause();
        void Stop();
        void Resume();
    }
}
