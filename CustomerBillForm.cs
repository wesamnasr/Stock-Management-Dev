using DevExpress.Data;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using StockManagementSystem.Models;
using StockManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class CustomerBillForm : XtraUserControl
    {
        private AppDBContext db = new AppDBContext();

        private List<CustomerBillItemVM> customerBillItems = new List<CustomerBillItemVM>();
        private CustomerBill customerBill = new CustomerBill();

        public CustomerBillForm()
        {
            InitializeComponent();

            InitializeLayout();
            ResetForm();
            Customer_Load();
            Product_Load();


        }
        private void InitializeLayout()
        {
            Size = new Size(988, 636);
            Dock = DockStyle.Fill;
            MaximumSize = new Size(988, 636);
            MinimumSize = new Size(988, 636);
        }

        private void Customer_Load()
        {
            // Load customers into the lookup edit
            sl_Customers.Properties.DataSource = db.Customers.ToList();
            sl_Customers.Properties.DisplayMember = "Name";
            sl_Customers.Properties.ValueMember = "CustomerID";

            sl_Customers.EditValueChanged += sl_Customers_EditValueChanged; // Subscribe to the event
            sl_Customers.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains; // Enable filtering
            sl_Customers.Properties.ShowFooter = false; // Hide the footer
            sl_Customers.Properties.ShowPopupShadow = true; // Show shadow for better visibility

        }

        private void Product_Load()
        {
            // Load products into the lookup edit
            sl_Products.Properties.DataSource = db.Products.ToList();
            sl_Products.Properties.DisplayMember = "Name";
            sl_Products.Properties.ValueMember = "ProductID";
            sl_Products.EditValueChanged += sl_Products_EditValueChanged; // Subscribe to the event
            sl_Products.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains; // Enable filtering
            sl_Products.Properties.ShowFooter = false; // Hide the footer
            sl_Products.Properties.ShowPopupShadow = true; // Show shadow for better visibility

        }

        private void sl_Customers_EditValueChanged(object sender, EventArgs e)
        {
            // Handle customer selection change if needed
            var selectedCustomer = sl_Customers.GetSelectedDataRow() as Customer;
            if (selectedCustomer != null)
            {
                tb_CustomerName.Text = selectedCustomer.Name;
                tb_CustomerPhone.Text = selectedCustomer.Phone;
                tb_CustomerAddress.Text = selectedCustomer.Address;

                tb_CustomerName.ReadOnly = true;
                tb_CustomerPhone.ReadOnly = true;
                tb_CustomerAddress.ReadOnly = true;


            }

        }

        private void sl_Products_EditValueChanged(object sender, EventArgs e)
        {
            // Handle product selection change if needed
            var selectedProduct = sl_Products.GetSelectedDataRow() as Product;
            if (selectedProduct != null)
            {
                tb_ProductName.Text = selectedProduct.Name;
                tb_ProductPrice.Text = selectedProduct.UnitPrice.ToString();
                tb_ProductCount.Text = "1";

                // make tb readonly
                tb_ProductName.ReadOnly = true;
                tb_ProductPrice.ReadOnly = true;

                int productCount = Convert.ToInt32(tb_ProductCount.Text);
                btn_showtotalProductPrice.Text = (selectedProduct.UnitPrice * productCount).ToString();

                tb_ProductCount.Focus();


            }
        }

        private void btn_AddCutomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_CustomerName.Text) || string.IsNullOrWhiteSpace(tb_CustomerPhone.Text))
            {
                XtraMessageBox.Show(".ادخل بيانات العميل", "خطأ في التحقق");
                return;
            }

            var customer = new Customer
            {
                Name = tb_CustomerName.Text,
                Phone = tb_CustomerPhone.Text,
                Address = tb_CustomerAddress.Text
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            XtraMessageBox.Show("!تم اضافة العميل بنجاح", "نجح");
            Customer_Load();

        }

        private void hl_DeleteCustomerData_Click(object sender, EventArgs e)
        {
            //clear all customer data
            tb_CustomerName.Text = string.Empty;
            tb_CustomerPhone.Text = string.Empty;
            tb_CustomerAddress.Text = string.Empty;
            tb_CustomerName.ReadOnly = false;
            tb_CustomerPhone.ReadOnly = false;
            tb_CustomerAddress.ReadOnly = false;
            sl_Customers.EditValue = null; // Clear the selected customer
            sl_Customers.Properties.NullText = "select customer"; // Reset the placeholder text

        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            // Validate product fields
            if (sl_Products.EditValue == null || string.IsNullOrWhiteSpace(tb_ProductName.Text) ||
                string.IsNullOrWhiteSpace(tb_ProductPrice.Text) || string.IsNullOrWhiteSpace(tb_ProductCount.Text))
            {
                XtraMessageBox.Show(".ادخل بيانات المنتج المطلوب", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_ProductCount.Text, out int quantity) || quantity <= 0)
            {
                XtraMessageBox.Show(".ادخل كمية مناسبة", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tb_ProductPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                XtraMessageBox.Show(".خطأ في سعر الوحدة ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(sl_Products.EditValue);
            var existingProduct = customerBillItems.FirstOrDefault(item => item.ProductID == productId);


            var product = db.Products.FirstOrDefault(p => p.ProductID == productId);
            if(product != null)
            {
               if(product.QuantityInStock < quantity)
                {
                    XtraMessageBox.Show("الكمية المطلوبة اكبر من الموجودة ف المخزن ", "خطأ في الكمية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
                }
            }



            if (existingProduct != null)
            {
               
                // If the product already exists, update the quantity and total price
                existingProduct.Quantity += Convert.ToInt32(tb_ProductCount.Text);
                existingProduct.TotalPrice = existingProduct.Quantity * existingProduct.UnitPrice;
                XtraMessageBox.Show("!تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = null;
                gridControl1.DataSource = customerBillItems;
                return;
            }

            customerBillItems.Add(new CustomerBillItemVM
            {
                ProductID = Convert.ToInt32(sl_Products.EditValue),
                ProductName = tb_ProductName.Text,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalPrice = quantity * unitPrice
            });





            XtraMessageBox.Show("!تمت اضافة المنتج بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear product fields after adding
            sl_Products.EditValue = null;
            tb_ProductName.Text = string.Empty;
            tb_ProductPrice.Text = string.Empty;
            tb_ProductCount.Text = "1"; // Reset to default value
            btn_showtotalProductPrice.Text = "0"; // Reset total price

            gridControl1.DataSource = null;
            gridControl1.DataSource = customerBillItems;

        }

        private void hl_DeleteProductData_Click(object sender, EventArgs e)
        {
            // Clear all product data
            sl_Products.EditValue = null; // Clear the selected product
            sl_Products.Properties.NullText = "select product"; // Reset the placeholder text
            tb_ProductName.Text = string.Empty;
            tb_ProductPrice.Text = string.Empty;
            tb_ProductCount.Text = "1"; // Reset to default value
            btn_showtotalProductPrice.Text = "0"; // Reset total price
            tb_ProductName.ReadOnly = false;
            tb_ProductPrice.ReadOnly = false; // Make product name and price editable again
            sl_Products.Focus(); // Set focus back to the product selection control

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditPillProduct_Click(object sender, EventArgs e)
        {
            // edit selected product quntity in the grid view
            if (gridView1.SelectedRowsCount > 0)
            {
                int selectedRowHandle = gridView1.GetSelectedRows()[0]; // Get the first selected row
                if (selectedRowHandle >= 0)
                {
                    var selectedItem = gridView1.GetRow(selectedRowHandle) as CustomerBillItem;
                    if (selectedItem != null)
                    {
                        // Update the quantity and total price
                        if (int.TryParse(tb_ProductCount.Text, out int newQuantity) && newQuantity > 0)
                        {
                            selectedItem.Quantity = newQuantity;
                            selectedItem.TotalPrice = selectedItem.Quantity * selectedItem.UnitPrice;
                            gridView1.RefreshRow(selectedRowHandle); // Refresh the row to show updated values
                            XtraMessageBox.Show("تم تعيل الكمية!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("ادخل كمية مناسبة.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("يرجى تحديد منتج للتعديل.", "خطأ في التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_DeletePillProduct_Click(object sender, EventArgs e)
        {
            // delete selected product from the grid view
            if (gridView1.SelectedRowsCount > 0)
            {
                int selectedRowHandle = gridView1.GetSelectedRows()[0]; // Get the first selected row
                if (selectedRowHandle >= 0)
                {
                    var selectedItem = gridView1.GetRow(selectedRowHandle) as CustomerBillItemVM;
                    if (selectedItem != null)
                    {
                        customerBillItems.Remove(selectedItem); // Remove the item from the list
                        gridControl1.DataSource = null; // Clear the data source
                        gridControl1.DataSource = customerBillItems; // Rebind the updated list
                        XtraMessageBox.Show("تم حذف المنتج بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("اختر منتج للحذف", "خطأ في التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // calculate total bill amount
            if (customerBillItems.Count == 0)
            {
                XtraMessageBox.Show(".ليس هناك منتجات ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal totalAmount = customerBillItems.Sum(item => item.TotalPrice);

            tb_TotalPillPrice.Text = totalAmount.ToString("F2"); // Format total amount to 2 decimal places



            // Subtract discount from total amount
            if (decimal.TryParse(tb_PillDiscount.Text, out decimal discount) && discount > 0)
            {
                totalAmount -= discount;
                if (totalAmount < 0)
                {
                    totalAmount = 0; // Ensure total amount does not go below zero
                }
            }

            btn_showtotalPillPrice.Text = totalAmount.ToString("F2"); // Update the button text with total amount






            customerBill.CustomerID = Convert.ToInt32(sl_Customers.EditValue);
            customerBill.BillDate = DateTime.Now;
            customerBill.TotalAmount = totalAmount;

            var items = new List<CustomerBillItem>();
            foreach (var billItem in customerBillItems)
            {
                items.Add(new CustomerBillItem
                {
                    ProductID = billItem.ProductID,
                    Quantity = billItem.Quantity,
                    UnitPrice = billItem.UnitPrice,
                    TotalPrice = billItem.TotalPrice
                });
            }


            customerBill.Items = items;

            tb_PillPaymentAmount.Text = "0"; // Set payment 0
            tb_PillRemainingAmount.Text = totalAmount.ToString("F2"); // Set remaining amount to total amount

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            // handle sup payment amount text change
            if (decimal.TryParse(tb_PillPaymentAmount.Text, out decimal paymentAmount) && paymentAmount >= 0)
            {
                // Calculate the remaining amount
                decimal totalAmount = customerBill.TotalAmount;
                decimal remainingAmount = totalAmount - paymentAmount;
                // Update the remaining amount text box
                tb_PillRemainingAmount.Text = remainingAmount.ToString("F2"); // Format to 2 decimal places
                if (remainingAmount < 0)
                {
                    XtraMessageBox.Show("لا يمكن ادخال مبلغ اكبر من المطلوب.", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_PillPaymentAmount.Focus();
                }
            }
            else
            {
                tb_PillRemainingAmount.Text = "0.00"; // Reset to zero if input is invalid
            }
        }

        private void btn_SaveBill_Click(object sender, EventArgs e)
        {
            // save customer bill to database
            if (customerBillItems.Count == 0)
            {
                XtraMessageBox.Show(".لم يتم اختيار منتجات", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sl_Customers.EditValue == null)
            {
                XtraMessageBox.Show(".لم يتم اختيار عملاء", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_PillPaymentAmount.Text) || !decimal.TryParse(tb_PillPaymentAmount.Text, out decimal paymentAmount) || paymentAmount < 0)
            {
                XtraMessageBox.Show("ادخل كمية مناسبة", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_PillDiscount.Text) || !decimal.TryParse(tb_PillDiscount.Text, out decimal discount) || discount < 0)
            {
                XtraMessageBox.Show(".ادخل خصم مناسب", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_TotalPillPrice.Text) || !decimal.TryParse(tb_TotalPillPrice.Text, out decimal totalAmount) || totalAmount < 0)
            {
                XtraMessageBox.Show(".احسب المجموع قبل الحفظ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_PillRemainingAmount.Text) || !decimal.TryParse(tb_PillRemainingAmount.Text, out decimal remainingAmount) || remainingAmount < 0)
            {
                XtraMessageBox.Show(".احسب الكمية المتبقية قبل الحفظ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Create a new CustomerBill object and set its properties
            customerBill.CustomerID = Convert.ToInt32(sl_Customers.EditValue);
            customerBill.BillDate = DateTime.Now;
            customerBill.TotalAmount = Convert.ToDecimal(tb_TotalPillPrice.Text);

            var items = new List<CustomerBillItem>();
            foreach (var billItem in customerBillItems)
            {
                items.Add(new CustomerBillItem
                {
                    ProductID = billItem.ProductID,
                    Quantity = billItem.Quantity,
                    UnitPrice = billItem.UnitPrice,
                    TotalPrice = billItem.TotalPrice
                });
            }

            customerBill.Items = items;

            db.CustomerBills.Add(customerBill); // Add the bill to the database context
            db.SaveChanges();

            lbl_ShowPillNumber.Text = customerBill.CustomerBillID.ToString(); // Show the bill number

            XtraMessageBox.Show("!تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm(); // Reset the form after saving the bill

        }

        private void btn_PrintPill_Click(object sender, EventArgs e)
        {
            // Print the customer bill
            if (customerBillItems.Count == 0)
            {
                XtraMessageBox.Show("لم يتم إضافة أي منتجات إلى الفاتورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sl_Customers.EditValue == null)
            {
                XtraMessageBox.Show("يرجى اختيار العميل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_TotalPillPrice.Text) || !decimal.TryParse(tb_TotalPillPrice.Text, out decimal totalAmount) || totalAmount < 0)
            {
                XtraMessageBox.Show("يرجى حساب المبلغ الإجمالي قبل الطباعة.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // طباعة الفاتورة باستخدام التقرير
            var customer = db.Customers.Find(Convert.ToInt32(sl_Customers.EditValue));
            if (customer == null)
            {
                XtraMessageBox.Show("لم يتم العثور على العميل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var reportModel = new CustomerBillReportViewModel
            {
                CustomerName = customer.Name,
                CustomerPhone = customer.Phone,
                CustomerAddress = customer.Address,
                BillNumber = customerBill.CustomerBillID,
                BillDate = customerBill.BillDate,
                TotalAmount = Convert.ToDecimal(tb_TotalPillPrice.Text),
                Discount = Convert.ToDecimal(tb_PillDiscount.Text),
                PaidAmount = Convert.ToDecimal(tb_PillPaymentAmount.Text),
                RemainingAmount = Convert.ToDecimal(tb_PillRemainingAmount.Text),
                Items = customerBillItems.Select(item => new CustomerBillItemViewModel
                {
                    ProductName = db.Products.Find(item.ProductID)?.Name ?? "Unknown",
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    TotalPrice = item.TotalPrice
                }).ToList()

            };

        }

        private void hl_DeleteBillData_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            sl_Customers.EditValue = null;
            sl_Products.EditValue = null;

            tb_CustomerName.Text = "";
            tb_CustomerPhone.Text = "";
            tb_CustomerAddress.Text = "";

            tb_ProductName.Text = "";
            tb_ProductPrice.Text = "";
            tb_ProductCount.Text = "1";

            btn_showtotalProductPrice.Text = "0";

            tb_PillDiscount.Text = "0";
            tb_TotalPillPrice.Text = "0";
            tb_PillPaymentAmount.Text = "0";
            tb_PillRemainingAmount.Text = "0";

            lbl_ShowPillNumber.Text = "0";

            customerBillItems.Clear(); // Clear the list of bill items
            gridControl1.DataSource = null;

            (gridControl1.MainView as ColumnView).Columns.AddRange(
               new DevExpress.XtraGrid.Columns.GridColumn[]
               {
                    new GridColumn() { FieldName = "ProductID", Caption = "Product ID", Visible = false },
                    new GridColumn() { FieldName = "ProductName", Caption = "اسم المنتج", Visible = true},
                    new GridColumn() { FieldName = "Quantity", Caption = "الكمية", Visible = true },
                    new GridColumn() { FieldName = "UnitPrice", Caption = " سعر الوحدة", Visible = true },
                    new GridColumn() { FieldName = "TotalPrice", Caption = " اجمالي السعر", Visible = true },

               });
            //SummaryItem = new GridColumnSummaryItem(SummaryItemType.Sum,"Quantity","المجموع: {0}") 

            gridControl1.DataSource = customerBillItems;






        }

        private void tb_ProductCount_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_ProductCount.Text, out int count))
            {
                count = 1;
            }

            if (sl_Products.EditValue != null && int.TryParse(sl_Products.EditValue.ToString(), out int productId))
            {
                var existingProduct = db.Products.FirstOrDefault(item => item.ProductID == productId);
                if (existingProduct != null)
                {
                    var price = existingProduct.UnitPrice;
                    btn_showtotalProductPrice.Text = (price * count).ToString("F2");
                }
            }
        }
    }
}
