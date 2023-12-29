using static Emgu.CV.CvInvoke;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

CascadeClassifier model = new CascadeClassifier("haarcascade_frontalface_default.xml");
//Create a 3 channel image of 400x200
using Mat img = CvInvoke.Imread("group.jpg");
Resize(img, img, new Size(), 0.5, 0.5);
var result = model.DetectMultiScale(img);
foreach(var bounds in result)
{
    Rectangle(img, bounds, new MCvScalar(255, 0, 0), 1);
}
CvInvoke.Imshow("my window", img);
    CvInvoke.WaitKey(0);
