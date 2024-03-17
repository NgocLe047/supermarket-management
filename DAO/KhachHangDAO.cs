using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        QLSTDataContext qlst = new QLSTDataContext();

        public List<KhachHangThanThiet> layDSKH()
        {
            List<KhachHangThanThiet> lsKH = new List<KhachHangThanThiet>();
            var KH = from kh in qlst.KhachHangThanThiets select kh;

            foreach (var a in KH)
            {
                lsKH.Add(a);
            }

            return lsKH;
        }

        public List<KhachHangThanThiet> layDSKHTheoMa(string pma)
        {
            List<KhachHangThanThiet> lsKH = new List<KhachHangThanThiet>();
            var KH = from kh in qlst.KhachHangThanThiets where kh.MaThe == pma select kh;
            foreach (var a in KH)
            {
                lsKH.Add(a);
            }
            return lsKH;
        }

        public List<KhachHangThanThiet> layDSKHTheoTen(string pten)
        {
            List<KhachHangThanThiet> lsKH = new List<KhachHangThanThiet>();

            var KH = from kh in qlst.KhachHangThanThiets where kh.HoTen.Contains(pten) select kh;

            foreach (var a in KH)
            {
                lsKH.Add(a);
            }

            return lsKH;
        }

        public bool XoaKHTHeoMa(string pma)
        {
            var kh = qlst.KhachHangThanThiets.Where(k => k.MaThe == pma).FirstOrDefault();

            if (kh != null)
            {
                qlst.KhachHangThanThiets.DeleteOnSubmit(kh);
                qlst.SubmitChanges();
                return true;
            }

            return false;
        }

        public void ThemKH(KhachHangThanThiet kh)
        {
            qlst.KhachHangThanThiets.InsertOnSubmit(kh);
            qlst.SubmitChanges();
        }

        public bool CapNhatKH(KhachHangThanThiet khachhang)
        {
            var kh = qlst.KhachHangThanThiets.Where(k => k.MaThe == khachhang.MaThe).FirstOrDefault();

            if (kh != null)
            {
                kh.HoTen = khachhang.HoTen;
                kh.NgaySinhKH = khachhang.NgaySinhKH;
                kh.Diem = khachhang.Diem;
                kh.DiaChiKH = khachhang.DiaChiKH;
                kh.SDTKH = khachhang.SDTKH;
                qlst.SubmitChanges();
                return true;
            }

            return false;
        }

    }
}
