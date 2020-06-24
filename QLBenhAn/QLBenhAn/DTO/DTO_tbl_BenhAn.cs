using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_tbl_BenhAn
    {
        string maBenhAn;
        string cCCD;
        DateTime ngayVaoVien;
        DateTime ngayRaVien;
        string chanDoanLucVaoVien;
        string chanDoanLucRaVien;
        string phuongAnDieuTri;
        string maBacSi;

        
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime NgayVaoVien { get => ngayVaoVien; set => ngayVaoVien = value; }
        public DateTime NgayRaVien { get => ngayRaVien; set => ngayRaVien = value; }
        public string ChanDoanLucVaoVien { get => chanDoanLucVaoVien; set => chanDoanLucVaoVien = value; }
        public string ChanDoanLucRaVien { get => chanDoanLucRaVien; set => chanDoanLucRaVien = value; }
        public string PhuongAnDieuTri { get => phuongAnDieuTri; set => phuongAnDieuTri = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public string MaBenhAn { get => maBenhAn; set => maBenhAn = value; }
    }
}
