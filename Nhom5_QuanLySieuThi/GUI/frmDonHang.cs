using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmDonHang : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmDonHang()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);


            var query = from hoadon in qlst.HoaDonBanHangs
                        join nv in qlst.NhanViens on hoadon.MaNV equals nv.MaNV
                        join kh in qlst.KhachHangThanThiets on hoadon.MaKHTT equals kh.MaThe
                        select new
                        {
                            SoHoaDon = hoadon.SoHoaDon,
                            NgayLap = hoadon.NgayLap,
                            VAT = hoadon.VAT,
                            TongTien = hoadon.TongTien,
                            TenKhachHang = kh.HoTen,
                            TenNhanVien = nv.HoTenNV

                        };
            dataGridView1.DataSource = query;
      


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string maHoaDon = txt_invoiceno.Text;


            var query = from hoadon in qlst.HoaDonBanHangs
                        where hoadon.SoHoaDon == maHoaDon
                        join nv in qlst.NhanViens on hoadon.MaNV equals nv.MaNV
                        join kh in qlst.KhachHangThanThiets on hoadon.MaKHTT equals kh.MaThe
                        select new
                        {
                            SoHoaDon = hoadon.SoHoaDon,
                            NgayLap = hoadon.NgayLap,
                            VAT = hoadon.VAT,
                            TongTien = hoadon.TongTien,
                            TenKhachHang = kh.HoTen,
                            TenNhanVien = nv.HoTenNV

                        };

            dataGridView1.DataSource = query;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_customername.Text;


            var query = from hoadon in qlst.HoaDonBanHangs
                        join kh in qlst.KhachHangThanThiets on hoadon.MaKHTT equals kh.MaThe
                        join nv in qlst.NhanViens on hoadon.MaNV equals nv.MaNV
                        where kh.HoTen.Contains(tenKhachHang)
                        select new
                        {
                            SoHoaDon = hoadon.SoHoaDon,
                            NgayLap = hoadon.NgayLap,
                            VAT = hoadon.VAT,
                            TongTien = hoadon.TongTien,
                            TenKhachHang = kh.HoTen,
                            TenNhanVien = nv.HoTenNV

                        };

            dataGridView1.DataSource = query;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_invoiceno.Clear();
            txt_customername.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
