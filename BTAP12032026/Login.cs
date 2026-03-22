using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTAP13032026
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void labelPassword(object sender, EventArgs e)
        {
            
        }

        private void labelDangNhap(object sender, EventArgs e)
        {

        }
        private void labelUsername(object sender, EventArgs e)
        {

        }

        private void LoadLogInForm(object sender, EventArgs e)
        {
            Database.GetAllDangNhap();
        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }

        private void DangNhap(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool dangNhapThanhCong = false;

            foreach (var dn in Database.dangNhaps)
            {
                if (dn.username == username && dn.password == password)
                {
                    dangNhapThanhCong = true;
                    break;
                }
            }
            if (dangNhapThanhCong)
            {
                this.Hide();
                Home home = new Home();
                home.FormClosed += (s, args) => Application.Exit(); 
                home.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.");
            }
        }
        private void Exit(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
