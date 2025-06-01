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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting; // Connect the event

        }

        private void LoadSuppliers()
        {
            var context = new AppDBContext();
            dataGridView1.DataSource = context.Suppliers.ToList();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var addForm = new AddSupplierForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ////edit supp
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit" && e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                using (var db = new AppDBContext())
                {
                    var supplier = db.Suppliers.Find(supplierId);
                    if (supplier != null)
                    {
                        var editForm = new AddSupplierForm();
                        editForm.CurrentSupplier = supplier;

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadSuppliers(); 
                        }
                    }
                }
            }

            ///delete supp
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete" && e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this supplier?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (var db = new AppDBContext())
                    {
                        var supplierToDelete = db.Suppliers.Find(supplierId);
                        if (supplierToDelete != null)
                        {
                            db.Suppliers.Remove(supplierToDelete);
                            db.SaveChanges();
                            MessageBox.Show("Supplier deleted successfully.");
                            LoadSuppliers(); // Refresh grid
                        }
                        else
                        {
                            MessageBox.Show("Supplier not found.");
                        }
                    }
                }
            }


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit")
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.IndianRed;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

    }
}
