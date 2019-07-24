using System;
using System.Collections.Generic;
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
            var exe = "cmd.exe";
            var dir = @"C:\Users\t-gubenb\source\repos\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\";
            var args = String.Format(@"/c C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3\Scripts\activate.bat C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3 & C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3\python.exe -u C:\Users\t-gubenb\source\repos\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\yolo.py -i C:\Users\t-gubenb\source\repos\PointerAppAlyn\FrameDir\image.jpeg -x {0} -y {1}", i_X, i_Y);
            var pipe = new YoloJsonPipe("cmd.exe", args, dir);
            //var pipe = new YoloJsonPipe("cmd.exe", @"/c C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3\Scripts\activate.bat C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3 & C:\Users\t-gubenb\AppData\Local\Continuum\anaconda3\python.exe -u C:\Users\t-gubenb\source\repos\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\yolo.py", @"C:\Users\t-gubenb\source\repos\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\");
            //var pipe = new YoloJsonPipe(@"C:\Users\shaharp\AppData\Local\Continuum\anaconda3\python.exe", @"c:/src/hackathon/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/yolo.py", @"c:\src\hackathon\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\");
            //var pipe = new YoloJsonPipe(@"cmd.exe", @"/c type c:\temp\sim.txt", null);
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
