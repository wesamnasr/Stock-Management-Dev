namespace Stock_Management_Dev
{
    partial class FORM_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_stats = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // pn_stats
            // 
            pn_stats.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_stats.Location = new System.Drawing.Point(0, 0);
            pn_stats.Name = "pn_stats";
            pn_stats.Size = new System.Drawing.Size(988, 636);
            pn_stats.TabIndex = 0;
            // 
            // FORM_Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pn_stats);
            Name = "FORM_Home";
            Size = new System.Drawing.Size(988, 636);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel pn_stats;
    }
}
