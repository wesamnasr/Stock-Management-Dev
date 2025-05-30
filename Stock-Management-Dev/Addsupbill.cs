using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Stock_Management.Models;
using System.Globalization;

namespace Stock_Management_Dev
{
    public partial class Addsupbill : DevExpress.XtraEditors.XtraForm
    {
        public Addsupbill()
        {
            InitializeComponent();
        }

       
        private void Addsupbill_Load(object sender, EventArgs e)
        {
         
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd، dd MMMM yyyy";  // يوم الأسبوع، اليوم، اسم الشهر، السنة
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddSupplierBillItem_Click(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                // 1. التحقق من اسم المورد
                string supplierName = txtNewSupplierName.Text.Trim();
                if (string.IsNullOrWhiteSpace(supplierName))
                {
                    MessageBox.Show("يرجى إدخال اسم المورد");
                    return;
                }

                var supplier = db.Suppliers.FirstOrDefault(s => s.Name == supplierName);
                if (supplier == null)
                {
                    supplier = new Supplier { Name = supplierName };
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                }

            
                var bill = new SupplierBill
                {
                    SupplierID = supplier.SupplierID,
                    BillDate = DateTime.Now,
                    Description = txtDescription.Text,
                    TotalAmount = 0,
                    PaidAmount = 0
                };
                db.SupplierBills.Add(bill);
                db.SaveChanges();

               
                if (!int.TryParse(txtProductID.Text, out int productId) ||
                    !int.TryParse(txtQuantity.Text, out int quantity) ||
                    !decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
                {
                    MessageBox.Show("تأكد من إدخال أرقام صحيحة للمنتج، الكمية والسعر");
                    return;
                }

              
                var item = new SupplierBillItem
                {
                    SupplierBillID = bill.SupplierBillID,
                    ProductID = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Description = txtDescription.Text,
                    PurchaseDate = DateTime.Now
                };
                item.CalculateTotalPrice();
                db.SupplierBillItems.Add(item);
                db.SaveChanges();

               
                bill.TotalAmount = db.SupplierBillItems
                                    .Where(i => i.SupplierBillID == bill.SupplierBillID)
                                    .Sum(i => i.TotalPrice);
                db.SaveChanges();

           
                MessageBox.Show($"تمت إضافة الفاتورة بنجاح برقم: {bill.SupplierBillID}");
                this.Close();

                txtProductID.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                txtDescription.Clear();
                txtNewSupplierName.Clear();
         
            }
        }
    }
}
