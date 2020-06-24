namespace GUI.QuanTriVien
{
    partial class FormAdmin_QuanLyBenhAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_BacSi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PhuongAnDieuTri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayRaVien = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayVaoVien = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ChanDoanLucRaVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ChanDoanLucVaoVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaBenhAn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TimKiemTheo = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_BenhAn = new System.Windows.Forms.DataGridView();
            this.MaBenhAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayRaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanDoanLucVaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanDoanLucRaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongAnDieuTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_BenhAn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(117, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 544);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(857, 425);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(131, 32);
            this.btn_Thoat.TabIndex = 30;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(857, 173);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 32);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(857, 257);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 32);
            this.btn_Sua.TabIndex = 28;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(857, 341);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 32);
            this.btn_Xoa.TabIndex = 27;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_BacSi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_PhuongAnDieuTri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtp_NgayRaVien);
            this.groupBox2.Controls.Add(this.dtp_NgayVaoVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ChanDoanLucRaVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ChanDoanLucVaoVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_CCCD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_MaBenhAn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cb_BacSi
            // 
            this.cb_BacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BacSi.FormattingEnabled = true;
            this.cb_BacSi.Location = new System.Drawing.Point(164, 363);
            this.cb_BacSi.Name = "cb_BacSi";
            this.cb_BacSi.Size = new System.Drawing.Size(223, 28);
            this.cb_BacSi.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Bác sĩ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 40);
            this.label9.TabIndex = 13;
            this.label9.Text = "Phương án\r\nđiều trị\r\n";
            // 
            // txt_PhuongAnDieuTri
            // 
            this.txt_PhuongAnDieuTri.Location = new System.Drawing.Point(161, 291);
            this.txt_PhuongAnDieuTri.Multiline = true;
            this.txt_PhuongAnDieuTri.Name = "txt_PhuongAnDieuTri";
            this.txt_PhuongAnDieuTri.Size = new System.Drawing.Size(577, 52);
            this.txt_PhuongAnDieuTri.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày ra viện";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày vào viện";
            // 
            // dtp_NgayRaVien
            // 
            this.dtp_NgayRaVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayRaVien.Location = new System.Drawing.Point(523, 93);
            this.dtp_NgayRaVien.Name = "dtp_NgayRaVien";
            this.dtp_NgayRaVien.Size = new System.Drawing.Size(215, 26);
            this.dtp_NgayRaVien.TabIndex = 9;
            // 
            // dtp_NgayVaoVien
            // 
            this.dtp_NgayVaoVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayVaoVien.Location = new System.Drawing.Point(161, 93);
            this.dtp_NgayVaoVien.Name = "dtp_NgayVaoVien";
            this.dtp_NgayVaoVien.Size = new System.Drawing.Size(226, 26);
            this.dtp_NgayVaoVien.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chẩn đoán \r\nlúc ra viện";
            // 
            // txt_ChanDoanLucRaVien
            // 
            this.txt_ChanDoanLucRaVien.Location = new System.Drawing.Point(161, 219);
            this.txt_ChanDoanLucRaVien.Multiline = true;
            this.txt_ChanDoanLucRaVien.Name = "txt_ChanDoanLucRaVien";
            this.txt_ChanDoanLucRaVien.Size = new System.Drawing.Size(577, 52);
            this.txt_ChanDoanLucRaVien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chẩn đoán \r\nlúc vào viện";
            // 
            // txt_ChanDoanLucVaoVien
            // 
            this.txt_ChanDoanLucVaoVien.Location = new System.Drawing.Point(161, 147);
            this.txt_ChanDoanLucVaoVien.Multiline = true;
            this.txt_ChanDoanLucVaoVien.Name = "txt_ChanDoanLucVaoVien";
            this.txt_ChanDoanLucVaoVien.Size = new System.Drawing.Size(577, 52);
            this.txt_ChanDoanLucVaoVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(523, 43);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(215, 26);
            this.txt_CCCD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã bệnh án";
            // 
            // txt_MaBenhAn
            // 
            this.txt_MaBenhAn.Location = new System.Drawing.Point(161, 43);
            this.txt_MaBenhAn.Name = "txt_MaBenhAn";
            this.txt_MaBenhAn.Size = new System.Drawing.Size(226, 26);
            this.txt_MaBenhAn.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_TimKiemTheo);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cb_TimKiemTheo
            // 
            this.cb_TimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimKiemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TimKiemTheo.FormattingEnabled = true;
            this.cb_TimKiemTheo.Items.AddRange(new object[] {
            "CCCD",
            "Mã bác sĩ",
            "Mã bệnh án"});
            this.cb_TimKiemTheo.Location = new System.Drawing.Point(510, 25);
            this.cb_TimKiemTheo.Name = "cb_TimKiemTheo";
            this.cb_TimKiemTheo.Size = new System.Drawing.Size(228, 28);
            this.cb_TimKiemTheo.Sorted = true;
            this.cb_TimKiemTheo.TabIndex = 13;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(161, 26);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(185, 26);
            this.txt_TimKiem.TabIndex = 12;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(41, 25);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 29);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bệnh án";
            // 
            // dgv_BenhAn
            // 
            this.dgv_BenhAn.AllowUserToAddRows = false;
            this.dgv_BenhAn.AllowUserToDeleteRows = false;
            this.dgv_BenhAn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_BenhAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BenhAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_BenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BenhAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenhAn,
            this.CCCD,
            this.NgayVaoVien,
            this.NgayRaVien,
            this.ChanDoanLucVaoVien,
            this.ChanDoanLucRaVien,
            this.PhuongAnDieuTri,
            this.MaBacSi});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BenhAn.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_BenhAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BenhAn.Location = new System.Drawing.Point(3, 553);
            this.dgv_BenhAn.Name = "dgv_BenhAn";
            this.dgv_BenhAn.ReadOnly = true;
            this.dgv_BenhAn.Size = new System.Drawing.Size(1251, 215);
            this.dgv_BenhAn.TabIndex = 1;
            this.dgv_BenhAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BenhAn_CellClick);
            // 
            // MaBenhAn
            // 
            this.MaBenhAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaBenhAn.DataPropertyName = "MaBenhAn";
            this.MaBenhAn.HeaderText = "Mã bệnh án";
            this.MaBenhAn.Name = "MaBenhAn";
            this.MaBenhAn.ReadOnly = true;
            this.MaBenhAn.Width = 99;
            // 
            // CCCD
            // 
            this.CCCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Width = 83;
            // 
            // NgayVaoVien
            // 
            this.NgayVaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayVaoVien.DataPropertyName = "NgayVaoVien";
            this.NgayVaoVien.HeaderText = "Ngày vào viện";
            this.NgayVaoVien.Name = "NgayVaoVien";
            this.NgayVaoVien.ReadOnly = true;
            this.NgayVaoVien.Width = 103;
            // 
            // NgayRaVien
            // 
            this.NgayRaVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayRaVien.DataPropertyName = "NgayRaVien";
            this.NgayRaVien.HeaderText = "Ngày ra viện";
            this.NgayRaVien.Name = "NgayRaVien";
            this.NgayRaVien.ReadOnly = true;
            this.NgayRaVien.Width = 92;
            // 
            // ChanDoanLucVaoVien
            // 
            this.ChanDoanLucVaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChanDoanLucVaoVien.DataPropertyName = "ChanDoanLucVaoVien";
            this.ChanDoanLucVaoVien.HeaderText = "Chẩn đoán lúc vào viện";
            this.ChanDoanLucVaoVien.Name = "ChanDoanLucVaoVien";
            this.ChanDoanLucVaoVien.ReadOnly = true;
            // 
            // ChanDoanLucRaVien
            // 
            this.ChanDoanLucRaVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChanDoanLucRaVien.DataPropertyName = "ChanDoanLucRaVien";
            this.ChanDoanLucRaVien.HeaderText = "Chẩn đoán lúc ra viện";
            this.ChanDoanLucRaVien.Name = "ChanDoanLucRaVien";
            this.ChanDoanLucRaVien.ReadOnly = true;
            // 
            // PhuongAnDieuTri
            // 
            this.PhuongAnDieuTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhuongAnDieuTri.DataPropertyName = "PhuongAnDieuTri";
            this.PhuongAnDieuTri.HeaderText = "Phương án diều trị";
            this.PhuongAnDieuTri.Name = "PhuongAnDieuTri";
            this.PhuongAnDieuTri.ReadOnly = true;
            // 
            // MaBacSi
            // 
            this.MaBacSi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaBacSi.DataPropertyName = "MaBacSi";
            this.MaBacSi.HeaderText = "Mã bác sĩ";
            this.MaBacSi.Name = "MaBacSi";
            this.MaBacSi.ReadOnly = true;
            this.MaBacSi.Width = 89;
            // 
            // FormQuanLyBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormQuanLyBenhAn";
            this.Text = "FormQuanLyBenhAn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyBenhAn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_BenhAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TimKiemTheo;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ChanDoanLucVaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaBenhAn;
        private System.Windows.Forms.ComboBox cb_BacSi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PhuongAnDieuTri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayRaVien;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ChanDoanLucRaVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayRaVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChanDoanLucVaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChanDoanLucRaVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongAnDieuTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacSi;
    }
}