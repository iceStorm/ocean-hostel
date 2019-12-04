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
    public partial class fDanhSachHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private DTO_HOADON hoaDon;

        public fDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void fDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_HOADON.LayDanhSachHoaDon();

            if (dt.Rows.Count == 0)
            {
                this.btn_thanhToan.Enabled = false;
                this.btn_xemChiTiet.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_thanhToan.Enabled = true;
                this.btn_xemChiTiet.Enabled = true;
                this.btn_xoa.Enabled = true;
            }


            this.gridControl_hoaDon.DataSource = dt;

            this.gridView_hoaDon.Columns["MAHOADON"].Visible = false;
            this.gridView_hoaDon.Columns["MAPHG"].Visible = false;

            this.gridView_hoaDon.Columns["TENPHG"].Caption = "Tên phòng";
            this.gridView_hoaDon.Columns["THANG"].Caption = "Tháng";
            this.gridView_hoaDon.Columns["NAM"].Caption = "Năm";

            this.gridView_hoaDon.Columns["TIENPHONG"].Caption = "Tiền phòng";
            this.gridView_hoaDon.Columns["TIENDICHVU"].Caption = "Tiền dịch vụ";
            this.gridView_hoaDon.Columns["TIENDIEN"].Caption = "Tiền điện";
            this.gridView_hoaDon.Columns["TIENNUOC"].Caption = "Tiền nước";
            this.gridView_hoaDon.Columns["TONGTIEN"].Caption = "Tổng tiền";
            this.gridView_hoaDon.Columns["DATHANHTOAN"].Caption = "Đã thanh toán";
        }

        private void gridView_hoaDon_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow dr = this.gridView_hoaDon.GetFocusedDataRow();

            DTO_HOADON hoaDonHienTai = new DTO_HOADON
            {
                MaHoaDon = (string)dr["MAHOADON"],
                MaPhong = (string)dr["MAPHG"],
                TenPhong = (string)dr["TENPHG"],
                Thang = (int)dr["THANG"],
                Nam = (int)dr["NAM"],
                TienPhong = (int)dr["TIENPHONG"],
                TienDien = (int)dr["TIENDIEN"],
                TienNuoc = (int)dr["TIENNUOC"],
                TienDichVu = (int)dr["TIENDICHVU"],
                TongTien = (int)dr["TONGTIEN"],
                DaThanhToan = dr["DATHANHTOAN"].ToString()
            };

            this.hoaDon = hoaDonHienTai;


            if (hoaDonHienTai.DaThanhToan == "True")
            {
                this.btn_thanhToan.Enabled = false;
            }
            else
            {
                this.btn_thanhToan.Enabled = true;
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format(@"Xác nhận thanh toán hoá đơn

Phòng: {0}
Tháng: {1}
Năm: {2}

Tiền phòng: {3:#,##0}
Tiền điện: {4:#,##0}
Tiền nước: {5:#,##0}
Tiền dịch vụ: {6:#,##0}

Tổng tiền: {7:#,##0}

",
this.hoaDon.TenPhong,
this.hoaDon.Thang,
this.hoaDon.Nam,
this.hoaDon.TienPhong,
this.hoaDon.TienDien,
this.hoaDon.TienNuoc,
this.hoaDon.TienDichVu,
this.hoaDon.TongTien);


                DialogResult dr = XtraMessageBox.Show(message,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    if (BLL_HOADON.ThanhToanHoaDon(this.hoaDon) == true)
                    {
                        XtraMessageBox.Show("Thanh toán thành công !", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xemChiTiet_Click(object sender, EventArgs e)
        {
            XtraForm FormChiTiet = new ChildrenForms.HoaDonChiTieu.DanhSachHoaDon.fChiTietHoaDon(this.hoaDon);
            FormChiTiet.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = XtraMessageBox.Show("Thông tin quan trọng, xác nhận xoá ?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    if (BLL_HOADON.XoaHoaDon(this.hoaDon) == true)
                    {
                        XtraMessageBox.Show("Xoá hoá đơn thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}