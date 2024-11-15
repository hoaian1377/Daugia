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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_CT2_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void UpdateImage(Image image)
        {
            if (image != null)
            {
                pictureBox1.Image = image; // Gán hình ảnh cho PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc bất kỳ SizeMode nào bạn muốn
            }
        }

        private void btn_CT1_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void btn_CT3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void btn_CT4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }
    }
}
