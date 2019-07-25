using System;

namespace TobiiAgent
{
    public interface IAgentAnalyzer
    {
        void UpdateDelayThreshold(double i_Delay);
        void StartWatching(Action<double, double> i_RecognizeMethod);
    }
}