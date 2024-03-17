using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeBLL
    {
        QLSTDataContext db = new QLSTDataContext(); 
        public ThongKeBLL() { } 
        public DataTable ThongKeDoanhThuNam(HoaDonBanHang hoadon)
        {
            var query = from hd in db.HoaDonBanHangs
                        where hd.NgayLap.Value.Year == hoadon.NgayLap.Value.Year
                        group hd by hd.NgayLap.Value.Month into g
                        select new
                        {
                            Thang = g.Key,
                            ThanhTien = g.Sum(x => x.TongTien)
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(int));
            dataTable.Columns.Add("Thành tiền", typeof(decimal));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.Thang, item.ThanhTien);
            }

            return dataTable;
        }
    }
}
