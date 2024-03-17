using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DAO;
using System.Data.SqlClient;
namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmHoaDon : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        public static string soHoaDon;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            soHoaDon = frmLapHoaDon.soHoaDon;
            String sql = "Select * from CTHoaDonBanHang Where SoHoaDon = '" + soHoaDon.ToString() + "'";
            String sql2 = "Select * from HoaDonBanHang Where SoHoaDon = '" + soHoaDon.ToString() + "'";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =LAPTOP-GKNTKFSD\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";

            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);



            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";

            DataSet dscthd = new DataSet();
            adp.Fill(dscthd, "CTHoaDonBanHang");

            ReportDataSource rdsCTHD = new ReportDataSource();
            rdsCTHD.Name = "DataSet1";
            rdsCTHD.Value = dscthd.Tables["CTHoaDonBanHang"];

            // Kết nối bảng PhieuNhapHang
            DataSet dsHDBanHang = new DataSet();
            adp2.Fill(dsHDBanHang, "HoaDonBanHang");

            ReportDataSource rdsHDBH = new ReportDataSource();
            rdsHDBH.Name = "DataSet2";
            rdsHDBH.Value = dsHDBanHang.Tables["HoaDonBanHang"];

            string sql3 = "SELECT KhachHangThanThiet.HoTen FROM KhachHangThanThiet " +
               "INNER JOIN HoaDonBanHang ON KhachHangThanThiet.MaThe = HoaDonBanHang.MaKHTT " +
               "WHERE HoaDonBanHang.SoHoaDon = '" + soHoaDon.ToString() + "'";
            SqlDataAdapter adp3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adp3.Fill(ds3);
            ReportDataSource rdsTenKH = new ReportDataSource();
            rdsTenKH.Name = "DataSet3";
            rdsTenKH.Value = ds3.Tables[0];

            string sql4 = "SELECT HangHoa.TenHang FROM HangHoa " +
              "INNER JOIN CTHoaDonBanHang ON HangHoa.MaHang = CTHoaDonBanHang.MaHang " +
              "WHERE CTHoaDonBanHang.SoHoaDon = '" + soHoaDon.ToString() + "'";
            SqlDataAdapter adp4 = new SqlDataAdapter(sql4, con);
            DataSet ds4 = new DataSet();
            adp4.Fill(ds4);

            // Tạo một ReportDataSource cho tên hàng hóa
            ReportDataSource rdsTenHang = new ReportDataSource();
            rdsTenHang.Name = "DataSet4";
            rdsTenHang.Value = ds4.Tables[0];

            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            reportViewer1.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer1.LocalReport.DataSources.Add(rdsCTHD);
            reportViewer1.LocalReport.DataSources.Add(rdsHDBH);
            reportViewer1.LocalReport.DataSources.Add(rdsTenKH);
            reportViewer1.LocalReport.DataSources.Add(rdsTenHang);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
