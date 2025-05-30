using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Dev.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

      
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SupplierBill> Invoices { get; set; }
    }
}
