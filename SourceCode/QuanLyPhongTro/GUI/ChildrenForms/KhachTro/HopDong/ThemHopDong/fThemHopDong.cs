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
using DevExpress.XtraGrid.Views.Grid;

namespace GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong
{
    public partial class fThemHopDong : DevExpress.XtraEditors.XtraForm
    {
        public static bool isUpdated = false;
        public static bool isAdded = false;
        public static DTO_KHACH khachTro;

        public fThemHopDong()
        {
            InitializeComponent();
            khachTro = new DTO_KHACH();
        }

        private void fThemHopDong_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }


        private void LoadPhong()
        {
            this.cb_phong.DataSource = BLL_PHONG.LayDanhSachPhongConTrong();
            this.cb_phong.DisplayMember = "TENPHG";
            this.cb_phong.ValueMember = "MAPHG";
            BindData();
        }

        private void BindData()
        {
            this.lb_giaPhong.DataBindings.Add("Text", this.cb_phong.DataSource, "GIAPHG", true, DataSourceUpdateMode.Never, "", "#,##0");
            this.lb_loaiPhong.DataBindings.Add("Text", this.cb_phong.DataSource, "TENLOAIPHG");
            this.lb_soLuongToiDa.DataBindings.Add("Text", this.cb_phong.DataSource, "SOLG_TOIDA");
            this.lb_soLuongDangO.DataBindings.Add("Text", this.cb_phong.DataSource, "SOLG_DANGO");
        }

        private void UnBindData()
        {
            this.lb_giaPhong.DataBindings.Clear();
            this.lb_loaiPhong.DataBindings.Clear();
            this.lb_soLuongToiDa.DataBindings.Clear();
            this.lb_soLuongDangO.DataBindings.Clear();
        }

        private void dgv_thongTinKhach_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgv_thongTinKhach.RowCount == 0)   //  Nếu xoá hết dòng
            {
                this.btn_tao.Enabled = false;
                this.btn_chinhSua.Enabled = false;
            }
            else
            {
                this.btn_tao.Enabled = true;
                this.btn_chinhSua.Enabled = true;
            }

            LoadBalance();
        }


        private List<DTO_KHACH> LayDanhSachKhach()
        {
            List<DTO_KHACH> listKhach = new List<DTO_KHACH>();


            foreach (DataGridViewRow dr in this.dgv_thongTinKhach.Rows)
                listKhach.Add(new DTO_KHACH
                {
                    MaKhach = (string)dr.Cells["MAKHACH"].Value,
                    Ho = (string)dr.Cells["HO"].Value,
                    Ten = (string)dr.Cells["TEN"].Value,
                    GioiTinh = (string)dr.Cells["GIOITINH"].Value,
                    NgaySinh = DateTime.Parse(dr.Cells["NGAYSINH"].Value.ToString()),
                    QueQuan = (string)dr.Cells["QUEQUAN"].Value,
                    SoCanCuoc = (string)dr.Cells["CANCUOC"].Value,
                    SoDienThoai = (string)dr.Cells["DIENTHOAI"].Value
                });

            return listKhach;
        }


        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = this.dgv_thongTinKhach.CurrentRow;
            khachTro.Ho = (string)dr.Cells["HO"].Value;
            khachTro.Ten = (string)dr.Cells["TEN"].Value;
            khachTro.GioiTinh = (string)dr.Cells["GIOITINH"].Value;
            khachTro.NgaySinh = DateTime.Parse(dr.Cells["NGAYSINH"].Value.ToString());
            khachTro.QueQuan = (string)dr.Cells["QUEQUAN"].Value;
            khachTro.SoCanCuoc = (string)dr.Cells["CANCUOC"].Value;
            khachTro.SoDienThoai = (string)dr.Cells["DIENTHOAI"].Value;


            List<DTO_KHACH> listKhach = LayDanhSachKhach();
            foreach (DTO_KHACH kh in listKhach)
                if (kh.SoCanCuoc == khachTro.SoCanCuoc)
                {
                    listKhach.Remove(kh);
                    break;
                }

            XtraForm FormThemKhach = new ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemThongTinKhach(listKhach, false, khachTro);
            FormThemKhach.ShowDialog();


            if (isUpdated == true)
            {
                dr.Cells["HO"].Value = khachTro.Ho;
                dr.Cells["TEN"].Value = khachTro.Ten;
                dr.Cells["GIOITINH"].Value = khachTro.GioiTinh;
                dr.Cells["NGAYSINH"].Value = khachTro.NgaySinh.ToShortDateString();
                dr.Cells["QUEQUAN"].Value = khachTro.QueQuan;
                dr.Cells["CANCUOC"].Value = khachTro.SoCanCuoc;
                dr.Cells["DIENTHOAI"].Value = khachTro.SoDienThoai;

                isUpdated = false;
            }
        }

        private void btn_themKhachMoi_Click(object sender, EventArgs e)
        {
            XtraForm FormThemKhach = new ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemThongTinKhach(LayDanhSachKhach(), true);
            FormThemKhach.ShowDialog();

            if (isAdded == true)
            {
                this.dgv_thongTinKhach.Rows.Add
                (
                    khachTro.MaKhach,
                    khachTro.Ho,
                    khachTro.Ten,
                    khachTro.GioiTinh,
                    khachTro.NgaySinh.ToShortDateString(),
                    khachTro.QueQuan,
                    khachTro.SoCanCuoc,
                    khachTro.SoDienThoai
                );


                isAdded = false;
                this.btn_tao.Enabled = true;
            }
        }

        private void btn_chonKhachCu_Click(object sender, EventArgs e)
        {
            List<DTO_KHACH> listKhach = LayDanhSachKhach();
            XtraForm FormChonKhachCu = new ChildrenForms.KhachTro.HopDong.ThemHopDong.fChonKhachCu(listKhach);
            FormChonKhachCu.ShowDialog();


            if (isAdded == true)
            {
                this.dgv_thongTinKhach.Rows.Add
                (
                    khachTro.MaKhach,
                    khachTro.Ho,
                    khachTro.Ten,
                    khachTro.GioiTinh,
                    khachTro.NgaySinh.ToShortDateString(),
                    khachTro.QueQuan,
                    khachTro.SoCanCuoc,
                    khachTro.SoDienThoai
                );

                isAdded = false;
            }
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            if (this.num_thoiHan.Value <= 0)
            {
                XtraMessageBox.Show("Thời hạn không hợp lệ !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.num_thoiHan.Focus();
                return;
            }


            DTO_HOPDONG hopDong = new DTO_HOPDONG()
            {
                MaHopDong = (string)BLL_HOPDONG.LayMaHopDongTiepTheo(),
                MaPhong = this.cb_phong.SelectedValue.ToString(),
                TienCoc = (int)this.num_tienCoc.Value,
                ThoiHan = (int)this.num_thoiHan.Value
            };


            try         //  INSERT TO HOPDONG
            {
                if (BLL_HOPDONG.ThemHopDong(hopDong) == true)
                {
                    XtraMessageBox.Show("Thêm hợp đồng thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    List<DTO_KHACH> listKhach = LayDanhSachKhach();
                    foreach (DTO_KHACH kh in listKhach)
                    {
                        if (kh.MaKhach == null)     //  Khách mới chưa có mã
                        {
                            kh.MaKhach = BLL_KHACH.LayMaKhachTiepTheo();
                            BLL_KHACH.ThemKhach(kh);
                        }


                        DTO_KHACH_HOPDONG khd = new DTO_KHACH_HOPDONG
                        {
                            MaKhach = kh.MaKhach,
                            MaHopDong = hopDong.MaHopDong
                        };

                        BLL_KHACH_HOPDONG.ThemKhachHopDong(khd);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_thongTinKhach_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = this.dgv_thongTinKhach.CurrentRow;

            if (dgvr != null)
            {
                if (dgvr.Cells["MAKHACH"].Value != null)    //  Khách cũ
                    this.btn_chinhSua.Enabled = false;
                else
                    this.btn_chinhSua.Enabled = true;       //  Khách mới
            }
        }

        private void cb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_thongTinKhach_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btn_tao.Enabled = true;
            LoadBalance();
        }


        private void LoadBalance()
        {
            int balance = int.Parse(lb_soLuongToiDa.Text) - int.Parse(lb_soLuongDangO.Text);

            if (this.dgv_thongTinKhach.RowCount == balance)
            {
                this.btn_themKhachMoi.Enabled = false;
                this.btn_chonKhachCu.Enabled = false;
            }
            else
            {
                this.btn_themKhachMoi.Enabled = true;
                this.btn_chonKhachCu.Enabled = true;
            }
        }

    }
}