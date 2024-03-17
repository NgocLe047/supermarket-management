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

using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmPhieuXuat : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public static int maPhieuXuat;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        string maNV = DangNhap.dn.MaNV;
        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            maPhieuXuat = frmXuatHang.maPhieuXuat;
          
            //Khai báo câu lệnh SQL
            String sql = "Select * from CTPhieuXuatHang Where SoPhieuXuat =" + maPhieuXuat.ToString();
            String sql2 = "Select * from PhieuXuatHang Where SoPhieuXuat =" + maPhieuXuat.ToString();
            String sql3 = "Select * from NhanVien,PhieuXuatHang Where PhieuXuatHang.MaNV = NhanVien.MaNV And SoPhieuXuat =" +maPhieuXuat.ToString();
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source =LAPTOP-GKNTKFSD\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);

            SqlDataAdapter adp3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adp2.Fill(ds3);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer2.LocalReport.ReportPath = "Report1.rdlc";
            //Nếu có dữ liệu

            // Kết nối bảng CTPhieuXuatHang
            DataSet dsCTPhieuNhap = new DataSet();
            adp.Fill(dsCTPhieuNhap, "CTPhieuXuatHang");

            ReportDataSource rdsCTPhieuNhap = new ReportDataSource();
            rdsCTPhieuNhap.Name = "DataSet1";
            rdsCTPhieuNhap.Value = dsCTPhieuNhap.Tables["CTPhieuXuatHang"];

            // Kết nối bảng PhieuXuatHang
            DataSet dsPhieuNhapHang = new DataSet();
            adp2.Fill(dsPhieuNhapHang, "PhieuXuatHang");

            ReportDataSource rdsPhieuNhapHang = new ReportDataSource();
            rdsPhieuNhapHang.Name = "DataSet2";
            rdsPhieuNhapHang.Value = dsPhieuNhapHang.Tables["PhieuXuatHang"];

            DataSet layMaNV = new DataSet();
            adp3.Fill(layMaNV, "NhanVien");

            ReportDataSource rdslayMaNV = new ReportDataSource();
            rdslayMaNV.Name = "DataSet3";
            rdslayMaNV.Value = layMaNV.Tables["NhanVien"];
            //Tạo nguồn dữ liệu cho báo cáo

            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            reportViewer2.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer2.LocalReport.DataSources.Add(rdsCTPhieuNhap);
            reportViewer2.LocalReport.DataSources.Add(rdsPhieuNhapHang);
            reportViewer2.LocalReport.DataSources.Add(rdslayMaNV);
            //Refresh lại báo cáo
            reportViewer2.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
