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
using Nhom5_QuanLySieuThi.GUI;

namespace Nhom5_QuanLySieuThi
{
    public partial class DangNhap : Form
    {
        DangNhapDAO dnDAO = new DangNhapDAO();
        List<DangNhap> lsdn = new List<DangNhap>();
        public static DangNhapDTO dn = new DangNhapDTO();

        NhanVienDAO nvDAO = new NhanVienDAO();
        NhanVien nv = new NhanVien();

        public DangNhap()
        {
            InitializeComponent();
            btn_login_2.Click += btn_login_2_Click;
            btn_Exit.Click += btn_Exit_Click;
            cbshowpassword.CheckedChanged += cbshowpassword_CheckedChanged;
        }

        void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = cbshowpassword.Checked ? '\0' : '*';
        }

        void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btn_login_2_Click(object sender, EventArgs e)
        {
            if (ktdangNhap(txt_Username.Text, txt_Password.Text))
            {
                string chucvu = nvDAO.LayChucVuNV(dn.MaNV);
                frmTrangChu fr = new frmTrangChu(chucvu);
                MessageBox.Show("Đăng nhập thành công");
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show( "Tài khoản hoặc mật khẩu không đúng","Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ktdangNhap(string tk, string mk)
        {
            string TK = txt_Username.Text;

            foreach (var a in dnDAO.layDSTK())
            {
                if (a.TaiKhoan == TK)
                {
                    if (a.MatKhau == mk)
                    {
                        dn.TaiKhoan = txt_Username.Text;
                        dn.MatKhau = txt_Password.Text;
                        dn.TaiKhoan = a.TaiKhoan;
                        dn.MaNV = a.MaNV;
                        return true;
                    }
                }
            }

            return false;
        }

        public void LayDSTK()
        {
            dnDAO.layDSTK();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
