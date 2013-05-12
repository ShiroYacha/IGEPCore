using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    [LayerBuilder]
    public static class TestLayers1
    {

        [Layer(0)]
        public class ConvertToGrayscaleLayer:ILayer
        {
            private Image<Gray, byte> imageToBeDisplayed;

            public string Name
            {
                get { return "ConvertToGrayscaleLayer"; }
            }
            public Dictionary<string, object> Proceed(Dictionary<string, object> argsDict)
            {
                if (argsDict.ContainsKey("SingleInput"))
                {
                    SingleView singleInput = argsDict["SingleInput"] as SingleView;
                    imageToBeDisplayed = singleInput.Image.Convert<Gray, byte>();
                    return new Dictionary<string, object>() { { "SingleGray", imageToBeDisplayed } };
                }
                else if (argsDict.ContainsKey("StereoInput"))
                {
                    StereoView stereoInput = argsDict["StereoInput"] as StereoView;
                    Image<Bgr, byte> leftInput = stereoInput.LeftImage;
                    Image<Bgr, byte> rightInput = stereoInput.RightImage;
                    Image<Gray, byte> leftConvertedImage = leftInput.Convert<Gray, byte>();
                    Image<Gray, byte> rightConvertedImage = rightInput.Convert<Gray, byte>();
                    imageToBeDisplayed = leftConvertedImage;
                    return new Dictionary<string, object>() { { "StereoGray", new Tuple<Image<Gray, byte>, Image<Gray, byte>>(leftConvertedImage, rightConvertedImage) } };
                }
                else throw new ArgumentException("Invalide arguments");
            }
            public Emgu.CV.IImage Display(int width, int height)
            {
                return imageToBeDisplayed.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            }
        }

        [Layer(1)]
        public class FindContourLayer: ILayer
        {
            private Image<Bgr, byte> imageToBeDisplayed;

            public string Name
            {
                get { return "FindContourLayer"; }
            }
            public Dictionary<string, object> Proceed(Dictionary<string, object> argsDict)
            {
                const int thresh = 10;
                const int threshLinking = 50;
                if (argsDict.ContainsKey("SingleGray"))
                {
                    Image<Gray, byte> singleGray = argsDict["SingleGray"] as Image<Gray, byte>;
                    imageToBeDisplayed = new Image<Bgr,byte>(singleGray.Size);
                    imageToBeDisplayed.SetZero();
                    Image<Gray, Byte> image_canny = singleGray.Canny(new Gray(thresh), new Gray(threshLinking));
                    Random random = new Random(1);
                    int nb = 0;
                    using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                    {
                        Contour<Point> contours;
                        for (
                           contours = image_canny.FindContours(
                              Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                              Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                              storage);
                           contours != null;
                           contours = contours.HNext)
                        {
                            imageToBeDisplayed.DrawPolyline(contours.ToArray(), contours.Convex, new Bgr((int)random.Next(0, 255), (int)random.Next(0, 255), (int)random.Next(0, 255)), 1);
                            nb++;
                        }
                        return new Dictionary<string, object>() { };
                    }
                }
                else throw new ArgumentException("Invalide arguments");
            }
            public Emgu.CV.IImage Display(int width, int height)
            {
                return imageToBeDisplayed.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            }
        }
    }
}
