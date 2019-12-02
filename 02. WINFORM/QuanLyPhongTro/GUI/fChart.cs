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
            this.chartControl.Hide();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            ShowEquipmentsChart();
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
            this.chartControl.Series.AddRange(new Series[] { series1, series2 });

            // Access the type-specific options of the diagram. 
            ((XYDiagram)this.chartControl.Diagram).EnableAxisXZooming = false;
            ((XYDiagram)(this.chartControl.Diagram)).Rotated = true;

            // Add a title to the chart (if necessary). 
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.Titles.Add(new ChartTitle());
            this.chartControl.Titles[0].Text = "Số lượng thiết bị";

            
            AnimatorNS.Animator anm = new Animator();
            anm.Show(this.chartControl, true, Animation.Scale);
        }


    }
}
