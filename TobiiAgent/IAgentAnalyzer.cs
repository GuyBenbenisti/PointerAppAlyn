using System;

namespace TobiiAgent
{
    public interface IAgentAnalyzer
    {
        void StartWatching(Action<double, double> i_RecognizeMethod);
    }
}