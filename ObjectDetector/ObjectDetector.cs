using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System.IO;
using System.Threading.Tasks;

namespace UI
{
    public class ObjectDetector
    {
        // subscriptionKey = "0123456789abcdef0123456789ABCDEF"
        private const string m_SubscriptionKey = "f00b15e35dc54148aed210c0611136f5";

        public async void Detect(MemoryStream i_MS)
        {
            ComputerVisionClient computerVision = new ComputerVisionClient(
                new ApiKeyServiceClientCredentials(m_SubscriptionKey),
                new System.Net.Http.DelegatingHandler[] { });

            // Specify the Azure region
            computerVision.Endpoint = "https://westcentralus.api.cognitive.microsoft.com";

            string localImagePath = @"C:\Users\t-gubenb\Desktop\Test\TobiiCapture.jpg";
            using(Stream imagestream = i_MS)
            {
               var analysis = AnalyzeLocalAsync(computerVision, localImagePath);
            }
        }

        private static async Task AnalyzeLocalAsync(
            ComputerVisionClient computerVision, string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                return;
            }

            using (Stream imageStream = File.OpenRead(imagePath))
            {
                DetectResult analysis = await computerVision.DetectObjectsInStreamAsync(imageStream);
                foreach (DetectedObject obj in analysis.Objects)
                {
                    //Console.WriteLine("ObjectProperty: {0}, Confidence: {1},", obj.ObjectProperty, obj.Confidence);
                }
            }
        }
    }
}