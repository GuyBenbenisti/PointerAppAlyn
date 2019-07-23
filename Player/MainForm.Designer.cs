using System.Drawing;

namespace ObjectDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelWhatIsThis = new System.Windows.Forms.Label();
            this.labelWhoIsThis = new System.Windows.Forms.Label();
            this.labelIWantThis = new System.Windows.Forms.Label();
            this.labelTakeMeThere = new System.Windows.Forms.Label();
            this.buttonTakeMeThere = new System.Windows.Forms.Button();
            this.buttonIWantThis = new System.Windows.Forms.Button();
            this.buttonWhoIsThis = new System.Windows.Forms.Button();
            this.buttonWhatIsThis = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(651, 35);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            //this.openVideofileusingDirectShowToolStripMenuItem,
            //this.openJPEGURLToolStripMenuItem,
            //this.openMJPEGURLToolStripMenuItem,
            //this.capture1stDisplayToolStripMenuItem,
            //this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // localVideoCaptureDeviceToolStripMenuItem
            // 
            this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
            this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
            this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
            //// 
            //// openVideofileusingDirectShowToolStripMenuItem
            //// 
            //this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            //this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            //this.openVideofileusingDirectShowToolStripMenuItem.Text = "Open video &file (using DirectShow)";
            //this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideofileusingDirectShowToolStripMenuItem_Click);
            //// 
            //// openJPEGURLToolStripMenuItem
            //// 
            //this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
            //this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            //this.openJPEGURLToolStripMenuItem.Text = "Open JPEG &URL";
            //this.openJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openJPEGURLToolStripMenuItem_Click);
            //// 
            //// openMJPEGURLToolStripMenuItem
            //// 
            //this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
            //this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            //this.openMJPEGURLToolStripMenuItem.Text = "Open &MJPEG URL";
            //this.openMJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openMJPEGURLToolStripMenuItem_Click);
            //// 
            //// capture1stDisplayToolStripMenuItem
            //// 
            //this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
            //this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            //this.capture1stDisplayToolStripMenuItem.Text = "Capture 1st display";
            //this.capture1stDisplayToolStripMenuItem.Click += new System.EventHandler(this.capture1stDisplayToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(367, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 523);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(651, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(628, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(651, 545);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.labelTakeMeThere);
            this.mainPanel.Controls.Add(this.buttonTakeMeThere);
            this.mainPanel.Controls.Add(this.labelIWantThis);
            this.mainPanel.Controls.Add(this.buttonIWantThis);
            this.mainPanel.Controls.Add(this.labelWhoIsThis);
            this.mainPanel.Controls.Add(this.buttonWhoIsThis);
            this.mainPanel.Controls.Add(this.labelWhatIsThis);
            this.mainPanel.Controls.Add(this.buttonWhatIsThis);
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new Size(1723, 976);
            this.mainPanel.TabIndex = 2;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(164, 123);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // labelWhatIsThis
            // 
            //this.labelWhatIsThis.Visible = false;
            this.labelWhatIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWhatIsThis.Location = new System.Drawing.Point(2, 95);
            this.labelWhatIsThis.Name = "labelWhatIsThis";
            this.labelWhatIsThis.Size = new System.Drawing.Size(149, 29);
            this.labelWhatIsThis.TabIndex = 3;
            this.labelWhatIsThis.Text = "מה זה?";
            this.labelWhatIsThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWhoIsThis
            // 
            this.labelWhoIsThis.Visible = false;
            this.labelWhoIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWhoIsThis.Location = new System.Drawing.Point(502, 95);
            this.labelWhoIsThis.Name = "labelWhoIsThis";
            this.labelWhoIsThis.Size = new System.Drawing.Size(149, 29);
            this.labelWhoIsThis.TabIndex = 5;
            this.labelWhoIsThis.Text = "מי זה?";
            this.labelWhoIsThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIWantThis
            // 
            this.labelIWantThis.Visible = false;
            this.labelIWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIWantThis.Location = new Point(this.Left, this.Top + 89);
            this.labelIWantThis.Name = "labelIWantThis";
            this.labelIWantThis.Size = new System.Drawing.Size(149, 29);
            this.labelIWantThis.TabIndex = 7;
            this.labelIWantThis.Text = "רוצה";
            this.labelIWantThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTakeMeThere
            // 
            //this.labelTakeMeThere.Visible = false;
            this.labelTakeMeThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTakeMeThere.Location = new Point(this.Right - 149, this.Bottom - (89 + 29));
            this.labelTakeMeThere.Name = "labelTakeMeThere";
            this.labelTakeMeThere.Size = new System.Drawing.Size(149, 29);
            this.labelTakeMeThere.TabIndex = 9;
            this.labelTakeMeThere.Text = "לשם";
            this.labelTakeMeThere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTakeMeThere
            // 
            //this.buttonTakeMeThere.Visible = false;
            this.buttonTakeMeThere.BackgroundImage = global::ObjectDetector.Properties.Resources.takeMeThere;
            this.buttonTakeMeThere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTakeMeThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeMeThere.ForeColor = System.Drawing.Color.Black;
            this.buttonTakeMeThere.Location = this.labelTakeMeThere.Location = new Point(this.Right - 149, this.Bottom - 89);
            this.buttonTakeMeThere.Name = "buttonTakeMeThere";
            this.buttonTakeMeThere.Size = new System.Drawing.Size(149, 89);
            this.buttonTakeMeThere.TabIndex = 8;
            this.buttonTakeMeThere.UseVisualStyleBackColor = true;
            // 
            // buttonIWantThis
            // 
            this.buttonIWantThis.Visible = false;
            this.buttonIWantThis.BackgroundImage = global::ObjectDetector.Properties.Resources.iWantThis;
            this.buttonIWantThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIWantThis.ForeColor = System.Drawing.Color.Black;
            this.buttonIWantThis.Location = new System.Drawing.Point(3, 396);
            this.buttonIWantThis.Name = "buttonIWantThis";
            this.buttonIWantThis.Size = new System.Drawing.Size(149, 89);
            this.buttonIWantThis.TabIndex = 6;
            this.buttonIWantThis.UseVisualStyleBackColor = true;
            // 
            // buttonWhoIsThis
            // 
            this.buttonWhoIsThis.Visible = false;
            this.buttonWhoIsThis.BackgroundImage = global::ObjectDetector.Properties.Resources.whoIsThis;
            this.buttonWhoIsThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWhoIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhoIsThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWhoIsThis.Location = new System.Drawing.Point(503, 3);
            this.buttonWhoIsThis.Name = "buttonWhoIsThis";
            this.buttonWhoIsThis.Size = new System.Drawing.Size(149, 89);
            this.buttonWhoIsThis.TabIndex = 4;
            this.buttonWhoIsThis.UseVisualStyleBackColor = true;
            // 
            // buttonWhatIsThis
            // 
            //this.buttonWhatIsThis.Visible = false;
            this.buttonWhatIsThis.BackgroundImage = global::ObjectDetector.Properties.Resources.whatIsThis;
            this.buttonWhatIsThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWhatIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhatIsThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWhatIsThis.Location = new System.Drawing.Point(0, 3);
            this.buttonWhatIsThis.Name = "buttonWhatIsThis";
            this.buttonWhatIsThis.Size = new System.Drawing.Size(149, 89);
            this.buttonWhatIsThis.TabIndex = 1;
            this.buttonWhatIsThis.UseVisualStyleBackColor = true;
            //
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
        private System.Windows.Forms.Button buttonWhatIsThis;
        private System.Windows.Forms.Label labelTakeMeThere;
        private System.Windows.Forms.Button buttonTakeMeThere;
        private System.Windows.Forms.Label labelIWantThis;
        private System.Windows.Forms.Button buttonIWantThis;
        private System.Windows.Forms.Label labelWhoIsThis;
        private System.Windows.Forms.Button buttonWhoIsThis;
        private System.Windows.Forms.Label labelWhatIsThis;
    }
}