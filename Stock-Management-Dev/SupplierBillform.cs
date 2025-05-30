using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using Stock_Management.Models;

namespace Stock_Management_Dev
{
    public partial class SupplierBillform : DevExpress.XtraEditors.XtraForm
    {

        public SupplierBillform()
        {
            InitializeComponent();
        }

        private void SupplierBill_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var suppliers = db.Suppliers.ToList();
                var supplierBills = db.SupplierBills.ToList();

                searchId.Properties.DataSource = suppliers;
                searchId.Properties.DisplayMember = "SupplierID";
                searchId.Properties.ValueMember = "SupplierID";
                searchId.Properties.NullText = "اختر المورد أو اكتب اسم جديد";
                searchId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                billID.Properties.DataSource = supplierBills;
                billID.Properties.DisplayMember = "SupplierBillID";
                billID.Properties.ValueMember = "SupplierBillID";

                billID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            }
            billID.Properties.NullText = "اختر الفاتورة أو اكتب اسم جديد";

        }

        private void searchId_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSupplier = searchId.GetSelectedDataRow() as Supplier;

            if (selectedSupplier != null)
            {
                txtname.Text = selectedSupplier.Name;
                txtphone.Text = selectedSupplier.Phone;
                txtEmail.Text = selectedSupplier.Email;
                txtcompany.Text = selectedSupplier.CompanyName;
                txtaddress.Text = selectedSupplier.Address;
            }
        }

        private void billID_EditValueChanged(object sender, EventArgs e)
        {
            int selectedBillID = Convert.ToInt32(billID.EditValue);

            using (var db = new AppDBContext())
            {
                var bill = db.SupplierBills
                    .Include(b => b.Supplier)
                    .FirstOrDefault(b => b.SupplierBillID == selectedBillID);


                if (bill != null)
                {

                    dateTimePicker1.Value = bill.BillDate;


                    searchId.EditValue = bill.SupplierID;


                    txtname.Text = bill.Supplier?.Name;
                    txtphone.Text = bill.Supplier?.Phone;
                    txtcompany.Text = bill.Supplier?.CompanyName;
                    txtEmail.Text = bill.Supplier?.Email;
                    txtaddress.Text = bill.Supplier?.Address;
                    addnewbill.Enabled = false;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على الفاتورة.");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            using (var db = new AppDBContext())
            {
                var bill = db.SupplierBills
                    .Include(b => b.Supplier)
                    .FirstOrDefault(b => b.BillDate.Date == selectedDate);

                var billItem = db.SupplierBillItems
    .Include(i => i.SupplierBill)
        .ThenInclude(b => b.Supplier)
    .FirstOrDefault(i => i.SupplierBill.BillDate.Date == selectedDate);
                if (bill != null)
                {
                    billID.EditValue = bill.SupplierBillID;

                    searchId.EditValue = bill.SupplierID;

                    txtname.Text = bill.Supplier?.Name;
                    txtphone.Text = bill.Supplier?.Phone;
                    txtcompany.Text = bill.Supplier?.CompanyName;
                    txtEmail.Text = bill.Supplier?.Email;
                    txtaddress.Text = bill.Supplier?.Address;
                    Description.Text = billItem.Description;


                    var total = db.SupplierBills
                        .Where(i => i.SupplierBillID == bill.SupplierBillID)
                        .Sum(i => (decimal?)i.TotalAmount) ?? 0;

                    var unitprice = db.SupplierBills
                        .Where(i => i.SupplierBillID == bill.SupplierBillID)
                        .Sum(i => (decimal?)i.PaidAmount) ?? 0;

                    Total.Text = total.ToString("0.00");
                    unit.Text = unitprice.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("لا توجد فاتورة في هذا التاريخ.");
                }
            }
        }

        private void addnewbill_Click(object sender, EventArgs e)
        {
            Addsupbill form2 = new Addsupbill();
            form2.Show();
        }

        private void SupplierBillform_MouseHover(object sender, EventArgs e)
        {
            savebill.BackColor = Color.Green;
        }
    }
}
