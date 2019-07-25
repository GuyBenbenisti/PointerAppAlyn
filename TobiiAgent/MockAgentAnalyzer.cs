using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobiiAgent
{
    public class MockAgentAnalyzer : IAgentAnalyzer
    {
        public async void StartWatching(Action<double, double> i_RecognizeMethod)
        {
            var r = new Random();
            var size = OS.GetNativeResolution();
            while (true)
            {
                if (r.NextDouble() < 0.2)
                {
                    var x = r.Next(0, size.Width);
                    var y = r.Next(0, size.Height);
                    i_RecognizeMethod(x, y);
                }

                await Task.Delay(700);
            }
        }

        public void UpdateDelayThreshold(double i_Delay)
        {
            throw new NotImplementedException();
        }
    }
}
