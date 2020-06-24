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
    public class BUS_tbl_BacSi
    {
        Data data = new Data();
        public DataTable SelectAll()
        {
            string sql = @"SELECT * FROM tbl_BacSi";
            return data.GetTable(sql);
        }

        public void InsertBacSi(DTO_tbl_BacSi bacsi)
        {
            string sql = @" INSERT INTO tbl_BacSi
                            VALUES('"+bacsi.MaBacSi+"',N'"+bacsi.TenBacSi+"',N'"+bacsi.GioiTinh+"','"+bacsi.NgaySinh+
                            "',N'"+bacsi.DiaChi+"','"+bacsi.Email+"','"+bacsi.MaKhoa+"','"+bacsi.MatKhau+"')";
            data.ExcuteNonQuerry(sql);
        }

        public void DeleteBacSi(string MaBacSi)
        {
            string sql = @" DELETE FROM tbl_BacSi 
                            WHERE MaBacSi='" + MaBacSi + "'";
            data.ExcuteNonQuerry(sql);
        }

        public void UpdateBacSi(DTO_tbl_BacSi bacsi)
        {
            string sql = @" UPDATE tbl_BacSi
                            SET TenBacSi=N'"+bacsi.TenBacSi+"',GioiTinh=N'"+bacsi.GioiTinh+"',NgaySinh='"
                            +bacsi.NgaySinh+"',DiaChi=N'"+bacsi.DiaChi+"',Email='"+bacsi.Email+"',MaKhoa='"
                            +bacsi.MaKhoa+"',MatKhau='"+bacsi.MatKhau+"'" +
                            "WHERE MaBacSi='"+bacsi.MaBacSi+"'";
            data.ExcuteNonQuerry(sql);
        }

        public DataTable FindBacSiByName(string name)
        {
            string sql = @"SELECT * FROM tbl_BacSi WHERE TenBacSi LIKE N'%"+name+"%'";
            return data.GetTable(sql);
        }

        public DataTable FindBacSiByMaBacSi(string mabacsi)
        {
            string sql = @"SELECT * FROM tbl_BacSi WHERE MaBacSi LIKE N'%" + mabacsi + "%'";
            return data.GetTable(sql);
        }
    }
}
