using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IgepCore.CV.InputSystem;
using IgepCore.CV.ProcessSystem;

namespace IgepCore.CV
{
    public interface ICvSystem
    {
        IInputSystem InputSystem { get; set; }
        IProcessSystem ProcessSystem { get; set; }
        void LaunchSystem();
        void StopSystem();
    }

    public class BasicCvSystem :ICvSystem
    {
        private IInputSystem inputSystem;
        private IProcessSystem processSystem;

        public IInputSystem InputSystem
        {
            get { return inputSystem; }
            set { inputSystem = value; }
        }
        
        public IProcessSystem ProcessSystem 
        {
            get { return processSystem;}
            set { processSystem = value; }
        }


        public void LaunchSystem()
        {
            processSystem.Start(inputSystem);
            inputSystem.Start();
        }

        public void StopSystem()
        {
            inputSystem.Stop();
        }
    }
}
