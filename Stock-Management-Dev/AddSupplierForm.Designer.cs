namespace Stock_Management_Dev
{
    partial class AddSupplierForm
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
            addLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtCompanyName = new System.Windows.Forms.TextBox();
            txtNotes = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addLabel.Location = new System.Drawing.Point(182, 9);
            addLabel.Name = "addLabel";
            addLabel.Size = new System.Drawing.Size(85, 21);
            addLabel.TabIndex = 0;
            addLabel.Text = "اضافه مورد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(383, 270);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 21);
            label3.TabIndex = 2;
            label3.Text = " : ملاحظات ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(399, 225);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 21);
            label4.TabIndex = 3;
            label4.Text = ": العنوان";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(402, 186);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 21);
            label5.TabIndex = 4;
            label5.Text = ": الايميل";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(383, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 21);
            label6.TabIndex = 5;
            label6.Text = ": اسم الشركه";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(383, 97);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 21);
            label7.TabIndex = 6;
            label7.Text = ": رقم الهاتف";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(405, 51);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 21);
            label8.TabIndex = 7;
            label8.Text = ": الاسم";
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(236, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(109, 33);
            btnSave.TabIndex = 8;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.Location = new System.Drawing.Point(105, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(109, 33);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(219, 53);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(149, 23);
            txtName.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(219, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(149, 23);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(219, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(149, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(219, 227);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(149, 23);
            txtAddress.TabIndex = 14;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(219, 147);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(149, 23);
            txtCompanyName.TabIndex = 15;
            // 
            // txtNotes
            // 
            txtNotes.Location = new System.Drawing.Point(226, 256);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(142, 57);
            txtNotes.TabIndex = 16;
            txtNotes.Text = "";
            // 
            // AddSupplierForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(478, 406);
            Controls.Add(txtNotes);
            Controls.Add(txtCompanyName);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addLabel);
            Name = "AddSupplierForm";
            Text = "AddSupplierForm";
            Load += AddSupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.RichTextBox txtNotes;
    }
}