using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    public class BasicInputHandler:IInputHandler
    {
        public event OnProceed onProceed; 
        private string inputType;
        private IView updatedView;

        public void HandleInputSystem(IInputSystem inputSytem)
        {
            if (inputSytem is BasicInputSystem<SingleView>)
            {
                (inputSytem as BasicInputSystem<SingleView>).OnUpdateHandler
                    += (view) => { updatedView = view; GenerateProcessEntryArgs(); };
                inputType = "SingleInput";
            }
            else if (inputSytem is BasicInputSystem<StereoView>)
            {
                (inputSytem as BasicInputSystem<StereoView>).OnUpdateHandler
                    += (view) => { updatedView = view; GenerateProcessEntryArgs(); };
                inputType = "StereoInput";
            }
        }

        public void GenerateProcessEntryArgs()
        {
            onProceed(new Dictionary<string, object>() {{inputType,updatedView}});
        }
    }
}
