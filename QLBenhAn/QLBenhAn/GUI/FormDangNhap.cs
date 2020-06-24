using BUS;
using GUI.QuanTriVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.BenhNhan;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0,0,0);//set màu đen trong cho form đăng nhập
            cb_BanLa.SelectedItem = "Bệnh nhân";
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(cb_BanLa.Text == "Bệnh nhân")
            {
                BUS_tbl_BenhNhan bus_BenhNhan = new BUS_tbl_BenhNhan();
                DTO_tbl_BenhNhan BenhNhan = new DTO_tbl_BenhNhan();
                BenhNhan.CCCD = txt_TaiKhoan.Text;
                BenhNhan.MatKhau = txt_MatKhau.Text;
                if(bus_BenhNhan.CheckAccount(BenhNhan) == 1)
                {
                    Hide();
                    BenhNhan.FormForBenhNhan frm = new BenhNhan.FormForBenhNhan();
                    frm.HoTen = bus_BenhNhan.FindBenhNhanByCCCD(txt_TaiKhoan.Text).Rows[0][2].ToString();
                    frm.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu hoặc tài khoản không tồn tại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(cb_BanLa.Text == "Bác sĩ")
            {
                
            }
            else
            {
                BUS_tbl_Admin bus_Admin = new BUS_tbl_Admin();
                if (bus_Admin.CheckAccount(txt_TaiKhoan.Text, txt_MatKhau.Text) == 1)
                {
                    Hide();
                    FormForAdmin frm = new FormForAdmin();
                    frm.Username = txt_TaiKhoan.Text;
                    frm.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu hoặc tài khoản không tồn tại","Lỗi đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            //Sau khi ấn nút đăng nhập thì xóa ô mật khẩu
            txt_MatKhau.Text = string.Empty;
        }
    }
}
