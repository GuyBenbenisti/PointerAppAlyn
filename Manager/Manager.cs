using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobii.Interaction;
using TobiiAgent;
using UI;

namespace Manager
{
    class Manager
    {
        private TobiiAgentAnalyzer m_Agent = new TobiiAgent.TobiiAgentAnalyzer(new Host());
        private ObjectDetector m_Detector;
        private void TryAndRecognize(double i_PointX, double i_PointY)
        {
            //TODO: Implement
            throw new Exception("Not implemented");
        }
    }
}
