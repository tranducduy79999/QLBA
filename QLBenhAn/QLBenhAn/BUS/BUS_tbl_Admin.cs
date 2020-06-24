using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_tbl_Admin
    {
        Data data = new Data();

        public int CheckAccount(string TaiKhoan, string MatKhau)
        {
            string sql = "SELECT * FROM tbl_Admin WHERE TaiKhoan = '" + TaiKhoan + "' AND MatKhau = '" + MatKhau + "'";
            return data.GetTable(sql).Rows.Count; //Đếm row trong table trả về, Nếu là 1 thì tài khoản và mật khẩu đúng
        }

        public DataTable SelectAll()
        {
            string sql = @"SELECT * FROM tbl_Admin";
            return data.GetTable(sql);
        }

        public void InsertAdmin(DTO_tbl_Admin admin)
        {
            string sql = @" INSERT INTO tbl_Admin
                            VALUES('" + admin.TaiKhoan + "','" +admin.MatKhau+ "')";
            data.ExcuteNonQuerry(sql);
        }

        public void DeleteAdmin(DTO_tbl_Admin admin)
        {
            string sql = @" DELETE FROM tbl_Admin WHERE TaiKhoan='"+admin.TaiKhoan+"'";
            data.ExcuteNonQuerry(sql);
        }

        public void UpdateAdmin(DTO_tbl_Admin admin)
        {
            string sql = @" UPDATE tbl_Admin
                            SET MatKhau='"+admin.MatKhau+
                            "'WHERE TaiKhoan='"+admin.TaiKhoan+"'";
            data.ExcuteNonQuerry(sql);
        }
    }
}
