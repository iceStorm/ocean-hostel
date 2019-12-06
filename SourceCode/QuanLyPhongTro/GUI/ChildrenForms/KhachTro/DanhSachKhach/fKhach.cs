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

namespace GUI.ChildrenForms.KhachTro.DanhSachKhach
{
    public partial class fKhach : DevExpress.XtraEditors.XtraForm
    {
        public static bool isUpdated = false;

        public fKhach()
        {
            InitializeComponent();
        }

        private void fKhach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_KHACH.LayDanhSachKhach();

            if (dt.Rows.Count == 0)
            {
                this.btn_sua.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
            }


            this.gridControl_khach.DataSource = dt;
            this.gridView_khach.Columns["MAKHACH"].Visible = false;
            this.gridView_khach.Columns["MAPHG"].Visible = false;
            this.gridView_khach.Columns["MAHOPDONG"].Caption = "Mã hợp đồng";

            this.gridView_khach.Columns["HO"].Caption = "Họ";
            this.gridView_khach.Columns["TEN"].Caption = "Tên";
            this.gridView_khach.Columns["GIOITINH"].Caption = "Giới tính";
            this.gridView_khach.Columns["NGAYSINH"].Caption = "Ngày sinh";
            this.gridView_khach.Columns["QUEQUAN"].Caption = "Quê quán";
            this.gridView_khach.Columns["SOCANCUOC"].Caption = "Số căn cước";
            this.gridView_khach.Columns["SODIENTHOAI"].Caption = "Số điện thoại";
            this.gridView_khach.Columns["TRANGTHAI"].Caption = "Trạng thái ở";
            this.gridView_khach.Columns["TENPHG"].Caption = "Tên phòng";
            this.gridView_khach.Columns["TENPHG"].VisibleIndex = 0;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.KhachTro.DanhSachKhach.fAlter(LayKhachHienTai());
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_KHACH.XoaKhach(LayKhachHienTai()) == true)
                {
                    XtraMessageBox.Show("Xoá thông tin khách thành công !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_khach_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DTO_KHACH khachHienTai = LayKhachHienTai();

            if (khachHienTai.TrangThai == "Hết hợp đồng")
            {
                this.btn_xoa.Enabled = true;
            }
            else
            {
                this.btn_xoa.Enabled = false;
            }
        }

        private DTO_KHACH LayKhachHienTai()
        {
            DataRow dr = this.gridView_khach.GetFocusedDataRow();

            DTO_KHACH khach = new DTO_KHACH
            {
                MaKhach = (string)dr["MAKHACH"],
                Ho = (string)dr["HO"],
                Ten = (string)dr["TEN"],
                GioiTinh = (string)dr["GIOITINH"],
                NgaySinh = (DateTime)dr["NGAYSINH"],
                QueQuan = (string)dr["QUEQUAN"],
                SoCanCuoc = (string)dr["SOCANCUOC"],
                SoDienThoai = (string)dr["SODIENTHOAI"],
                TrangThai = (string)dr["TRANGTHAI"]
            };

            return khach;
        }

    }
}