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
using BLL;
using DTO;

namespace GUI.ChildrenForms.HoaDonChiTieu.DanhSachHoaDon
{
    public partial class fThemHoaDon : DevExpress.XtraEditors.XtraForm
    {
        int tongTien = 0;
        int tienPhong = 0;
        int tienDichVu = 0;
        int tienDien = 0;
        int tienNuoc = 0;
        int cbPhong_lastSelectedIndex = -1;

        public fThemHoaDon()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemHoaDon_Load(object sender, EventArgs e)
        {
            this.cb_khu.Items.AddRange(BLL_KHU.LayDanhSachTenKhu());
            SetMonthYear();
            LoadGiaDienNuoc();
        }

        private void SetMonthYear()
        {
            int thang = DateTime.Today.Month;
            int nam = DateTime.Today.Year;

            this.lb_thangNam.Text = String.Format("Tháng {0:d2} - {1}", thang, nam);
        }

        private void LoadGiaDienNuoc()
        {
            DataTable dt = BLL_DICHVU.LayThongTinDienNuoc();

            this.lb_giaDien.Text = String.Format("{0:#,##0}", dt.Rows[0]["GIADICHVU"]);
            this.lb_giaNuoc.Text = String.Format("{0:#,##0}", dt.Rows[1]["GIADICHVU"]);
        }

        private void cb_khu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_KHU khu = new DTO_KHU();
            khu.TenKhu = this.cb_khu.Text;

            this.cb_tang.SelectedIndex = -1;
            this.cb_phong.SelectedIndex = -1;
            this.cb_tang.Items.Clear();
            this.cb_phong.Items.Clear();

            this.cb_tang.Items.AddRange(BLL_TANG.LayDanhSachTenTang_TheoTenKhu(khu));
        }

        private void cb_tang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_KHU khu = new DTO_KHU();
            khu.TenKhu = this.cb_khu.Text;
            khu.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);

            DTO_TANG tang = new DTO_TANG();
            tang.TenTang = this.cb_tang.Text;
            tang.MaTang = BLL_TANG.LayMaTang_TheoTenTang_MaKhu(tang, khu);

            this.cb_phong.SelectedIndex = -1;
            this.cb_phong.Items.Clear();
            this.cb_phong.Items.AddRange(BLL_PHONG.LayDanhSachTenPhongTheoMaTang(tang));
        }

        private void cb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_phong.SelectedIndex != this.cbPhong_lastSelectedIndex)
            {
                this.cbPhong_lastSelectedIndex = this.cb_phong.SelectedIndex;
            }
            else
            {
                return;
            }


            ResetForm();

            int thang = DateTime.Today.Month;
            int nam = DateTime.Today.Year;


            DTO_PHONG phong = new DTO_PHONG();
            phong.TenPhong = this.cb_phong.Text;
            phong.MaPhong = BLL_PHONG.LayMaPhongTheoTenPhong(phong);

            DTO_HOADON hoaDon = new DTO_HOADON
            {
                MaPhong = phong.MaPhong,
                Thang = thang,
                Nam = nam
            };



            try
            {
                if (this.cb_phong.SelectedIndex >= 0)
                    if (BLL_HOADON.PhongDaGhiHoaDon(hoaDon) == true)
                    {
                        XtraMessageBox.Show("Phòng đã ghi hoá đơn tháng này !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.cb_phong.SelectedIndex = -1;
                        this.btn_luuVaNhap.Enabled = false;
                        this.btn_luuVaThoat.Enabled = false;
                        this.num_soDienMoi.Enabled = false;
                        this.num_soNuocMoi.Enabled = false;
                    }
                    else
                    {
                        this.btn_luuVaNhap.Enabled = true;
                        this.btn_luuVaThoat.Enabled = true;
                        this.num_soDienMoi.Enabled = true;
                        this.num_soNuocMoi.Enabled = true;


                        DataTable dt = BLL_PHONG.LayThongTinLoaiPhongTheoTenPhong(phong);
                        this.lb_loaiPhong.Text = (string)dt.Rows[0]["TENLOAIPHG"];
                        int giaPhong = (int)dt.Rows[0]["GIAPHG"];
                        this.lb_giaPhong.Text = String.Format("{0:#,##0}", giaPhong);
                        this.lb_loaiPhong.Visible = true;
                        this.lb_giaPhong.Visible = true;

                        this.tienPhong = giaPhong;
                        SetTotal();


                        DTO_HOADON_DIENNUOC hdn = BLL_HOADON_DIENNUOC.LayThongTinThangTruoc(hoaDon);
                        this.txt_soDienCu.Text = hdn.SoDien.ToString();
                        this.txt_soNuocCu.Text = hdn.SoNuoc.ToString();


                        DataTable listServices = BLL_DICHVU_PHONG.LayDanhSachDichVuKhacTheoMaPhong(phong);
                        this.gridControl_dichVuPhong.DataSource = listServices;
                        this.gridView_dichVuPhong.Columns["MAPHG"].Visible = false;
                        this.gridView_dichVuPhong.Columns["MADICHVU"].Visible = false;
                        this.gridView_dichVuPhong.Columns["TENDICHVU"].Caption = "Tên dịch vụ";
                        this.gridView_dichVuPhong.Columns["TENDICHVU"].VisibleIndex = 0;
                        this.gridView_dichVuPhong.Columns["GIADICHVU"].Caption = "Giá dịch vụ";
                        this.gridView_dichVuPhong.Columns["GIADICHVU"].VisibleIndex = 1;
                        this.gridView_dichVuPhong.Columns["NGAYDANGKY"].Caption = "Ngày đăng ký";
                        this.gridView_dichVuPhong.Columns["NGAYDANGKY"].VisibleIndex = 2;
                        this.gridView_dichVuPhong.Columns["BATBUOC"].Caption = "Bắt buộc";

                        if (listServices.Rows.Count > 0)
                        {
                            int sum = 0;

                            foreach (DataRow dr in listServices.Rows)
                                sum += (int)dr["GIADICHVU"];

                            this.lb_tongTienDichVu.Visible = true;
                            this.lb_tongTienDichVu.Text = String.Format("{0:#,##0}", sum);

                            this.tienDichVu = sum;
                            SetTotal();
                        }
                    }
                else
                {
                    this.btn_luuVaNhap.Enabled = false;
                    this.btn_luuVaThoat.Enabled = false;
                    this.num_soDienMoi.Enabled = false;
                    this.num_soNuocMoi.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void num_soDienMoi_EditValueChanged(object sender, EventArgs e)
        {
            int soDienTieuThu = (int)this.num_soDienMoi.Value - int.Parse(txt_soDienCu.Text);
            this.txt_soDienTieuThu.Text = soDienTieuThu.ToString();

            int tongTienDien = soDienTieuThu * (int.Parse(Str.Remove(this.lb_giaDien.Text, ',')));
            this.tienDien = tongTienDien;
            SetTotal();

            this.lb_tongTienDien.Visible = true;
            this.lb_tongTienDien.Text = String.Format("{0:#,##0}", tongTienDien);
        }

        private void num_soNuocMoi_EditValueChanged(object sender, EventArgs e)
        {
            int soNuocTieuThu = (int)this.num_soNuocMoi.Value - int.Parse(txt_soNuocCu.Text);
            this.txt_soNuocTieuThu.Text = soNuocTieuThu.ToString();

            int tongTienNuoc = soNuocTieuThu * (int.Parse(Str.Remove(this.lb_giaNuoc.Text, ',')));
            this.tienNuoc = tongTienNuoc;
            SetTotal();

            this.lb_tongTienNuoc.Visible = true;
            this.lb_tongTienNuoc.Text = String.Format("{0:#,##0}", tongTienNuoc);
        }


        private void SetTotal()
        {
            this.tongTien = this.tienPhong + this.tienDichVu + this.tienDien + this.tienNuoc;

            this.lb_tongTien.Text = String.Format("{0:#,##0} đ", this.tongTien);
            this.lb_tienBangChu.Text = Reader.ReadNumber((decimal)this.tongTien);
        }

        private void ResetForm()
        {
            this.lb_loaiPhong.Visible = false;
            this.lb_giaPhong.Visible = false;
            this.lb_tongTienDichVu.Visible = false;
            this.lb_tongTienNuoc.Visible = false;
            this.lb_tongTienDien.Visible = false;

            this.num_soDienMoi.Value = 0;
            this.num_soNuocMoi.Value = 0;

            this.txt_soDienCu.Text = "–";
            this.txt_soNuocCu.Text = "–";
            this.txt_soDienTieuThu.Text = "–";
            this.txt_soNuocTieuThu.Text = "–";

            this.tienDichVu = 0;
            this.tienPhong = 0;
            this.tienDien = 0;
            this.tienNuoc = 0;
            SetTotal();

            this.gridControl_dichVuPhong.DataSource = null;
        }


        private bool LuuHoaDon()
        {
            if ((int)this.num_soDienMoi.Value < (int.Parse(this.txt_soDienCu.Text)))
            {
                XtraMessageBox.Show("Số điện mới không hợp lệ !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if ((int)this.num_soNuocMoi.Value < (int.Parse(this.txt_soNuocCu.Text)))
                {
                    XtraMessageBox.Show("Số nước mới không hợp lệ !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DTO_PHONG phong = new DTO_PHONG();
                    phong.TenPhong = this.cb_phong.Text;
                    phong.MaPhong = BLL_PHONG.LayMaPhongTheoTenPhong(phong);

                    DTO_HOADON hoaDon = new DTO_HOADON
                    {
                        MaPhong = phong.MaPhong,
                        Thang = DateTime.Today.Month,
                        Nam = DateTime.Today.Year
                    };

                    DTO_HOADON_DIENNUOC hoaDonDienNuoc = new DTO_HOADON_DIENNUOC
                    {
                        SoDien = (int)this.num_soDienMoi.Value,
                        SoNuoc = (int)this.num_soNuocMoi.Value
                    };


                    try
                    {
                        if (BLL_HOADON.ThemHoaDon(hoaDon, hoaDonDienNuoc) == true)
                        {
                            XtraMessageBox.Show("Ghi hoá đơn thành công !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            return false;
        }

        private void btn_luuVaThoat_Click(object sender, EventArgs e)
        {
            if (LuuHoaDon() == true)
                this.Close();
        }

        private void btn_luuVaNhap_Click(object sender, EventArgs e)
        {
            if (LuuHoaDon() == true)
            {
                ResetForm();

                this.cb_khu.SelectedIndex = -1;
                this.cb_tang.SelectedIndex = -1;
                this.cb_phong.SelectedIndex = -1;
            }
        }

    }
}