using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhapDTO
    {
        string taiKhoan, matKhau, maNV;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DangNhapDTO() { }

        public DangNhapDTO(string tk, string mk, string maNV)
        {
            this.TaiKhoan = tk;
            this.MatKhau = mk;
            this.MaNV = maNV;
        }

        public DangNhapDTO(DangNhapDTO a)
        {
            this.TaiKhoan = a.TaiKhoan;
            this.MatKhau = a.MatKhau;
            this.MaNV = a.MaNV;
        }
    }
}
