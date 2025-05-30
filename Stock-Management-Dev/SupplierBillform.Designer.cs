namespace Stock_Management_Dev
{
	partial class SupplierBillform
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            addnewbill = new DevExpress.XtraEditors.SimpleButton();
            savebill = new DevExpress.XtraEditors.SimpleButton();
            unit = new DevExpress.XtraEditors.TextEdit();
            Total = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            totalprice = new DevExpress.XtraEditors.LabelControl();
            billID = new DevExpress.XtraEditors.SearchLookUpEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Description = new DevExpress.XtraEditors.TextEdit();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            txtaddress = new System.Windows.Forms.TextBox();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            searchId = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtphone = new DevExpress.XtraEditors.TextEdit();
            txtcompany = new DevExpress.XtraEditors.TextEdit();
            txtname = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Total.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Description.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtphone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcompany.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtname.Properties).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(131, 158);
            dateTimePicker1.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(266, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(addnewbill);
            groupControl1.Controls.Add(savebill);
            groupControl1.Controls.Add(unit);
            groupControl1.Controls.Add(Total);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(totalprice);
            groupControl1.Controls.Add(billID);
            groupControl1.Controls.Add(Description);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(dateTimePicker1);
            groupControl1.Location = new System.Drawing.Point(678, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupControl1.Size = new System.Drawing.Size(589, 430);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "بيانات الفاتورة";
            // 
            // addnewbill
            // 
            addnewbill.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addnewbill.Appearance.Options.UseFont = true;
            addnewbill.Location = new System.Drawing.Point(0, 65);
            addnewbill.Name = "addnewbill";
            addnewbill.Size = new System.Drawing.Size(154, 21);
            addnewbill.TabIndex = 4;
            addnewbill.Text = "اضافة فاتورة جديدة";
            addnewbill.Click += addnewbill_Click;
            // 
            // savebill
            // 
            savebill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            savebill.Appearance.Options.UseFont = true;
            savebill.Location = new System.Drawing.Point(374, 377);
            savebill.Name = "savebill";
            savebill.Size = new System.Drawing.Size(210, 26);
            savebill.TabIndex = 11;
            savebill.Text = "حفظ الفاتورة";
            // 
            // unit
            // 
            unit.Location = new System.Drawing.Point(131, 270);
            unit.Name = "unit";
            unit.Size = new System.Drawing.Size(266, 26);
            unit.TabIndex = 9;
            // 
            // Total
            // 
            Total.Location = new System.Drawing.Point(131, 213);
            Total.Name = "Total";
            Total.Size = new System.Drawing.Size(266, 26);
            Total.TabIndex = 8;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(432, 274);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(105, 22);
            labelControl8.TabIndex = 7;
            labelControl8.Text = "المبلغ المدفوع";
            // 
            // totalprice
            // 
            totalprice.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            totalprice.Appearance.Options.UseFont = true;
            totalprice.Location = new System.Drawing.Point(426, 216);
            totalprice.Name = "totalprice";
            totalprice.Size = new System.Drawing.Size(111, 22);
            totalprice.TabIndex = 6;
            totalprice.Text = "المبلغ المطلوب";
            // 
            // billID
            // 
            billID.Location = new System.Drawing.Point(172, 63);
            billID.Name = "billID";
            billID.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            billID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            billID.Properties.PopupView = gridView1;
            billID.Properties.UseReadOnlyAppearance = false;
            billID.Size = new System.Drawing.Size(225, 26);
            billID.TabIndex = 4;
            billID.EditValueChanged += billID_EditValueChanged;
            // 
            // gridView1
            // 
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Description
            // 
            Description.Location = new System.Drawing.Point(131, 105);
            Description.Name = "Description";
            Description.Size = new System.Drawing.Size(266, 26);
            Description.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(439, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 22);
            label3.TabIndex = 4;
            label3.Text = "تاريخ الشراء";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(432, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 22);
            label2.TabIndex = 3;
            label2.Text = "وصف الفاتورة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(444, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 22);
            label1.TabIndex = 2;
            label1.Text = "رقم الفاتورة";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(simpleButton1);
            groupControl2.Controls.Add(txtaddress);
            groupControl2.Controls.Add(labelControl6);
            groupControl2.Controls.Add(searchId);
            groupControl2.Controls.Add(labelControl3);
            groupControl2.Controls.Add(txtEmail);
            groupControl2.Controls.Add(txtphone);
            groupControl2.Controls.Add(txtcompany);
            groupControl2.Controls.Add(txtname);
            groupControl2.Controls.Add(labelControl5);
            groupControl2.Controls.Add(labelControl4);
            groupControl2.Controls.Add(labelControl2);
            groupControl2.Controls.Add(labelControl1);
            groupControl2.Location = new System.Drawing.Point(12, 12);
            groupControl2.Name = "groupControl2";
            groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupControl2.Size = new System.Drawing.Size(599, 423);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "بيانات العميل";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(5, 40);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(137, 29);
            simpleButton1.TabIndex = 14;
            simpleButton1.Text = "اضافة عميل جديد";
            // 
            // txtaddress
            // 
            txtaddress.Location = new System.Drawing.Point(241, 356);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new System.Drawing.Size(187, 27);
            txtaddress.TabIndex = 13;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(473, 361);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(102, 22);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "عنوان الشركة";
            // 
            // searchId
            // 
            searchId.Location = new System.Drawing.Point(241, 46);
            searchId.Name = "searchId";
            searchId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchId.Properties.PopupView = searchLookUpEdit1View;
            searchId.Size = new System.Drawing.Size(187, 26);
            searchId.TabIndex = 11;
            searchId.EditValueChanged += searchId_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(456, 299);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(119, 22);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "البريد الالكتروني";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(241, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(187, 26);
            txtEmail.TabIndex = 9;
            // 
            // txtphone
            // 
            txtphone.Location = new System.Drawing.Point(241, 232);
            txtphone.Name = "txtphone";
            txtphone.Size = new System.Drawing.Size(187, 26);
            txtphone.TabIndex = 8;
            // 
            // txtcompany
            // 
            txtcompany.Location = new System.Drawing.Point(241, 161);
            txtcompany.Name = "txtcompany";
            txtcompany.Size = new System.Drawing.Size(187, 26);
            txtcompany.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new System.Drawing.Point(241, 105);
            txtname.Name = "txtname";
            txtname.Size = new System.Drawing.Size(187, 26);
            txtname.TabIndex = 6;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(480, 162);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(95, 22);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "اسم الشركة";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(498, 233);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(77, 22);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "رقم الهاتف";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(452, 106);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(123, 22);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "الاسم الشخصي";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(479, 47);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(96, 22);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "معرف العميل";
            // 
            // SupplierBillform
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1290, 666);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "SupplierBillform";
            Text = "SupplierBill";
            Load += SupplierBill_Load;
            MouseHover += SupplierBillform_MouseHover;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)unit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Total.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)billID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Description.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtphone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcompany.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtname.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtphone;
        private DevExpress.XtraEditors.TextEdit txtcompany;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtaddress;
        private DevExpress.XtraEditors.SearchLookUpEdit billID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit unit;
        private DevExpress.XtraEditors.TextEdit Total;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl totalprice;
        private DevExpress.XtraEditors.SimpleButton savebill;
        private DevExpress.XtraEditors.SimpleButton addnewbill;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}