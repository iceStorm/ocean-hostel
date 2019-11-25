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
using DTO;
using BLL;

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
        private DTO_NGUOIDUNG nguoiDung;

        public fMain(DTO_NGUOIDUNG nguoiDung = null)
        {
            if (nguoiDung != null)
                this.nguoiDung = nguoiDung;
            else
                this.nguoiDung = new DTO_NGUOIDUNG
                {
                    Ho = "",
                    Ten = ""
                };


            InitializeComponent();
            SetFormSize();

            //this.rib_main.Minimized = true;

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
            this.txt_tenNhanVien.Caption = String.Format("{0} {1}", nguoiDung.Ho, nguoiDung.Ten);


            //fDashboard FormDashboard = new fDashboard();
            //FormDashboard.MdiParent = this;
            //FormDashboard.Show();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Xác nhận thoát ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                e.Cancel = true;
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



        #region QUẢN LÝ PHÒNG
        private void btn_dayNha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fDayNha")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormDayNha = new ChildrenForms.QuanLyPhong.fDayNha();
            FormDayNha.MdiParent = this;
            FormDayNha.Show();
        }

        private void btn_tang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fTang")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormTang = new ChildrenForms.QuanLyPhong.fTang();
            FormTang.MdiParent = this;
            FormTang.Show();
        }

        private void btn_loaiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fLoaiPhong")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormLoaiPhong = new ChildrenForms.QuanLyPhong.LoaiPhong.fLoaiPhong();
            FormLoaiPhong.MdiParent = this;
            FormLoaiPhong.Show();
        }

        private void btn_phong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fPhong")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormPhong = new ChildrenForms.QuanLyPhong.fPhong();
            FormPhong.MdiParent = this;
            FormPhong.Show();
        }
        #endregion


        #region HỆ THỐNG
        private void btn_dashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_lichSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion


        #region THIẾT BỊ
        
        private void btn_thietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fDanhMucThietBi")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormThietBi = new ChildrenForms.QuanLyThietBi.DanhMucThietBi.fDanhMucThietBi();
            FormThietBi.MdiParent = this;
            FormThietBi.Show();
        }
        private void btn_phanBoThietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fPhanBoThietBi")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormPhanBoThietBi = new ChildrenForms.QuanLyThietBi.PhanBoThietBi.fPhanBoThietBi();
            FormPhanBoThietBi.MdiParent = this;
            FormPhanBoThietBi.Show();
        }

        #endregion



    }
}