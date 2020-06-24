using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_tbl_BenhNhan
    {
        Data data = new Data();
        public DataTable FindBenhNhanByName(string name)
        {
            string sql = @" SELECT * 
                            FROM tbl_BenhNhan
                            WHERE HoTen LIKE N'%"+name+"%'";
            return data.GetTable(sql);
        }

        public DataTable FindBenhNhanByCCCD(string cccd)
        {
            string sql = @" SELECT *
                            FROM tbl_BenhNhan
                            WHERE CCCD Like '%"+cccd+"%'";
            return data.GetTable(sql);
        }

        public DataTable SelectAllFromBenhNhan()
        {
            string sql = @"SELECT * FROM tbl_BenhNhan";
            return data.GetTable(sql);
        }

        public void InsertBenhNhan(DTO_tbl_BenhNhan bn)
        {
            string sql = @" INSERT INTO tbl_BenhNhan
                            VALUES('" + bn.CCCD + "','" + bn.MatKhau + "',N'" + bn.HoTen + "',N'"+bn.GioiTinh+"','"
                            +bn.NgaySinh+"','"+bn.MaBHYT+"',N'"+bn.DiaChi+"','"+bn.SDT+"')";
            data.ExcuteNonQuerry(sql);
        }

        public void DeleteBenhNhan(string cccd)
        {
            string sql = @"DELETE FROM tbl_BenhNhan WHERE CCCD = '"+cccd+"'" ;
            data.ExcuteNonQuerry(sql);
        }

        public void UpdateBenhNhan(DTO_tbl_BenhNhan BenhNhan)
        {
            string sql = @" UPDATE tbl_BenhNhan SET 
                            MatKhau='"+BenhNhan.MatKhau+"',HoTen=N'"+BenhNhan.HoTen+"',GioiTinh=N'"+BenhNhan.GioiTinh+"',NgaySinh='"
                            +BenhNhan.NgaySinh+"',MaBHYT='"+BenhNhan.MaBHYT+"',DiaChi=N'"+BenhNhan.DiaChi+"',SDT='"+BenhNhan.SDT
                            +"'WHERE CCCD='"+BenhNhan.CCCD+"'";
            data.ExcuteNonQuerry(sql);
        }

        public int CheckAccount(DTO_tbl_BenhNhan BenhNhan)
        {
            string sql = @" SELECT * FROM tbl_BenhNhan
                            WHERE CCCD='"+BenhNhan.CCCD+"'AND MatKhau='"+BenhNhan.MatKhau+"'";
            return data.GetTable(sql).Rows.Count;
        }
    }
}
