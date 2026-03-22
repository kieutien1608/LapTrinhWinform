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
    public partial class EditClass : Form
    {
        private LopHoc _lopHoc;

        public EditClass()
        {
            InitializeComponent();
        }

        public EditClass(LopHoc lop)
        {
            InitializeComponent();
            _lopHoc = lop;
        }

        private void EditClass_Load(object sender, EventArgs e)
        {
            if (_lopHoc == null) return;

            textBox1.Text = _lopHoc.MaLop;
            textBox1.ReadOnly = true;
            textBox2.Text = _lopHoc.TenLop;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (_lopHoc == null) return;

            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Tên Lớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _lopHoc.MaLop = textBox1.Text.Trim();
            _lopHoc.TenLop = textBox2.Text.Trim();
            Database.SuaLopHoc(_lopHoc);
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAdd_Click(object sender, EventArgs e) { }
        private void labelMaLop_Click(object sender, EventArgs e) { }
        private void labelTenLop_Click(object sender, EventArgs e) { }
        private void textBoxMaSV_TextChanged(object sender, EventArgs e) { }
        private void textBoxTenLop_TextChanged(object sender, EventArgs e) { }
    }
}