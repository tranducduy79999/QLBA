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
    public class BUS_tbl_Khoa
    {
        Data data = new Data();
        public DataTable SelectAll()
        {
            string sql = @"SELECT * FROM tbl_Khoa";
            return data.GetTable(sql);
        }

        public void DeleteKhoa(string makhoa)
        {
            string sql = @" DELETE FROM tbl_Khoa 
                            WHERE MaKhoa='"+makhoa+"'";
            data.ExcuteNonQuerry(sql);
        }

        public void InsertKhoa(DTO_tbl_Khoa khoa)
        {
            string sql = @" INSERT INTO tbl_Khoa
                            VALUES('"+khoa.MaKhoa+"',N'"+khoa.TenKhoa+"')";
            data.ExcuteNonQuerry(sql);
        }

        public void UpdateKhoa(DTO_tbl_Khoa khoa)
        {
            string sql = @" UPDATE tbl_Khoa SET TenKhoa=N'"+khoa.TenKhoa+
                            "' WHERE MaKhoa='"+khoa.MaKhoa+"'";
            data.ExcuteNonQuerry(sql);
        }
    }
}
