namespace GUI
{
    partial class fChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart_thietBi = new DevExpress.XtraCharts.ChartControl();
            this.chart_test = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_test)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_thietBi
            // 
            this.chart_thietBi.Legend.Name = "Default Legend";
            this.chart_thietBi.Location = new System.Drawing.Point(34, 27);
            this.chart_thietBi.Name = "chart_thietBi";
            this.chart_thietBi.PaletteName = "Flow";
            this.chart_thietBi.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart_thietBi.Size = new System.Drawing.Size(486, 235);
            this.chart_thietBi.TabIndex = 10;
            // 
            // chart_test
            // 
            this.chart_test.Legend.Name = "Default Legend";
            this.chart_test.Location = new System.Drawing.Point(34, 290);
            this.chart_test.Name = "chart_test";
            this.chart_test.PaletteName = "Metro";
            this.chart_test.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart_test.Size = new System.Drawing.Size(486, 196);
            this.chart_test.TabIndex = 11;
            // 
            // fChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 513);
            this.Controls.Add(this.chart_test);
            this.Controls.Add(this.chart_thietBi);
            this.Name = "fChart";
            this.Text = "Biểu đồ";
            this.Load += new System.EventHandler(this.fReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_thietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart_thietBi;
        private DevExpress.XtraCharts.ChartControl chart_test;


    }
}