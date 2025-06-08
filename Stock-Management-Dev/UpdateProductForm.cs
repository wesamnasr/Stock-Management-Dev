using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.About;
using Stock_Management_Dev.Middlewares;
using Stock_Management_Dev.Models;

namespace Stock_Management_Dev
{
    public partial class UpdateProductForm : Form
    {
        AppDBContext context;

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public int SupplierID { get; set; }


        //#region Validation
        //public bool IsTextBoxEmpty()
        //{
        //    if (string.IsNullOrWhiteSpace(UpdatedProductNameTxt.Text) || string.IsNullOrWhiteSpace(UpdatedProductDescriptionTxt.Text) ||
        //   string.IsNullOrWhiteSpace(UpdatedProductQuantityTxt.Text) || string.IsNullOrWhiteSpace(UpdatedProductPriceTxt.Text) ||
        //   string.IsNullOrWhiteSpace(UpdatedSupplierNumberTxt.Text))
        //        return true;
        //    else
        //        return false;

        //}
        //public bool IsViolateDataType()
        //{
        //    if (!int.TryParse(UpdatedProductQuantityTxt.Text, out _) || !int.TryParse(UpdatedSupplierNumberTxt.Text, out _) || !decimal.TryParse(UpdatedProductPriceTxt.Text, out _))
        //        return true;
        //    else
        //        return false;
        //}
        //public bool CheckSupplierForeignKeyExisting()
        //{
        //    var ForeignKey = context.Suppliers.Where(x => x.SupplierID == int.Parse(UpdatedSupplierNumberTxt.Text)).FirstOrDefault();
        //    if (ForeignKey != null)
        //        return true;
        //    else
        //        return false;

        //}
        //#endregion

        public UpdateProductForm()
        {
            InitializeComponent();
        }

        public void UpdateProduct(AppDBContext context)
        {

            #region Update Form Field
            string productName = UpdatedProductNameTxt.Text;
            string productDescription = UpdatedProductDescriptionTxt.Text;
            string productQuantity = UpdatedProductQuantityTxt.Text;
            string productPrice = UpdatedProductPriceTxt.Text;
            string supplierID = UpdatedSupplierNumberTxt.Text;
            #endregion

            if (!Validation.IsTextBoxEmpty(productName, productDescription, productQuantity, productPrice, supplierID))
            {
                if (!Validation.IsViolateDataType(productQuantity, supplierID, productPrice))
                {
                    if (Validation.CheckSupplierForeignKeyExisting(context, supplierID))
                    {
                        var product = context.Products.Find(ProductID);
                        if (product != null)
                        {
                            product.Name = UpdatedProductNameTxt.Text;
                            product.Description = UpdatedProductDescriptionTxt.Text;
                            product.QuantityInStock = int.Parse(UpdatedProductQuantityTxt.Text);
                            product.UnitPrice = decimal.Parse(UpdatedProductPriceTxt.Text);
                            product.SupplierID = int.Parse(UpdatedSupplierNumberTxt.Text);

                            context.SaveChanges();
                            MessageBox.Show("تم تعديل المنتج بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
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
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            UpdatedProductNameTxt.Text = ProductName;
            UpdatedProductDescriptionTxt.Text = ProductDescription;
            UpdatedProductQuantityTxt.Text = ProductQuantity.ToString();
            UpdatedProductPriceTxt.Text = ProductPrice.ToString();
            UpdatedSupplierNumberTxt.Text = SupplierID.ToString();
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            context = new AppDBContext();
            UpdateProduct(context);
        }
    }
}
