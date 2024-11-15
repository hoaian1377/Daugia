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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void btn_trong_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam \n";
            lbl_xem.Text += "thể loại: nhạc cụ\n";
            lbl_xem.Text += "phát hành: Năm 1934\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void btn_tranh_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam  \n";
            lbl_xem.Text += "thể loại: Tranh\n";
            lbl_xem.Text += "phát hành: Năm 198\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void btn_tranhan_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam \n";
            lbl_xem.Text += "thể loại: Tranh\n";
            lbl_xem.Text += "phát hành: Năm 1922\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void btn_thuyen_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam \n";
            lbl_xem.Text += "thể loại: Thuyền \n";
            lbl_xem.Text += "phát hành: Năm 1578\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }
    }
}
