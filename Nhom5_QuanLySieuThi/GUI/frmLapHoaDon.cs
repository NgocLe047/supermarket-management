using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

using System.Data.Linq;
using DAO;

namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmLapHoaDon : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmLapHoaDon()
        {
            InitializeComponent();
            loaddata();
            label15.Text = DangNhap.dn.MaNV;
            txt_vat.Text = "0";
            //dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        public void loadTTKH()
        {
            var query = from kh in qlst.KhachHangThanThiets
                        select kh;

            // Gán kết quả truy vấn vào ComboBox
            cbo_customername.DataSource = query.ToList();
            cbo_customername.DisplayMember = "HoTen";
            cbo_customername.ValueMember = "MaThe";

            string selectedMaThe = cbo_customername.SelectedValue.ToString(); // Lấy mã khách hàng thân thiết đã chọn

            var khachHang = qlst.KhachHangThanThiets
                .Where(kh => kh.MaThe == selectedMaThe)
                .FirstOrDefault(); // Truy vấn khách hàng thân thiết theo mã

            if (khachHang != null)
            {
                txt_contact.Text = khachHang.SDTKH;
                txt_address.Text = khachHang.DiaChiKH;
            }
        }
        public void loadSP()
        {
            var query = from hanghoa in qlst.HangHoas
                        select hanghoa;

            // Gán kết quả truy vấn vào ComboBox
            cbo_productname.DataSource = query.ToList();
            cbo_productname.DisplayMember = "TenHang";
            cbo_productname.ValueMember = "MaHang";

            string selectedMaHang = cbo_productname.SelectedValue.ToString(); // Lấy mã hàng đã chọn

            var HangHoa = qlst.HangHoas
                .Where(hh => hh.MaHang == selectedMaHang)
                .FirstOrDefault(); // Truy vấn hàng theo mã

            if (HangHoa != null)
            {
                txt_productprice.Text = HangHoa.DonGia.ToString();
            }

        }


        public void loadCTHD()
        {
            var chiTietHD = from chiTiet in qlst.CTHoaDonBanHangs
                            join hoaDon in qlst.HoaDonBanHangs on chiTiet.SoHoaDon equals hoaDon.SoHoaDon
                            join hangHoa in qlst.HangHoas on chiTiet.MaHang equals hangHoa.MaHang
                            join khachHang in qlst.KhachHangThanThiets on hoaDon.MaKHTT equals khachHang.MaThe

                            select new
                            {
                                chiTiet.SoHoaDon,
                                chiTiet.MaHang,
                                TenHang = hangHoa.TenHang,
                                chiTiet.SoLuong,
                                chiTiet.ThanhTien,
                                khachHang.HoTen,
                                hoaDon.NgayLap

                            };
            dataGridView1.DataSource = chiTietHD;
        }

        public void loaddata()
        {
            loadTTKH();
            txt_contact.Enabled = false;
            txt_address.Enabled = false;
            loadSP();
            txt_productprice.Enabled = false;
            txt_totalprice.Enabled = false;
            txt_grandtotal.Enabled = false;
            loadCTHD();


            var hangHoa = from hh in qlst.HangHoas select new { hh.MaHang, hh.TenHang, hh.DonGia };
            
            dataGridView2.DataSource = hangHoa;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string maPhieu = txt_invoiceno.Text;

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from cthd in qlst.CTHoaDonBanHangs
                        join hh in qlst.HangHoas on cthd.MaHang equals hh.MaHang
                        where cthd.SoHoaDon == maPhieu
                        select new
                        {
                            cthd.SoHoaDon,
                            cthd.MaHang,
                            TenHang = hh.TenHang,
                            cthd.SoLuong,
                            cthd.ThanhTien
                        };

            // Gán kết quả truy vấn vào DataGridView
            dataGridView1.DataSource = query.ToList();
            sum();
        }
        public void sum()
        {
            int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);
            }

            txt_grandtotal.Text = B.ToString();
        }

        

        private void txt_invoiceno_TextChanged(object sender, EventArgs e)
        {
            loadCTHD();
        }

        

        private void cbo_customername_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMaThe = cbo_customername.SelectedValue.ToString(); // Lấy mã khách hàng thân thiết đã chọn
            var khachHang = qlst.KhachHangThanThiets
                .Where(kh => kh.MaThe == selectedMaThe)
                .FirstOrDefault(); // Truy vấn khách hàng thân thiết theo mã

            if (khachHang != null)
            {
                txt_contact.Text = khachHang.SDTKH;
                txt_address.Text = khachHang.DiaChiKH;
            }
        }

        private void cbo_productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHang = cbo_productname.SelectedValue.ToString(); // Lấy mã hàng đã chọn
            txt_vat.Text = "0";
            var HangHoa = qlst.HangHoas
                .Where(hh => hh.MaHang == selectedMaHang)
                .FirstOrDefault(); // Truy vấn hàng theo mã

            if (HangHoa != null)
            {
                txt_productprice.Text = HangHoa.DonGia.ToString();
            }
        }

        private void txt_productquantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_productquantity.Text.Length > 20)
            {
                MessageBox.Show("Chuỗi không được dài hơn 20 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_productquantity.Text = txt_productquantity.Text.Substring(0, 20); // Giới hạn độ dài của chuỗi
                txt_productquantity.SelectionStart = txt_productquantity.Text.Length; // Di chuyển con trỏ đến cuối chuỗi
            }
            else
            {
                string text = txt_productquantity.Text;
                string validText = new string(text.Where(c => char.IsDigit(c) || c == '-').ToArray());
                txt_productquantity.Text = validText; // Loại bỏ các ký tự không phải số
            }
            try
            {

                if (txt_productquantity.Text == "")
                {
                    txt_totalprice.Clear();
                }
                else if (cbo_productname.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên hàng hóa ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cbo_productname.Focus();

                }
                else
                {
                    double tprice;
                    double giamgia = double.Parse(txt_vat.Text) / 100;

                    tprice = (double.Parse(txt_productprice.Text) * double.Parse(txt_productquantity.Text)) - (double.Parse(txt_productprice.Text) * double.Parse(txt_productquantity.Text) * giamgia);

                    txt_totalprice.Text = tprice.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_addtocard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_invoiceno.Text))
            {
                MessageBox.Show("Chưa có mã hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbo_productname.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_productname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_productquantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_productquantity.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_vat.Text))
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vat.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_productprice.Text))
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vat.Focus();
                return;
            }
            // Lấy giá trị từ các TextBox
            string maHangHoa = cbo_productname.SelectedValue.ToString();
            double soLuong = float.Parse(txt_productquantity.Text);
            double thanhTien = float.Parse(txt_totalprice.Text);
            string soHoaDon = txt_invoiceno.Text;
            float donGia = float.Parse(txt_productprice.Text);
            double vat = float.Parse(txt_vat.Text);

            var hoaDon = qlst.HoaDonBanHangs.FirstOrDefault(p => p.SoHoaDon == soHoaDon);
            var hangHoa = qlst.HangHoas.FirstOrDefault(hh => hh.MaHang == maHangHoa);

            if (hangHoa != null)
            {
                // Kiểm tra mã hàng đã tồn tại trong chi tiết hd hay chưa
                var chiTietHoaDon = hoaDon.CTHoaDonBanHangs.FirstOrDefault(ct => ct.MaHang == maHangHoa);

               
                    if (chiTietHoaDon != null)
                    {

                        if (chiTietHoaDon.SoLuong + soLuong <= 0)
                        {
                            MessageBox.Show(this, "Số lượng mua không hợp lệ");
                        }
                        else
                        {
                            // Nếu hàng hóa đã tồn tại trong chi tiết hd  cập nhật số lượng hàng hóa trong bảng HangHoa
                            chiTietHoaDon.ThanhTien += thanhTien;

                            // Cập nhật số lượng hàng hóa trong bảng HangHoa
                            chiTietHoaDon.SoLuong += soLuong;
                            
                        }


                    }
                    else
                    {
                        // Tạo mới chi tiết phiếu nhập
                        chiTietHoaDon = new CTHoaDonBanHang()
                        {
                            SoHoaDon = soHoaDon,
                            MaHang = maHangHoa,
                            SoLuong = soLuong,
                            ThanhTien = thanhTien
                        };
                        hoaDon.CTHoaDonBanHangs.Add(chiTietHoaDon);
                        //hangHoa.SoLuongTon -= soLuong;

                    }
                    sum();
                    cbo_productname.Text = "";
                    txt_productprice.Clear();
                    txt_productquantity.Clear();
                    txt_totalprice.Clear();

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();
                }
            
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa.");
            }

            string maPhieu = txt_invoiceno.Text;

            var query = from chiTiet in qlst.CTHoaDonBanHangs
                        join hoaDo in qlst.HoaDonBanHangs on chiTiet.SoHoaDon equals hoaDo.SoHoaDon
                        join hangHo in qlst.HangHoas on chiTiet.MaHang equals hangHo.MaHang
                        join khachHang in qlst.KhachHangThanThiets on hoaDo.MaKHTT equals khachHang.MaThe
                        where chiTiet.SoHoaDon == maPhieu
                        select new
                        {
                            chiTiet.SoHoaDon,
                            chiTiet.MaHang,
                            TenHang = hangHo.TenHang,
                            chiTiet.SoLuong,
                            chiTiet.ThanhTien,
                            khachHang.HoTen,
                            hoaDo.NgayLap

                        };

            // Gán kết quả truy vấn vào DataGridView
            dataGridView1.DataSource = query.ToList();
            sum();
        }

        private void txt_invoiceno_TextChanged_1(object sender, EventArgs e)
        {
            loadCTHD();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_invoiceno.Text))
            {
                MessageBox.Show("Chưa có mã hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbo_productname.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_productname.Focus();
                return;
            }

            string maPhieu = txt_invoiceno.Text;
            string maHang = cbo_productname.SelectedValue.ToString();

            // Tìm chi tiết phiếu nhập cần xóa
            var chiTietHD = qlst.CTHoaDonBanHangs.FirstOrDefault(cthd => cthd.SoHoaDon == maPhieu && cthd.MaHang == maHang);

            if (chiTietHD != null)
            {
                //chiTietHD.HangHoa.SoLuongTon += chiTietHD.SoLuong;
                // Xóa chi tiết phiếu nhập
                qlst.CTHoaDonBanHangs.DeleteOnSubmit(chiTietHD);
                qlst.SubmitChanges();
                MessageBox.Show("Đã xóa hàng hóa");

            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ các ô cột trong dòng
                string soHoaDon = row.Cells["SoHoaDon"].Value.ToString();
                DateTime ngayLap = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                string tenKhachHang = row.Cells["HoTen"].Value.ToString();
                string tenSanPham = row.Cells["TenHang"].Value.ToString();
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                // Gán giá trị cho các TextBox tương ứng
                txt_invoiceno.Text = soHoaDon;
                dtp_invoicedate.Text = ngayLap.ToString();
                cbo_customername.Text = tenKhachHang;
                cbo_productname.Text = tenSanPham;
                txt_productquantity.Text = soLuong;
                txt_totalprice.Text = thanhTien;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = true;
            cbo_customername.Enabled = true;
            cbo_productname.Enabled = true;


            string soHoaDon = txt_invoiceno.Text;
            DateTime ngayLap = dtp_invoicedate.Value;
            string maNV = label15.Text;
            string makhtt = "KHVL";
          
            // Kiểm tra xem mã hóa đơn đã tồn tại chưa
            var existingHoaDon = qlst.HoaDonBanHangs.FirstOrDefault(h => h.SoHoaDon == soHoaDon);
            if (txt_invoiceno.Text != string.Empty)
            {
                if (existingHoaDon != null)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng kiểm tra lại.");
                }
                else
                {
                    // Tạo hóa đơn mới và thêm vào cơ sở dữ liệu
                    var newHoaDon = new HoaDonBanHang
                    {
                        SoHoaDon = soHoaDon,
                        NgayLap = ngayLap,
                        MaNV = maNV,
                        MaKHTT = makhtt,
                     
                    };

                    qlst.HoaDonBanHangs.InsertOnSubmit(newHoaDon);
                    qlst.SubmitChanges();

                    MessageBox.Show("Hóa đơn đã được thêm thành công.");
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không dược để trống!");
                txt_invoiceno.Focus();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string soHoaDon = txt_invoiceno.Text;

            // Kiểm tra xem hóa đơn tồn tại
            var existingHoaDon = qlst.HoaDonBanHangs.FirstOrDefault(h => h.SoHoaDon == soHoaDon);

            if (existingHoaDon == null)
            {
                MessageBox.Show(this, "Số hóa đơn không tồn tại.");
            }

            else
            {
                if (string.IsNullOrWhiteSpace(txt_vat.Text))
                {
                    MessageBox.Show("Vui lòng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_vat.Focus();
                    return;
                }


                // Cập nhật thông tin hóa đơn
                existingHoaDon.MaKHTT = cbo_customername.SelectedValue.ToString();
                existingHoaDon.VAT = double.Parse(txt_vat.Text);
                existingHoaDon.TongTien = double.Parse(txt_grandtotal.Text);
                existingHoaDon.NgayLap = dtp_invoicedate.Value;
                existingHoaDon.MaNV = label15.Text;

                qlst.SubmitChanges();

                double tongTienHoaDon = double.Parse(txt_grandtotal.Text);

                string maKHTT = cbo_customername.SelectedValue.ToString();

                // Xác định điểm thưởng dựa trên tổng tiền
                int diemThuong = 0;
                if (tongTienHoaDon >= 100000 && tongTienHoaDon < 1000000)
                {
                    diemThuong = (int)(tongTienHoaDon / 100000);
                }
                else if (tongTienHoaDon >= 1000000)
                {
                    diemThuong = 10;
                }
                var khachHang = qlst.KhachHangThanThiets.FirstOrDefault(kh => kh.MaThe == maKHTT);

                if (khachHang != null)
                {
                    // Cập nhật điểm thưởng cho khách hàng
                    khachHang.Diem += diemThuong;

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();
                }
                MessageBox.Show("Hóa đơn đã được cập nhật thành công.");
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            txt_invoiceno.Text = "HD" + GetUniqueKey(5);
            txt_address.Clear();
            txt_contact.Clear();
            cbo_customername.Text = "";
            cbo_productname.Text = "";
            txt_vat.Text = "0";
        }

        private void btnSearchMa_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = true;
            dataGridView1.Enabled = true;
            cbo_productname.Enabled = true;

            string maPhieu = txt_invoiceno.Text;
            cbo_customername.Text = "";
            txt_address.Clear();
            txt_contact.Clear();
            cbo_productname.Text = "";
            txt_productprice.Clear();
            cbo_customername.Enabled = true;

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from chiTiet in qlst.CTHoaDonBanHangs
                        join hoaDon in qlst.HoaDonBanHangs on chiTiet.SoHoaDon equals hoaDon.SoHoaDon
                        join hangHoa in qlst.HangHoas on chiTiet.MaHang equals hangHoa.MaHang
                        join khachHang in qlst.KhachHangThanThiets on hoaDon.MaKHTT equals khachHang.MaThe
                        where chiTiet.SoHoaDon == maPhieu
                        select new
                        {
                            chiTiet.SoHoaDon,
                            chiTiet.MaHang,
                            TenHang = hangHoa.TenHang,
                            chiTiet.SoLuong,
                            chiTiet.ThanhTien,
                            khachHang.HoTen,
                            hoaDon.NgayLap

                        };

            // Gán kết quả truy vấn vào DataGridView
            dataGridView1.DataSource = query.ToList();
            sum();

            //Hiển thị VAT theo mã hóa đơn
            float? vat = qlst.HoaDonBanHangs
     .Where(chiTiet => chiTiet.SoHoaDon == maPhieu)
     .Select(chiTiet => (float?)chiTiet.VAT)
     .SingleOrDefault();
            txt_vat.Text = vat.ToString();
        }

        private void txt_vat_TextChanged(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text == "")
            {
                txt_grandtotal.Clear();
            }
            else if (txt_productquantity.Text != string.Empty && txt_vat.Text != string.Empty)
            {
                txt_grandtotal.Clear();
                double tprice;
                double giamgia = double.Parse(txt_vat.Text) / 100;

                tprice = (double.Parse(txt_productprice.Text) * double.Parse(txt_productquantity.Text)) - (double.Parse(txt_productprice.Text) * double.Parse(txt_productquantity.Text) * giamgia);

                txt_totalprice.Text = tprice.ToString();

            }
            else if (txt_grandtotal.Text != string.Empty && txt_vat.Text != string.Empty)
            {
                double tongtien = double.Parse(txt_grandtotal.Text) + (double.Parse(txt_grandtotal.Text) * double.Parse(txt_vat.Text) / 100);
                txt_grandtotal.Text = tongtien.ToString();
            }

        }

        private void txt_vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_invoiceno.Clear();
            txt_productprice.Clear();
            txt_productquantity.Clear();
            txt_totalprice.Clear();
            cbo_customername.Enabled = true;
            txt_grandtotal.Clear();
        }

        private void btn_remove__Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_invoiceno.Text))
            {
                MessageBox.Show("Chưa có mã hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHoaDon = txt_invoiceno.Text;

            // Tìm hóa đơn bán hàng cần xóa
            var hoadon = qlst.HoaDonBanHangs.FirstOrDefault(h => h.SoHoaDon == maHoaDon);

            if (hoadon == null)
            {
                MessageBox.Show("Hóa đơn không tồn tại.");
            }
            else
            {
                // Tìm và xóa chi tiết hóa đơn liên quan
                var chiTietHoaDon = qlst.CTHoaDonBanHangs.Where(ct => ct.SoHoaDon == maHoaDon);

                // Xóa chi tiết hóa đơn
                qlst.CTHoaDonBanHangs.DeleteAllOnSubmit(chiTietHoaDon);

                // Xóa hóa đơn
                qlst.HoaDonBanHangs.DeleteOnSubmit(hoadon);

                qlst.SubmitChanges();
                MessageBox.Show("Hóa đơn đã được xóa thành công.");
                txt_invoiceno.Clear();

            }
        }
        public static string soHoaDon;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            soHoaDon = txt_invoiceno.Text.Trim();

            // Tạo một phiếu nhập mới để chứa thông tin chi tiết
            HoaDonBanHang hd = qlst.HoaDonBanHangs.FirstOrDefault(pn => pn.SoHoaDon == soHoaDon);

            if (hd != null)
            {

                frmHoaDon hdForm = new frmHoaDon();
                // Hiển thị form "PhieuNhapForm"
                hdForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn.");
            }
        }

      

        private void label15_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ các ô cột trong dòng
                string soHoaDon = row.Cells["SoHoaDon"].Value.ToString();
                DateTime ngayLap = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                string tenKhachHang = row.Cells["HoTen"].Value.ToString();
                string tenSanPham = row.Cells["TenHang"].Value.ToString();
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                // Gán giá trị cho các TextBox tương ứng
                txt_invoiceno.Text = soHoaDon;
                dtp_invoicedate.Text = ngayLap.ToString();
                cbo_customername.Text = tenKhachHang;
                cbo_productname.Text = tenSanPham;
                txt_productquantity.Text = soLuong;
                txt_totalprice.Text = thanhTien;
                cbo_customername.Enabled = false;

            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void cbo_productname_TextChanged(object sender, EventArgs e)
        {
            txt_productquantity.Clear();
            txt_vat.Clear();
            txt_totalprice.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Lấy giá trị từ các ô cột trong dòng
                string tenhang = row.Cells["TenHang"].Value.ToString();
                string dongia = row.Cells["DonGia"].Value.ToString();
                

                // Gán giá trị cho các TextBox tương ứng
                cbo_productname.Text = tenhang;
                txt_productprice.Text = dongia;

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbo_customername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_productname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
