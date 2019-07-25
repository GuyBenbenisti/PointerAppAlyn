using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using YoloPipe.Harness;

namespace UI
{
    public class ObjectDetector
    {
        public float PointX { get; set; }
        public float PointY { get; set; }

        public async void DetectFromImagePath()
        {
            // Change path inside Harness.TestYoloJsonPipe
            await Harness.TestYoloJsonPipe(PointX, PointY);
        }

        //public async void Detect(MemoryStream i_MS)
        //{
        //    ComputerVisionClient computerVision = new ComputerVisionClient(
        //        new ApiKeyServiceClientCredentials(m_SubscriptionKey),
        //        new System.Net.Http.DelegatingHandler[] { });

        //    // Specify the Azure region
        //    computerVision.Endpoint = "https://westcentralus.api.cognitive.microsoft.com";

        //    string localImagePath = @"C:\Users\t-gubenb\Desktop\Test\TobiiCapture.jpg";
        //    var analysis = AnalyzeLocalAsyncFromMemoryStream(computerVision, i_MS);
        //}

        //private static async Task AnalyzeLocalAsyncFromMemoryStream(
        //    ComputerVisionClient computerVision, MemoryStream i_MS)
        //{
        //        DetectResult analysis = await computerVision.DetectObjectsInStreamAsync(i_MS);
        //        foreach (DetectedObject obj in analysis.Objects)
        //        {
        //            //Console.WriteLine("ObjectProperty: {0}, Confidence: {1},", obj.ObjectProperty, obj.Confidence);
        //        }
        //}
        //private static async Task AnalyzeLocalAsync(
        //    ComputerVisionClient computerVision, string imagePath)
        //{
        //    if (!File.Exists(imagePath))
        //    {
        //        return;
        //    }

        //    using (Stream imageStream = File.OpenRead(imagePath))
        //    {
        //        DetectResult analysis = await computerVision.DetectObjectsInStreamAsync(imageStream);
        //        foreach (DetectedObject obj in analysis.Objects)
        //        {
        //            //Console.WriteLine("ObjectProperty: {0}, Confidence: {1},", obj.ObjectProperty, obj.Confidence);
        //        }
        //    }
        //}
    }
}