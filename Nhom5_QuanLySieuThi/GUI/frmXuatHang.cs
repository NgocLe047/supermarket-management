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
    public partial class frmXuatHang : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public static int maPhieuXuat;
        public frmXuatHang()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            var chiTietPhieuXuat = from ctpn in qlst.CTPhieuXuatHangs
                                   join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                                   select new
                                   {
                                       ctpn.SoPhieuXuat,
                                       ctpn.MaHang,
                                       TenHang = hh.TenHang,
                                       ctpn.SoLuongXuat,
                                     
                                   };
            dtGVCTPhieuNhap.DataSource = chiTietPhieuXuat;

            var hangHoa = from hh in qlst.HangHoas select new { hh.MaHang, hh.TenHang, hh.SoLuongTon };
            dTGVHangHoa1.DataSource = hangHoa;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }

        private void cboSoPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void loadcboSoPX()
        {
            var query2 = from ctpn in qlst.PhieuXuatHangs
                         select ctpn;

            // Gán kết quả truy vấn vào ComboBox
            cboSoPhieuXuat.DataSource = query2.ToList();
            cboSoPhieuXuat.DisplayMember = "SoPhieuXuat";
            cboSoPhieuXuat.ValueMember = "SoPhieuXuat";
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

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            loadcboSoPX();
            loadcboMaHH();
            var query = from loaiHang in qlst.LoaiHangHoas
                        select loaiHang;

            // Gán kết quả truy vấn vào ComboBox
            cboLoaiHang.DataSource = query.ToList();
            cboLoaiHang.DisplayMember = "TenLoai";
            cboLoaiHang.ValueMember = "MaLoai";

          
            cboSoPhieuXuat.SelectedIndex = 0;
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            int maPhieuXuat = int.Parse(cboSoPhieuXuat.Text.Trim());
            string maHangHoa = cboMaHang.Text.Trim();

            // Tìm chi tiết phiếu xuất cần xóa
            var chiTietPhieuXuat = qlst.CTPhieuXuatHangs.FirstOrDefault(ctpx => ctpx.SoPhieuXuat == maPhieuXuat && ctpx.MaHang == maHangHoa);

            if (chiTietPhieuXuat != null)
            {
                // Lấy số lượng xuất của chi tiết phiếu xuất
                float soLuongXuat = (float)chiTietPhieuXuat.SoLuongXuat;

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận xóa hàng hóa ra khỏi phiếu xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tăng số lượng hàng hóa trong bảng HangHoas
                    chiTietPhieuXuat.HangHoa.SoLuongTon += soLuongXuat;

                    // Xóa chi tiết phiếu xuất
                    qlst.CTPhieuXuatHangs.DeleteOnSubmit(chiTietPhieuXuat);
                    qlst.SubmitChanges();

                    // Hiển thị phiếu xuất mới trong DataGridView
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu xuất.");
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra số phiếu xuất
            if (string.IsNullOrWhiteSpace(cboSoPhieuXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soPhieuXuat;
            if (!int.TryParse(cboSoPhieuXuat.Text, out soPhieuXuat))
            {
                MessageBox.Show("Số phiếu xuất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ngày tạo phiếu xuất
            DateTime ngayTaoPXH = dateTimePickerNgayTaoPXH.Value;

            // Kiểm tra mã hàng hóa
            if (string.IsNullOrWhiteSpace(cboMaHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mã hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHangHoa = cboMaHang.Text;

            // Kiểm tra số lượng xuất
            if (string.IsNullOrWhiteSpace(txtSoLuongXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float soLuongXuat;
            if (!float.TryParse(txtSoLuongXuat.Text, out soLuongXuat))
            {
                MessageBox.Show("Số lượng xuất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (!float.TryParse(txtSoLuongXuat.Text, out soLuongXuat) || soLuongXuat <= 0)
            {
                MessageBox.Show("Số lượng xuất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var phieuXuat = qlst.PhieuXuatHangs.FirstOrDefault(pxh => pxh.SoPhieuXuat == soPhieuXuat);

            // Tìm hàng hóa dựa trên mã hàng
            var hangHoa = qlst.HangHoas.FirstOrDefault(hh => hh.MaHang == maHangHoa);
            // Kiểm tra số lượng tồn của hàng hóa
            if (hangHoa.SoLuongTon <= 0)
            {
                MessageBox.Show("Hàng hóa không còn tồn kho. Không thể xuất hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số lượng xuất hàng
            if (soLuongXuat > hangHoa.SoLuongTon)
            {
                MessageBox.Show("Số lượng xuất hàng vượt quá số lượng tồn kho. Không thể xuất hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (hangHoa != null)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Xác nhận xuất hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (result == DialogResult.Yes)
                {
                    // Kiểm tra mã hàng đã tồn tại trong chi tiết phiếu xuất hay chưa
                    var chiTietPhieuXuat = phieuXuat.CTPhieuXuatHangs.FirstOrDefault(ct => ct.MaHang == maHangHoa);

                    if (chiTietPhieuXuat != null)
                    {
                        // Nếu hàng hóa đã tồn tại trong chi tiết phiếu xuất, tăng số lượng và cập nhật số lượng hàng hóa trong bảng HangHoa
                        chiTietPhieuXuat.SoLuongXuat += soLuongXuat;

                        // Cập nhật số lượng hàng hóa trong bảng HangHoa
                        hangHoa.SoLuongTon -= soLuongXuat;
                    }
                    else
                    {
                        // Tạo mới chi tiết phiếu xuất
                        chiTietPhieuXuat = new CTPhieuXuatHang()
                        {
                            SoPhieuXuat = soPhieuXuat,
                            MaHang = maHangHoa,
                            SoLuongXuat = soLuongXuat
                        };
                        phieuXuat.CTPhieuXuatHangs.Add(chiTietPhieuXuat);

                        // Cập nhật số lượng hàng hóa trong bảng HangHoa
                        hangHoa.SoLuongTon -= soLuongXuat;
                    }

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    // Hiển thị phiếu xuất mới trong DataGridView
                    loadData();
                }
                else
                {
                    // Người dùng không đồng ý, không thực hiện gì
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa.");
            }
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSoPhieuXuat.Text) || string.IsNullOrWhiteSpace(cboMaHang.Text) ||
        string.IsNullOrWhiteSpace(txtSoLuongXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maPhieuXuat;
            if (!int.TryParse(cboSoPhieuXuat.Text, out maPhieuXuat))
            {
                MessageBox.Show("Số phiếu xuất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHangHoa = cboMaHang.Text.Trim();

            float soLuongXuatMoi;
            if (!float.TryParse(txtSoLuongXuat.Text, out soLuongXuatMoi) || soLuongXuatMoi <= 0)
            {
                MessageBox.Show("Số lượng xuất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm chi tiết phiếu xuất cần sửa
            var chiTietPhieuXuat = qlst.CTPhieuXuatHangs.FirstOrDefault(ctpx => ctpx.SoPhieuXuat == maPhieuXuat && ctpx.MaHang == maHangHoa);

            if (chiTietPhieuXuat != null)
            {
                float soLuongXuatCu = (float)chiTietPhieuXuat.SoLuongXuat;

                // Kiểm tra số lượng xuất mới
                if (soLuongXuatMoi == 0)
                {
                    MessageBox.Show("Số lượng xuất không được bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận cập nhật chi tiết phiếu xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Cập nhật số lượng xuất mới
                    chiTietPhieuXuat.SoLuongXuat = soLuongXuatMoi;

                    if (soLuongXuatMoi < soLuongXuatCu)
                    {
                        float soLuongGiam = soLuongXuatCu - soLuongXuatMoi;
                        chiTietPhieuXuat.HangHoa.SoLuongTon += soLuongGiam;
                    }
                    else if (soLuongXuatMoi > soLuongXuatCu)
                    {
                        float soLuongTang = soLuongXuatMoi - soLuongXuatCu;

                        // Kiểm tra số lượng tăng không vượt quá số lượng hiện tại trong kho
                        if (soLuongTang > chiTietPhieuXuat.HangHoa.SoLuongTon)
                        {
                            MessageBox.Show("Số lượng tăng vượt quá số lượng hiện tại trong kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        chiTietPhieuXuat.HangHoa.SoLuongTon -= soLuongTang;
                    }
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    // Hiển thị phiếu xuất mới trong DataGridView
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu xuất.");
            }
        }

        private void dtGVCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVCTPhieuNhap.Rows[e.RowIndex];
                int soPhieuXuat = int.Parse(row.Cells["SoPhieuXuat"].Value.ToString());
                string maHangHoa = row.Cells["MaHang"].Value.ToString();
            

               
                int selectedIndex = cboSoPhieuXuat.FindStringExact(soPhieuXuat.ToString());

                if (selectedIndex != -1)
                {
                   
                    cboSoPhieuXuat.SelectedIndex = selectedIndex;
                }

                cboMaHang.Text = maHangHoa;
              
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var chiTietPhieuXuat = from ctpn in qlst.CTPhieuXuatHangs
                                   join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                                   select new
                                   {
                                       ctpn.SoPhieuXuat,
                                       ctpn.MaHang,
                                       TenHang = hh.TenHang,
                                       ctpn.SoLuongXuat,
                                      
                                   };
            dtGVCTPhieuNhap.DataSource = chiTietPhieuXuat;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var hangHoa = from hh in qlst.HangHoas select new { hh.MaHang, hh.TenHang, hh.SoLuongTon, hh.DonGia };
            dTGVHangHoa1.DataSource = hangHoa;
        }

        private void btnSearchLoai_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của loại hàng đang được chọn trong ComboBox
            var selectedLoaiHang = cboLoaiHang.SelectedItem as LoaiHangHoa;

            if (selectedLoaiHang != null)
            {
                string tenLoaiHang = selectedLoaiHang.TenLoai;

                // Thực hiện truy vấn LINQ để lấy các hàng hóa theo tên loại hàng
                var query = from hangHoa in qlst.HangHoas
                            where hangHoa.LoaiHangHoa.TenLoai.Contains(tenLoaiHang)
                            select new { hangHoa.MaHang, hangHoa.TenHang, hangHoa.SoLuongTon };

                // Gán kết quả truy vấn vào DataGridView
                dTGVHangHoa1.DataSource = query.ToList();
            }
        }

        private void btnSearchTen_Click(object sender, EventArgs e)
        {
            string maHang = cboMaHang.Text.Trim();

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from hangHoa in qlst.HangHoas
                        where hangHoa.MaHang == maHang
                        select new { hangHoa.MaHang, hangHoa.TenHang, hangHoa.SoLuongTon };

            // Gán kết quả truy vấn vào DataGridView
            dTGVHangHoa1.DataSource = query.ToList();
        }
        private int GetPhieuXuatCount()
        {
            using (QLSTDataContext qlst1 = new QLSTDataContext())
            {
                int count = qlst1.PhieuXuatHangs.Count();
                return count;
            }
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Tạo phiếu xuất mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                // Người dùng đã đồng ý, thực hiện tạo phiếu xuất mới

                // Tạo số phiếu xuất mới
                int soPhieuXuat = GetPhieuXuatCount() + 1;
                DateTime ngayTao = dateTimePickerNgayTaoPXH.Value;
                // Thêm phiếu xuất vào cơ sở dữ liệu
                PhieuXuatHang newPhieuXuat = new PhieuXuatHang
                {
                    SoPhieuXuat = soPhieuXuat,
                    NgayTaoPXH = ngayTao,
                    MaNV = DangNhap.dn.MaNV
                    // Các thông tin khác của phiếu xuất
                };

                qlst.PhieuXuatHangs.InsertOnSubmit(newPhieuXuat);

                qlst.SubmitChanges();

                // Cập nhật ComboBox
                loadcboSoPX();
                int lastIndex = cboSoPhieuXuat.Items.Count - 1;
                cboSoPhieuXuat.SelectedIndex = lastIndex;
            }
            else
            {
                // Người dùng không đồng ý, không thực hiện gì
                return;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            int soPhieuXuat = int.Parse(cboSoPhieuXuat.Text);
            var phieuXuat = qlst.PhieuXuatHangs.FirstOrDefault(p => p.SoPhieuXuat == soPhieuXuat);

            if (phieuXuat != null)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Xác nhận lập phiếu xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (result == DialogResult.Yes)
                {
                    // Người dùng đã đồng ý, thực hiện các thay đổi liên quan đến lập phiếu

                    // Kiểm tra số lượng hàng hóa trong chi tiết phiếu xuất
                    if (phieuXuat.CTPhieuXuatHangs.Count == 0)
                    {
                        MessageBox.Show("Phiếu không có hàng hóa nào được nhập.");
                        return;
                    }

                    // Cập nhật trạng thái của phiếu xuất thành "Hoàn thành"
                    phieuXuat.TrangThai = "Hoàn thành";

                    // Lưu thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    // Thực hiện các hành động khác sau khi lập phiếu thành công
                    // ...

                    // Disable các nút sửa và xóa nếu phiếu xuất đã được lập
                    btnSuaPX.Enabled = false;
                    btnXoaPX.Enabled = false;
                    btnInPhieu.Enabled = true;
                    btnLapPhieu.Enabled = false;
                    btnXuatHang.Enabled = false;
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

        private void cboSoPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soPhieuXuat;
            if (!string.IsNullOrEmpty(cboSoPhieuXuat.Text))
            {
                if (Int32.TryParse(cboSoPhieuXuat.Text, out soPhieuXuat))
                {
                    var phieuNhap = qlst.PhieuXuatHangs.FirstOrDefault(p => p.SoPhieuXuat == soPhieuXuat);

                    if (phieuNhap != null && phieuNhap.TrangThai == "Hoàn thành")
                    {
                        btnSuaPX.Enabled = false;
                        btnXoaPX.Enabled = false;
                        btnInPhieu.Enabled = true;
                        btnLapPhieu.Enabled = false;
                        btnXuatHang.Enabled = false;
                    }
                    else
                    {
                        btnSuaPX.Enabled = true;
                        btnXoaPX.Enabled = true;
                        btnInPhieu.Enabled = false;
                        btnLapPhieu.Enabled = true;
                        btnXuatHang.Enabled = true;
                    }
                }
                else
                {

                }
            }
        }

        private void btnSearchMa_Click(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(cboSoPhieuXuat.Text.Trim());

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from ctpn in qlst.CTPhieuXuatHangs
                        join hh in qlst.HangHoas on ctpn.MaHang equals hh.MaHang
                        where ctpn.SoPhieuXuat == maPhieu
                        select new
                        {
                            ctpn.SoPhieuXuat,
                            ctpn.MaHang,
                            TenHang = hh.TenHang,
                            ctpn.SoLuongXuat,
                            
                        };

            // Gán kết quả truy vấn vào DataGridView
            dtGVCTPhieuNhap.DataSource = query.ToList();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            maPhieuXuat = int.Parse(cboSoPhieuXuat.Text.Trim());

            // Tạo một phiếu nhập mới để chứa thông tin chi tiết
            PhieuXuatHang phieuXuat = qlst.PhieuXuatHangs.FirstOrDefault(pn => pn.SoPhieuXuat == maPhieuXuat);

            if (phieuXuat != null)
            {

                frmPhieuXuat phieuXuatForm = new frmPhieuXuat();
                // Hiển thị form "PhieuNhapForm"
                phieuXuatForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu nhập.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dTGVHangHoa1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dTGVHangHoa1.Rows[e.RowIndex];
             
                string maHangHoa = row.Cells["MaHang"].Value.ToString();
            


                

                cboMaHang.Text = maHangHoa;
               
            }
        }
    }
}
