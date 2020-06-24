using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanTriVien
{
    public partial class FormAdmin_QuanLyBenhAn : Form
    {
        public FormAdmin_QuanLyBenhAn()
        {
            InitializeComponent();
        }
        BUS_tbl_BenhAn bus_BenhAn = new BUS_tbl_BenhAn();
        private void ClearAll()
        {
            txt_TimKiem.Text = string.Empty;
            txt_MaBenhAn.Text = string.Empty;
            txt_CCCD.Text = string.Empty;
            dtp_NgayRaVien.Text = DateTime.Today.ToString();
            dtp_NgayRaVien.Text = DateTime.Today.ToString();
            txt_ChanDoanLucVaoVien.Text = string.Empty;
            txt_ChanDoanLucRaVien.Text = string.Empty;
            txt_PhuongAnDieuTri.Text = string.Empty;
        }
        private void FormQuanLyBenhAn_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            dgv_BenhAn.DataSource = bus_BenhAn.SelectAll();

            BUS_tbl_BacSi bus_BacSi = new BUS_tbl_BacSi();
            cb_BacSi.DisplayMember = "TenBacSi";
            cb_BacSi.ValueMember = "MaBacSi";
            cb_BacSi.DataSource = bus_BacSi.SelectAll();

            cb_TimKiemTheo.SelectedItem = "Mã bệnh án";
            ClearAll();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int row;
        private void dgv_BenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if(row >= 0)
            {
                txt_MaBenhAn.Text = dgv_BenhAn.Rows[row].Cells[0].Value.ToString();
                txt_CCCD.Text = dgv_BenhAn.Rows[row].Cells[1].Value.ToString();
                dtp_NgayVaoVien.Text = dgv_BenhAn.Rows[row].Cells[2].Value.ToString();
                dtp_NgayRaVien.Text = dgv_BenhAn.Rows[row].Cells[3].Value.ToString();
                txt_ChanDoanLucVaoVien.Text = dgv_BenhAn.Rows[row].Cells[4].Value.ToString();
                txt_ChanDoanLucRaVien.Text = dgv_BenhAn.Rows[row].Cells[5].Value.ToString();
                txt_PhuongAnDieuTri.Text = dgv_BenhAn.Rows[row].Cells[6].Value.ToString();
                cb_BacSi.SelectedValue = dgv_BenhAn.Rows[row].Cells[7].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_tbl_BenhAn benhan = new DTO_tbl_BenhAn();
            benhan.MaBenhAn = txt_MaBenhAn.Text;
            benhan.CCCD = txt_CCCD.Text;
            benhan.NgayVaoVien = dtp_NgayVaoVien.Value;
            benhan.NgayRaVien = dtp_NgayRaVien.Value;
            benhan.ChanDoanLucVaoVien = txt_ChanDoanLucVaoVien.Text;
            benhan.ChanDoanLucRaVien = txt_ChanDoanLucRaVien.Text;
            benhan.PhuongAnDieuTri = txt_PhuongAnDieuTri.Text;
            benhan.MaBacSi = cb_BacSi.SelectedValue.ToString();
            bus_BenhAn.InsertBenhAn(benhan);

            FormQuanLyBenhAn_Load(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus_BenhAn.DeleteBenhAn(dgv_BenhAn.Rows[row].Cells[0].Value.ToString());

            FormQuanLyBenhAn_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DTO_tbl_BenhAn benhan = new DTO_tbl_BenhAn();
            benhan.MaBenhAn = dgv_BenhAn.Rows[row].Cells[0].Value.ToString();
            benhan.CCCD = txt_CCCD.Text;
            benhan.NgayVaoVien = dtp_NgayVaoVien.Value;
            benhan.NgayRaVien = dtp_NgayRaVien.Value;
            benhan.ChanDoanLucVaoVien = txt_ChanDoanLucVaoVien.Text;
            benhan.ChanDoanLucRaVien = txt_ChanDoanLucRaVien.Text;
            benhan.PhuongAnDieuTri = txt_PhuongAnDieuTri.Text;
            benhan.MaBacSi = cb_BacSi.SelectedValue.ToString();
            bus_BenhAn.UpdateBenhAn(benhan);

            FormQuanLyBenhAn_Load(sender, e);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(cb_TimKiemTheo.Text == "Mã bệnh án")
            {
                dgv_BenhAn.DataSource = bus_BenhAn.FindBenhAnByMaBenhAn(txt_TimKiem.Text);
            }
            else if(cb_TimKiemTheo.Text == "CCCD")
            {
                dgv_BenhAn.DataSource = bus_BenhAn.FindBenhAnByCCCD(txt_TimKiem.Text);
            }
            else
            {
                dgv_BenhAn.DataSource = bus_BenhAn.FindBenhAnByMaBacSi(txt_TimKiem.Text);
            }
        }
    }
}
