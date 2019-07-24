using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobii.Interaction;

namespace Manager
{
    class Manager
    {
        private TobiiAgent.TobiiAgent m_Agent = new TobiiAgent.TobiiAgent(new Host());
        private UI.ObjectDetector m_Detector;
        private void TryAndRecognize(double i_PointX, double i_PointY)
        {
            //TODO: Implement
            throw new Exception("Not implemented");
        }
    }
}
