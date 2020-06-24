using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.QuanTriVien
{
    public partial class FormAdmin_QuanLyKhoa : Form
    {
        public FormAdmin_QuanLyKhoa()
        {
            InitializeComponent();
        }
        BUS_tbl_Khoa bus = new BUS_tbl_Khoa();

        private void ClearAll()
        {
            txt_MaKhoa.Text = string.Empty;
            txt_TenKhoa.Text = string.Empty;
        }
        private void FormQuanLyKhoa_Load(object sender, EventArgs e)
        {
            dgv_Khoa.DataSource = bus.SelectAll();
            FormBorderStyle = FormBorderStyle.None;
            ClearAll();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int row;
        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if(row >= 0)
            {
                txt_MaKhoa.Text = dgv_Khoa.Rows[row].Cells[0].Value.ToString();
                txt_TenKhoa.Text = dgv_Khoa.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus.DeleteKhoa(dgv_Khoa.Rows[row].Cells[0].Value.ToString());

            FormQuanLyKhoa_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_tbl_Khoa khoa = new DTO_tbl_Khoa();
            khoa.MaKhoa = txt_MaKhoa.Text;
            khoa.TenKhoa = txt_TenKhoa.Text;
            bus.InsertKhoa(khoa);

            FormQuanLyKhoa_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DTO_tbl_Khoa khoa = new DTO_tbl_Khoa();
            khoa.MaKhoa = txt_MaKhoa.Text;/*dgv_Khoa.Rows[row].Cells[0].Value.ToString();*/
            khoa.TenKhoa = txt_TenKhoa.Text;
            bus.UpdateKhoa(khoa);

            FormQuanLyKhoa_Load(sender, e);
        }


    }
}
