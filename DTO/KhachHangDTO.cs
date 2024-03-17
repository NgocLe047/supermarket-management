using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        string maThe, hoTen, sDTKH, diaChiKH;
        DateTime ngaySinhKH;
        int diem;

        public string MaThe { get => maThe; set => maThe = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinhKH { get => ngaySinhKH; set => ngaySinhKH = value; }
        public string SDTKH { get => sDTKH; set => sDTKH = value; }
        public string DiaChiKH { get => diaChiKH; set => diaChiKH = value; }
        public int Diem { get => diem; set => diem = value; }

        public KhachHangDTO(string maThe, string hoTen, DateTime ngaySinhKH, string sDTKH, string diaChiKH, int diem)
        {
            this.MaThe = maThe;
            this.HoTen = hoTen;
            this.NgaySinhKH = ngaySinhKH;
            this.SDTKH = sDTKH;
            this.DiaChiKH = diaChiKH;
            this.Diem = diem;
        }

        public KhachHangDTO() { }
    }
}
