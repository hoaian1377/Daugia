using System;
using System.Windows.Forms;

namespace AppBTL
{
    public partial class Form1 : Form
    {
        private bool isAdminAuthenticated = false; // Biến kiểm tra xác thực quyền admin
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
            custom();
        }

        private void custom()
        {
            panel_TSDG.Visible = false;
            panel_CDG.Visible = false;
            panel_Admin.Visible = false;
        }

        private void hidemenu()
        {
            if (panel_TSDG.Visible)
            {
                panel_TSDG.Visible = false;
            }
            if (panel_CDG.Visible)
            {
                panel_CDG.Visible = false;
            }
            if (panel_Admin.Visible)
            {
                panel_Admin.Visible = false;
            }
        }

        private void showmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidemenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_TSDG_Click(object sender, EventArgs e)
        {
            showmenu(panel_TSDG);
        }

        private void btn_CDG_Click(object sender, EventArgs e)
        {
            showmenu(panel_CDG);
        }

        private void openShowForm(Form ShowForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ShowForm;
            ShowForm.TopLevel = false;
            ShowForm.FormBorderStyle = FormBorderStyle.None;
            ShowForm.Dock = DockStyle.Fill;
            panelShowForm.Controls.Add(ShowForm);
            panelShowForm.Tag = ShowForm;
            ShowForm.BringToFront();
            ShowForm.Show();
        }

        // Sự kiện khi bấm nút PTXC
        private void btn_PTXC_Click(object sender, EventArgs e)
        {
            openShowForm(new Form2());
            hidemenu();
        }

        // Sự kiện khi bấm nút DC
        private void btn_DC_Click(object sender, EventArgs e)
        {
            openShowForm(new Form3());
            hidemenu();
        }

        // Sự kiện khi bấm nút BDS
        private void btn_BDS_Click_1(object sender, EventArgs e)
        {
            openShowForm(new Form4());
            hidemenu();
        }

        // Sự kiện khi bấm nút Home
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        // Sự kiện khi bấm nút PTXCA
        private void btn_PTXCA_Click(object sender, EventArgs e)
        {
            openShowForm(new Form15());
            hidemenu();
        }

        // Xác thực quyền admin và hiển thị menu admin nếu xác thực thành công
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            if (!isAdminAuthenticated)
            {
                if (AuthenticateAdmin())
                {
                    isAdminAuthenticated = true;
                    showmenu(panel_Admin); // Hiển thị menu admin sau khi xác thực thành công
                }
                else
                {
                    MessageBox.Show("Incorrect password. Access denied.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                showmenu(panel_Admin); // Nếu đã xác thực rồi, chỉ cần hiển thị menu admin
            }
        }

        // Phương thức xác thực admin
        private bool AuthenticateAdmin()
        {
            string password = "admin123"; // Mật khẩu admin (nên thay bằng phương thức bảo mật trong thực tế)
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Admin Authentication", "", -1, -1);
            return input == password;
        }

        // Các sự kiện khác để mở form con
        private void btn_HT_Click(object sender, EventArgs e)
        {
            openShowForm(new Form13());
            hidemenu();
        }

        private void btn_ĐCA_Click(object sender, EventArgs e)
        {
            openShowForm(new Form16());
            hidemenu();
        }

        private void btn_BĐSA_Click(object sender, EventArgs e)
        {
            openShowForm(new Form17());
            hidemenu();
        }

        private void btn_SDG_Click(object sender, EventArgs e)
        {
            openShowForm(new Form9());
            hidemenu();
        }

        private void btn_DDR_Click(object sender, EventArgs e)
        {
            openShowForm(new Form10());
            hidemenu();
        }

        private void btn_KT_Click(object sender, EventArgs e)
        {
            openShowForm(new Form11());
            hidemenu();
        }
    }
}
