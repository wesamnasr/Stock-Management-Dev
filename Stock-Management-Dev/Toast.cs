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
    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Toast_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_caption_Click(object sender, EventArgs e)
        {

        }
    }
}
