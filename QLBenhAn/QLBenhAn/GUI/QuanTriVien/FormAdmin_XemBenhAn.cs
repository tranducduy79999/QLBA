using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;


namespace GUI.BenhNhan
{
    public partial class FormXemBenhAn : Form
    {
        public FormXemBenhAn()
        {
            InitializeComponent();
        }
        string tenBenhNhan;
        string cCCD;
        
        public string TenBenhNhan { get => tenBenhNhan; set => tenBenhNhan = value; }
        public string CCCD1 { get => cCCD; set => cCCD = value; }
        BUS_tbl_BenhAn bus_BenhAn = new BUS_tbl_BenhAn();
        BUS_tbl_BacSi bus_BacSi = new BUS_tbl_BacSi();
        private void ClearAll()
        {
            txt_MaBenhAn.Text = string.Empty;
            //txt_CCCD.Text = string.Empty;
            dtp_NgayRaVien.Text = DateTime.Today.ToString();
            dtp_NgayRaVien.Text = DateTime.Today.ToString();
            txt_ChanDoanLucVaoVien.Text = string.Empty;
            txt_ChanDoanLucRaVien.Text = string.Empty;
            txt_PhuongAnDieuTri.Text = string.Empty;
        }

        private void FormXemBenhAn_Load(object sender, EventArgs e)
        {
            lb_BenhAnCuaBenhNhan.Text = "Bệnh án của bênh nhân " + tenBenhNhan;
            txt_CCCD.Text = cCCD;
            txt_CCCD.Enabled = false;
            dgv_BenhAn.DataSource = bus_BenhAn.FindBenhAnByCCCD(cCCD);

            cb_BacSi.DisplayMember = "TenBacSi";
            cb_BacSi.ValueMember = "MaBacSi";
            cb_BacSi.DataSource = bus_BacSi.SelectAll();

            ClearAll();

        }

        int row;
        private void dgv_BenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if (row >= 0)
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

            FormXemBenhAn_Load(sender, e);
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

            FormXemBenhAn_Load(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus_BenhAn.DeleteBenhAn(dgv_BenhAn.Rows[row].Cells[0].Value.ToString());

            FormXemBenhAn_Load(sender, e);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
