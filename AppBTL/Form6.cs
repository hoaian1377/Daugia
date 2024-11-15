using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTL { 

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-AV5VHME;Initial Catalog=QLKH;Integrated Security=True;Encrypt=true;TrustServerCertificate=True";
        SqlDataAdapter adt;
        DataTable dt;
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string otp=tb_nhapmaotp.Text;
            if(otp.Length !=6)
            {
                MessageBox.Show("Mã OTP Của Bạn Không Hợp Lệ","Cảnh Báo",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
            else
            {
                MessageBox.Show("Xác Nhận Thành Công", "Thông Báo");
                Form7 fm7 =new Form7();
                fm7.ShowDialog();
                this.Close();
            }
            
            
           
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_gui_Click(object sender, EventArgs e)
        {
            string email = tb_nhapemail.Text;

            if (email == "")
            {
                MessageBox.Show("Hãy Nhập Email Của Bạn", "Thông Báo");
                return;
            }

            else
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    try
                    {
                        conn.Open();
                        // Câu lệnh SQL để kiểm tra sự tồn tại của email
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_KhachhHang WHERE Email = @Email", conn))
                        {
                            // Thêm tham số email để tránh lỗi SQL Injection
                            cmd.Parameters.AddWithValue("@Email", email);

                            // Thực thi truy vấn và kiểm tra kết quả
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Mã OTP Đã Được Gửi Đến Mail Của Bạn");
                            }
                            else
                            {
                                MessageBox.Show("Email này chưa tồn tại.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
