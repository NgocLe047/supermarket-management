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
using DTO;

namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmTrangChu : Form
    {
        public NhanVien nv = new NhanVien();
        QLSTDataContext qlst = new QLSTDataContext();
        public frmTrangChu(string chucvu)
        {
            nv.ChucVu = chucvu;
            InitializeComponent();
            enableButton(true);
            loadTheoChucVu(nv.ChucVu);
            label2.Text = nv.ChucVu;
            string hoten = (from ht in qlst.NhanViens
                           where ht.MaNV == DangNhap.dn.MaNV
                           select ht.HoTenNV).FirstOrDefault();
            label3.Text = hoten;
        }
     




        private Form currentformchild;

        public void OpenChildForm(Form child)
        {
            if (currentformchild != null)
                currentformchild.Close();
            currentformchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            bunifuPanel_child.Controls.Add(child);
            bunifuPanel_child.Width = child.Width;

            bunifuPanel_child.BringToFront();
            child.Show();
        }
        private void btn_dashborad_Click(object sender, EventArgs e)
        {
            btnThongKe.Top = ((Control)sender).Top;
            OpenChildForm(new frmThongKe());
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            btnMatHang.Top = ((Control)sender).Top;
            OpenChildForm(new frmMatHang());
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            btnHangHoa.Top = ((Control)sender).Top;
            OpenChildForm(new frmMenuHangHoa());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            btnKhachHang.Top = ((Control)sender).Top;
            OpenChildForm(new frmKhachHang());
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            btnDonHang.Top = ((Control)sender).Top;
            OpenChildForm(new frmDonHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            btnHoaDon.Top = ((Control)sender).Top;
            OpenChildForm(new frmLapHoaDon());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            btnNhanVien.Top = ((Control)sender).Top;
            OpenChildForm(new frmNhanVien());
        }

        private void Logout_Click(object sender, EventArgs e)
        {
           
            
        }
        public void OpenChildFormFromOtherForm(Form child)
        {
            OpenChildForm(child);
        }

        public void loadTheoChucVu(string chucvu)
        {
            if (chucvu == "Quản lý")
            {
                enableButton(true);
            }

            if (chucvu == "Nhân viên bán hàng")
            {
                btnThongKe.Enabled = false;
                btnMatHang.Enabled = false;
                btnHangHoa.Enabled = false;
                btnNhanVien.Enabled = false;    
            }

            if (chucvu == "Nhân viên kho")
            {

                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
            }
            if (chucvu == "Nhân viên kế toán")
            {
                 btnMatHang.Enabled = false;
                 btnHangHoa.Enabled = false;
                 btnKhachHang.Enabled = false;
                 btnNhanVien.Enabled = false;
            }
        }


        public void enableButton(bool kq)
        {
            btnMatHang.Enabled = kq;
            btnHangHoa.Enabled = kq;
            btnKhachHang.Enabled = kq;
            btnNhanVien.Enabled = kq;
            btnThongKe.Enabled = kq;
            btnHoaDon.Enabled = kq;
            btnDonHang.Enabled = kq;
        }

        private void btnPhongToNho_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                // Nếu đã phóng to, phóng nhỏ lại về kích thước màn hình
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Nếu chưa phóng to, phóng to đến kích thước màn hình
                this.WindowState = FormWindowState.Maximized;
            }

            // Gọi hàm cập nhật kích thước của các control bên trong
            UpdateControlsSize();
        }
        private void UpdateControlsSize()
        {
            // Tính tỉ lệ scale dựa trên kích thước cửa sổ
            float scaleX = (float)this.ClientSize.Width / 1920;  // originalFormWidth là kích thước ban đầu của form
            float scaleY = (float)this.ClientSize.Height / 1061;  // originalFormHeight là kích thước ban đầu của form

            // Lặp qua tất cả các control bên trong form và cập nhật kích thước của chúng
            foreach (Control control in this.Controls)
            {
                // Cập nhật kích thước của control bằng cách nhân với tỉ lệ scale
                control.Width = (int)(control.Width * scaleX);
                control.Height = (int)(control.Height * scaleY);

                // Cập nhật vị trí của control bằng cách nhân với tỉ lệ scale
                control.Left = (int)(control.Left * scaleX);
                control.Top = (int)(control.Top * scaleY);
            }
        }
        private void btnAnManHinh_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }
    }
}
