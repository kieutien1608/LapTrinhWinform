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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            LoadDanhSachSinhVien();
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

        public void LoadDanhSachSinhVien()
        {
            Database.GetAllSinhVien();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("MaSV", "Mã SV");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("NgaySinh", "Ngày Sinh");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("DiaChi", "Địa Chỉ");
            dataGridView1.Columns.Add("MaLop", "Mã Lớp");
            dataGridView1.Columns.Add("TenLop", "Tên Lớp");

            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.Name = "Sua";
            btnSua.HeaderText = "Sửa";
            btnSua.Text = "Sửa";
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Width = 80;
            btnSua.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnSua);

            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.Name = "Xoa";
            btnXoa.HeaderText = "Xóa";
            btnXoa.Text = "Xóa";
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Width = 80;
            btnXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns.Add(btnXoa);

            foreach (var sv in Database.sinhViens)
            {
                dataGridView1.Rows.Add(
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.GioiTinh,
                    sv.DiaChi,
                    sv.MaLop,
                    sv.TenLop
                );
            }

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maSV = dataGridView1.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sua")
            {
                SinhVien sv = Database.sinhViens[e.RowIndex];
                EditStudent editForm = new EditStudent(sv);
                editForm.FormClosed += (s, args) => LoadDanhSachSinhVien();
                editForm.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa sinh viên '{dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    Database.XoaSinhVien(maSV);
                    LoadDanhSachSinhVien();
                }
            }
        }

        private void AddButton(object sender, EventArgs e)
        {
            AddStudent addForm = new AddStudent();
            addForm.FormClosed += (s, args) => LoadDanhSachSinhVien();
            addForm.ShowDialog();
        }

        private void EditButton(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void labelQLSV(object sender, EventArgs e) { }
        private void labelDSSV(object sender, EventArgs e) { }
        private void dataGridView_StudentList(object sender, DataGridViewCellEventArgs e) { }
    }
}