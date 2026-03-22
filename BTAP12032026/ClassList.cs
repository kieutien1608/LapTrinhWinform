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
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            LoadDanhSachLopHoc();
        }

        private void CauHinhDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        public void LoadDanhSachLopHoc()
        {
            Database.GetAllLopHoc();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Cột 1: Mã Lớp Học
            dataGridView1.Columns.Add("MaLop", "Mã Lớp Học");

            // Cột 2: Tên Lớp Học
            dataGridView1.Columns.Add("TenLop", "Tên Lớp Học");

            // Cột 3: Nút Sửa
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.Name = "Sua";
            btnSua.HeaderText = "Sửa";
            btnSua.Text = "Sửa";
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Width = 80;
            btnSua.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnSua);

            // Cột 4: Nút Xóa
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.Name = "Xoa";
            btnXoa.HeaderText = "Xóa";
            btnXoa.Text = "Xóa";
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Width = 80;
            btnXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnXoa);

            // Đổ dữ liệu
            foreach (var lop in Database.lopHocs)
            {
                dataGridView1.Rows.Add(lop.MaLop, lop.TenLop);
            }

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maLop = dataGridView1.Rows[e.RowIndex].Cells["MaLop"].Value?.ToString();

            // Nút Sửa
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sua")
            {
                LopHoc lop = Database.lopHocs[e.RowIndex];
                EditClass editForm = new EditClass(lop);
                editForm.FormClosed += (s, args) => LoadDanhSachLopHoc();
                editForm.ShowDialog();
            }

            // Nút Xóa
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa lớp '{dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    Database.XoaLopHoc(maLop);
                    LoadDanhSachLopHoc();
                }
            }
        }

        private void AddButton(object sender, EventArgs e)
        {
            AddClass addForm = new AddClass();
            addForm.FormClosed += (s, args) => LoadDanhSachLopHoc();
            addForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

