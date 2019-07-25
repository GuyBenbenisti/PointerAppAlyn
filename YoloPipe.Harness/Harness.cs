using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoloPipe.Harness
{
    public static class Harness
    {
        //static void Main(string[] args)
        //{
        //    //TestYoloPipe();
        //    Console.WriteLine("Hit enter to start");
        //    Console.ReadLine();
        //    TestYoloJsonPipe();
        //    Console.ReadLine();
        //}

        public static async Task TestYoloJsonPipe(double i_X, double i_Y)
        {
            var anacondaDir = ConfigurationManager.AppSettings["AnacondaDirectory"]; // @"C:\Users\username\AppData\Local";
            var solutionDir = ConfigurationManager.AppSettings["SolutionDirectory"]; // @"C:\Users\username\source\repos\";
            var speechLanguage = ConfigurationManager.AppSettings["Language"];
            var exe = "cmd.exe";
            var dir = String.Format(@"{0}\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\", solutionDir);
            var args = String.Format(@"/c {0}\Continuum\anaconda3\Scripts\activate.bat {0}\Continuum\anaconda3 & {0}\Continuum\anaconda3\python.exe -u {1}\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\yolo.py -i {1}\PointerAppAlyn\FrameDir\image.jpeg -ln {4} -x {2} -y {3}", anacondaDir, solutionDir, i_X, i_Y, speechLanguage);
            var pipe = new YoloJsonPipe("cmd.exe", args, dir);

            pipe.Start();

            //int i = 0;
            //while (true)
            //{
            //    var obj = await pipe.ReadJsonObjextAsync();
            //    if (obj != null)
            //    {
            //        i++;
            //        Console.WriteLine($"Read {obj.Length} chars. Object #{i}");
            //    }
            //}
        }

        private static async Task TestYoloPipe()
        {
            // var pipe = new YoloPipe("cmd.exe", "/c dir");
            var pipe = new YoloPipe("cmd.exe", "/c type c:\\temp\\sim.txt");
            pipe.Start();
            await DoIt(pipe);
        }

        private static async Task DoIt(YoloPipe pipe)
        {
            string line = null;
            do
            {
                line = await pipe.ReadNext();
                //Console.WriteLine(line);
            } while (line != null);
        }
    }
}
