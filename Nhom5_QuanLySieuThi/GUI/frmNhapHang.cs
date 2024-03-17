using Microsoft.Reporting.WinForms;
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
    public partial class frmNhapHang : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmNhapHang()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            var chiTietPhieuNhap = from ctpn in qlst.CTPhieuNhaps
                                   join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                                   select new
                                   {
                                       ctpn.SoPhieuNhap,
                                       ctpn.MaHang,
                                       TenHang = hh.TenHang,
                                       ctpn.SoLuongNhap,
                                       ctpn.DonGiaNhap,
                                       ctpn.ThanhTien
                                   };
            dtGVCTPhieuNhap.DataSource = chiTietPhieuNhap;

            var hangHoa = from hh in qlst.HangHoas
                          join ncc in qlst.NhaCungCaps on hh.MaNCC equals ncc.MaNCC
                          select new { hh.MaHang, hh.TenHang,ncc.TenNCC, hh.SoLuongTon };
            dTGVHangHoa1.DataSource = hangHoa;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }


        public void loadcboSoPN()
        {
            var query2 = from ctpn in qlst.PhieuNhapHangs
                         select ctpn;

            // Gán kết quả truy vấn vào ComboBox
            cboSoPhieuNhap.DataSource = query2.ToList();
            cboSoPhieuNhap.DisplayMember = "SoPhieuNhap";
            cboSoPhieuNhap.ValueMember = "SoPhieuNhap";
        }

        public void loadcboMaHH()
        {
            var query2 = from ctpn in qlst.HangHoas
                         select ctpn;

            // Gán kết quả truy vấn vào ComboBox
            cboMaHang.DataSource = query2.ToList();
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
        }
















        public static int maPhieuNhap;


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra số phiếu nhập
            if (string.IsNullOrWhiteSpace(cboSoPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soPhieuNhap;
            if (!int.TryParse(cboSoPhieuNhap.Text, out soPhieuNhap))
            {
                MessageBox.Show("Số phiếu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ngày sản xuất
            DateTime ngaySX = dateTimePickerNgaySX.Value;

            // Kiểm tra mã hàng hóa
            if (string.IsNullOrWhiteSpace(cboMaHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mã hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHangHoa = cboMaHang.Text;

            // Kiểm tra số lượng nhập
            if (string.IsNullOrWhiteSpace(txtSoLuongNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float soLuongNhap;
            if (!float.TryParse(txtSoLuongNhap.Text, out soLuongNhap))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra đơn giá
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float donGia;
            if (!float.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtSoLuongNhap.Text, out soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var phieuNhap = qlst.PhieuNhapHangs.FirstOrDefault(p => p.SoPhieuNhap == soPhieuNhap);

            // Tìm hàng hóa dựa trên mã hàng
            var hangHoa = qlst.HangHoas.FirstOrDefault(hh => hh.MaHang == maHangHoa);

            if (hangHoa != null)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Xác nhận nhập hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (result == DialogResult.Yes)
                {
                    // Kiểm tra mã hàng đã tồn tại trong chi tiết phiếu nhập hay chưa
                    var chiTietPhieuNhap = phieuNhap.CTPhieuNhaps.FirstOrDefault(ct => ct.MaHang == maHangHoa);

                    if (chiTietPhieuNhap != null)
                    {
                        // Nếu hàng hóa đã tồn tại trong chi tiết phiếu nhập, tăng số lượng và cập nhật số lượng hàng hóa trong bảng HangHoa
                        chiTietPhieuNhap.SoLuongNhap += soLuongNhap;
                        chiTietPhieuNhap.ThanhTien += soLuongNhap * chiTietPhieuNhap.DonGiaNhap;
                        
                        // Cập nhật số lượng hàng hóa trong bảng HangHoa
                        hangHoa.SoLuongTon += soLuongNhap;
                    }
                    else
                    {
                        // Tạo mới chi tiết phiếu nhập
                        chiTietPhieuNhap = new CTPhieuNhap()
                        {
                            SoPhieuNhap = soPhieuNhap,
                            MaHang = maHangHoa,
                            SoLuongNhap = soLuongNhap,
                            ThanhTien = soLuongNhap * donGia,
                            DonGiaNhap = donGia,
                        };
                        phieuNhap.CTPhieuNhaps.Add(chiTietPhieuNhap);

                        // Cập nhật số lượng hàng hóa trong bảng HangHoa
                        hangHoa.SoLuongTon += soLuongNhap;
                    }

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    // Hiển thị phiếu nhập mới trong DataGridView
                    loadData();
                   
                }
            
                }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa.");
            }
        }

        private void btnSuaPN_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSoPhieuNhap.Text) || string.IsNullOrWhiteSpace(cboMaHang.Text) ||
        string.IsNullOrWhiteSpace(txtSoLuongNhap.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maPhieu;
            if (!int.TryParse(cboSoPhieuNhap.Text, out maPhieu))
            {
                MessageBox.Show("Số phiếu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHang = cboMaHang.Text.Trim();

            float soLuongNhapMoi;
            if (!float.TryParse(txtSoLuongNhap.Text, out soLuongNhapMoi) || soLuongNhapMoi <= 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float donGiaMoi;
            if (!float.TryParse(txtDonGia.Text, out donGiaMoi) || donGiaMoi <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm chi tiết phiếu nhập cần sửa
            var chiTietPhieuNhap = qlst.CTPhieuNhaps.FirstOrDefault(ctpn => ctpn.SoPhieuNhap == maPhieu && ctpn.MaHang == maHang);

            if (chiTietPhieuNhap != null)
            {
                float soLuongNhapCu = (float)chiTietPhieuNhap.SoLuongNhap;
                // Cập nhật số lượng nhập mới và đơn giá mới
                chiTietPhieuNhap.SoLuongNhap = soLuongNhapMoi;
                chiTietPhieuNhap.DonGiaNhap = donGiaMoi;
                chiTietPhieuNhap.ThanhTien = donGiaMoi*soLuongNhapMoi;
                
                if (soLuongNhapMoi < soLuongNhapCu)
                {
                    float soLuongGiam = soLuongNhapCu - soLuongNhapMoi;
                    chiTietPhieuNhap.HangHoa.SoLuongTon -= soLuongGiam;
                }
                else if (soLuongNhapMoi > soLuongNhapCu)
                {
                    float soLuongTang = soLuongNhapMoi - soLuongNhapCu;
                    chiTietPhieuNhap.HangHoa.SoLuongTon += soLuongTang;
                }
                // Lưu các thay đổi vào cơ sở dữ liệu
                qlst.SubmitChanges();

                // Hiển thị phiếu nhập mới trong DataGridView
                loadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu nhập.");
            }
        }

        private void btnXoaPN_Click_1(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(cboSoPhieuNhap.Text.Trim());
            string maHang = cboMaHang.Text.Trim();

            // Tìm chi tiết phiếu nhập cần xóa
            var chiTietPhieuNhap = qlst.CTPhieuNhaps.FirstOrDefault(ctpn => ctpn.SoPhieuNhap == maPhieu && ctpn.MaHang == maHang);

            if (chiTietPhieuNhap != null)
            {
                // Lấy số lượng nhập của chi tiết phiếu nhập
                float soLuongNhap = (float)chiTietPhieuNhap.SoLuongNhap;

                var result = MessageBox.Show("Xác nhận xóa hàng hóa ra khỏi phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Giảm số lượng hàng hóa trong bảng HangHoa
                    chiTietPhieuNhap.HangHoa.SoLuongTon -= soLuongNhap;

                    // Xóa chi tiết phiếu nhập
                    qlst.CTPhieuNhaps.DeleteOnSubmit(chiTietPhieuNhap);
                    qlst.SubmitChanges();

                    // Hiển thị phiếu nhập mới trong DataGridView
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu nhập.");
            }
        }

        private void dtGVCTPhieuNhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVCTPhieuNhap.Rows[e.RowIndex];
                int soPhieuNhap = int.Parse(row.Cells["SoPhieuNhap"].Value.ToString());
                string maHang = row.Cells["MaHang"].Value.ToString();
                float soLuongNhap = float.Parse(row.Cells["SoLuongNhap"].Value.ToString());
                float donGia = float.Parse(row.Cells["DonGiaNhap"].Value.ToString());
          

                int selectedIndex = cboSoPhieuNhap.FindStringExact(soPhieuNhap.ToString());

                if (selectedIndex != -1)
                {

                    cboSoPhieuNhap.SelectedIndex = selectedIndex;
                }

                cboMaHang.Text = maHang;
                txtSoLuongNhap.Text = soLuongNhap.ToString();
                txtDonGia.Text = donGia.ToString();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var chiTietPhieuNhap = from ctpn in qlst.CTPhieuNhaps
                                   join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                                   select new
                                   {
                                       ctpn.SoPhieuNhap,
                                       ctpn.MaHang,
                                       TenHang = hh.TenHang,
                                       ctpn.SoLuongNhap,
                                       ctpn.ThanhTien
                                   };
            dtGVCTPhieuNhap.DataSource = chiTietPhieuNhap;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var hangHoa = from hh in qlst.HangHoas
                          join ncc in qlst.NhaCungCaps on hh.MaNCC equals ncc.MaNCC
                          select new { hh.MaHang, hh.TenHang, ncc.TenNCC, hh.SoLuongTon };
            dTGVHangHoa1.DataSource = hangHoa;
        }

        private void frmNhapHang_Load_1(object sender, EventArgs e)
        {
            var query = from ncc in qlst.NhaCungCaps
                        select ncc;

            // Gán kết quả truy vấn vào ComboBox
            cboNhaCC.DataSource = query.ToList();
            cboNhaCC.DisplayMember = "TenNCC";
            cboNhaCC.ValueMember = "MaNCC";

            loadcboSoPN();
            loadcboMaHH();
            cboSoPhieuNhap.SelectedIndex = 0;
        }

        private void btnSearchLoai_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị của loại hàng đang được chọn trong ComboBox
          

            
                string maNCC = cboNhaCC.SelectedValue.ToString();

                // Thực hiện truy vấn LINQ để lấy các hàng hóa theo tên loại hàng
                var query = from hh in qlst.HangHoas
                            join ncc in qlst.NhaCungCaps on hh.MaNCC equals ncc.MaNCC
                            where hh.MaNCC == maNCC
                            select new { hh.MaHang, hh.TenHang, ncc.TenNCC, hh.SoLuongTon };
            
            
            
            // Gán kết quả truy vấn vào DataGridView
            dTGVHangHoa1.DataSource = query.ToList();
           
        }

        private void btnSearchTen_Click_1(object sender, EventArgs e)
        {
            string maHang = cboMaHang.Text.Trim();

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from hangHoa in qlst.HangHoas
                        join ncc in qlst.NhaCungCaps on hangHoa.MaNCC equals ncc.MaNCC
                        where hangHoa.MaHang == maHang
                        select new { hangHoa.MaHang, hangHoa.TenHang, ncc.TenNCC, hangHoa.SoLuongTon };

            // Gán kết quả truy vấn vào DataGridView
            dTGVHangHoa1.DataSource = query.ToList();
        }

        private void cboSoPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearTextBoxes()
        {
            cboMaHang.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtSoLuongNhap.Text = string.Empty;

            dateTimePickerNgaySX.Text = string.Empty;

            cboNhaCC.SelectedIndex = -1;
            cboSoPhieuNhap.SelectedIndex = -1;
        }

        private int GetPhieuNhapCount()
        {
            using (QLSTDataContext qlst1 = new QLSTDataContext())
            {
                int count = qlst1.PhieuNhapHangs.Count();
                return count;
            }
        }


        private void btnThemPN_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Tạo phiếu nhập mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                // Tạo số phiếu nhập mới
                int soPhieuNhap = GetPhieuNhapCount() + 1;
                DateTime ngayTao = dateTimePickerNgaySX.Value;
                // Thêm phiếu nhập vào cơ sở dữ liệu
                PhieuNhapHang newPhieuNhap = new PhieuNhapHang
                {
                    SoPhieuNhap = soPhieuNhap,
                    NgayTaoPNH = ngayTao,
                    MaNV = DangNhap.dn.MaNV
                    // Các thông tin khác của phiếu nhập
                };

                qlst.PhieuNhapHangs.InsertOnSubmit(newPhieuNhap);

                qlst.SubmitChanges();




                // Cập nhật ComboBox
                loadcboSoPN();
                int lastIndex = cboSoPhieuNhap.Items.Count - 1;
                cboSoPhieuNhap.SelectedIndex = lastIndex;
            }
            else
            {
                return;
            }
        }


        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            int soPhieuNhap = int.Parse(cboSoPhieuNhap.Text);
            var phieuNhap = qlst.PhieuNhapHangs.FirstOrDefault(p => p.SoPhieuNhap == soPhieuNhap);

            if (phieuNhap != null)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Xác nhận lập phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    // Kiểm tra số lượng hàng hóa trong chi tiết phiếu nhập
                    if (phieuNhap.CTPhieuNhaps.Count == 0)
                    {
                        MessageBox.Show("Phiếu không có hàng hóa nào được nhập.");
                        return;
                    }

                    // Cập nhật trạng thái của phiếu nhập thành "Hoàn thành"
                    phieuNhap.TrangThai = "Hoàn thành";

                    // Lưu thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    // Thực hiện các hành động khác sau khi lập phiếu thành công
                    // ...

                    // Disable các nút sửa và xóa nếu phiếu nhập đã được lập
                    btnSuaPN.Enabled = false;
                    btnXoaPN.Enabled = false;
                    btnInPhieu.Enabled = true;
                    btnLapPhieu.Enabled = false;
                    btnNhapHang.Enabled = false;
                }
                else
                {
                    // Người dùng không đồng ý, không thực hiện gì
                    return;
                }
            }
        
                
            else
            {
                MessageBox.Show("Không tìm thấy phiếu nhập.");
            }
        }

        private void cboSoPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soPhieuNhap;
            if (!string.IsNullOrEmpty(cboSoPhieuNhap.Text))
            {
                if (Int32.TryParse(cboSoPhieuNhap.Text, out soPhieuNhap))
                {
                    var phieuNhap = qlst.PhieuNhapHangs.FirstOrDefault(p => p.SoPhieuNhap == soPhieuNhap);

                    if (phieuNhap != null && phieuNhap.TrangThai == "Hoàn thành")
                    {
                        btnSuaPN.Enabled = false;
                        btnXoaPN.Enabled = false;
                        btnInPhieu.Enabled = true;
                        btnLapPhieu.Enabled = false;
                        btnNhapHang.Enabled = false;
                    }
                    else
                    {
                        btnSuaPN.Enabled = true;
                        btnXoaPN.Enabled = true;
                        btnInPhieu.Enabled = false;
                        btnLapPhieu.Enabled = true;
                        btnNhapHang.Enabled = true;
                    }
                }
                else
                {

                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            maPhieuNhap = int.Parse(cboSoPhieuNhap.Text.Trim());

            // Tạo một phiếu nhập mới để chứa thông tin chi tiết
            PhieuNhapHang phieuNhap = qlst.PhieuNhapHangs.FirstOrDefault(pn => pn.SoPhieuNhap == maPhieuNhap);

            if (phieuNhap != null)
            {

                frmPhieuNhap phieuNhapForm = new frmPhieuNhap();
                // Hiển thị form "PhieuNhapForm"
                phieuNhapForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu nhập.");
            }
        }

        private void btnSearchMa_Click(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(cboSoPhieuNhap.Text.Trim());

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from ctpn in qlst.CTPhieuNhaps
                        join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                        where ctpn.SoPhieuNhap == maPhieu
                        select new
                        {
                            ctpn.SoPhieuNhap,
                            ctpn.MaHang,
                            TenHang = hh.TenHang,
                            ctpn.SoLuongNhap,
                            ctpn.ThanhTien
                        };

            // Gán kết quả truy vấn vào DataGridView
            dtGVCTPhieuNhap.DataSource = query.ToList();
        }

        private void dTGVHangHoa1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dTGVHangHoa1.Rows[e.RowIndex];
               
                string maHang = row.Cells["MaHang"].Value.ToString();
               


               

                cboMaHang.Text = maHang;
              
            }
        }
    }
}
