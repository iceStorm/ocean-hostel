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

namespace GUI.ChildrenForms.QuanLyViPham.KhachViPham
{
    public partial class fKhachViPham : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;

        public fKhachViPham()
        {
            InitializeComponent();
        }

        private void fKhachViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_KHACH_VIPHAM.LayDanhSachKhachViPham();

            if (dt.Rows.Count == 0)
            {
                this.btn_xuLy.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_xuLy.Enabled = true;
                this.btn_xoa.Enabled = true;
            }

            this.gridControl_khachViPham.DataSource = dt;
            this.gridView_khachViPham.Columns["MAKHACH"].Visible = false;
            this.gridView_khachViPham.Columns["MAVIPHAM"].Visible = false;

            this.gridView_khachViPham.Columns["TENPHG"].Caption = "Tên phòng";
            this.gridView_khachViPham.Columns["NOIDUNG"].Caption = "Tên vi phạm";
            this.gridView_khachViPham.Columns["HOTEN"].Caption = "Họ và tên";
            this.gridView_khachViPham.Columns["THOIGIANVIPHAM"].Caption = "Thời điểm";
            this.gridView_khachViPham.Columns["DAGIAIQUYET"].Caption = "Đã xử lý";
            this.gridView_khachViPham.Columns["GHICHU"].Caption = "Ghi chú";

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyViPham.KhachViPham.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gridView_khachViPham.GetFocusedDataRow();

            DTO_KHACH_VIPHAM khachViPham = new DTO_KHACH_VIPHAM
            {
                MaViPham = (string)dr["MAVIPHAM"],
                MaKhach = (string)dr["MAKHACH"],
                ThoiGianViPham = (DateTime)dr["THOIGIANVIPHAM"]
            };


            try
            {
                if (BLL_KHACH_VIPHAM.XoaKhachViPham(khachViPham) == true)
                {
                    XtraMessageBox.Show("Xoá thông tin khách vi phạm thành công !",
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

        private void gridView_khachViPham_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow dr = this.gridView_khachViPham.GetFocusedDataRow();

            if (dr["DAGIAIQUYET"].ToString() == "True")
            {
                this.btn_xuLy.Enabled = false;
            }
            else
            {
                this.btn_xuLy.Enabled = true;
            }
        }

        private void btn_xuLy_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gridView_khachViPham.GetFocusedDataRow();

            DTO_KHACH_VIPHAM khachViPham = new DTO_KHACH_VIPHAM
            {
                MaViPham = (string)dr["MAVIPHAM"],
                MaKhach = (string)dr["MAKHACH"],
                ThoiGianViPham = (DateTime)dr["THOIGIANVIPHAM"]
            };


            try
            {
                if (BLL_KHACH_VIPHAM.XuLyViPham(khachViPham) == true)
                {
                    XtraMessageBox.Show("Cập nhật thông tin vi phạm thành công !",
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

    }
}