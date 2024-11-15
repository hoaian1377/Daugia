using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTL
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn tệp không
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp được chọn
                    string filePath = openFileDialog.FileName;
                    Image selectedImage=Image.FromFile(filePath);   

                    // Tải hình ảnh từ đường dẫn tệp và gán vào PictureBox
                    pB_ad1.Image = Image.FromFile(filePath);
                    pB_ad2.SizeMode = PictureBoxSizeMode.StretchImage; // Điều chỉnh kích thước hình ảnh
                    Form2 form2 = new Form2();
                    form2.UpdateImage(selectedImage);
                    form2.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_chitiet2_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void btn_chitiet1_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
        }

        private void btn_chitiet3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void btn_chitiet4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }
    }
}
