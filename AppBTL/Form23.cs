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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void btn_binh1_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Việt Nam \n";
            lbl_xem.Text += "thể loại: đồ cổ \n";
            lbl_xem.Text += "phát hành: Năm 1554\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Trung Quốc  \n";
            lbl_xem.Text += "thể loại: đồ cổ  \n";
            lbl_xem.Text += "phát hành: Năm 1652\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lbl_xem.Text = "xuất xứ: Trung Quốc  \n";
            lbl_xem.Text += "thể loại: đồ cổ  \n";
            lbl_xem.Text += "phát hành: Năm 1622\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            lbl_xem.Text = "xuất xứ: Trung Quốc  \n";
            lbl_xem.Text += "thể loại: đồ cổ  \n";
            lbl_xem.Text += "phát hành: Năm 1642\n";
            lbl_xem.Text += "giá khởi điểm: 2000000000";
        }
    }
    }

