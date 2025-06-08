namespace Stock_Management_Dev
{
    partial class UpdateProductForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            UpdateProductBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            UpdatedProductPriceTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            UpdatedSupplierNumberTxt = new System.Windows.Forms.TextBox();
            UpdatedProductQuantityTxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            UpdatedProductDescriptionTxt = new System.Windows.Forms.TextBox();
            UpdatedProductNameTxt = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpdateProductBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(UpdatedProductPriceTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(UpdatedSupplierNumberTxt);
            groupBox1.Controls.Add(UpdatedProductQuantityTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(UpdatedProductDescriptionTxt);
            groupBox1.Controls.Add(UpdatedProductNameTxt);
            groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(776, 426);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "تعديل منتج";
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.Location = new System.Drawing.Point(269, 293);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new System.Drawing.Size(145, 46);
            UpdateProductBtn.TabIndex = 10;
            UpdateProductBtn.Text = "تعديل المنتج";
            UpdateProductBtn.UseVisualStyleBackColor = true;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(672, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 22);
            label3.TabIndex = 5;
            label3.Text = "الكمية";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(269, 141);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 22);
            label5.TabIndex = 9;
            label5.Text = "رقم المورد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(672, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 22);
            label2.TabIndex = 4;
            label2.Text = "الوصف";
            // 
            // UpdatedProductPriceTxt
            // 
            UpdatedProductPriceTxt.Location = new System.Drawing.Point(126, 58);
            UpdatedProductPriceTxt.Name = "UpdatedProductPriceTxt";
            UpdatedProductPriceTxt.Size = new System.Drawing.Size(125, 27);
            UpdatedProductPriceTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(652, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 22);
            label1.TabIndex = 3;
            label1.Text = "اسم المنتج";
            // 
            // UpdatedSupplierNumberTxt
            // 
            UpdatedSupplierNumberTxt.Location = new System.Drawing.Point(126, 137);
            UpdatedSupplierNumberTxt.Name = "UpdatedSupplierNumberTxt";
            UpdatedSupplierNumberTxt.Size = new System.Drawing.Size(125, 27);
            UpdatedSupplierNumberTxt.TabIndex = 8;
            // 
            // UpdatedProductQuantityTxt
            // 
            UpdatedProductQuantityTxt.Location = new System.Drawing.Point(471, 182);
            UpdatedProductQuantityTxt.Name = "UpdatedProductQuantityTxt";
            UpdatedProductQuantityTxt.Size = new System.Drawing.Size(161, 27);
            UpdatedProductQuantityTxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(269, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 22);
            label4.TabIndex = 7;
            label4.Text = "سعر الوحدة";
            // 
            // UpdatedProductDescriptionTxt
            // 
            UpdatedProductDescriptionTxt.Location = new System.Drawing.Point(471, 116);
            UpdatedProductDescriptionTxt.Name = "UpdatedProductDescriptionTxt";
            UpdatedProductDescriptionTxt.Size = new System.Drawing.Size(161, 27);
            UpdatedProductDescriptionTxt.TabIndex = 1;
            // 
            // UpdatedProductNameTxt
            // 
            UpdatedProductNameTxt.Location = new System.Drawing.Point(471, 55);
            UpdatedProductNameTxt.Name = "UpdatedProductNameTxt";
            UpdatedProductNameTxt.Size = new System.Drawing.Size(161, 27);
            UpdatedProductNameTxt.TabIndex = 0;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            Load += UpdateProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdatedProductPriceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdatedSupplierNumberTxt;
        private System.Windows.Forms.TextBox UpdatedProductQuantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UpdatedProductDescriptionTxt;
        private System.Windows.Forms.TextBox UpdatedProductNameTxt;
    }
}