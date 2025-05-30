namespace Stock_Management_Dev
{
	partial class Addsupbill
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
            txtNewSupplierName = new DevExpress.XtraEditors.TextEdit();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btnAddSupplierBillItem = new DevExpress.XtraEditors.SimpleButton();
            txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            txtDescription = new DevExpress.XtraEditors.TextEdit();
            txtProductID = new DevExpress.XtraEditors.TextEdit();
            txtQuantity = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtNewSupplierName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtNewSupplierName
            // 
            txtNewSupplierName.Location = new System.Drawing.Point(424, 56);
            txtNewSupplierName.Name = "txtNewSupplierName";
            txtNewSupplierName.Size = new System.Drawing.Size(357, 26);
            txtNewSupplierName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(415, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(366, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(689, -1);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(181, 24);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "اضافة فاتورة جديدة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(811, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 24);
            label1.TabIndex = 3;
            label1.Text = "اسم المورد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(831, 368);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 24);
            label4.TabIndex = 6;
            label4.Text = "المنتجات";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(809, 275);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 24);
            label5.TabIndex = 7;
            label5.Text = "وصف الفاتورة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(809, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 24);
            label6.TabIndex = 8;
            label6.Text = "السعر الكلى";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(811, 117);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(113, 24);
            label7.TabIndex = 9;
            label7.Text = "تاريخ الفاتورة";
            // 
            // btnAddSupplierBillItem
            // 
            btnAddSupplierBillItem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddSupplierBillItem.Appearance.Options.UseFont = true;
            btnAddSupplierBillItem.Location = new System.Drawing.Point(98, 535);
            btnAddSupplierBillItem.Name = "btnAddSupplierBillItem";
            btnAddSupplierBillItem.Size = new System.Drawing.Size(265, 51);
            btnAddSupplierBillItem.TabIndex = 10;
            btnAddSupplierBillItem.Text = "اضافة الفاتورة";
            btnAddSupplierBillItem.Click += btnAddSupplierBillItem_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(415, 199);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(366, 26);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(415, 276);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(366, 26);
            txtDescription.TabIndex = 12;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(415, 369);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(366, 26);
            txtProductID.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(415, 464);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(366, 26);
            txtQuantity.TabIndex = 14;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(847, 463);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(52, 24);
            labelControl2.TabIndex = 15;
            labelControl2.Text = "الكمية";
            // 
            // Addsupbill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(947, 618);
            Controls.Add(labelControl2);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductID);
            Controls.Add(txtDescription);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnAddSupplierBillItem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(labelControl1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNewSupplierName);
            Name = "Addsupbill";
            Text = "Addsupbill";
            ((System.ComponentModel.ISupportInitialize)txtNewSupplierName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNewSupplierName;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnAddSupplierBillItem;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}