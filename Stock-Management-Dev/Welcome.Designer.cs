namespace Stock_Management_Dev
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            enterbtn = new DevExpress.XtraEditors.SimpleButton();
            pswrd_txt = new System.Windows.Forms.TextBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = Properties.Resources.welcome;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(438, 368);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(20, 371);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(404, 38);
            label1.TabIndex = 1;
            label1.Text = "مرحباً ، من فضلك ادخل كلمة السر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 14);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 31);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // enterbtn
            // 
            enterbtn.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            enterbtn.Appearance.Font = new System.Drawing.Font("LBC", 16.1999989F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            enterbtn.Appearance.Options.UseBackColor = true;
            enterbtn.Appearance.Options.UseFont = true;
            enterbtn.Location = new System.Drawing.Point(147, 471);
            enterbtn.Margin = new System.Windows.Forms.Padding(5);
            enterbtn.Name = "enterbtn";
            enterbtn.Size = new System.Drawing.Size(142, 42);
            enterbtn.TabIndex = 4;
            enterbtn.Text = "دخول";
            enterbtn.Click += enterbtn_Click;
            // 
            // pswrd_txt
            // 
            pswrd_txt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            pswrd_txt.Location = new System.Drawing.Point(104, 423);
            pswrd_txt.Margin = new System.Windows.Forms.Padding(5);
            pswrd_txt.Name = "pswrd_txt";
            pswrd_txt.Size = new System.Drawing.Size(229, 37);
            pswrd_txt.TabIndex = 5;
            pswrd_txt.KeyDown += pswrd_txt_KeyDown;
            // 
            // simpleButton1
            // 
            simpleButton1.AutoSize = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new System.Drawing.Point(390, 1);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(46, 44);
            simpleButton1.TabIndex = 6;
            simpleButton1.Click += simpleButton2_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MidnightBlue;
            ClientSize = new System.Drawing.Size(438, 526);
            Controls.Add(simpleButton1);
            Controls.Add(pswrd_txt);
            Controls.Add(enterbtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Welcome";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Welcome_Load;
            Shown += Welcome_Shown;
            MouseDown += Welcome_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton enterbtn;
        private System.Windows.Forms.TextBox pswrd_txt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}