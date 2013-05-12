using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    public interface IInputHandler
    {
        event OnProceed onProceed; 
        void HandleInputSystem(IInputSystem inputSytem);
        void GenerateProcessEntryArgs();
    }
}
