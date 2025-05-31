using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using DevExpress.XtraSpreadsheet.Export;
namespace Stock_Management_Dev
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        FORM_Home home = new FORM_Home();
        public Main()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = true;
            FORM_Home homeControl = new FORM_Home();
            homeControl.Dock = DockStyle.Fill; // Makes the control fill the form
            pn_container.Controls.Add(homeControl);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void accordionControlElement8_Click(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            home.Controls.Clear();
            home.Controls.Add(home.pn_stats);
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            pn_container.Controls.Clear(); // Remove previous control

            UserControl selectedControl = null;
            Toast toast = new Toast();
            // Match by element name or text
            switch (e.Element.Text)
            {
                case "الرئيسية": // "Customers"
                    selectedControl = new FORM_Home(); // your custom UserControl
                    break;
                case "الموردين": // "Suppliers"
                    toast.txt_caption.Text = "لسه يعم";
                    toast.Show();
                    break;
                    //case "إضافة صنف":
                    //    selectedControl = new ItemControl();
                    //    break;
                    // Add more cases as needed
            }

            if (selectedControl != null)
            {
                selectedControl.Dock = DockStyle.Fill;
                pn_container.Controls.Add(selectedControl);
            }
        }
    }
}
