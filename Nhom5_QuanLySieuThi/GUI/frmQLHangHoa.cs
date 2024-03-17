using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmQLHangHoa : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmQLHangHoa()
        {
            InitializeComponent();
            loadData();
            txtSoLuongTon.Enabled = false;
            btnLuu.Enabled = false;
        }
        public void loadData()
        {

            var hanghoa = from hh in qlst.HangHoas select new
            {
                hh.MaHang,
                hh.TenHang,
                hh.DVT,
                hh.DonGia,
                hh.NgaySX,
                hh.HSD,
                hh.SoLuongTon,
                hh.MaLoai,
                hh.MaNCC,
                hh.LoaiHangHoa.TenLoai,
                hh.NhaCungCap.TenNCC,
            };
            dtGVHangHoa.DataSource = hanghoa;
        }

       

       

        
        private void ClearTextBoxes()
        {
            txtMaHang.Text = string.Empty;
            txtTenHang.Text = string.Empty;
            txtDVT.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            dateTimePickerNgaySX.Text = string.Empty;
            dateTimePickerHSD.Text = string.Empty;
            
            cboLoaiHang.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;
        }

        bool checkThemSua = false;

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenuHangHoa qlHH = new frmMenuHangHoa();
            frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
            trangChu.OpenChildForm(qlHH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtMaHang.Enabled = false;
            checkThemSua = true;

        }
        private string GenerateNewMaHang(string lastMaHang)
        {
            if (string.IsNullOrEmpty(lastMaHang))
            {
                return "HH001";
            }

            string prefix = lastMaHang.Substring(0, 2);

            if (int.TryParse(lastMaHang.Substring(2), out int lastNumber))
            {
                int newNumber = lastNumber + 1;
                return prefix + newNumber.ToString("D3");
            }
            else
            {
               
                return "HH001";
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Lấy mã hàng hóa từ TextBox
            string maHang = txtMaHang.Text;

            // Kiểm tra xem mã hàng hóa có tồn tại chưa
            var hangHoa = qlst.HangHoas.FirstOrDefault(h => h.MaHang == maHang);

            if (hangHoa == null)
            {
                MessageBox.Show("Mã hàng hóa không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa hàng hóa
            DialogResult result = MessageBox.Show("Xác nhận xóa hàng hóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Xóa hàng hóa khỏi cơ sở dữ liệu
                    qlst.HangHoas.DeleteOnSubmit(hangHoa);
                    qlst.SubmitChanges();

                    MessageBox.Show("Xóa hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    // Xóa nội dung TextBox sau khi xóa thành công
                    txtMaHang.Text = string.Empty;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Không thể xóa hàng hóa do có dữ liệu liên quan trong bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmQLHangHoa n = new frmQLHangHoa();
                    frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
                    trangChu.OpenChildForm(n);
                }
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaHang.Enabled = true;
            checkThemSua = false;



            

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtGVHangHoa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVHangHoa.Rows[e.RowIndex];


                string maHang = row.Cells["MaHang"].Value.ToString();
                string tenHang = row.Cells["TenHang"].Value.ToString();
                string dvt = row.Cells["DVT"].Value.ToString();
                float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                DateTime ngaySX = DateTime.Parse(row.Cells["NgaySX"].Value.ToString());
                DateTime hsd = DateTime.Parse(row.Cells["HSD"].Value.ToString());
                int soLuongTon = int.Parse(row.Cells["SoLuongTon"].Value.ToString());
                string maLoaiHang = row.Cells["MaLoai"].Value.ToString();
                string maNCC = row.Cells["MaNCC"].Value.ToString();


                txtMaHang.Text = maHang;
                txtTenHang.Text = tenHang;
                txtDVT.Text = dvt;
                txtDonGia.Text = donGia.ToString();
                dateTimePickerNgaySX.Text = ngaySX.ToString("yyyy-MM-dd");
                dateTimePickerHSD.Text = hsd.ToString("yyyy-MM-dd");
                txtSoLuongTon.Text = soLuongTon.ToString();


                cboLoaiHang.SelectedValue = maLoaiHang;


                cboNCC.SelectedValue = maNCC;
            }
        }

        private void btnSearchMa_Click_1(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text.Trim();

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
            var query = from hh in qlst.HangHoas
                        where hh.MaHang == maHang
                        select new
                        {
                            hh.MaHang,
                            hh.TenHang,
                            hh.DVT,
                            hh.DonGia,
                            hh.NgaySX,
                            hh.HSD,
                            hh.SoLuongTon,
                            hh.MaLoai,
                            hh.MaNCC,
                            hh.LoaiHangHoa.TenLoai,
                            hh.NhaCungCap.TenNCC,
                        };

            // Gán kết quả truy vấn vào DataGridView
            dtGVHangHoa.DataSource = query.ToList();
        }

        private void btnSearchTen_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị của loại hàng đang được chọn trong ComboBox
            var selectedLoaiHang = cboLoaiHang.SelectedItem as LoaiHangHoa;

            if (selectedLoaiHang != null)
            {
                string tenLoaiHang = selectedLoaiHang.TenLoai;

                // Thực hiện truy vấn LINQ để lấy các hàng hóa theo tên loại hàng
                var query = from hh in qlst.HangHoas
                            where hh.LoaiHangHoa.TenLoai.Contains(tenLoaiHang)
                            select new
                            {
                                hh.MaHang,
                                hh.TenHang,
                                hh.DVT,
                                hh.DonGia,
                                hh.NgaySX,
                                hh.HSD,
                                hh.SoLuongTon,
                                hh.MaLoai,
                                hh.MaNCC,
                                hh.LoaiHangHoa.TenLoai,
                                hh.NhaCungCap.TenNCC,
                            };

                // Gán kết quả truy vấn vào DataGridView
                dtGVHangHoa.DataSource = query.ToList();
            }
        }

        private void btnSearchLoai_Click_1(object sender, EventArgs e)
        {
            string tenHang = txtTenHang.Text.Trim();

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo tên
            var query = from hh in qlst.HangHoas
                        where hh.TenHang.Contains(tenHang)
                        select new
                        {
                            hh.MaHang,
                            hh.TenHang,
                            hh.DVT,
                            hh.DonGia,
                            hh.NgaySX,
                            hh.HSD,
                            hh.SoLuongTon,
                            hh.MaLoai,
                            hh.MaNCC,
                            hh.LoaiHangHoa.TenLoai,
                            hh.NhaCungCap.TenNCC,
                        };

            // Gán kết quả truy vấn vào DataGridView
            dtGVHangHoa.DataSource = query.ToList();
        }

        private void frmQLHangHoa_Load(object sender, EventArgs e)
        {
            var query = from loaiHang in qlst.LoaiHangHoas
                        select loaiHang;

            // Gán kết quả truy vấn vào ComboBox
            cboLoaiHang.DataSource = query.ToList();
            cboLoaiHang.DisplayMember = "TenLoai";
            cboLoaiHang.ValueMember = "MaLoai";

            var query2 = from ncc in qlst.NhaCungCaps
                         select ncc;

            // Gán kết quả truy vấn vào ComboBox
            cboNCC.DataSource = query2.ToList();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }

        private void cboLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkThemSua == true)
            {

                string maHang = txtMaHang.Text;
                string tenHang = txtTenHang.Text;
                string dvt = txtDVT.Text;
                float donGia;
                DateTime ngaySX;
                DateTime hsd;
                int soLuongTon;
                string maLoaiHang;
                string maNCC;

                if (string.IsNullOrEmpty(tenHang) || string.IsNullOrEmpty(dvt) ||
                    !float.TryParse(txtDonGia.Text, out donGia) || !DateTime.TryParse(dateTimePickerNgaySX.Text, out ngaySX) ||
                    !DateTime.TryParse(dateTimePickerHSD.Text, out hsd) ||
                    cboLoaiHang.SelectedIndex == -1 || cboNCC.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (hsd < ngaySX)
                {
                    MessageBox.Show("Ngày HSD phải lớn hơn hoặc bằng ngày SX.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maLoaiHang = ((LoaiHangHoa)cboLoaiHang.SelectedItem).MaLoai;
                maNCC = ((NhaCungCap)cboNCC.SelectedItem).MaNCC;

                // Kiểm tra xem mã hàng đã tồn tại chưa


                // Hiển thị hộp thoại xác nhận trước khi thêm hàng hóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm hàng hóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Tìm mã hàng cuối cùng từ nguồn dữ liệu HangHoas
                    string lastMaHang = qlst.HangHoas.OrderByDescending(h => h.MaHang).Select(h => h.MaHang).FirstOrDefault();

                    // Tạo mã hàng mới dựa trên mã hàng cuối cùng
                    string newMaHang = GenerateNewMaHang(lastMaHang);

                    // Tạo đối tượng mới và thêm vào cơ sở dữ liệu
                    HangHoa newHangHoa = new HangHoa()
                    {
                        MaHang = newMaHang,
                        TenHang = tenHang,
                        DVT = dvt,
                        DonGia = donGia,
                        NgaySX = ngaySX,
                        HSD = hsd,
                        SoLuongTon = 0,
                        MaLoai = maLoaiHang,
                        MaNCC = maNCC
                    };

                    qlst.HangHoas.InsertOnSubmit(newHangHoa);
                    qlst.SubmitChanges();

                    MessageBox.Show("Thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    // Xóa nội dung các TextBox sau khi thêm thành công
                    ClearTextBoxes();
                    txtMaHang.Enabled = true;
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                }

              
            }
            if (checkThemSua == false)
            {
                //Lấy thông tin từ các TextBox và ComboBox
                string maHang = txtMaHang.Text;
                string tenHang = txtTenHang.Text;
                string dvt = txtDVT.Text;
                float donGia;
                DateTime ngaySX;
                DateTime hsd;
                int soLuongTon;
                string maLoaiHang;
                string maNCC;

                if (string.IsNullOrEmpty(maHang) || string.IsNullOrEmpty(tenHang) || string.IsNullOrEmpty(dvt) ||
                    !float.TryParse(txtDonGia.Text, out donGia) || !DateTime.TryParse(dateTimePickerNgaySX.Text, out ngaySX) ||
                    !DateTime.TryParse(dateTimePickerHSD.Text, out hsd) || !int.TryParse(txtSoLuongTon.Text, out soLuongTon) ||
                    cboLoaiHang.SelectedIndex == -1 || cboNCC.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (hsd < ngaySX)
                {
                    MessageBox.Show("Ngày HSD phải lớn hơn hoặc bằng ngày SX.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                maLoaiHang = ((LoaiHangHoa)cboLoaiHang.SelectedItem).MaLoai;
                maNCC = ((NhaCungCap)cboNCC.SelectedItem).MaNCC;

                // Kiểm tra xem mã hàng hóa có tồn tại chưa
                var hangHoa = qlst.HangHoas.FirstOrDefault(h => h.MaHang == maHang);

                if (hangHoa == null)
                {
                    MessageBox.Show("Mã hàng hóa không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận trước khi sửa hàng hóa
                DialogResult result2 = MessageBox.Show("Xác nhận sửa hàng hóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    // Cập nhật thông tin hàng hóa
                    hangHoa.TenHang = tenHang;
                    hangHoa.DVT = dvt;
                    hangHoa.DonGia = donGia;
                    hangHoa.NgaySX = ngaySX;
                    hangHoa.HSD = hsd;

                    hangHoa.MaLoai = maLoaiHang;
                    hangHoa.MaNCC = maNCC;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    qlst.SubmitChanges();

                    MessageBox.Show("Sửa hàng hóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    ClearTextBoxes();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                }
            }
        }
    }
}
