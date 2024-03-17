using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmKhachHang : Form
    {
        KhachHangDAO khDAO = new KhachHangDAO();
        List<KhachHangThanThiet> lskh = new List<KhachHangThanThiet>();
        KhachHangDTO KH = new KhachHangDTO();
        bool Edit_Flag = false;
        public frmKhachHang()
        {
            InitializeComponent();
            loadData();
            txtSDT.KeyPress += TxtSDT_KeyPress;
            txtMaKH.KeyPress += TxtMaKH_KeyPress;
            txtSDT.MaxLength = 10;
        }

        private void TxtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        public void loadData()
        {
            lskh = khDAO.layDSKH();
            tb_KhachHang.DataSource = lskh;
        }

        private void dtGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void dtGVKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaKH.Text = tb_KhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = tb_KhachHang.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(tb_KhachHang.CurrentRow.Cells[2].Value.ToString());
            txtSDT.Text = tb_KhachHang.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = tb_KhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDiemThuong.Text = tb_KhachHang.CurrentRow.Cells[5].Value.ToString();
        }

        //private void btn_remove_Click(object sender, EventArgs e)
        //{
        //    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
        //    if (rs == DialogResult.Yes)
        //    {
        //        string ma = txtMaKH.Text;

        //        if (khDAO.XoaKHTHeoMa(ma))
        //        {
        //            MessageBox.Show(this, "Xóa thành công");
        //        }
        //        else
        //        {
        //            MessageBox.Show(this, "Xóa thất bại");
        //        }
        //    }
        //    txtMaKH.Clear();
        //    txtDiaChi.Clear();
        //    txtSDT.Clear();
        //    txtHoTen.Clear();
        //    txtDiemThuong.Clear();
        //    pictureBox3_Click(sender, e);
        //}

        private void btn_save_Click(object sender, EventArgs e)
        {
            KhachHangThanThiet kh = new KhachHangThanThiet();
            kh.MaThe = txtMaKH.Text;
            kh.HoTen = txtHoTen.Text;
            kh.NgaySinhKH = dtpNgaySinh.Value;
            kh.Diem = 0;
            kh.DiaChiKH = txtDiaChi.Text;
            kh.SDTKH = txtSDT.Text;

            if (!Edit_Flag)
            {
                if (txtDiaChi.Text == string.Empty || txtSDT.Text == string.Empty ||
                    txtMaKH.Text == string.Empty || txtHoTen.Text == string.Empty )
                {
                    if (txtSDT.TextLength < 10)
                    {
                        MessageBox.Show(this, "Số điện thoại không hợp lệ");
                    }
                    MessageBox.Show(this, "Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    khDAO.ThemKH(kh);
                    MessageBox.Show(this, "Thêm thành công");
                    pictureBox3_Click(sender, e);
                }
            }
            else
            {
                if (khDAO.CapNhatKH(kh))
                {
                    MessageBox.Show(this, "Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show(this, "Cập nhật thất bại");
                }

                Edit_Flag = false;
                txtMaKH.Enabled = true;
                pictureBox3_Click(sender, e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit_Flag = true;
            txtMaKH.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lskh = khDAO.layDSKHTheoMa(txtMaKH.Text);
            tb_KhachHang.DataSource = lskh;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lskh = khDAO.layDSKHTheoMa(txtMaKH.Text);
            tb_KhachHang.DataSource = lskh;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "KH" + GetUniqueKey(5);
            txtHoTen.Clear();
            txtDiemThuong.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
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

        
    }
}
