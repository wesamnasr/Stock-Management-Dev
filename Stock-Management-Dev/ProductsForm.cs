using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Stock_Management_Dev.Models;

namespace Stock_Management_Dev
{
    public partial class ProductsForm : Form
    {
        AppDBContext context;
        public ProductsForm()
        {
            InitializeComponent();

        }

        private void LoadProducts()
        {
            var productData = context.Products.Include(p => p.Supplier).Select(p => new
        {
            p.ProductID,
            p.Name,
            p.Description,
            p.QuantityInStock,
            p.UnitPrice,
            p.SupplierID,
            Supplier = p.Supplier.Name, 
        }).ToList();

            ProductsTable.DataSource = null; // clear binding first (good practice)
            ProductsTable.DataSource = productData;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            context = new AppDBContext();
            LoadProducts();

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }
    }
}
