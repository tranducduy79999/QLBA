using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanTriVien
{
    public partial class FormForAdmin : Form
    {
        public FormForAdmin()
        {
            InitializeComponent();

        }
        string username;

        public string Username { get => username; set => username = value; }

        private void CloseOtherForm()//Hàm đóng tất cả các form hiện tại trên panel container rồi mới mở form mới
        {
            while (PanelContainer.Controls.Count > 0)
            {
                PanelContainer.Controls[0].Dispose();
            }
        }

        private void FormQuanTriVien_Load(object sender, EventArgs e)
        {
            lb_ChaoMungUser.Text = "Chào mừng\n" + username;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuanLyBacSi_Click(object sender, EventArgs e)
        {
            CloseOtherForm();
            FormAdmin_QuanLyBacSi frm = new FormAdmin_QuanLyBacSi() { TopLevel=false};
            this.PanelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btn_QuanLyBenhNhan_Click(object sender, EventArgs e)
        {
            CloseOtherForm();
            FormAdmin_QuanLyBenhNhan frm = new FormAdmin_QuanLyBenhNhan() { TopLevel=false};
            this.PanelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btn_QuanLyKhoa_Click(object sender, EventArgs e)
        {
            CloseOtherForm();
            FormAdmin_QuanLyKhoa frm = new FormAdmin_QuanLyKhoa() { TopLevel = false};
            this.PanelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btn_QuanLyTaiKhoanAdmin_Click(object sender, EventArgs e)
        {
            CloseOtherForm();
            FormAdmin_QuanLyTaiKhoanAdmin frm = new FormAdmin_QuanLyTaiKhoanAdmin() { TopLevel = false};
            this.PanelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btn_QuanLyBenhAn_Click(object sender, EventArgs e)
        {
            CloseOtherForm();
            FormAdmin_QuanLyBenhAn frm = new FormAdmin_QuanLyBenhAn() { TopLevel = false };
            this.PanelContainer.Controls.Add(frm);
            frm.Show();
        }
    }
}
