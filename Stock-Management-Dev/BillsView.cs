using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Stock_Management_Dev
{
    public partial class BillsView : Form
    {
        BillSupplierView view = new BillSupplierView();
        BillsClientView billsClient = new BillsClientView();
        public BillsView()
        {
            InitializeComponent();
            billsClient.Dock = DockStyle.Fill;
            pn_tables.Controls.Add(billsClient.pn_cont);
        }

        private void supp_bills_Click(object sender, EventArgs e)
        {
            pn_tables.Controls.Clear();
            view.pn_cont.Dock = DockStyle.Fill;
            pn_tables.Controls.Add(view.pn_cont);
        }

        private void cust_bills_Click(object sender, EventArgs e)
        {
            pn_tables.Controls.Clear();
            billsClient.pn_cont.Dock = DockStyle.Fill;
            pn_tables.Controls.Add(billsClient.pn_cont);
        }

       
    }
}
