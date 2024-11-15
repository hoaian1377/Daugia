using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTL
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        string str = "Data Source=DESKTOP-AV5VHME;Initial Catalog=QLKH;Integrated Security=True;Encrypt=true;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt=new SqlDataAdapter();
        DataTable dt=new DataTable();
        void loaddata()
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_KhachhHang";
                adt.SelectCommand = cmd;
                dt.Clear();
                adt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi");
            }
            finally
            {
                conn?.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = tb_nhaptaikhoan.Text.Trim();
            string password = tb_nhapMatkhau.Text.Trim();

            if (username == "" && password == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Thông Báo");
                return;
            }

            using (TcpClient client = new TcpClient("127.0.0.1", 8888))
            {
                NetworkStream stream = client.GetStream();
                string message = $"{username}|{password}";
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (response == "Login success")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    Form1 mainForm = new Form1();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông Báo");
                }
            }
        }




        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                Form8 fm8 = new Form8();
                fm8.Show();
                this.Hide();
            }

        }



        private void tb_nhaptaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhapMatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form6 fm6=new Form6();
            fm6.ShowDialog();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
