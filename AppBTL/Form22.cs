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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Đức \n";
            lbl_xem.Text += "thể loại: Xe thể thao cổ\n";
            lbl_xem.Text += "phát hành: Năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: mỹ\n";
            lbl_xem.Text += "thể loại: Xe cổ \n";
            lbl_xem.Text += "phát hành: Năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Đức \n";
            lbl_xem.Text += "thể loại: Xe thể thao\n";
            lbl_xem.Text += "phát hành: Năm 1989\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Anh \n";
            lbl_xem.Text += "thể loại: Xe cổ \n";
            lbl_xem.Text += "phát hành: Năm 1954\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }
    }
}
