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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void btn_xedo_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam-Q7\n";
            lbl_xem.Text += "thể loại: Nhà Lầu kIểu Thái \n";
            lbl_xem.Text += "Xây Dựng : Năm 2016\n";
            lbl_xem.Text += "giá khởi điểm: 20000000000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam-Gò Vấp \n";
            lbl_xem.Text += "thể loại: Nhà Lầu Nhật\n";
            lbl_xem.Text += "Xây Dựng : Năm 2013\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam-Q3\n";
            lbl_xem.Text += "thể loại: Nhà Thái  \n";
            lbl_xem.Text += "Xây Dựng : Năm 2016\n";
            lbl_xem.Text += "giá khởi điểm: 1350000000000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam-Q2\n";
            lbl_xem.Text += "thể loại: Nhà Lầu bình dân  \n";
            lbl_xem.Text += "Xây Dựng : Năm 2018\n";
            lbl_xem.Text += "giá khởi điểm: 12000000000";
        }
    }
}
