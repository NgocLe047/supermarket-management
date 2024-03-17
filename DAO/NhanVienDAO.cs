using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class NhanVienDAO
    {
        public NhanVienDAO() { }

        QLSTDataContext qlst = new QLSTDataContext();

        public string LayChucVuNV(string pma)
        {

            List<NhanVien> lsNV = new List<NhanVien>();

            string chucvu = "";


            var NV = from nv in qlst.NhanViens select nv;

            foreach (var b in NV)
            {
                lsNV.Add(b);
            }

            foreach (var c in lsNV)
            {
                if (c.MaNV == pma)
                {
                    chucvu = c.ChucVu;
                    break;
                }
            }
            return chucvu;
        }

    }
}
