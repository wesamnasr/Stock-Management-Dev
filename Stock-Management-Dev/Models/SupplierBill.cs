using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Dev.Models
{
    public class SupplierBill
    {
        public int SupplierBillID { get; set; }
        public int SupplierID { get; set; }
       
        public DateTime BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }


        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<SupplierBillItem> Items { get; set; } = new List<SupplierBillItem>();
    }
}
