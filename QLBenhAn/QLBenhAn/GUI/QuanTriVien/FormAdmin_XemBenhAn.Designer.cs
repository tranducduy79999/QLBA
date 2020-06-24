namespace GUI.BenhNhan
{
    partial class FormXemBenhAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_BenhAn = new System.Windows.Forms.DataGridView();
            this.MaBenhAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayRaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanDoanLucVaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanDoanLucRaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongAnDieuTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_BacSi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PhuongAnDieuTri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_NgayRaVien = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayVaoVien = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ChanDoanLucRaVien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ChanDoanLucVaoVien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_MaBenhAn = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lb_BenhAnCuaBenhNhan = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_BenhAn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 816);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_BenhAn
            // 
            this.dgv_BenhAn.AllowUserToAddRows = false;
            this.dgv_BenhAn.AllowUserToDeleteRows = false;
            this.dgv_BenhAn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_BenhAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BenhAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BenhAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BenhAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BenhAn.Location = new System.Drawing.Point(3, 603);
            this.dgv_BenhAn.Name = "dgv_BenhAn";
            this.dgv_BenhAn.ReadOnly = true;
            this.dgv_BenhAn.Size = new System.Drawing.Size(1313, 215);
            this.dgv_BenhAn.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.lb_BenhAnCuaBenhNhan);
            this.panel1.Location = new System.Drawing.Point(54, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 594);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_BacSi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_PhuongAnDieuTri);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtp_NgayRaVien);
            this.groupBox2.Controls.Add(this.dtp_NgayVaoVien);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_ChanDoanLucRaVien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_ChanDoanLucVaoVien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_CCCD);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_MaBenhAn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 527);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cb_BacSi
            // 
            this.cb_BacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BacSi.FormattingEnabled = true;
            this.cb_BacSi.Location = new System.Drawing.Point(164, 482);
            this.cb_BacSi.Name = "cb_BacSi";
            this.cb_BacSi.Size = new System.Drawing.Size(223, 28);
            this.cb_BacSi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phương án\r\nđiều trị\r\n";
            // 
            // txt_PhuongAnDieuTri
            // 
            this.txt_PhuongAnDieuTri.Location = new System.Drawing.Point(164, 392);
            this.txt_PhuongAnDieuTri.Multiline = true;
            this.txt_PhuongAnDieuTri.Name = "txt_PhuongAnDieuTri";
            this.txt_PhuongAnDieuTri.Size = new System.Drawing.Size(774, 79);
            this.txt_PhuongAnDieuTri.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ngày ra viện";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ngày vào viện";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 40);
            this.label13.TabIndex = 7;
            this.label13.Text = "Chẩn đoán \r\nlúc ra viện";
            // 
            // txt_ChanDoanLucRaVien
            // 
            this.txt_ChanDoanLucRaVien.Location = new System.Drawing.Point(164, 281);
            this.txt_ChanDoanLucRaVien.Multiline = true;
            this.txt_ChanDoanLucRaVien.Name = "txt_ChanDoanLucRaVien";
            this.txt_ChanDoanLucRaVien.Size = new System.Drawing.Size(774, 79);
            this.txt_ChanDoanLucRaVien.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 40);
            this.label14.TabIndex = 5;
            this.label14.Text = "Chẩn đoán \r\nlúc vào viện";
            // 
            // txt_ChanDoanLucVaoVien
            // 
            this.txt_ChanDoanLucVaoVien.Location = new System.Drawing.Point(164, 168);
            this.txt_ChanDoanLucVaoVien.Multiline = true;
            this.txt_ChanDoanLucVaoVien.Name = "txt_ChanDoanLucVaoVien";
            this.txt_ChanDoanLucVaoVien.Size = new System.Drawing.Size(774, 81);
            this.txt_ChanDoanLucVaoVien.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "CCCD";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(523, 43);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(215, 26);
            this.txt_CCCD.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mã bệnh án";
            // 
            // txt_MaBenhAn
            // 
            this.txt_MaBenhAn.Location = new System.Drawing.Point(161, 43);
            this.txt_MaBenhAn.Name = "txt_MaBenhAn";
            this.txt_MaBenhAn.Size = new System.Drawing.Size(226, 26);
            this.txt_MaBenhAn.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(1035, 537);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(131, 32);
            this.btn_Thoat.TabIndex = 34;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(1035, 189);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 32);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(1035, 305);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 32);
            this.btn_Sua.TabIndex = 32;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(1035, 421);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 32);
            this.btn_Xoa.TabIndex = 31;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lb_BenhAnCuaBenhNhan
            // 
            this.lb_BenhAnCuaBenhNhan.AutoSize = true;
            this.lb_BenhAnCuaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BenhAnCuaBenhNhan.Location = new System.Drawing.Point(187, 28);
            this.lb_BenhAnCuaBenhNhan.Name = "lb_BenhAnCuaBenhNhan";
            this.lb_BenhAnCuaBenhNhan.Size = new System.Drawing.Size(342, 33);
            this.lb_BenhAnCuaBenhNhan.TabIndex = 0;
            this.lb_BenhAnCuaBenhNhan.Text = "Bệnh án của bênh nhân";
            // 
            // FormXemBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 816);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormXemBenhAn";
            this.Text = "Xem bệnh án";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormXemBenhAn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_BenhAnCuaBenhNhan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_BacSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PhuongAnDieuTri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_NgayRaVien;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ChanDoanLucRaVien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ChanDoanLucVaoVien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_MaBenhAn;
        private System.Windows.Forms.DataGridView dgv_BenhAn;
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