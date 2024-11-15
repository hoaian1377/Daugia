namespace AppBTL
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_nhaptaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_nhapMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Nhập";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangnhap.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_dangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(530, 337);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(176, 56);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(730, 337);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(178, 56);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Đăng Ký";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(635, 411);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Quên Mật Khẩu";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(660, 292);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ghi nhớ đăng Nhập";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(594, 503);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(271, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Bạn Chấp Nhận Các Điền Khoản Của Tôi\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppBTL.Properties.Resources._8f23fea75f;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 555);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_nhaptaikhoan
            // 
            this.tb_nhaptaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nhaptaikhoan.DefaultText = "";
            this.tb_nhaptaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nhaptaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nhaptaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhaptaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhaptaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhaptaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_nhaptaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhaptaikhoan.IconLeft = global::AppBTL.Properties.Resources._1144760;
            this.tb_nhaptaikhoan.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tb_nhaptaikhoan.Location = new System.Drawing.Point(594, 134);
            this.tb_nhaptaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nhaptaikhoan.Name = "tb_nhaptaikhoan";
            this.tb_nhaptaikhoan.PasswordChar = '\0';
            this.tb_nhaptaikhoan.PlaceholderText = "Nhập Tài Khoản";
            this.tb_nhaptaikhoan.SelectedText = "";
            this.tb_nhaptaikhoan.Size = new System.Drawing.Size(250, 54);
            this.tb_nhaptaikhoan.TabIndex = 9;
            this.tb_nhaptaikhoan.TextChanged += new System.EventHandler(this.tb_nhaptaikhoan_TextChanged);
            // 
            // tb_nhapMatkhau
            // 
            this.tb_nhapMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nhapMatkhau.DefaultText = "";
            this.tb_nhapMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nhapMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nhapMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_nhapMatkhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.tb_nhapMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapMatkhau.IconLeft = global::AppBTL.Properties.Resources.images;
            this.tb_nhapMatkhau.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tb_nhapMatkhau.Location = new System.Drawing.Point(594, 210);
            this.tb_nhapMatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nhapMatkhau.Name = "tb_nhapMatkhau";
            this.tb_nhapMatkhau.PasswordChar = '*';
            this.tb_nhapMatkhau.PlaceholderText = "Nhập Mật Khẩu";
            this.tb_nhapMatkhau.SelectedText = "";
            this.tb_nhapMatkhau.Size = new System.Drawing.Size(250, 54);
            this.tb_nhapMatkhau.TabIndex = 10;
            this.tb_nhapMatkhau.TextChanged += new System.EventHandler(this.tb_nhapMatkhau_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.tb_nhapMatkhau);
            this.Controls.Add(this.tb_nhaptaikhoan);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_dangnhap;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Guna.UI2.WinForms.Guna2TextBox tb_nhaptaikhoan;
        private Guna.UI2.WinForms.Guna2TextBox tb_nhapMatkhau;
    }
}