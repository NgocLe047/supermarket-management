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
    public partial class frmMatHang : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public frmMatHang()
        {
            InitializeComponent();
            loadData();
            btnLuu.Enabled = false;
        }
        bool checkThemSua = false;
        private void loadData()
        {
            var mathangs = from mh in qlst.LoaiHangHoas select mh;
            db_categoriesDataGridView.DataSource = mathangs;

            int count = 0;
            for (int i = 0; i < db_categoriesDataGridView.Rows.Count; i++)
            {
                count++;
            }

            if (count >= 1)
            {
                // Chọn dòng đầu tiên
                db_categoriesDataGridView.Rows[0].Selected = true;
                txt_categorieid.Text = db_categoriesDataGridView.Rows[0].Cells[db_categoriesDataGridView.Columns["MaLoai"].Index].Value.ToString();
                txt_categoriename.Text = db_categoriesDataGridView.Rows[0].Cells[db_categoriesDataGridView.Columns["TenLoai"].Index].Value.ToString();
            }
        }

       

        private void FrmMatHang_Click(object sender, EventArgs e)
        {
            txt_categorieid.ReadOnly = false;
            txt_categorieid.BackColor = Color.White;
        }



        //Tìm kiếm
        //Theo mã loại
        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
        }

        private void frmMatHang_Load_1(object sender, EventArgs e)
        {

        }

       

        private void btn_edit_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {

        }

        private void db_categoriesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click_2(object sender, EventArgs e)
        {
            txt_categorieid.Enabled = false;
            txt_categoriename.Text = "";
            txt_categorieid.Text = "";
            btnLuu.Enabled = true;
            btn_edit.Enabled = false;
            btn_remove.Enabled = false;
            checkThemSua = true;
        }

        private string GenerateNewMaLoaiHang(string lastMaLoaiHang)
        {
            if (string.IsNullOrEmpty(lastMaLoaiHang))
            {
                return "LOAI001";
            }

            string prefix = lastMaLoaiHang.Substring(0, 4);

            if (int.TryParse(lastMaLoaiHang.Substring(4), out int lastNumber))
            {
                int newNumber = lastNumber + 1;
                return prefix + newNumber.ToString("D3");
            }
            else
            {
                return "LOAI001";
            }
        }

        private void btn_edit_Click_2(object sender, EventArgs e)
        {
            btn_remove.Enabled = false;
            btnLuu.Enabled = true;
            btn_save.Enabled = false;
            checkThemSua = false;

        }

        private void btn_remove_Click_2(object sender, EventArgs e)
        {
            // Lấy mã loại hàng hóa từ TextBox
            string maLoai = txt_categorieid.Text;

            // Kiểm tra xem mã loại hàng hóa có tồn tại chưa
            var loaiHangHoa = qlst.LoaiHangHoas.FirstOrDefault(lh => lh.MaLoai == maLoai);

            if (loaiHangHoa == null)
            {
                MessageBox.Show("Mã loại hàng hóa không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem loại hàng hóa có dữ liệu liên quan trong bảng HangHoas hay không
            var hangHoas = qlst.HangHoas.Where(hh => hh.MaLoai == maLoai).ToList();

            if (hangHoas.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại hàng hóa vì có hàng hóa thuộc loại này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa loại hàng hóa
            DialogResult result = MessageBox.Show("Xác nhận xóa loại hàng hóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Xóa loại hàng hóa khỏi cơ sở dữ liệu
                    qlst.LoaiHangHoas.DeleteOnSubmit(loaiHangHoa);
                    qlst.SubmitChanges();

                    MessageBox.Show("Xóa loại hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    // Xóa nội dung TextBox sau khi xóa thành công
                    txt_categorieid.Text = string.Empty;
                    txt_categorieid.Text = string.Empty;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Không thể xóa loại hàng hóa do có dữ liệu liên quan trong bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmMatHang n = new frmMatHang();
                    frmTrangChu trangChu = (frmTrangChu)this.ParentForm;
                    trangChu.OpenChildForm(n);
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_categorieid.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại hàng hóa!");
                return;
            }

           
            string maHang = txt_categorieid.Text.Trim();
            var query = from hangHoa in qlst.LoaiHangHoas
                        where hangHoa.MaLoai == maHang
                        select hangHoa;
           
            if (query == null)
            {
                MessageBox.Show("Không tìm thấy loại hàng hóa này!");
                return;
            }
           

            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm
           

            // Gán kết quả truy vấn vào DataGridView
            db_categoriesDataGridView.DataSource = query.ToList();
            // Hiển thị thông tin nhân viên lên db_userDataGridView.
         
        }

        private void db_categoriesDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            string mamh = db_categoriesDataGridView.CurrentRow.Cells[0].Value.ToString();
            LoaiHangHoa mh = qlst.LoaiHangHoas.Where(t => t.MaLoai == mamh).FirstOrDefault();

            txt_categorieid.Text = mh.MaLoai;
      

            txt_categoriename.Text = mh.TenLoai;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_categorieid.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng hóa!");
                return;
            }


            string maHang = txt_categoriename.Text.Trim();
            var query = from hangHoa in qlst.LoaiHangHoas
                        where hangHoa.TenLoai == maHang
                        select hangHoa;

            if (query == null)
            {
                MessageBox.Show("Không tìm thấy loại hàng hóa này!");
                return;
            }


            // Thực hiện truy vấn LINQ để lấy các hàng hóa theo mã sản phẩm


            // Gán kết quả truy vấn vào DataGridView
            db_categoriesDataGridView.DataSource = query.ToList();
            // Hiển thị thông tin nhân viên lên db_userDataGridView.
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkThemSua == true)
            {
                // Kiểm tra các textbox có rỗng hay không
                if ( string.IsNullOrEmpty(txt_categoriename.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận thêm loại hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tìm mã loại hàng cuối cùng từ nguồn dữ liệu LoaiHangHoas
                    string lastMaLoaiHang = qlst.LoaiHangHoas.OrderByDescending(lh => lh.MaLoai).Select(lh => lh.MaLoai).FirstOrDefault();

                    // Tạo mã loại hàng mới dựa trên mã loại hàng cuối cùng
                    string newMaLoaiHang = GenerateNewMaLoaiHang(lastMaLoaiHang);

                    // Tạo đối tượng mới và thêm vào cơ sở dữ liệu
                    LoaiHangHoa mh = new LoaiHangHoa();
                    mh.MaLoai = newMaLoaiHang;
                    mh.TenLoai = txt_categoriename.Text;
                    qlst.LoaiHangHoas.InsertOnSubmit(mh);
                    qlst.SubmitChanges();
                    loadData();

                    MessageBox.Show("Thêm loại hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_edit.Enabled = true;
                    btnLuu.Enabled = false;
                    btn_remove.Enabled = true;
                    txt_categorieid.Enabled = true;
                    txt_categoriename.Text = "";
                   
                }
            }
            if (checkThemSua == false)
            {
                // Kiểm tra các textbox có rỗng hay không
                if (string.IsNullOrEmpty(txt_categorieid.Text) || string.IsNullOrEmpty(txt_categoriename.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã loại hàng từ textbox
                string maLoaiHang = txt_categorieid.Text;

                // Kiểm tra xem mã loại hàng có tồn tại trong cơ sở dữ liệu hay không
                LoaiHangHoa loaiHangHoa = qlst.LoaiHangHoas.FirstOrDefault(lh => lh.MaLoai == maLoaiHang);
                if (loaiHangHoa == null)
                {
                    MessageBox.Show("Mã loại hàng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Xác nhận cập nhật tên loại hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Cập nhật tên loại hàng
                    loaiHangHoa.TenLoai = txt_categoriename.Text;
                    qlst.SubmitChanges();

                    MessageBox.Show("Cập nhật tên loại hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    btn_save.Enabled = true;
                    btnLuu.Enabled = false;
                    btn_remove.Enabled = true;
                    txt_categorieid.Enabled = true;
                    txt_categoriename.Text = "";
                    txt_categorieid.Text = "";
                    checkThemSua = false;
                }
            }
        }
    }
}
