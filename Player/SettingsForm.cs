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
using Player.Properties;

namespace UI
{
    public partial class SettingsForm : Form
    {
        private Action<double> updateDelay;
        // Class constructor
        public SettingsForm(Action<double> i_UpdateDelay)
        {
            InitializeComponent();
            updateDelay = i_UpdateDelay;
        }

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gazePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gazeDelay = new System.Windows.Forms.Label();
            this.soundAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.gazeDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainPanel.SuspendLayout();
            this.gazePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gazeDelayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.soundAlertsCheckBox);
            this.mainPanel.Controls.Add(this.gazePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainPanel.Size = new System.Drawing.Size(484, 461);
            this.mainPanel.TabIndex = 1;
            // 
            // soundAlertsCheckBox
            // 
            this.soundAlertsCheckBox.AutoSize = true;
            this.soundAlertsCheckBox.Checked = global::Player.Properties.Settings.Default.SoundAlerts;
            this.soundAlertsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundAlertsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Player.Properties.Settings.Default, "SoundAlerts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soundAlertsCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundAlertsCheckBox.Location = new System.Drawing.Point(206, 23);
            this.soundAlertsCheckBox.Name = "soundAlertsCheckBox";
            this.soundAlertsCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.soundAlertsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.soundAlertsCheckBox.Size = new System.Drawing.Size(235, 54);
            this.soundAlertsCheckBox.TabIndex = 0;
            this.soundAlertsCheckBox.Text = "התראות קוליות";
            this.soundAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // gazePanel
            // 
            this.gazePanel.ColumnCount = 2;
            this.gazePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gazePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gazePanel.Controls.Add(this.gazeDelayUpDown, 1, 0);
            this.gazePanel.Controls.Add(this.gazeDelay, 0, 0);
            this.gazePanel.Location = new System.Drawing.Point(51, 83);
            this.gazePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.gazePanel.Name = "gazePanel";
            this.gazePanel.RowCount = 1;
            this.gazePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gazePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gazePanel.Size = new System.Drawing.Size(390, 45);
            this.gazePanel.TabIndex = 6;
            // 
            // gazeDelay
            // 
            this.gazeDelay.AutoSize = true;
            this.gazeDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gazeDelay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gazeDelay.Location = new System.Drawing.Point(195, 0);
            this.gazeDelay.Margin = new System.Windows.Forms.Padding(0);
            this.gazeDelay.Name = "gazeDelay";
            this.gazeDelay.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gazeDelay.Size = new System.Drawing.Size(195, 45);
            this.gazeDelay.TabIndex = 2;
            this.gazeDelay.Text = "עיכוב באזור המבט (בשניות)";
            this.gazeDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundAlertsCheckBox
            // 
            this.soundAlertsCheckBox.AutoSize = true;
            this.soundAlertsCheckBox.Checked = global::Player.Properties.Settings.Default.SoundAlerts;
            this.soundAlertsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundAlertsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Player.Properties.Settings.Default, "SoundAlerts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soundAlertsCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundAlertsCheckBox.Location = new System.Drawing.Point(282, 23);
            this.soundAlertsCheckBox.Name = "soundAlertsCheckBox";
            this.soundAlertsCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.soundAlertsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.soundAlertsCheckBox.Size = new System.Drawing.Size(159, 39);
            this.soundAlertsCheckBox.TabIndex = 0;
            this.soundAlertsCheckBox.Text = "התראות קוליות";
            this.soundAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // gazeDelayUpDown
            // 
            this.gazeDelayUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gazeDelayUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Player.Properties.Settings.Default, "gazeDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gazeDelayUpDown.DecimalPlaces = 1;
            this.gazeDelayUpDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gazeDelayUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.gazeDelayUpDown.Location = new System.Drawing.Point(41, 8);
            this.gazeDelayUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.gazeDelayUpDown.Name = "gazeDelayUpDown";
            this.gazeDelayUpDown.Size = new System.Drawing.Size(120, 29);
            this.gazeDelayUpDown.TabIndex = 3;
            this.gazeDelayUpDown.Value = global::Player.Properties.Settings.Default.gazeDelay;
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.gazePanel.ResumeLayout(false);
            this.gazePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gazeDelayUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateDelay.Invoke(this.gazeDelayUpDown.Value);
        }

        private void circleShowTimeout_Click(object sender, EventArgs e)
        {

        }
    }
}
