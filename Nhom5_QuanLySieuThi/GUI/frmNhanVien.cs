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
    public partial class frmNhanVien : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmNhanVien()
        {
            InitializeComponent();
            loadData();
            cboChucVu.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void loadData()
        {
            var query = from nv in qlst.NhanViens
                        join dn in qlst.DangNhaps on nv.MaNV equals dn.MaNV
                        select new
                        {
                            nv.MaNV,
                            nv.HoTenNV,
                            nv.SDTNV,
                            nv.ChucVu,
                            dn.TaiKhoan,
                            dn.MatKhau
                        };

            db_userDataGridView.DataSource = query.ToList();
        }

        public void loadcboChucVu()
        {
            var query2 = from ctpn in qlst.NhanViens
                         select ctpn;

            // Gán kết quả truy vấn vào ComboBox
            cboChucVu.DataSource = query2.ToList();
            cboChucVu.DisplayMember = "ChucVu";
            cboChucVu.ValueMember = "ChucVu";
        }


        private void themtk(string manv)
        {
            DAO.DangNhap tk = new DAO.DangNhap();
            tk.MaNV = manv;
            tk.MatKhau = txt_Password.Text;
            tk.TaiKhoan = "nv";

            qlst.DangNhaps.InsertOnSubmit(tk);
            qlst.SubmitChanges();

        }

        
        private void suatk(string manv)
        {
            DAO.DangNhap tk = qlst.DangNhaps.Where(t => t.MaNV == manv).FirstOrDefault();
            tk.MatKhau = txt_Password.Text;
            qlst.SubmitChanges();
        }

       

        private void db_userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string manv = db_userDataGridView.CurrentRow.Cells[0].Value.ToString();
            NhanVien nv = qlst.NhanViens.Where(t => t.MaNV == manv).FirstOrDefault();

            txt_Username.Text = nv.MaNV;
            txt_Username.ReadOnly = true;
            txt_Username.BackColor = Color.LightGray;

            txt_fullname.Text = nv.HoTenNV;
            txt_mobailno.Text = nv.SDTNV;

            DAO.DangNhap tk = qlst.DangNhaps.Where(t => t.MaNV == nv.MaNV).FirstOrDefault();
            txt_Password.Text = new string('*', 6);
        }

        private void db_userDataGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == db_userDataGridView.Columns["MatKhau"].Index && e.Value != null)
            {
                e.Value = new string('*', 6);
            }
        }

        bool checkThemSua = false;
        

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtMaNV.Text = "";
            txt_fullname.Text = "";
            txt_mobailno.Text = "";
            txt_Password.Text = "";
            txt_Username.Text = "";
            btnLuu.Enabled = true;
            btn_edit.Enabled = false;
            btnDoiMK.Enabled    = false;
            btn_remove.Enabled = false;
            checkThemSua = true;
            cboChucVu.Enabled = true;
        }

        private string GenerateNewMaNV(string lastMaNV)
        {
            if (string.IsNullOrEmpty(lastMaNV))
            {
                return "NV001";
            }

            if (int.TryParse(lastMaNV.Substring(2), out int lastNumber))
            {
                int newNumber = lastNumber + 1;
                return "NV" + newNumber.ToString("D3");
            }
            else
            {
                return "NV001";
            }
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
          
            btnLuu.Enabled = true;
            btn_login.Enabled = false;
            btnDoiMK.Enabled = false;
            btn_remove.Enabled = false;
            checkThemSua = false;
            txt_Username.Enabled = false;
            txt_Password.Enabled = false;

           
        }

       

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng!");
                return;
            }


            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm


            // Gán kết quả truy vấn vào DataGridView
            var query = from nv in qlst.NhanViens
                        join dn in qlst.DangNhaps on nv.MaNV equals dn.MaNV
                        where nv.MaNV == txtMaNV.Text
                        select new
                        {
                            nv.MaNV,
                            nv.HoTenNV,
                            nv.SDTNV,
                            nv.ChucVu,
                            dn.TaiKhoan,
                            dn.MatKhau
                        };

            // Kiểm tra xem nhân viên có tồn tại không.
            if (query == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào có mã NV này!");
                return;
            }

            // Hiển thị thông tin nhân viên lên db_userDataGridView.
            db_userDataGridView.DataSource = query.ToList();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fullname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!");
                return;
            }


            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm


            // Gán kết quả truy vấn vào DataGridView
            var query = from nv in qlst.NhanViens
                        join tk in qlst.DangNhaps on nv.MaNV equals tk.MaNV
                        where nv.HoTenNV == txt_fullname.Text
                        select new
                        {
                            nv.MaNV,
                            nv.HoTenNV,
                            nv.SDTNV,
                            nv.ChucVu,
                            tk.TaiKhoan,
                            tk.MatKhau
                        };

            // Kiểm tra xem nhân viên có tồn tại không.
            if (query == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào có tên này!");
                return;
            }

            // Hiển thị thông tin nhân viên lên db_userDataGridView.
            db_userDataGridView.DataSource = query.ToList();
        }

        private void db_userDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //string manv = db_userDataGridView.CurrentRow.Cells[0].Value.ToString();
            //DAO.NhanVien nv = qlst.NhanViens.Where(t => t.MaNV == manv).FirstOrDefault();

            //txt_Username.Text = nv.MaNV;
            //txt_Username.ReadOnly = true;
            //txt_Username.BackColor = Color.LightGray;

            //txt_fullname.Text = nv.HoTenNV;
            //txt_mobailno.Text = nv.SDTNV;
            txt_Password.Text = new string('*', 6);
            //DAO.DangNhap tk = qlst.DangNhaps.Where(t => t.MaNV == nv.MaNV).FirstOrDefault();
            //txt_Password.Text = new string('*', 6); 
        }

        private void db_userDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == db_userDataGridView.Columns["MatKhau"].Index && e.Value != null)
            {
                e.Value = new string('*', 6);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadcboChucVu();
        }

        private void db_userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = db_userDataGridView.Rows[e.RowIndex];

                // Lấy giá trị từ các cột của dòng được chọn
                string maNV = row.Cells["MaNV"].Value.ToString();
                string hoTenNV = row.Cells["HoTenNV"].Value.ToString();
                string sdtNV = row.Cells["SDTNV"].Value.ToString();
                string chucVu = row.Cells["ChucVu"].Value.ToString();
                string taiKhoan = row.Cells["TaiKhoan"].Value.ToString();
                string matKhau = row.Cells["MatKhau"].Value.ToString();

                // Hiển thị giá trị lên các TextBox và ComboBox
                txtMaNV.Text = maNV;
                txt_fullname.Text = hoTenNV;
                txt_mobailno.Text = sdtNV;
                cboChucVu.Text = chucVu;
                txt_Username.Text = taiKhoan;
                txt_Password.Text = matKhau;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem txt_Username có rỗng hay không
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên tài khoản từ textbox
            string username = txt_Username.Text;

            // Tìm tài khoản trong cơ sở dữ liệu
            DAO.DangNhap dangNhap = qlst.DangNhaps.FirstOrDefault(dn => dn.TaiKhoan == username);
            if (dangNhap == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            var result = MessageBox.Show("Xác nhận xóa tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa tài khoản
                qlst.DangNhaps.DeleteOnSubmit(dangNhap);
                qlst.SubmitChanges();

                MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem txt_Username có rỗng hay không
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem txt_Password có rỗng hay không
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên tài khoản và mật khẩu mới từ textbox
            string username = txt_Username.Text;
            string newPassword = txt_Password.Text;

            // Tìm tài khoản trong cơ sở dữ liệu
            DAO.DangNhap dangNhap = qlst.DangNhaps.FirstOrDefault(dn => dn.TaiKhoan == username);
            if (dangNhap == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            var result = MessageBox.Show("Xác nhận đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cập nhật mật khẩu mới
                dangNhap.MatKhau = newPassword;
                qlst.SubmitChanges();

                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkThemSua == true)
            {
                // Kiểm tra các textbox có rỗng hay không
                if (string.IsNullOrEmpty(txt_fullname.Text) || string.IsNullOrEmpty(txt_mobailno.Text) || cboChucVu.SelectedItem == null || string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string username = txt_Username.Text;
                bool usernameExists = qlst.DangNhaps.Any(dn => dn.TaiKhoan == username);
                if (usernameExists)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận thêm nhân viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tìm mã nhân viên cuối cùng từ nguồn dữ liệu NhanVien
                    string lastMaNV = qlst.NhanViens.OrderByDescending(nv1 => nv1.MaNV).Select(nv1 => nv1.MaNV).FirstOrDefault();

                    // Tạo mã nhân viên mới dựa trên mã nhân viên cuối cùng
                    string newMaNV = GenerateNewMaNV(lastMaNV);

                    // Tạo đối tượng mới và thêm vào cơ sở dữ liệu
                    NhanVien nv = new NhanVien();
                    nv.MaNV = newMaNV;
                    nv.HoTenNV = txt_fullname.Text;
                    nv.NgaySinhNV = null;
                    nv.ChucVu = ((NhanVien)cboChucVu.SelectedItem).ChucVu;
                    nv.Luong = null;
                    nv.SDTNV = txt_mobailno.Text;
                    nv.DiaChiNv = null;
                    qlst.NhanViens.InsertOnSubmit(nv);
                    qlst.SubmitChanges();

                    DAO.DangNhap tk = new DAO.DangNhap();

                    tk.MaNV = newMaNV;
                    tk.TaiKhoan = txt_Username.Text;
                    tk.MatKhau = txt_Password.Text;
                    qlst.DangNhaps.InsertOnSubmit(tk);
                    qlst.SubmitChanges();


                    loadData();

                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                    btn_edit.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btn_remove.Enabled = true;
                    txtMaNV.Enabled = true;
                    cboChucVu.Enabled = false;
                }
            }
            if (checkThemSua == false)
            {
                // Kiểm tra các textbox có rỗng hay không
                if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_fullname.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_mobailno.Text) || cboChucVu.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã nhân viên từ textbox
                string maNV = txtMaNV.Text;

                // Kiểm tra xem mã nhân viên có tồn tại trong cơ sở dữ liệu hay không
                NhanVien nhanVien = qlst.NhanViens.FirstOrDefault(nv => nv.MaNV == maNV);
                if (nhanVien == null)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận cập nhật thông tin nhân viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Cập nhật thông tin nhân viên
                    nhanVien.HoTenNV = txt_fullname.Text;
                    nhanVien.SDTNV = txt_mobailno.Text;
                    nhanVien.ChucVu = ((NhanVien)cboChucVu.SelectedItem).ChucVu;
                    qlst.SubmitChanges();



                    MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    btnLuu.Enabled = false;
                    btn_login.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btn_remove.Enabled = true;
                    txtMaNV.Enabled = true;
                    txt_Password.Enabled = true;
                    txt_Username.Enabled = true;
                }
            }
        }
    }
}
