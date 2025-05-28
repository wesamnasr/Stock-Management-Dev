using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management.Models
{
    public class CustomerBillItem
    {
        public int CustomerBillItemID { get; set; }
        public int CustomerBillID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual CustomerBill CustomerBill { get; set; }
        public virtual Product Product { get; set; }

        // Constructor to calculate TotalPrice
        public void CalculateTotalPrice()
        {
            TotalPrice = Quantity * UnitPrice;
        }
    }
}
