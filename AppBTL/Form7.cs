using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace AppBTL
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        string str = "Data Source=DESKTOP-AV5VHME;Initial Catalog=QLKH;Integrated Security=True;Encrypt=true;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tb_nhaplaiemail.Text;
            string newpassword = tb_nhapmatkhaumoi.Text;
            string confirmpassword = tb_nhaplaimatkhaumoi.Text;

            // Basic input validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newpassword) || string.IsNullOrEmpty(confirmpassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newpassword != confirmpassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect to the database and check if the username exists
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();

                    // Check if the username exists in the database
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_KhachhHang WHERE Email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Tên tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update the password if the username exists
                    using (SqlCommand cmd = new SqlCommand("UPDATE tb_KhachhHang SET MK = @MatKhauMoi WHERE Email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@MatKhauMoi", newpassword);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form5 fm5 = new Form5();
                        fm5.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
