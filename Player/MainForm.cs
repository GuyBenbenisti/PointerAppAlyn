// Simple Player sample application
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.DirectShow;
using TobiiAgent;
using UI;
using Tobii.Interaction;
using System.IO;

namespace UI
{
    public partial class MainForm : Form
    {
        private IAgentAnalyzer m_Agent;
        private Stopwatch stopWatch = null;
        ObjectDetector m_Detector;

        // Class constructor//
        public MainForm()
        {
            InitializeComponent();
            m_Detector = new ObjectDetector();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            localVideoCaptureDeviceToolStripMenuItem_Start();
            m_Agent = new TobiiAgentAnalyzer(new Host());
            //m_Agent = new MockAgentAnalyzer();
            m_Agent.StartWatching(this.onDetection);
        }

        // "Exit" menu item clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localVideoCaptureDeviceToolStripMenuItem_Start()
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.CaptureSize = new System.Drawing.Size(1280, 720);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                form.CaptureSize = new System.Drawing.Size(1280, 720);
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource(videoSource);
            }
        }

        // Open local video capture device
        private void localVideoCaptureDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.CaptureSize = new System.Drawing.Size(1280, 720);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                form.CaptureSize = new System.Drawing.Size(1280, 720);
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource(videoSource);
            }
        }

        internal void onDetection(double x, double y)
        {
            double ratio = OS.GetScalingFactor(Handle);
            Point gazeLocation = new Point((int)(x / ratio), (int)(y / ratio));

            var pt = this.PointToClient(new Point((int)x, (int)y));

                Action action = () =>
                {
                    if (Bounds.Contains(pt))
                    {
                        panelDetectionFrame.Location = gazeLocation;
                        panelDetectionFrame.Visible = true;
                    }
                    else
                    {
                        panelDetectionFrame.Visible = false;
                    }
                };

                this.Invoke(action);

            MemoryStream frame_MS = CaptureSnapshot();
            saveImageLocally(frame_MS);
            tryToDetect(frame_MS);
        }

        internal void saveImageLocally(MemoryStream ms)
        {
            try
            {
                string path = @"C:\Users\t-gubenb\Desktop\Test";
                //var imageStream = Image.FromStream(ms);
                //imageStream.Save(outStream, ImageFormat.Jpeg);
                System.Drawing.Image imgSave = System.Drawing.Image.FromStream(ms);
                Bitmap bmSave = new Bitmap(imgSave);
                Bitmap bmTemp = new Bitmap(bmSave);

                Graphics grSave = Graphics.FromImage(bmTemp);
                grSave.DrawImage(imgSave, 0, 0, imgSave.Width, imgSave.Height);

                bmTemp.Save(path + "\\" + "TobiiCapture" + ".jpg");
                imgSave.Dispose();
                bmSave.Dispose();
                bmTemp.Dispose();
                grSave.Dispose();
            }
            catch (Exception ex)
            {
                
            }
        }

        internal MemoryStream CaptureSnapshot()
        {
            if (videoSourcePlayer != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                Bitmap varBmp = videoSourcePlayer.GetCurrentVideoFrame();
                varBmp.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                varBmp.Dispose();
                memoryStream.Seek(0);
                return memoryStream;
                //varBmp.Save(@"C:\a.png", ImageFormat.Png);
            }
            return null;
        }

        internal void tryToDetect(MemoryStream i_MS)
        {
            m_Detector.Detect(i_MS);
        }

        // Open video file using DirectShow
        private void openVideofileusingDirectShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // create video source
                FileVideoSource fileSource = new FileVideoSource(openFileDialog.FileName);

                // open it
                OpenVideoSource(fileSource);
            }
        }

        // Open JPEG URL
        private void openJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLForm form = new URLForm();

            form.Description = "Enter URL of an updating JPEG from a web camera:";
            form.URLs = new string[]
                {
                    "http://195.243.185.195/axis-cgi/jpg/image.cgi?camera=1",
                };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                JPEGStream jpegSource = new JPEGStream(form.URL);

                // open it
                OpenVideoSource(jpegSource);
            }
        }

        // Open MJPEG URL
        private void openMJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLForm form = new URLForm();

            form.Description = "Enter URL of an MJPEG video stream:";
            form.URLs = new string[]
                {
                    "http://195.243.185.195/axis-cgi/mjpg/video.cgi?camera=4",
                    "http://195.243.185.195/axis-cgi/mjpg/video.cgi?camera=3",
                };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                MJPEGStream mjpegSource = new MJPEGStream(form.URL);

                // open it
                OpenVideoSource(mjpegSource);
            }
        }

        // Capture 1st display in the system
        private void capture1stDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenVideoSource(new ScreenCaptureStream(Screen.AllScreens[0].Bounds, 100));
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        // New frame received by the player
        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            DateTime now = DateTime.Now;
            Graphics g = Graphics.FromImage(image);

            // paint current time
            SolidBrush brush = new SolidBrush(Color.Red);
            g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
            brush.Dispose();

            g.Dispose();
        }

        // On timer event - gather statistics
        private void timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if (videoSource != null)
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if (stopWatch == null)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();

                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        private void buttonTakeMeThere_Click(object sender, EventArgs e)
        {

        }

        private void buttonStopTobii_Click(object sender, EventArgs e)
        {

        }

        private void buttonIWhatsThis_Click(object sender, EventArgs e)
        {

        }

        private void buttonWantThis_Click(object sender, EventArgs e)
        {

        }

        private void buttonWhoIsThis_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }
    }
}
