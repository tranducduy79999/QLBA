using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_tbl_BacSi
    {
        string maBacSi;
        string tenBacSi;
        string gioiTinh;
        DateTime ngaySinh;
        string diaChi;
        string email;
        string maKhoa;
        string matKhau;

        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public string TenBacSi { get => tenBacSi; set => tenBacSi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
