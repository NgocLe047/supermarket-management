using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAO;
namespace Nhom5_QuanLySieuThi.GUI
{
    public partial class frmThongKe : Form
    {
        QLSTDataContext qlst = new QLSTDataContext();
        ThongKeBLL tk = new ThongKeBLL();
        public frmThongKe()
        {
            InitializeComponent();
          
        }
        private void FormatChartAxis()
        {
            // Định dạng trục Y để hiển thị giá trị theo triệu đồng
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.##}M";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (triệu VNĐ)";

            // Nếu bạn muốn thay đổi tooltip cũng để hiển thị triệu đồng, bạn có thể thêm:
            foreach (var series in chartRevenue.Series)
            {
                series.ToolTip = "#VALX tháng: #VALY triệu VNĐ";
            }
        }
        private void getDoanhThuNam()
        {
            if (cboNam.SelectedItem != null)
            {
               
                int nam;
                if (int.TryParse(cboNam.SelectedItem.ToString(), out nam))
                {
                    chartRevenue.Series.Clear();
                    chartRevenue.Series.Add("Doanh thu");
                    HoaDonBanHang HopDong = new HoaDonBanHang();

                    HopDong.NgayLap = new DateTime(nam, 1, 1);

                    var dataTable = tk.ThongKeDoanhThuNam(HopDong).AsEnumerable();

                    var doanhThuData = dataTable.Select(row => new
                    {
                        Thang = row.Field<int>("Tháng"),
                        ThanhTien = row.Field<decimal>("Thành tiền") / 1000000 
                    }).ToList();

                    chartRevenue.DataSource = doanhThuData;
   
                    chartRevenue.Series[0].XValueMember = "Thang";
                    chartRevenue.Series[0].YValueMembers = "ThanhTien";
                    chartRevenue.Series[0].ChartType = SeriesChartType.Column;

                    chartRevenue.Series.Add(".");
                    chartRevenue.Series[1].XValueMember = "Thang";
                    chartRevenue.Series[1].YValueMembers = "ThanhTien";
                    chartRevenue.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
                    chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
                    chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                    chartRevenue.Series["Doanh thu"].Color = Color.SlateBlue;
                    chartRevenue.Series["."].Color = Color.FromArgb(0, 255, 255, 255);
                    chartRevenue.Series[0].Color = Color.SlateBlue;
                    chartRevenue.Series[1].Color = Color.FromArgb(0, 255, 255, 255);
                    chartRevenue.Series[1].BorderWidth = 3;
                    chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
                    chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
                    chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                    FormatChartAxis();
                }
            }
            else
            {
                MessageBox.Show("Lỗi thống kê doanh thu");
                return;
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("Doanh thu");

            HoaDonBanHang Hd = new HoaDonBanHang();
            Hd.NgayLap = new DateTime(2023, 1, 1);

            var doanhThuData = tk.ThongKeDoanhThuNam(Hd).AsEnumerable();

            chartRevenue.DataSource = doanhThuData.ToList();

            chartRevenue.Series[0].XValueMember = "Tháng";
            chartRevenue.Series[0].YValueMembers = "Thành tiền";
            chartRevenue.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartRevenue.Series.Add(".");
            chartRevenue.Series[1].XValueMember = "Tháng";
            chartRevenue.Series[1].YValueMembers = "Thành tiền";
            chartRevenue.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartRevenue.Series["Doanh thu"].Color = Color.SlateBlue;
            chartRevenue.Series["."].Color = Color.FromArgb(0, 255, 255, 255);
            chartRevenue.Series[0].Color = Color.SlateBlue;
            chartRevenue.Series[1].Color = Color.FromArgb(0, 255, 255, 255);
            chartRevenue.Series[1].BorderWidth = 3;
            chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;

          

            cboNam.Items.Add("-- Chọn năm --");
            cboNam.SelectedIndex = 0;
            for (int a = 2021; a < 2024; a++)
            {
                cboNam.Items.Add(a);
            }
            cboNam.SelectedIndex = 3;
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDoanhThuNam();
        }
    }
}
