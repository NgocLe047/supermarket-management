using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class DangNhapDAO
    {
        public DangNhapDAO(){}

        QLSTDataContext qlst = new QLSTDataContext();

        public List<DangNhap> layDSTK()
        {
            List<DangNhap> lsDN = new List<DangNhap>();

            var DN = from dn in qlst.DangNhaps select dn;

            foreach (var d in DN)
            {
                lsDN.Add(d);
            }

            return lsDN;
        }

     
    }
}
