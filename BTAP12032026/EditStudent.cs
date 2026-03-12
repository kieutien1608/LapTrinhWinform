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
    public partial class EditStudent : Form
    {
        private SinhVien _sinhVien;

        public EditStudent()
        {
            InitializeComponent();
        }

        public EditStudent(SinhVien sv)
        {
            InitializeComponent();
            _sinhVien = sv;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            if (_sinhVien == null) return;

            textBoxMaSV.Text = _sinhVien.MaSV;
            textBoxMaSV.ReadOnly = true;
            textBoxHovaTen.Text = _sinhVien.HoTen;
            textBoxNgaySinh.Text = _sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            textBoxGioiTinh.Text = _sinhVien.GioiTinh;
            textBoxMaLop.Text = _sinhVien.MaLop;
            textBoxTenLop.Text = _sinhVien.TenLop;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (_sinhVien == null) return;

            if (string.IsNullOrEmpty(textBoxHovaTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!",
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

            _sinhVien.HoTen = textBoxHovaTen.Text.Trim();
            _sinhVien.NgaySinh = ngaySinh; 
            _sinhVien.GioiTinh = textBoxGioiTinh.Text.Trim();
            _sinhVien.MaLop = textBoxMaLop.Text.Trim();
            _sinhVien.TenLop = textBoxTenLop.Text.Trim();

            Database.SuaSinhVien(_sinhVien);
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEdit_Click(object sender, EventArgs e) { }
        private void labelMaSv_Click(object sender, EventArgs e) { }
        private void labelHovaTen_Click(object sender, EventArgs e) { }
        private void labelNgaySinh_Click(object sender, EventArgs e) { }
        private void labelGioiTinh_Click(object sender, EventArgs e) { }
        private void labelMaLop_Click(object sender, EventArgs e) { }
        private void labelTenLop_Click(object sender, EventArgs e) { }
        private void textBoxMaSV_TextChanged(object sender, EventArgs e) { }
        private void textBoxHovaTen_TextChanged(object sender, EventArgs e) { }
        private void textBoxNgaySinh_TextChanged(object sender, EventArgs e) { }
        private void textBoxGioiTinh_TextChanged(object sender, EventArgs e) { }
        private void textBoxMaLop_TextChanged(object sender, EventArgs e) { }
        private void textBoxTenLop_TextChanged(object sender, EventArgs e) { }
    }
}