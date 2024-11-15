using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net; // Import thư viện BCrypt

namespace AppBTL
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-AV5VHME;Initial Catalog=QLKH;Integrated Security=True;Encrypt=true;TrustServerCertificate=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void loaddata()
        {
            using (cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_KhachhHang";
                adt.SelectCommand = cmd;
                dt.Clear();
                adt.Fill(dt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường nhập liệu có hợp lệ hay không
                if (!ktradn())
                {
                    return; // Dừng xử lý nếu không hợp lệ
                }

                // Tạo lệnh kiểm tra tài khoản đã tồn tại
                using (cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM tb_KhachhHang WHERE TenTk=@TenTk";
                    cmd.Parameters.AddWithValue("@TenTk", tb_tennguoidung.Text);
                    int Count = (int)cmd.ExecuteScalar();

                    // Nếu tài khoản đã tồn tại, thông báo lỗi và dừng xử lý
                    if (Count > 0)
                    {
                        MessageBox.Show("Tài Khoản Hoặc Số Điện Thoại Đã Tồn Tại Vui Lòng Nhập Lại!!", "Thông Báo");
                        return; // Dừng xử lý
                    }
                }

                // Nếu tài khoản không tồn tại, tiếp tục thêm dữ liệu mới
                using (cmd = conn.CreateCommand())
                {
                    // Mã hóa mật khẩu trước khi lưu
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tb_nhapmatkhau.Text);

                    cmd.CommandText = "INSERT INTO tb_KhachhHang (TenTk, MK, Email) VALUES (@TenTk, @MK, @Email)";
                    cmd.Parameters.AddWithValue("@TenTk", tb_tennguoidung.Text);
                    cmd.Parameters.AddWithValue("@MK", hashedPassword); // Sử dụng mật khẩu đã mã hóa
                    cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                    cmd.ExecuteNonQuery();
                }

                // Load lại dữ liệu sau khi thêm
                loaddata();
                MessageBox.Show("Tạo tài khoản thành công!", "Thông Báo");

                // Chuyển sang form đăng nhập sau khi tạo tài khoản thành công
                this.Hide();
                Form5 fm5 = new Form5();
                fm5.ShowDialog();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            try
            {
                conn.Open();
                loaddata();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi Kết Nối: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tb_tennguoidung_TextChanged(object sender, EventArgs e)
        {
        }

        bool ktradn()
        {
            if (string.IsNullOrWhiteSpace(tb_tennguoidung.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản", "Thông báo");
                tb_tennguoidung.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_nhapmatkhau.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông báo");
                tb_nhapmatkhau.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_email.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Email", "Thông báo");
                tb_email.Focus();
                return false;
            }
            if (tb_nhapmatkhau.Text != tb_nhaplaimatkhau.Text)
            {
                MessageBox.Show("Mật Khẩu Không Khớp", "Thông Báo");
                tb_nhaplaimatkhau.Focus();
                return false;
            }
            return true;
        }
    }
}
