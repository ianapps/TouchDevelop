﻿namespace Microsoft.MicroBit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusLabel = new System.Windows.Forms.Label();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.versionLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Window;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 251);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(364, 23);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "loading...";
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackColor = System.Drawing.Color.White;
            this.backgroundPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundPictureBox.Image = global::Microsoft.MicroBit.Properties.Resources.logo480;
            this.backgroundPictureBox.InitialImage = null;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, -2);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(388, 238);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Click += new System.EventHandler(this.backgroundPictureBox_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(348, 255);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.TabStop = true;
            this.versionLabel.Text = "v0.6";
            this.versionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.versionLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 283);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.backgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft Uploader for micro:bit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.LinkLabel versionLabel;
    }
}

