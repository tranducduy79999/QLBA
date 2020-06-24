namespace GUI.QuanTriVien
{
    partial class FormForAdmin
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
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_QuanLyTaiKhoanAdmin = new System.Windows.Forms.Button();
            this.btn_QuanLyKhoa = new System.Windows.Forms.Button();
            this.btn_QuanLyBenhAn = new System.Windows.Forms.Button();
            this.btn_QuanLyBenhNhan = new System.Windows.Forms.Button();
            this.btn_QuanLyBacSi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_ChaoMungUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.btn_QuanLyTaiKhoanAdmin);
            this.panel1.Controls.Add(this.btn_QuanLyKhoa);
            this.panel1.Controls.Add(this.btn_QuanLyBenhAn);
            this.panel1.Controls.Add(this.btn_QuanLyBenhNhan);
            this.panel1.Controls.Add(this.btn_QuanLyBacSi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 472);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 335);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(269, 45);
            this.btn_DangXuat.TabIndex = 6;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QuanLyTaiKhoanAdmin
            // 
            this.btn_QuanLyTaiKhoanAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_QuanLyTaiKhoanAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyTaiKhoanAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyTaiKhoanAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyTaiKhoanAdmin.Location = new System.Drawing.Point(0, 290);
            this.btn_QuanLyTaiKhoanAdmin.Name = "btn_QuanLyTaiKhoanAdmin";
            this.btn_QuanLyTaiKhoanAdmin.Size = new System.Drawing.Size(269, 45);
            this.btn_QuanLyTaiKhoanAdmin.TabIndex = 5;
            this.btn_QuanLyTaiKhoanAdmin.Text = "Quản lý tài khoản admin";
            this.btn_QuanLyTaiKhoanAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyTaiKhoanAdmin.UseVisualStyleBackColor = false;
            this.btn_QuanLyTaiKhoanAdmin.Click += new System.EventHandler(this.btn_QuanLyTaiKhoanAdmin_Click);
            // 
            // btn_QuanLyKhoa
            // 
            this.btn_QuanLyKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_QuanLyKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyKhoa.Location = new System.Drawing.Point(0, 245);
            this.btn_QuanLyKhoa.Name = "btn_QuanLyKhoa";
            this.btn_QuanLyKhoa.Size = new System.Drawing.Size(269, 45);
            this.btn_QuanLyKhoa.TabIndex = 4;
            this.btn_QuanLyKhoa.Text = "Quản lý khoa";
            this.btn_QuanLyKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyKhoa.UseVisualStyleBackColor = false;
            this.btn_QuanLyKhoa.Click += new System.EventHandler(this.btn_QuanLyKhoa_Click);
            // 
            // btn_QuanLyBenhAn
            // 
            this.btn_QuanLyBenhAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_QuanLyBenhAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyBenhAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyBenhAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyBenhAn.Location = new System.Drawing.Point(0, 200);
            this.btn_QuanLyBenhAn.Name = "btn_QuanLyBenhAn";
            this.btn_QuanLyBenhAn.Size = new System.Drawing.Size(269, 45);
            this.btn_QuanLyBenhAn.TabIndex = 3;
            this.btn_QuanLyBenhAn.Text = "Quản lý bệnh án";
            this.btn_QuanLyBenhAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyBenhAn.UseVisualStyleBackColor = false;
            this.btn_QuanLyBenhAn.Click += new System.EventHandler(this.btn_QuanLyBenhAn_Click);
            // 
            // btn_QuanLyBenhNhan
            // 
            this.btn_QuanLyBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_QuanLyBenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyBenhNhan.Location = new System.Drawing.Point(0, 155);
            this.btn_QuanLyBenhNhan.Name = "btn_QuanLyBenhNhan";
            this.btn_QuanLyBenhNhan.Size = new System.Drawing.Size(269, 45);
            this.btn_QuanLyBenhNhan.TabIndex = 2;
            this.btn_QuanLyBenhNhan.Text = "Quản lý bệnh nhân";
            this.btn_QuanLyBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyBenhNhan.UseVisualStyleBackColor = false;
            this.btn_QuanLyBenhNhan.Click += new System.EventHandler(this.btn_QuanLyBenhNhan_Click);
            // 
            // btn_QuanLyBacSi
            // 
            this.btn_QuanLyBacSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_QuanLyBacSi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyBacSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyBacSi.Location = new System.Drawing.Point(0, 110);
            this.btn_QuanLyBacSi.Name = "btn_QuanLyBacSi";
            this.btn_QuanLyBacSi.Size = new System.Drawing.Size(269, 45);
            this.btn_QuanLyBacSi.TabIndex = 1;
            this.btn_QuanLyBacSi.Text = "Quản lý bác sĩ";
            this.btn_QuanLyBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyBacSi.UseVisualStyleBackColor = false;
            this.btn_QuanLyBacSi.Click += new System.EventHandler(this.btn_QuanLyBacSi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.lb_ChaoMungUser);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 110);
            this.panel2.TabIndex = 0;
            // 
            // lb_ChaoMungUser
            // 
            this.lb_ChaoMungUser.AutoSize = true;
            this.lb_ChaoMungUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChaoMungUser.Location = new System.Drawing.Point(99, 42);
            this.lb_ChaoMungUser.Name = "lb_ChaoMungUser";
            this.lb_ChaoMungUser.Size = new System.Drawing.Size(99, 36);
            this.lb_ChaoMungUser.TabIndex = 1;
            this.lb_ChaoMungUser.Text = "Chào mừng \r\nUsername";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::GUI.Properties.Resources.icon_admin;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(7, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 81);
            this.panel3.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(269, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(668, 472);
            this.PanelContainer.TabIndex = 1;
            // 
            // FormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 472);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "FormForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanTriVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanTriVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_ChaoMungUser;
        private System.Windows.Forms.Button btn_QuanLyTaiKhoanAdmin;
        private System.Windows.Forms.Button btn_QuanLyKhoa;
        private System.Windows.Forms.Button btn_QuanLyBenhAn;
        private System.Windows.Forms.Button btn_QuanLyBenhNhan;
        private System.Windows.Forms.Button btn_QuanLyBacSi;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel PanelContainer;
    }
}