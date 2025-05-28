using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string?Description { get; set; }
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
