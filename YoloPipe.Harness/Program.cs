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
            TestYoloJsonPipe();
            Console.ReadLine();
        }

        private static async Task TestYoloJsonPipe()
        {
            var pipe = new YoloJsonPipe("cmd.exe", "/c type c:\\temp\\sim.txt");
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
