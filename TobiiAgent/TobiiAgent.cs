using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace TobiiAgent
{
    public class TobiiAgentAnalyzer : IAgentAnalyzer
    {
        private readonly double m_FixationThreshold = 1.5; // Threshold for the kids gaze time before sending the object to the manager for recognition.
        private bool m_SentForRecognition;
        //private bool m_FixationBeginWithoutEnd;
        private Host m_host;
        private FixationDataStream m_Stream;
        public TobiiAgentAnalyzer(object host)
        {
            //m_FixationBeginWithoutEnd = false;
            m_SentForRecognition = false;
            this.m_host = new Host();
            m_Stream = m_host.Streams.CreateFixationDataStream(FixationDataMode.Sensitive, true);
        }

        // This method registers the callbacks for fixation begin, during, and end.
        // On begin, timestamp is reset, during we check if the fixation time is passed the threshold and if the object was not sent for recognition before. If so, we run the method i_RecognizeMethod which is from the manager,
        // And responsible for recognizing the object in location x,y.
        public void StartWatching(Action<double, double> i_RecognizeMethod)
        {
            // Because timestamp of fixation events is relative to the previous ones
            // only, we will store them in this variable.
            var fixationBeginTime = 0d;

            // On fixation begin
            m_Stream.Next += async (o, fixation) =>
            {
                // On the Next event, data comes as FixationData objects, wrapped in a StreamData<T> object.
                var fixationPointX = fixation.Data.X;
                var fixationPointY = fixation.Data.Y;

                switch (fixation.Data.EventType)
                {
                    case FixationDataEventType.Begin:
                        //if (!m_FixationBeginWithoutEnd)
                        //{
                        fixationBeginTime = fixation.Data.Timestamp;
                        //    m_FixationBeginWithoutEnd = true;
                        //}
                        break;

                    case FixationDataEventType.Data:
                        if (!m_SentForRecognition && ((fixation.Data.Timestamp - fixationBeginTime) / 1000) >= m_FixationThreshold)
                        {
                            //m_FixationBeginWithoutEnd = false;
                            this.m_host.DisableConnection();
                            i_RecognizeMethod.Invoke(fixationPointX, fixationPointY);
                            this.m_host.EnableConnection();
                            m_SentForRecognition = true;
                        }
                        break;

                    case FixationDataEventType.End:
                        //m_FixationBeginWithoutEnd = false;
                        m_SentForRecognition = false;
                        break;

                    default:
                        throw new InvalidOperationException("Unknown fixation event type, which doesn't have explicit handling.");
                }
            };
        }
    }
}
