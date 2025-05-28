using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management.Models
{
    public class CustomerBill
    {
        public int CustomerBillID { get; set; }
        public DateTime BillDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CustomerBillItem> Items { get; set; } = new List<CustomerBillItem> ();

        
    }
}
