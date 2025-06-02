using DevExpress.XtraEditors;
using Stock_Management_Dev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_Dev
{
    public partial class DebtsForm : DevExpress.XtraEditors.XtraForm
    {
        public DebtsForm()
        {
            InitializeComponent();

            using (var db = new AppDBContext())
            {
                var debts = db.Customers.ToList();

                dataGridView1.DataSource = debts;
            }
        }

      

     
    }
}