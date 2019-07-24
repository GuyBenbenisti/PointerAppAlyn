using System.Drawing;

namespace UI
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
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelDetectionFrame = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonStopTobii = new System.Windows.Forms.Button();
            this.buttonTakeMeThere = new System.Windows.Forms.Button();
            this.buttonWhoIsThis = new System.Windows.Forms.Button();
            this.buttonWantThis = new System.Windows.Forms.Button();
            this.buttonIWhatsThis = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openVideofileusingDirectShowToolStripMenuItem
            // 
            this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openJPEGURLToolStripMenuItem
            // 
            this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
            this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openMJPEGURLToolStripMenuItem
            // 
            this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
            this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // capture1stDisplayToolStripMenuItem
            // 
            this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
            this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(367, 6);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainPanel.Controls.Add(this.panelDetectionFrame);
            this.mainPanel.Controls.Add(this.buttonSettings);
            this.mainPanel.Controls.Add(this.buttonStopTobii);
            this.mainPanel.Controls.Add(this.buttonTakeMeThere);
            this.mainPanel.Controls.Add(this.buttonWhoIsThis);
            this.mainPanel.Controls.Add(this.buttonWantThis);
            this.mainPanel.Controls.Add(this.buttonIWhatsThis);
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1277, 598);
            this.mainPanel.TabIndex = 2;
            // 
            // panelDetectionFrame
            // 
            this.panelDetectionFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDetectionFrame.BackColor = System.Drawing.Color.Lime;
            this.panelDetectionFrame.Location = new System.Drawing.Point(378, 155);
            this.panelDetectionFrame.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetectionFrame.Name = "panelDetectionFrame";
            this.panelDetectionFrame.Size = new System.Drawing.Size(33, 32);
            this.panelDetectionFrame.TabIndex = 10;
            this.panelDetectionFrame.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSettings.Location = new System.Drawing.Point(0, 269);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSettings.Size = new System.Drawing.Size(85, 52);
            this.buttonSettings.TabIndex = 10;
            this.buttonSettings.Text = "הגדרות";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(10);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(1277, 598);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // buttonStopTobii
            // 
            this.buttonStopTobii.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStopTobii.BackColor = System.Drawing.Color.White;
            this.buttonStopTobii.BackgroundImage = global::Player.Properties.Resources.stop;
            this.buttonStopTobii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStopTobii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopTobii.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopTobii.ForeColor = System.Drawing.Color.Black;
            this.buttonStopTobii.Location = new System.Drawing.Point(565, 0);
            this.buttonStopTobii.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopTobii.Name = "buttonStopTobii";
            this.buttonStopTobii.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonStopTobii.Size = new System.Drawing.Size(150, 150);
            this.buttonStopTobii.TabIndex = 9;
            this.buttonStopTobii.Text = "עצור";
            this.buttonStopTobii.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStopTobii.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStopTobii.UseVisualStyleBackColor = false;
            this.buttonStopTobii.Click += new System.EventHandler(this.buttonStopTobii_Click);
            // 
            // buttonTakeMeThere
            // 
            this.buttonTakeMeThere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTakeMeThere.AutoSize = true;
            this.buttonTakeMeThere.BackColor = System.Drawing.Color.White;
            this.buttonTakeMeThere.BackgroundImage = global::Player.Properties.Resources.go;
            this.buttonTakeMeThere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTakeMeThere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeMeThere.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeMeThere.ForeColor = System.Drawing.Color.Black;
            this.buttonTakeMeThere.Location = new System.Drawing.Point(1125, 446);
            this.buttonTakeMeThere.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeMeThere.Name = "buttonTakeMeThere";
            this.buttonTakeMeThere.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonTakeMeThere.Size = new System.Drawing.Size(150, 150);
            this.buttonTakeMeThere.TabIndex = 8;
            this.buttonTakeMeThere.Text = "לשם";
            this.buttonTakeMeThere.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTakeMeThere.UseVisualStyleBackColor = false;
            this.buttonTakeMeThere.Click += new System.EventHandler(this.buttonTakeMeThere_Click);
            // 
            // buttonWhoIsThis
            // 
            this.buttonWhoIsThis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWhoIsThis.BackColor = System.Drawing.Color.White;
            this.buttonWhoIsThis.BackgroundImage = global::Player.Properties.Resources.who;
            this.buttonWhoIsThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonWhoIsThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhoIsThis.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhoIsThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWhoIsThis.Location = new System.Drawing.Point(1125, 0);
            this.buttonWhoIsThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWhoIsThis.Name = "buttonWhoIsThis";
            this.buttonWhoIsThis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonWhoIsThis.Size = new System.Drawing.Size(150, 150);
            this.buttonWhoIsThis.TabIndex = 4;
            this.buttonWhoIsThis.Text = "מי זה?";
            this.buttonWhoIsThis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWhoIsThis.UseVisualStyleBackColor = false;
            this.buttonWhoIsThis.Click += new System.EventHandler(this.buttonWhoIsThis_Click);
            // 
            // buttonWantThis
            // 
            this.buttonWantThis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWantThis.BackColor = System.Drawing.Color.White;
            this.buttonWantThis.BackgroundImage = global::Player.Properties.Resources.get;
            this.buttonWantThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWantThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWantThis.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWantThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWantThis.Location = new System.Drawing.Point(0, 446);
            this.buttonWantThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWantThis.Name = "buttonWantThis";
            this.buttonWantThis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonWantThis.Size = new System.Drawing.Size(150, 150);
            this.buttonWantThis.TabIndex = 6;
            this.buttonWantThis.Text = "רוצה";
            this.buttonWantThis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWantThis.UseVisualStyleBackColor = false;
            this.buttonWantThis.Click += new System.EventHandler(this.buttonWantThis_Click);
            // 
            // buttonIWhatsThis
            // 
            this.buttonIWhatsThis.BackColor = System.Drawing.Color.White;
            this.buttonIWhatsThis.BackgroundImage = global::Player.Properties.Resources.what;
            this.buttonIWhatsThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIWhatsThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIWhatsThis.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIWhatsThis.ForeColor = System.Drawing.Color.Black;
            this.buttonIWhatsThis.Location = new System.Drawing.Point(0, 0);
            this.buttonIWhatsThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIWhatsThis.Name = "buttonIWhatsThis";
            this.buttonIWhatsThis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonIWhatsThis.Size = new System.Drawing.Size(150, 150);
            this.buttonIWhatsThis.TabIndex = 6;
            this.buttonIWhatsThis.Text = "מה זה?";
            this.buttonIWhatsThis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIWhatsThis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonIWhatsThis.UseVisualStyleBackColor = false;
            this.buttonIWhatsThis.Click += new System.EventHandler(this.buttonIWhatsThis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1277, 598);
            this.Controls.Add(this.mainPanel);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointer App - Alyn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
        private System.Windows.Forms.Button buttonTakeMeThere;
        private System.Windows.Forms.Button buttonWhoIsThis;
        private System.Windows.Forms.Button buttonIWhatsThis;
        private System.Windows.Forms.Button buttonWantThis;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button buttonStopTobii;
        private System.Windows.Forms.Panel panelDetectionFrame;
        private System.Windows.Forms.Button buttonSettings;
    }
}