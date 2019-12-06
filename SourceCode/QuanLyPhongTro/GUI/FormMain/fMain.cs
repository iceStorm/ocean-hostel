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
using System.Threading;
using DevExpress.XtraCharts;

namespace GUI
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string[] skinsToHide = { "2010", "Sharp", "2007", "2013", "Visual Studio",
                                           "Blueprint", "Whiteprint", "Pumpkin", "Coffee", "Caramel",
                                           "Xmas", "Stardust", "The Asphalt World", "High Contrast",
                                           "Metropolis", "Liquid", "Dark Side", "Valentine", "Lilian",
                                           "Glass Oceans", "Money Twins"};

        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_hour;
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

            this.Opacity = 0;
            this.timer_open = new System.Windows.Forms.Timer();
            this.timer_open.Interval = 1;
            this.timer_open.Tick += timer_Tick;
            this.timer_open.Start();

            this.timer_hour = new System.Windows.Forms.Timer();
            this.timer_hour.Interval = 1000;
            this.timer_hour.Tick += timer_hour_Tick;
            this.timer_hour.Start();
        }

        private void timer_hour_Tick(object sender, EventArgs e)
        {
            this.txt_time.Caption = DateTime.Now.ToShortTimeString();
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

            fWelcome FormWelcome = new fWelcome(this.nguoiDung);
            FormWelcome.MdiParent = this;
            FormWelcome.Show();
        }


        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            DialogResult dr = XtraMessageBox.Show("Xác nhận thoát ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                e.Cancel = true;*/
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


        #region DỊCH VỤ

        private void btn_danhMucDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fDanhMucDichVu")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormDichVu = new ChildrenForms.DichVu.DanhMucDichVu.fDanhMucDichVu();
            FormDichVu.MdiParent = this;
            FormDichVu.Show();
        }

        private void btn_dichVuMoiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fDichVuMoiPhong")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormDichVuPhong = new ChildrenForms.DichVu.DichVuMoiPhong.fDichVuMoiPhong();
            FormDichVuPhong.MdiParent = this;
            FormDichVuPhong.Show();
        }

        #endregion


        #region HOÁ ĐƠN

        private void btn_danhSachHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fDanhSachHoaDon")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormHoaDon = new ChildrenForms.HoaDonChiTieu.DanhSachHoaDon.fDanhSachHoaDon();
            FormHoaDon.MdiParent = this;
            FormHoaDon.Show();
        }

        private void btn_nhapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm FormThemHoaDon = new ChildrenForms.HoaDonChiTieu.DanhSachHoaDon.fThemHoaDon();
            FormThemHoaDon.ShowDialog();
        }

        #endregion


        #region KHÁCH TRỌ
        
        private void btn_khachTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fKhach")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormKhach = new ChildrenForms.KhachTro.DanhSachKhach.fKhach();
            FormKhach.MdiParent = this;
            FormKhach.Show();
        }

        #endregion


        #region NỘI QUY
        
        private void btn_noiQuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fViPham")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormNoiQuy = new GUI.ChildrenForms.QuanLyViPham.ViPham.fViPham();
            FormNoiQuy.MdiParent = this;
            FormNoiQuy.Show();
        }

        private void btn_danhSachViPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fKhachViPham")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormViPham = new GUI.ChildrenForms.QuanLyViPham.KhachViPham.fKhachViPham();
            FormViPham.MdiParent = this;
            FormViPham.Show();
        }

        #endregion


        #region HỢP ĐỒNG
        
        private void btn_danhSachHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fHopDong")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormHopDong = new GUI.ChildrenForms.KhachTro.HopDong.fDanhSachHopDong();
            FormHopDong.MdiParent = this;
            FormHopDong.Show();
        }

        private void btn_themHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm FormThemHopDong = new GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong();
            FormThemHopDong.ShowDialog();
        }

        #endregion

        private void rib_main_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread thr = new Thread(DangXuat);
            this.Close();
            thr.Start();
        }

        private void DangXuat()
        {
            XtraForm FormDangNhap = new fLogin();
            FormDangNhap.ShowDialog();
        }

        private void btn_doiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm FormDoiMatKhau = new ChildrenForms.HeThong.fDoiMatKhau(this.nguoiDung);
            FormDoiMatKhau.ShowDialog();
        }


        private void btn_bieuDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraForm childForm in this.MdiChildren)
                if (childForm.Name == "fChart")
                {
                    childForm.Activate();
                    return;
                }

            XtraForm FormBieuDo = new fChart();
            FormBieuDo.MdiParent = this;
            FormBieuDo.Show();
        }

        private void btn_thongTinTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm FormThongTinTaiKhoan = new ChildrenForms.HeThong.fXemThongTinTaiKhoan(this.nguoiDung);
            FormThongTinTaiKhoan.ShowDialog();
        }



    }
}