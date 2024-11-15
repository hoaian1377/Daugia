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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            lbl_xem.Text = "xuất xứ: Chưa rõ \n";
            lbl_xem.Text += "thể loại: Đá quý  \n";
            lbl_xem.Text += "tìm thấy : Năm 2018\n";
            lbl_xem.Text += "giá khởi điểm: 12000000000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Chưa rõ \n";
            lbl_xem.Text += "thể loại: Đá quý  \n";
            lbl_xem.Text += "tìm thấy : Năm 2013\n";
            lbl_xem.Text += "giá khởi điểm: 12000000000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Chưa rõ \n";
            lbl_xem.Text += "thể loại: Đá quý  \n";
            lbl_xem.Text += "tìm thấy : Năm 2015\n";
            lbl_xem.Text += "giá khởi điểm: 12000000000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_xem.Text = "xuất xứ: Trung Quốc\n";
            lbl_xem.Text += "thể loại: Đá quý  \n";
            lbl_xem.Text += "tìm thấy : Năm 2012\n";
            lbl_xem.Text += "giá khởi điểm: 12000000000";
        }
    }
}
