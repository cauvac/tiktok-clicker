﻿namespace tiktok_clicker
{
    partial class camera
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.MaximumSize = new Size(308, 15);
            label1.MinimumSize = new Size(312, 15);
            label1.Name = "label1";
            label1.Size = new Size(312, 15);
            label1.TabIndex = 0;
            label1.Text = "You'll reach the next level in 999,999,999 seconds or less";
            // 
            // camera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 41);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(350, 80);
            MinimizeBox = false;
            MinimumSize = new Size(350, 80);
            Name = "camera";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "camera";
            Load += camera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}