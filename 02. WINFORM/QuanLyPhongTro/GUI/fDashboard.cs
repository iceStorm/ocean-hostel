using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AnimatorNS;

namespace GUI
{
    public partial class fDashboard : DevExpress.XtraEditors.XtraForm
    {

        private Timer timer_open;
        private AnimatorNS.Animator animator;


        public fDashboard()
        {
            InitializeComponent();
            HideControls();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.animator = new Animator();
            this.animator.AnimationType = AnimationType.Transparent;
            this.animator.Interval = 1;


            this.timer_open = new Timer();
            this.timer_open.Interval = 1;
            this.timer_open.Tick += timer_open_Tick;

            LoadGauges();
        }

        private void timer_open_Tick(object sender, EventArgs e)
        {
            if (bunifuRadialGauge1.Value == 75)
            {
                this.timer_open.Stop();
                return;
            }

            this.bunifuRadialGauge1.Value += 1;
        }

        private void fDashboard_Load(object sender, EventArgs e)
        {

        }

        private async void LoadGauges()
        {
            animator.Show(bunifuRadialGauge1, true);
            animator.Show(label1, true, Animation.VertSlide);
            this.bunifuRadialGauge1.Value = 0;

            await Task.Delay(750);
            this.timer_open.Start();
        }

        private void HideControls()
        {
            this.label1.Visible = false;
        }

    }
}