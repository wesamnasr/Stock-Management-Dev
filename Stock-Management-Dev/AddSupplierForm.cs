using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Management.Models;

namespace Stock_Management_Dev
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is Requiered !");
                return;
            }
            var context = new AppDBContext();
            if (CurrentSupplier==null)
            { //add new
                var newSupplier = new Supplier
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                CompanyName = txtCompanyName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Description=txtNotes.Text.Trim(),
            };

                context.Suppliers.Add(newSupplier);
             }
            else
            {
                var updatedSupplier=context.Suppliers.Find(CurrentSupplier.SupplierID);
                if (updatedSupplier!=null) {
                    updatedSupplier.Name = txtName.Text.Trim();
                    updatedSupplier.Phone = txtPhone.Text.Trim();
                    updatedSupplier.CompanyName = txtCompanyName.Text.Trim();
                    updatedSupplier.Email = txtEmail.Text.Trim();
                    updatedSupplier.Address = txtAddress.Text.Trim();
                    updatedSupplier.Description = txtNotes.Text.Trim();

                }

            }
             context.SaveChanges();

            MessageBox.Show("Supplier Saved successfully");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            addLabel.Text = "تعديل مورد";
            if (CurrentSupplier != null) //  Edit mode
            {
                txtName.Text = CurrentSupplier.Name;
                txtPhone.Text = CurrentSupplier.Phone;
                txtCompanyName.Text = CurrentSupplier.CompanyName;
                txtEmail.Text = CurrentSupplier.Email;
                txtAddress.Text = CurrentSupplier.Address;
            }
        }

        public Supplier CurrentSupplier { get; set; }

    }
}
