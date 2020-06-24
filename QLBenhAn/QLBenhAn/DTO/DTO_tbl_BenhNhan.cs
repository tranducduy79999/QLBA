using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_tbl_BenhNhan
    {
        string cCCD;
        string matKhau;
        string hoTen;
        string gioiTinh;
        DateTime ngaySinh;
        string maBHYT;
        string diaChi;
        string sDT;

        public string CCCD { get => cCCD; set => cCCD = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MaBHYT { get => maBHYT; set => maBHYT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
