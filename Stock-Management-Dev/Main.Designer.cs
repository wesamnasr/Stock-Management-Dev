namespace Stock_Management_Dev
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pn_cont = new System.Windows.Forms.Panel();
            pn_container = new System.Windows.Forms.Panel();
            pn_topbar = new DevExpress.XtraEditors.PanelControl();
            label_title = new System.Windows.Forms.Label();
            btn_max = new DevExpress.XtraEditors.SimpleButton();
            btn_min = new DevExpress.XtraEditors.SimpleButton();
            btn_close = new DevExpress.XtraEditors.SimpleButton();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            pn_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pn_topbar).BeginInit();
            pn_topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // pn_cont
            // 
            pn_cont.BackColor = System.Drawing.Color.Transparent;
            pn_cont.Controls.Add(pn_container);
            pn_cont.Controls.Add(pn_topbar);
            pn_cont.Controls.Add(accordionControl1);
            pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_cont.Location = new System.Drawing.Point(0, 0);
            pn_cont.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            pn_cont.Name = "pn_cont";
            pn_cont.Size = new System.Drawing.Size(1280, 720);
            pn_cont.TabIndex = 3;
            pn_cont.Paint += pn_cont_Paint;
            // 
            // pn_container
            // 
            pn_container.BackColor = System.Drawing.Color.White;
            pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_container.Location = new System.Drawing.Point(0, 84);
            pn_container.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            pn_container.Name = "pn_container";
            pn_container.Size = new System.Drawing.Size(988, 636);
            pn_container.TabIndex = 5;
            // 
            // pn_topbar
            // 
            pn_topbar.Appearance.BackColor = System.Drawing.Color.LightGray;
            pn_topbar.Appearance.Options.UseBackColor = true;
            pn_topbar.Controls.Add(label_title);
            pn_topbar.Controls.Add(btn_max);
            pn_topbar.Controls.Add(btn_min);
            pn_topbar.Controls.Add(btn_close);
            pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            pn_topbar.Location = new System.Drawing.Point(0, 0);
            pn_topbar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            pn_topbar.Name = "pn_topbar";
            pn_topbar.Size = new System.Drawing.Size(988, 84);
            pn_topbar.TabIndex = 4;
            pn_topbar.MouseDown += panelControl1_MouseDown;
            // 
            // label_title
            // 
            label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            label_title.AutoSize = true;
            label_title.BackColor = System.Drawing.Color.WhiteSmoke;
            label_title.Font = new System.Drawing.Font("LBC", 22.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_title.Location = new System.Drawing.Point(471, 20);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(144, 47);
            label_title.TabIndex = 6;
            label_title.Text = "الرئيسية";
            // 
            // btn_max
            // 
            btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_max.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_max.ImageOptions.SvgImage");
            btn_max.Location = new System.Drawing.Point(66, 20);
            btn_max.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btn_max.Name = "btn_max";
            btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btn_max.Size = new System.Drawing.Size(50, 50);
            btn_max.TabIndex = 5;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_min.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_min.ImageOptions.SvgImage");
            btn_min.Location = new System.Drawing.Point(122, 20);
            btn_min.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btn_min.Name = "btn_min";
            btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btn_min.Size = new System.Drawing.Size(50, 50);
            btn_min.TabIndex = 4;
            btn_min.Click += btn_min_Click;
            // 
            // btn_close
            // 
            btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_close.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_close.ImageOptions.SvgImage");
            btn_close.Location = new System.Drawing.Point(14, 18);
            btn_close.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btn_close.Name = "btn_close";
            btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btn_close.Size = new System.Drawing.Size(50, 50);
            btn_close.TabIndex = 3;
            btn_close.Click += btn_close_Click;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement8, accordionControlElement1, accordionControlElement9, accordionControlElement4, accordionControlElement13, accordionControlElement10, accordionControlElement11, accordionControlElement12 });
            accordionControl1.Location = new System.Drawing.Point(988, 0);
            accordionControl1.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            accordionControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            accordionControl1.Size = new System.Drawing.Size(292, 720);
            accordionControl1.TabIndex = 3;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            accordionControl1.ElementClick += accordionControl1_ElementClick;
            // 
            // accordionControlElement8
            // 
            accordionControlElement8.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement8.Appearance.Default.Options.UseFont = true;
            accordionControlElement8.Height = 60;
            accordionControlElement8.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement8.ImageOptions.Image");
            accordionControlElement8.ImageOptions.ImageUri.Uri = "Home";
            accordionControlElement8.Name = "accordionControlElement8";
            accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement8.Text = "الرئيسية";
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement1.Appearance.Default.Options.UseFont = true;
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Height = 60;
            accordionControlElement1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement1.ImageOptions.Image");
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement1.Text = "الأصناف";
            // 
            // accordionControlElement9
            // 
            accordionControlElement9.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement9.Appearance.Default.Options.UseFont = true;
            accordionControlElement9.Height = 60;
            accordionControlElement9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement9.ImageOptions.SvgImage");
            accordionControlElement9.Name = "accordionControlElement9";
            accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement9.Text = "فاتورة عميل";
            // 
            // accordionControlElement4
            // 
            accordionControlElement4.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement4.Appearance.Default.Options.UseFont = true;
            accordionControlElement4.Height = 60;
            accordionControlElement4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement4.ImageOptions.Image");
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement4.Text = "الموردين";
            // 
            // accordionControlElement13
            // 
            accordionControlElement13.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement13.Appearance.Default.Options.UseFont = true;
            accordionControlElement13.Height = 60;
            accordionControlElement13.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement13.ImageOptions.Image");
            accordionControlElement13.Name = "accordionControlElement13";
            accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement13.Text = "فاتورة مورد";
            // 
            // accordionControlElement10
            // 
            accordionControlElement10.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement10.Appearance.Default.Options.UseFont = true;
            accordionControlElement10.Height = 60;
            accordionControlElement10.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement10.ImageOptions.SvgImage");
            accordionControlElement10.Name = "accordionControlElement10";
            accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement10.Text = "الديون";
            // 
            // accordionControlElement11
            // 
            accordionControlElement11.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement11.Appearance.Default.Options.UseFont = true;
            accordionControlElement11.Height = 60;
            accordionControlElement11.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement11.ImageOptions.SvgImage");
            accordionControlElement11.Name = "accordionControlElement11";
            accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement11.Text = "المستحقات";
            // 
            // accordionControlElement12
            // 
            accordionControlElement12.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement12.Appearance.Default.Options.UseFont = true;
            accordionControlElement12.Height = 60;
            accordionControlElement12.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement12.ImageOptions.SvgImage");
            accordionControlElement12.Name = "accordionControlElement12";
            accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement12.Text = "فواتير العملاء";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement2.Appearance.Default.Options.UseFont = true;
            accordionControlElement2.Expanded = true;
            accordionControlElement2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement2.ImageOptions.Image");
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement2.Text = "الأصناف";
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement3.Appearance.Default.Options.UseFont = true;
            accordionControlElement3.Expanded = true;
            accordionControlElement3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement3.ImageOptions.Image");
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement3.Text = "الأصناف";
            // 
            // accordionControlElement5
            // 
            accordionControlElement5.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement5.Appearance.Default.Options.UseFont = true;
            accordionControlElement5.Expanded = true;
            accordionControlElement5.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement5.ImageOptions.Image");
            accordionControlElement5.Name = "accordionControlElement5";
            accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement5.Text = "الأصناف";
            // 
            // accordionControlElement6
            // 
            accordionControlElement6.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement6.Appearance.Default.Options.UseFont = true;
            accordionControlElement6.Expanded = true;
            accordionControlElement6.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement6.ImageOptions.Image");
            accordionControlElement6.Name = "accordionControlElement6";
            accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement6.Text = "الأصناف";
            // 
            // accordionControlElement7
            // 
            accordionControlElement7.Appearance.Default.Font = new System.Drawing.Font("LBC", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accordionControlElement7.Appearance.Default.Options.UseFont = true;
            accordionControlElement7.Expanded = true;
            accordionControlElement7.Height = 60;
            accordionControlElement7.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement7.ImageOptions.Image");
            accordionControlElement7.Name = "accordionControlElement7";
            accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement7.Text = "الأصناف";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 720);
            Controls.Add(pn_cont);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Main";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "Form1";
            pn_cont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pn_topbar).EndInit();
            pn_topbar.ResumeLayout(false);
            pn_topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_cont;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.PanelControl pn_topbar;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Panel pn_container;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private System.Windows.Forms.Label label_title;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
    }
}

