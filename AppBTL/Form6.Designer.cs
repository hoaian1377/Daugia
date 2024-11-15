namespace AppBTL
{
    partial class Form6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.tb_nhapmaotp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_gui = new System.Windows.Forms.Button();
            this.tb_nhapemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_xacnhan);
            this.panel1.Controls.Add(this.tb_nhapmaotp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_gui);
            this.panel1.Controls.Add(this.tb_nhapemail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(261, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 447);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.Location = new System.Drawing.Point(123, 341);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(160, 55);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // tb_nhapmaotp
            // 
            this.tb_nhapmaotp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nhapmaotp.DefaultText = "";
            this.tb_nhapmaotp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nhapmaotp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nhapmaotp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapmaotp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapmaotp.FillColor = System.Drawing.Color.RoyalBlue;
            this.tb_nhapmaotp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapmaotp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhapmaotp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapmaotp.Location = new System.Drawing.Point(105, 266);
            this.tb_nhapmaotp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nhapmaotp.Name = "tb_nhapmaotp";
            this.tb_nhapmaotp.PasswordChar = '\0';
            this.tb_nhapmaotp.PlaceholderText = "Nhập Mã OTP";
            this.tb_nhapmaotp.SelectedText = "";
            this.tb_nhapmaotp.Size = new System.Drawing.Size(198, 48);
            this.tb_nhapmaotp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã OTP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_gui
            // 
            this.bt_gui.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_gui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gui.Location = new System.Drawing.Point(153, 165);
            this.bt_gui.Name = "bt_gui";
            this.bt_gui.Size = new System.Drawing.Size(100, 43);
            this.bt_gui.TabIndex = 2;
            this.bt_gui.Text = "Gửi";
            this.bt_gui.UseVisualStyleBackColor = false;
            this.bt_gui.Click += new System.EventHandler(this.bt_gui_Click);
            // 
            // tb_nhapemail
            // 
            this.tb_nhapemail.BackColor = System.Drawing.Color.Black;
            this.tb_nhapemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nhapemail.DefaultText = "";
            this.tb_nhapemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nhapemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nhapemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nhapemail.FillColor = System.Drawing.Color.RoyalBlue;
            this.tb_nhapemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhapemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nhapemail.Location = new System.Drawing.Point(105, 104);
            this.tb_nhapemail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_nhapemail.Name = "tb_nhapemail";
            this.tb_nhapemail.PasswordChar = '\0';
            this.tb_nhapemail.PlaceholderText = "Nhập Email";
            this.tb_nhapemail.SelectedText = "";
            this.tb_nhapemail.Size = new System.Drawing.Size(198, 52);
            this.tb_nhapemail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppBTL.Properties.Resources.pngtree_modern_simple_elegant_beautiful_color_website_landing_page_background_image_757350;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_gui;
        private Guna.UI2.WinForms.Guna2TextBox tb_nhapemail;
        private System.Windows.Forms.Button btn_xacnhan;
        private Guna.UI2.WinForms.Guna2TextBox tb_nhapmaotp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}