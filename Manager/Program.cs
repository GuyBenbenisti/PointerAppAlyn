using VideoAppAndObjectDetector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tobii.Interaction;

namespace Manager
{
    public static class Program
    {
        static TobiiAgent.TobiiAgent m_Agent = new TobiiAgent.TobiiAgent(new Host());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

        private static void TryAndRecognize(double i_PointX, double i_PointY)
        {
            //TODO: Implement
            throw new Exception("Not implemented");
        }

    }
}
