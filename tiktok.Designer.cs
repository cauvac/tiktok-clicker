namespace tiktok_clicker
{
    partial class tiktok
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tiktok));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.TikTok_logo;
            pictureBox1.Location = new Point(37, 32);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(37, 413);
            button1.Name = "button1";
            button1.Size = new Size(270, 23);
            button1.TabIndex = 1;
            button1.Text = "tiktok (x1)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-329, 302);
            label1.MinimumSize = new Size(1000, 60);
            label1.Name = "label1";
            label1.Size = new Size(1000, 60);
            label1.TabIndex = 2;
            label1.Text = "0 tiktok";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 438);
            button2.Name = "button2";
            button2.Size = new Size(270, 23);
            button2.TabIndex = 3;
            button2.Text = "upgrade tiktok (50 tiktok)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(37, 464);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "get updates";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(207, 464);
            label2.MinimumSize = new Size(100, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "tc v.";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 362);
            label3.MinimumSize = new Size(270, 20);
            label3.Name = "label3";
            label3.Size = new Size(270, 21);
            label3.TabIndex = 6;
            label3.Text = "level 1";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 362);
            label4.MaximumSize = new Size(200, 20);
            label4.MinimumSize = new Size(200, 20);
            label4.Name = "label4";
            label4.Size = new Size(200, 20);
            label4.TabIndex = 7;
            label4.Text = "0 tps";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 482);
            label5.MaximumSize = new Size(270, 20);
            label5.MinimumSize = new Size(270, 25);
            label5.Name = "label5";
            label5.Size = new Size(270, 25);
            label5.TabIndex = 8;
            label5.Text = "(c) patcha de som 2024 software engineering department";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 386);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(270, 23);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.webcam_icon;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(37, 6);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(151, 6);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(232, 6);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "load";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "save file";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 13;
            // 
            // tiktok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 511);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(360, 550);
            MinimumSize = new Size(360, 550);
            Name = "tiktok";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tiktok clicker";
            Load += tiktok_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label5;
        private ProgressBar progressBar1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
    }
}