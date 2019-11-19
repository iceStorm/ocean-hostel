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

namespace GUI
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string[] skinsToHide = { "2010", "Sharp", "2007", "2013", "Visual Studio",
                                           "Blueprint", "Whiteprint", "Pumpkin", "Coffee", "Caramel",
                                           "Xmas", "Stardust", "The Asphalt World", "High Contrast",
                                           "Metropolis", "Liquid", "Dark Side", "Valentine", "Lilian",
                                           "Glass Oceans", "Money Twins"};
        private Timer timer_open;

        public fMain()
        {
            InitializeComponent();
            SetFormSize();

            this.Opacity = 0;
            this.timer_open = new Timer();
            this.timer_open.Interval = 1;
            this.timer_open.Tick += timer_Tick;
            this.timer_open.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;

            if (this.Opacity >= 1)
                this.timer_open.Stop();
        }

        private void SetFormSize()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;    //  Lấy chiều rộng của màn hình
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;  //  Lấy chiều cao của màn hình

            this.Width = screenWidth - 50;
            this.Height = screenHeight - 50;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            HideSkins(skinsToHide);


            this.txt_date.Caption = DateTime.Today.ToLongDateString();
            this.txt_time.Caption = DateTime.Today.ToLongTimeString();


            fDashboard FormDashboard = new fDashboard();
            FormDashboard.MdiParent = this;
            FormDashboard.Show();
        }

        private void HideSkins(string[] skinsToHide)
        {
            for (var i = 0; i < skinRibbonGalleryBarItem1.Gallery.Groups.Count; i++)
            {
                var group = skinRibbonGalleryBarItem1.Gallery.Groups[i];


                if (group == null)
                    continue;


                for (var j = 0; j < group.Items.Count; j++)
                {
                    var item = group.Items[j];

                    if (item == null)
                        continue;

                    foreach (var skin in skinsToHide)
                        if (item.Caption.Contains(skin))
                            item.Visible = false;
                }
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form childForm in this.MdiChildren)
                if (childForm.Name == "f")
                {
                    childForm.Activate();
                    return;
                }

            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;
            f.BackColor = Color.Crimson;
            f.Name = "f";
            f.MdiParent = this;
            f.Text = "Tabbed Child Form";
            f.Show();
        }

        private void pn_seperator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
                if (childForm.Name == "fDashboard")
                {
                    childForm.Activate();
                    return;
                }

            fDashboard FormDashboard = new fDashboard();
            FormDashboard.MdiParent = this;
            FormDashboard.Show();
        }


    }
}