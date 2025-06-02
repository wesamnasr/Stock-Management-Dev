namespace Stock_Management_Dev
{
    partial class AddProductForm
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
            ProductNameTxt = new System.Windows.Forms.TextBox();
            ProductDescriptionTxt = new System.Windows.Forms.TextBox();
            ProductQuantityTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ProductPriceTxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            SupplierNumberTxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            AddProductBtn = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // ProductNameTxt
            // 
            ProductNameTxt.Location = new System.Drawing.Point(521, 104);
            ProductNameTxt.Name = "ProductNameTxt";
            ProductNameTxt.Size = new System.Drawing.Size(125, 27);
            ProductNameTxt.TabIndex = 0;
           
            // 
            // ProductDescriptionTxt
            // 
            ProductDescriptionTxt.Location = new System.Drawing.Point(521, 165);
            ProductDescriptionTxt.Name = "ProductDescriptionTxt";
            ProductDescriptionTxt.Size = new System.Drawing.Size(125, 27);
            ProductDescriptionTxt.TabIndex = 1;
            // 
            // ProductQuantityTxt
            // 
            ProductQuantityTxt.Location = new System.Drawing.Point(521, 231);
            ProductQuantityTxt.Name = "ProductQuantityTxt";
            ProductQuantityTxt.Size = new System.Drawing.Size(125, 27);
            ProductQuantityTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(666, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "اسم المنتج";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(686, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "الوصف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(686, 238);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "الكمية";
            // 
            // ProductPriceTxt
            // 
            ProductPriceTxt.Location = new System.Drawing.Point(99, 107);
            ProductPriceTxt.Name = "ProductPriceTxt";
            ProductPriceTxt.Size = new System.Drawing.Size(125, 27);
            ProductPriceTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(244, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "سعر الوحدة";
            // 
            // SupplierNumberTxt
            // 
            SupplierNumberTxt.Location = new System.Drawing.Point(99, 186);
            SupplierNumberTxt.Name = "SupplierNumberTxt";
            SupplierNumberTxt.Size = new System.Drawing.Size(125, 27);
            SupplierNumberTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(244, 193);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "رقم المورد";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new System.Drawing.Point(305, 346);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new System.Drawing.Size(145, 46);
            AddProductBtn.TabIndex = 10;
            AddProductBtn.Text = "اضافة المنتج";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProduct_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(347, 35);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 20);
            label6.TabIndex = 11;
            label6.Text = "اضافة منتج";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label6);
            Controls.Add(AddProductBtn);
            Controls.Add(label5);
            Controls.Add(SupplierNumberTxt);
            Controls.Add(label4);
            Controls.Add(ProductPriceTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProductQuantityTxt);
            Controls.Add(ProductDescriptionTxt);
            Controls.Add(ProductNameTxt);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox ProductDescriptionTxt;
        private System.Windows.Forms.TextBox ProductQuantityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierNumberTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label6;
    }
}