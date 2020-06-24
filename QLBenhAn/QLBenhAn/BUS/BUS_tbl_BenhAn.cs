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
    public class BUS_tbl_BenhAn
    {
        Data data = new Data();
        public DataTable SelectAll()
        {
            string sql = @"SELECT * FROM tbl_BenhAn";
            return data.GetTable(sql);
        }

        public void InsertBenhAn(DTO_tbl_BenhAn benhan)
        {
            string sql = @" INSERT INTO tbl_BenhAn
                            VALUES('"+benhan.MaBenhAn+"','"+benhan.CCCD+"','"+benhan.NgayVaoVien+"','"
                            +benhan.NgayRaVien+"',N'"+benhan.ChanDoanLucVaoVien+"',N'"+benhan.ChanDoanLucRaVien+"',N'"
                            +benhan.PhuongAnDieuTri+"','"+benhan.MaBacSi+"')";
            data.ExcuteNonQuerry(sql);
        }

        public void DeleteBenhAn(string mabenhan)
        {
            string sql = @" DELETE FROM tbl_BenhAn WHERE MaBenhAn='"+mabenhan+"'";
            data.ExcuteNonQuerry(sql);
        }

        public void UpdateBenhAn(DTO_tbl_BenhAn benhan)
        {
            string sql = @" UPDATE tbl_BenhAn
                            SET CCCD='"+benhan.CCCD+"',NgayVaoVien='"+benhan.NgayVaoVien+"',NgayRaVien='"
                            +benhan.NgayRaVien+"',ChanDoanLucVaoVien=N'"+benhan.ChanDoanLucVaoVien+"',ChanDoanLucRaVien=N'"
                            +benhan.ChanDoanLucRaVien+"',PhuongAnDieuTri=N'"+benhan.PhuongAnDieuTri+"',MaBacSi='"
                            +benhan.MaBacSi
                            +"'WHERE MaBenhAn='"+benhan.MaBenhAn+"'";
            data.ExcuteNonQuerry(sql);
        }
        public DataTable FindBenhAnByMaBenhAn(string mabenhan)
        {
            string sql = @" SELECT * FROM tbl_BenhAn WHERE MaBenhAn LIKE '%"+mabenhan+"%'";
            return data.GetTable(sql);
        }

        public DataTable FindBenhAnByCCCD(string cccd)
        {
            string sql = @" SELECT * FROM tbl_BenhAn WHERE CCCD LIKE '%" + cccd + "%'";
            return data.GetTable(sql);
        }

        public DataTable FindBenhAnByMaBacSi(string mabacsi)
        {
            string sql = @" SELECT * FROM tbl_BenhAn WHERE MaBacSi LIKE '%" + mabacsi + "%'";
            return data.GetTable(sql);
        }

    }
}
