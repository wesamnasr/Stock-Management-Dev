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
using Stock_Management_Dev.Middlewares;

namespace Stock_Management_Dev
{
    public partial class AddProductForm : Form
    {
        AppDBContext context;
        public AddProductForm()
        {
            InitializeComponent();
        }

        #region Add Product Function
        public void AddProduct(AppDBContext context)
        {

            #region Add Form Fields
                string productName = ProductNameTxt.Text;
                string productDescription = ProductDescriptionTxt.Text;
                string productQuantity = ProductQuantityTxt.Text;
                string productPrice = ProductPriceTxt.Text;
                string supplierID = SupplierNumberTxt.Text;
            #endregion

            if (!Validation.IsTextBoxEmpty(productName,productDescription,productQuantity,productPrice,supplierID)) {
                if (!Validation.IsViolateDataType(productQuantity,supplierID,productPrice))
                {
                    if (Validation.CheckSupplierForeignKeyExisting(context,supplierID))
                    {
                        Product product = new Product()
                        {
                            Name = productName,
                            Description = productDescription,
                            QuantityInStock = int.Parse(productQuantity),
                            UnitPrice = decimal.Parse(productPrice),
                            SupplierID = int.Parse(supplierID),
                
                        };
                        context.Products.Add(product);
                        context.SaveChanges();
                        MessageBox.Show("تم اضافة المنتج بنجاح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("هذا المورد غير موجود بقائمة الموردين", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("بالرجاء ادخال رقم و ليس نص", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("بالرجاءادخال العناصر المطلوبه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        private void AddProduct_Click(object sender, EventArgs e)
        {
            context = new AppDBContext();
            AddProduct(context);
        }
    }
}


#region Validation
//public bool IsTextBoxEmpty()
//{
//    if (string.IsNullOrWhiteSpace(ProductNameTxt.Text) ||string.IsNullOrWhiteSpace(ProductDescriptionTxt.Text) ||
//   string.IsNullOrWhiteSpace(ProductQuantityTxt.Text) ||string.IsNullOrWhiteSpace(ProductPriceTxt.Text) ||
//   string.IsNullOrWhiteSpace(SupplierNumberTxt.Text))
//        return true;
//    else 
//        return false;

//}
//public bool IsViolateDataType()
//{
//    if(!int.TryParse(ProductQuantityTxt.Text,out _) || !int.TryParse(SupplierNumberTxt.Text, out _) || !decimal.TryParse(ProductPriceTxt.Text, out _))
//        return true;
//    else 
//        return false;
//}
//public bool CheckSupplierForeignKeyExisting()
//{
//    var ForeignKey = context.Suppliers.Where(x => x.SupplierID == int.Parse(SupplierNumberTxt.Text)).FirstOrDefault();
//    if (ForeignKey != null)
//        return true;
//    else
//        return false; 

//}
#endregion