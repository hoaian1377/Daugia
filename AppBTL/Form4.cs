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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_CT1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
                form20.Show();
        }

        private void btn_CT2_Click(object sender, EventArgs e)
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
