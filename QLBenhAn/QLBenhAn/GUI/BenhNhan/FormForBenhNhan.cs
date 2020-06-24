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

namespace GUI.BenhNhan
{
    public partial class FormForBenhNhan : Form
    {
        public FormForBenhNhan()
        {
            InitializeComponent();
        }
        string cCCD;
        string hoTen;
        public string CCCD1 { get => cCCD; set => cCCD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        BUS_tbl_BenhAn bus_BenhAn = new BUS_tbl_BenhAn();
        BUS_tbl_BacSi bus_BacSi = new BUS_tbl_BacSi();
        private void FormForBenhNhan_Load(object sender, EventArgs e)
        {
            lb_BenhAnCuaBenhNhan.Text = "Bệnh án của bệnh nhân " + hoTen;
            dgv_BenhAn.DataSource = bus_BenhAn.FindBenhAnByCCCD(cCCD);

            cb_BacSi.DisplayMember = "TenBacSi";
            cb_BacSi.ValueMember = "MaBacSi";
            cb_BacSi.DataSource = bus_BacSi.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                grb_ThongTin.Text = "Thông tin bênh án thứ " + (row+1);
            }
        }
    }
}
