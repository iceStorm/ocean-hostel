using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using BLL;
using DTO;
using AnimatorNS;

namespace GUI
{
    public partial class fChart : DevExpress.XtraEditors.XtraForm
    {
        public fChart()
        {
            InitializeComponent();
            this.chart_thietBi.Hide();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            ShowEquipmentsChart();
            ShowTestChart();
        }

        private async void ShowEquipmentsChart()
        {
            DataTable dt = BLL_THIETBI.LayDanhSachThietBi();

            // Create two stacked bar series. 
            Series series1 = new Series("Số lượng tồn", ViewType.StackedBar);
            Series series2 = new Series("Số lượng phân bổ", ViewType.StackedBar);

            StackedBarSeriesView view = series1.View as StackedBarSeriesView;
            view.Animation = new BarGrowUpAnimation();


            // Add points to them 
            foreach (DataRow dr in dt.Rows)
            {
                series1.Points.Add(new SeriesPoint((string)dr["TENTBI"], (int)dr["SOLG_TON"]));
                series2.Points.Add(new SeriesPoint((string)dr["TENTBI"], (int)dr["SOLG_PHANBO"]));
            }

            // Add both series to the chart. 
            this.chart_thietBi.Series.AddRange(new Series[] { series1, series2 });

            // Access the type-specific options of the diagram. 
            ((XYDiagram)this.chart_thietBi.Diagram).EnableAxisXZooming = false;
            ((XYDiagram)(this.chart_thietBi.Diagram)).Rotated = true;

            // Add a title to the chart (if necessary). 
            this.chart_thietBi.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart_thietBi.Titles.Add(new ChartTitle());
            this.chart_thietBi.Titles[0].Text = "Số lượng thiết bị";

            
            AnimatorNS.Animator anm = new Animator();
            anm.Show(this.chart_thietBi, true, Animation.Scale);
        }


        private void ShowTestChart()
        {
            // Create the first side-by-side bar series and add points to it. 
            Series series1 = new Series("", ViewType.Bar);

            DataTable dt = BLL_LOAIPHONG.LayDuLieuThongKe();
            foreach (DataRow dr in dt.Rows)
            {
                series1.Points.Add(new SeriesPoint((string)dr["TENLOAIPHG"], (int)dr["SOLG"]));
            }

            // Add the series to the chart. 
            chart_test.Series.Add(series1);

            // Hide the legend (if necessary). 
            chart_test.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Rotate the diagram (if necessary). 
            ((XYDiagram)chart_test.Diagram).Rotated = true;

            // Add a title to the chart (if necessary). 
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "XU HƯỚNG LOẠI PHÒNG";
            chart_test.Titles.Add(chartTitle1);
        }

    }
}
