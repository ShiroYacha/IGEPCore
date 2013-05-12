using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgepCore.CV.InputSystem
{
    public static class InputSystemFactory
    {
        public static BasicInputSystem<SingleView> CreateSingleCameraInputSystem(int channel)
        {
            BasicInputSystem<SingleView> system = new BasicInputSystem<SingleView>();
            // Set input source
            SingleCameraSource source = new SingleCameraSource();
            source.ConfigCamera(channel);
            // Bind source to input sytem
            system.Source = source;
            // Return system
            return system;
        }

        public static BasicInputSystem<StereoView> CreateStereoCameraInputSystem(int leftChannel,int rightChannel)
        {
            BasicInputSystem<StereoView> system = new BasicInputSystem<StereoView>();
            // Set input source
            StereoCameraSource source = new StereoCameraSource();
            source.ConfigCamera(leftChannel,rightChannel);
            // Bind source to input sytem
            system.Source = source;
            // Return system
            return system;
        }

        public static BasicInputSystem<SingleView> CreateSingleImageInputSystem(string path)
        {
            BasicInputSystem<SingleView> system = new BasicInputSystem<SingleView>();
            // Set input source
            SingleImageSource source = new SingleImageSource();
            source.LoadImage(path);
            // Bind source to input sytem
            system.Source = source;
            // Return system
            return system;
        }

        public static BasicInputSystem<StereoView> CreateStereoImageInputSystem(string leftPath, string rightPath)
        {
            BasicInputSystem<StereoView> system = new BasicInputSystem<StereoView>();
            // Set input source
            StereoImageSource source = new StereoImageSource();
            source.LoadImage(leftPath, rightPath);
            // Bind source to input sytem
            system.Source = source;
            // Return system
            return system;
        }
    }
}
