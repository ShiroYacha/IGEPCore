using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    public delegate Dictionary<string,object> OnProceed(Dictionary<string,object> argsDict);

    public abstract class BasicProcessSystem:IProcessSystem
    {
        protected IInputHandler inputHandler;

        public BasicProcessSystem()
        {
            inputHandler = new BasicInputHandler();
        }

        public virtual void Start(IInputSystem inputSystem)
        {
            inputHandler.HandleInputSystem(inputSystem);
        }
    }
}
