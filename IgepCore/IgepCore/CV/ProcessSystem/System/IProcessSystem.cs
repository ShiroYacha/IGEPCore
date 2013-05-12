using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    public interface IProcessSystem
    {
        void Start(IInputSystem inputSystem);
    }
}
