namespace Stock_Management_Dev
{
    partial class BillsView
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
            pn_cont = new System.Windows.Forms.Panel();
            pn_tables = new System.Windows.Forms.Panel();
            pn_choose = new System.Windows.Forms.Panel();
            supp_bills = new DevExpress.XtraEditors.SimpleButton();
            cust_bills = new DevExpress.XtraEditors.SimpleButton();
            pn_cont.SuspendLayout();
            pn_choose.SuspendLayout();
            SuspendLayout();
            // 
            // pn_cont
            // 
            pn_cont.Controls.Add(pn_tables);
            pn_cont.Controls.Add(pn_choose);
            pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_cont.Location = new System.Drawing.Point(0, 0);
            pn_cont.Name = "pn_cont";
            pn_cont.Size = new System.Drawing.Size(970, 589);
            pn_cont.TabIndex = 0;
            // 
            // pn_tables
            // 
            pn_tables.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_tables.Location = new System.Drawing.Point(0, 99);
            pn_tables.Name = "pn_tables";
            pn_tables.Size = new System.Drawing.Size(970, 490);
            pn_tables.TabIndex = 3;
            // 
            // pn_choose
            // 
            pn_choose.BackColor = System.Drawing.Color.Gainsboro;
            pn_choose.Controls.Add(supp_bills);
            pn_choose.Controls.Add(cust_bills);
            pn_choose.Dock = System.Windows.Forms.DockStyle.Top;
            pn_choose.Location = new System.Drawing.Point(0, 0);
            pn_choose.Name = "pn_choose";
            pn_choose.Size = new System.Drawing.Size(970, 99);
            pn_choose.TabIndex = 2;
            // 
            // supp_bills
            // 
            supp_bills.Anchor = System.Windows.Forms.AnchorStyles.Left;
            supp_bills.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            supp_bills.Appearance.Options.UseFont = true;
            supp_bills.Location = new System.Drawing.Point(195, 25);
            supp_bills.Name = "supp_bills";
            supp_bills.Size = new System.Drawing.Size(144, 58);
            supp_bills.TabIndex = 1;
            supp_bills.Text = "فواتير الموردين";
            supp_bills.Click += supp_bills_Click;
            // 
            // cust_bills
            // 
            cust_bills.Anchor = System.Windows.Forms.AnchorStyles.Right;
            cust_bills.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cust_bills.Appearance.Options.UseFont = true;
            cust_bills.Location = new System.Drawing.Point(653, 25);
            cust_bills.Name = "cust_bills";
            cust_bills.Size = new System.Drawing.Size(129, 58);
            cust_bills.TabIndex = 0;
            cust_bills.Text = "فواتير العملاء";
            cust_bills.Click += cust_bills_Click;
            // 
            // BillsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(970, 589);
            Controls.Add(pn_cont);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "BillsView";
            Text = "BillsView";
            pn_cont.ResumeLayout(false);
            pn_choose.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pn_tables;
        private System.Windows.Forms.Panel pn_choose;
        private DevExpress.XtraEditors.SimpleButton supp_bills;
        private DevExpress.XtraEditors.SimpleButton cust_bills;
        public System.Windows.Forms.Panel pn_cont;
    }
}