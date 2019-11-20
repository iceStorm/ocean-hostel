namespace GUI
{
    partial class fDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDashboard));
            this.bunifuRadialGauge1 = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuRadialGauge1
            // 
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuRadialGauge1.LighteningFactor = 70;
            this.bunifuRadialGauge1.Location = new System.Drawing.Point(215, 103);
            this.bunifuRadialGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuRadialGauge1.Name = "bunifuRadialGauge1";
            this.bunifuRadialGauge1.Prefix = "";
            this.bunifuRadialGauge1.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressHighValueMark = 70;
            this.bunifuRadialGauge1.RangeEnd = 100;
            this.bunifuRadialGauge1.RangeLabelsColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRadialGauge1.RangeStart = 0;
            this.bunifuRadialGauge1.ShowRangeLabels = true;
            this.bunifuRadialGauge1.ShowValueLabel = true;
            this.bunifuRadialGauge1.Size = new System.Drawing.Size(174, 117);
            this.bunifuRadialGauge1.Suffix = "%";
            this.bunifuRadialGauge1.TabIndex = 0;
            this.bunifuRadialGauge1.Thickness = 30;
            this.bunifuRadialGauge1.Value = 0;
            this.bunifuRadialGauge1.ValueByTransition = 0;
            this.bunifuRadialGauge1.ValueLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh thu";
            // 
            // bunifuGradientPanel1
            // 
            //this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuRadialGauge1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(598, 367);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 367);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "fDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.fDashboard_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}