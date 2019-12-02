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
        public static DTO_KHACH khachTro;

        public fThemHopDong()
        {
            InitializeComponent();
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
            this.cb_phong.SelectedIndex = -1;
        }

        private void dgv_thongTinKhach_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgv_thongTinKhach.RowCount == 0)
            {
                this.btn_tao.Enabled = false;
                this.btn_chinhSua.Enabled = false;
            }
            else
            {
                this.btn_tao.Enabled = true;
                this.btn_chinhSua.Enabled = true;
            }
        }

        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = this.dgv_thongTinKhach.CurrentRow;

            khachTro = new DTO_KHACH();
            khachTro.Ho = (string)dr.Cells["HO"].Value;
            khachTro.Ten = (string)dr.Cells["TEN"].Value;
            khachTro.GioiTinh = (string)dr.Cells["GIOITINH"].Value;
            khachTro.NgaySinh = DateTime.Parse(dr.Cells["NGAYSINH"].Value.ToString());
            khachTro.QueQuan = (string)dr.Cells["QUEQUAN"].Value;
            khachTro.SoCanCuoc = (string)dr.Cells["CANCUOC"].Value;
            khachTro.SoDienThoai = (string)dr.Cells["DIENTHOAI"].Value;


            XtraForm FormThemKhach = new ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemThongTinKhach(LayDanhSachKhach(), khachTro);
            FormThemKhach.ShowDialog();


            if (khachTro != null)
            {
                dr.Cells["HO"].Value = khachTro.Ho;
                dr.Cells["TEN"].Value = khachTro.Ten;
                dr.Cells["GIOITINH"].Value = khachTro.GioiTinh;
                dr.Cells["NGAYSINH"].Value = khachTro.NgaySinh.ToShortDateString();
                dr.Cells["QUEQUAN"].Value = khachTro.QueQuan;
                dr.Cells["CANCUOC"].Value = khachTro.SoCanCuoc;
                dr.Cells["DIENTHOAI"].Value = khachTro.SoDienThoai;

                khachTro = null;
            }
        }


        private List<DTO_KHACH> LayDanhSachKhach()
        {
            List<DTO_KHACH> listKhach = new List<DTO_KHACH>();


            foreach (DataGridViewRow dr in this.dgv_thongTinKhach.Rows)
                listKhach.Add(new DTO_KHACH
                {
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


        private void btn_themKhachMoi_Click(object sender, EventArgs e)
        {
            XtraForm FormThemKhach = new ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemThongTinKhach(LayDanhSachKhach());
            FormThemKhach.ShowDialog();

            if (khachTro != null)
            {
                this.dgv_thongTinKhach.Rows.Add
                (
                    khachTro.Ho,
                    khachTro.Ten,
                    khachTro.GioiTinh,
                    khachTro.NgaySinh.ToShortDateString(),
                    khachTro.QueQuan,
                    khachTro.SoCanCuoc,
                    khachTro.SoDienThoai
                );

                this.btn_tao.Enabled = true;
                this.btn_chinhSua.Enabled = true;
                khachTro = null;
            }
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
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

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            foreach (DataGridViewRow dr in this.dgv_thongTinKhach.Rows)
            {
                khachTro = new DTO_KHACH
                {
                    MaKhach = BLL_KHACH.LayMaKhachTiepTheo(),
                    Ho = (string)dr.Cells["HO"].Value,
                    Ten = (string)dr.Cells["TEN"].Value,
                    GioiTinh = (string)dr.Cells["GIOITINH"].Value,
                    NgaySinh = DateTime.Parse(dr.Cells["NGAYSINH"].Value.ToString()),
                    QueQuan = (string)dr.Cells["QUEQUAN"].Value,
                    SoCanCuoc = (string)dr.Cells["CANCUOC"].Value,
                    SoDienThoai = (string)dr.Cells["DIENTHOAI"].Value
                };


                try
                {
                    BLL_KHACH.ThemKhach(khachTro);

                    DTO_KHACH_HOPDONG khachHopDong = new DTO_KHACH_HOPDONG
                    {
                        MaKhach = khachTro.MaKhach,
                        MaHopDong = hopDong.MaHopDong
                    };

                    BLL_KHACH_HOPDONG.ThemKhachHopDong(khachHopDong);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}