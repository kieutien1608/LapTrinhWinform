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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            buttonThem.Click += BtnThem_Click;
            buttonBack.Click += BtnBack_Click;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSV.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxHovaTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ Tên!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(textBoxNgaySinh.Text.Trim(), "dd/MM/yyyy",
                null, System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Định dạng: dd/MM/yyyy",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = new SinhVien
            {
                MaSV = textBoxMaSV.Text.Trim(),
                HoTen = textBoxHovaTen.Text.Trim(),
                NgaySinh = ngaySinh, 
                GioiTinh = textBoxGioiTinh.Text.Trim(),
                DiaChi = "",
                MaLop = textBoxMaLop.Text.Trim(),
                TenLop = textBoxTenLop.Text.Trim()
            };

            Database.ThemSinhVien(sv);
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void labelAdd_Click(object sender, EventArgs e) { }
    }
}