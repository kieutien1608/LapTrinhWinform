using System;
using System.Windows.Forms;

namespace BTAP13032026
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) ||
                string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Lớp và Tên Lớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopHoc lop = new LopHoc
            {
                MaLop = textBox1.Text.Trim(),
                TenLop = textBox2.Text.Trim()
            };

            Database.ThemLopHoc(lop);
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các hàm do Designer tạo ra, giữ nguyên
        private void labelAdd_Click(object sender, EventArgs e) { }
        private void labelMaLop_Click(object sender, EventArgs e) { }
        private void labelTenLop_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}