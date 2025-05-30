using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management.Models
{
    public class SupplierBillItem
    {
        public int SupplierBillItemID { get; set; }
        public int SupplierBillID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Description { get; set; }
        public virtual SupplierBill SupplierBill { get; set; }
        
        public virtual Product Product { get; set; }

       
        
        // Constructor to calculate TotalPrice
        public void CalculateTotalPrice()
        {
            TotalPrice = Quantity * UnitPrice;
        }
    }
}
