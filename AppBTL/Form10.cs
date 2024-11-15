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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbn_xacnhan2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tb_nhapgia2.Text))
            {
                MessageBox.Show("Vui lòng nhập giá."); // Message if no value is entered
                return;
            }

            // Parse the entered price from tb_nhapgia1
            if (long.TryParse(tb_nhapgia2.Text, out long enteredPrice))
            {
                // Check if lbl_gia contains a valid number
                if (long.TryParse(lbl_gia1.Text, out long highestPrice))
                {
                    // Check if the entered price is less than the highest price
                    if (enteredPrice < highestPrice)
                    {
                        MessageBox.Show("Vui lòng nhập giá cao hơn giá cao nhất hiện tại.");
                    }
                    else if (enteredPrice < 1000000000)
                    {
                        MessageBox.Show("Vui lòng nhập giá cho hợp lệ.");
                    }
                    else
                    {
                        lbl_gia1.Text = tb_nhapgia2.Text; // Update highest bid if valid
                        tb_nhapgia2.Text = ""; // Clear the TextBox
                    }
                }
                else
                {
                    // If lbl_gia does not contain a valid number, set an initial value or display an error
                    lbl_gia1.Text = "2000000000"; // Set an initial highest price if needed
                    MessageBox.Show(" Đã đặt giá cao nhất thành 2000000000.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }



        private void tbn_xacnhan1_Click(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(tb_nhapgia1.Text))
            {
                MessageBox.Show("Vui lòng nhập giá."); // Message if no value is entered
                return;
            }

            // Parse the entered price from tb_nhapgia1
            if (long.TryParse(tb_nhapgia1.Text, out long enteredPrice))
            {
                // Check if the entered price is at least 100,000
                if (enteredPrice < 1000000000)
                {
                    MessageBox.Show("Vui lòng nhập giá cho hợp lệ.");
                    return;
                }

                // Check if lbl_gia contains a valid number
                if (long.TryParse(lbl_gia.Text, out long highestPrice))
                {
                    // Check if the entered price is less than the highest price
                    if (enteredPrice < highestPrice)
                    {
                        MessageBox.Show("Vui lòng nhập giá cao hơn giá cao nhất hiện tại.");
                    }
                    else
                    {
                        lbl_gia.Text = tb_nhapgia1.Text; // Update highest bid if valid
                        tb_nhapgia1.Text = ""; // Clear the TextBox
                    }
                }
                else
                {

                    lbl_gia.Text = "2000000000"; 
                    MessageBox.Show(" Đã đặt giá cao nhất thành 2000000000.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void tbn_xacnhan3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nhapgia3.Text))
            {
                MessageBox.Show("Vui lòng nhập giá."); // Message if no value is entered
                return;
            }

            // Parse the entered price from tb_nhapgia1
            if (long.TryParse(tb_nhapgia3.Text, out long enteredPrice))
            {
                // Check if lbl_gia contains a valid number
                if (long.TryParse(lbl_gia2.Text, out long highestPrice))
                {
                    // Check if the entered price is less than the highest price
                    if (enteredPrice < highestPrice)
                    {
                        MessageBox.Show("Vui lòng nhập giá cao hơn giá cao nhất hiện tại.");
                    }
                    else if (enteredPrice < 1000000000)
                    {
                        MessageBox.Show("Vui lòng nhập giá cho hợp lệ.");
                    }
                    else
                    {
                        lbl_gia2.Text = tb_nhapgia3.Text; // Update highest bid if valid
                        tb_nhapgia3.Text = ""; // Clear the TextBox
                    }
                }
                else
                {
                    // If lbl_gia does not contain a valid number, set an initial value or display an error
                    lbl_gia2.Text = "2000000000"; // Set an initial highest price if needed
                    MessageBox.Show(" Đã đặt giá cao nhất thành 2000000000.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }


        private void tbn_xacnhan4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tb_nhapgia4.Text))
            {
                MessageBox.Show("Vui lòng nhập giá."); // Message if no value is entered
                return;
            }

            // Parse the entered price from tb_nhapgia1
            if (long.TryParse(tb_nhapgia4.Text, out long enteredPrice))
            {
                // Check if lbl_gia contains a valid number
                if (long.TryParse(lbl_gia3.Text, out long highestPrice))
                {
                    // Check if the entered price is less than the highest price
                    if (enteredPrice < highestPrice)
                    {
                        MessageBox.Show("Vui lòng nhập giá cao hơn giá cao nhất hiện tại.");
                    }
                    else if (enteredPrice < 1000000000)
                    {
                        MessageBox.Show("Vui lòng nhập giá cho hợp lệ.");
                    }
                    else
                    {
                        lbl_gia3.Text = tb_nhapgia4.Text; // Update highest bid if valid
                        tb_nhapgia4.Text = ""; // Clear the TextBox
                    }
                }
                else
                {
                    // If lbl_gia does not contain a valid number, set an initial value or display an error
                    lbl_gia3.Text = "2000000000"; // Set an initial highest price if needed
                    MessageBox.Show("Đã đặt giá cao nhất thành 2000000000.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void tbn_chitiet1_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.Show();
        }

        private void tbn_chitiet2_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void tbn_chitiet3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tbn_chitiet4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }
    }
   
}

