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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_xedo_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Đức\n";
            lbl_xem.Text += "thể loại: xe thể thao\n";
            lbl_xem.Text += "phát hành: năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 2500000000";

        }

        private void btn_xeden_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Mỹ \n";
            lbl_xem.Text += "thể loại: xe thể thao\n";
            lbl_xem.Text += "phát hành: năm 1956\n";
            lbl_xem.Text += "giá khởi điểm: 3500000000";


        }

        private void btn_xexanh_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Đức \n";
            lbl_xem.Text += "thể loại: Xe thể thao\n";
            lbl_xem.Text += "phát hành: Năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";

        }

        private void btn_xetrang_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Đức\n";
            lbl_xem.Text += "thể loại: xe thể thao\n";
            lbl_xem.Text += "phát hành: năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 20000000000";

        }
    }
}
