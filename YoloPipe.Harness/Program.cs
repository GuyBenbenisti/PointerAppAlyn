using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoloPipe.Harness
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestYoloPipe();
            Console.WriteLine("Hit enter to start");
            Console.ReadLine();
            TestYoloJsonPipe();
            Console.ReadLine();
        }

        private static async Task TestYoloJsonPipe()
        {
            var pipe = new YoloJsonPipe("cmd.exe", @"/C C:\Users\shaharp\AppData\Local\Continuum\anaconda3\Scripts\activate.bat C:\Users\shaharp\AppData\Local\Continuum\anaconda3 & C:\Users\shaharp\AppData\Local\Continuum\anaconda3\python.exe -u c:/src/hackathon/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/yolo.py", @"c:\src\hackathon\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\");
            //var pipe = new YoloJsonPipe(@"C:\Users\shaharp\AppData\Local\Continuum\anaconda3\python.exe", @"c:/src/hackathon/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/yolo.py", @"c:\src\hackathon\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\");
            //var pipe = new YoloJsonPipe(@"cmd.exe", @"/c type c:\temp\sim.txt", null);
            pipe.Start();

            int i = 0;
            while (true)
            {
                var obj = await pipe.ReadJsonObjextAsync();
                if (obj != null)
                {
                    i++;
                    Console.WriteLine($"Read {obj.Length} chars. Object #{i}");
                }
            }
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
                Console.WriteLine(line);
            } while (line != null);
        }
    }
}
