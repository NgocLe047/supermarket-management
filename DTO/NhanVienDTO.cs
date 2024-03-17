using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string maNV, hoTenNV, chucVu, sDTNV, diaChiNv;
        int luong;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTenNV
        {
            get { return hoTenNV; }
            set { hoTenNV = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string SDTNV
        {
            get { return sDTNV; }
            set { sDTNV = value; }
        }

        public string DiaChiNv
        {
            get { return diaChiNv; }
            set { diaChiNv = value; }
        }

        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }

        public NhanVienDTO() { }

        public NhanVienDTO(string maNV, string hoTenNV, string chucVu, string sDTNV, string diaChiNv, int luong)
        {
            this.MaNV = maNV;
            this.HoTenNV = hoTenNV;
            this.ChucVu = chucVu;
            this.SDTNV = sDTNV;
            this.DiaChiNv = diaChiNv;
            this.Luong = luong;
        }
    }
}
