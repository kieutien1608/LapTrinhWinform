using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTAP13032026
{
    public class Database
    {
        const string connectionString = "Data Source=DESKTOP-LO7A6QH;Initial Catalog=DangNhap;Integrated Security=True;TrustServerCertificate=True";

        public static List<DangNhap> dangNhaps = new List<DangNhap>();
        public static List<SinhVien> sinhViens = new List<SinhVien>();
        public static List<LopHoc> lopHocs = new List<LopHoc>();

        // ==================== ĐĂNG NHẬP ====================
        public static void GetAllDangNhap()
        {
            dangNhaps.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT username, password FROM Account";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dangNhaps.Add(new DangNhap
                            {
                                username = reader["username"].ToString(),
                                password = reader["password"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi");
            }
        }

        // ==================== SINH VIÊN ====================
        public static void GetAllSinhVien()
        {
            sinhViens.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, TenLop FROM SinhVien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sinhViens.Add(new SinhVien
                            {
                                MaSV = reader["MaSV"].ToString(),
                                HoTen = reader["HoTen"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                MaLop = reader["MaLop"].ToString(),
                                TenLop = reader["TenLop"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi");
            }
        }

        public static void ThemSinhVien(SinhVien sv)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, TenLop) 
                                     VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop, @TenLop)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSV", sv.MaSV);
                        command.Parameters.AddWithValue("@HoTen", sv.HoTen);
                        command.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                        command.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                        command.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                        command.Parameters.AddWithValue("@MaLop", sv.MaLop);
                        command.Parameters.AddWithValue("@TenLop", sv.TenLop);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi");
            }
        }

        public static void SuaSinhVien(SinhVien sv)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE SinhVien SET
                                     HoTen    = @HoTen,
                                     NgaySinh = @NgaySinh,
                                     GioiTinh = @GioiTinh,
                                     DiaChi   = @DiaChi,
                                     MaLop    = @MaLop,
                                     TenLop   = @TenLop
                                     WHERE MaSV = @MaSV";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSV", sv.MaSV);
                        command.Parameters.AddWithValue("@HoTen", sv.HoTen);
                        command.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                        command.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                        command.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                        command.Parameters.AddWithValue("@MaLop", sv.MaLop);
                        command.Parameters.AddWithValue("@TenLop", sv.TenLop);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi");
            }
        }

        public static void XoaSinhVien(string maSV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSV", maSV);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi");
            }
        }

        // ==================== LỚP HỌC ====================
        public static void GetAllLopHoc()
        {
            lopHocs.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MaLop, TenLop FROM LopHoc"; // Sửa tên bảng nếu khác
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lopHocs.Add(new LopHoc
                            {
                                MaLop = reader["MaLop"].ToString(),
                                TenLop = reader["TenLop"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi");
            }
        }

        public static void ThemLopHoc(LopHoc lop)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO LopHoc (MaLop, TenLop) VALUES (@MaLop, @TenLop)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", lop.MaLop);
                        command.Parameters.AddWithValue("@TenLop", lop.TenLop);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm lớp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi");
            }
        }

        public static void SuaLopHoc(LopHoc lop)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE LopHoc SET TenLop = @TenLop WHERE MaLop = @MaLop";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", lop.MaLop);
                        command.Parameters.AddWithValue("@TenLop", lop.TenLop);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi");
            }
        }

        public static void XoaLopHoc(string maLop)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM LopHoc WHERE MaLop = @MaLop";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", maLop);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa lớp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi");
            }
        }
    }
}
