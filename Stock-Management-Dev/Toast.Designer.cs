namespace Stock_Management_Dev
{
    partial class Toast
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
            panel1 = new System.Windows.Forms.Panel();
            txt_caption = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Blue;
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(472, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(25, 107);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txt_caption
            // 
            txt_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_caption.Font = new System.Drawing.Font("LBC", 19.7999973F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txt_caption.Location = new System.Drawing.Point(0, 0);
            txt_caption.Name = "txt_caption";
            txt_caption.Size = new System.Drawing.Size(472, 107);
            txt_caption.TabIndex = 4;
            txt_caption.Text = "الرسالة";
            txt_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txt_caption.Click += txt_caption_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(90, 107);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Toast
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(497, 107);
            Controls.Add(pictureBox1);
            Controls.Add(txt_caption);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Toast";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Toast";
            TopMost = true;
            Click += Toast_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label txt_caption;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}