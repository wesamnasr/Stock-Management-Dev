using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Management_Dev.Models;

namespace Stock_Management_Dev
{
    public partial class Welcome : Form
    {
        Main main = new Main();

        AppDBContext _context = new AppDBContext();

        public Welcome()
        {
            InitializeComponent();
            pswrd_txt.Focus();
        }

        #region Drag
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            var CurrentPass = _context.Passwords.OrderByDescending(p => p.PasswordID).FirstOrDefault();
            if (pswrd_txt.Text != CurrentPass.NewPassword)
            {
                Toast toast = new Toast();
                toast.txt_caption.Text = "كلمة سر غير صحيحة";
                toast.alert_color.BackColor = Color.Red;
                toast.Show();
            }
            else
            {
                main.Show();
            }
        }

        private void pswrd_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                enterbtn.PerformClick();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            pswrd_txt.Focus();
        }

        private void Welcome_Shown(object sender, EventArgs e)
        {
            pswrd_txt.Focus();
        }
    }
}
